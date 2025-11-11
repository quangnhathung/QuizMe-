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
    public partial class Forgot : Form
    {
        public Forgot()
        {
            InitializeComponent();
        }

        private void linkBackToLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            start loginForm = new start();
            loginForm.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection db = Data.GetConnection())
            {
                string Id = txtUsername.Text;
                string phone = txtPhone.Text;



                if (!Id.All(c => char.IsDigit(c)))
                {
                    Utilities.MessageBoxWarning("Mã số sinh viên không hợp lệ!");
                    return;
                }

                if (!phone.All(c => char.IsDigit(c)))
                {
                    Utilities.MessageBoxWarning("Số điện thoại không hợp lệ!");
                    return;
                }

                string queryGetPhone = $"select Phone from Users where Uid='{Id}'";
                db.Open();
                SqlCommand command = new SqlCommand(queryGetPhone, db);

                var phone_auth = command.ExecuteScalar();
                string pa = "";

                if (phone_auth == null)
                {
                    Utilities.MessageBoxError("Mã số hoặc số điện thoại không tồn tại");
                    return;
                }
                else { pa = phone_auth.ToString(); }


                if (phone != pa)
                {
                    Utilities.MessageBoxError("Mã số hoặc số điện thoại không tồn tại");
                    return;
                }

                LocalStorage.Add(Id);

                ChangePassword form = new ChangePassword();
                this.Hide();
                form.Show();
            }
        }
    }
}
