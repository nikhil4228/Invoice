namespace Invoice
{
    partial class frmStocks
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
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.dtpStockDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFeatures = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateStock.FlatAppearance.BorderSize = 0;
            this.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStock.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateStock.Image = global::Invoice.Properties.Resources.Edit_icon;
            this.btnUpdateStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStock.Location = new System.Drawing.Point(298, 362);
            this.btnUpdateStock.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(104, 25);
            this.btnUpdateStock.TabIndex = 104;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // cmbProducts
            // 
            this.cmbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(198, 72);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(373, 24);
            this.cmbProducts.TabIndex = 103;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // dtpStockDate
            // 
            this.dtpStockDate.CustomFormat = "dd/MM/yyyy";
            this.dtpStockDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpStockDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStockDate.Location = new System.Drawing.Point(198, 279);
            this.dtpStockDate.Name = "dtpStockDate";
            this.dtpStockDate.Size = new System.Drawing.Size(373, 23);
            this.dtpStockDate.TabIndex = 100;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(95, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 102;
            this.label6.Text = "Stock Date :";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtQty.Location = new System.Drawing.Point(198, 246);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(373, 23);
            this.txtQty.TabIndex = 99;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(105, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 101;
            this.label4.Text = "Quantity :";
            // 
            // txtFeatures
            // 
            this.txtFeatures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtFeatures.Location = new System.Drawing.Point(198, 107);
            this.txtFeatures.Name = "txtFeatures";
            this.txtFeatures.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.txtFeatures.Size = new System.Drawing.Size(373, 130);
            this.txtFeatures.TabIndex = 97;
            this.txtFeatures.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(111, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 98;
            this.label2.Text = "Features :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(73, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 96;
            this.label1.Text = "Product Name :";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.ForeColor = System.Drawing.Color.Red;
            this.lblCount.Location = new System.Drawing.Point(577, 278);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(0, 17);
            this.lblCount.TabIndex = 105;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold);
            this.lblNotification.ForeColor = System.Drawing.Color.Red;
            this.lblNotification.Location = new System.Drawing.Point(295, 405);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(0, 19);
            this.lblNotification.TabIndex = 106;
            // 
            // frmStocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 434);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.dtpStockDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFeatures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStocks";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Stock Details";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmStocks_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.ComboBox cmbProducts;
        public System.Windows.Forms.DateTimePicker dtpStockDate;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.RichTextBox txtFeatures;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblNotification;

    }
}