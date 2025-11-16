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

namespace QuizMe.Admin
{
    public partial class StudentList : UserControl
    {
        public StudentList()
        {
            InitializeComponent();
        }

        private void ucStudentList_Load(object sender, EventArgs e)
        {
            // Tải dữ liệu sinh viên khi UC được load
            LoadStudentData();
        }

        /// <summary>
        /// Tải dữ liệu sinh viên vào DataGridView.
        /// (Thay thế bằng logic CSDL thật của bạn)
        /// </summary>
        private void LoadStudentData()
        {
            try
            {
                using (SqlConnection db = Data.GetConnection())
                {
                    db.Open();

                    string query = @"
                SELECT 
                    U.Uid AS MaSinhVien,
                    U.Ten AS HoTen,
                    U.GioiTinh,
                    L.Id AS Lop,
                    COUNT(KQ.LanThi) AS SoLanThi,
                    AVG(KQ.Diem) AS DiemTrungBinh
                FROM Users U
                JOIN Lop L ON U.MaLop = L.Id
                JOIN KetQua KQ ON U.Uid = KQ.MaSinhVien
                WHERE U.Role = 'Student'
                GROUP BY 
                    U.Uid, U.Ten, U.GioiTinh, L.Id
                ORDER BY U.Uid";

                    using (SqlCommand cmd = new SqlCommand(query, db))
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        dgvStudents.Rows.Clear();

                        while (rd.Read())
                        {
                            dgvStudents.Rows.Add(
                                rd["MaSinhVien"].ToString(),
                                rd["HoTen"].ToString(),
                                rd["GioiTinh"].ToString(),
                                rd["Lop"].ToString(),
                                Convert.ToInt32(rd["SoLanThi"]),
                                Convert.ToDouble(rd["DiemTrungBinh"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi truy vấn dữ liệu sinh viên:\n{ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
