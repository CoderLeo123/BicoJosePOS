namespace Capstone
{
    partial class frmEditPaymentOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.tabControlEditPayOrd = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelEditPayment = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewPaymentStat = new System.Windows.Forms.DataGridView();
            this.NumPendingSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransRefNoPendingSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNamePendingSet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPayment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialDeposit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cashier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblCurrentTransN = new System.Windows.Forms.Label();
            this.txtSearchPending = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelEditOrder = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.tabControlEditPayOrd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelEditPayment.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentStat)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelEditOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 57);
            this.panel1.TabIndex = 34;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnClose);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1140, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(61, 57);
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tabControlEditPayOrd
            // 
            this.tabControlEditPayOrd.Controls.Add(this.tabPage1);
            this.tabControlEditPayOrd.Controls.Add(this.tabPage2);
            this.tabControlEditPayOrd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEditPayOrd.Location = new System.Drawing.Point(0, 57);
            this.tabControlEditPayOrd.Name = "tabControlEditPayOrd";
            this.tabControlEditPayOrd.SelectedIndex = 0;
            this.tabControlEditPayOrd.Size = new System.Drawing.Size(1201, 490);
            this.tabControlEditPayOrd.TabIndex = 35;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelEditPayment);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1193, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Payment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelEditPayment
            // 
            this.panelEditPayment.Controls.Add(this.panel3);
            this.panelEditPayment.Controls.Add(this.panel2);
            this.panelEditPayment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditPayment.Location = new System.Drawing.Point(3, 3);
            this.panelEditPayment.Name = "panelEditPayment";
            this.panelEditPayment.Size = new System.Drawing.Size(1187, 434);
            this.panelEditPayment.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewPaymentStat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1187, 364);
            this.panel3.TabIndex = 1;
            // 
            // dataGridViewPaymentStat
            // 
            this.dataGridViewPaymentStat.AllowUserToResizeColumns = false;
            this.dataGridViewPaymentStat.AllowUserToResizeRows = false;
            this.dataGridViewPaymentStat.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewPaymentStat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPaymentStat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.Cashier,
            this.S});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPaymentStat.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPaymentStat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPaymentStat.EnableHeadersVisualStyles = false;
            this.dataGridViewPaymentStat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewPaymentStat.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPaymentStat.Name = "dataGridViewPaymentStat";
            this.dataGridViewPaymentStat.RowHeadersVisible = false;
            this.dataGridViewPaymentStat.RowHeadersWidth = 51;
            this.dataGridViewPaymentStat.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPaymentStat.RowTemplate.Height = 35;
            this.dataGridViewPaymentStat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPaymentStat.Size = new System.Drawing.Size(1187, 364);
            this.dataGridViewPaymentStat.TabIndex = 5;
            this.dataGridViewPaymentStat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPaymentStat_CellContentClick);
            // 
            // NumPendingSet
            // 
            this.NumPendingSet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumPendingSet.HeaderText = "#";
            this.NumPendingSet.MinimumWidth = 6;
            this.NumPendingSet.Name = "NumPendingSet";
            this.NumPendingSet.ReadOnly = true;
            this.NumPendingSet.Width = 61;
            // 
            // TransRefNoPendingSet
            // 
            this.TransRefNoPendingSet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TransRefNoPendingSet.HeaderText = "TRANS NO";
            this.TransRefNoPendingSet.MinimumWidth = 6;
            this.TransRefNoPendingSet.Name = "TransRefNoPendingSet";
            this.TransRefNoPendingSet.ReadOnly = true;
            this.TransRefNoPendingSet.Visible = false;
            this.TransRefNoPendingSet.Width = 125;
            // 
            // CustomerNamePendingSet
            // 
            this.CustomerNamePendingSet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerNamePendingSet.HeaderText = "NAME";
            this.CustomerNamePendingSet.MinimumWidth = 6;
            this.CustomerNamePendingSet.Name = "CustomerNamePendingSet";
            this.CustomerNamePendingSet.ReadOnly = true;
            // 
            // TotalPayment
            // 
            this.TotalPayment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalPayment.HeaderText = "TOTAL";
            this.TotalPayment.MinimumWidth = 6;
            this.TotalPayment.Name = "TotalPayment";
            this.TotalPayment.ReadOnly = true;
            this.TotalPayment.Width = 122;
            // 
            // InitialDeposit
            // 
            this.InitialDeposit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.InitialDeposit.HeaderText = "DEPOSIT";
            this.InitialDeposit.MinimumWidth = 6;
            this.InitialDeposit.Name = "InitialDeposit";
            this.InitialDeposit.ReadOnly = true;
            this.InitialDeposit.Width = 152;
            // 
            // RemBalance
            // 
            this.RemBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RemBalance.HeaderText = "BALANCE";
            this.RemBalance.MinimumWidth = 6;
            this.RemBalance.Name = "RemBalance";
            this.RemBalance.ReadOnly = true;
            this.RemBalance.Width = 162;
            // 
            // DueDate
            // 
            this.DueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DueDate.HeaderText = "DUE DATE";
            this.DueDate.MinimumWidth = 6;
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            this.DueDate.Width = 169;
            // 
            // Cashier
            // 
            this.Cashier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cashier.HeaderText = "CASHIER";
            this.Cashier.MinimumWidth = 6;
            this.Cashier.Name = "Cashier";
            this.Cashier.ReadOnly = true;
            this.Cashier.Width = 152;
            // 
            // S
            // 
            this.S.HeaderText = "STATUS";
            this.S.MinimumWidth = 6;
            this.S.Name = "S";
            this.S.ReadOnly = true;
            this.S.Visible = false;
            this.S.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1187, 70);
            this.panel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DimGray;
            this.panel7.Controls.Add(this.lblCurrentTransN);
            this.panel7.Controls.Add(this.txtSearchPending);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1187, 70);
            this.panel7.TabIndex = 37;
            // 
            // lblCurrentTransN
            // 
            this.lblCurrentTransN.AutoSize = true;
            this.lblCurrentTransN.ForeColor = System.Drawing.Color.Red;
            this.lblCurrentTransN.Location = new System.Drawing.Point(640, 14);
            this.lblCurrentTransN.Name = "lblCurrentTransN";
            this.lblCurrentTransN.Size = new System.Drawing.Size(57, 38);
            this.lblCurrentTransN.TabIndex = 39;
            this.lblCurrentTransN.Text = "     ";
            this.lblCurrentTransN.Visible = false;
            // 
            // txtSearchPending
            // 
            this.txtSearchPending.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchPending.Location = new System.Drawing.Point(35, 16);
            this.txtSearchPending.Name = "txtSearchPending";
            this.txtSearchPending.PlaceholderText = "Search Here";
            this.txtSearchPending.Size = new System.Drawing.Size(573, 38);
            this.txtSearchPending.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelEditOrder);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1193, 457);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelEditOrder
            // 
            this.panelEditOrder.Controls.Add(this.textBox1);
            this.panelEditOrder.Controls.Add(this.monthCalendar1);
            this.panelEditOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEditOrder.Location = new System.Drawing.Point(3, 3);
            this.panelEditOrder.Name = "panelEditOrder";
            this.panelEditOrder.Size = new System.Drawing.Size(1187, 451);
            this.panelEditOrder.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(45, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 43);
            this.textBox1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(45, 94);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // frmEditPaymentOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 547);
            this.Controls.Add(this.tabControlEditPayOrd);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmEditPaymentOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditPaymentOrder";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.tabControlEditPayOrd.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelEditPayment.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPaymentStat)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelEditOrder.ResumeLayout(false);
            this.panelEditOrder.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel6;
        private PictureBox btnClose;
        public TabControl tabControlEditPayOrd;
        private TabPage tabPage1;
        public Panel panelEditPayment;
        private TabPage tabPage2;
        public Panel panelEditOrder;
        private Panel panel3;
        private Panel panel2;
        private Panel panel7;
        private DataGridViewTextBoxColumn NumPendingSet;
        private DataGridViewTextBoxColumn TransRefNoPendingSet;
        private DataGridViewTextBoxColumn CustomerNamePendingSet;
        private DataGridViewTextBoxColumn TotalPayment;
        private DataGridViewTextBoxColumn InitialDeposit;
        private DataGridViewTextBoxColumn RemBalance;
        private DataGridViewTextBoxColumn DueDate;
        private DataGridViewTextBoxColumn Cashier;
        private DataGridViewTextBoxColumn S;
        private TextBox textBox1;
        private MonthCalendar monthCalendar1;
        public TextBox txtSearchPending;
        public DataGridView dataGridViewPaymentStat;
        public Label lblCurrentTransN;
    }
}