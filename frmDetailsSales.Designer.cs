namespace Capstone
{
    partial class frmDetailsSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelSoldDetails = new System.Windows.Forms.Panel();
            this.lblPTerms = new System.Windows.Forms.Label();
            this.lblPMode = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblChange = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelTransDetails = new System.Windows.Forms.Panel();
            this.lblChangeTrans = new System.Windows.Forms.Label();
            this.lblPaymentTrans = new System.Windows.Forms.Label();
            this.lblTotalTrans = new System.Windows.Forms.Label();
            this.lblCashier = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelBrowseService = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblItemIDCheck = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblCheck = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTrans = new System.Windows.Forms.Label();
            this.lblTransNo = new System.Windows.Forms.Label();
            this.txtSearchService = new System.Windows.Forms.TextBox();
            this.NumService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.add = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelSoldDetails.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelTransDetails.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panelBrowseService.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(685, 415);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelSoldDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(677, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sold Items";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelSoldDetails
            // 
            this.panelSoldDetails.Controls.Add(this.lblPTerms);
            this.panelSoldDetails.Controls.Add(this.lblPMode);
            this.panelSoldDetails.Controls.Add(this.label15);
            this.panelSoldDetails.Controls.Add(this.label16);
            this.panelSoldDetails.Controls.Add(this.lblChange);
            this.panelSoldDetails.Controls.Add(this.lblPayment);
            this.panelSoldDetails.Controls.Add(this.lblTotal);
            this.panelSoldDetails.Controls.Add(this.lblDiscount);
            this.panelSoldDetails.Controls.Add(this.lblQty);
            this.panelSoldDetails.Controls.Add(this.lblPrice);
            this.panelSoldDetails.Controls.Add(this.label5);
            this.panelSoldDetails.Controls.Add(this.label6);
            this.panelSoldDetails.Controls.Add(this.label3);
            this.panelSoldDetails.Controls.Add(this.label4);
            this.panelSoldDetails.Controls.Add(this.label2);
            this.panelSoldDetails.Controls.Add(this.label1);
            this.panelSoldDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSoldDetails.Location = new System.Drawing.Point(3, 3);
            this.panelSoldDetails.Name = "panelSoldDetails";
            this.panelSoldDetails.Size = new System.Drawing.Size(671, 359);
            this.panelSoldDetails.TabIndex = 0;
            // 
            // lblPTerms
            // 
            this.lblPTerms.AutoSize = true;
            this.lblPTerms.ForeColor = System.Drawing.Color.Red;
            this.lblPTerms.Location = new System.Drawing.Point(466, 191);
            this.lblPTerms.Name = "lblPTerms";
            this.lblPTerms.Size = new System.Drawing.Size(55, 38);
            this.lblPTerms.TabIndex = 15;
            this.lblPTerms.Text = ".    ";
            // 
            // lblPMode
            // 
            this.lblPMode.AutoSize = true;
            this.lblPMode.ForeColor = System.Drawing.Color.Red;
            this.lblPMode.Location = new System.Drawing.Point(466, 82);
            this.lblPMode.Name = "lblPMode";
            this.lblPMode.Size = new System.Drawing.Size(55, 38);
            this.lblPMode.TabIndex = 14;
            this.lblPMode.Text = ".    ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(404, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(205, 38);
            this.label15.TabIndex = 13;
            this.label15.Text = "Payment Terms";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(404, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(262, 38);
            this.label16.TabIndex = 12;
            this.label16.Text = "Method of Payment";
            // 
            // lblChange
            // 
            this.lblChange.AutoSize = true;
            this.lblChange.ForeColor = System.Drawing.Color.Red;
            this.lblChange.Location = new System.Drawing.Point(218, 292);
            this.lblChange.Name = "lblChange";
            this.lblChange.Size = new System.Drawing.Size(55, 38);
            this.lblChange.TabIndex = 11;
            this.lblChange.Text = ".    ";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.ForeColor = System.Drawing.Color.Red;
            this.lblPayment.Location = new System.Drawing.Point(218, 239);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(55, 38);
            this.lblPayment.TabIndex = 10;
            this.lblPayment.Text = ".    ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(218, 191);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(55, 38);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = ".    ";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.ForeColor = System.Drawing.Color.Red;
            this.lblDiscount.Location = new System.Drawing.Point(218, 138);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(55, 38);
            this.lblDiscount.TabIndex = 8;
            this.lblDiscount.Text = ".    ";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.ForeColor = System.Drawing.Color.Red;
            this.lblQty.Location = new System.Drawing.Point(218, 82);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(55, 38);
            this.lblQty.TabIndex = 7;
            this.lblQty.Text = ".    ";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Red;
            this.lblPrice.Location = new System.Drawing.Point(218, 29);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(55, 38);
            this.lblPrice.TabIndex = 6;
            this.lblPrice.Text = ".    ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 38);
            this.label5.TabIndex = 5;
            this.label5.Text = "Change";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Discount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelTransDetails);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(677, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transac Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelTransDetails
            // 
            this.panelTransDetails.Controls.Add(this.lblChangeTrans);
            this.panelTransDetails.Controls.Add(this.lblPaymentTrans);
            this.panelTransDetails.Controls.Add(this.lblTotalTrans);
            this.panelTransDetails.Controls.Add(this.lblCashier);
            this.panelTransDetails.Controls.Add(this.lblCustomer);
            this.panelTransDetails.Controls.Add(this.label13);
            this.panelTransDetails.Controls.Add(this.label14);
            this.panelTransDetails.Controls.Add(this.label17);
            this.panelTransDetails.Controls.Add(this.label19);
            this.panelTransDetails.Controls.Add(this.label20);
            this.panelTransDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTransDetails.Location = new System.Drawing.Point(3, 3);
            this.panelTransDetails.Name = "panelTransDetails";
            this.panelTransDetails.Size = new System.Drawing.Size(671, 359);
            this.panelTransDetails.TabIndex = 0;
            // 
            // lblChangeTrans
            // 
            this.lblChangeTrans.AutoSize = true;
            this.lblChangeTrans.ForeColor = System.Drawing.Color.Red;
            this.lblChangeTrans.Location = new System.Drawing.Point(242, 291);
            this.lblChangeTrans.Name = "lblChangeTrans";
            this.lblChangeTrans.Size = new System.Drawing.Size(55, 38);
            this.lblChangeTrans.TabIndex = 23;
            this.lblChangeTrans.Text = ".    ";
            // 
            // lblPaymentTrans
            // 
            this.lblPaymentTrans.AutoSize = true;
            this.lblPaymentTrans.ForeColor = System.Drawing.Color.Red;
            this.lblPaymentTrans.Location = new System.Drawing.Point(242, 238);
            this.lblPaymentTrans.Name = "lblPaymentTrans";
            this.lblPaymentTrans.Size = new System.Drawing.Size(55, 38);
            this.lblPaymentTrans.TabIndex = 22;
            this.lblPaymentTrans.Text = ".    ";
            // 
            // lblTotalTrans
            // 
            this.lblTotalTrans.AutoSize = true;
            this.lblTotalTrans.ForeColor = System.Drawing.Color.Red;
            this.lblTotalTrans.Location = new System.Drawing.Point(242, 190);
            this.lblTotalTrans.Name = "lblTotalTrans";
            this.lblTotalTrans.Size = new System.Drawing.Size(55, 38);
            this.lblTotalTrans.TabIndex = 21;
            this.lblTotalTrans.Text = ".    ";
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.ForeColor = System.Drawing.Color.Red;
            this.lblCashier.Location = new System.Drawing.Point(242, 81);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(55, 38);
            this.lblCashier.TabIndex = 19;
            this.lblCashier.Text = ".    ";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.ForeColor = System.Drawing.Color.Red;
            this.lblCustomer.Location = new System.Drawing.Point(242, 28);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(55, 38);
            this.lblCustomer.TabIndex = 18;
            this.lblCustomer.Text = ".    ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(61, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 38);
            this.label13.TabIndex = 17;
            this.label13.Text = "Change";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(61, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 38);
            this.label14.TabIndex = 16;
            this.label14.Text = "Payment";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(61, 190);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 38);
            this.label17.TabIndex = 15;
            this.label17.Text = "Total";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(61, 81);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(108, 38);
            this.label19.TabIndex = 13;
            this.label19.Text = "Cashier";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(61, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 38);
            this.label20.TabIndex = 12;
            this.label20.Text = "Customer";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 63);
            this.panel1.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnClose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(624, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(61, 63);
            this.panel6.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(3);
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(685, 63);
            this.panel2.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tabControl1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 415);
            this.panel3.TabIndex = 36;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelBrowseService);
            this.tabPage3.Location = new System.Drawing.Point(4, 46);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(677, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "BrowseService";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelBrowseService
            // 
            this.panelBrowseService.Controls.Add(this.panel5);
            this.panelBrowseService.Controls.Add(this.panel4);
            this.panelBrowseService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBrowseService.Location = new System.Drawing.Point(0, 0);
            this.panelBrowseService.Name = "panelBrowseService";
            this.panelBrowseService.Size = new System.Drawing.Size(677, 365);
            this.panelBrowseService.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(677, 56);
            this.panel4.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridViewService);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 56);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(677, 309);
            this.panel5.TabIndex = 1;
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToAddRows = false;
            this.dataGridViewService.AllowUserToResizeColumns = false;
            this.dataGridViewService.AllowUserToResizeRows = false;
            this.dataGridViewService.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewService.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewService.ColumnHeadersHeight = 40;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewService.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumService,
            this.Name,
            this.Desc,
            this.Price,
            this.add,
            this.ID});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewService.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.dataGridViewService.Size = new System.Drawing.Size(677, 309);
            this.dataGridViewService.TabIndex = 7;
            this.dataGridViewService.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewService_CellContentClick);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Controls.Add(this.lblItemIDCheck);
            this.panel7.Controls.Add(this.lblStock);
            this.panel7.Controls.Add(this.lblCheck);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.lblTrans);
            this.panel7.Controls.Add(this.lblTransNo);
            this.panel7.Controls.Add(this.txtSearchService);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(677, 54);
            this.panel7.TabIndex = 37;
            // 
            // lblItemIDCheck
            // 
            this.lblItemIDCheck.AutoSize = true;
            this.lblItemIDCheck.Location = new System.Drawing.Point(795, 18);
            this.lblItemIDCheck.Name = "lblItemIDCheck";
            this.lblItemIDCheck.Size = new System.Drawing.Size(65, 38);
            this.lblItemIDCheck.TabIndex = 10;
            this.lblItemIDCheck.Text = "      ";
            this.lblItemIDCheck.Visible = false;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(679, 15);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(65, 38);
            this.lblStock.TabIndex = 9;
            this.lblStock.Text = "      ";
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(991, 15);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(89, 38);
            this.lblCheck.TabIndex = 4;
            this.lblCheck.Text = "         ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1153, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 38);
            this.label7.TabIndex = 3;
            this.label7.Text = "label7";
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Location = new System.Drawing.Point(1188, 20);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(65, 38);
            this.lblTrans.TabIndex = 2;
            this.lblTrans.Text = "      ";
            this.lblTrans.Visible = false;
            // 
            // lblTransNo
            // 
            this.lblTransNo.AutoSize = true;
            this.lblTransNo.Location = new System.Drawing.Point(1162, 15);
            this.lblTransNo.Name = "lblTransNo";
            this.lblTransNo.Size = new System.Drawing.Size(0, 38);
            this.lblTransNo.TabIndex = 1;
            // 
            // txtSearchService
            // 
            this.txtSearchService.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchService.Location = new System.Drawing.Point(23, 10);
            this.txtSearchService.Name = "txtSearchService";
            this.txtSearchService.PlaceholderText = "Search Here";
            this.txtSearchService.Size = new System.Drawing.Size(619, 38);
            this.txtSearchService.TabIndex = 0;
            // 
            // NumService
            // 
            this.NumService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumService.HeaderText = "#";
            this.NumService.MinimumWidth = 6;
            this.NumService.Name = "NumService";
            this.NumService.ReadOnly = true;
            this.NumService.Width = 61;
            // 
            // Name
            // 
            this.Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Name.HeaderText = "NAME";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc.HeaderText = "DESCRIPTION";
            this.Desc.MinimumWidth = 6;
            this.Desc.Name = "Desc";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Price.HeaderText = "PRICE";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 115;
            // 
            // add
            // 
            this.add.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.add.HeaderText = "";
            this.add.MinimumWidth = 6;
            this.add.Name = "add";
            this.add.Width = 6;
            // 
            // ID
            // 
            this.ID.HeaderText = "ServiceID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // frmDetailsSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 478);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDetailsSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDetailsSales";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelSoldDetails.ResumeLayout(false);
            this.panelSoldDetails.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelTransDetails.ResumeLayout(false);
            this.panelTransDetails.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panelBrowseService.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public TabControl tabControl1;
        private TabPage tabPage1;
        public Panel panelSoldDetails;
        private TabPage tabPage2;
        public Panel panelTransDetails;
        private Label label15;
        private Label label16;
        private Label label5;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label13;
        private Label label14;
        private Label label17;
        private Label label19;
        private Label label20;
        private Panel panel1;
        private Panel panel6;
        private PictureBox btnClose;
        private Panel panel2;
        private Panel panel3;
        public Label lblPTerms;
        public Label lblPMode;
        public Label lblChange;
        public Label lblPayment;
        public Label lblTotal;
        public Label lblDiscount;
        public Label lblQty;
        public Label lblPrice;
        public Label lblChangeTrans;
        public Label lblPaymentTrans;
        public Label lblTotalTrans;
        public Label lblCashier;
        public Label lblCustomer;
        private TabPage tabPage3;
        public Panel panelBrowseService;
        private Panel panel5;
        private Panel panel4;
        public DataGridView dataGridViewService;
        private Panel panel7;
        private Label lblItemIDCheck;
        public Label lblStock;
        public Label lblCheck;
        private Label label7;
        public Label lblTrans;
        private Label lblTransNo;
        private DataGridViewTextBoxColumn NumService;
        private DataGridViewTextBoxColumn Name;
        private DataGridViewTextBoxColumn Desc;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewImageColumn add;
        private DataGridViewTextBoxColumn ID;
        public TextBox txtSearchService;
    }
}