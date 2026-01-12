namespace _2312678_BaiThucHanhBuoi1
{
    partial class MainForm
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSaoChep = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnSaoChep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên của bạn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bạn đã nhập:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(231, 48);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(300, 26);
            this.txtTen.TabIndex = 2;
            this.txtTen.TextChanged += new System.EventHandler(this.txtTen_TextChanged);
            // 
            // txtSaoChep
            // 
            this.txtSaoChep.Location = new System.Drawing.Point(231, 123);
            this.txtSaoChep.Name = "txtSaoChep";
            this.txtSaoChep.ReadOnly = true;
            this.txtSaoChep.Size = new System.Drawing.Size(300, 26);
            this.txtSaoChep.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(313, 86);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 31);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "Xử lý";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.Location = new System.Drawing.Point(421, 86);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(110, 31);
            this.btnSaoChep.TabIndex = 5;
            this.btnSaoChep.Text = "Sao Chép";
            this.btnSaoChep.UseVisualStyleBackColor = true;
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChep_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSaoChep);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtSaoChep);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Xử lý";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSaoChep;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnSaoChep;
    }
}