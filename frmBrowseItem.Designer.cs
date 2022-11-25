namespace Capstone
{
    partial class frmBrowseItem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddSearchItem = new System.Windows.Forms.DataGridViewImageColumn();
            this.TypeSearchItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescSearchItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.PCodeSearchItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSearchItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewBrowse = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLensecheck = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblItemIDCheck = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTrans = new System.Windows.Forms.Label();
            this.lblTransNo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PriceSearchItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSearchItem = new System.Windows.Forms.DataGridView();
            this.NumBrowseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescBrowseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeBrowseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductBrowseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBrowseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UNIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LensChe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceReal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToCart = new System.Windows.Forms.DataGridViewImageColumn();
            this.StockID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrowse)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchItem)).BeginInit();
            this.SuspendLayout();
            // 
            // AddSearchItem
            // 
            this.AddSearchItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddSearchItem.HeaderText = "";
            this.AddSearchItem.MinimumWidth = 6;
            this.AddSearchItem.Name = "AddSearchItem";
            this.AddSearchItem.Width = 24;
            // 
            // TypeSearchItem
            // 
            this.TypeSearchItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TypeSearchItem.HeaderText = "TYPE";
            this.TypeSearchItem.MinimumWidth = 6;
            this.TypeSearchItem.Name = "TypeSearchItem";
            this.TypeSearchItem.Width = 81;
            // 
            // DescSearchItem
            // 
            this.DescSearchItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescSearchItem.HeaderText = "DESCRIPTION";
            this.DescSearchItem.MinimumWidth = 6;
            this.DescSearchItem.Name = "DescSearchItem";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(23, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search Description Here";
            this.txtSearch.Size = new System.Drawing.Size(619, 38);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // PCodeSearchItem
            // 
            this.PCodeSearchItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PCodeSearchItem.HeaderText = "PCODE";
            this.PCodeSearchItem.MinimumWidth = 6;
            this.PCodeSearchItem.Name = "PCodeSearchItem";
            // 
            // NumSearchItem
            // 
            this.NumSearchItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumSearchItem.HeaderText = "#";
            this.NumSearchItem.MinimumWidth = 6;
            this.NumSearchItem.Name = "NumSearchItem";
            this.NumSearchItem.Width = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Browse Item";
            // 
            // dataGridViewBrowse
            // 
            this.dataGridViewBrowse.AllowUserToAddRows = false;
            this.dataGridViewBrowse.AllowUserToResizeColumns = false;
            this.dataGridViewBrowse.AllowUserToResizeRows = false;
            this.dataGridViewBrowse.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewBrowse.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBrowse.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBrowse.ColumnHeadersHeight = 40;
            this.dataGridViewBrowse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewBrowse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumBrowseItem,
            this.ID,
            this.DescBrowseItem,
            this.TypeBrowseItem,
            this.ProductBrowseItem,
            this.PriceBrowseItem,
            this.Stock,
            this.Classification,
            this.UNIT,
            this.LensChe,
            this.priceReal,
            this.AddToCart,
            this.StockID,
            this.StockNum,
            this.UM});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewBrowse.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBrowse.EnableHeadersVisualStyles = false;
            this.dataGridViewBrowse.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewBrowse.Location = new System.Drawing.Point(0, 120);
            this.dataGridViewBrowse.Name = "dataGridViewBrowse";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewBrowse.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBrowse.RowHeadersVisible = false;
            this.dataGridViewBrowse.RowHeadersWidth = 51;
            this.dataGridViewBrowse.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewBrowse.RowTemplate.Height = 35;
            this.dataGridViewBrowse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBrowse.Size = new System.Drawing.Size(1315, 810);
            this.dataGridViewBrowse.TabIndex = 7;
            this.dataGridViewBrowse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewBrowse_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lblLensecheck);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 120);
            this.panel1.TabIndex = 6;
            // 
            // lblLensecheck
            // 
            this.lblLensecheck.AutoSize = true;
            this.lblLensecheck.Location = new System.Drawing.Point(923, 22);
            this.lblLensecheck.Name = "lblLensecheck";
            this.lblLensecheck.Size = new System.Drawing.Size(62, 28);
            this.lblLensecheck.TabIndex = 11;
            this.lblLensecheck.Text = "         l";
            this.lblLensecheck.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.lblItemIDCheck);
            this.panel2.Controls.Add(this.lblStock);
            this.panel2.Controls.Add(this.lblCheck);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblTrans);
            this.panel2.Controls.Add(this.lblTransNo);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 54);
            this.panel2.TabIndex = 36;
            // 
            // lblItemIDCheck
            // 
            this.lblItemIDCheck.AutoSize = true;
            this.lblItemIDCheck.Location = new System.Drawing.Point(795, 18);
            this.lblItemIDCheck.Name = "lblItemIDCheck";
            this.lblItemIDCheck.Size = new System.Drawing.Size(42, 28);
            this.lblItemIDCheck.TabIndex = 10;
            this.lblItemIDCheck.Text = "      ";
            this.lblItemIDCheck.Visible = false;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(679, 15);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(42, 28);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "      ";
            this.lblStock.Visible = false;
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(991, 15);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(57, 28);
            this.lblCheck.TabIndex = 4;
            this.lblCheck.Text = "         ";
            this.lblCheck.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1153, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Location = new System.Drawing.Point(1228, 20);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(42, 28);
            this.lblTrans.TabIndex = 2;
            this.lblTrans.Text = "      ";
            this.lblTrans.Visible = false;
            // 
            // lblTransNo
            // 
            this.lblTransNo.AutoSize = true;
            this.lblTransNo.Location = new System.Drawing.Point(1162, 15);
            this.lblTransNo.Name = "lblTransNo";
            this.lblTransNo.Size = new System.Drawing.Size(0, 28);
            this.lblTransNo.TabIndex = 1;
            this.lblTransNo.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1263, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PriceSearchItem
            // 
            this.PriceSearchItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PriceSearchItem.HeaderText = "PRICE";
            this.PriceSearchItem.MinimumWidth = 6;
            this.PriceSearchItem.Name = "PriceSearchItem";
            this.PriceSearchItem.Width = 89;
            // 
            // dataGridViewSearchItem
            // 
            this.dataGridViewSearchItem.AllowUserToResizeColumns = false;
            this.dataGridViewSearchItem.AllowUserToResizeRows = false;
            this.dataGridViewSearchItem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSearchItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSearchItem.ColumnHeadersHeight = 40;
            this.dataGridViewSearchItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSearchItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumSearchItem,
            this.PCodeSearchItem,
            this.DescSearchItem,
            this.TypeSearchItem,
            this.PriceSearchItem,
            this.AddSearchItem});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchItem.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSearchItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSearchItem.EnableHeadersVisualStyles = false;
            this.dataGridViewSearchItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewSearchItem.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSearchItem.Name = "dataGridViewSearchItem";
            this.dataGridViewSearchItem.RowHeadersVisible = false;
            this.dataGridViewSearchItem.RowHeadersWidth = 51;
            this.dataGridViewSearchItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSearchItem.RowTemplate.Height = 29;
            this.dataGridViewSearchItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchItem.Size = new System.Drawing.Size(1315, 930);
            this.dataGridViewSearchItem.TabIndex = 8;
            // 
            // NumBrowseItem
            // 
            this.NumBrowseItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumBrowseItem.HeaderText = "#";
            this.NumBrowseItem.MinimumWidth = 6;
            this.NumBrowseItem.Name = "NumBrowseItem";
            this.NumBrowseItem.ReadOnly = true;
            this.NumBrowseItem.Width = 51;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.HeaderText = "ITEM ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            this.ID.Width = 106;
            // 
            // DescBrowseItem
            // 
            this.DescBrowseItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DescBrowseItem.HeaderText = "DESCRIPTION";
            this.DescBrowseItem.MinimumWidth = 6;
            this.DescBrowseItem.Name = "DescBrowseItem";
            this.DescBrowseItem.ReadOnly = true;
            this.DescBrowseItem.Width = 159;
            // 
            // TypeBrowseItem
            // 
            this.TypeBrowseItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TypeBrowseItem.HeaderText = "TYPE";
            this.TypeBrowseItem.MinimumWidth = 6;
            this.TypeBrowseItem.Name = "TypeBrowseItem";
            this.TypeBrowseItem.ReadOnly = true;
            // 
            // ProductBrowseItem
            // 
            this.ProductBrowseItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductBrowseItem.HeaderText = "PRODUCT";
            this.ProductBrowseItem.MinimumWidth = 6;
            this.ProductBrowseItem.Name = "ProductBrowseItem";
            this.ProductBrowseItem.ReadOnly = true;
            this.ProductBrowseItem.Width = 127;
            // 
            // PriceBrowseItem
            // 
            this.PriceBrowseItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PriceBrowseItem.HeaderText = "PRICE";
            this.PriceBrowseItem.MinimumWidth = 6;
            this.PriceBrowseItem.Name = "PriceBrowseItem";
            this.PriceBrowseItem.ReadOnly = true;
            this.PriceBrowseItem.Width = 89;
            // 
            // Stock
            // 
            this.Stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Stock.HeaderText = "STOCK";
            this.Stock.MinimumWidth = 6;
            this.Stock.Name = "Stock";
            this.Stock.ReadOnly = true;
            this.Stock.Width = 98;
            // 
            // Classification
            // 
            this.Classification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Classification.HeaderText = "CLASSIFICATION";
            this.Classification.MinimumWidth = 6;
            this.Classification.Name = "Classification";
            this.Classification.ReadOnly = true;
            this.Classification.Width = 185;
            // 
            // UNIT
            // 
            this.UNIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.UNIT.HeaderText = "UNIT";
            this.UNIT.MinimumWidth = 6;
            this.UNIT.Name = "UNIT";
            this.UNIT.ReadOnly = true;
            this.UNIT.Width = 83;
            // 
            // LensChe
            // 
            this.LensChe.HeaderText = "LenseCheck";
            this.LensChe.MinimumWidth = 6;
            this.LensChe.Name = "LensChe";
            this.LensChe.Visible = false;
            this.LensChe.Width = 125;
            // 
            // priceReal
            // 
            this.priceReal.HeaderText = "priceReal";
            this.priceReal.MinimumWidth = 6;
            this.priceReal.Name = "priceReal";
            this.priceReal.Visible = false;
            this.priceReal.Width = 125;
            // 
            // AddToCart
            // 
            this.AddToCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddToCart.HeaderText = "";
            this.AddToCart.Image = global::Capstone.Properties.Resources.addToCart;
            this.AddToCart.MinimumWidth = 6;
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Width = 6;
            // 
            // StockID
            // 
            this.StockID.HeaderText = "Stock ID";
            this.StockID.MinimumWidth = 6;
            this.StockID.Name = "StockID";
            this.StockID.Visible = false;
            this.StockID.Width = 125;
            // 
            // StockNum
            // 
            this.StockNum.HeaderText = "Stock Num";
            this.StockNum.MinimumWidth = 6;
            this.StockNum.Name = "StockNum";
            this.StockNum.Visible = false;
            this.StockNum.Width = 125;
            // 
            // UM
            // 
            this.UM.HeaderText = "UnitMeas";
            this.UM.MinimumWidth = 6;
            this.UM.Name = "UM";
            this.UM.Visible = false;
            this.UM.Width = 125;
            // 
            // frmBrowseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 930);
            this.Controls.Add(this.dataGridViewBrowse);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewSearchItem);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBrowseItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBrowseItem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBrowse)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewImageColumn AddSearchItem;
        private DataGridViewTextBoxColumn TypeSearchItem;
        private DataGridViewTextBoxColumn DescSearchItem;
        private TextBox txtSearch;
        private DataGridViewTextBoxColumn PCodeSearchItem;
        private DataGridViewTextBoxColumn NumSearchItem;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn PriceSearchItem;
        private DataGridView dataGridViewSearchItem;
        private Panel panel2;
        public DataGridView dataGridViewBrowse;
        private Label lblTransNo;
        public Label lblTrans;
        public Label lblCheck;
        private Label label2;
        public Label lblStock;
        public Label lblItemIDCheck;
        public Label lblLensecheck;
        private DataGridViewTextBoxColumn NumBrowseItem;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn DescBrowseItem;
        private DataGridViewTextBoxColumn TypeBrowseItem;
        private DataGridViewTextBoxColumn ProductBrowseItem;
        private DataGridViewTextBoxColumn PriceBrowseItem;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Classification;
        private DataGridViewTextBoxColumn UNIT;
        private DataGridViewTextBoxColumn LensChe;
        private DataGridViewTextBoxColumn priceReal;
        private DataGridViewImageColumn AddToCart;
        private DataGridViewTextBoxColumn StockID;
        private DataGridViewTextBoxColumn StockNum;
        private DataGridViewTextBoxColumn UM;
    }
}