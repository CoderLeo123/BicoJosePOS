namespace Capstone
{
    partial class frmDailySales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCloseDailySales = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchTransac = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartTrans = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerEndTrans = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewTransacHist = new System.Windows.Forms.DataGridView();
            this.NumDailySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCodeDailySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDailySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionDailySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelDailySales = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelTransacHist = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelSoldItems = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridViewSoldItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtSearchSold = new System.Windows.Forms.TextBox();
            this.dateTimePickerStartSold = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerEndSold = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseDailySales)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransacHist)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelTransacHist.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelSoldItems.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoldItems)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1301, 120);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCloseDailySales);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1240, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(61, 66);
            this.panel3.TabIndex = 37;
            // 
            // btnCloseDailySales
            // 
            this.btnCloseDailySales.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseDailySales.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnCloseDailySales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseDailySales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseDailySales.Location = new System.Drawing.Point(9, 9);
            this.btnCloseDailySales.Name = "btnCloseDailySales";
            this.btnCloseDailySales.Padding = new System.Windows.Forms.Padding(3);
            this.btnCloseDailySales.Size = new System.Drawing.Size(40, 38);
            this.btnCloseDailySales.TabIndex = 0;
            this.btnCloseDailySales.TabStop = false;
            this.btnCloseDailySales.Click += new System.EventHandler(this.btnCloseDailySales_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.txtSearchTransac);
            this.panel2.Controls.Add(this.dateTimePickerStartTrans);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePickerEndTrans);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1301, 54);
            this.panel2.TabIndex = 36;
            // 
            // txtSearchTransac
            // 
            this.txtSearchTransac.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchTransac.Location = new System.Drawing.Point(685, 10);
            this.txtSearchTransac.Name = "txtSearchTransac";
            this.txtSearchTransac.PlaceholderText = "Search Here";
            this.txtSearchTransac.Size = new System.Drawing.Size(570, 38);
            this.txtSearchTransac.TabIndex = 0;
            // 
            // dateTimePickerStartTrans
            // 
            this.dateTimePickerStartTrans.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerStartTrans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerStartTrans.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartTrans.Location = new System.Drawing.Point(313, 9);
            this.dateTimePickerStartTrans.Name = "dateTimePickerStartTrans";
            this.dateTimePickerStartTrans.Size = new System.Drawing.Size(158, 34);
            this.dateTimePickerStartTrans.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 31);
            this.label2.TabIndex = 32;
            this.label2.Text = "Filter By Date (From - To)";
            // 
            // dateTimePickerEndTrans
            // 
            this.dateTimePickerEndTrans.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerEndTrans.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerEndTrans.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndTrans.Location = new System.Drawing.Point(486, 9);
            this.dateTimePickerEndTrans.Name = "dateTimePickerEndTrans";
            this.dateTimePickerEndTrans.Size = new System.Drawing.Size(158, 34);
            this.dateTimePickerEndTrans.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transactions List";
            // 
            // dataGridViewTransacHist
            // 
            this.dataGridViewTransacHist.AllowUserToResizeColumns = false;
            this.dataGridViewTransacHist.AllowUserToResizeRows = false;
            this.dataGridViewTransacHist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTransacHist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTransacHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTransacHist.ColumnHeadersHeight = 40;
            this.dataGridViewTransacHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTransacHist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumDailySales,
            this.PCodeDailySales,
            this.InvoiceDailySales,
            this.Customer,
            this.DescriptionDailySales,
            this.Date,
            this.CancelDailySales});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTransacHist.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTransacHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransacHist.EnableHeadersVisualStyles = false;
            this.dataGridViewTransacHist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewTransacHist.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTransacHist.Name = "dataGridViewTransacHist";
            this.dataGridViewTransacHist.RowHeadersVisible = false;
            this.dataGridViewTransacHist.RowHeadersWidth = 51;
            this.dataGridViewTransacHist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTransacHist.RowTemplate.Height = 29;
            this.dataGridViewTransacHist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransacHist.Size = new System.Drawing.Size(1301, 754);
            this.dataGridViewTransacHist.TabIndex = 8;
            this.dataGridViewTransacHist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTransacHist_CellContentClick);
            // 
            // NumDailySales
            // 
            this.NumDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumDailySales.HeaderText = "#";
            this.NumDailySales.MinimumWidth = 6;
            this.NumDailySales.Name = "NumDailySales";
            this.NumDailySales.Width = 61;
            // 
            // PCodeDailySales
            // 
            this.PCodeDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PCodeDailySales.HeaderText = "CardID";
            this.PCodeDailySales.MinimumWidth = 6;
            this.PCodeDailySales.Name = "PCodeDailySales";
            this.PCodeDailySales.Visible = false;
            this.PCodeDailySales.Width = 125;
            // 
            // InvoiceDailySales
            // 
            this.InvoiceDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.InvoiceDailySales.HeaderText = "INVOICE NO.";
            this.InvoiceDailySales.MinimumWidth = 6;
            this.InvoiceDailySales.Name = "InvoiceDailySales";
            this.InvoiceDailySales.Width = 203;
            // 
            // Customer
            // 
            this.Customer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Customer.HeaderText = "CUSTOMER";
            this.Customer.MinimumWidth = 6;
            this.Customer.Name = "Customer";
            // 
            // DescriptionDailySales
            // 
            this.DescriptionDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionDailySales.HeaderText = "CASHIER";
            this.DescriptionDailySales.MinimumWidth = 6;
            this.DescriptionDailySales.Name = "DescriptionDailySales";
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Date.HeaderText = "DATE";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 108;
            // 
            // CancelDailySales
            // 
            this.CancelDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CancelDailySales.HeaderText = "";
            this.CancelDailySales.MinimumWidth = 6;
            this.CancelDailySales.Name = "CancelDailySales";
            this.CancelDailySales.Width = 24;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1315, 930);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelTransacHist);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1307, 880);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Transaction History";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelTransacHist
            // 
            this.panelTransacHist.Controls.Add(this.panel5);
            this.panelTransacHist.Controls.Add(this.panel4);
            this.panelTransacHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTransacHist.Location = new System.Drawing.Point(3, 3);
            this.panelTransacHist.Name = "panelTransacHist";
            this.panelTransacHist.Size = new System.Drawing.Size(1301, 874);
            this.panelTransacHist.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dataGridViewTransacHist);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 120);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1301, 754);
            this.panel5.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1301, 120);
            this.panel4.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelSoldItems);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1307, 880);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sold Items";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelSoldItems
            // 
            this.panelSoldItems.Controls.Add(this.panel7);
            this.panelSoldItems.Controls.Add(this.panel6);
            this.panelSoldItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSoldItems.Location = new System.Drawing.Point(3, 3);
            this.panelSoldItems.Name = "panelSoldItems";
            this.panelSoldItems.Size = new System.Drawing.Size(1301, 874);
            this.panelSoldItems.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridViewSoldItems);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 119);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1301, 755);
            this.panel7.TabIndex = 1;
            // 
            // dataGridViewSoldItems
            // 
            this.dataGridViewSoldItems.AllowUserToResizeColumns = false;
            this.dataGridViewSoldItems.AllowUserToResizeRows = false;
            this.dataGridViewSoldItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSoldItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSoldItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSoldItems.ColumnHeadersHeight = 40;
            this.dataGridViewSoldItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSoldItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.ExpDate,
            this.Price,
            this.Qty,
            this.Total,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSoldItems.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSoldItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSoldItems.EnableHeadersVisualStyles = false;
            this.dataGridViewSoldItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewSoldItems.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSoldItems.Name = "dataGridViewSoldItems";
            this.dataGridViewSoldItems.RowHeadersVisible = false;
            this.dataGridViewSoldItems.RowHeadersWidth = 51;
            this.dataGridViewSoldItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSoldItems.RowTemplate.Height = 29;
            this.dataGridViewSoldItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSoldItems.Size = new System.Drawing.Size(1301, 755);
            this.dataGridViewSoldItems.TabIndex = 9;
            this.dataGridViewSoldItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSoldItems_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 61;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "CardID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "INVOICE NO.";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 203;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "DESCRIPTION";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // ExpDate
            // 
            this.ExpDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ExpDate.HeaderText = "EXPIRATION";
            this.ExpDate.MinimumWidth = 6;
            this.ExpDate.Name = "ExpDate";
            this.ExpDate.Width = 195;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Price.HeaderText = "PRICE";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 115;
            // 
            // Qty
            // 
            this.Qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Qty.HeaderText = "QTY";
            this.Qty.MinimumWidth = 6;
            this.Qty.Name = "Qty";
            this.Qty.Width = 95;
            // 
            // Total
            // 
            this.Total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Total.HeaderText = "TOTAL";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 122;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 108;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 24;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1301, 119);
            this.panel6.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1301, 119);
            this.panel8.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.pictureBox1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(1240, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(61, 65);
            this.panel9.TabIndex = 37;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(9, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.DimGray;
            this.panel10.Controls.Add(this.txtSearchSold);
            this.panel10.Controls.Add(this.dateTimePickerStartSold);
            this.panel10.Controls.Add(this.label3);
            this.panel10.Controls.Add(this.dateTimePickerEndSold);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 65);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1301, 54);
            this.panel10.TabIndex = 36;
            // 
            // txtSearchSold
            // 
            this.txtSearchSold.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchSold.Location = new System.Drawing.Point(685, 10);
            this.txtSearchSold.Name = "txtSearchSold";
            this.txtSearchSold.PlaceholderText = "Search Here";
            this.txtSearchSold.Size = new System.Drawing.Size(570, 38);
            this.txtSearchSold.TabIndex = 0;
            // 
            // dateTimePickerStartSold
            // 
            this.dateTimePickerStartSold.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerStartSold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerStartSold.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStartSold.Location = new System.Drawing.Point(313, 9);
            this.dateTimePickerStartSold.Name = "dateTimePickerStartSold";
            this.dateTimePickerStartSold.Size = new System.Drawing.Size(158, 34);
            this.dateTimePickerStartSold.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(277, 31);
            this.label3.TabIndex = 32;
            this.label3.Text = "Filter By Date (From - To)";
            // 
            // dateTimePickerEndSold
            // 
            this.dateTimePickerEndSold.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerEndSold.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerEndSold.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEndSold.Location = new System.Drawing.Point(486, 9);
            this.dateTimePickerEndSold.Name = "dateTimePickerEndSold";
            this.dateTimePickerEndSold.Size = new System.Drawing.Size(158, 34);
            this.dateTimePickerEndSold.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 41);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sold Items ";
            // 
            // frmDailySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 930);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDailySales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDailySales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseDailySales)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransacHist)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelTransacHist.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelSoldItems.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSoldItems)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private PictureBox btnCloseDailySales;
        private Panel panel3;
        public TabControl tabControl1;
        private TabPage tabPage1;
        public Panel panelTransacHist;
        private Panel panel5;
        private Panel panel4;
        private TabPage tabPage2;
        public Panel panelSoldItems;
        private Panel panel7;
        public DataGridView dataGridViewSoldItems;
        private Panel panel6;
        private Panel panel8;
        private Panel panel9;
        private PictureBox pictureBox1;
        private Panel panel10;
        private Label label3;
        private Label label4;
        public DataGridView dataGridViewTransacHist;
        private DataGridViewTextBoxColumn NumDailySales;
        private DataGridViewTextBoxColumn PCodeDailySales;
        private DataGridViewTextBoxColumn InvoiceDailySales;
        private DataGridViewTextBoxColumn Customer;
        private DataGridViewTextBoxColumn DescriptionDailySales;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewImageColumn CancelDailySales;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn ExpDate;
        private DataGridViewTextBoxColumn Price;
        private DataGridViewTextBoxColumn Qty;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewImageColumn dataGridViewImageColumn1;
        public TextBox txtSearchTransac;
        public TextBox txtSearchSold;
        public DateTimePicker dateTimePickerStartTrans;
        public DateTimePicker dateTimePickerStartSold;
        public DateTimePicker dateTimePickerEndTrans;
        public DateTimePicker dateTimePickerEndSold;
    }
}