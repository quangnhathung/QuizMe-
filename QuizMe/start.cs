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

            // Khi form đăng ký đóng → hiện lại form đăng nhập
            registerForm.FormClosed += (s, args) => this.Show();

            this.Hide();   // ẩn form đăng nhập
            registerForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection db = Data.GetConnection();

            db.Open();
            string Id = txtUsername.Text;
            string pass = txtPassword.Text;

            string query = $"Select * from Users where Uid = '{Id}' and Password = '{pass}'";
            SqlCommand cmd = new SqlCommand(query, db);
            SqlDataReader reader = cmd.ExecuteReader(); if (reader.Read())
            {
                string tenUser = reader["Ten"].ToString();
                string role = reader["Role"].ToString();

                MessageBox.Show("Đăng nhập thành công! Xin chào " + tenUser);
                //home main = new home(); // ví dụ mở form chính
                //main.Show();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
            }
            db.Close();
        }
    }
}
