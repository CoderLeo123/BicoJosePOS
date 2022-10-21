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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.del = new System.Windows.Forms.DataGridViewImageColumn();
            this.ServID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblDiscPercen = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSalesTotal = new System.Windows.Forms.Label();
            this.lblNetTotal = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblCashierName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSettleBalance = new System.Windows.Forms.Button();
            this.btnBrowseService = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnDailySales = new System.Windows.Forms.Button();
            this.btnClearCart = new System.Windows.Forms.Button();
            this.btnSettlePayment = new System.Windows.Forms.Button();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.btnBrowseItem = new System.Windows.Forms.Button();
            this.btnNewTransaction = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitMe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.panel7.SuspendLayout();
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
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 713);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 266);
            this.panel2.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.dataGridViewService);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1173, 266);
            this.panel8.TabIndex = 1;
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToAddRows = false;
            this.dataGridViewService.AllowUserToResizeColumns = false;
            this.dataGridViewService.AllowUserToResizeRows = false;
            this.dataGridViewService.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewService.ColumnHeadersHeight = 40;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.del,
            this.ServID,
            this.ServNum});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewService.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewService.EnableHeadersVisualStyles = false;
            this.dataGridViewService.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewService.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.RowHeadersVisible = false;
            this.dataGridViewService.RowHeadersWidth = 51;
            this.dataGridViewService.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewService.RowTemplate.Height = 29;
            this.dataGridViewService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewService.Size = new System.Drawing.Size(1173, 266);
            this.dataGridViewService.TabIndex = 4;
            this.dataGridViewService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewService_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 51;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "NAME";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "PRICE";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 89;
            // 
            // del
            // 
            this.del.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.del.HeaderText = "";
            this.del.Image = global::Capstone.Properties.Resources._Delete;
            this.del.MinimumWidth = 6;
            this.del.Name = "del";
            this.del.Width = 6;
            // 
            // ServID
            // 
            this.ServID.HeaderText = "SID";
            this.ServID.MinimumWidth = 6;
            this.ServID.Name = "ServID";
            this.ServID.Visible = false;
            this.ServID.Width = 125;
            // 
            // ServNum
            // 
            this.ServNum.HeaderText = "Num";
            this.ServNum.MinimumWidth = 6;
            this.ServNum.Name = "ServNum";
            this.ServNum.Visible = false;
            this.ServNum.Width = 125;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.lblDiscPercen);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.lblSalesTotal);
            this.panel7.Controls.Add(this.lblNetTotal);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.lblChange);
            this.panel7.Controls.Add(this.lblDiscount);
            this.panel7.Controls.Add(this.lblPayment);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(1173, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(427, 266);
            this.panel7.TabIndex = 0;
            // 
            // lblDiscPercen
            // 
            this.lblDiscPercen.AutoSize = true;
            this.lblDiscPercen.ForeColor = System.Drawing.Color.Red;
            this.lblDiscPercen.Location = new System.Drawing.Point(146, 112);
            this.lblDiscPercen.Name = "lblDiscPercen";
            this.lblDiscPercen.Size = new System.Drawing.Size(76, 28);
            this.lblDiscPercen.TabIndex = 23;
            this.lblDiscPercen.Text = "Percent";
            this.lblDiscPercen.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gross Total";
            // 
            // lblSalesTotal
            // 
            this.lblSalesTotal.AutoSize = true;
            this.lblSalesTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalesTotal.Location = new System.Drawing.Point(274, 58);
            this.lblSalesTotal.Name = "lblSalesTotal";
            this.lblSalesTotal.Size = new System.Drawing.Size(94, 41);
            this.lblSalesTotal.TabIndex = 2;
            this.lblSalesTotal.Text = "00.00";
            // 
            // lblNetTotal
            // 
            this.lblNetTotal.AutoSize = true;
            this.lblNetTotal.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNetTotal.ForeColor = System.Drawing.Color.Red;
            this.lblNetTotal.Location = new System.Drawing.Point(274, 140);
            this.lblNetTotal.Name = "lblNetTotal";
            this.lblNetTotal.Size = new System.Drawing.Size(94, 41);
            this.lblNetTotal.TabIndex = 6;
            this.lblNetTotal.Text = "00.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(0, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 41);
            this.label10.TabIndex = 4;
            this.label10.Text = "Net Total";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChange.ForeColor = System.Drawing.Color.Red;
            this.lblChange.Location = new System.Drawing.Point(280, 252);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(94, 41);
            this.lblChange.TabIndex = 9;
            this.lblChange.Text = "00.00";
            this.lblChange.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDiscount.Location = new System.Drawing.Point(274, 99);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(94, 41);
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "00.00";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPayment.Location = new System.Drawing.Point(333, 252);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(94, 41);
            this.lblPayment.TabIndex = 7;
            this.lblPayment.Text = "00.00";
            this.lblPayment.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(0, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 41);
            this.label5.TabIndex = 1;
            this.label5.Text = "Discount";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.BackgroundImage = global::Capstone.Properties.Resources.eye_glasses__1_;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.lblCashierName);
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
            // lblCashierName
            // 
            this.lblCashierName.AutoSize = true;
            this.lblCashierName.ForeColor = System.Drawing.Color.White;
            this.lblCashierName.Location = new System.Drawing.Point(87, 40);
            this.lblCashierName.Name = "lblCashierName";
            this.lblCashierName.Size = new System.Drawing.Size(77, 28);
            this.lblCashierName.TabIndex = 1;
            this.lblCashierName.Text = "Leomar";
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
            this.panel4.Location = new System.Drawing.Point(1173, 78);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(427, 635);
            this.panel4.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Cyan;
            this.panel6.Controls.Add(this.btnSettleBalance);
            this.panel6.Controls.Add(this.btnBrowseService);
            this.panel6.Controls.Add(this.btnLogout);
            this.panel6.Controls.Add(this.btnDailySales);
            this.panel6.Controls.Add(this.btnClearCart);
            this.panel6.Controls.Add(this.btnSettlePayment);
            this.panel6.Controls.Add(this.btnAddDiscount);
            this.panel6.Controls.Add(this.btnBrowseItem);
            this.panel6.Controls.Add(this.btnNewTransaction);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(427, 645);
            this.panel6.TabIndex = 1;
            // 
            // btnSettleBalance
            // 
            this.btnSettleBalance.FlatAppearance.BorderSize = 0;
            this.btnSettleBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettleBalance.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettleBalance.ForeColor = System.Drawing.Color.Black;
            this.btnSettleBalance.Image = global::Capstone.Properties.Resources.payStat;
            this.btnSettleBalance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettleBalance.Location = new System.Drawing.Point(0, 487);
            this.btnSettleBalance.Name = "btnSettleBalance";
            this.btnSettleBalance.Size = new System.Drawing.Size(389, 68);
            this.btnSettleBalance.TabIndex = 9;
            this.btnSettleBalance.Text = "    [ F9 ] SETTLE BALANCE";
            this.btnSettleBalance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettleBalance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettleBalance.UseVisualStyleBackColor = true;
            this.btnSettleBalance.Click += new System.EventHandler(this.btnSettleBalance_Click);
            // 
            // btnBrowseService
            // 
            this.btnBrowseService.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBrowseService.FlatAppearance.BorderSize = 0;
            this.btnBrowseService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowseService.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBrowseService.ForeColor = System.Drawing.Color.Black;
            this.btnBrowseService.Image = global::Capstone.Properties.Resources.SearchCart;
            this.btnBrowseService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseService.Location = new System.Drawing.Point(0, 136);
            this.btnBrowseService.Name = "btnBrowseService";
            this.btnBrowseService.Size = new System.Drawing.Size(427, 67);
            this.btnBrowseService.TabIndex = 8;
            this.btnBrowseService.Text = "    [ F3 ] BROWSE SERVICE";
            this.btnBrowseService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBrowseService.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBrowseService.UseVisualStyleBackColor = true;
            this.btnBrowseService.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = global::Capstone.Properties.Resources.Log_out;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 561);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(389, 68);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "    [ F10 ] LOGOUT";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnDailySales
            // 
            this.btnDailySales.FlatAppearance.BorderSize = 0;
            this.btnDailySales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDailySales.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDailySales.ForeColor = System.Drawing.Color.Black;
            this.btnDailySales.Image = global::Capstone.Properties.Resources.DailySales;
            this.btnDailySales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailySales.Location = new System.Drawing.Point(0, 417);
            this.btnDailySales.Name = "btnDailySales";
            this.btnDailySales.Size = new System.Drawing.Size(389, 68);
            this.btnDailySales.TabIndex = 5;
            this.btnDailySales.Text = "    [ F8 ] DAILY SALES";
            this.btnDailySales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDailySales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDailySales.UseVisualStyleBackColor = true;
            this.btnDailySales.Click += new System.EventHandler(this.btnDailySales_Click);
            // 
            // btnClearCart
            // 
            this.btnClearCart.Enabled = false;
            this.btnClearCart.FlatAppearance.BorderSize = 0;
            this.btnClearCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearCart.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearCart.ForeColor = System.Drawing.Color.Black;
            this.btnClearCart.Image = global::Capstone.Properties.Resources.ClearCart;
            this.btnClearCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearCart.Location = new System.Drawing.Point(0, 343);
            this.btnClearCart.Name = "btnClearCart";
            this.btnClearCart.Size = new System.Drawing.Size(389, 68);
            this.btnClearCart.TabIndex = 4;
            this.btnClearCart.Text = "    [ F7 ] CLEAR CART";
            this.btnClearCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearCart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearCart.UseVisualStyleBackColor = true;
            this.btnClearCart.Click += new System.EventHandler(this.btnClearCart_Click);
            // 
            // btnSettlePayment
            // 
            this.btnSettlePayment.Enabled = false;
            this.btnSettlePayment.FlatAppearance.BorderSize = 0;
            this.btnSettlePayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettlePayment.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettlePayment.ForeColor = System.Drawing.Color.Black;
            this.btnSettlePayment.Image = global::Capstone.Properties.Resources.SettlePayment;
            this.btnSettlePayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettlePayment.Location = new System.Drawing.Point(0, 269);
            this.btnSettlePayment.Name = "btnSettlePayment";
            this.btnSettlePayment.Size = new System.Drawing.Size(389, 68);
            this.btnSettlePayment.TabIndex = 3;
            this.btnSettlePayment.Text = "    [ F6 ] SETTLE PAYMENT";
            this.btnSettlePayment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettlePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettlePayment.UseVisualStyleBackColor = true;
            this.btnSettlePayment.Click += new System.EventHandler(this.btnSettlePayment_Click);
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.Enabled = false;
            this.btnAddDiscount.FlatAppearance.BorderSize = 0;
            this.btnAddDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDiscount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddDiscount.ForeColor = System.Drawing.Color.Black;
            this.btnAddDiscount.Image = global::Capstone.Properties.Resources.Discount;
            this.btnAddDiscount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDiscount.Location = new System.Drawing.Point(0, 209);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(389, 68);
            this.btnAddDiscount.TabIndex = 2;
            this.btnAddDiscount.Text = "    [ F4 ] ADD DISCOUNT";
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
            this.btnBrowseItem.Size = new System.Drawing.Size(427, 68);
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
            this.btnNewTransaction.Size = new System.Drawing.Size(427, 68);
            this.btnNewTransaction.TabIndex = 0;
            this.btnNewTransaction.Text = "    [ F1 ] NEW TRANSACTION";
            this.btnNewTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewTransaction.UseVisualStyleBackColor = true;
            this.btnNewTransaction.Click += new System.EventHandler(this.btnNewTransaction_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblTransactionNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1173, 180);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(827, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 38);
            this.label11.TabIndex = 9;
            this.label11.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(494, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 38);
            this.label2.TabIndex = 8;
            this.label2.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(255, 45);
            this.label7.TabIndex = 7;
            this.label7.Text = "Customer Name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtFirstName.Location = new System.Drawing.Point(529, 118);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.Size = new System.Drawing.Size(292, 43);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLastName.Location = new System.Drawing.Point(862, 119);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.Size = new System.Drawing.Size(305, 43);
            this.txtLastName.TabIndex = 5;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(552, 22);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search Item Here";
            this.txtSearch.Size = new System.Drawing.Size(615, 43);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDate.ForeColor = System.Drawing.Color.Black;
            this.lblDate.Location = new System.Drawing.Point(279, 67);
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
            this.lblTransactionNo.Location = new System.Drawing.Point(273, 22);
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
            this.panel5.Location = new System.Drawing.Point(0, 258);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1173, 455);
            this.panel5.TabIndex = 5;
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.AllowUserToAddRows = false;
            this.dataGridViewCart.AllowUserToResizeColumns = false;
            this.dataGridViewCart.AllowUserToResizeRows = false;
            this.dataGridViewCart.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            this.DeleteCart,
            this.ID,
            this.sd,
            this.ItemID,
            this.unitMe,
            this.Classif});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCart.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.dataGridViewCart.Size = new System.Drawing.Size(1173, 455);
            this.dataGridViewCart.TabIndex = 3;
            this.dataGridViewCart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCart_CellContentClick);
            // 
            // NumCart
            // 
            this.NumCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumCart.HeaderText = "#";
            this.NumCart.MinimumWidth = 6;
            this.NumCart.Name = "NumCart";
            this.NumCart.ReadOnly = true;
            this.NumCart.Width = 51;
            // 
            // DescriptionCart
            // 
            this.DescriptionCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionCart.HeaderText = "DESCRIPTION";
            this.DescriptionCart.MinimumWidth = 6;
            this.DescriptionCart.Name = "DescriptionCart";
            this.DescriptionCart.ReadOnly = true;
            // 
            // Expiration
            // 
            this.Expiration.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Expiration.HeaderText = "EXPIRATION";
            this.Expiration.MinimumWidth = 6;
            this.Expiration.Name = "Expiration";
            this.Expiration.ReadOnly = true;
            this.Expiration.Width = 146;
            // 
            // PriceCart
            // 
            this.PriceCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PriceCart.HeaderText = "PRICE";
            this.PriceCart.MinimumWidth = 6;
            this.PriceCart.Name = "PriceCart";
            this.PriceCart.ReadOnly = true;
            this.PriceCart.Width = 89;
            // 
            // QuantityCart
            // 
            this.QuantityCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QuantityCart.HeaderText = "QTY";
            this.QuantityCart.MinimumWidth = 6;
            this.QuantityCart.Name = "QuantityCart";
            this.QuantityCart.ReadOnly = true;
            this.QuantityCart.Width = 74;
            // 
            // DiscountCart
            // 
            this.DiscountCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DiscountCart.HeaderText = "DISCOUNT";
            this.DiscountCart.MinimumWidth = 6;
            this.DiscountCart.Name = "DiscountCart";
            this.DiscountCart.ReadOnly = true;
            this.DiscountCart.Visible = false;
            this.DiscountCart.Width = 125;
            // 
            // TotalCart
            // 
            this.TotalCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalCart.HeaderText = "TOTAL";
            this.TotalCart.MinimumWidth = 6;
            this.TotalCart.Name = "TotalCart";
            this.TotalCart.ReadOnly = true;
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
            // ID
            // 
            this.ID.HeaderText = "StockID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // sd
            // 
            this.sd.HeaderText = "CartID";
            this.sd.MinimumWidth = 6;
            this.sd.Name = "sd";
            this.sd.Visible = false;
            this.sd.Width = 125;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "ItemID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.Visible = false;
            this.ItemID.Width = 125;
            // 
            // unitMe
            // 
            this.unitMe.HeaderText = "UnitMeasure";
            this.unitMe.MinimumWidth = 6;
            this.unitMe.Name = "unitMe";
            this.unitMe.ReadOnly = true;
            this.unitMe.Visible = false;
            this.unitMe.Width = 125;
            // 
            // Classif
            // 
            this.Classif.HeaderText = "CLassificate";
            this.Classif.MinimumWidth = 6;
            this.Classif.Name = "Classif";
            this.Classif.Visible = false;
            this.Classif.Width = 125;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmCashier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 979);
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
            this.panel2.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
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
        private Panel panel1;
        private Panel panel5;
        private Label label1;
        private Label label6;
        private Label label4;
        public Label lblTransactionNo;
        public DataGridView dataGridViewCart;
        public TextBox txtSearch;
        private Panel panel7;
        private Label label5;
        private Label label3;
        public Label lblDiscount;
        public Label lblSalesTotal;
        public Button btnNewTransaction;
        public Button btnLogout;
        public Button btnDailySales;
        public Button btnClearCart;
        public Button btnSettlePayment;
        public Button btnAddDiscount;
        public Button btnBrowseItem;
        public Label lblPayment;
        public Label lblNetTotal;
        private Label label10;
        private Panel panel8;
        public Label lblChange;
        private Label label7;
        public TextBox txtFirstName;
        public TextBox txtLastName;
        public Label lblCashierName;
        public DataGridView dataGridViewService;
        public Button btnBrowseService;
        private Label label11;
        private Label label2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewImageColumn del;
        private DataGridViewTextBoxColumn ServID;
        private DataGridViewTextBoxColumn ServNum;
        public System.Drawing.Printing.PrintDocument printDocument1;
        public Label lblDate;
        public Label lblDiscPercen;
        public Label lblTotal;
        public Button btnSettleBalance;
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn sd;
        private DataGridViewTextBoxColumn ItemID;
        private DataGridViewTextBoxColumn unitMe;
        private DataGridViewTextBoxColumn Classif;
    }
}