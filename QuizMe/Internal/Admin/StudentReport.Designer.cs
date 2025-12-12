namespace QuizMe.Internal.Admin
{
    public partial class StudentReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentReport));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblLabelMSSV = new System.Windows.Forms.Label();
            this.lblValMSSV = new System.Windows.Forms.Label();
            this.lblLabelTen = new System.Windows.Forms.Label();
            this.lblValTen = new System.Windows.Forms.Label();
            this.lblLabelLop = new System.Windows.Forms.Label();
            this.lblValLop = new System.Windows.Forms.Label();
            this.lblLabelNgaySinh = new System.Windows.Forms.Label();
            this.lblValNgaySinh = new System.Windows.Forms.Label();
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.lblLabelDTB = new System.Windows.Forms.Label();
            this.lblValDTB = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTitle.Location = new System.Drawing.Point(209, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(411, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "PHIẾU BÁO ĐIỂM CÁ NHÂN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblLabelMSSV
            // 
            this.lblLabelMSSV.AutoSize = true;
            this.lblLabelMSSV.ForeColor = System.Drawing.Color.Gray;
            this.lblLabelMSSV.Location = new System.Drawing.Point(40, 80);
            this.lblLabelMSSV.Name = "lblLabelMSSV";
            this.lblLabelMSSV.Size = new System.Drawing.Size(110, 23);
            this.lblLabelMSSV.TabIndex = 1;
            this.lblLabelMSSV.Text = "Mã sinh viên:";
            // 
            // lblValMSSV
            // 
            this.lblValMSSV.AutoSize = true;
            this.lblValMSSV.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblValMSSV.Location = new System.Drawing.Point(156, 80);
            this.lblValMSSV.Name = "lblValMSSV";
            this.lblValMSSV.Size = new System.Drawing.Size(32, 25);
            this.lblValMSSV.TabIndex = 2;
            this.lblValMSSV.Text = "....";
            // 
            // lblLabelTen
            // 
            this.lblLabelTen.AutoSize = true;
            this.lblLabelTen.ForeColor = System.Drawing.Color.Gray;
            this.lblLabelTen.Location = new System.Drawing.Point(40, 110);
            this.lblLabelTen.Name = "lblLabelTen";
            this.lblLabelTen.Size = new System.Drawing.Size(88, 23);
            this.lblLabelTen.TabIndex = 3;
            this.lblLabelTen.Text = "Họ và tên:";
            // 
            // lblValTen
            // 
            this.lblValTen.AutoSize = true;
            this.lblValTen.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblValTen.Location = new System.Drawing.Point(156, 110);
            this.lblValTen.Name = "lblValTen";
            this.lblValTen.Size = new System.Drawing.Size(32, 25);
            this.lblValTen.TabIndex = 4;
            this.lblValTen.Text = "....";
            // 
            // lblLabelLop
            // 
            this.lblLabelLop.AutoSize = true;
            this.lblLabelLop.ForeColor = System.Drawing.Color.Gray;
            this.lblLabelLop.Location = new System.Drawing.Point(450, 80);
            this.lblLabelLop.Name = "lblLabelLop";
            this.lblLabelLop.Size = new System.Drawing.Size(42, 23);
            this.lblLabelLop.TabIndex = 5;
            this.lblLabelLop.Text = "Lớp:";
            // 
            // lblValLop
            // 
            this.lblValLop.AutoSize = true;
            this.lblValLop.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblValLop.Location = new System.Drawing.Point(546, 78);
            this.lblValLop.Name = "lblValLop";
            this.lblValLop.Size = new System.Drawing.Size(32, 25);
            this.lblValLop.TabIndex = 6;
            this.lblValLop.Text = "....";
            // 
            // lblLabelNgaySinh
            // 
            this.lblLabelNgaySinh.AutoSize = true;
            this.lblLabelNgaySinh.ForeColor = System.Drawing.Color.Gray;
            this.lblLabelNgaySinh.Location = new System.Drawing.Point(450, 110);
            this.lblLabelNgaySinh.Name = "lblLabelNgaySinh";
            this.lblLabelNgaySinh.Size = new System.Drawing.Size(90, 23);
            this.lblLabelNgaySinh.TabIndex = 7;
            this.lblLabelNgaySinh.Text = "Ngày sinh:";
            // 
            // lblValNgaySinh
            // 
            this.lblValNgaySinh.AutoSize = true;
            this.lblValNgaySinh.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblValNgaySinh.Location = new System.Drawing.Point(546, 108);
            this.lblValNgaySinh.Name = "lblValNgaySinh";
            this.lblValNgaySinh.Size = new System.Drawing.Size(32, 25);
            this.lblValNgaySinh.TabIndex = 8;
            this.lblValNgaySinh.Text = "....";
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.AllowUserToDeleteRows = false;
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDiem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDiem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDiem.ColumnHeadersHeight = 40;
            this.dgvDiem.EnableHeadersVisualStyles = false;
            this.dgvDiem.Location = new System.Drawing.Point(44, 160);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.ReadOnly = true;
            this.dgvDiem.RowHeadersVisible = false;
            this.dgvDiem.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(240)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDiem.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDiem.RowTemplate.Height = 35;
            this.dgvDiem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiem.Size = new System.Drawing.Size(696, 300);
            this.dgvDiem.TabIndex = 9;
            // 
            // lblLabelDTB
            // 
            this.lblLabelDTB.AutoSize = true;
            this.lblLabelDTB.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLabelDTB.Location = new System.Drawing.Point(40, 480);
            this.lblLabelDTB.Name = "lblLabelDTB";
            this.lblLabelDTB.Size = new System.Drawing.Size(239, 28);
            this.lblLabelDTB.TabIndex = 10;
            this.lblLabelDTB.Text = "Điểm Trung Bình Tích Lũy :";
            // 
            // lblValDTB
            // 
            this.lblValDTB.AutoSize = true;
            this.lblValDTB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblValDTB.ForeColor = System.Drawing.Color.Red;
            this.lblValDTB.Location = new System.Drawing.Point(274, 478);
            this.lblValDTB.Name = "lblValDTB";
            this.lblValDTB.Size = new System.Drawing.Size(64, 32);
            this.lblValDTB.TabIndex = 11;
            this.lblValDTB.Text = "0.00";
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(600, 550);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(140, 45);
            this.btnPrint.TabIndex = 12;
            this.btnPrint.Text = "IN PHIẾU";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // StudentReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 631);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblValDTB);
            this.Controls.Add(this.lblLabelDTB);
            this.Controls.Add(this.dgvDiem);
            this.Controls.Add(this.lblValNgaySinh);
            this.Controls.Add(this.lblLabelNgaySinh);
            this.Controls.Add(this.lblValLop);
            this.Controls.Add(this.lblLabelLop);
            this.Controls.Add(this.lblValTen);
            this.Controls.Add(this.lblLabelTen);
            this.Controls.Add(this.lblValMSSV);
            this.Controls.Add(this.lblLabelMSSV);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLabelMSSV;
        private System.Windows.Forms.Label lblValMSSV;
        private System.Windows.Forms.Label lblLabelTen;
        private System.Windows.Forms.Label lblValTen;
        private System.Windows.Forms.Label lblLabelLop;
        private System.Windows.Forms.Label lblValLop;
        private System.Windows.Forms.Label lblLabelNgaySinh;
        private System.Windows.Forms.Label lblValNgaySinh;
        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.Label lblLabelDTB;
        private System.Windows.Forms.Label lblValDTB;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}