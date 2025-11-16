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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            start loginForm = new start();

            this.Close();
            loginForm.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection db = Data.GetConnection())
            {
                string Id = txtUsername.Text;
                string pass = txtPassword.Text;
                string name = txtName.Text;
                string connfirm_password = txtConfirmPassword.Text;
                if (!Id.All(c => char.IsDigit(c)))
                {
                    Utilities.MessageBoxWarning("Mã số sinh viên không hợp lệ!");
                    return;
                }

                if (pass != connfirm_password) {
                    Utilities.MessageBoxWarning("Mật khẩu xác nhận không khớp!");
                    return;
                }
                string query = $"insert into Users(Uid, Ten, Password) values ('{Id}','{name}' ,'{pass}')";
                SqlCommand cmd = new SqlCommand(query, db);

                db.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Đăng ký thành công!");
                    this.Hide();
                    new start().Show();
                }
                catch
                {
                    MessageBox.Show("Id đã tồn tại!");
                }
            }
        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {
           
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
