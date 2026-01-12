namespace ThongTinSoXo
{
    partial class frmChinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenDai = new System.Windows.Forms.TextBox();
            this.txtSoCanDo = new System.Windows.Forms.TextBox();
            this.dtpNgay = new System.Windows.Forms.DateTimePicker();
            this.rdMienNam = new System.Windows.Forms.RadioButton();
            this.rdMienTrung = new System.Windows.Forms.RadioButton();
            this.rdMienBac = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Reset);
            this.groupBox1.Controls.Add(this.txtTenDai);
            this.groupBox1.Controls.Add(this.txtSoCanDo);
            this.groupBox1.Controls.Add(this.dtpNgay);
            this.groupBox1.Controls.Add(this.rdMienNam);
            this.groupBox1.Controls.Add(this.rdMienTrung);
            this.groupBox1.Controls.Add(this.rdMienBac);
            this.groupBox1.Location = new System.Drawing.Point(25, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(698, 215);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(346, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nhập tên đài cần tìm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chọn ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(346, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nhập số dò:";
            // 
            // txtTenDai
            // 
            this.txtTenDai.Location = new System.Drawing.Point(526, 94);
            this.txtTenDai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTenDai.Name = "txtTenDai";
            this.txtTenDai.Size = new System.Drawing.Size(154, 26);
            this.txtTenDai.TabIndex = 10;
            this.txtTenDai.TextChanged += new System.EventHandler(this.txtTenDai_TextChanged);
            // 
            // txtSoCanDo
            // 
            this.txtSoCanDo.Location = new System.Drawing.Point(525, 30);
            this.txtSoCanDo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSoCanDo.Name = "txtSoCanDo";
            this.txtSoCanDo.Size = new System.Drawing.Size(155, 26);
            this.txtSoCanDo.TabIndex = 11;
            this.txtSoCanDo.TextChanged += new System.EventHandler(this.txtSoCanDo_TextChanged);
            // 
            // dtpNgay
            // 
            this.dtpNgay.Location = new System.Drawing.Point(113, 148);
            this.dtpNgay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpNgay.Name = "dtpNgay";
            this.dtpNgay.Size = new System.Drawing.Size(138, 26);
            this.dtpNgay.TabIndex = 4;
            this.dtpNgay.ValueChanged += new System.EventHandler(this.DtpNgay_ValueChanged);
            // 
            // rdMienNam
            // 
            this.rdMienNam.AutoSize = true;
            this.rdMienNam.Location = new System.Drawing.Point(21, 99);
            this.rdMienNam.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdMienNam.Name = "rdMienNam";
            this.rdMienNam.Size = new System.Drawing.Size(105, 24);
            this.rdMienNam.TabIndex = 2;
            this.rdMienNam.TabStop = true;
            this.rdMienNam.Text = "Miền Nam";
            this.rdMienNam.UseVisualStyleBackColor = true;
            // 
            // rdMienTrung
            // 
            this.rdMienTrung.AutoSize = true;
            this.rdMienTrung.Location = new System.Drawing.Point(21, 64);
            this.rdMienTrung.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdMienTrung.Name = "rdMienTrung";
            this.rdMienTrung.Size = new System.Drawing.Size(113, 24);
            this.rdMienTrung.TabIndex = 1;
            this.rdMienTrung.TabStop = true;
            this.rdMienTrung.Text = "Miền Trung";
            this.rdMienTrung.UseVisualStyleBackColor = true;
            // 
            // rdMienBac
            // 
            this.rdMienBac.AutoSize = true;
            this.rdMienBac.Location = new System.Drawing.Point(21, 30);
            this.rdMienBac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdMienBac.Name = "rdMienBac";
            this.rdMienBac.Size = new System.Drawing.Size(100, 24);
            this.rdMienBac.TabIndex = 0;
            this.rdMienBac.TabStop = true;
            this.rdMienBac.Text = "Miền Bắc";
            this.rdMienBac.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 238);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(698, 201);
            this.dataGridView1.TabIndex = 12;
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(545, 153);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(135, 35);
            this.btn_Reset.TabIndex = 9;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 493);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmChinh";
            this.Text = "Thông tin xổ số các miền";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpNgay;
        private System.Windows.Forms.RadioButton rdMienNam;
        private System.Windows.Forms.RadioButton rdMienTrung;
        private System.Windows.Forms.RadioButton rdMienBac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenDai;
        private System.Windows.Forms.TextBox txtSoCanDo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Reset;
    }
}

