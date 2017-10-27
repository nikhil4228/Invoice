namespace Invoice
{
    partial class UpdateUserDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdate_record = new System.Windows.Forms.Button();
            this.cmbUserType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContact_no = new System.Windows.Forms.TextBox();
            this.txtEmail_Address = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdate_record);
            this.panel1.Controls.Add(this.cmbUserType);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtContact_no);
            this.panel1.Controls.Add(this.txtEmail_Address);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 60);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(621, 405);
            this.panel1.TabIndex = 1;
            // 
            // btnUpdate_record
            // 
            this.btnUpdate_record.BackColor = System.Drawing.Color.Orange;
            this.btnUpdate_record.FlatAppearance.BorderSize = 0;
            this.btnUpdate_record.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate_record.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate_record.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate_record.Image = global::Invoice.Properties.Resources.Edit_icon1;
            this.btnUpdate_record.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate_record.Location = new System.Drawing.Point(289, 311);
            this.btnUpdate_record.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate_record.Name = "btnUpdate_record";
            this.btnUpdate_record.Size = new System.Drawing.Size(105, 31);
            this.btnUpdate_record.TabIndex = 37;
            this.btnUpdate_record.Text = "&Update";
            this.btnUpdate_record.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate_record.UseVisualStyleBackColor = false;
            this.btnUpdate_record.Click += new System.EventHandler(this.btnUpdate_record_Click);
            // 
            // cmbUserType
            // 
            this.cmbUserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbUserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserType.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.cmbUserType.FormattingEnabled = true;
            this.cmbUserType.Location = new System.Drawing.Point(204, 76);
            this.cmbUserType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUserType.Name = "cmbUserType";
            this.cmbUserType.Size = new System.Drawing.Size(351, 31);
            this.cmbUserType.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(76, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 34;
            this.label1.Text = "User Type:";
            // 
            // txtContact_no
            // 
            this.txtContact_no.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.txtContact_no.Location = new System.Drawing.Point(204, 196);
            this.txtContact_no.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContact_no.MaxLength = 10;
            this.txtContact_no.Name = "txtContact_no";
            this.txtContact_no.Size = new System.Drawing.Size(351, 30);
            this.txtContact_no.TabIndex = 5;
            // 
            // txtEmail_Address
            // 
            this.txtEmail_Address.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.txtEmail_Address.Location = new System.Drawing.Point(204, 235);
            this.txtEmail_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail_Address.Name = "txtEmail_Address";
            this.txtEmail_Address.Size = new System.Drawing.Size(351, 30);
            this.txtEmail_Address.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(204, 37);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(351, 30);
            this.txtName.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(204, 156);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(351, 30);
            this.txtPassword.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(115, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(69, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Contact No.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(113, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(84, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(204, 117);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(351, 30);
            this.txtUsername.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(63, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "User Name: ";
            // 
            // UpdateUserDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 485);
            this.Controls.Add(this.panel1);
            this.Name = "UpdateUserDetails";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Update User Details";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.UpdateUserDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdate_record;
        private System.Windows.Forms.ComboBox cmbUserType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContact_no;
        private System.Windows.Forms.TextBox txtEmail_Address;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
    }
}