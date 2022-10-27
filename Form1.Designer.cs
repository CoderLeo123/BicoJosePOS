namespace Capstone
{
    partial class frmAdmin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnCashier = new System.Windows.Forms.Button();
            this.btnUserSettings = new System.Windows.Forms.Button();
            this.btnBackupArch = new System.Windows.Forms.Button();
            this.dropPanelSales = new System.Windows.Forms.Panel();
            this.dropBtnReports = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnStockDel = new System.Windows.Forms.Button();
            this.dropPanelProducts = new System.Windows.Forms.Panel();
            this.dropBtnProducts = new System.Windows.Forms.Button();
            this.dropPanelPayment = new System.Windows.Forms.Panel();
            this.dropBtnPayment = new System.Windows.Forms.Button();
            this.btnPatientR = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerDrpBtnProducts = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timerDrpBtnPayment = new System.Windows.Forms.Timer(this.components);
            this.timerDrpBtnSales = new System.Windows.Forms.Timer(this.components);
            this.panelLoad = new System.Windows.Forms.Panel();
            this.panelDashboard = new System.Windows.Forms.Panel();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtOutOStk = new System.Windows.Forms.TextBox();
            this.txtCrit = new System.Windows.Forms.TextBox();
            this.txtReOrd = new System.Windows.Forms.TextBox();
            this.txtAvailStock = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMasterCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblReOrBlink = new System.Windows.Forms.Label();
            this.lblSettledPay = new System.Windows.Forms.Label();
            this.lblPendingPay = new System.Windows.Forms.Label();
            this.lblClaimedOrd = new System.Windows.Forms.Label();
            this.lblInLab = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblCashier = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblInLabBlink = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPendingBlink = new System.Windows.Forms.Label();
            this.lblOofStkBlink = new System.Windows.Forms.Label();
            this.lblCritBlink = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.dropPanelSales.SuspendLayout();
            this.dropPanelProducts.SuspendLayout();
            this.dropPanelPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLoad.SuspendLayout();
            this.panelDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 948);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnLogout);
            this.panel4.Controls.Add(this.btnCashier);
            this.panel4.Controls.Add(this.btnUserSettings);
            this.panel4.Controls.Add(this.btnBackupArch);
            this.panel4.Controls.Add(this.dropPanelSales);
            this.panel4.Controls.Add(this.btnInventory);
            this.panel4.Controls.Add(this.btnStockDel);
            this.panel4.Controls.Add(this.dropPanelProducts);
            this.panel4.Controls.Add(this.dropPanelPayment);
            this.panel4.Controls.Add(this.btnPatientR);
            this.panel4.Controls.Add(this.btnDashboard);
            this.panel4.Location = new System.Drawing.Point(5, 214);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 924);
            this.panel4.TabIndex = 6;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::Capstone.Properties.Resources.Log_out;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 534);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(278, 52);
            this.btnLogout.TabIndex = 18;
            this.btnLogout.Text = "   Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // btnCashier
            // 
            this.btnCashier.BackColor = System.Drawing.Color.Transparent;
            this.btnCashier.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCashier.FlatAppearance.BorderSize = 0;
            this.btnCashier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCashier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCashier.ForeColor = System.Drawing.Color.White;
            this.btnCashier.Image = global::Capstone.Properties.Resources.Items;
            this.btnCashier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCashier.Location = new System.Drawing.Point(0, 482);
            this.btnCashier.Name = "btnCashier";
            this.btnCashier.Size = new System.Drawing.Size(278, 52);
            this.btnCashier.TabIndex = 17;
            this.btnCashier.Text = "   Cashier";
            this.btnCashier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCashier.UseVisualStyleBackColor = false;
            this.btnCashier.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnUserSettings
            // 
            this.btnUserSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnUserSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserSettings.FlatAppearance.BorderSize = 0;
            this.btnUserSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserSettings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUserSettings.ForeColor = System.Drawing.Color.White;
            this.btnUserSettings.Image = global::Capstone.Properties.Resources.User_Settings;
            this.btnUserSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserSettings.Location = new System.Drawing.Point(0, 430);
            this.btnUserSettings.Name = "btnUserSettings";
            this.btnUserSettings.Size = new System.Drawing.Size(278, 52);
            this.btnUserSettings.TabIndex = 16;
            this.btnUserSettings.Text = "   UserSettings";
            this.btnUserSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserSettings.UseVisualStyleBackColor = false;
            this.btnUserSettings.Click += new System.EventHandler(this.btnUserSettings_Click);
            // 
            // btnBackupArch
            // 
            this.btnBackupArch.BackColor = System.Drawing.Color.Transparent;
            this.btnBackupArch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackupArch.FlatAppearance.BorderSize = 0;
            this.btnBackupArch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupArch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackupArch.ForeColor = System.Drawing.Color.White;
            this.btnBackupArch.Image = global::Capstone.Properties.Resources.Back_up;
            this.btnBackupArch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackupArch.Location = new System.Drawing.Point(0, 378);
            this.btnBackupArch.Name = "btnBackupArch";
            this.btnBackupArch.Size = new System.Drawing.Size(278, 52);
            this.btnBackupArch.TabIndex = 15;
            this.btnBackupArch.Text = "   Backup and Archive";
            this.btnBackupArch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBackupArch.UseVisualStyleBackColor = false;
            this.btnBackupArch.Click += new System.EventHandler(this.btnBackupArch_Click);
            // 
            // dropPanelSales
            // 
            this.dropPanelSales.Controls.Add(this.dropBtnReports);
            this.dropPanelSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropPanelSales.Location = new System.Drawing.Point(0, 322);
            this.dropPanelSales.MaximumSize = new System.Drawing.Size(366, 155);
            this.dropPanelSales.MinimumSize = new System.Drawing.Size(366, 52);
            this.dropPanelSales.Name = "dropPanelSales";
            this.dropPanelSales.Size = new System.Drawing.Size(366, 56);
            this.dropPanelSales.TabIndex = 14;
            // 
            // dropBtnReports
            // 
            this.dropBtnReports.BackColor = System.Drawing.Color.Transparent;
            this.dropBtnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropBtnReports.FlatAppearance.BorderSize = 0;
            this.dropBtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropBtnReports.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropBtnReports.ForeColor = System.Drawing.Color.White;
            this.dropBtnReports.Image = global::Capstone.Properties.Resources.Sales_Report;
            this.dropBtnReports.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dropBtnReports.Location = new System.Drawing.Point(0, 0);
            this.dropBtnReports.Name = "dropBtnReports";
            this.dropBtnReports.Size = new System.Drawing.Size(366, 52);
            this.dropBtnReports.TabIndex = 0;
            this.dropBtnReports.Text = "   Reports";
            this.dropBtnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dropBtnReports.UseVisualStyleBackColor = false;
            this.dropBtnReports.Click += new System.EventHandler(this.dropBtnSales_Click_1);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.Transparent;
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInventory.ForeColor = System.Drawing.Color.White;
            this.btnInventory.Image = global::Capstone.Properties.Resources.inventoryMonitor;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 270);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(278, 52);
            this.btnInventory.TabIndex = 13;
            this.btnInventory.Text = "   Inventory";
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnStockDel
            // 
            this.btnStockDel.BackColor = System.Drawing.Color.Transparent;
            this.btnStockDel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStockDel.FlatAppearance.BorderSize = 0;
            this.btnStockDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockDel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStockDel.ForeColor = System.Drawing.Color.White;
            this.btnStockDel.Image = global::Capstone.Properties.Resources.Stock_Delivery;
            this.btnStockDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStockDel.Location = new System.Drawing.Point(0, 218);
            this.btnStockDel.Name = "btnStockDel";
            this.btnStockDel.Size = new System.Drawing.Size(278, 52);
            this.btnStockDel.TabIndex = 12;
            this.btnStockDel.Text = "   Stock Delivery";
            this.btnStockDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnStockDel.UseVisualStyleBackColor = false;
            this.btnStockDel.Click += new System.EventHandler(this.btnStockDel_Click);
            // 
            // dropPanelProducts
            // 
            this.dropPanelProducts.Controls.Add(this.dropBtnProducts);
            this.dropPanelProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropPanelProducts.Location = new System.Drawing.Point(0, 161);
            this.dropPanelProducts.MaximumSize = new System.Drawing.Size(366, 207);
            this.dropPanelProducts.MinimumSize = new System.Drawing.Size(366, 52);
            this.dropPanelProducts.Name = "dropPanelProducts";
            this.dropPanelProducts.Size = new System.Drawing.Size(366, 57);
            this.dropPanelProducts.TabIndex = 10;
            // 
            // dropBtnProducts
            // 
            this.dropBtnProducts.BackColor = System.Drawing.Color.Transparent;
            this.dropBtnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropBtnProducts.FlatAppearance.BorderSize = 0;
            this.dropBtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropBtnProducts.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropBtnProducts.ForeColor = System.Drawing.Color.White;
            this.dropBtnProducts.Image = global::Capstone.Properties.Resources.ProdItemServ;
            this.dropBtnProducts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dropBtnProducts.Location = new System.Drawing.Point(0, 0);
            this.dropBtnProducts.Name = "dropBtnProducts";
            this.dropBtnProducts.Size = new System.Drawing.Size(366, 52);
            this.dropBtnProducts.TabIndex = 0;
            this.dropBtnProducts.Text = "   Product and Items";
            this.dropBtnProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dropBtnProducts.UseVisualStyleBackColor = false;
            this.dropBtnProducts.Click += new System.EventHandler(this.dropBtnProducts_Click_1);
            // 
            // dropPanelPayment
            // 
            this.dropPanelPayment.Controls.Add(this.dropBtnPayment);
            this.dropPanelPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropPanelPayment.Location = new System.Drawing.Point(0, 104);
            this.dropPanelPayment.MaximumSize = new System.Drawing.Size(366, 155);
            this.dropPanelPayment.MinimumSize = new System.Drawing.Size(366, 52);
            this.dropPanelPayment.Name = "dropPanelPayment";
            this.dropPanelPayment.Size = new System.Drawing.Size(366, 57);
            this.dropPanelPayment.TabIndex = 7;
            // 
            // dropBtnPayment
            // 
            this.dropBtnPayment.BackColor = System.Drawing.Color.Transparent;
            this.dropBtnPayment.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropBtnPayment.FlatAppearance.BorderSize = 0;
            this.dropBtnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropBtnPayment.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dropBtnPayment.ForeColor = System.Drawing.Color.White;
            this.dropBtnPayment.Image = global::Capstone.Properties.Resources.payment;
            this.dropBtnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dropBtnPayment.Location = new System.Drawing.Point(0, 0);
            this.dropBtnPayment.Name = "dropBtnPayment";
            this.dropBtnPayment.Size = new System.Drawing.Size(366, 52);
            this.dropBtnPayment.TabIndex = 0;
            this.dropBtnPayment.Text = "   Payment and Order Status";
            this.dropBtnPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dropBtnPayment.UseVisualStyleBackColor = false;
            this.dropBtnPayment.Click += new System.EventHandler(this.dropBtnPayment_Click_1);
            // 
            // btnPatientR
            // 
            this.btnPatientR.BackColor = System.Drawing.Color.Transparent;
            this.btnPatientR.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPatientR.FlatAppearance.BorderSize = 0;
            this.btnPatientR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPatientR.ForeColor = System.Drawing.Color.White;
            this.btnPatientR.Image = global::Capstone.Properties.Resources.Patient_s_Record;
            this.btnPatientR.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientR.Location = new System.Drawing.Point(0, 52);
            this.btnPatientR.Name = "btnPatientR";
            this.btnPatientR.Size = new System.Drawing.Size(278, 52);
            this.btnPatientR.TabIndex = 0;
            this.btnPatientR.Text = "   Patient\'s Record";
            this.btnPatientR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPatientR.UseVisualStyleBackColor = false;
            this.btnPatientR.Click += new System.EventHandler(this.btnPatientR_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = global::Capstone.Properties.Resources.Dashboard;
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 0);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(278, 52);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "   Dashboard";
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-8, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 51);
            this.label1.TabIndex = 2;
            this.label1.Text = "Administrator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Aqua;
            this.lblName.Location = new System.Drawing.Point(-8, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(291, 51);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Username";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(68, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timerDrpBtnProducts
            // 
            this.timerDrpBtnProducts.Interval = 15;
            this.timerDrpBtnProducts.Tick += new System.EventHandler(this.timerDrpBtnProducts_Tick);
            // 
            // timerDrpBtnPayment
            // 
            this.timerDrpBtnPayment.Interval = 15;
            this.timerDrpBtnPayment.Tick += new System.EventHandler(this.timerDrpBtnPayment_Tick);
            // 
            // timerDrpBtnSales
            // 
            this.timerDrpBtnSales.Interval = 15;
            this.timerDrpBtnSales.Tick += new System.EventHandler(this.timerDrpBtnSales_Tick);
            // 
            // panelLoad
            // 
            this.panelLoad.Controls.Add(this.panelDashboard);
            this.panelLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoad.Location = new System.Drawing.Point(281, 0);
            this.panelLoad.Name = "panelLoad";
            this.panelLoad.Size = new System.Drawing.Size(1317, 948);
            this.panelLoad.TabIndex = 2;
            this.panelLoad.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panelDashboard
            // 
            this.panelDashboard.Controls.Add(this.txtExp);
            this.panelDashboard.Controls.Add(this.txtOutOStk);
            this.panelDashboard.Controls.Add(this.txtCrit);
            this.panelDashboard.Controls.Add(this.txtReOrd);
            this.panelDashboard.Controls.Add(this.txtAvailStock);
            this.panelDashboard.Controls.Add(this.label5);
            this.panelDashboard.Controls.Add(this.lblMasterCount);
            this.panelDashboard.Controls.Add(this.label4);
            this.panelDashboard.Controls.Add(this.lblReOrBlink);
            this.panelDashboard.Controls.Add(this.lblSettledPay);
            this.panelDashboard.Controls.Add(this.lblPendingPay);
            this.panelDashboard.Controls.Add(this.lblClaimedOrd);
            this.panelDashboard.Controls.Add(this.lblInLab);
            this.panelDashboard.Controls.Add(this.lblTotalUsers);
            this.panelDashboard.Controls.Add(this.lblCashier);
            this.panelDashboard.Controls.Add(this.lblAdmin);
            this.panelDashboard.Controls.Add(this.label14);
            this.panelDashboard.Controls.Add(this.lblInLabBlink);
            this.panelDashboard.Controls.Add(this.label9);
            this.panelDashboard.Controls.Add(this.label10);
            this.panelDashboard.Controls.Add(this.label11);
            this.panelDashboard.Controls.Add(this.label6);
            this.panelDashboard.Controls.Add(this.lblPendingBlink);
            this.panelDashboard.Controls.Add(this.lblOofStkBlink);
            this.panelDashboard.Controls.Add(this.lblCritBlink);
            this.panelDashboard.Controls.Add(this.label2);
            this.panelDashboard.Controls.Add(this.textBox4);
            this.panelDashboard.Controls.Add(this.textBox3);
            this.panelDashboard.Controls.Add(this.textBox2);
            this.panelDashboard.Controls.Add(this.textBox1);
            this.panelDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDashboard.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panelDashboard.Location = new System.Drawing.Point(0, 0);
            this.panelDashboard.Name = "panelDashboard";
            this.panelDashboard.Size = new System.Drawing.Size(1317, 948);
            this.panelDashboard.TabIndex = 0;
            this.panelDashboard.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDashboard_Paint);
            // 
            // txtExp
            // 
            this.txtExp.BackColor = System.Drawing.Color.Cyan;
            this.txtExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtExp.Enabled = false;
            this.txtExp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtExp.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtExp.Location = new System.Drawing.Point(360, 404);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(147, 40);
            this.txtExp.TabIndex = 73;
            this.txtExp.Text = "0";
            this.txtExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtOutOStk
            // 
            this.txtOutOStk.BackColor = System.Drawing.Color.Cyan;
            this.txtOutOStk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOutOStk.Enabled = false;
            this.txtOutOStk.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtOutOStk.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtOutOStk.Location = new System.Drawing.Point(360, 338);
            this.txtOutOStk.Name = "txtOutOStk";
            this.txtOutOStk.Size = new System.Drawing.Size(147, 40);
            this.txtOutOStk.TabIndex = 72;
            this.txtOutOStk.Text = "0";
            this.txtOutOStk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCrit
            // 
            this.txtCrit.BackColor = System.Drawing.Color.Cyan;
            this.txtCrit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCrit.Enabled = false;
            this.txtCrit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtCrit.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCrit.Location = new System.Drawing.Point(360, 268);
            this.txtCrit.Name = "txtCrit";
            this.txtCrit.Size = new System.Drawing.Size(147, 40);
            this.txtCrit.TabIndex = 71;
            this.txtCrit.Text = "0";
            this.txtCrit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtReOrd
            // 
            this.txtReOrd.BackColor = System.Drawing.Color.Cyan;
            this.txtReOrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReOrd.Enabled = false;
            this.txtReOrd.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtReOrd.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtReOrd.Location = new System.Drawing.Point(360, 207);
            this.txtReOrd.Name = "txtReOrd";
            this.txtReOrd.Size = new System.Drawing.Size(147, 40);
            this.txtReOrd.TabIndex = 70;
            this.txtReOrd.Text = "0";
            this.txtReOrd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAvailStock
            // 
            this.txtAvailStock.BackColor = System.Drawing.Color.Cyan;
            this.txtAvailStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAvailStock.Enabled = false;
            this.txtAvailStock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtAvailStock.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtAvailStock.Location = new System.Drawing.Point(360, 137);
            this.txtAvailStock.Name = "txtAvailStock";
            this.txtAvailStock.Size = new System.Drawing.Size(147, 40);
            this.txtAvailStock.TabIndex = 69;
            this.txtAvailStock.Text = "0";
            this.txtAvailStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAvailStock.TextChanged += new System.EventHandler(this.txtAvailStock_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 38);
            this.label5.TabIndex = 67;
            this.label5.Text = "Expired:";
            // 
            // lblMasterCount
            // 
            this.lblMasterCount.AutoSize = true;
            this.lblMasterCount.ForeColor = System.Drawing.Color.Red;
            this.lblMasterCount.Location = new System.Drawing.Point(924, 724);
            this.lblMasterCount.Name = "lblMasterCount";
            this.lblMasterCount.Size = new System.Drawing.Size(32, 38);
            this.lblMasterCount.TabIndex = 66;
            this.lblMasterCount.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 724);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 38);
            this.label4.TabIndex = 65;
            this.label4.Text = "Master:";
            // 
            // lblReOrBlink
            // 
            this.lblReOrBlink.AutoSize = true;
            this.lblReOrBlink.Location = new System.Drawing.Point(100, 201);
            this.lblReOrBlink.Name = "lblReOrBlink";
            this.lblReOrBlink.Size = new System.Drawing.Size(137, 38);
            this.lblReOrBlink.TabIndex = 63;
            this.lblReOrBlink.Text = "Re-Order:";
            // 
            // lblSettledPay
            // 
            this.lblSettledPay.AutoSize = true;
            this.lblSettledPay.ForeColor = System.Drawing.Color.Green;
            this.lblSettledPay.Location = new System.Drawing.Point(911, 262);
            this.lblSettledPay.Name = "lblSettledPay";
            this.lblSettledPay.Size = new System.Drawing.Size(32, 38);
            this.lblSettledPay.TabIndex = 60;
            this.lblSettledPay.Text = "0";
            // 
            // lblPendingPay
            // 
            this.lblPendingPay.AutoSize = true;
            this.lblPendingPay.ForeColor = System.Drawing.Color.Red;
            this.lblPendingPay.Location = new System.Drawing.Point(911, 201);
            this.lblPendingPay.Name = "lblPendingPay";
            this.lblPendingPay.Size = new System.Drawing.Size(32, 38);
            this.lblPendingPay.TabIndex = 59;
            this.lblPendingPay.Text = "0";
            // 
            // lblClaimedOrd
            // 
            this.lblClaimedOrd.AutoSize = true;
            this.lblClaimedOrd.ForeColor = System.Drawing.Color.Green;
            this.lblClaimedOrd.Location = new System.Drawing.Point(289, 762);
            this.lblClaimedOrd.Name = "lblClaimedOrd";
            this.lblClaimedOrd.Size = new System.Drawing.Size(32, 38);
            this.lblClaimedOrd.TabIndex = 57;
            this.lblClaimedOrd.Text = "0";
            // 
            // lblInLab
            // 
            this.lblInLab.AutoSize = true;
            this.lblInLab.ForeColor = System.Drawing.Color.Red;
            this.lblInLab.Location = new System.Drawing.Point(289, 701);
            this.lblInLab.Name = "lblInLab";
            this.lblInLab.Size = new System.Drawing.Size(32, 38);
            this.lblInLab.TabIndex = 56;
            this.lblInLab.Text = "0";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.ForeColor = System.Drawing.Color.Green;
            this.lblTotalUsers.Location = new System.Drawing.Point(924, 783);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(32, 38);
            this.lblTotalUsers.TabIndex = 55;
            this.lblTotalUsers.Text = "0";
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.ForeColor = System.Drawing.Color.Red;
            this.lblCashier.Location = new System.Drawing.Point(924, 667);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(32, 38);
            this.lblCashier.TabIndex = 54;
            this.lblCashier.Text = "0";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.ForeColor = System.Drawing.Color.Red;
            this.lblAdmin.Location = new System.Drawing.Point(924, 606);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(32, 38);
            this.lblAdmin.TabIndex = 53;
            this.lblAdmin.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(100, 757);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(123, 38);
            this.label14.TabIndex = 15;
            this.label14.Text = "Claimed:";
            // 
            // lblInLabBlink
            // 
            this.lblInLabBlink.AutoSize = true;
            this.lblInLabBlink.Location = new System.Drawing.Point(100, 696);
            this.lblInLabBlink.Name = "lblInLabBlink";
            this.lblInLabBlink.Size = new System.Drawing.Size(145, 38);
            this.lblInLabBlink.TabIndex = 14;
            this.lblInLabBlink.Text = "In the Lab:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(718, 783);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 38);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total Users:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(718, 667);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 38);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cashier:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(718, 606);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 38);
            this.label11.TabIndex = 11;
            this.label11.Text = "Admin:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(709, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "Settled:";
            // 
            // lblPendingBlink
            // 
            this.lblPendingBlink.AutoSize = true;
            this.lblPendingBlink.Location = new System.Drawing.Point(709, 201);
            this.lblPendingBlink.Name = "lblPendingBlink";
            this.lblPendingBlink.Size = new System.Drawing.Size(124, 38);
            this.lblPendingBlink.TabIndex = 7;
            this.lblPendingBlink.Text = "Pending:";
            // 
            // lblOofStkBlink
            // 
            this.lblOofStkBlink.AutoSize = true;
            this.lblOofStkBlink.Location = new System.Drawing.Point(100, 332);
            this.lblOofStkBlink.Name = "lblOofStkBlink";
            this.lblOofStkBlink.Size = new System.Drawing.Size(176, 38);
            this.lblOofStkBlink.TabIndex = 6;
            this.lblOofStkBlink.Text = "Out of Stock:";
            // 
            // lblCritBlink
            // 
            this.lblCritBlink.AutoSize = true;
            this.lblCritBlink.Location = new System.Drawing.Point(100, 266);
            this.lblCritBlink.Name = "lblCritBlink";
            this.lblCritBlink.Size = new System.Drawing.Size(107, 38);
            this.lblCritBlink.TabIndex = 5;
            this.lblCritBlink.Text = "Critical:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Safety:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Cyan;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(67, 592);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(572, 40);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Order Monitoring";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Cyan;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(689, 526);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(572, 40);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Users";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Cyan;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(689, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(572, 40);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Payment Monitoring";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Cyan;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(67, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(572, 40);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Stock";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1598, 948);
            this.ControlBox = false;
            this.Controls.Add(this.panelLoad);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.dropPanelSales.ResumeLayout(false);
            this.dropPanelProducts.ResumeLayout(false);
            this.dropPanelPayment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLoad.ResumeLayout(false);
            this.panelDashboard.ResumeLayout(false);
            this.panelDashboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private System.Windows.Forms.Timer timerDrpBtnProducts;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timerDrpBtnPayment;
        private System.Windows.Forms.Timer timerDrpBtnSales;
        private Panel panel4;
        private Panel dropPanelSales;
        private Panel dropPanelPayment;
        private Button dropBtnProducts;
        private Panel panelLoad;
        public Label lblName;
        private Panel panelDashboard;
        private Label label14;
        private Label lblInLabBlink;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label6;
        private Label lblPendingBlink;
        private Label lblOofStkBlink;
        private Label lblCritBlink;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        public Label lblSettledPay;
        public Label lblPendingPay;
        public Label lblClaimedOrd;
        public Label lblInLab;
        public Label lblTotalUsers;
        public Label lblCashier;
        public Label lblAdmin;
        public Button btnUserSettings;
        public Button btnBackupArch;
        public Button btnInventory;
        public Button btnStockDel;
        public Panel dropPanelProducts;
        public Button btnPatientR;
        public Button btnDashboard;
        public Button dropBtnReports;
        public Button dropBtnPayment;
        private Button btnLogout;
        public Button btnCashier;
        private Label lblReOrBlink;
        public Label lblMasterCount;
        private Label label4;
        public TextBox txtExp;
        public TextBox txtOutOStk;
        public TextBox txtCrit;
        public TextBox txtReOrd;
        public TextBox txtAvailStock;
        public Label label5;
    }
}