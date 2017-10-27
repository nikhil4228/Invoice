namespace Invoice
{
    partial class Sub_Category
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSubCategory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1438, 635);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSubCategory
            // 
            this.btnSubCategory.BackColor = System.Drawing.Color.Orange;
            this.btnSubCategory.FlatAppearance.BorderSize = 0;
            this.btnSubCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubCategory.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnSubCategory.ForeColor = System.Drawing.Color.Black;
            this.btnSubCategory.Location = new System.Drawing.Point(27, 53);
            this.btnSubCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubCategory.Name = "btnSubCategory";
            this.btnSubCategory.Size = new System.Drawing.Size(179, 48);
            this.btnSubCategory.TabIndex = 1;
            this.btnSubCategory.Text = "Add Sub Category";
            this.btnSubCategory.UseVisualStyleBackColor = false;
            this.btnSubCategory.Click += new System.EventHandler(this.btnSubCat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(27, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1438, 635);
            this.panel1.TabIndex = 2;
            // 
            // Sub_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1492, 785);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSubCategory);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sub_Category";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "SubCategory";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSubCategory;
        private System.Windows.Forms.Panel panel1;
    }
}