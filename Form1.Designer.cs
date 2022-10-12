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
            this.lblSalesTotal = new System.Windows.Forms.Label();
            this.lblSales30Days = new System.Windows.Forms.Label();
            this.lblSales7Days = new System.Windows.Forms.Label();
            this.lblSalesToday = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.lblTypeCount = new System.Windows.Forms.Label();
            this.lblProductCount = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblCashier = new System.Windows.Forms.Label();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.lblOutOfStock = new System.Windows.Forms.Label();
            this.lblCriticalStock = new System.Windows.Forms.Label();
            this.lblAvailableStock = new System.Windows.Forms.Label();
            this.btnCategoryDetails = new System.Windows.Forms.Button();
            this.btnUsersDetails = new System.Windows.Forms.Button();
            this.btnStockDetails = new System.Windows.Forms.Button();
            this.btnSalesDetails = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.btnLogout.Location = new System.Drawing.Point(0, 482);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(278, 52);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "   Logout";
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.dropBtnReports.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
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
            this.pictureBox1.Image = global::Capstone.Properties.Resources.User;
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
            this.panelDashboard.Controls.Add(this.lblSalesTotal);
            this.panelDashboard.Controls.Add(this.lblSales30Days);
            this.panelDashboard.Controls.Add(this.lblSales7Days);
            this.panelDashboard.Controls.Add(this.lblSalesToday);
            this.panelDashboard.Controls.Add(this.lblItemCount);
            this.panelDashboard.Controls.Add(this.lblTypeCount);
            this.panelDashboard.Controls.Add(this.lblProductCount);
            this.panelDashboard.Controls.Add(this.lblTotalUsers);
            this.panelDashboard.Controls.Add(this.lblCashier);
            this.panelDashboard.Controls.Add(this.lblAdmin);
            this.panelDashboard.Controls.Add(this.lblOutOfStock);
            this.panelDashboard.Controls.Add(this.lblCriticalStock);
            this.panelDashboard.Controls.Add(this.lblAvailableStock);
            this.panelDashboard.Controls.Add(this.btnCategoryDetails);
            this.panelDashboard.Controls.Add(this.btnUsersDetails);
            this.panelDashboard.Controls.Add(this.btnStockDetails);
            this.panelDashboard.Controls.Add(this.btnSalesDetails);
            this.panelDashboard.Controls.Add(this.label13);
            this.panelDashboard.Controls.Add(this.label14);
            this.panelDashboard.Controls.Add(this.label15);
            this.panelDashboard.Controls.Add(this.label9);
            this.panelDashboard.Controls.Add(this.label10);
            this.panelDashboard.Controls.Add(this.label11);
            this.panelDashboard.Controls.Add(this.label8);
            this.panelDashboard.Controls.Add(this.label5);
            this.panelDashboard.Controls.Add(this.label6);
            this.panelDashboard.Controls.Add(this.label7);
            this.panelDashboard.Controls.Add(this.label4);
            this.panelDashboard.Controls.Add(this.label3);
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
            // 
            // lblSalesTotal
            // 
            this.lblSalesTotal.AutoSize = true;
            this.lblSalesTotal.ForeColor = System.Drawing.Color.Red;
            this.lblSalesTotal.Location = new System.Drawing.Point(891, 350);
            this.lblSalesTotal.Name = "lblSalesTotal";
            this.lblSalesTotal.Size = new System.Drawing.Size(23, 38);
            this.lblSalesTotal.TabIndex = 62;
            this.lblSalesTotal.Text = ".";
            // 
            // lblSales30Days
            // 
            this.lblSales30Days.AutoSize = true;
            this.lblSales30Days.ForeColor = System.Drawing.Color.Red;
            this.lblSales30Days.Location = new System.Drawing.Point(891, 280);
            this.lblSales30Days.Name = "lblSales30Days";
            this.lblSales30Days.Size = new System.Drawing.Size(23, 38);
            this.lblSales30Days.TabIndex = 61;
            this.lblSales30Days.Text = ".";
            // 
            // lblSales7Days
            // 
            this.lblSales7Days.AutoSize = true;
            this.lblSales7Days.ForeColor = System.Drawing.Color.Red;
            this.lblSales7Days.Location = new System.Drawing.Point(891, 214);
            this.lblSales7Days.Name = "lblSales7Days";
            this.lblSales7Days.Size = new System.Drawing.Size(23, 38);
            this.lblSales7Days.TabIndex = 60;
            this.lblSales7Days.Text = ".";
            // 
            // lblSalesToday
            // 
            this.lblSalesToday.AutoSize = true;
            this.lblSalesToday.ForeColor = System.Drawing.Color.Red;
            this.lblSalesToday.Location = new System.Drawing.Point(891, 153);
            this.lblSalesToday.Name = "lblSalesToday";
            this.lblSalesToday.Size = new System.Drawing.Size(23, 38);
            this.lblSalesToday.TabIndex = 59;
            this.lblSalesToday.Text = ".";
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.ForeColor = System.Drawing.Color.Red;
            this.lblItemCount.Location = new System.Drawing.Point(878, 724);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(32, 38);
            this.lblItemCount.TabIndex = 58;
            this.lblItemCount.Text = "0";
            // 
            // lblTypeCount
            // 
            this.lblTypeCount.AutoSize = true;
            this.lblTypeCount.ForeColor = System.Drawing.Color.Red;
            this.lblTypeCount.Location = new System.Drawing.Point(878, 658);
            this.lblTypeCount.Name = "lblTypeCount";
            this.lblTypeCount.Size = new System.Drawing.Size(32, 38);
            this.lblTypeCount.TabIndex = 57;
            this.lblTypeCount.Text = "0";
            // 
            // lblProductCount
            // 
            this.lblProductCount.AutoSize = true;
            this.lblProductCount.ForeColor = System.Drawing.Color.Red;
            this.lblProductCount.Location = new System.Drawing.Point(878, 597);
            this.lblProductCount.Name = "lblProductCount";
            this.lblProductCount.Size = new System.Drawing.Size(32, 38);
            this.lblProductCount.TabIndex = 56;
            this.lblProductCount.Text = "0";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.ForeColor = System.Drawing.Color.Green;
            this.lblTotalUsers.Location = new System.Drawing.Point(306, 733);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(32, 38);
            this.lblTotalUsers.TabIndex = 55;
            this.lblTotalUsers.Text = "0";
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.ForeColor = System.Drawing.Color.Red;
            this.lblCashier.Location = new System.Drawing.Point(306, 667);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(32, 38);
            this.lblCashier.TabIndex = 54;
            this.lblCashier.Text = "0";
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.ForeColor = System.Drawing.Color.Red;
            this.lblAdmin.Location = new System.Drawing.Point(306, 606);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(32, 38);
            this.lblAdmin.TabIndex = 53;
            this.lblAdmin.Text = "0";
            // 
            // lblOutOfStock
            // 
            this.lblOutOfStock.AutoSize = true;
            this.lblOutOfStock.ForeColor = System.Drawing.Color.Red;
            this.lblOutOfStock.Location = new System.Drawing.Point(306, 280);
            this.lblOutOfStock.Name = "lblOutOfStock";
            this.lblOutOfStock.Size = new System.Drawing.Size(32, 38);
            this.lblOutOfStock.TabIndex = 52;
            this.lblOutOfStock.Text = "0";
            // 
            // lblCriticalStock
            // 
            this.lblCriticalStock.AutoSize = true;
            this.lblCriticalStock.ForeColor = System.Drawing.Color.Gold;
            this.lblCriticalStock.Location = new System.Drawing.Point(306, 214);
            this.lblCriticalStock.Name = "lblCriticalStock";
            this.lblCriticalStock.Size = new System.Drawing.Size(32, 38);
            this.lblCriticalStock.TabIndex = 51;
            this.lblCriticalStock.Text = "0";
            // 
            // lblAvailableStock
            // 
            this.lblAvailableStock.AutoSize = true;
            this.lblAvailableStock.ForeColor = System.Drawing.Color.Green;
            this.lblAvailableStock.Location = new System.Drawing.Point(306, 153);
            this.lblAvailableStock.Name = "lblAvailableStock";
            this.lblAvailableStock.Size = new System.Drawing.Size(32, 38);
            this.lblAvailableStock.TabIndex = 50;
            this.lblAvailableStock.Text = "0";
            // 
            // btnCategoryDetails
            // 
            this.btnCategoryDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCategoryDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoryDetails.FlatAppearance.BorderSize = 0;
            this.btnCategoryDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoryDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCategoryDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCategoryDetails.Location = new System.Drawing.Point(847, 793);
            this.btnCategoryDetails.Name = "btnCategoryDetails";
            this.btnCategoryDetails.Size = new System.Drawing.Size(286, 49);
            this.btnCategoryDetails.TabIndex = 49;
            this.btnCategoryDetails.Text = "View Details";
            this.btnCategoryDetails.UseVisualStyleBackColor = false;
            this.btnCategoryDetails.Click += new System.EventHandler(this.btnCategoryDetails_Click);
            // 
            // btnUsersDetails
            // 
            this.btnUsersDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnUsersDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsersDetails.FlatAppearance.BorderSize = 0;
            this.btnUsersDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsersDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUsersDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnUsersDetails.Location = new System.Drawing.Point(200, 803);
            this.btnUsersDetails.Name = "btnUsersDetails";
            this.btnUsersDetails.Size = new System.Drawing.Size(286, 49);
            this.btnUsersDetails.TabIndex = 48;
            this.btnUsersDetails.Text = "View Details";
            this.btnUsersDetails.UseVisualStyleBackColor = false;
            this.btnUsersDetails.Click += new System.EventHandler(this.btnUsersDetails_Click);
            // 
            // btnStockDetails
            // 
            this.btnStockDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStockDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStockDetails.FlatAppearance.BorderSize = 0;
            this.btnStockDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStockDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnStockDetails.Location = new System.Drawing.Point(200, 415);
            this.btnStockDetails.Name = "btnStockDetails";
            this.btnStockDetails.Size = new System.Drawing.Size(286, 49);
            this.btnStockDetails.TabIndex = 47;
            this.btnStockDetails.Text = "View Details";
            this.btnStockDetails.UseVisualStyleBackColor = false;
            this.btnStockDetails.Click += new System.EventHandler(this.btnStockDetails_Click);
            // 
            // btnSalesDetails
            // 
            this.btnSalesDetails.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalesDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalesDetails.FlatAppearance.BorderSize = 0;
            this.btnSalesDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesDetails.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSalesDetails.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnSalesDetails.Location = new System.Drawing.Point(847, 415);
            this.btnSalesDetails.Name = "btnSalesDetails";
            this.btnSalesDetails.Size = new System.Drawing.Size(286, 49);
            this.btnSalesDetails.TabIndex = 46;
            this.btnSalesDetails.Text = "View Details";
            this.btnSalesDetails.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(689, 719);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 38);
            this.label13.TabIndex = 16;
            this.label13.Text = "Item:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(689, 653);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 38);
            this.label14.TabIndex = 15;
            this.label14.Text = "Type:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(689, 592);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 38);
            this.label15.TabIndex = 14;
            this.label15.Text = "Product:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(100, 733);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 38);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total Users:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(100, 667);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 38);
            this.label10.TabIndex = 12;
            this.label10.Text = "Cashier:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 606);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 38);
            this.label11.TabIndex = 11;
            this.label11.Text = "Admin:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(689, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 38);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total Sales:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(689, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 38);
            this.label5.TabIndex = 9;
            this.label5.Text = "Last 30 Days:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(689, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 38);
            this.label6.TabIndex = 8;
            this.label6.Text = "Last 7 Days:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(689, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 38);
            this.label7.TabIndex = 7;
            this.label7.Text = "Today:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 38);
            this.label4.TabIndex = 6;
            this.label4.Text = "Out of Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Critical:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Available:";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.Cyan;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(689, 514);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(572, 40);
            this.textBox4.TabIndex = 3;
            this.textBox4.Text = "Category";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Cyan;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(67, 514);
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
            this.textBox2.Text = "Sales";
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
        private Button btnLogout;
        private Button btnUserSettings;
        private Button btnBackupArch;
        private Panel dropPanelSales;
        private Button btnInventory;
        private Button btnStockDel;
        private Panel dropPanelProducts;
        private Panel dropPanelPayment;
        private Button btnPatientR;
        private Button btnDashboard;
        private Button dropBtnReports;
        private Button dropBtnProducts;
        private Button dropBtnPayment;
        private Panel panelLoad;
        public Label lblName;
        private Panel panelDashboard;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        public Label lblSalesTotal;
        public Label lblSales30Days;
        public Label lblSales7Days;
        public Label lblSalesToday;
        public Label lblItemCount;
        public Label lblTypeCount;
        public Label lblProductCount;
        public Label lblTotalUsers;
        public Label lblCashier;
        public Label lblAdmin;
        public Label lblOutOfStock;
        public Label lblCriticalStock;
        public Label lblAvailableStock;
        public Button btnCategoryDetails;
        public Button btnUsersDetails;
        public Button btnStockDetails;
        public Button btnSalesDetails;
    }
}