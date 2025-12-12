using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using QuizMe.Internal.Admin;
using QuizMe.Storage;

namespace QuizMe.Admin
{
    public partial class StudentDetail : UserControl
    {

        // Biến để lưu mã sinh viên đang xem, dùng cho nút Report
        private string _currentMaSV = "";

        public StudentDetail()
        {
            InitializeComponent();
        }

        private void ucStudentDetail_Load(object sender, EventArgs e)
        {
            // Ẩn panel kết quả khi mới vào
            pnlResults.Visible = false;

            // Cho phép nhấn Enter để tìm kiếm
            txtSearchMaSV.KeyPress += (s, ev) =>
            {
                if (ev.KeyChar == (char)Keys.Enter)
                {
                    btnSearch.PerformClick();
                    ev.Handled = true; // Ngăn tiếng "beep"
                }
            };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string maSV = txtSearchMaSV.Text.Trim();
            if (string.IsNullOrWhiteSpace(maSV))
            {
                MessageBox.Show("Vui lòng nhập Mã Sinh Viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool studentFound = false;

            try
            {
                using (SqlConnection db = Data.GetConnection())
                {
                    db.Open();

                    // ===== 1. TÌM THÔNG TIN SINH VIÊN =====
                    string querySV = @"
                SELECT 
                    u.Uid,
                    u.Ten AS HoTen,
                    u.GioiTinh,
                    u.NgaySinh,
                    u.MaLop
                FROM Users u
                WHERE u.Uid = @MaSV";

                    using (SqlCommand cmd = new SqlCommand(querySV, db))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                studentFound = true;

                                lblHoTen.Text = rd["HoTen"]?.ToString() ?? "-----";
                                lblGioiTinh.Text = rd["GioiTinh"]?.ToString() ?? "-----";
                                lblMaLop.Text = rd["MaLop"]?.ToString() ?? "-----";

                                lblNgaySinh.Text = rd["NgaySinh"] == DBNull.Value
                                    ? "-----"
                                    : Convert.ToDateTime(rd["NgaySinh"]).ToString("dd/MM/yyyy");

                                _currentMaSV = maSV;
                                pnlResults.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                pnlResults.Visible = false;
                                dgvResults.Rows.Clear();
                                return;
                            }
                        }
                    }

                    if (studentFound)
                    {
                        UserSearch.MaSv = _currentMaSV;
                        string queryKQ = @"
                    SELECT 
                        m.Name,
                        k.LanThi,
                        k.Diem
                    FROM KetQua k
                    JOIN MonThi m ON m.Id = k.MaMon
                    WHERE k.MaSinhVien = @MaSV
                    ORDER BY m.Name, k.LanThi";

                        using (SqlCommand cmd2 = new SqlCommand(queryKQ, db))
                        {
                            cmd2.Parameters.AddWithValue("@MaSV", maSV);

                            using (SqlDataReader rd2 = cmd2.ExecuteReader())
                            {
                                dgvResults.Rows.Clear();

                                if (!rd2.HasRows)
                                {
                                    dgvResults.Rows.Add("Không có dữ liệu", "-", "-");
                                    return;
                                }

                                while (rd2.Read())
                                {
                                    dgvResults.Rows.Add(
                                        rd2["Name"].ToString(),
                                        rd2["LanThi"].ToString(),
                                        rd2["Diem"].ToString()
                                    );
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi xử lý: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(_currentMaSV))
            {
                StudentReport form = new StudentReport();
                form.Show();
                return;
            }
            else {
                Utilities.MessageBoxError("Không có sinh viên nào được chọn để tạo report.");
            }


        }
    }
}
