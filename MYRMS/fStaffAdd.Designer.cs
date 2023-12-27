namespace MYRMS
{
    partial class fStaffAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStaffAdd));
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.Phone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRole = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // label1
            // 
            this.label1.Size = new System.Drawing.Size(157, 31);
            this.label1.Text = "Staff Details";
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtName.Location = new System.Drawing.Point(94, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(186, 20);
            this.txtName.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "Name";
            // 
            // txtPhone
            // 
            this.txtPhone.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtPhone.Location = new System.Drawing.Point(94, 123);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(186, 20);
            this.txtPhone.TabIndex = 26;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Phone
            // 
            this.Phone.AutoSize = true;
            this.Phone.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.Location = new System.Drawing.Point(12, 118);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(57, 21);
            this.Phone.TabIndex = 25;
            this.Phone.Text = "Phone";
            this.Phone.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 27;
            this.label4.Text = "Role";
            // 
            // cbRole
            // 
            this.cbRole.BackColor = System.Drawing.Color.Transparent;
            this.cbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbRole.ItemHeight = 30;
            this.cbRole.Items.AddRange(new object[] {
            "Cashier",
            "Waiter",
            "Clening ",
            "Manager",
            "Other"});
            this.cbRole.Location = new System.Drawing.Point(92, 180);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(188, 36);
            this.cbRole.TabIndex = 28;
            // 
            // fStaffAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Name = "fStaffAdd";
            this.Text = "fStaffAdd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label Phone;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2ComboBox cbRole;
    }
}