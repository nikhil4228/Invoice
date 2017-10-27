namespace Invoice
{
    partial class CreateProduct
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtOriginalPrice = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbSubCategory = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnBrows = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblVat = new System.Windows.Forms.Label();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(193, 431);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(351, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Orange;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Image = global::Invoice.Properties.Resources.save_icon1;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(239, 595);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(85, 31);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(79, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Category :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(43, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Sub-Category :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(42, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 25;
            this.label4.Text = "Original Price :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(58, 334);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "Description :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 30);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 23);
            this.label8.TabIndex = 23;
            this.label8.Text = "Product Name :";
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProductName.Location = new System.Drawing.Point(193, 28);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(351, 26);
            this.txtProductName.TabIndex = 1;
            // 
            // txtOriginalPrice
            // 
            this.txtOriginalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtOriginalPrice.Location = new System.Drawing.Point(193, 146);
            this.txtOriginalPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtOriginalPrice.Name = "txtOriginalPrice";
            this.txtOriginalPrice.Size = new System.Drawing.Size(351, 26);
            this.txtOriginalPrice.TabIndex = 4;
            this.txtOriginalPrice.Leave += new System.EventHandler(this.txtOriginalPrice_Leave);
            // 
            // cbCategory
            // 
            this.cbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(193, 66);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(351, 28);
            this.cbCategory.TabIndex = 2;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // cbSubCategory
            // 
            this.cbSubCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cbSubCategory.FormattingEnabled = true;
            this.cbSubCategory.Location = new System.Drawing.Point(193, 106);
            this.cbSubCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cbSubCategory.Name = "cbSubCategory";
            this.cbSubCategory.Size = new System.Drawing.Size(351, 28);
            this.cbSubCategory.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDescription.Location = new System.Drawing.Point(193, 336);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(351, 83);
            this.txtDescription.TabIndex = 9;
            // 
            // btnBrows
            // 
            this.btnBrows.BackColor = System.Drawing.Color.Orange;
            this.btnBrows.FlatAppearance.BorderSize = 0;
            this.btnBrows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrows.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnBrows.ForeColor = System.Drawing.Color.Black;
            this.btnBrows.Image = global::Invoice.Properties.Resources.upload1;
            this.btnBrows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrows.Location = new System.Drawing.Point(445, 535);
            this.btnBrows.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrows.Name = "btnBrows";
            this.btnBrows.Size = new System.Drawing.Size(97, 28);
            this.btnBrows.TabIndex = 9;
            this.btnBrows.Text = "Browse";
            this.btnBrows.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBrows.UseVisualStyleBackColor = false;
            this.btnBrows.Click += new System.EventHandler(this.btnBrows_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Orange;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = global::Invoice.Properties.Resources.backspace_arrow1;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.ImeMode = System.Windows.Forms.ImeMode.On;
            this.btnClear.Location = new System.Drawing.Point(332, 595);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 31);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.lblVat.ForeColor = System.Drawing.Color.Black;
            this.lblVat.Location = new System.Drawing.Point(97, 220);
            this.lblVat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(69, 23);
            this.lblVat.TabIndex = 37;
            this.lblVat.Text = "C.GST :";
            // 
            // txtCGST
            // 
            this.txtCGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCGST.Location = new System.Drawing.Point(194, 222);
            this.txtCGST.Margin = new System.Windows.Forms.Padding(4);
            this.txtCGST.MaxLength = 2;
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.Size = new System.Drawing.Size(72, 26);
            this.txtCGST.TabIndex = 6;
            this.txtCGST.Text = "0";
            this.txtCGST.Leave += new System.EventHandler(this.txtCGST_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(78, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 39;
            this.label5.Text = "Discount :";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDiscount.Location = new System.Drawing.Point(193, 184);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiscount.MaxLength = 2;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(351, 26);
            this.txtDiscount.TabIndex = 5;
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(110, 296);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 41;
            this.label1.Text = "Price :";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPrice.Location = new System.Drawing.Point(193, 298);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(351, 26);
            this.txtPrice.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(99, 258);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 23);
            this.label7.TabIndex = 43;
            this.label7.Text = "S.GST :";
            // 
            // txtSGST
            // 
            this.txtSGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSGST.Location = new System.Drawing.Point(194, 260);
            this.txtSGST.Margin = new System.Windows.Forms.Padding(4);
            this.txtSGST.MaxLength = 2;
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.Size = new System.Drawing.Size(72, 26);
            this.txtSGST.TabIndex = 7;
            this.txtSGST.Text = "0";
            this.txtSGST.Leave += new System.EventHandler(this.txtSGST_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(269, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 44;
            this.label9.Text = "(%)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(269, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = "(%)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtSGST);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCGST);
            this.panel1.Controls.Add(this.lblVat);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnBrows);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.cbSubCategory);
            this.panel1.Controls.Add(this.cbCategory);
            this.panel1.Controls.Add(this.txtOriginalPrice);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(27, 74);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(610, 634);
            this.panel1.TabIndex = 0;
            // 
            // CreateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(664, 733);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateProduct";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Create Product";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.CreateProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtOriginalPrice;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbSubCategory;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnBrows;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.TextBox txtCGST;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSGST;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
    }
}