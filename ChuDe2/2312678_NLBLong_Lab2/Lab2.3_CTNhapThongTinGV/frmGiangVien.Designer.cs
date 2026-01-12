namespace Lab2._3_CTNhapThongTinGV
{
    partial class frmGiangVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiangVien));
            this.lbl = new System.Windows.Forms.Label();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.cboMaSo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnThongBao = new System.Windows.Forms.Button();
            this.lbDanhSachHP = new System.Windows.Forms.ListBox();
            this.chklbNgoaiNgu = new System.Windows.Forms.CheckedListBox();
            this.mtxtSoDT = new System.Windows.Forms.MaskedTextBox();
            this.lbHocPhanDay = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.linklbLienHe = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.ForeColor = System.Drawing.Color.DarkViolet;
            this.lbl.Location = new System.Drawing.Point(121, 20);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(813, 49);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "THÔNG TIN GIẢNG VIÊN KHOA CNTT";
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold);
            this.rdNu.Location = new System.Drawing.Point(803, 95);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(81, 35);
            this.rdNu.TabIndex = 5;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold);
            this.rdNam.Location = new System.Drawing.Point(683, 95);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(101, 35);
            this.rdNam.TabIndex = 4;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // cboMaSo
            // 
            this.cboMaSo.FormattingEnabled = true;
            this.cboMaSo.Items.AddRange(new object[] {
            "001",
            "002",
            "003",
            "004"});
            this.cboMaSo.Location = new System.Drawing.Point(222, 97);
            this.cboMaSo.Name = "cboMaSo";
            this.cboMaSo.Size = new System.Drawing.Size(154, 33);
            this.cboMaSo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(532, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mã Số";
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(223, 163);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(255, 31);
            this.txtHoTen.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(91, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Họ Tên";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(221, 219);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(257, 31);
            this.dtpNgaySinh.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(57, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ngày Sinh";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(707, 221);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(279, 31);
            this.txtMail.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(532, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Địa chỉ mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(532, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "Số ĐT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(52, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 31);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ngoại Ngữ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(220, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(243, 31);
            this.label8.TabIndex = 16;
            this.label8.Text = "Danh sách môn học";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(607, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(277, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "Môn học giáo viên dạy";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(707, 723);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(181, 55);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(405, 713);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(257, 78);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.UseMnemonic = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnThongBao
            // 
            this.btnThongBao.Font = new System.Drawing.Font("Times New Roman", 10.125F, System.Drawing.FontStyle.Bold);
            this.btnThongBao.Location = new System.Drawing.Point(142, 723);
            this.btnThongBao.Name = "btnThongBao";
            this.btnThongBao.Size = new System.Drawing.Size(214, 55);
            this.btnThongBao.TabIndex = 20;
            this.btnThongBao.Text = "Thông báo";
            this.btnThongBao.UseVisualStyleBackColor = true;
            this.btnThongBao.Click += new System.EventHandler(this.btnThongBao_Click);
            // 
            // lbDanhSachHP
            // 
            this.lbDanhSachHP.FormattingEnabled = true;
            this.lbDanhSachHP.ItemHeight = 25;
            this.lbDanhSachHP.Items.AddRange(new object[] {
            "Tin học cơ sở",
            "Lập trình cấu trúc C/C++",
            "Cơ sở dữ liệu",
            "Tiếng Anh B1",
            "Tiếng Anh B2",
            "Lập trình hướng đối tượng",
            "Mạng máy tính",
            "Công nghệ phần mềm",
            "Phân tích TKHDT"});
            this.lbDanhSachHP.Location = new System.Drawing.Point(222, 470);
            this.lbDanhSachHP.Name = "lbDanhSachHP";
            this.lbDanhSachHP.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhSachHP.Size = new System.Drawing.Size(256, 229);
            this.lbDanhSachHP.TabIndex = 21;
            // 
            // chklbNgoaiNgu
            // 
            this.chklbNgoaiNgu.FormattingEnabled = true;
            this.chklbNgoaiNgu.Items.AddRange(new object[] {
            "Tiếng Anh",
            "Tiếng Pháp",
            "Tiếng Nhật",
            "Tiếng Nga"});
            this.chklbNgoaiNgu.Location = new System.Drawing.Point(221, 275);
            this.chklbNgoaiNgu.Name = "chklbNgoaiNgu";
            this.chklbNgoaiNgu.Size = new System.Drawing.Size(266, 144);
            this.chklbNgoaiNgu.TabIndex = 23;
            // 
            // mtxtSoDT
            // 
            this.mtxtSoDT.Location = new System.Drawing.Point(707, 163);
            this.mtxtSoDT.Mask = "(\\0633).000.000";
            this.mtxtSoDT.Name = "mtxtSoDT";
            this.mtxtSoDT.Size = new System.Drawing.Size(177, 31);
            this.mtxtSoDT.TabIndex = 24;
            // 
            // lbHocPhanDay
            // 
            this.lbHocPhanDay.FormattingEnabled = true;
            this.lbHocPhanDay.ItemHeight = 25;
            this.lbHocPhanDay.Location = new System.Drawing.Point(621, 471);
            this.lbHocPhanDay.Name = "lbHocPhanDay";
            this.lbHocPhanDay.Size = new System.Drawing.Size(262, 229);
            this.lbHocPhanDay.TabIndex = 25;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(505, 518);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(92, 58);
            this.btnChon.TabIndex = 26;
            this.btnChon.Text = ">>";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(505, 601);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 58);
            this.btnXoa.TabIndex = 26;
            this.btnXoa.Text = "<<";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // linklbLienHe
            // 
            this.linklbLienHe.AutoSize = true;
            this.linklbLienHe.Location = new System.Drawing.Point(939, 811);
            this.linklbLienHe.Name = "linklbLienHe";
            this.linklbLienHe.Size = new System.Drawing.Size(83, 25);
            this.linklbLienHe.TabIndex = 27;
            this.linklbLienHe.TabStop = true;
            this.linklbLienHe.Text = "Liên hệ";
            this.linklbLienHe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbLienHe_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(820, 810);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 26);
            this.label10.TabIndex = 28;
            this.label10.Text = "Website";
            // 
            // frmGiangVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 851);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.linklbLienHe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lbHocPhanDay);
            this.Controls.Add(this.mtxtSoDT);
            this.Controls.Add(this.chklbNgoaiNgu);
            this.Controls.Add(this.lbDanhSachHP);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnThongBao);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpNgaySinh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdNu);
            this.Controls.Add(this.rdNam);
            this.Controls.Add(this.cboMaSo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Name = "frmGiangVien";
            this.Text = "Giảng Viên";
            this.Load += new System.EventHandler(this.frmGiangVien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.ComboBox cboMaSo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnThongBao;
        private System.Windows.Forms.ListBox lbDanhSachHP;
        private System.Windows.Forms.CheckedListBox chklbNgoaiNgu;
        private System.Windows.Forms.MaskedTextBox mtxtSoDT;
        private System.Windows.Forms.ListBox lbHocPhanDay;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.LinkLabel linklbLienHe;
        private System.Windows.Forms.Label label10;
    }
}

