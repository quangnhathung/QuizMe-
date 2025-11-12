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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
            lbDob.Text = UserStorage.Dob?.ToString("dd/MM/yyyy") ?? "";
            lbMalop.Text = UserStorage.MaLop;
            LbUid.Text = UserStorage.Uid;
            lbGioitinh.Text = UserStorage.Gender;
            lblUserName.Text = UserStorage.Ten;

            //load tất cả môn học
            Load_Subject();

        }

        private void Load_Subject()
        {
            using (SqlConnection db = Data.GetConnection())
            {
                string query = $"Select Id, Name, SoCauHoi, ThoiGianThi from MonThi";
                SqlCommand cmd = new SqlCommand(query, db);

                db.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Subject Subject_item  = new Subject();
                        Subject_item.MaMon = reader["Id"].ToString();
                        Subject_item.TenMonHoc = reader["Name"].ToString();
                        Subject_item.SoCauHoi = Convert.ToInt32(reader["SoCauHoi"]);
                        Subject_item.ThoiGianThi = Convert.ToInt32(reader["ThoiGianThi"]);
                        SubjectStorage.Add(Subject_item);
                    }
                }

                cmbSubjects.DataSource = SubjectStorage.Subjects;
                cmbSubjects.DisplayMember = "TenMonHoc";
                cmbSubjects.ValueMember = "MaMon";
            }
        }

        private void lblUserEmail_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            UserStorage.Clear();
            start Form = new start();
            this.Hide();
            Form.Show();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
