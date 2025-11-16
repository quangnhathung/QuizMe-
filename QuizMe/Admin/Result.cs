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
    public partial class Result : UserControl
    {
        public Result()
        {
            InitializeComponent();
        }

        private void ucResult_Load(object sender, EventArgs e)
        {
            LoadResultsData();
        }

        private void LoadResultsData()
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
                    MT.Name AS TenMonHoc,
                    KQ.LanThi,
                    KQ.Diem
                FROM Users U
                JOIN KetQua KQ ON U.Uid = KQ.MaSinhVien
                JOIN MonThi MT ON KQ.MaMon = MT.Id
                ORDER BY U.Uid, MT.Name, KQ.LanThi";

                    using (SqlCommand cmd = new SqlCommand(query, db))
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        dgvResults.Rows.Clear();

                        while (rd.Read())
                        {
                            dgvResults.Rows.Add(
                                rd["MaSinhVien"].ToString(),
                                rd["HoTen"].ToString(),
                                rd["TenMonHoc"].ToString(),
                                Convert.ToInt32(rd["LanThi"]),
                                Convert.ToDouble(rd["Diem"])
                            );
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải dữ liệu kết quả thi:\n{ex.Message}",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
