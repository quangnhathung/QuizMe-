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
    public partial class QuestionBank : UserControl
    {
        List<Question> questions = new List<Question>();

        public QuestionBank()
        {
            InitializeComponent();
            dgvQuestions.RowHeadersVisible = false;

            // Ngăn SelectedIndexChanged chạy sớm
            cmbSubjectFilter.SelectedIndexChanged -= cmbSubjectFilter_SelectedIndexChanged;

            // Load danh sách môn (đã có "All" trong SubjectStorage.Subjects)
            cmbSubjectFilter.DataSource = SubjectStorage.Subjects;
            cmbSubjectFilter.DisplayMember = "TenMonHoc";
            cmbSubjectFilter.ValueMember = "MaMon";

            // Gắn lại event
            cmbSubjectFilter.SelectedIndexChanged += cmbSubjectFilter_SelectedIndexChanged;

            List<Subject> list = new List<Subject>();

            list = SubjectStorage.Subjects.Skip(1).Take(SubjectStorage.Subjects.Count - 1).ToList();

            cmbSubjectEdit.DataSource = list;
            cmbSubjectEdit.DisplayMember = "TenMonHoc";
            cmbSubjectEdit.ValueMember = "MaMon";

            //List<string> optionList = new List<string> { "A", "B", "C", "D" };

            //cmbCorrectAnswer.Items.AddRange(optionList.ToArray());


            // Load lần đầu
            LoadQuestions();
            ReloadGrid();
        }

        private void LoadQuestions()
        {
            questions = new List<Question>(); // reset list

            try
            {
                using (SqlConnection db = Data.GetConnection())
                {
                    db.Open();
                    string query = "select CauHoi.Id, NoiDung, DapAn, Name from CauHoi, MonThi where CauHoi.MaMon = MonThi.Id";

                    using (SqlCommand cmd = new SqlCommand(query, db))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string ma = reader.GetString(0);
                            string raw = reader.GetString(1);
                            int dapAn = reader.GetInt32(2);
                            string tenmon = reader.GetString(3);

                            Question q = new Question(raw);
                            q.DapAn = dapAn;
                            q.Mon = tenmon;      // tên môn
                            q.Macauhoi = ma;

                            questions.Add(q);
                        }
                    }
                    questions = questions.OrderBy(i => i.Mon).ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load câu hỏi: " + ex.Message);
            }
        }

        private void ReloadGrid()
        {
            dgvQuestions.Rows.Clear();
            questions = questions.OrderBy(i => i.Mon).ToList();
            foreach (var item in questions)
            {
                string content = item.CauHoi + "_";
                foreach (var i in item.LuaChon)
                    content += i + "|";

                dgvQuestions.Rows.Add(item.Macauhoi, content, item.DapAn, item.Mon);
            }
        }

        private void cmbSubjectFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadQuestions();   // Load toàn bộ

            string tenMon = cmbSubjectFilter.Text;

            if (tenMon != "All")
            {
                // lọc theo tên môn vì bạn đang lưu q.Mon = tenmon (tên môn)
                questions = questions.Where(q => q.Mon == tenMon).ToList();
            }

            ReloadGrid();
        }

        #region Xử lý nút chức năng (Thêm, Sửa, Xóa)

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ClearEditPanel();
            lblEditTitle.Text = "THÊM MỚI CÂU HỎI";
            //txtID.Text = "[Tự động tạo]";
            pnlEdit.Visible = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.SelectedRows.Count == 0)
            {
                Utilities.MessageBoxWarning("Vui lòng chọn một câu hỏi để sửa.");
                return;
            }

            DataGridViewRow selectedRow = dgvQuestions.SelectedRows[0];
            string id = selectedRow.Cells["colID"].Value.ToString();
            string content = selectedRow.Cells["colContent"].Value.ToString();
            string answer = selectedRow.Cells["colAnswers"].Value.ToString();
            string subject = selectedRow.Cells["colSubject"].Value.ToString();

            lblEditTitle.Text = "SỬA CÂU HỎI";
            txtID.Text = id;
            cmbSubjectEdit.SelectedItem = subject;

            switch (answer)
            {
                case "1":
                    cmbCorrectAnswer.SelectedItem = "A";
                    break;
                case "2":
                    cmbCorrectAnswer.SelectedItem = "A";
                    break;
                case "3":
                    cmbCorrectAnswer.SelectedItem = "A";
                    break;
                case "4":
                    cmbCorrectAnswer.SelectedItem = "A";
                    break;
            }

            // Đổ lên form

            Question temp = new Question(content);
            txtOptionA.Text = temp.LuaChon[0];
            txtOptionB.Text = temp?.LuaChon[1] ?? "";
            txtOptionC.Text = temp?.LuaChon[2] ?? "";
            txtOptionD.Text = temp?.LuaChon[3] ?? "";

            txtContent.Text = temp.CauHoi;

            pnlEdit.Visible = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvQuestions.SelectedRows.Count == 0)
            {
                Utilities.MessageBoxWarning("Vui lòng chọn một câu hỏi để xóa.");
                return;
            }

            // Lấy ID của câu hỏi được chọn
            string id = dgvQuestions.SelectedRows[0].Cells["colID"].Value.ToString();

            // Lấy nội dung để hiển thị confirm
            string questionContent = dgvQuestions.SelectedRows[0].Cells["colContent"].Value.ToString();

            DialogResult dr = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa câu hỏi:\n{questionContent} ?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dr != DialogResult.Yes) return;

            try
            {
                using (SqlConnection db = Data.GetConnection())
                {
                    db.Open();
                    string query = "DELETE FROM CauHoi WHERE Id = @id";

                    using (SqlCommand cmd = new SqlCommand(query, db))
                    {
                        cmd.Parameters.AddWithValue("@id", id);

                        int rows = cmd.ExecuteNonQuery();

                        if (rows > 0)
                        {
                            Utilities.MessageBoxInfor("Xóa thành công!");
                        }
                        else
                        {
                            Utilities.MessageBoxWarning("Không tìm thấy câu hỏi để xóa.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Utilities.MessageBoxError("Lỗi khi xóa: " + ex.Message);
            }

            LoadQuestions();
            ReloadGrid();
        }

        #endregion

        #region Panel Nhập liệu (Lưu, Hủy)

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string id = txtID.Text.Trim();
                bool isNew = string.IsNullOrEmpty(id);

                if (isNew)
                {
                    id = Utilities.GenerateNewQuestionId();
                }

                id = id.Trim();
                string noiDung = txtContent.Text.Trim();
                string dapAnA = txtOptionA.Text.Trim();
                string dapAnB = txtOptionB.Text.Trim();
                string dapAnC = txtOptionC.Text.Trim();
                string dapAnD = txtOptionD.Text.Trim();

                // Đáp án
                string correct = cmbCorrectAnswer.SelectedItem.ToString(); // "A", "B", "C", "D"
                int dapAnNumber = "ABCD".IndexOf(correct) + 1;

                // Môn học
                string maMon = cmbSubjectEdit.SelectedValue.ToString();

                // Format nội dung
                string noiDungFull = $"{noiDung}_{dapAnA}|{dapAnB}|{dapAnC}|{dapAnD}";

                using (SqlConnection db = Data.GetConnection())
                {
                    db.Open();

                    string checkQuery = "SELECT COUNT(*) FROM CauHoi WHERE Id = @Id";
                    bool exists = false;

                    using (SqlCommand checkCmd = new SqlCommand(checkQuery, db))
                    {
                        Console.WriteLine(id);
                        checkCmd.Parameters.Add("@Id", SqlDbType.Char, 5).Value = id;
                        exists = (int)checkCmd.ExecuteScalar() > 0;
                    }

                    string query;

                    if (exists)
                    {
                        query = @"UPDATE CauHoi 
                          SET NoiDung = @NoiDung,
                              DapAn = @DapAn,
                              MaMon = @MaMon
                          WHERE Id = @Id";
                    }
                    else
                    {
                        query = @"INSERT INTO CauHoi (Id, NoiDung, DapAn, MaMon)
                          VALUES (@Id, @NoiDung, @DapAn, @MaMon)";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, db))
                    {
                        Console.WriteLine(id);
                        cmd.Parameters.Add("@Id", SqlDbType.Char, 5).Value = id;

                        cmd.Parameters.AddWithValue("@NoiDung", noiDungFull);
                        cmd.Parameters.AddWithValue("@DapAn", dapAnNumber);
                        cmd.Parameters.AddWithValue("@MaMon", maMon);

                        cmd.ExecuteNonQuery();
                    }
                }

                // Thông báo
                Utilities.MessageBoxInfor("Done!");

                LoadQuestions();
                ReloadGrid();
                pnlEdit.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu câu hỏi: " + ex.Message);
            }
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }

        private void ClearEditPanel()
        {
            txtID.Text = "";
            cmbSubjectEdit.SelectedIndex = 0;
            txtContent.Text = "";
            txtOptionA.Text = "";
            txtOptionB.Text = "";
            txtOptionC.Text = "";
            txtOptionD.Text = "";
            cmbCorrectAnswer.SelectedIndex = 0;
        }

        #endregion

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
        }
    }
}
