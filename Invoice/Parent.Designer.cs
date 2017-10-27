namespace Invoice
{
    partial class Parent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.invoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.subCategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loginDetailsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyRepotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.invoiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.stockMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkOrange;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceToolStripMenuItem,
            this.OrderToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 74);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1884, 31);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // invoiceToolStripMenuItem
            // 
            this.invoiceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem1,
            this.subCategoryToolStripMenuItem1,
            this.productToolStripMenuItem});
            this.invoiceToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.invoiceToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.invoiceToolStripMenuItem.Name = "invoiceToolStripMenuItem";
            this.invoiceToolStripMenuItem.Size = new System.Drawing.Size(125, 27);
            this.invoiceToolStripMenuItem.Text = "Master Entry";
            this.invoiceToolStripMenuItem.ToolTipText = "Master Entry Form";
            // 
            // categoryToolStripMenuItem1
            // 
            this.categoryToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("categoryToolStripMenuItem1.Image")));
            this.categoryToolStripMenuItem1.Name = "categoryToolStripMenuItem1";
            this.categoryToolStripMenuItem1.ShortcutKeyDisplayString = "Alt+C";
            this.categoryToolStripMenuItem1.Size = new System.Drawing.Size(263, 28);
            this.categoryToolStripMenuItem1.Text = "Category";
            this.categoryToolStripMenuItem1.Click += new System.EventHandler(this.categoryToolStripMenuItem1_Click);
            // 
            // subCategoryToolStripMenuItem1
            // 
            this.subCategoryToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("subCategoryToolStripMenuItem1.Image")));
            this.subCategoryToolStripMenuItem1.Name = "subCategoryToolStripMenuItem1";
            this.subCategoryToolStripMenuItem1.ShortcutKeyDisplayString = "Alt+SC";
            this.subCategoryToolStripMenuItem1.Size = new System.Drawing.Size(263, 28);
            this.subCategoryToolStripMenuItem1.Text = "Sub Category";
            this.subCategoryToolStripMenuItem1.Click += new System.EventHandler(this.subCategoryToolStripMenuItem1_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("productToolStripMenuItem.Image")));
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.ShortcutKeyDisplayString = "Alt+P";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(263, 28);
            this.productToolStripMenuItem.Text = "Product";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // OrderToolStripMenuItem
            // 
            this.OrderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationToolStripMenuItem,
            this.loginDetailsToolStripMenuItem});
            this.OrderToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.OrderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem";
            this.OrderToolStripMenuItem.Size = new System.Drawing.Size(76, 27);
            this.OrderToolStripMenuItem.Text = "Orders";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.Image = global::Invoice.Properties.Resources.stocks;
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.ShortcutKeyDisplayString = "Alt+S";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.registrationToolStripMenuItem.Text = "Stocks";
            this.registrationToolStripMenuItem.Click += new System.EventHandler(this.registrationToolStripMenuItem_Click);
            // 
            // loginDetailsToolStripMenuItem
            // 
            this.loginDetailsToolStripMenuItem.Image = global::Invoice.Properties.Resources.stock;
            this.loginDetailsToolStripMenuItem.Name = "loginDetailsToolStripMenuItem";
            this.loginDetailsToolStripMenuItem.ShortcutKeyDisplayString = "Alt+Ctrl+s";
            this.loginDetailsToolStripMenuItem.Size = new System.Drawing.Size(221, 28);
            this.loginDetailsToolStripMenuItem.Text = "Sales";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationToolStripMenuItem1,
            this.loginDetailsToolStripMenuItem1});
            this.usersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.usersToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // registrationToolStripMenuItem1
            // 
            this.registrationToolStripMenuItem1.Image = global::Invoice.Properties.Resources.register;
            this.registrationToolStripMenuItem1.Name = "registrationToolStripMenuItem1";
            this.registrationToolStripMenuItem1.Size = new System.Drawing.Size(191, 28);
            this.registrationToolStripMenuItem1.Text = "Registration";
            // 
            // loginDetailsToolStripMenuItem1
            // 
            this.loginDetailsToolStripMenuItem1.Image = global::Invoice.Properties.Resources.login;
            this.loginDetailsToolStripMenuItem1.Name = "loginDetailsToolStripMenuItem1";
            this.loginDetailsToolStripMenuItem1.Size = new System.Drawing.Size(191, 28);
            this.loginDetailsToolStripMenuItem1.Text = "Login Details";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notepadToolStripMenuItem,
            this.calculatorToolStripMenuItem});
            this.toolsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(62, 27);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("notepadToolStripMenuItem.Image")));
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(167, 28);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Image = global::Invoice.Properties.Resources.cal;
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(167, 28);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dailyRepotToolStripMenuItem,
            this.stockReportToolStripMenuItem,
            this.customerReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(84, 27);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // dailyRepotToolStripMenuItem
            // 
            this.dailyRepotToolStripMenuItem.Image = global::Invoice.Properties.Resources.finances;
            this.dailyRepotToolStripMenuItem.Name = "dailyRepotToolStripMenuItem";
            this.dailyRepotToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.dailyRepotToolStripMenuItem.Text = "Daily Repot";
            // 
            // stockReportToolStripMenuItem
            // 
            this.stockReportToolStripMenuItem.Image = global::Invoice.Properties.Resources.stockreport;
            this.stockReportToolStripMenuItem.Name = "stockReportToolStripMenuItem";
            this.stockReportToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.stockReportToolStripMenuItem.Text = "Stock Report";
            // 
            // customerReportToolStripMenuItem
            // 
            this.customerReportToolStripMenuItem.Image = global::Invoice.Properties.Resources.report_icon;
            this.customerReportToolStripMenuItem.Name = "customerReportToolStripMenuItem";
            this.customerReportToolStripMenuItem.Size = new System.Drawing.Size(223, 28);
            this.customerReportToolStripMenuItem.Text = "Customer Report";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(72, 27);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoiceToolStripMenuItem1,
            this.stockMenuItem,
            this.chartMenuItem,
            this.registrationToolStripMenuItem2,
            this.logoutToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(20, 105);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip2.ShowItemToolTips = true;
            this.menuStrip2.Size = new System.Drawing.Size(1884, 51);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // invoiceToolStripMenuItem1
            // 
            this.invoiceToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.invoiceToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("invoiceToolStripMenuItem1.Image")));
            this.invoiceToolStripMenuItem1.Name = "invoiceToolStripMenuItem1";
            this.invoiceToolStripMenuItem1.Size = new System.Drawing.Size(76, 47);
            this.invoiceToolStripMenuItem1.Text = "Invoice";
            this.invoiceToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.invoiceToolStripMenuItem1.Click += new System.EventHandler(this.invoiceToolStripMenuItem1_Click);
            // 
            // stockMenuItem
            // 
            this.stockMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.stockMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("stockMenuItem.Image")));
            this.stockMenuItem.Name = "stockMenuItem";
            this.stockMenuItem.Size = new System.Drawing.Size(62, 47);
            this.stockMenuItem.Text = "Stock";
            this.stockMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.stockMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // chartMenuItem
            // 
            this.chartMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.chartMenuItem.Image = global::Invoice.Properties.Resources.pie_chart;
            this.chartMenuItem.Name = "chartMenuItem";
            this.chartMenuItem.Size = new System.Drawing.Size(71, 47);
            this.chartMenuItem.Text = "Charts";
            this.chartMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chartMenuItem.Click += new System.EventHandler(this.chartMenuItem_Click);
            // 
            // registrationToolStripMenuItem2
            // 
            this.registrationToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.registrationToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("registrationToolStripMenuItem2.Image")));
            this.registrationToolStripMenuItem2.Name = "registrationToolStripMenuItem2";
            this.registrationToolStripMenuItem2.Size = new System.Drawing.Size(113, 47);
            this.registrationToolStripMenuItem2.Text = "Registration";
            this.registrationToolStripMenuItem2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.registrationToolStripMenuItem2.Click += new System.EventHandler(this.registrationToolStripMenuItem2_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.logoutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logoutToolStripMenuItem.Image")));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(76, 47);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.Window;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Blue;
            this.lblName.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblName.Location = new System.Drawing.Point(1816, 136);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "label1";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.SystemColors.Window;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.ForeColor = System.Drawing.Color.Blue;
            this.lblTimer.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTimer.Location = new System.Drawing.Point(1861, 109);
            this.lblTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(85, 29);
            this.lblTimer.TabIndex = 9;
            this.lblTimer.Text = "label1";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 156);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1884, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1924, 468);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Parent";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Inventory Management";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Parent_FormClosed);
            this.Load += new System.EventHandler(this.Parent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem subCategoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loginDetailsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notepadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem dailyRepotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockReportToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem invoiceToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem OrderToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem2;
        public System.Windows.Forms.ToolStripMenuItem stockMenuItem;
        public System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerReportToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem chartMenuItem;
    }
}