namespace Invoice
{
    partial class UpdateCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCategory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCatDescription = new System.Windows.Forms.TextBox();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.lblCatDescription = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtCatDescription);
            this.panel1.Controls.Add(this.txtCatName);
            this.panel1.Controls.Add(this.lblCatDescription);
            this.panel1.Controls.Add(this.lblCatName);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.button1, "button1");
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = global::Invoice.Properties.Resources.upload;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Orange;
            this.btnClear.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = global::Invoice.Properties.Resources.backspace_arrow1;
            this.btnClear.Name = "btnClear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Orange;
            this.btnSave.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::Invoice.Properties.Resources.tick;
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCatDescription
            // 
            resources.ApplyResources(this.txtCatDescription, "txtCatDescription");
            this.txtCatDescription.Name = "txtCatDescription";
            // 
            // txtCatName
            // 
            resources.ApplyResources(this.txtCatName, "txtCatName");
            this.txtCatName.Name = "txtCatName";
            // 
            // lblCatDescription
            // 
            resources.ApplyResources(this.lblCatDescription, "lblCatDescription");
            this.lblCatDescription.ForeColor = System.Drawing.Color.Black;
            this.lblCatDescription.Name = "lblCatDescription";
            // 
            // lblCatName
            // 
            resources.ApplyResources(this.lblCatName, "lblCatName");
            this.lblCatName.ForeColor = System.Drawing.Color.Black;
            this.lblCatName.Name = "lblCatName";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // UpdateCategory
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateCategory";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.UpdateCategory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCatDescription;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label lblCatDescription;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}