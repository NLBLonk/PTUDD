namespace _2312678_BTWindowsForm_BT1
{
    partial class frmBai3
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
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtSoN = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTongN = new System.Windows.Forms.RadioButton();
            this.rdTongAB = new System.Windows.Forms.RadioButton();
            this.btnKQ = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblKQ = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số n";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(136, 53);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(159, 26);
            this.txtSoA.TabIndex = 2;
            this.txtSoA.Text = "0";
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(136, 105);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(159, 26);
            this.txtSoB.TabIndex = 2;
            this.txtSoB.Text = "0";
            // 
            // txtSoN
            // 
            this.txtSoN.Location = new System.Drawing.Point(136, 159);
            this.txtSoN.Name = "txtSoN";
            this.txtSoN.Size = new System.Drawing.Size(159, 26);
            this.txtSoN.TabIndex = 2;
            this.txtSoN.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTongN);
            this.groupBox1.Controls.Add(this.rdTongAB);
            this.groupBox1.Location = new System.Drawing.Point(59, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 139);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn phép toán";
            // 
            // rdTongN
            // 
            this.rdTongN.AutoSize = true;
            this.rdTongN.Location = new System.Drawing.Point(25, 88);
            this.rdTongN.Name = "rdTongN";
            this.rdTongN.Size = new System.Drawing.Size(175, 24);
            this.rdTongN.TabIndex = 0;
            this.rdTongN.Text = "Tính tổng từ 1 đến n";
            this.rdTongN.UseVisualStyleBackColor = true;
            // 
            // rdTongAB
            // 
            this.rdTongAB.AutoSize = true;
            this.rdTongAB.Checked = true;
            this.rdTongAB.Location = new System.Drawing.Point(25, 47);
            this.rdTongAB.Name = "rdTongAB";
            this.rdTongAB.Size = new System.Drawing.Size(160, 24);
            this.rdTongAB.TabIndex = 0;
            this.rdTongAB.TabStop = true;
            this.rdTongAB.Text = "Tính tổng của a, b";
            this.rdTongAB.UseVisualStyleBackColor = true;
            // 
            // btnKQ
            // 
            this.btnKQ.Location = new System.Drawing.Point(108, 369);
            this.btnKQ.Name = "btnKQ";
            this.btnKQ.Size = new System.Drawing.Size(151, 38);
            this.btnKQ.TabIndex = 4;
            this.btnKQ.Text = "Xem kết quả";
            this.btnKQ.UseVisualStyleBackColor = true;
            this.btnKQ.Click += new System.EventHandler(this.btnKQ_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 438);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kết quả:";
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ.Location = new System.Drawing.Point(173, 438);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(17, 25);
            this.lblKQ.TabIndex = 0;
            this.lblKQ.Text = ".";
            // 
            // frmBai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 489);
            this.Controls.Add(this.btnKQ);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSoN);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "frmBai3";
            this.Text = "Bài 3";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtSoN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTongN;
        private System.Windows.Forms.RadioButton rdTongAB;
        private System.Windows.Forms.Button btnKQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblKQ;
    }
}