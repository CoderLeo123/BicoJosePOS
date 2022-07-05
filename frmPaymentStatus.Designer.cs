namespace Capstone
{
    partial class frmPaymentStatus
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumSettled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransRefNoSettled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustNameSettled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPaymentSettled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialDepSettled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettledAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SettledDatePaymentStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompletedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSearchSettled = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewPaymentStat = new System.Windows.Forms.DataGridView();
            this.NumPendingSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransRefNoPendingSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNamePendingSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearchPending = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TRREFNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUSTOMERNAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentStat)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 642);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1315, 400);
            this.panel4.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumSettled,
            this.TransRefNoSettled,
            this.CustNameSettled,
            this.TotalPaymentSettled,
            this.InitialDepSettled,
            this.SettledAmount,
            this.SettledDatePaymentStat,
            this.CompletedBy});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1315, 400);
            this.dataGridView1.TabIndex = 5;
            // 
            // NumSettled
            // 
            this.NumSettled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumSettled.HeaderText = "#";
            this.NumSettled.MinimumWidth = 6;
            this.NumSettled.Name = "NumSettled";
            this.NumSettled.Width = 50;
            // 
            // TransRefNoSettled
            // 
            this.TransRefNoSettled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TransRefNoSettled.HeaderText = "TRANS REF. NO.";
            this.TransRefNoSettled.MinimumWidth = 6;
            this.TransRefNoSettled.Name = "TransRefNoSettled";
            this.TransRefNoSettled.Width = 176;
            // 
            // CustNameSettled
            // 
            this.CustNameSettled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustNameSettled.HeaderText = "CUSTOMER NAME";
            this.CustNameSettled.MinimumWidth = 6;
            this.CustNameSettled.Name = "CustNameSettled";
            // 
            // TotalPaymentSettled
            // 
            this.TotalPaymentSettled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalPaymentSettled.HeaderText = "TOTAL PAYMENT";
            this.TotalPaymentSettled.MinimumWidth = 6;
            this.TotalPaymentSettled.Name = "TotalPaymentSettled";
            this.TotalPaymentSettled.Width = 184;
            // 
            // InitialDepSettled
            // 
            this.InitialDepSettled.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.InitialDepSettled.HeaderText = "INITIAL DEPOSIT";
            this.InitialDepSettled.MinimumWidth = 6;
            this.InitialDepSettled.Name = "InitialDepSettled";
            this.InitialDepSettled.Width = 184;
            // 
            // SettledAmount
            // 
            this.SettledAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SettledAmount.HeaderText = "SETTLED AMOUNT";
            this.SettledAmount.MinimumWidth = 6;
            this.SettledAmount.Name = "SettledAmount";
            this.SettledAmount.Width = 200;
            // 
            // SettledDatePaymentStat
            // 
            this.SettledDatePaymentStat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SettledDatePaymentStat.HeaderText = "SETTLED DATE";
            this.SettledDatePaymentStat.MinimumWidth = 6;
            this.SettledDatePaymentStat.Name = "SettledDatePaymentStat";
            this.SettledDatePaymentStat.Width = 164;
            // 
            // CompletedBy
            // 
            this.CompletedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CompletedBy.HeaderText = "COMPLETED BY";
            this.CompletedBy.MinimumWidth = 6;
            this.CompletedBy.Name = "CompletedBy";
            this.CompletedBy.Width = 173;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Completely Settled";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightBlue;
            this.panel3.Controls.Add(this.dateTimePicker2);
            this.panel3.Controls.Add(this.dateTimePicker1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1315, 111);
            this.panel3.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(461, 66);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(158, 34);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(297, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 34);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(26, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 31);
            this.label3.TabIndex = 28;
            this.label3.Text = "Filter By Date (From - To)";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtSearchSettled);
            this.panel6.Location = new System.Drawing.Point(637, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(631, 57);
            this.panel6.TabIndex = 6;
            // 
            // txtSearchSettled
            // 
            this.txtSearchSettled.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchSettled.Location = new System.Drawing.Point(19, 9);
            this.txtSearchSettled.Name = "txtSearchSettled";
            this.txtSearchSettled.PlaceholderText = "Search Here";
            this.txtSearchSettled.Size = new System.Drawing.Size(592, 38);
            this.txtSearchSettled.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pending Settlement";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(1260, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(3);
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewPaymentStat);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 531);
            this.panel2.TabIndex = 7;
            // 
            // dataGridViewPaymentStat
            // 
            this.dataGridViewPaymentStat.AllowUserToResizeColumns = false;
            this.dataGridViewPaymentStat.AllowUserToResizeRows = false;
            this.dataGridViewPaymentStat.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPaymentStat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPaymentStat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPaymentStat.ColumnHeadersHeight = 40;
            this.dataGridViewPaymentStat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPaymentStat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumPendingSet,
            this.TransRefNoPendingSet,
            this.CustomerNamePendingSet,
            this.TotalPayment,
            this.InitialDeposit,
            this.RemBalance,
            this.DueDate,
            this.Cashier});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPaymentStat.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewPaymentStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPaymentStat.EnableHeadersVisualStyles = false;
            this.dataGridViewPaymentStat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewPaymentStat.Location = new System.Drawing.Point(0, 105);
            this.dataGridViewPaymentStat.Name = "dataGridViewPaymentStat";
            this.dataGridViewPaymentStat.RowHeadersVisible = false;
            this.dataGridViewPaymentStat.RowHeadersWidth = 51;
            this.dataGridViewPaymentStat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPaymentStat.RowTemplate.Height = 29;
            this.dataGridViewPaymentStat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPaymentStat.Size = new System.Drawing.Size(1315, 426);
            this.dataGridViewPaymentStat.TabIndex = 4;
            // 
            // NumPendingSet
            // 
            this.NumPendingSet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumPendingSet.HeaderText = "#";
            this.NumPendingSet.MinimumWidth = 6;
            this.NumPendingSet.Name = "NumPendingSet";
            this.NumPendingSet.Width = 50;
            // 
            // TransRefNoPendingSet
            // 
            this.TransRefNoPendingSet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TransRefNoPendingSet.HeaderText = "TRANS REF.NO.";
            this.TransRefNoPendingSet.MinimumWidth = 6;
            this.TransRefNoPendingSet.Name = "TransRefNoPendingSet";
            this.TransRefNoPendingSet.Width = 171;
            // 
            // CustomerNamePendingSet
            // 
            this.CustomerNamePendingSet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerNamePendingSet.HeaderText = "CUSTOMER NAME";
            this.CustomerNamePendingSet.MinimumWidth = 6;
            this.CustomerNamePendingSet.Name = "CustomerNamePendingSet";
            // 
            // TotalPayment
            // 
            this.TotalPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalPayment.HeaderText = "TOTAL PAYMENT";
            this.TotalPayment.MinimumWidth = 6;
            this.TotalPayment.Name = "TotalPayment";
            this.TotalPayment.Width = 184;
            // 
            // InitialDeposit
            // 
            this.InitialDeposit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.InitialDeposit.HeaderText = "INITIAL DEPOSIT";
            this.InitialDeposit.MinimumWidth = 6;
            this.InitialDeposit.Name = "InitialDeposit";
            this.InitialDeposit.Width = 184;
            // 
            // RemBalance
            // 
            this.RemBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RemBalance.HeaderText = "REM. BALANCE";
            this.RemBalance.MinimumWidth = 6;
            this.RemBalance.Name = "RemBalance";
            this.RemBalance.Width = 170;
            // 
            // DueDate
            // 
            this.DueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DueDate.HeaderText = "DUE DATE";
            this.DueDate.MinimumWidth = 6;
            this.DueDate.Name = "DueDate";
            this.DueDate.Width = 126;
            // 
            // Cashier
            // 
            this.Cashier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cashier.HeaderText = "CASHIER";
            this.Cashier.MinimumWidth = 6;
            this.Cashier.Name = "Cashier";
            this.Cashier.Width = 115;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.dateTimePicker3);
            this.panel1.Controls.Add(this.dateTimePicker4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 105);
            this.panel1.TabIndex = 2;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(461, 56);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(158, 34);
            this.dateTimePicker3.TabIndex = 34;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(297, 56);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(158, 34);
            this.dateTimePicker4.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(26, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "Filter By Date (From - To)";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtSearchPending);
            this.panel5.Location = new System.Drawing.Point(637, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(631, 57);
            this.panel5.TabIndex = 31;
            // 
            // txtSearchPending
            // 
            this.txtSearchPending.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchPending.Location = new System.Drawing.Point(19, 9);
            this.txtSearchPending.Name = "txtSearchPending";
            this.txtSearchPending.PlaceholderText = "Search Here";
            this.txtSearchPending.Size = new System.Drawing.Size(592, 38);
            this.txtSearchPending.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "#";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // TRREFNO
            // 
            this.TRREFNO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TRREFNO.HeaderText = "TR REF.NO";
            this.TRREFNO.MinimumWidth = 6;
            this.TRREFNO.Name = "TRREFNO";
            this.TRREFNO.Width = 125;
            // 
            // CUSTOMERNAME
            // 
            this.CUSTOMERNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CUSTOMERNAME.HeaderText = "CUSTOMER NAME";
            this.CUSTOMERNAME.MinimumWidth = 6;
            this.CUSTOMERNAME.Name = "CUSTOMERNAME";
            this.CUSTOMERNAME.Width = 125;
            // 
            // frmPaymentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 930);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPaymentStatus";
            this.Text = "frmPaymentStatus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentStat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel4;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private PictureBox btnClose;
        private Panel panel2;
        private Panel panel1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn TRREFNO;
        private DataGridViewTextBoxColumn CUSTOMERNAME;
        private DataGridView dataGridViewPaymentStat;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NumPendingSet;
        private DataGridViewTextBoxColumn TransRefNoPendingSet;
        private DataGridViewTextBoxColumn CustomerNamePendingSet;
        private DataGridViewTextBoxColumn TotalPayment;
        private DataGridViewTextBoxColumn InitialDeposit;
        private DataGridViewTextBoxColumn RemBalance;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn Cashier;
        private Panel panel6;
        private TextBox txtSearchSettled;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DateTimePicker dateTimePicker3;
        private DateTimePicker dateTimePicker4;
        private Label label4;
        private Panel panel5;
        private TextBox txtSearchPending;
        private DataGridViewTextBoxColumn NumSettled;
        private DataGridViewTextBoxColumn TransRefNoSettled;
        private DataGridViewTextBoxColumn CustNameSettled;
        private DataGridViewTextBoxColumn TotalPaymentSettled;
        private DataGridViewTextBoxColumn InitialDepSettled;
        private DataGridViewTextBoxColumn SettledAmount;
        private DataGridViewTextBoxColumn SettledDatePaymentStat;
        private DataGridViewTextBoxColumn CompletedBy;
    }
}