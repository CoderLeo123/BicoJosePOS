namespace Capstone
{
    partial class frmCashier
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnDailySales = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnSettlePayment = new System.Windows.Forms.Button();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.btnBrowseItem = new System.Windows.Forms.Button();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTransactionNo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.NumCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalCart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlusCart = new System.Windows.Forms.DataGridViewImageColumn();
            this.MinusCart = new System.Windows.Forms.DataGridViewImageColumn();
            this.DeleteCart = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 787);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 163);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.BackgroundImage = global::Capstone.Properties.Resources.eye_glasses__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1600, 78);
            this.panel3.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.Lime;
            this.lblTotal.Location = new System.Drawing.Point(1462, 6);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(126, 62);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cashier Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(87, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bico-Jose Point of Sale ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(1211, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(389, 709);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Cyan;
            this.panel6.Controls.Add(this.btnLogout);
            this.panel6.Controls.Add(this.btnChangePass);
            this.panel6.Controls.Add(this.btnDailySales);
            this.panel6.Controls.Add(this.btnClearCart);
            this.panel6.Controls.Add(this.btnSettlePayment);
            this.panel6.Controls.Add(this.btnAddDiscount);
            this.panel6.Controls.Add(this.btnBrowseItem);
            this.panel6.Controls.Add(this.btnNewTransaction);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(389, 561);
            this.panel6.TabIndex = 1;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = global::Capstone.Properties.Resources.Log_out;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 476);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(389, 68);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "    [ F1 ] LOGOUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnChangePass.ForeColor = System.Drawing.Color.Black;
            this.btnChangePass.Image = global::Capstone.Properties.Resources.Pass;
            this.btnChangePass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.Location = new System.Drawing.Point(0, 408);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(389, 68);
            this.btnChangePass.TabIndex = 6;
            this.btnChangePass.Text = "    [ F1 ] CHANGE PASSWORD";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnDailySales
            // 
            this.btnDailySales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDailySales.FlatAppearance.BorderSize = 0;
            this.btnDailySales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailySales.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDailySales.ForeColor = System.Drawing.Color.Black;
            this.btnDailySales.Image = global::Capstone.Properties.Resources.DailySales;
            this.btnDailySales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailySales.Location = new System.Drawing.Point(0, 340);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Size = new System.Drawing.Size(389, 68);
            this.btnDailySales.TabIndex = 5;
            this.btnDailySales.Text = "    [ F1 ] DAILY SALES";
            this.btnDailySales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailySales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDailySales.UseVisualStyleBackColor = true;
            this.btnDailySales.Click += new System.EventHandler(this.btnDailySales_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearCart.ForeColor = System.Drawing.Color.Black;
            this.btnClearCart.Image = global::Capstone.Properties.Resources.ClearCart;
            this.btnClearCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearCart.Location = new System.Drawing.Point(0, 272);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(389, 68);
            this.btnClearCart.TabIndex = 4;
            this.btnClearCart.Text = "    [ F1 ] CLEAR CART";
            this.btnClearCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearCart.UseVisualStyleBackColor = true;
            // 
            // btnSettlePayment
            // 
            this.btnSettlePayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettlePayment.FlatAppearance.BorderSize = 0;
            this.btnSettlePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettlePayment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettlePayment.ForeColor = System.Drawing.Color.Black;
            this.btnSettlePayment.Image = global::Capstone.Properties.Resources.SettlePayment;
            this.btnSettlePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettlePayment.Location = new System.Drawing.Point(0, 204);
            this.btnSettlePayment.Name = "btnSettlePayment";
            this.btnSettlePayment.Size = new System.Drawing.Size(389, 68);
            this.btnSettlePayment.TabIndex = 3;
            this.btnSettlePayment.Text = "    [ F1 ] SETTLE PAYMENT";
            this.btnSettlePayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettlePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettlePayment.UseVisualStyleBackColor = true;
            this.btnSettlePayment.Click += new System.EventHandler(this.btnSettlePayment_Click);
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddDiscount.FlatAppearance.BorderSize = 0;
            this.btnAddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDiscount.ForeColor = System.Drawing.Color.Black;
            this.btnAddDiscount.Image = global::Capstone.Properties.Resources.Discount;
            this.btnAddDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDiscount.Location = new System.Drawing.Point(0, 136);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(389, 68);
            this.btnAddDiscount.TabIndex = 2;
            this.btnAddDiscount.Text = "    [ F1 ] ADD DISCOUNT";
            this.btnAddDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDiscount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddDiscount.UseVisualStyleBackColor = true;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnBrowseItem
            // 
            this.btnBrowseItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowseItem.FlatAppearance.BorderSize = 0;
            this.btnBrowseItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseItem.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrowseItem.ForeColor = System.Drawing.Color.Black;
            this.btnBrowseItem.Image = global::Capstone.Properties.Resources.SearchCart;
            this.btnBrowseItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseItem.Location = new System.Drawing.Point(0, 68);
            this.btnBrowseItem.Name = "btnBrowseItem";
            this.btnBrowseItem.Size = new System.Drawing.Size(389, 68);
            this.btnBrowseItem.TabIndex = 1;
            this.btnBrowseItem.Text = "    [ F2 ] BROWSE ITEMS";
            this.btnBrowseItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowseItem.UseVisualStyleBackColor = true;
            this.btnBrowseItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnNewTransaction
            // 
            this.btnNewTransaction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewTransaction.FlatAppearance.BorderSize = 0;
            this.btnNewTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewTransaction.ForeColor = System.Drawing.Color.Black;
            this.btnNewTransaction.Image = global::Capstone.Properties.Resources.NewTransaction;
            this.btnNewTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewTransaction.Location = new System.Drawing.Point(0, 0);
            this.btnNewTransaction.Name = "btnNewTransaction";
            this.btnNewTransaction.Size = new System.Drawing.Size(389, 68);
            this.btnNewTransaction.TabIndex = 0;
            this.btnNewTransaction.Text = "    [ F1 ] NEW TRANSACTION";
            this.btnNewTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTransactionNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 136);
            this.panel1.TabIndex = 4;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(316, 75);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 45);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "  ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 45);
            this.label6.TabIndex = 2;
            this.label6.Text = "Transaction Date";
            // 
            // lblTransactionNo
            // 
            this.lblTransactionNo.AutoSize = true;
            this.lblTransactionNo.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTransactionNo.ForeColor = System.Drawing.Color.Red;
            this.lblTransactionNo.Location = new System.Drawing.Point(316, 22);
            this.lblTransactionNo.Name = "lblTransactionNo";
            this.lblTransactionNo.Size = new System.Drawing.Size(0, 45);
            this.lblTransactionNo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(244, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Transaction No.";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridViewCart);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 214);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1211, 573);
            this.panel5.TabIndex = 5;
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToResizeColumns = false;
            this.dataGridViewCart.AllowUserToResizeRows = false;
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCart.ColumnHeadersHeight = 40;
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumCart,
            this.DescriptionCart,
            this.Expiration,
            this.PriceCart,
            this.QuantityCart,
            this.DiscountCart,
            this.TotalCart,
            this.PlusCart,
            this.MinusCart,
            this.DeleteCart});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCart.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCart.EnableHeadersVisualStyles = false;
            this.dataGridViewCart.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewCart.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.RowHeadersVisible = false;
            this.dataGridViewCart.RowHeadersWidth = 51;
            this.dataGridViewCart.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewCart.RowTemplate.Height = 29;
            this.dataGridViewCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCart.Size = new System.Drawing.Size(1211, 573);
            this.dataGridViewCart.TabIndex = 3;
            // 
            // NumCart
            // 
            this.NumCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumCart.HeaderText = "#";
            this.NumCart.MinimumWidth = 6;
            this.NumCart.Name = "NumCart";
            this.NumCart.Width = 51;
            // 
            // DescriptionCart
            // 
            this.DescriptionCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionCart.HeaderText = "DESCRIPTION";
            this.DescriptionCart.MinimumWidth = 6;
            this.DescriptionCart.Name = "DescriptionCart";
            // 
            // Expiration
            // 
            this.Expiration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Expiration.HeaderText = "EXPIRATION";
            this.Expiration.MinimumWidth = 6;
            this.Expiration.Name = "Expiration";
            this.Expiration.Width = 146;
            // 
            // PriceCart
            // 
            this.PriceCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PriceCart.HeaderText = "PRICE";
            this.PriceCart.MinimumWidth = 6;
            this.PriceCart.Name = "PriceCart";
            this.PriceCart.Width = 89;
            // 
            // QuantityCart
            // 
            this.QuantityCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QuantityCart.HeaderText = "QUANTITY";
            this.QuantityCart.MinimumWidth = 6;
            this.QuantityCart.Name = "QuantityCart";
            this.QuantityCart.Width = 132;
            // 
            // DiscountCart
            // 
            this.DiscountCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DiscountCart.HeaderText = "DISCOUNT";
            this.DiscountCart.MinimumWidth = 6;
            this.DiscountCart.Name = "DiscountCart";
            this.DiscountCart.Width = 134;
            // 
            // TotalCart
            // 
            this.TotalCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalCart.HeaderText = "TOTAL";
            this.TotalCart.MinimumWidth = 6;
            this.TotalCart.Name = "TotalCart";
            this.TotalCart.Width = 93;
            // 
            // PlusCart
            // 
            this.PlusCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PlusCart.HeaderText = "";
            this.PlusCart.Image = global::Capstone.Properties.Resources._Add;
            this.PlusCart.MinimumWidth = 6;
            this.PlusCart.Name = "PlusCart";
            this.PlusCart.Width = 6;
            // 
            // MinusCart
            // 
            this.MinusCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MinusCart.HeaderText = "";
            this.MinusCart.Image = global::Capstone.Properties.Resources.Minus;
            this.MinusCart.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.MinusCart.MinimumWidth = 6;
            this.MinusCart.Name = "MinusCart";
            this.MinusCart.Width = 6;
            // 
            // DeleteCart
            // 
            this.DeleteCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DeleteCart.HeaderText = "";
            this.DeleteCart.Image = global::Capstone.Properties.Resources._Delete;
            this.DeleteCart.MinimumWidth = 6;
            this.DeleteCart.Name = "DeleteCart";
            this.DeleteCart.Width = 6;
            // 
            // frmCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 950);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCashier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCashier";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel6;
        private Button btnNewTransaction;
        private Panel panel1;
        private Panel panel5;
        private Button btnLogout;
        private Button btnChangePass;
        private Button btnDailySales;
        private Button btnClearCart;
        private Button btnSettlePayment;
        private Button btnAddDiscount;
        private Button btnBrowseItem;
        private Label label1;
        private Label lblTotal;
        private Label label2;
        private Label label6;
        private Label label4;
        private Label lblDate;
        public Label lblTransactionNo;
        private DataGridViewTextBoxColumn NumCart;
        private DataGridViewTextBoxColumn DescriptionCart;
        private DataGridViewTextBoxColumn Expiration;
        private DataGridViewTextBoxColumn PriceCart;
        private DataGridViewTextBoxColumn QuantityCart;
        private DataGridViewTextBoxColumn DiscountCart;
        private DataGridViewTextBoxColumn TotalCart;
        private DataGridViewImageColumn PlusCart;
        private DataGridViewImageColumn MinusCart;
        private DataGridViewImageColumn DeleteCart;
        public DataGridView dataGridViewCart;
    }
}