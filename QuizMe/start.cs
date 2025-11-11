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
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            Register registerForm = new Register();
            registerForm.FormClosed += (s, args) => this.Show();
            this.Hide();
            registerForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (SqlConnection db = Data.GetConnection())
            {
                string Id = txtUsername.Text;
                string pass = txtPassword.Text;
                if (!Id.All(c => char.IsDigit(c)))
                {
                    Utilities.MessageBoxWarning("Mã số sinh viên không hợp lệ!");
                    return;
                }

                string query = $"Select * from Users where Uid = '{Id}' and Password = '{pass}'";
                SqlCommand cmd = new SqlCommand(query, db);

                db.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        UserStorage.Uid = reader["Uid"].ToString();
                        UserStorage.Ten = reader["Ten"].ToString();
                        UserStorage.Role = reader["Role"].ToString();
                        UserStorage.Gender = reader["GioiTinh"].ToString();
                        UserStorage.Phone = reader["Phone"].ToString();
                        UserStorage.Dob = reader["Ngaysinh"] as DateTime?;

                        if (UserStorage.Role == "Student")
                        {
                            home HomeForm = new home();
                            HomeForm.Show();
                            this.Hide();
                        }
                        else Utilities.MessageBoxInfor($"{UserStorage.Role} User hiện tại thuộc admin hoặc giảng viên!");
                        

                    }
                    else
                    {
                        Utilities.MessageBoxError("Sai tài khoản hoặc mật khẩu!");
                    }
                }

            }
        }

        private void lblinkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forgot Form = new Forgot();
            Form.FormClosed += (s, args) => this.Show();
            this.Hide();
            Form.Show();
        }
    }
}
