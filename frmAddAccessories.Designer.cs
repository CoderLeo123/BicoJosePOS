namespace Capstone
{
    partial class frmAddAccessories
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCloseAccessories = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControlCreateNew = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.txtProdID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnCancelProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnSaveProduct = new System.Windows.Forms.Button();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelType = new System.Windows.Forms.Panel();
            this.txtProductIDType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comBoxProductType = new System.Windows.Forms.ComboBox();
            this.txtTypID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCancelType = new System.Windows.Forms.Button();
            this.btnUpdateType = new System.Windows.Forms.Button();
            this.btnSaveType = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelItem = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comBoxClassification = new System.Windows.Forms.ComboBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.btnSaveItem = new System.Windows.Forms.Button();
            this.txtTypeID = new System.Windows.Forms.TextBox();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCancelItem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.comBoxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panelService = new System.Windows.Forms.Panel();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtServicePrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtServiceDesc = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCloseService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnSaveService = new System.Windows.Forms.Button();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAccessories)).BeginInit();
            this.tabControlCreateNew.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelProduct.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelType.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelItem.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panelService.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 57);
            this.panel1.TabIndex = 18;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCloseAccessories);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(801, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(98, 57);
            this.panel2.TabIndex = 39;
            // 
            // btnCloseAccessories
            // 
            this.btnCloseAccessories.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseAccessories.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnCloseAccessories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseAccessories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseAccessories.Location = new System.Drawing.Point(41, 9);
            this.btnCloseAccessories.Name = "btnCloseAccessories";
            this.btnCloseAccessories.Padding = new System.Windows.Forms.Padding(3);
            this.btnCloseAccessories.Size = new System.Drawing.Size(40, 38);
            this.btnCloseAccessories.TabIndex = 0;
            this.btnCloseAccessories.TabStop = false;
            this.btnCloseAccessories.Click += new System.EventHandler(this.btnCloseAccessories_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Create New";
            // 
            // tabControlCreateNew
            // 
            this.tabControlCreateNew.Controls.Add(this.tabPage1);
            this.tabControlCreateNew.Controls.Add(this.tabPage2);
            this.tabControlCreateNew.Controls.Add(this.tabPage3);
            this.tabControlCreateNew.Controls.Add(this.tabPage4);
            this.tabControlCreateNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlCreateNew.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlCreateNew.Location = new System.Drawing.Point(0, 57);
            this.tabControlCreateNew.Name = "tabControlCreateNew";
            this.tabControlCreateNew.SelectedIndex = 0;
            this.tabControlCreateNew.Size = new System.Drawing.Size(899, 547);
            this.tabControlCreateNew.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelProduct);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Product";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelProduct
            // 
            this.panelProduct.Controls.Add(this.txtProdID);
            this.panelProduct.Controls.Add(this.label17);
            this.panelProduct.Controls.Add(this.btnCancelProduct);
            this.panelProduct.Controls.Add(this.btnUpdateProduct);
            this.panelProduct.Controls.Add(this.btnSaveProduct);
            this.panelProduct.Controls.Add(this.txtProdName);
            this.panelProduct.Controls.Add(this.label18);
            this.panelProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelProduct.Location = new System.Drawing.Point(3, 3);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(885, 491);
            this.panelProduct.TabIndex = 0;
            // 
            // txtProdID
            // 
            this.txtProdID.Enabled = false;
            this.txtProdID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdID.Location = new System.Drawing.Point(288, 136);
            this.txtProdID.Name = "txtProdID";
            this.txtProdID.PlaceholderText = "P1001";
            this.txtProdID.Size = new System.Drawing.Size(204, 38);
            this.txtProdID.TabIndex = 52;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(108, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 41);
            this.label17.TabIndex = 51;
            this.label17.Text = "Product ID";
            // 
            // btnCancelProduct
            // 
            this.btnCancelProduct.BackColor = System.Drawing.Color.Red;
            this.btnCancelProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelProduct.FlatAppearance.BorderSize = 0;
            this.btnCancelProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelProduct.ForeColor = System.Drawing.Color.White;
            this.btnCancelProduct.Location = new System.Drawing.Point(514, 263);
            this.btnCancelProduct.Name = "btnCancelProduct";
            this.btnCancelProduct.Size = new System.Drawing.Size(153, 49);
            this.btnCancelProduct.TabIndex = 50;
            this.btnCancelProduct.Text = "Cancel";
            this.btnCancelProduct.UseVisualStyleBackColor = false;
            this.btnCancelProduct.Click += new System.EventHandler(this.btnCancelProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateProduct.Enabled = false;
            this.btnUpdateProduct.FlatAppearance.BorderSize = 0;
            this.btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateProduct.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProduct.Location = new System.Drawing.Point(355, 263);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(153, 49);
            this.btnUpdateProduct.TabIndex = 49;
            this.btnUpdateProduct.Text = " Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = false;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnSaveProduct
            // 
            this.btnSaveProduct.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveProduct.FlatAppearance.BorderSize = 0;
            this.btnSaveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveProduct.ForeColor = System.Drawing.Color.White;
            this.btnSaveProduct.Location = new System.Drawing.Point(196, 263);
            this.btnSaveProduct.Name = "btnSaveProduct";
            this.btnSaveProduct.Size = new System.Drawing.Size(153, 49);
            this.btnSaveProduct.TabIndex = 48;
            this.btnSaveProduct.Text = "Save";
            this.btnSaveProduct.UseVisualStyleBackColor = false;
            this.btnSaveProduct.Click += new System.EventHandler(this.btnSaveProduct_Click);
            // 
            // txtProdName
            // 
            this.txtProdName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProdName.Location = new System.Drawing.Point(288, 189);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.PlaceholderText = "Ex. Eyeglass Frame";
            this.txtProdName.Size = new System.Drawing.Size(411, 38);
            this.txtProdName.TabIndex = 47;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(108, 189);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(122, 41);
            this.label18.TabIndex = 46;
            this.label18.Text = "Product";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelType);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(891, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Type";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelType
            // 
            this.panelType.Controls.Add(this.txtProductIDType);
            this.panelType.Controls.Add(this.label9);
            this.panelType.Controls.Add(this.comBoxProductType);
            this.panelType.Controls.Add(this.txtTypID);
            this.panelType.Controls.Add(this.label10);
            this.panelType.Controls.Add(this.txtType);
            this.panelType.Controls.Add(this.label11);
            this.panelType.Controls.Add(this.btnCancelType);
            this.panelType.Controls.Add(this.btnUpdateType);
            this.panelType.Controls.Add(this.btnSaveType);
            this.panelType.Controls.Add(this.label12);
            this.panelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelType.Location = new System.Drawing.Point(3, 3);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(885, 491);
            this.panelType.TabIndex = 0;
            // 
            // txtProductIDType
            // 
            this.txtProductIDType.Enabled = false;
            this.txtProductIDType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductIDType.Location = new System.Drawing.Point(237, 158);
            this.txtProductIDType.Name = "txtProductIDType";
            this.txtProductIDType.PlaceholderText = "P1001";
            this.txtProductIDType.Size = new System.Drawing.Size(204, 38);
            this.txtProductIDType.TabIndex = 49;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(57, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 41);
            this.label9.TabIndex = 48;
            this.label9.Text = "Product ID";
            // 
            // comBoxProductType
            // 
            this.comBoxProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxProductType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxProductType.Location = new System.Drawing.Point(237, 213);
            this.comBoxProductType.Name = "comBoxProductType";
            this.comBoxProductType.Size = new System.Drawing.Size(425, 39);
            this.comBoxProductType.TabIndex = 47;
            this.comBoxProductType.SelectedIndexChanged += new System.EventHandler(this.comBoxProduct_SelectedIndexChanged);
            // 
            // txtTypID
            // 
            this.txtTypID.Enabled = false;
            this.txtTypID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTypID.Location = new System.Drawing.Point(237, 103);
            this.txtTypID.Name = "txtTypID";
            this.txtTypID.PlaceholderText = "T1001";
            this.txtTypID.Size = new System.Drawing.Size(204, 38);
            this.txtTypID.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(57, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 41);
            this.label10.TabIndex = 45;
            this.label10.Text = "Type ID";
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtType.Location = new System.Drawing.Point(237, 268);
            this.txtType.Name = "txtType";
            this.txtType.PlaceholderText = "Ex. Semi-Rimless Frames";
            this.txtType.Size = new System.Drawing.Size(582, 38);
            this.txtType.TabIndex = 44;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(57, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 41);
            this.label11.TabIndex = 43;
            this.label11.Text = "Type";
            // 
            // btnCancelType
            // 
            this.btnCancelType.BackColor = System.Drawing.Color.Red;
            this.btnCancelType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelType.FlatAppearance.BorderSize = 0;
            this.btnCancelType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelType.ForeColor = System.Drawing.Color.White;
            this.btnCancelType.Location = new System.Drawing.Point(555, 333);
            this.btnCancelType.Name = "btnCancelType";
            this.btnCancelType.Size = new System.Drawing.Size(153, 49);
            this.btnCancelType.TabIndex = 42;
            this.btnCancelType.Text = "Cancel";
            this.btnCancelType.UseVisualStyleBackColor = false;
            this.btnCancelType.Click += new System.EventHandler(this.btnCancelType_Click);
            // 
            // btnUpdateType
            // 
            this.btnUpdateType.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateType.Enabled = false;
            this.btnUpdateType.FlatAppearance.BorderSize = 0;
            this.btnUpdateType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateType.ForeColor = System.Drawing.Color.White;
            this.btnUpdateType.Location = new System.Drawing.Point(396, 333);
            this.btnUpdateType.Name = "btnUpdateType";
            this.btnUpdateType.Size = new System.Drawing.Size(153, 49);
            this.btnUpdateType.TabIndex = 41;
            this.btnUpdateType.Text = "Update";
            this.btnUpdateType.UseVisualStyleBackColor = false;
            this.btnUpdateType.Click += new System.EventHandler(this.btnUpdateType_Click);
            // 
            // btnSaveType
            // 
            this.btnSaveType.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveType.FlatAppearance.BorderSize = 0;
            this.btnSaveType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveType.ForeColor = System.Drawing.Color.White;
            this.btnSaveType.Location = new System.Drawing.Point(237, 333);
            this.btnSaveType.Name = "btnSaveType";
            this.btnSaveType.Size = new System.Drawing.Size(153, 49);
            this.btnSaveType.TabIndex = 40;
            this.btnSaveType.Text = "Save";
            this.btnSaveType.UseVisualStyleBackColor = false;
            this.btnSaveType.Click += new System.EventHandler(this.btnSaveType_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(57, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 41);
            this.label12.TabIndex = 39;
            this.label12.Text = "Product";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelItem);
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(891, 497);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Item";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelItem
            // 
            this.panelItem.Controls.Add(this.label5);
            this.panelItem.Controls.Add(this.label8);
            this.panelItem.Controls.Add(this.label2);
            this.panelItem.Controls.Add(this.comBoxClassification);
            this.panelItem.Controls.Add(this.txtPrice);
            this.panelItem.Controls.Add(this.txtProduct);
            this.panelItem.Controls.Add(this.btnSaveItem);
            this.panelItem.Controls.Add(this.txtTypeID);
            this.panelItem.Controls.Add(this.btnUpdateItem);
            this.panelItem.Controls.Add(this.label7);
            this.panelItem.Controls.Add(this.btnCancelItem);
            this.panelItem.Controls.Add(this.label6);
            this.panelItem.Controls.Add(this.label3);
            this.panelItem.Controls.Add(this.txtID);
            this.panelItem.Controls.Add(this.txtDescription);
            this.panelItem.Controls.Add(this.comBoxType);
            this.panelItem.Controls.Add(this.label4);
            this.panelItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelItem.Location = new System.Drawing.Point(0, 0);
            this.panelItem.Name = "panelItem";
            this.panelItem.Size = new System.Drawing.Size(891, 497);
            this.panelItem.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(90, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 38);
            this.label5.TabIndex = 48;
            this.label5.Text = "Item ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(90, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 38);
            this.label8.TabIndex = 55;
            this.label8.Text = "Classification";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(90, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 38);
            this.label2.TabIndex = 39;
            this.label2.Text = "Price";
            // 
            // comBoxClassification
            // 
            this.comBoxClassification.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxClassification.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxClassification.Items.AddRange(new object[] {
            "Consumable",
            "Non-Consumable"});
            this.comBoxClassification.Location = new System.Drawing.Point(296, 206);
            this.comBoxClassification.Name = "comBoxClassification";
            this.comBoxClassification.Size = new System.Drawing.Size(256, 39);
            this.comBoxClassification.TabIndex = 54;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(296, 151);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "0.00";
            this.txtPrice.Size = new System.Drawing.Size(256, 38);
            this.txtPrice.TabIndex = 40;
            // 
            // txtProduct
            // 
            this.txtProduct.Enabled = false;
            this.txtProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProduct.Location = new System.Drawing.Point(296, 326);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(256, 38);
            this.txtProduct.TabIndex = 53;
            // 
            // btnSaveItem
            // 
            this.btnSaveItem.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveItem.FlatAppearance.BorderSize = 0;
            this.btnSaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveItem.ForeColor = System.Drawing.Color.White;
            this.btnSaveItem.Location = new System.Drawing.Point(95, 433);
            this.btnSaveItem.Name = "btnSaveItem";
            this.btnSaveItem.Size = new System.Drawing.Size(153, 49);
            this.btnSaveItem.TabIndex = 41;
            this.btnSaveItem.Text = "Save";
            this.btnSaveItem.UseVisualStyleBackColor = false;
            this.btnSaveItem.Click += new System.EventHandler(this.btnSaveItem_Click);
            // 
            // txtTypeID
            // 
            this.txtTypeID.Enabled = false;
            this.txtTypeID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTypeID.Location = new System.Drawing.Point(296, 380);
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.PlaceholderText = "T1001";
            this.txtTypeID.Size = new System.Drawing.Size(256, 38);
            this.txtTypeID.TabIndex = 52;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateItem.Enabled = false;
            this.btnUpdateItem.FlatAppearance.BorderSize = 0;
            this.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateItem.ForeColor = System.Drawing.Color.White;
            this.btnUpdateItem.Location = new System.Drawing.Point(254, 433);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(153, 49);
            this.btnUpdateItem.TabIndex = 42;
            this.btnUpdateItem.Text = "Update";
            this.btnUpdateItem.UseVisualStyleBackColor = false;
            this.btnUpdateItem.Click += new System.EventHandler(this.btnUpdateItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(90, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 38);
            this.label7.TabIndex = 51;
            this.label7.Text = "Type ID";
            // 
            // btnCancelItem
            // 
            this.btnCancelItem.BackColor = System.Drawing.Color.Red;
            this.btnCancelItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelItem.FlatAppearance.BorderSize = 0;
            this.btnCancelItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelItem.ForeColor = System.Drawing.Color.White;
            this.btnCancelItem.Location = new System.Drawing.Point(413, 433);
            this.btnCancelItem.Name = "btnCancelItem";
            this.btnCancelItem.Size = new System.Drawing.Size(153, 49);
            this.btnCancelItem.TabIndex = 43;
            this.btnCancelItem.Text = "Cancel";
            this.btnCancelItem.UseVisualStyleBackColor = false;
            this.btnCancelItem.Click += new System.EventHandler(this.btnCancelItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(90, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 38);
            this.label6.TabIndex = 50;
            this.label6.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(90, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 38);
            this.label3.TabIndex = 44;
            this.label3.Text = "Description";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(296, 41);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "ITM1001";
            this.txtID.Size = new System.Drawing.Size(256, 38);
            this.txtID.TabIndex = 49;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(296, 94);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Ex. Eyeglass Cleaning Solution Spray Bottle 50ml";
            this.txtDescription.Size = new System.Drawing.Size(566, 38);
            this.txtDescription.TabIndex = 45;
            // 
            // comBoxType
            // 
            this.comBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxType.Location = new System.Drawing.Point(296, 274);
            this.comBoxType.Name = "comBoxType";
            this.comBoxType.Size = new System.Drawing.Size(256, 39);
            this.comBoxType.TabIndex = 46;
            this.comBoxType.SelectedIndexChanged += new System.EventHandler(this.comBoxType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(90, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 38);
            this.label4.TabIndex = 47;
            this.label4.Text = "Type";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panelService);
            this.tabPage4.Location = new System.Drawing.Point(4, 46);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(891, 497);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Service";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panelService
            // 
            this.panelService.Controls.Add(this.txtServiceID);
            this.panelService.Controls.Add(this.label13);
            this.panelService.Controls.Add(this.txtServicePrice);
            this.panelService.Controls.Add(this.label14);
            this.panelService.Controls.Add(this.txtServiceDesc);
            this.panelService.Controls.Add(this.label15);
            this.panelService.Controls.Add(this.btnCloseService);
            this.panelService.Controls.Add(this.btnUpdateService);
            this.panelService.Controls.Add(this.btnSaveService);
            this.panelService.Controls.Add(this.txtServiceName);
            this.panelService.Controls.Add(this.label16);
            this.panelService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelService.Location = new System.Drawing.Point(0, 0);
            this.panelService.Name = "panelService";
            this.panelService.Size = new System.Drawing.Size(891, 497);
            this.panelService.TabIndex = 0;
            // 
            // txtServiceID
            // 
            this.txtServiceID.Enabled = false;
            this.txtServiceID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtServiceID.Location = new System.Drawing.Point(256, 111);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.PlaceholderText = "S1001";
            this.txtServiceID.Size = new System.Drawing.Size(164, 38);
            this.txtServiceID.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(52, 106);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 41);
            this.label13.TabIndex = 29;
            this.label13.Text = "Service ID";
            // 
            // txtServicePrice
            // 
            this.txtServicePrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtServicePrice.Location = new System.Drawing.Point(256, 288);
            this.txtServicePrice.Name = "txtServicePrice";
            this.txtServicePrice.PlaceholderText = "0.00";
            this.txtServicePrice.Size = new System.Drawing.Size(199, 38);
            this.txtServicePrice.TabIndex = 28;
            this.txtServicePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServicePrice_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(52, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 41);
            this.label14.TabIndex = 27;
            this.label14.Text = "Price";
            // 
            // txtServiceDesc
            // 
            this.txtServiceDesc.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtServiceDesc.Location = new System.Drawing.Point(256, 230);
            this.txtServiceDesc.Name = "txtServiceDesc";
            this.txtServiceDesc.PlaceholderText = "Ex. Automated reading of eyeglass prescription";
            this.txtServiceDesc.Size = new System.Drawing.Size(582, 38);
            this.txtServiceDesc.TabIndex = 26;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(52, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 41);
            this.label15.TabIndex = 25;
            this.label15.Text = "Description";
            // 
            // btnCloseService
            // 
            this.btnCloseService.BackColor = System.Drawing.Color.Red;
            this.btnCloseService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseService.FlatAppearance.BorderSize = 0;
            this.btnCloseService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseService.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCloseService.ForeColor = System.Drawing.Color.White;
            this.btnCloseService.Location = new System.Drawing.Point(574, 343);
            this.btnCloseService.Name = "btnCloseService";
            this.btnCloseService.Size = new System.Drawing.Size(153, 49);
            this.btnCloseService.TabIndex = 24;
            this.btnCloseService.Text = "Cancel";
            this.btnCloseService.UseVisualStyleBackColor = false;
            this.btnCloseService.Click += new System.EventHandler(this.btnCloseService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateService.Enabled = false;
            this.btnUpdateService.FlatAppearance.BorderSize = 0;
            this.btnUpdateService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateService.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateService.ForeColor = System.Drawing.Color.White;
            this.btnUpdateService.Location = new System.Drawing.Point(415, 343);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(153, 49);
            this.btnUpdateService.TabIndex = 23;
            this.btnUpdateService.Text = "Update";
            this.btnUpdateService.UseVisualStyleBackColor = false;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnSaveService
            // 
            this.btnSaveService.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveService.FlatAppearance.BorderSize = 0;
            this.btnSaveService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveService.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveService.ForeColor = System.Drawing.Color.White;
            this.btnSaveService.Location = new System.Drawing.Point(256, 343);
            this.btnSaveService.Name = "btnSaveService";
            this.btnSaveService.Size = new System.Drawing.Size(153, 49);
            this.btnSaveService.TabIndex = 22;
            this.btnSaveService.Text = "Save";
            this.btnSaveService.UseVisualStyleBackColor = false;
            this.btnSaveService.Click += new System.EventHandler(this.btnSaveService_Click);
            // 
            // txtServiceName
            // 
            this.txtServiceName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtServiceName.Location = new System.Drawing.Point(256, 168);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.PlaceholderText = "Ex. Refractor Machine";
            this.txtServiceName.Size = new System.Drawing.Size(582, 38);
            this.txtServiceName.TabIndex = 21;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(52, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(198, 41);
            this.label16.TabIndex = 20;
            this.label16.Text = "Service Name";
            // 
            // frmAddAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 604);
            this.Controls.Add(this.tabControlCreateNew);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAccessories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddAccessories";
            this.Load += new System.EventHandler(this.frmAddAccessories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAccessories)).EndInit();
            this.tabControlCreateNew.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelType.ResumeLayout(false);
            this.panelType.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panelItem.ResumeLayout(false);
            this.panelItem.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panelService.ResumeLayout(false);
            this.panelService.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Label label1;
        private PictureBox btnCloseAccessories;
        private Panel panel2;
        public TabControl tabControlCreateNew;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label5;
        private Label label8;
        private Label label2;
        public ComboBox comBoxClassification;
        public TextBox txtPrice;
        public TextBox txtProduct;
        public Button btnSaveItem;
        public TextBox txtTypeID;
        public Button btnUpdateItem;
        private Label label7;
        private Button btnCancelItem;
        private Label label6;
        private Label label3;
        public TextBox txtID;
        public TextBox txtDescription;
        public ComboBox comBoxType;
        private Label label4;
        public TextBox txtProductIDType;
        private Label label9;
        public ComboBox comBoxProductType;
        public TextBox txtTypID;
        private Label label10;
        public TextBox txtType;
        private Label label11;
        private Button btnCancelType;
        public Button btnUpdateType;
        public Button btnSaveType;
        private Label label12;
        public TextBox txtProdID;
        private Label label17;
        private Button btnCancelProduct;
        public Button btnUpdateProduct;
        public Button btnSaveProduct;
        public TextBox txtProdName;
        private Label label18;
        public Panel panelProduct;
        public Panel panelType;
        public Panel panelItem;
        private TabPage tabPage4;
        public TextBox txtServiceID;
        private Label label13;
        public TextBox txtServicePrice;
        private Label label14;
        public TextBox txtServiceDesc;
        private Label label15;
        private Button btnCloseService;
        public Button btnUpdateService;
        public Button btnSaveService;
        public TextBox txtServiceName;
        private Label label16;
        public Panel panelService;
    }
}