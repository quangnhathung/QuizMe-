using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuizMe
{
    public partial class EditInfomation : Form
    {
        private bool isDragging = false;
        private Point lastLocation;

        public EditInfomation()
        {
            InitializeComponent();
            LoadLop();
            txtMaSV.Text = UserStorage.Uid;
            txtHoTen.Text = UserStorage.Ten;
            dtpNgaySinh.Value = UserStorage.Dob ?? DateTime.Now;
        }

        private void LoadLop()
        {
            using (SqlConnection conn = Data.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id FROM Lop";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        cmbLop.Items.Clear();

                        while (rd.Read())
                        {
                            string id = rd["Id"].ToString();

                            cmbLop.Items.Add($"{id}");
                        }
                    }
                }
            }

            if (cmbLop.Items.Count > 0)
                cmbLop.SelectedIndex = 0;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X,
                    (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            home form = new home();
            this.Hide();
            form.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Lấy các giá trị từ form
            string uid = txtMaSV.Text?.Trim();
            if (string.IsNullOrWhiteSpace(uid))
            {
                MessageBox.Show("Mã sinh viên không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string ten = txtHoTen.Text?.Trim();
            if (string.IsNullOrWhiteSpace(ten))
            {
                MessageBox.Show("Vui lòng nhập Họ Tên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy MaLop từ cmbLop (hỗ trợ cả trường hợp bind DataSource hoặc add items)
            string maLop = null;
            if (cmbLop != null)
            {
                maLop = (cmbLop.SelectedValue != null) ? cmbLop.SelectedValue.ToString()
                       : (cmbLop.SelectedItem != null) ? cmbLop.SelectedItem.ToString()
                       : cmbLop.Text;
                if (string.IsNullOrWhiteSpace(maLop)) maLop = null;
            }

            // Lấy giới tính nếu control tồn tại (cmbGioiTinh hoặc txtGioiTinh)
            string gioiTinh = null;
            var cbs = this.Controls.Find("cmbGioiTinh", true);
            if (cbs.Length > 0 && cbs[0] is ComboBox cbG)
            {
                gioiTinh = (cbG.SelectedValue != null) ? cbG.SelectedValue.ToString()
                          : (cbG.SelectedItem != null) ? cbG.SelectedItem.ToString()
                          : cbG.Text;
                if (string.IsNullOrWhiteSpace(gioiTinh)) gioiTinh = null;
            }
            else
            {
                var tgs = this.Controls.Find("txtGioiTinh", true);
                if (tgs.Length > 0 && tgs[0] is TextBox tbG)
                {
                    gioiTinh = tbG.Text.Trim();
                    if (string.IsNullOrWhiteSpace(gioiTinh)) gioiTinh = null;
                }
            }

            // Lấy phone nếu có control txtPhone
            string phone = null;
            var phones = this.Controls.Find("txtPhone", true);
            if (phones.Length > 0 && phones[0] is TextBox tbPhone)
            {
                phone = tbPhone.Text.Trim();
                if (string.IsNullOrWhiteSpace(phone)) phone = null;
            }

            // Xử lý DateTimePicker: nếu có ShowCheckBox và unchecked => null, ngược lại lấy Value
            DateTime? ngaysinh = null;
            if (dtpNgaySinh != null)
            {
                try
                {
                    // nếu dtp có thuộc tính Checked (ShowCheckBox = true) và user bỏ unchecked => không lưu ngày
                    var prop = typeof(DateTimePicker).GetProperty("Checked");
                    if (prop != null)
                    {
                        bool checkedBox = (bool)prop.GetValue(dtpNgaySinh);
                        if (checkedBox)
                            ngaysinh = dtpNgaySinh.Value;
                        else
                            ngaysinh = null;
                    }
                    else
                    {
                        // không có Checked -> luôn lấy Value
                        ngaysinh = dtpNgaySinh.Value;
                    }
                }
                catch
                {
                    ngaysinh = dtpNgaySinh.Value;
                }
            }

            // Thực hiện UPDATE lên DB
            try
            {
                using (SqlConnection db = Data.GetConnection())
                {
                    db.Open();

                    string query = @"
                UPDATE Users
                SET Ten = @Ten,
                    GioiTinh = @GioiTinh,
                    Ngaysinh = @Ngaysinh,
                    MaLop = @MaLop,
                    Phone = @Phone
                WHERE Uid = @Uid";

                    using (SqlCommand cmd = new SqlCommand(query, db))
                    {
                        cmd.Parameters.AddWithValue("@Uid", uid);
                        cmd.Parameters.AddWithValue("@Ten", ten);

                        if (gioiTinh != null)
                            cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                        else
                            cmd.Parameters.AddWithValue("@GioiTinh", DBNull.Value);

                        if (ngaysinh.HasValue)
                            cmd.Parameters.AddWithValue("@Ngaysinh", ngaysinh.Value);
                        else
                            cmd.Parameters.AddWithValue("@Ngaysinh", DBNull.Value);

                        if (maLop != null)
                            cmd.Parameters.AddWithValue("@MaLop", maLop);
                        else
                            cmd.Parameters.AddWithValue("@MaLop", DBNull.Value);

                        if (phone != null)
                            cmd.Parameters.AddWithValue("@Phone", phone);
                        else
                            cmd.Parameters.AddWithValue("@Phone", DBNull.Value);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            MessageBox.Show("Cập nhật thông tin thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Cập nhật UserStorage (nếu bạn sử dụng)
                            UserStorage.Ten = ten;
                            UserStorage.MaLop = maLop;
                            UserStorage.Phone = phone;
                            UserStorage.Gender = gioiTinh;
                            UserStorage.Dob = ngaysinh;

                            // Nếu muốn đóng form hoặc quay về home, bạn có thể làm ở đây.
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy sinh viên để cập nhật (kiểm tra Uid).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật thông tin: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
