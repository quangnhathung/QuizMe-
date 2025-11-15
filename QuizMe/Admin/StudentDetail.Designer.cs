
namespace QuizMe.Admin
{
    partial class StudentDetail
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
            this.pnlTopSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchMaSV = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.btnCreateReport = new System.Windows.Forms.Button();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.colSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAttempt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbStudentInfo = new System.Windows.Forms.GroupBox();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.pnlTopSearch.SuspendLayout();
            this.pnlResults.SuspendLayout();
            this.gbResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.gbStudentInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopSearch
            // 
            this.pnlTopSearch.BackColor = System.Drawing.Color.White;
            this.pnlTopSearch.Controls.Add(this.btnSearch);
            this.pnlTopSearch.Controls.Add(this.txtSearchMaSV);
            this.pnlTopSearch.Controls.Add(this.lblSearch);
            this.pnlTopSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlTopSearch.Name = "pnlTopSearch";
            this.pnlTopSearch.Size = new System.Drawing.Size(750, 60);
            this.pnlTopSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(400, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchMaSV
            // 
            this.txtSearchMaSV.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMaSV.Location = new System.Drawing.Point(150, 18);
            this.txtSearchMaSV.Name = "txtSearchMaSV";
            this.txtSearchMaSV.Size = new System.Drawing.Size(230, 25);
            this.txtSearchMaSV.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(20, 21);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(124, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Nhập Mã Sinh Viên:";
            // 
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.btnCreateReport);
            this.pnlResults.Controls.Add(this.gbResults);
            this.pnlResults.Controls.Add(this.gbStudentInfo);
            this.pnlResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlResults.Location = new System.Drawing.Point(0, 60);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Padding = new System.Windows.Forms.Padding(10);
            this.pnlResults.Size = new System.Drawing.Size(750, 460);
            this.pnlResults.TabIndex = 1;
            this.pnlResults.Visible = false; // Ẩn ban đầu
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnCreateReport.FlatAppearance.BorderSize = 0;
            this.btnCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReport.ForeColor = System.Drawing.Color.White;
            this.btnCreateReport.Location = new System.Drawing.Point(587, 410);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Size = new System.Drawing.Size(150, 40);
            this.btnCreateReport.TabIndex = 2;
            this.btnCreateReport.Text = "Tạo Report";
            this.btnCreateReport.UseVisualStyleBackColor = false;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // gbResults
            // 
            this.gbResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResults.Controls.Add(this.dgvResults);
            this.gbResults.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbResults.Location = new System.Drawing.Point(13, 145);
            this.gbResults.Name = "gbResults";
            this.gbResults.Padding = new System.Windows.Forms.Padding(10);
            this.gbResults.Size = new System.Drawing.Size(724, 255);
            this.gbResults.TabIndex = 1;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Kết quả thi";
            // 
            // dgvResults
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            this.dgvResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResults.BackgroundColor = System.Drawing.Color.White;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSubject,
            this.colAttempt,
            this.colScore});
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvResults.Location = new System.Drawing.Point(10, 28);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.Size = new System.Drawing.Size(704, 217);
            this.dgvResults.TabIndex = 0;
            // 
            // colSubject
            // 
            this.colSubject.HeaderText = "Môn thi";
            this.colSubject.Name = "colSubject";
            this.colSubject.ReadOnly = true;
            this.colSubject.FillWeight = 60F;
            // 
            // colAttempt
            // 
            this.colAttempt.HeaderText = "Lần thi";
            this.colAttempt.Name = "colAttempt";
            this.colAttempt.ReadOnly = true;
            this.colAttempt.FillWeight = 20F;
            // 
            // colScore
            // 
            this.colScore.HeaderText = "Điểm";
            this.colScore.Name = "colScore";
            this.colScore.ReadOnly = true;
            this.colScore.FillWeight = 20F;
            // 
            // gbStudentInfo
            // 
            this.gbStudentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbStudentInfo.Controls.Add(this.lblMaLop);
            this.gbStudentInfo.Controls.Add(this.lblNgaySinh);
            this.gbStudentInfo.Controls.Add(this.lblGioiTinh);
            this.gbStudentInfo.Controls.Add(this.lblHoTen);
            this.gbStudentInfo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudentInfo.Location = new System.Drawing.Point(13, 13);
            this.gbStudentInfo.Name = "gbStudentInfo";
            this.gbStudentInfo.Size = new System.Drawing.Size(724, 120);
            this.gbStudentInfo.TabIndex = 0;
            this.gbStudentInfo.TabStop = false;
            this.gbStudentInfo.Text = "Thông tin sinh viên";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.Location = new System.Drawing.Point(350, 75);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(65, 20);
            this.lblMaLop.TabIndex = 3;
            this.lblMaLop.Text = "Mã Lớp: ";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(30, 75);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(81, 20);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày Sinh: ";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(350, 35);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(72, 20);
            this.lblGioiTinh.TabIndex = 1;
            this.lblGioiTinh.Text = "Giới Tính: ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(30, 35);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(63, 20);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ Tên: ";
            // 
            // ucStudentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.pnlTopSearch);
            this.Name = "ucStudentDetail";
            this.Size = new System.Drawing.Size(750, 520);
            this.Load += new System.EventHandler(this.ucStudentDetail_Load);
            this.pnlTopSearch.ResumeLayout(false);
            this.pnlTopSearch.PerformLayout();
            this.pnlResults.ResumeLayout(false);
            this.gbResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.gbStudentInfo.ResumeLayout(false);
            this.gbStudentInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTopSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearchMaSV;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.GroupBox gbStudentInfo;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnCreateReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAttempt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScore;
    }
}
