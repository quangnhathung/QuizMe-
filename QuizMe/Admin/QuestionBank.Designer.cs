
namespace QuizMe.Admin
{
    partial class QuestionBank
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cmbSubjectFilter = new System.Windows.Forms.ComboBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.lblEditTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.cmbCorrectAnswer = new System.Windows.Forms.ComboBox();
            this.txtOptionD = new System.Windows.Forms.TextBox();
            this.lblOptionD = new System.Windows.Forms.Label();
            this.txtOptionC = new System.Windows.Forms.TextBox();
            this.lblOptionC = new System.Windows.Forms.Label();
            this.txtOptionB = new System.Windows.Forms.TextBox();
            this.lblOptionB = new System.Windows.Forms.Label();
            this.txtOptionA = new System.Windows.Forms.TextBox();
            this.lblOptionA = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.lblContent = new System.Windows.Forms.Label();
            this.cmbSubjectEdit = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAnswers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.btnDelete);
            this.pnlTop.Controls.Add(this.btnEdit);
            this.pnlTop.Controls.Add(this.btnAdd);
            this.pnlTop.Controls.Add(this.cmbSubjectFilter);
            this.pnlTop.Controls.Add(this.lblFilter);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(750, 60);
            this.pnlTop.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(647, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 30);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(561, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(80, 30);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(475, 15);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 30);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cmbSubjectFilter
            // 
            this.cmbSubjectFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjectFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjectFilter.FormattingEnabled = true;
            this.cmbSubjectFilter.Location = new System.Drawing.Point(120, 18);
            this.cmbSubjectFilter.Name = "cmbSubjectFilter";
            this.cmbSubjectFilter.Size = new System.Drawing.Size(250, 25);
            this.cmbSubjectFilter.TabIndex = 1;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilter.Location = new System.Drawing.Point(20, 21);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(94, 17);
            this.lblFilter.TabIndex = 0;
            this.lblFilter.Text = "Lọc theo môn:";
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.pnlEdit.Controls.Add(this.lblEditTitle);
            this.pnlEdit.Controls.Add(this.btnCancel);
            this.pnlEdit.Controls.Add(this.btnSave);
            this.pnlEdit.Controls.Add(this.lblCorrect);
            this.pnlEdit.Controls.Add(this.cmbCorrectAnswer);
            this.pnlEdit.Controls.Add(this.txtOptionD);
            this.pnlEdit.Controls.Add(this.lblOptionD);
            this.pnlEdit.Controls.Add(this.txtOptionC);
            this.pnlEdit.Controls.Add(this.lblOptionC);
            this.pnlEdit.Controls.Add(this.txtOptionB);
            this.pnlEdit.Controls.Add(this.lblOptionB);
            this.pnlEdit.Controls.Add(this.txtOptionA);
            this.pnlEdit.Controls.Add(this.lblOptionA);
            this.pnlEdit.Controls.Add(this.txtContent);
            this.pnlEdit.Controls.Add(this.lblContent);
            this.pnlEdit.Controls.Add(this.cmbSubjectEdit);
            this.pnlEdit.Controls.Add(this.lblSubject);
            this.pnlEdit.Controls.Add(this.txtID);
            this.pnlEdit.Controls.Add(this.lblID);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEdit.Location = new System.Drawing.Point(400, 60); // Đổi vị trí
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(350, 460); // Đổi kích thước
            this.pnlEdit.TabIndex = 1;
            this.pnlEdit.Visible = false; // Quan trọng: Ẩn ban đầu
            // 
            // lblEditTitle
            // 
            this.lblEditTitle.AutoSize = true;
            this.lblEditTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditTitle.Location = new System.Drawing.Point(20, 15);
            this.lblEditTitle.Name = "lblEditTitle";
            this.lblEditTitle.Size = new System.Drawing.Size(161, 21);
            this.lblEditTitle.TabIndex = 18;
            this.lblEditTitle.Text = "THÊM MỚI CÂU HỎI";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(243, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 30);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(157, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 30);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrect.Location = new System.Drawing.Point(21, 368);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(76, 15);
            this.lblCorrect.TabIndex = 14;
            this.lblCorrect.Text = "Đáp án đúng";
            // 
            // cmbCorrectAnswer
            // 
            this.cmbCorrectAnswer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCorrectAnswer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCorrectAnswer.FormattingEnabled = true;
            this.cmbCorrectAnswer.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.cmbCorrectAnswer.Location = new System.Drawing.Point(100, 365);
            this.cmbCorrectAnswer.Name = "cmbCorrectAnswer";
            this.cmbCorrectAnswer.Size = new System.Drawing.Size(223, 23);
            this.cmbCorrectAnswer.TabIndex = 15;
            // 
            // txtOptionD
            // 
            this.txtOptionD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionD.Location = new System.Drawing.Point(100, 335);
            this.txtOptionD.Name = "txtOptionD";
            this.txtOptionD.Size = new System.Drawing.Size(223, 23);
            this.txtOptionD.TabIndex = 13;
            // 
            // lblOptionD
            // 
            this.lblOptionD.AutoSize = true;
            this.lblOptionD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionD.Location = new System.Drawing.Point(21, 338);
            this.lblOptionD.Name = "lblOptionD";
            this.lblOptionD.Size = new System.Drawing.Size(56, 15);
            this.lblOptionD.TabIndex = 12;
            this.lblOptionD.Text = "Đáp án D";
            // 
            // txtOptionC
            // 
            this.txtOptionC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionC.Location = new System.Drawing.Point(100, 305);
            this.txtOptionC.Name = "txtOptionC";
            this.txtOptionC.Size = new System.Drawing.Size(223, 23);
            this.txtOptionC.TabIndex = 11;
            // 
            // lblOptionC
            // 
            this.lblOptionC.AutoSize = true;
            this.lblOptionC.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionC.Location = new System.Drawing.Point(21, 308);
            this.lblOptionC.Name = "lblOptionC";
            this.lblOptionC.Size = new System.Drawing.Size(55, 15);
            this.lblOptionC.TabIndex = 10;
            this.lblOptionC.Text = "Đáp án C";
            // 
            // txtOptionB
            // 
            this.txtOptionB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionB.Location = new System.Drawing.Point(100, 275);
            this.txtOptionB.Name = "txtOptionB";
            this.txtOptionB.Size = new System.Drawing.Size(223, 23);
            this.txtOptionB.TabIndex = 9;
            // 
            // lblOptionB
            // 
            this.lblOptionB.AutoSize = true;
            this.lblOptionB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionB.Location = new System.Drawing.Point(21, 278);
            this.lblOptionB.Name = "lblOptionB";
            this.lblOptionB.Size = new System.Drawing.Size(55, 15);
            this.lblOptionB.TabIndex = 8;
            this.lblOptionB.Text = "Đáp án B";
            // 
            // txtOptionA
            // 
            this.txtOptionA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOptionA.Location = new System.Drawing.Point(100, 245);
            this.txtOptionA.Name = "txtOptionA";
            this.txtOptionA.Size = new System.Drawing.Size(223, 23);
            this.txtOptionA.TabIndex = 7;
            // 
            // lblOptionA
            // 
            this.lblOptionA.AutoSize = true;
            this.lblOptionA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptionA.Location = new System.Drawing.Point(21, 248);
            this.lblOptionA.Name = "lblOptionA";
            this.lblOptionA.Size = new System.Drawing.Size(55, 15);
            this.lblOptionA.TabIndex = 6;
            this.lblOptionA.Text = "Đáp án A";
            // 
            // txtContent
            // 
            this.txtContent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContent.Location = new System.Drawing.Point(24, 150);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(299, 80);
            this.txtContent.TabIndex = 5;
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContent.Location = new System.Drawing.Point(21, 130);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(99, 15);
            this.lblContent.TabIndex = 4;
            this.lblContent.Text = "Nội dung câu hỏi";
            // 
            // cmbSubjectEdit
            // 
            this.cmbSubjectEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjectEdit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubjectEdit.FormattingEnabled = true;
            this.cmbSubjectEdit.Location = new System.Drawing.Point(100, 95);
            this.cmbSubjectEdit.Name = "cmbSubjectEdit";
            this.cmbSubjectEdit.Size = new System.Drawing.Size(223, 23);
            this.cmbSubjectEdit.TabIndex = 3;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(21, 98);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(57, 15);
            this.lblSubject.TabIndex = 2;
            this.lblSubject.Text = "Môn học";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(100, 60);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(223, 23);
            this.txtID.TabIndex = 1;
            this.txtID.Text = "[Tự động tạo]";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(21, 63);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(63, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Mã câu hỏi";
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.AllowUserToAddRows = false;
            this.dgvQuestions.AllowUserToDeleteRows = false;
            this.dgvQuestions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuestions.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colContent,
            this.colAnswers,
            this.colSubject});
            this.dgvQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuestions.Location = new System.Drawing.Point(0, 60);
            this.dgvQuestions.MultiSelect = false;
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvQuestions.Size = new System.Drawing.Size(400, 460); // Đổi kích thước
            this.dgvQuestions.TabIndex = 2;
            // 
            // colID
            // 
            this.colID.HeaderText = "Mã";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.FillWeight = 10F;
            // 
            // colContent
            // 
            this.colContent.HeaderText = "Nội dung";
            this.colContent.Name = "colContent";
            this.colContent.ReadOnly = true;
            this.colContent.FillWeight = 100F;
            // 
            // colAnswers
            // 
            this.colAnswers.HeaderText = "Đáp án";
            this.colAnswers.Name = "colAnswers";
            this.colAnswers.ReadOnly = true;
            this.colAnswers.FillWeight = 7F;
            // 
            // colSubject
            // 
            this.colSubject.HeaderText = "Môn học";
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            this.colSubject.FillWeight = 15F;
            // 
            // ucQuestionBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlTop);
            this.Name = "ucQuestionBank";
            this.Size = new System.Drawing.Size(750, 520);
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.ComboBox cmbSubjectFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.ComboBox cmbCorrectAnswer;
        private System.Windows.Forms.TextBox txtOptionD;
        private System.Windows.Forms.Label lblOptionD;
        private System.Windows.Forms.TextBox txtOptionC;
        private System.Windows.Forms.Label lblOptionC;
        private System.Windows.Forms.TextBox txtOptionB;
        private System.Windows.Forms.Label lblOptionB;
        private System.Windows.Forms.TextBox txtOptionA;
        private System.Windows.Forms.Label lblOptionA;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.ComboBox cmbSubjectEdit;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblEditTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAnswers;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
    }
}
