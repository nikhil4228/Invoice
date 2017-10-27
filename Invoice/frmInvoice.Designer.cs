namespace Invoice
{
    partial class frmInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInvoice));
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblCreatedByValue = new System.Windows.Forms.Label();
            this.lblIsReturnedValue = new System.Windows.Forms.Label();
            this.lblIsActiveValue = new System.Windows.Forms.Label();
            this.lblCreatedBy = new System.Windows.Forms.Label();
            this.lblIsReturned = new System.Windows.Forms.Label();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.txtSearchInvNo = new System.Windows.Forms.TextBox();
            this.btnCancelSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSearchInv = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OriginalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.grpDesc = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.grpCust = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustMobile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.grpProduct = new System.Windows.Forms.GroupBox();
            this.txtSGST = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCGST = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblOriginalPrc = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtOriginalPrice = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.txtSaleQty = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtAvailableQty = new System.Windows.Forms.TextBox();
            this.pnlAccount = new System.Windows.Forms.Panel();
            this.cmbCashCard = new System.Windows.Forms.ComboBox();
            this.txtDiscountAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDiscountPer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.payment = new System.Windows.Forms.Label();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.Label14 = new System.Windows.Forms.Label();
            this.grpInvoice = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.dtpInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnSavePrint = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.btnCancelorder = new System.Windows.Forms.Button();
            this.btnReturnOrder = new System.Windows.Forms.Button();
            this.btnSearchPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpDesc.SuspendLayout();
            this.grpCust.SuspendLayout();
            this.grpProduct.SuspendLayout();
            this.pnlAccount.SuspendLayout();
            this.grpInvoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.grpSearch);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.grpDesc);
            this.panel1.Controls.Add(this.grpCust);
            this.panel1.Controls.Add(this.grpProduct);
            this.panel1.Controls.Add(this.pnlAccount);
            this.panel1.Controls.Add(this.grpInvoice);
            this.panel1.Location = new System.Drawing.Point(45, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1556, 784);
            this.panel1.TabIndex = 106;
            // 
            // grpSearch
            // 
            this.grpSearch.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grpSearch.Controls.Add(this.lblCreatedByValue);
            this.grpSearch.Controls.Add(this.lblIsReturnedValue);
            this.grpSearch.Controls.Add(this.lblIsActiveValue);
            this.grpSearch.Controls.Add(this.lblCreatedBy);
            this.grpSearch.Controls.Add(this.lblIsReturned);
            this.grpSearch.Controls.Add(this.lblIsActive);
            this.grpSearch.Controls.Add(this.txtSearchInvNo);
            this.grpSearch.Controls.Add(this.btnCancelSearch);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.lblSearchInv);
            this.grpSearch.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.grpSearch.Location = new System.Drawing.Point(1149, 16);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpSearch.Size = new System.Drawing.Size(377, 164);
            this.grpSearch.TabIndex = 120;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Serach By Invoice";
            // 
            // lblCreatedByValue
            // 
            this.lblCreatedByValue.AutoSize = true;
            this.lblCreatedByValue.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByValue.ForeColor = System.Drawing.Color.Red;
            this.lblCreatedByValue.Location = new System.Drawing.Point(95, 139);
            this.lblCreatedByValue.Name = "lblCreatedByValue";
            this.lblCreatedByValue.Size = new System.Drawing.Size(86, 21);
            this.lblCreatedByValue.TabIndex = 136;
            this.lblCreatedByValue.Text = "UnKnown";
            this.lblCreatedByValue.Visible = false;
            // 
            // lblIsReturnedValue
            // 
            this.lblIsReturnedValue.AutoSize = true;
            this.lblIsReturnedValue.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsReturnedValue.ForeColor = System.Drawing.Color.Red;
            this.lblIsReturnedValue.Location = new System.Drawing.Point(95, 117);
            this.lblIsReturnedValue.Name = "lblIsReturnedValue";
            this.lblIsReturnedValue.Size = new System.Drawing.Size(86, 21);
            this.lblIsReturnedValue.TabIndex = 135;
            this.lblIsReturnedValue.Text = "UnKnown";
            this.lblIsReturnedValue.Visible = false;
            // 
            // lblIsActiveValue
            // 
            this.lblIsActiveValue.AutoSize = true;
            this.lblIsActiveValue.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActiveValue.ForeColor = System.Drawing.Color.Red;
            this.lblIsActiveValue.Location = new System.Drawing.Point(95, 92);
            this.lblIsActiveValue.Name = "lblIsActiveValue";
            this.lblIsActiveValue.Size = new System.Drawing.Size(86, 21);
            this.lblIsActiveValue.TabIndex = 134;
            this.lblIsActiveValue.Text = "UnKnown";
            this.lblIsActiveValue.Visible = false;
            // 
            // lblCreatedBy
            // 
            this.lblCreatedBy.AutoSize = true;
            this.lblCreatedBy.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedBy.Location = new System.Drawing.Point(1, 139);
            this.lblCreatedBy.Name = "lblCreatedBy";
            this.lblCreatedBy.Size = new System.Drawing.Size(91, 21);
            this.lblCreatedBy.TabIndex = 133;
            this.lblCreatedBy.Text = "CreatedBy :";
            this.lblCreatedBy.Visible = false;
            // 
            // lblIsReturned
            // 
            this.lblIsReturned.AutoSize = true;
            this.lblIsReturned.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsReturned.Location = new System.Drawing.Point(1, 117);
            this.lblIsReturned.Name = "lblIsReturned";
            this.lblIsReturned.Size = new System.Drawing.Size(84, 21);
            this.lblIsReturned.TabIndex = 132;
            this.lblIsReturned.Text = "Returned :";
            this.lblIsReturned.Visible = false;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(1, 92);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(78, 21);
            this.lblIsActive.TabIndex = 131;
            this.lblIsActive.Text = "Canceled:";
            this.lblIsActive.Visible = false;
            // 
            // txtSearchInvNo
            // 
            this.txtSearchInvNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSearchInvNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearchInvNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchInvNo.Location = new System.Drawing.Point(99, 23);
            this.txtSearchInvNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearchInvNo.Name = "txtSearchInvNo";
            this.txtSearchInvNo.Size = new System.Drawing.Size(171, 28);
            this.txtSearchInvNo.TabIndex = 130;
            this.txtSearchInvNo.TextChanged += new System.EventHandler(this.txtSearchInvNo_TextChanged);
            // 
            // btnCancelSearch
            // 
            this.btnCancelSearch.BackColor = System.Drawing.Color.Orange;
            this.btnCancelSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelSearch.FlatAppearance.BorderSize = 0;
            this.btnCancelSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelSearch.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSearch.ForeColor = System.Drawing.Color.Black;
            this.btnCancelSearch.Image = global::Invoice.Properties.Resources.backspace_arrow;
            this.btnCancelSearch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancelSearch.Location = new System.Drawing.Point(276, 59);
            this.btnCancelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelSearch.Name = "btnCancelSearch";
            this.btnCancelSearch.Size = new System.Drawing.Size(91, 31);
            this.btnCancelSearch.TabIndex = 128;
            this.btnCancelSearch.Text = "Back";
            this.btnCancelSearch.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancelSearch.UseVisualStyleBackColor = false;
            this.btnCancelSearch.Visible = false;
            this.btnCancelSearch.Click += new System.EventHandler(this.btnCancelSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Orange;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = global::Invoice.Properties.Resources.search_icon1;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSearch.Location = new System.Drawing.Point(276, 22);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(91, 31);
            this.btnSearch.TabIndex = 126;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSearchInv
            // 
            this.lblSearchInv.AutoSize = true;
            this.lblSearchInv.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchInv.ForeColor = System.Drawing.Color.Black;
            this.lblSearchInv.Location = new System.Drawing.Point(5, 27);
            this.lblSearchInv.Name = "lblSearchInv";
            this.lblSearchInv.Size = new System.Drawing.Size(91, 21);
            this.lblSearchInv.TabIndex = 99;
            this.lblSearchInv.Text = "Invoice No.";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.OriginalPrice,
            this.Discount,
            this.CGST,
            this.SGST,
            this.Price,
            this.Qty,
            this.TotalAmount,
            this.aqty,
            this.Status,
            this.Action,
            this.Edit});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(27, 191);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1116, 562);
            this.dataGridView1.TabIndex = 125;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductID.FillWeight = 35.1941F;
            this.ProductID.HeaderText = "ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.FillWeight = 284.7007F;
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // OriginalPrice
            // 
            this.OriginalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.OriginalPrice.FillWeight = 103.7473F;
            this.OriginalPrice.HeaderText = "Original Price";
            this.OriginalPrice.Name = "OriginalPrice";
            this.OriginalPrice.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount(%)";
            this.Discount.Name = "Discount";
            // 
            // CGST
            // 
            this.CGST.HeaderText = "CGST";
            this.CGST.Name = "CGST";
            // 
            // SGST
            // 
            this.SGST.HeaderText = "SGST";
            this.SGST.Name = "SGST";
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Qty.FillWeight = 52.14166F;
            this.Qty.HeaderText = "Qty.";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            this.Qty.Width = 68;
            // 
            // TotalAmount
            // 
            this.TotalAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalAmount.FillWeight = 134.6725F;
            this.TotalAmount.HeaderText = "Total";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // aqty
            // 
            this.aqty.HeaderText = "aqty";
            this.aqty.Name = "aqty";
            this.aqty.Visible = false;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Visible = false;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Action.FillWeight = 13.40973F;
            this.Action.HeaderText = "";
            this.Action.Image = ((System.Drawing.Image)(resources.GetObject("Action.Image")));
            this.Action.Name = "Action";
            this.Action.Width = 5;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 76.13383F;
            this.Edit.HeaderText = "";
            this.Edit.Image = ((System.Drawing.Image)(resources.GetObject("Edit.Image")));
            this.Edit.Name = "Edit";
            this.Edit.ToolTipText = "Edit Item";
            // 
            // grpDesc
            // 
            this.grpDesc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grpDesc.Controls.Add(this.label7);
            this.grpDesc.Controls.Add(this.txtDesc);
            this.grpDesc.Location = new System.Drawing.Point(1149, 604);
            this.grpDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDesc.Name = "grpDesc";
            this.grpDesc.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpDesc.Size = new System.Drawing.Size(377, 105);
            this.grpDesc.TabIndex = 124;
            this.grpDesc.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 21);
            this.label7.TabIndex = 99;
            this.label7.Text = "Description";
            // 
            // txtDesc
            // 
            this.txtDesc.BackColor = System.Drawing.Color.White;
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(109, 21);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDesc.MaxLength = 300;
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(235, 70);
            this.txtDesc.TabIndex = 12;
            // 
            // grpCust
            // 
            this.grpCust.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grpCust.Controls.Add(this.label13);
            this.grpCust.Controls.Add(this.txtEmail);
            this.grpCust.Controls.Add(this.label6);
            this.grpCust.Controls.Add(this.txtCustAddress);
            this.grpCust.Controls.Add(this.label1);
            this.grpCust.Controls.Add(this.txtCustMobile);
            this.grpCust.Controls.Add(this.label2);
            this.grpCust.Controls.Add(this.txtCustName);
            this.grpCust.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.grpCust.Location = new System.Drawing.Point(1149, 361);
            this.grpCust.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCust.Name = "grpCust";
            this.grpCust.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpCust.Size = new System.Drawing.Size(377, 234);
            this.grpCust.TabIndex = 123;
            this.grpCust.TabStop = false;
            this.grpCust.Text = "Customer Details";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 21);
            this.label13.TabIndex = 80;
            this.label13.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(109, 98);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 26);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(27, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 21);
            this.label6.TabIndex = 78;
            this.label6.Text = "Address";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCustAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAddress.Location = new System.Drawing.Point(109, 133);
            this.txtCustAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustAddress.MaxLength = 150;
            this.txtCustAddress.Multiline = true;
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(235, 84);
            this.txtCustAddress.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 76;
            this.label1.Text = "Mobile";
            // 
            // txtCustMobile
            // 
            this.txtCustMobile.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCustMobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustMobile.Location = new System.Drawing.Point(109, 64);
            this.txtCustMobile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustMobile.MaxLength = 10;
            this.txtCustMobile.Name = "txtCustMobile";
            this.txtCustMobile.Size = new System.Drawing.Size(235, 26);
            this.txtCustMobile.TabIndex = 9;
            this.txtCustMobile.TextChanged += new System.EventHandler(this.txtCustMobile_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 74;
            this.label2.Text = "Name";
            // 
            // txtCustName
            // 
            this.txtCustName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(109, 30);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCustName.MaxLength = 30;
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(235, 26);
            this.txtCustName.TabIndex = 8;
            // 
            // grpProduct
            // 
            this.grpProduct.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grpProduct.Controls.Add(this.txtSGST);
            this.grpProduct.Controls.Add(this.label15);
            this.grpProduct.Controls.Add(this.txtCGST);
            this.grpProduct.Controls.Add(this.txtDiscount);
            this.grpProduct.Controls.Add(this.lblVAT);
            this.grpProduct.Controls.Add(this.lblOriginalPrc);
            this.grpProduct.Controls.Add(this.lblDiscount);
            this.grpProduct.Controls.Add(this.txtOriginalPrice);
            this.grpProduct.Controls.Add(this.btnClear);
            this.grpProduct.Controls.Add(this.btnCancel);
            this.grpProduct.Controls.Add(this.btnUpdateCart);
            this.grpProduct.Controls.Add(this.btnAddToCart);
            this.grpProduct.Controls.Add(this.txtTotalAmount);
            this.grpProduct.Controls.Add(this.Label11);
            this.grpProduct.Controls.Add(this.Label5);
            this.grpProduct.Controls.Add(this.txtProductName);
            this.grpProduct.Controls.Add(this.Label12);
            this.grpProduct.Controls.Add(this.txtSaleQty);
            this.grpProduct.Controls.Add(this.Label9);
            this.grpProduct.Controls.Add(this.txtPrice);
            this.grpProduct.Controls.Add(this.Label10);
            this.grpProduct.Controls.Add(this.txtAvailableQty);
            this.grpProduct.Font = new System.Drawing.Font("Palatino Linotype", 9F);
            this.grpProduct.ForeColor = System.Drawing.Color.Black;
            this.grpProduct.Location = new System.Drawing.Point(27, 16);
            this.grpProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProduct.Name = "grpProduct";
            this.grpProduct.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpProduct.Size = new System.Drawing.Size(709, 169);
            this.grpProduct.TabIndex = 122;
            this.grpProduct.TabStop = false;
            this.grpProduct.Text = "Product Details";
            // 
            // txtSGST
            // 
            this.txtSGST.Enabled = false;
            this.txtSGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGST.Location = new System.Drawing.Point(504, 64);
            this.txtSGST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSGST.Name = "txtSGST";
            this.txtSGST.ReadOnly = true;
            this.txtSGST.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSGST.Size = new System.Drawing.Size(32, 20);
            this.txtSGST.TabIndex = 103;
            this.txtSGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(453, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 17);
            this.label15.TabIndex = 104;
            this.label15.Text = "SGST%";
            // 
            // txtCGST
            // 
            this.txtCGST.Enabled = false;
            this.txtCGST.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGST.Location = new System.Drawing.Point(417, 64);
            this.txtCGST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCGST.Name = "txtCGST";
            this.txtCGST.ReadOnly = true;
            this.txtCGST.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCGST.Size = new System.Drawing.Size(31, 20);
            this.txtCGST.TabIndex = 101;
            this.txtCGST.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(317, 63);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.ReadOnly = true;
            this.txtDiscount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscount.Size = new System.Drawing.Size(44, 26);
            this.txtDiscount.TabIndex = 98;
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Palatino Linotype", 6.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVAT.Location = new System.Drawing.Point(365, 67);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(50, 17);
            this.lblVAT.TabIndex = 102;
            this.lblVAT.Text = "CGST%";
            // 
            // lblOriginalPrc
            // 
            this.lblOriginalPrc.AutoSize = true;
            this.lblOriginalPrc.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalPrc.Location = new System.Drawing.Point(21, 66);
            this.lblOriginalPrc.Name = "lblOriginalPrc";
            this.lblOriginalPrc.Size = new System.Drawing.Size(110, 21);
            this.lblOriginalPrc.TabIndex = 100;
            this.lblOriginalPrc.Text = "Original Price";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(222, 66);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(89, 19);
            this.lblDiscount.TabIndex = 99;
            this.lblDiscount.Text = "Discount(%)";
            // 
            // txtOriginalPrice
            // 
            this.txtOriginalPrice.Enabled = false;
            this.txtOriginalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginalPrice.Location = new System.Drawing.Point(139, 63);
            this.txtOriginalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOriginalPrice.Name = "txtOriginalPrice";
            this.txtOriginalPrice.ReadOnly = true;
            this.txtOriginalPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOriginalPrice.Size = new System.Drawing.Size(77, 26);
            this.txtOriginalPrice.TabIndex = 97;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Orange;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Image = global::Invoice.Properties.Resources.backspace_arrow;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnClear.Location = new System.Drawing.Point(612, 133);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(88, 31);
            this.btnClear.TabIndex = 96;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.BackgroundImage = global::Invoice.Properties.Resources.Edit_8;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = global::Invoice.Properties.Resources.backspace_arrow;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancel.Location = new System.Drawing.Point(604, 64);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 31);
            this.btnCancel.TabIndex = 95;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdateCart
            // 
            this.btnUpdateCart.BackColor = System.Drawing.Color.Orange;
            this.btnUpdateCart.FlatAppearance.BorderSize = 0;
            this.btnUpdateCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateCart.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnUpdateCart.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateCart.Image = global::Invoice.Properties.Resources.Edit_icon;
            this.btnUpdateCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCart.Location = new System.Drawing.Point(571, 30);
            this.btnUpdateCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdateCart.Name = "btnUpdateCart";
            this.btnUpdateCart.Size = new System.Drawing.Size(129, 31);
            this.btnUpdateCart.TabIndex = 94;
            this.btnUpdateCart.Text = "Update Cart";
            this.btnUpdateCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCart.UseVisualStyleBackColor = false;
            this.btnUpdateCart.Visible = false;
            this.btnUpdateCart.Click += new System.EventHandler(this.btnUpdateCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.Orange;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.ForeColor = System.Drawing.Color.Black;
            this.btnAddToCart.Image = global::Invoice.Properties.Resources.Add_icon;
            this.btnAddToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddToCart.Location = new System.Drawing.Point(589, 98);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(111, 31);
            this.btnAddToCart.TabIndex = 2;
            this.btnAddToCart.Text = "&Add Cart";
            this.btnAddToCart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddToCart.UseVisualStyleBackColor = false;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalAmount.Location = new System.Drawing.Point(401, 134);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTotalAmount.Size = new System.Drawing.Size(133, 26);
            this.txtTotalAmount.TabIndex = 93;
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.Location = new System.Drawing.Point(29, 132);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(74, 21);
            this.Label11.TabIndex = 89;
            this.Label11.Text = "Sale Qty.";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(21, 31);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(110, 21);
            this.Label5.TabIndex = 74;
            this.Label5.Text = "Product Name";
            // 
            // txtProductName
            // 
            this.txtProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(139, 28);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(397, 26);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(27, 97);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(81, 21);
            this.Label12.TabIndex = 87;
            this.Label12.Text = "Unit Price";
            // 
            // txtSaleQty
            // 
            this.txtSaleQty.Enabled = false;
            this.txtSaleQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaleQty.Location = new System.Drawing.Point(139, 130);
            this.txtSaleQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSaleQty.MaxLength = 10;
            this.txtSaleQty.Name = "txtSaleQty";
            this.txtSaleQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSaleQty.Size = new System.Drawing.Size(133, 26);
            this.txtSaleQty.TabIndex = 3;
            this.txtSaleQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaleQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSaleQty_KeyUp);
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(281, 102);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(108, 21);
            this.Label9.TabIndex = 75;
            this.Label9.Text = "Available Qty";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(139, 97);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPrice.Size = new System.Drawing.Size(133, 26);
            this.txtPrice.TabIndex = 0;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(279, 138);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(107, 21);
            this.Label10.TabIndex = 76;
            this.Label10.Text = "Total Amount";
            // 
            // txtAvailableQty
            // 
            this.txtAvailableQty.Enabled = false;
            this.txtAvailableQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAvailableQty.Location = new System.Drawing.Point(401, 98);
            this.txtAvailableQty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAvailableQty.Name = "txtAvailableQty";
            this.txtAvailableQty.ReadOnly = true;
            this.txtAvailableQty.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAvailableQty.Size = new System.Drawing.Size(133, 26);
            this.txtAvailableQty.TabIndex = 0;
            // 
            // pnlAccount
            // 
            this.pnlAccount.BackColor = System.Drawing.Color.LightSkyBlue;
            this.pnlAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAccount.Controls.Add(this.cmbCashCard);
            this.pnlAccount.Controls.Add(this.txtDiscountAmount);
            this.pnlAccount.Controls.Add(this.label17);
            this.pnlAccount.Controls.Add(this.txtDiscountPer);
            this.pnlAccount.Controls.Add(this.label8);
            this.pnlAccount.Controls.Add(this.payment);
            this.pnlAccount.Controls.Add(this.txtGrandTotal);
            this.pnlAccount.Controls.Add(this.Label16);
            this.pnlAccount.Controls.Add(this.txtSubTotal);
            this.pnlAccount.Controls.Add(this.Label14);
            this.pnlAccount.Location = new System.Drawing.Point(1149, 191);
            this.pnlAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlAccount.Name = "pnlAccount";
            this.pnlAccount.Size = new System.Drawing.Size(377, 158);
            this.pnlAccount.TabIndex = 121;
            // 
            // cmbCashCard
            // 
            this.cmbCashCard.FormattingEnabled = true;
            this.cmbCashCard.Items.AddRange(new object[] {
            "Cash",
            "Card"});
            this.cmbCashCard.Location = new System.Drawing.Point(125, 118);
            this.cmbCashCard.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCashCard.Name = "cmbCashCard";
            this.cmbCashCard.Size = new System.Drawing.Size(217, 24);
            this.cmbCashCard.TabIndex = 102;
            // 
            // txtDiscountAmount
            // 
            this.txtDiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountAmount.Location = new System.Drawing.Point(216, 49);
            this.txtDiscountAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscountAmount.Name = "txtDiscountAmount";
            this.txtDiscountAmount.ReadOnly = true;
            this.txtDiscountAmount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscountAmount.Size = new System.Drawing.Size(127, 26);
            this.txtDiscountAmount.TabIndex = 7;
            this.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(183, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 26);
            this.label17.TabIndex = 101;
            this.label17.Text = "%";
            // 
            // txtDiscountPer
            // 
            this.txtDiscountPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPer.Location = new System.Drawing.Point(125, 50);
            this.txtDiscountPer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDiscountPer.MaxLength = 2;
            this.txtDiscountPer.Name = "txtDiscountPer";
            this.txtDiscountPer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDiscountPer.Size = new System.Drawing.Size(52, 26);
            this.txtDiscountPer.TabIndex = 6;
            this.txtDiscountPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDiscountPer.Leave += new System.EventHandler(this.txtDiscountPer_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 21);
            this.label8.TabIndex = 99;
            this.label8.Text = "Discount";
            // 
            // payment
            // 
            this.payment.AutoSize = true;
            this.payment.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payment.Location = new System.Drawing.Point(28, 118);
            this.payment.Name = "payment";
            this.payment.Size = new System.Drawing.Size(85, 21);
            this.payment.TabIndex = 95;
            this.payment.Text = "Cash/Card";
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrandTotal.Location = new System.Drawing.Point(125, 84);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.ReadOnly = true;
            this.txtGrandTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGrandTotal.Size = new System.Drawing.Size(217, 26);
            this.txtGrandTotal.TabIndex = 9;
            this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(25, 87);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(97, 21);
            this.Label16.TabIndex = 94;
            this.Label16.Text = "Grand Total";
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubTotal.Location = new System.Drawing.Point(125, 14);
            this.txtSubTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.ReadOnly = true;
            this.txtSubTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubTotal.Size = new System.Drawing.Size(217, 26);
            this.txtSubTotal.TabIndex = 5;
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label14.Location = new System.Drawing.Point(31, 17);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(78, 21);
            this.Label14.TabIndex = 77;
            this.Label14.Text = "Sub Total";
            // 
            // grpInvoice
            // 
            this.grpInvoice.BackColor = System.Drawing.Color.LightSkyBlue;
            this.grpInvoice.Controls.Add(this.Label4);
            this.grpInvoice.Controls.Add(this.Label3);
            this.grpInvoice.Controls.Add(this.txtInvoiceNo);
            this.grpInvoice.Controls.Add(this.dtpInvoiceDate);
            this.grpInvoice.Location = new System.Drawing.Point(741, 16);
            this.grpInvoice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInvoice.Name = "grpInvoice";
            this.grpInvoice.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grpInvoice.Size = new System.Drawing.Size(324, 98);
            this.grpInvoice.TabIndex = 119;
            this.grpInvoice.TabStop = false;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Black;
            this.Label4.Location = new System.Drawing.Point(9, 22);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(91, 21);
            this.Label4.TabIndex = 99;
            this.Label4.Text = "Invoice No.";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(9, 57);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 21);
            this.Label3.TabIndex = 100;
            this.Label3.Text = "Invoice Date";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(121, 18);
            this.txtInvoiceNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.ReadOnly = true;
            this.txtInvoiceNo.Size = new System.Drawing.Size(187, 26);
            this.txtInvoiceNo.TabIndex = 101;
            // 
            // dtpInvoiceDate
            // 
            this.dtpInvoiceDate.CustomFormat = "MM/dd/yyyy";
            this.dtpInvoiceDate.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInvoiceDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInvoiceDate.Location = new System.Drawing.Point(121, 54);
            this.dtpInvoiceDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpInvoiceDate.Name = "dtpInvoiceDate";
            this.dtpInvoiceDate.Size = new System.Drawing.Size(187, 30);
            this.dtpInvoiceDate.TabIndex = 4;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.FillWeight = 13.40973F;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 76.13383F;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ToolTipText = "Edit Item";
            this.dataGridViewImageColumn2.Width = 81;
            // 
            // btnSavePrint
            // 
            this.btnSavePrint.BackColor = System.Drawing.Color.Orange;
            this.btnSavePrint.FlatAppearance.BorderSize = 0;
            this.btnSavePrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavePrint.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePrint.Image = global::Invoice.Properties.Resources.save_icon1;
            this.btnSavePrint.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSavePrint.Location = new System.Drawing.Point(741, 894);
            this.btnSavePrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSavePrint.Name = "btnSavePrint";
            this.btnSavePrint.Size = new System.Drawing.Size(149, 30);
            this.btnSavePrint.TabIndex = 13;
            this.btnSavePrint.Text = "Save && Print Receipt";
            this.btnSavePrint.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSavePrint.UseVisualStyleBackColor = false;
            this.btnSavePrint.Click += new System.EventHandler(this.btnSavePrint_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Orange;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Image = global::Invoice.Properties.Resources.backspace_arrow;
            this.btnRemove.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnRemove.Location = new System.Drawing.Point(909, 894);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(83, 30);
            this.btnRemove.TabIndex = 112;
            this.btnRemove.Text = "&Clear";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // btnCancelorder
            // 
            this.btnCancelorder.BackColor = System.Drawing.Color.Orange;
            this.btnCancelorder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelorder.FlatAppearance.BorderSize = 0;
            this.btnCancelorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelorder.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelorder.ForeColor = System.Drawing.Color.Black;
            this.btnCancelorder.Image = global::Invoice.Properties.Resources.backspace_arrow;
            this.btnCancelorder.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancelorder.Location = new System.Drawing.Point(1432, 885);
            this.btnCancelorder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancelorder.Name = "btnCancelorder";
            this.btnCancelorder.Size = new System.Drawing.Size(143, 31);
            this.btnCancelorder.TabIndex = 131;
            this.btnCancelorder.Text = "Cancel Order";
            this.btnCancelorder.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCancelorder.UseVisualStyleBackColor = false;
            this.btnCancelorder.Visible = false;
            this.btnCancelorder.Click += new System.EventHandler(this.btnCancelorder_Click);
            // 
            // btnReturnOrder
            // 
            this.btnReturnOrder.BackColor = System.Drawing.Color.Orange;
            this.btnReturnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnReturnOrder.FlatAppearance.BorderSize = 0;
            this.btnReturnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnOrder.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnReturnOrder.Image = global::Invoice.Properties.Resources.back_arrow;
            this.btnReturnOrder.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnReturnOrder.Location = new System.Drawing.Point(1285, 885);
            this.btnReturnOrder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReturnOrder.Name = "btnReturnOrder";
            this.btnReturnOrder.Size = new System.Drawing.Size(143, 31);
            this.btnReturnOrder.TabIndex = 130;
            this.btnReturnOrder.Text = "Return Order";
            this.btnReturnOrder.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnReturnOrder.UseVisualStyleBackColor = false;
            this.btnReturnOrder.Visible = false;
            this.btnReturnOrder.Click += new System.EventHandler(this.btnReturnOrder_Click);
            // 
            // btnSearchPrint
            // 
            this.btnSearchPrint.BackColor = System.Drawing.Color.Orange;
            this.btnSearchPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSearchPrint.FlatAppearance.BorderSize = 0;
            this.btnSearchPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPrint.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPrint.ForeColor = System.Drawing.Color.Black;
            this.btnSearchPrint.Image = global::Invoice.Properties.Resources.print_2_icon;
            this.btnSearchPrint.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnSearchPrint.Location = new System.Drawing.Point(1139, 885);
            this.btnSearchPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchPrint.Name = "btnSearchPrint";
            this.btnSearchPrint.Size = new System.Drawing.Size(143, 31);
            this.btnSearchPrint.TabIndex = 132;
            this.btnSearchPrint.Text = "Print Receipt";
            this.btnSearchPrint.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnSearchPrint.UseVisualStyleBackColor = false;
            this.btnSearchPrint.Visible = false;
            this.btnSearchPrint.Click += new System.EventHandler(this.btnSearchPrint_Click);
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1778, 935);
            this.Controls.Add(this.btnSearchPrint);
            this.Controls.Add(this.btnCancelorder);
            this.Controls.Add(this.btnReturnOrder);
            this.Controls.Add(this.btnSavePrint);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "frmInvoice";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "&Invoice Entry";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.panel1.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpDesc.ResumeLayout(false);
            this.grpDesc.PerformLayout();
            this.grpCust.ResumeLayout(false);
            this.grpCust.PerformLayout();
            this.grpProduct.ResumeLayout(false);
            this.grpProduct.PerformLayout();
            this.pnlAccount.ResumeLayout(false);
            this.pnlAccount.PerformLayout();
            this.grpInvoice.ResumeLayout(false);
            this.grpInvoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpInvoice;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtInvoiceNo;
        internal System.Windows.Forms.DateTimePicker dtpInvoiceDate;
        internal System.Windows.Forms.Panel pnlAccount;
        internal System.Windows.Forms.TextBox txtDiscountAmount;
        internal System.Windows.Forms.Label label17;
        internal System.Windows.Forms.TextBox txtDiscountPer;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.Label payment;
        internal System.Windows.Forms.TextBox txtGrandTotal;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.TextBox txtSubTotal;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.GroupBox grpProduct;
        internal System.Windows.Forms.TextBox txtTotalAmount;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtProductName;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.TextBox txtSaleQty;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtPrice;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.TextBox txtAvailableQty;
        internal System.Windows.Forms.GroupBox grpCust;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox txtCustAddress;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox txtCustMobile;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtCustName;
        internal System.Windows.Forms.Button btnRemove;
        internal System.Windows.Forms.Button btnSavePrint;
        private System.Windows.Forms.GroupBox grpDesc;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.TextBox txtDesc;
        internal System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Button btnUpdateCart;
        internal System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.GroupBox grpSearch;
        internal System.Windows.Forms.Label lblSearchInv;
        internal System.Windows.Forms.Button btnSearch;
        internal System.Windows.Forms.Button btnCancelSearch;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.TextBox txtEmail;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        internal System.Windows.Forms.TextBox txtSearchInvNo;
        internal System.Windows.Forms.Button btnCancelorder;
        internal System.Windows.Forms.Button btnReturnOrder;
        internal System.Windows.Forms.Button btnSearchPrint;
        internal System.Windows.Forms.Label lblIsActive;
        internal System.Windows.Forms.Label lblIsReturned;
        internal System.Windows.Forms.Label lblCreatedBy;
        internal System.Windows.Forms.Label lblIsActiveValue;
        internal System.Windows.Forms.Label lblIsReturnedValue;
        internal System.Windows.Forms.Label lblCreatedByValue;
        internal System.Windows.Forms.Label lblOriginalPrc;
        internal System.Windows.Forms.Label lblDiscount;
        internal System.Windows.Forms.TextBox txtOriginalPrice;
        internal System.Windows.Forms.TextBox txtDiscount;
        internal System.Windows.Forms.Label lblVAT;
        internal System.Windows.Forms.TextBox txtCGST;
        private System.Windows.Forms.ComboBox cmbCashCard;
        internal System.Windows.Forms.TextBox txtSGST;
        internal System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn aqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewImageColumn Action;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
    }
}