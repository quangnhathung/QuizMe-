using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizMe;
using System.Data.SqlClient;

namespace QuizMe.Admin
{
    public partial class AdminHome : Form
    {

        public AdminHome()
        {
            InitializeComponent();
            var util = new home();


            SubjectStorage.Clear();
            using (SqlConnection db = Data.GetConnection())
            {
                string query = $"Select Id, Name, SoCauHoi, ThoiGianThi from MonThi";
                SqlCommand cmd = new SqlCommand(query, db);

                db.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    Subject all = new Subject();
                    all.MaMon = "00";
                    all.TenMonHoc = "All";
                    all.SoCauHoi = 0;
                    all.ThoiGianThi = 0;
                    SubjectStorage.Add(all);
                    while (reader.Read())
                    {
                        Subject Subject_item = new Subject();
                        Subject_item.MaMon = reader["Id"].ToString();
                        Subject_item.TenMonHoc = reader["Name"].ToString();
                        Subject_item.SoCauHoi = Convert.ToInt32(reader["SoCauHoi"]);
                        Subject_item.ThoiGianThi = Convert.ToInt32(reader["ThoiGianThi"]);
                        SubjectStorage.Add(Subject_item);
                    }
                }

            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserStorage.Clear();
            start Form = new start();
            this.Hide();
            Form.Show();
            this.Close();
        }

        private void btnQuestionBank_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "QUẢN LÝ NGÂN HÀNG CÂU HỎI";

            // Xóa nội dung cũ trong panel chính
            pnlMainContent.Controls.Clear();

            // Tạo một thể hiện (instance) của User Control
            QuestionBank uc = new QuestionBank();
            uc.Dock = DockStyle.Fill; // Tự động lấp đầy panel

            // Thêm User Control vào panel chính
            pnlMainContent.Controls.Add(uc);
        }
    }
}
