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
    public partial class Exercise : Form
    {
        //luu cau hoi tu db
        List<Question> questions = new List<Question>();

        // tong cau hoi
        private int _totalQuestions = SubjectStorage.CurrentSubject.SoCauHoi;
        private int _currentQuestionIndex = 0;

        // luu dap an nguoi dung 1=A,2=B,3=C,4=D
        private Dictionary<int, int> _userAnswers = new Dictionary<int, int>();

        // countdown
        private Timer examTimer;
        private int remainingSeconds = 0; // sẽ set mặc định trong constructor

        public Exercise()
        {
            InitializeComponent();

            
            examTimer = new Timer();
            examTimer.Interval = 1000; // 1 giây
            examTimer.Tick += ExamTimer_Tick;

            // Tinh thoi gian thi
            remainingSeconds = SubjectStorage.CurrentSubject.ThoiGianThi * 60;
            UpdateCountdownLabel();

       
            rbOptionA.CheckedChanged += rbOptionA_CheckedChanged;
            rbOptionB.CheckedChanged += rbOptionB_CheckedChanged;
            rbOptionC.CheckedChanged += rbOptionC_CheckedChanged;
            rbOptionD.CheckedChanged += rbOptionD_CheckedChanged;

            this.Load += frmExam_Load;

            LoadQuestionsFromDatabase();

            Load_info();
        }

        private void LoadQuestionsFromDatabase()
        {
            questions.Clear();
            try
            {
                using (SqlConnection db = Data.GetConnection())
                {
                    db.Open();
                    string query = $"select NoiDung,DapAn from CauHoi where MaMon='{SubjectStorage.CurrentSubject.MaMon}'";

                    using (SqlCommand cmd = new SqlCommand(query, db))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string raw = reader.GetString(0);
                                int dapAn = reader.GetInt32(1);

                                Question q = new Question(raw);
                                q.DapAn = dapAn;
                                questions.Add(q);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load câu hỏi: " + ex.Message);
            }
        }

        //load info hiện tại
        public void Load_info()
        {
            try
            {
                lbStudentName.Text = UserStorage.Ten;
                lbClass.Text = UserStorage.MaLop;
                lbSubject.Text = SubjectStorage.CurrentSubject.TenMonHoc;

                //lấy số lần thi tiếp theo
                int LanThi = 0;
                using (SqlConnection db = Data.GetConnection())
                {
                    db.Open();

                    string query = $"SELECT ISNULL(MAX(LanThi), 0) + 1 AS LanThiTiepTheo FROM KetQua WHERE MaSinhVien = '{UserStorage.Uid}' AND MaMon = '{SubjectStorage.CurrentSubject.MaMon}'";

                    using (SqlCommand cmd = new SqlCommand(query, db))
                    {
                        LanThi = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                lbLanthi.Text = LanThi.ToString();

                if (questions.Count < _totalQuestions)
                    _totalQuestions = questions.Count;

                if (questions.Count > 0)
                {
                    questions = Utilities.GetRandomElements(questions, _totalQuestions);
                    questions = Utilities.Shuffle(questions);
                }

                // Khởi tạo nút câu hỏi
                LoadQuestionButtons();

                // Khởi động bộ đếm
                examTimer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Load_info: " + ex.Message);
            }
        }

        private void frmExam_Load(object sender, EventArgs e)
        {
            // Tạo các nút bấm bên phải

            // Tải câu hỏi đầu tiên
            if (_totalQuestions > 0)
                LoadQuestion(_currentQuestionIndex);
            else
                MessageBox.Show("Không có câu hỏi để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadQuestion(int questionIndex)
        {
            if (questions == null || questions.Count == 0) return;
            if (questionIndex < 0 || questionIndex >= _totalQuestions) return;

            // câu hỏi
            lblQuestionText.Text = $"Câu {questionIndex + 1}. " + questions[questionIndex].CauHoi;

            // đáp án
            rbOptionA.Text = $"A. {(questions[questionIndex].LuaChon.Count > 0 ? questions[questionIndex].LuaChon[0] : "----")}";
            rbOptionB.Text = $"B. {(questions[questionIndex].LuaChon.Count > 1 ? questions[questionIndex].LuaChon[1] : "-----")}";
            rbOptionC.Text = $"C. {(questions[questionIndex].LuaChon.Count > 2 ? questions[questionIndex].LuaChon[2] : "-----")}";
            rbOptionD.Text = $"D. {(questions[questionIndex].LuaChon.Count > 3 ? questions[questionIndex].LuaChon[3] : "-----")}";

            lblCurrentQuestionInfo.Text = $"Câu {questionIndex + 1} / {_totalQuestions}";

            // Xóa chọn tất cả đáp án
            ClearAnswers();

            // Tô lại đáp án
            if (_userAnswers.ContainsKey(questionIndex))
            {
                int selected = _userAnswers[questionIndex];
                switch (selected)
                {
                    case 0: rbOptionA.Checked = true; break;
                    case 1: rbOptionB.Checked = true; break;
                    case 2: rbOptionC.Checked = true; break;
                    case 3: rbOptionD.Checked = true; break;
                }
            }

            // Cập nhật màu sắc nút bấm
            UpdateQuestionButtonStyles(questionIndex + 1);
        }

        // Tạo các nút bấm 1, 2, 3... bên phải
        private void LoadQuestionButtons()
        {
            flowQuestionButtons.Controls.Clear(); // Xóa các nút cũ

            for (int i = 1; i <= _totalQuestions; i++)
            {
                Button btn = new Button();
                btn.Text = i.ToString();
                btn.Size = new Size(40, 40);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderColor = Color.LightGray;
                btn.BackColor = Color.White;
                btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                btn.Tag = i;

                // Gán sự kiện Click
                btn.Click += QuestionButton_Click;

                flowQuestionButtons.Controls.Add(btn);
            }
        }

        private void QuestionButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int newIndex = (int)clickedButton.Tag - 1;

            _currentQuestionIndex = newIndex;

            LoadQuestion(_currentQuestionIndex);
        }

        private void UpdateQuestionButtonStyles(int currentQuestionNumber)
        {
            foreach (Control control in flowQuestionButtons.Controls)
            {
                if (control is Button btn)
                {
                    int btnNumber = (int)btn.Tag;
                    if (btnNumber == currentQuestionNumber)
                    {
                        //câu hỏi hiện tại
                        btn.BackColor = Color.FromArgb(30, 144, 255); // Màu xanh
                        btn.ForeColor = Color.White;
                    }
                    else if (_userAnswers.ContainsKey(btnNumber - 1))
                    {
                        // Đã trả lời
                        btn.BackColor = Color.LightGreen;
                        btn.ForeColor = Color.Black;
                    }
                    else
                    {
                        // Chưa trả lời
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void ClearAnswers()
        {
            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;
        }


        //submit
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int correctCount = 0;

            for (int i = 0; i < _totalQuestions; i++)
            {
                if (_userAnswers.ContainsKey(i))
                {
                    if (_userAnswers[i] == questions[i].DapAn)
                        correctCount++;
                }
            }

            double score = Math.Round((double)correctCount / _totalQuestions * 10, 2);

            DialogResult dr = MessageBox.Show(
                $"Vẫn còn thời gian\nXác nhận nộp bài?",
                "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                try
                {
                    SaveResultToDatabase(score);
                    MessageBox.Show($"Thí sinh:{UserStorage.Ten}\nMã số sinh viên:{UserStorage.Uid}\nBạn trả lời đúng {correctCount}/{_totalQuestions} câu.\nĐiểm: {score}\n", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Dừng timer và đóng form
                    if (examTimer != null && examTimer.Enabled) examTimer.Stop();

                    home homeForm = new home();
                    this.Hide();
                    homeForm.Show();
                }
                catch (Exception ex)
                {
                    Utilities.MessageBoxError("Lỗi khi lưu kết quả: " + ex.Message);
                }
            }
        }

        private void SaveResultToDatabase(double score)
        {
            using (SqlConnection db = Data.GetConnection())
            {
                db.Open();

                string query = $"INSERT INTO KetQua (MaSinhVien, MaMon, LanThi, Diem) VALUES ('{UserStorage.Uid}', '{SubjectStorage.CurrentSubject.MaMon}', {Convert.ToInt32(lbLanthi.Text)},{score} )";

                using (SqlCommand cmd = new SqlCommand(query, db))
                {
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex) { Utilities.MessageBoxError(ex.ToString()); }
                    
                }
            }
        }

        #region RadioButton CheckedChanged handlers
        private void rbOptionA_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOptionA.Checked)
            {
                _userAnswers[_currentQuestionIndex] = 1;
                UpdateQuestionButtonStyles(_currentQuestionIndex + 1);
            }
        }

        private void rbOptionB_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOptionB.Checked)
            {
                _userAnswers[_currentQuestionIndex] = 2;
                UpdateQuestionButtonStyles(_currentQuestionIndex + 1);
            }
        }

        private void rbOptionC_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOptionC.Checked)
            {
                _userAnswers[_currentQuestionIndex] = 3;
                UpdateQuestionButtonStyles(_currentQuestionIndex + 1);
            }
        }

        private void rbOptionD_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOptionD.Checked)
            {
                _userAnswers[_currentQuestionIndex] = 4;
                UpdateQuestionButtonStyles(_currentQuestionIndex + 1);
            }
        }
        #endregion

        #region Exam Timer
        private void ExamTimer_Tick(object sender, EventArgs e)
        {
            remainingSeconds--;
            UpdateCountdownLabel();

            if (remainingSeconds <= 0)
            {
                examTimer.Stop();
                MessageBox.Show("Hết thời gian làm bài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Tự động submit
                btnSubmit.PerformClick();
            }
        }

        private void UpdateCountdownLabel()
        {
            TimeSpan t = TimeSpan.FromSeconds(Math.Max(0, remainingSeconds));
            lbCountDown.Text = $"{t.Minutes:D2}:{t.Seconds:D2}";
        }
        #endregion

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (_currentQuestionIndex < _totalQuestions - 1)
            {
                _currentQuestionIndex++;
                LoadQuestion(_currentQuestionIndex);
            }
        }

        private void btnPrevious_Click_1(object sender, EventArgs e)
        {
            if (_currentQuestionIndex > 0)
            {
                _currentQuestionIndex--;
                LoadQuestion(_currentQuestionIndex);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
