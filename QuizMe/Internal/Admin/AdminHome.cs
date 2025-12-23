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
using QuizMe.dto;

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

        private void btnViewStudents_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "TRA CỨU SINH VIÊN";

            // Xóa nội dung cũ trong panel chính
            pnlMainContent.Controls.Clear();

            // Tạo một thể hiện (instance) của User Control
            StudentDetail uc = new StudentDetail();
            uc.Dock = DockStyle.Fill; // Tự động lấp đầy panel

            // Thêm User Control vào panel chính
            pnlMainContent.Controls.Add(uc);
        }

        private void btnDsSinhvien_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "DANH SÁCH SINH VIÊN";

            // Xóa nội dung cũ trong panel chính
            pnlMainContent.Controls.Clear();

            // Tạo một thể hiện (instance) của User Control mới
            StudentList uc = new StudentList();
            uc.Dock = DockStyle.Fill; // Tự động lấp đầy panel

            // Thêm User Control vào panel chính
            pnlMainContent.Controls.Add(uc);
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            lblHeaderTitle.Text = "DANH SÁCH KẾT QUẢ THI";

            // Xóa nội dung cũ trong panel chính
            pnlMainContent.Controls.Clear();

            // Tạo một thể hiện (instance) của User Control mới
            Result uc = new Result();
            uc.Dock = DockStyle.Fill; // Tự động lấp đầy panel

            // Thêm User Control vào panel chính
            pnlMainContent.Controls.Add(uc);
        }

        public BackupResult RunBackup(string path, string fileName, string mode)
        {
            BackupResult result = new BackupResult();

            using (SqlConnection conn = Data.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_System_BackupManager", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.CommandTimeout = 130;

                        cmd.Parameters.AddWithValue("@Path", path);
                        cmd.Parameters.AddWithValue("@FileName", fileName);
                        cmd.Parameters.AddWithValue("@Mode", mode);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result.Success = Convert.ToBoolean(reader["Success"]);
                                result.Message = reader["Message"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    result.Success = false;
                    result.Message = "Lỗi hệ thống: " + ex.Message;
                }
            }

            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"D:\";
            string fileName = $"Backup_Full_{DateTime.Now:yyyyMMdd_HHmmss}.bak";

            string mode = "";

            if (radioButton1.Checked == true)
            {
                mode = "FULL";
            }
            else if (radioButton2.Checked == true)
            {
                mode = "DIFF";
            }

            var result = RunBackup(path, fileName, mode);

            if (result.Success)
            {
                MessageBox.Show(result.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fileChoooser_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn file";
                ofd.Filter = "Backup Files (*.bak)|*.bak|All Files (*.*)|*.*";
                ofd.FilterIndex = 1;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string path = ofd.FileName;
                    pathRestore.Text = path; 
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public static void SetupRestoreProcedure()
        {
            string query = @"
        CREATE OR ALTER PROCEDURE sp_System_RestoreManager
            @FullPath NVARCHAR(400)
        AS
        BEGIN
            SET NOCOUNT ON;

            DECLARE 
                @Success BIT = 0,
                @Message NVARCHAR(500);

            BEGIN TRY
                -- 1. Ngắt kết nối người dùng khác
                IF EXISTS (SELECT name FROM sys.databases WHERE name = N'quizme_db')
                BEGIN
                    ALTER DATABASE [quizme_db] 
                    SET SINGLE_USER 
                    WITH ROLLBACK IMMEDIATE;
                END

                -- 2. Restore
                RESTORE DATABASE [quizme_db]
                FROM DISK = @FullPath
                WITH FILE = 1,      
                     REPLACE,        
                     RECOVERY;      

                -- 3. Mở lại kết nối
                ALTER DATABASE [quizme_db] SET MULTI_USER;

                SET @Success = 1;
                SET @Message = N'Restore thành công từ file: ' + @FullPath;
            END TRY
            BEGIN CATCH
                SET @Success = 0;
                SET @Message = N'Lỗi Restore: ' + ERROR_MESSAGE();

                BEGIN TRY
                    ALTER DATABASE [quizme_db] SET MULTI_USER;
                END TRY
                BEGIN CATCH
                END CATCH
            END CATCH;

            SELECT @Success AS Success, @Message AS Message;
        END;
    "; 

            using (SqlConnection conn = Data.GetMasterConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Lỗi cài đặt Proc Restore: " + ex.Message);
                }
            }
        }

        public RestoreResult RestoreDatabase(string fullFilePath)
        {
            RestoreResult result = new RestoreResult();
            SetupRestoreProcedure();

            using (SqlConnection conn = Data.GetMasterConnection())
            {
                try
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("sp_System_RestoreManager", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.CommandTimeout = 120;

                        cmd.Parameters.AddWithValue("@FullPath", fullFilePath);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                result.Success = Convert.ToBoolean(reader["Success"]);
                                result.Message = reader["Message"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    result.Success = false;
                    result.Message = "Lỗi kết nối C#: " + ex.Message;
                }
            }
            return result;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (pathRestore.Text == "") {
                Utilities.MessageBoxInfor("Vui long chon file restore!");
                return;
            }
            var result = RestoreDatabase(pathRestore.Text);

            if (result.Success)
            {
                MessageBox.Show(result.Message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(result.Message, "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
