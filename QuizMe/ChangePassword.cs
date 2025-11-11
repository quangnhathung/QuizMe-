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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            using (SqlConnection db = Data.GetConnection())
            {
                string pass = txtPass.Text;
                string confirm_pass = txtConfirm.Text;
                string Id = (string)LocalStorage.GetFirst();
                LocalStorage.Clear();

                if (pass != confirm_pass)
                {
                    Utilities.MessageBoxError("Mật khẩu xác nhận không khớp!");
                    return;
                }

                string query = $"update Users set Password = '{pass}' where Uid = '{Id}'";
                SqlCommand cmd = new SqlCommand(query, db);

                db.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    Utilities.MessageBoxError("Đổi mật khẩu thành công!");
                    this.Hide();
                    new start().Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
