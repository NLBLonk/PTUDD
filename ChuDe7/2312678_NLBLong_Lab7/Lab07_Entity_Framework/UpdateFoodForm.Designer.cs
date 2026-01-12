namespace Lab07_Entity_Framework
{
    partial class UpdateFoodForm
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cboFoodCategory = new System.Windows.Forms.ComboBox();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.txtFoodID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFoodUnit = new System.Windows.Forms.TextBox();
            this.numFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.rtxtFoodNotes = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numFoodPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(431, 358);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 32);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(288, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 32);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cboFoodCategory
            // 
            this.cboFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoodCategory.FormattingEnabled = true;
            this.cboFoodCategory.Location = new System.Drawing.Point(178, 132);
            this.cboFoodCategory.Name = "cboFoodCategory";
            this.cboFoodCategory.Size = new System.Drawing.Size(378, 28);
            this.cboFoodCategory.TabIndex = 10;
            // 
            // txtFoodName
            // 
            this.txtFoodName.Location = new System.Drawing.Point(178, 82);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(378, 26);
            this.txtFoodName.TabIndex = 8;
            // 
            // txtFoodID
            // 
            this.txtFoodID.Location = new System.Drawing.Point(178, 24);
            this.txtFoodID.Name = "txtFoodID";
            this.txtFoodID.ReadOnly = true;
            this.txtFoodID.Size = new System.Drawing.Size(146, 26);
            this.txtFoodID.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thuộc danh mục:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tên thức ăn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã số:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn vị tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Đơn giá:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Ghi chú khác:";
            // 
            // txtFoodUnit
            // 
            this.txtFoodUnit.Location = new System.Drawing.Point(178, 182);
            this.txtFoodUnit.Name = "txtFoodUnit";
            this.txtFoodUnit.Size = new System.Drawing.Size(378, 26);
            this.txtFoodUnit.TabIndex = 8;
            // 
            // numFoodPrice
            // 
            this.numFoodPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numFoodPrice.Location = new System.Drawing.Point(177, 229);
            this.numFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numFoodPrice.Name = "numFoodPrice";
            this.numFoodPrice.Size = new System.Drawing.Size(379, 26);
            this.numFoodPrice.TabIndex = 13;
            this.numFoodPrice.ThousandsSeparator = true;
            // 
            // rtxtFoodNotes
            // 
            this.rtxtFoodNotes.Location = new System.Drawing.Point(177, 272);
            this.rtxtFoodNotes.Name = "rtxtFoodNotes";
            this.rtxtFoodNotes.Size = new System.Drawing.Size(378, 58);
            this.rtxtFoodNotes.TabIndex = 14;
            this.rtxtFoodNotes.Text = "";
            // 
            // UpdateFoodForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(591, 418);
            this.ControlBox = false;
            this.Controls.Add(this.rtxtFoodNotes);
            this.Controls.Add(this.numFoodPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboFoodCategory);
            this.Controls.Add(this.txtFoodUnit);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.txtFoodID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateFoodForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm/ cập nhật món ăn";
            this.Load += new System.EventHandler(this.UpdateFoodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numFoodPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cboFoodCategory;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.TextBox txtFoodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFoodUnit;
        private System.Windows.Forms.NumericUpDown numFoodPrice;
        private System.Windows.Forms.RichTextBox rtxtFoodNotes;
    }
}