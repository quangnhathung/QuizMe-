using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using QuizMe.dto;
using System.Data.SqlClient;
using QuizMe.Storage;

namespace QuizMe.Internal.Admin
{

    public partial class StudentReport : Form
    {
        List<MonHoc> danhSachDiem;

        public StudentReport()
        {
            InitializeComponent();
            LoadData();
        }

        public List<MonHoc> GetDiemCaoNhatCuaSinhVien(string maSinhVien)
        {
            List<MonHoc> danhSachKetQua = new List<MonHoc>();

            string query = @"
        SELECT 
            m.Name AS TenMon,
            k.LanThi,
            k.Diem
        FROM KetQua k
        JOIN MonThi m ON k.MaMon = m.Id
        WHERE k.MaSinhVien = @MaSinhVien
        AND k.Diem = (
            -- Tìm điểm cao nhất của môn đó
            SELECT MAX(kq2.Diem) 
            FROM KetQua kq2 
            WHERE kq2.MaMon = k.MaMon AND kq2.MaSinhVien = @MaSinhVien
        )
        AND k.LanThi = (
            -- Nếu trùng điểm, lấy lần thi mới nhất
            SELECT MAX(kq3.LanThi)
            FROM KetQua kq3
            WHERE kq3.MaMon = k.MaMon 
              AND kq3.MaSinhVien = @MaSinhVien 
              AND kq3.Diem = k.Diem
        )";

            using (SqlConnection conn = Data.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaSinhVien", maSinhVien);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MonHoc kq = new MonHoc();

                                kq.TenMon = reader["TenMon"].ToString();

                                kq.LanThi = Convert.ToInt32(reader["LanThi"]);
                                kq.Diem = Convert.ToDouble(reader["Diem"]);

                                danhSachKetQua.Add(kq);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Utilities.MessageBoxError("Lỗi: " + ex.Message);
                }
            }

            return danhSachKetQua;
        }

        private void LoadData()
        {
            string queryInfo = "SELECT Uid, Ten, MaLop, Ngaysinh FROM Users WHERE Uid = @Uid";
            using (SqlConnection conn = Data.GetConnection())
            {
                try
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(queryInfo, conn))
                    {
                        cmd.Parameters.AddWithValue("@Uid", UserSearch.MaSv);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                lblValMSSV.Text = reader["Uid"].ToString();
                                lblValTen.Text = reader["Ten"].ToString();
                                lblValLop.Text = reader["MaLop"].ToString();

                                if (reader["Ngaysinh"] != DBNull.Value)
                                {
                                    lblValNgaySinh.Text = Convert.ToDateTime(reader["Ngaysinh"]).ToString("dd/MM/yyyy");
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Utilities.MessageBoxError("Lỗi: " + ex.Message);
                }
            }

            danhSachDiem = GetDiemCaoNhatCuaSinhVien(UserSearch.MaSv);


            dgvDiem.DataSource = danhSachDiem;

            dgvDiem.Columns["TenMon"].HeaderText = "Môn Học";
            dgvDiem.Columns["LanThi"].HeaderText = "Lần Thi";
            dgvDiem.Columns["Diem"].HeaderText = "Điểm Số";
            if (danhSachDiem.Count > 0)
            {
                double dtb = danhSachDiem.Average(x => x.Diem);
                lblValDTB.Text = Math.Round(dtb, 2).ToString();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ((Form)printPreviewDialog1).WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("Segoe UI", 22, FontStyle.Bold);
            Font headerFont = new Font("Segoe UI", 12, FontStyle.Bold);
            Font normalFont = new Font("Segoe UI", 12, FontStyle.Regular);

            Brush blackBrush = Brushes.Black;
            Brush blueBrush = Brushes.MidnightBlue;
            Pen linePen = new Pen(Color.Black, 1);

            int y = 50;
            int leftMargin = 50;
            int rightMargin = e.PageBounds.Width - 50;
            int pageWidth = e.PageBounds.Width;

            string title = "PHIẾU BÁO ĐIỂM";
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont);
            e.Graphics.DrawString(title, titleFont, blueBrush, (pageWidth - titleSize.Width) / 2, y);
            y += 70;

            e.Graphics.DrawString($"Mã Sinh Viên: {lblValMSSV.Text}", normalFont, blackBrush, leftMargin, y);
            e.Graphics.DrawString($"Lớp: {lblValLop.Text}", normalFont, blackBrush, pageWidth / 2 + 50, y);
            y += 35;
            e.Graphics.DrawString($"Họ và Tên: {lblValTen.Text}", headerFont, blackBrush, leftMargin, y);
            e.Graphics.DrawString($"Ngày sinh: {lblValNgaySinh.Text}", normalFont, blackBrush, pageWidth / 2 + 50, y);
            y += 50;


            int col1_X = leftMargin;
            int col2_X = pageWidth - 250;
            int col3_X = pageWidth - 100;

            e.Graphics.DrawLine(linePen, leftMargin, y, rightMargin, y);
            y += 10;
            e.Graphics.DrawString("Môn Học", headerFont, blackBrush, col1_X, y);
            e.Graphics.DrawString("Lần Thi", headerFont, blackBrush, col2_X, y);
            e.Graphics.DrawString("Điểm", headerFont, blackBrush, col3_X, y);
            y += 30;
            e.Graphics.DrawLine(linePen, leftMargin, y, rightMargin, y);
            y += 20;

            foreach (var mh in danhSachDiem)
            {
                e.Graphics.DrawString(mh.TenMon, normalFont, blackBrush, col1_X, y);

                e.Graphics.DrawString(mh.LanThi.ToString(), normalFont, blackBrush, col2_X + 20, y);
                e.Graphics.DrawString(mh.Diem.ToString("0.0"), normalFont, blackBrush, col3_X, y);

                y += 35;
            }

            y += 10;
            e.Graphics.DrawLine(linePen, leftMargin, y, rightMargin, y); 
            y += 30;

            string dtbStr = $"Điểm Trung Bình: {lblValDTB.Text}";
            e.Graphics.DrawString(dtbStr, new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Red, pageWidth - 300, y);

            y += 60;
            string dateFooter = $"Ngày {DateTime.Now.Day} tháng {DateTime.Now.Month} năm {DateTime.Now.Year}";
            e.Graphics.DrawString(dateFooter, new Font("Segoe UI", 10, FontStyle.Italic), Brushes.Gray, pageWidth - 300, y);
        }
    }
}