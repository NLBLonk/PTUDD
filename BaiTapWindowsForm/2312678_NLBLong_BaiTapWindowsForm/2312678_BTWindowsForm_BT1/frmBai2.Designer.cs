namespace _2312678_BTWindowsForm_BT1
{
    partial class frmBai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCK = new System.Windows.Forms.RadioButton();
            this.rdTienMat = new System.Windows.Forms.RadioButton();
            this.cboTenHang = new System.Windows.Forms.ComboBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Đơn giá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 393);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Số tiền thanh toán:";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSoTien.Location = new System.Drawing.Point(337, 393);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(17, 25);
            this.lblSoTien.TabIndex = 0;
            this.lblSoTien.Text = ".";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(188, 99);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(161, 26);
            this.txtDonGia.TabIndex = 1;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(188, 148);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(100, 26);
            this.txtSL.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTienMat);
            this.groupBox1.Controls.Add(this.rdCK);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Location = new System.Drawing.Point(188, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 120);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình thức thanh toán:";
            // 
            // rdCK
            // 
            this.rdCK.AutoSize = true;
            this.rdCK.Checked = true;
            this.rdCK.Location = new System.Drawing.Point(34, 35);
            this.rdCK.Name = "rdCK";
            this.rdCK.Size = new System.Drawing.Size(136, 24);
            this.rdCK.TabIndex = 0;
            this.rdCK.TabStop = true;
            this.rdCK.Text = "Chuyển khoản";
            this.rdCK.UseVisualStyleBackColor = true;
            // 
            // rdTienMat
            // 
            this.rdTienMat.AutoSize = true;
            this.rdTienMat.Location = new System.Drawing.Point(34, 65);
            this.rdTienMat.Name = "rdTienMat";
            this.rdTienMat.Size = new System.Drawing.Size(95, 24);
            this.rdTienMat.TabIndex = 0;
            this.rdTienMat.Text = "Tiền mặt";
            this.rdTienMat.UseVisualStyleBackColor = true;
            // 
            // cboTenHang
            // 
            this.cboTenHang.FormattingEnabled = true;
            this.cboTenHang.Items.AddRange(new object[] {
            "Chuột",
            "Máy in",
            "Bàn phím"});
            this.cboTenHang.Location = new System.Drawing.Point(188, 42);
            this.cboTenHang.Name = "cboTenHang";
            this.cboTenHang.Size = new System.Drawing.Size(161, 28);
            this.cboTenHang.TabIndex = 3;
            this.cboTenHang.SelectedIndexChanged += new System.EventHandler(this.cboTenHang_SelectedIndexChanged);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(245, 339);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(104, 34);
            this.btnTinhTien.TabIndex = 4;
            this.btnTinhTien.Text = "Tính Tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 471);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.cboTenHang);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBai2";
            this.Text = "Bài 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTienMat;
        private System.Windows.Forms.RadioButton rdCK;
        private System.Windows.Forms.ComboBox cboTenHang;
        private System.Windows.Forms.Button btnTinhTien;
    }
}