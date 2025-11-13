
namespace QuizMe
{
    partial class Exercise
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbLanthi = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbCountDown = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lbClass = new System.Windows.Forms.Label();
            this.lbSubject = new System.Windows.Forms.Label();
            this.lbStudentName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurrentQuestionInfo = new System.Windows.Forms.Label();
            this.lblUserInfo = new System.Windows.Forms.Label();
            this.pnlQuestionNav = new System.Windows.Forms.Panel();
            this.flowQuestionButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.lblNavTitle = new System.Windows.Forms.Label();
            this.pnlMainContent = new System.Windows.Forms.Panel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.flowOptions = new System.Windows.Forms.FlowLayoutPanel();
            this.rbOptionA = new System.Windows.Forms.RadioButton();
            this.rbOptionB = new System.Windows.Forms.RadioButton();
            this.rbOptionC = new System.Windows.Forms.RadioButton();
            this.rbOptionD = new System.Windows.Forms.RadioButton();
            this.lblQuestionText = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlQuestionNav.SuspendLayout();
            this.pnlMainContent.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.flowOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.pnlHeader.Controls.Add(this.lbLanthi);
            this.pnlHeader.Controls.Add(this.label8);
            this.pnlHeader.Controls.Add(this.lbCountDown);
            this.pnlHeader.Controls.Add(this.btnSubmit);
            this.pnlHeader.Controls.Add(this.lbClass);
            this.pnlHeader.Controls.Add(this.lbSubject);
            this.pnlHeader.Controls.Add(this.lbStudentName);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lblCurrentQuestionInfo);
            this.pnlHeader.Controls.Add(this.lblUserInfo);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(4);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1365, 170);
            this.pnlHeader.TabIndex = 0;
            // 
            // lbLanthi
            // 
            this.lbLanthi.AutoSize = true;
            this.lbLanthi.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLanthi.ForeColor = System.Drawing.Color.White;
            this.lbLanthi.Location = new System.Drawing.Point(743, 112);
            this.lbLanthi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLanthi.Name = "lbLanthi";
            this.lbLanthi.Size = new System.Drawing.Size(114, 41);
            this.lbLanthi.TabIndex = 10;
            this.lbLanthi.Text = "--------";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(632, 109);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 41);
            this.label8.TabIndex = 9;
            this.label8.Text = "Lần thi:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // lbCountDown
            // 
            this.lbCountDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCountDown.AutoSize = true;
            this.lbCountDown.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountDown.ForeColor = System.Drawing.Color.White;
            this.lbCountDown.Location = new System.Drawing.Point(900, 35);
            this.lbCountDown.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCountDown.Name = "lbCountDown";
            this.lbCountDown.Size = new System.Drawing.Size(120, 51);
            this.lbCountDown.TabIndex = 8;
            this.lbCountDown.Text = "00:00";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmit.BackColor = System.Drawing.Color.Red;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(1120, 61);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(173, 49);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "NỘP BÀI";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lbClass
            // 
            this.lbClass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClass.ForeColor = System.Drawing.Color.White;
            this.lbClass.Location = new System.Drawing.Point(285, 71);
            this.lbClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClass.Name = "lbClass";
            this.lbClass.Size = new System.Drawing.Size(187, 28);
            this.lbClass.TabIndex = 7;
            this.lbClass.Text = "--------";
            // 
            // lbSubject
            // 
            this.lbSubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubject.ForeColor = System.Drawing.Color.White;
            this.lbSubject.Location = new System.Drawing.Point(285, 122);
            this.lbSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubject.Name = "lbSubject";
            this.lbSubject.Size = new System.Drawing.Size(227, 28);
            this.lbSubject.TabIndex = 6;
            this.lbSubject.Text = "--------";
            // 
            // lbStudentName
            // 
            this.lbStudentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentName.ForeColor = System.Drawing.Color.White;
            this.lbStudentName.Location = new System.Drawing.Point(285, 17);
            this.lbStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStudentName.Name = "lbStudentName";
            this.lbStudentName.Size = new System.Drawing.Size(227, 28);
            this.lbStudentName.TabIndex = 5;
            this.lbStudentName.Text = "-------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(185, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lớp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(185, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Môn thi:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::QuizMe.Properties.Resources.Avatar;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblCurrentQuestionInfo
            // 
            this.lblCurrentQuestionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCurrentQuestionInfo.AutoSize = true;
            this.lblCurrentQuestionInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentQuestionInfo.ForeColor = System.Drawing.Color.White;
            this.lblCurrentQuestionInfo.Location = new System.Drawing.Point(882, 109);
            this.lblCurrentQuestionInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCurrentQuestionInfo.Name = "lblCurrentQuestionInfo";
            this.lblCurrentQuestionInfo.Size = new System.Drawing.Size(159, 41);
            this.lblCurrentQuestionInfo.TabIndex = 1;
            this.lblCurrentQuestionInfo.Text = "Câu 1 / 40";
            // 
            // lblUserInfo
            // 
            this.lblUserInfo.AutoSize = true;
            this.lblUserInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserInfo.ForeColor = System.Drawing.Color.White;
            this.lblUserInfo.Location = new System.Drawing.Point(185, 17);
            this.lblUserInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserInfo.Name = "lblUserInfo";
            this.lblUserInfo.Size = new System.Drawing.Size(92, 28);
            this.lblUserInfo.TabIndex = 0;
            this.lblUserInfo.Text = "Thí sinh:";
            // 
            // pnlQuestionNav
            // 
            this.pnlQuestionNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.pnlQuestionNav.Controls.Add(this.flowQuestionButtons);
            this.pnlQuestionNav.Controls.Add(this.lblNavTitle);
            this.pnlQuestionNav.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlQuestionNav.Location = new System.Drawing.Point(1032, 170);
            this.pnlQuestionNav.Margin = new System.Windows.Forms.Padding(4);
            this.pnlQuestionNav.Name = "pnlQuestionNav";
            this.pnlQuestionNav.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.pnlQuestionNav.Size = new System.Drawing.Size(333, 677);
            this.pnlQuestionNav.TabIndex = 1;
            // 
            // flowQuestionButtons
            // 
            this.flowQuestionButtons.AutoScroll = true;
            this.flowQuestionButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowQuestionButtons.Location = new System.Drawing.Point(13, 52);
            this.flowQuestionButtons.Margin = new System.Windows.Forms.Padding(4);
            this.flowQuestionButtons.Name = "flowQuestionButtons";
            this.flowQuestionButtons.Size = new System.Drawing.Size(307, 613);
            this.flowQuestionButtons.TabIndex = 1;
            // 
            // lblNavTitle
            // 
            this.lblNavTitle.AutoSize = true;
            this.lblNavTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNavTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNavTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNavTitle.Location = new System.Drawing.Point(13, 12);
            this.lblNavTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNavTitle.Name = "lblNavTitle";
            this.lblNavTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.lblNavTitle.Size = new System.Drawing.Size(185, 40);
            this.lblNavTitle.TabIndex = 0;
            this.lblNavTitle.Text = "Danh sách câu hỏi";
            // 
            // pnlMainContent
            // 
            this.pnlMainContent.BackColor = System.Drawing.Color.White;
            this.pnlMainContent.Controls.Add(this.pnlFooter);
            this.pnlMainContent.Controls.Add(this.flowOptions);
            this.pnlMainContent.Controls.Add(this.lblQuestionText);
            this.pnlMainContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainContent.Location = new System.Drawing.Point(0, 170);
            this.pnlMainContent.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMainContent.Name = "pnlMainContent";
            this.pnlMainContent.Padding = new System.Windows.Forms.Padding(40, 37, 40, 37);
            this.pnlMainContent.Size = new System.Drawing.Size(1032, 677);
            this.pnlMainContent.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.btnNext);
            this.pnlFooter.Controls.Add(this.btnPrevious);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(40, 550);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(952, 90);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Location = new System.Drawing.Point(511, 16);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(160, 49);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Câu tiếp >>";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click_1);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPrevious.FlatAppearance.BorderSize = 0;
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.Color.Black;
            this.btnPrevious.Location = new System.Drawing.Point(312, 16);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(160, 49);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<< Câu trước";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click_1);
            // 
            // flowOptions
            // 
            this.flowOptions.Controls.Add(this.rbOptionA);
            this.flowOptions.Controls.Add(this.rbOptionB);
            this.flowOptions.Controls.Add(this.rbOptionC);
            this.flowOptions.Controls.Add(this.rbOptionD);
            this.flowOptions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowOptions.Location = new System.Drawing.Point(40, 132);
            this.flowOptions.Margin = new System.Windows.Forms.Padding(4);
            this.flowOptions.Name = "flowOptions";
            this.flowOptions.Padding = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.flowOptions.Size = new System.Drawing.Size(956, 410);
            this.flowOptions.TabIndex = 1;
            // 
            // rbOptionA
            // 
            this.rbOptionA.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionA.Location = new System.Drawing.Point(4, 29);
            this.rbOptionA.Margin = new System.Windows.Forms.Padding(4);
            this.rbOptionA.Name = "rbOptionA";
            this.rbOptionA.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.rbOptionA.Size = new System.Drawing.Size(942, 54);
            this.rbOptionA.TabIndex = 0;
            this.rbOptionA.TabStop = true;
            this.rbOptionA.Text = "A. Đáp án 1";
            this.rbOptionA.UseVisualStyleBackColor = true;
            // 
            // rbOptionB
            // 
            this.rbOptionB.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionB.Location = new System.Drawing.Point(4, 91);
            this.rbOptionB.Margin = new System.Windows.Forms.Padding(4);
            this.rbOptionB.Name = "rbOptionB";
            this.rbOptionB.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.rbOptionB.Size = new System.Drawing.Size(940, 54);
            this.rbOptionB.TabIndex = 1;
            this.rbOptionB.TabStop = true;
            this.rbOptionB.Text = "B. Đáp án 2";
            this.rbOptionB.UseVisualStyleBackColor = true;
            // 
            // rbOptionC
            // 
            this.rbOptionC.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionC.Location = new System.Drawing.Point(4, 153);
            this.rbOptionC.Margin = new System.Windows.Forms.Padding(4);
            this.rbOptionC.Name = "rbOptionC";
            this.rbOptionC.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.rbOptionC.Size = new System.Drawing.Size(941, 54);
            this.rbOptionC.TabIndex = 2;
            this.rbOptionC.TabStop = true;
            this.rbOptionC.Text = "C. Đáp án 3";
            this.rbOptionC.UseVisualStyleBackColor = true;
            // 
            // rbOptionD
            // 
            this.rbOptionD.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOptionD.Location = new System.Drawing.Point(4, 215);
            this.rbOptionD.Margin = new System.Windows.Forms.Padding(4);
            this.rbOptionD.Name = "rbOptionD";
            this.rbOptionD.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.rbOptionD.Size = new System.Drawing.Size(944, 54);
            this.rbOptionD.TabIndex = 3;
            this.rbOptionD.TabStop = true;
            this.rbOptionD.Text = "D. Đáp án 4";
            this.rbOptionD.UseVisualStyleBackColor = true;
            // 
            // lblQuestionText
            // 
            this.lblQuestionText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionText.Location = new System.Drawing.Point(37, 37);
            this.lblQuestionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuestionText.Name = "lblQuestionText";
            this.lblQuestionText.Size = new System.Drawing.Size(952, 603);
            this.lblQuestionText.TabIndex = 0;
            this.lblQuestionText.Text = "Question------";
            // 
            // Exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 847);
            this.Controls.Add(this.pnlMainContent);
            this.Controls.Add(this.pnlQuestionNav);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Exercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmExam";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlQuestionNav.ResumeLayout(false);
            this.pnlQuestionNav.PerformLayout();
            this.pnlMainContent.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            this.flowOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblCurrentQuestionInfo;
        private System.Windows.Forms.Label lblUserInfo;
        private System.Windows.Forms.Panel pnlQuestionNav;
        private System.Windows.Forms.FlowLayoutPanel flowQuestionButtons;
        private System.Windows.Forms.Label lblNavTitle;
        private System.Windows.Forms.Panel pnlMainContent;
        private System.Windows.Forms.Label lblQuestionText;
        private System.Windows.Forms.FlowLayoutPanel flowOptions;
        private System.Windows.Forms.RadioButton rbOptionA;
        private System.Windows.Forms.RadioButton rbOptionB;
        private System.Windows.Forms.RadioButton rbOptionC;
        private System.Windows.Forms.RadioButton rbOptionD;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbCountDown;
        private System.Windows.Forms.Label lbClass;
        private System.Windows.Forms.Label lbSubject;
        private System.Windows.Forms.Label lbStudentName;
        private System.Windows.Forms.Label lbLanthi;
        private System.Windows.Forms.Label label8;
    }
}