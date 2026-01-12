namespace Lab07_Entity_Framework
{
    partial class UpdateCategoryForm
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
            this.txtCateID = new System.Windows.Forms.TextBox();
            this.txtCateName = new System.Windows.Forms.TextBox();
            this.cboCateType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhóm thức ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại:";
            // 
            // txtCateID
            // 
            this.txtCateID.Location = new System.Drawing.Point(177, 21);
            this.txtCateID.Name = "txtCateID";
            this.txtCateID.ReadOnly = true;
            this.txtCateID.Size = new System.Drawing.Size(146, 26);
            this.txtCateID.TabIndex = 2;
            // 
            // txtCateName
            // 
            this.txtCateName.Location = new System.Drawing.Point(177, 79);
            this.txtCateName.Name = "txtCateName";
            this.txtCateName.Size = new System.Drawing.Size(378, 26);
            this.txtCateName.TabIndex = 2;
            // 
            // cboCateType
            // 
            this.cboCateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCateType.FormattingEnabled = true;
            this.cboCateType.Items.AddRange(new object[] {
            "Đồ uống",
            "Thức ăn"});
            this.cboCateType.Location = new System.Drawing.Point(177, 140);
            this.cboCateType.Name = "cboCateType";
            this.cboCateType.Size = new System.Drawing.Size(378, 28);
            this.cboCateType.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(288, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 32);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(431, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(124, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Thoát";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // UpdateCategoryForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(587, 263);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cboCateType);
            this.Controls.Add(this.txtCateName);
            this.Controls.Add(this.txtCateID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm/cập nhật món ăn";
            this.Load += new System.EventHandler(this.UpdateCategoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCateID;
        private System.Windows.Forms.TextBox txtCateName;
        private System.Windows.Forms.ComboBox cboCateType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
    }
}