namespace Capstone
{
    partial class frmReports
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseReports = new System.Windows.Forms.PictureBox();
            this.tabControlReports = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.History = new System.Windows.Forms.TabPage();
            this.panelSalesHistory = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewTransHist = new System.Windows.Forms.DataGridView();
            this.NumTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransRefNoTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNameTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseItemsTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailedServTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentTermsTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatusTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtSearchTransHist = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseReports)).BeginInit();
            this.tabControlReports.SuspendLayout();
            this.History.SuspendLayout();
            this.panelSalesHistory.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransHist)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseReports);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 57);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sales and Inventory Report";
            // 
            // btnCloseReports
            // 
            this.btnCloseReports.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseReports.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnCloseReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseReports.Location = new System.Drawing.Point(1260, 9);
            this.btnCloseReports.Name = "btnCloseReports";
            this.btnCloseReports.Padding = new System.Windows.Forms.Padding(3);
            this.btnCloseReports.Size = new System.Drawing.Size(40, 38);
            this.btnCloseReports.TabIndex = 0;
            this.btnCloseReports.TabStop = false;
            // 
            // tabControlReports
            // 
            this.tabControlReports.Controls.Add(this.tabPage1);
            this.tabControlReports.Controls.Add(this.tabPage2);
            this.tabControlReports.Controls.Add(this.History);
            this.tabControlReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReports.Location = new System.Drawing.Point(0, 57);
            this.tabControlReports.Name = "tabControlReports";
            this.tabControlReports.SelectedIndex = 0;
            this.tabControlReports.Size = new System.Drawing.Size(1315, 873);
            this.tabControlReports.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1307, 823);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Sales Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1307, 840);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Top Selling";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // History
            // 
            this.History.Controls.Add(this.panelSalesHistory);
            this.History.Location = new System.Drawing.Point(4, 46);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(1307, 823);
            this.History.TabIndex = 2;
            this.History.Text = "Sale\'s History";
            this.History.UseVisualStyleBackColor = true;
            // 
            // panelSalesHistory
            // 
            this.panelSalesHistory.Controls.Add(this.panel3);
            this.panelSalesHistory.Controls.Add(this.panel2);
            this.panelSalesHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSalesHistory.Location = new System.Drawing.Point(0, 0);
            this.panelSalesHistory.Name = "panelSalesHistory";
            this.panelSalesHistory.Size = new System.Drawing.Size(1307, 823);
            this.panelSalesHistory.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewTransHist);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1307, 715);
            this.panel3.TabIndex = 1;
            // 
            // dataGridViewTransHist
            // 
            this.dataGridViewTransHist.AllowUserToResizeColumns = false;
            this.dataGridViewTransHist.AllowUserToResizeRows = false;
            this.dataGridViewTransHist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTransHist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTransHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTransHist.ColumnHeadersHeight = 40;
            this.dataGridViewTransHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewTransHist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumTransHist,
            this.TransRefNoTransHist,
            this.CustomerNameTransHist,
            this.PurchaseItemsTransHist,
            this.AvailedServTransHist,
            this.TotalTransHist,
            this.PaymentTermsTransHist,
            this.PaymentStatusTransHist,
            this.OrderStatusTransHist,
            this.DateTransHist});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTransHist.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTransHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTransHist.EnableHeadersVisualStyles = false;
            this.dataGridViewTransHist.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewTransHist.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTransHist.Name = "dataGridViewTransHist";
            this.dataGridViewTransHist.RowHeadersVisible = false;
            this.dataGridViewTransHist.RowHeadersWidth = 51;
            this.dataGridViewTransHist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTransHist.RowTemplate.Height = 29;
            this.dataGridViewTransHist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransHist.Size = new System.Drawing.Size(1307, 715);
            this.dataGridViewTransHist.TabIndex = 7;
            // 
            // NumTransHist
            // 
            this.NumTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumTransHist.HeaderText = "#";
            this.NumTransHist.MinimumWidth = 6;
            this.NumTransHist.Name = "NumTransHist";
            this.NumTransHist.Width = 61;
            // 
            // TransRefNoTransHist
            // 
            this.TransRefNoTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TransRefNoTransHist.HeaderText = "TRANS REF.NO.";
            this.TransRefNoTransHist.MinimumWidth = 6;
            this.TransRefNoTransHist.Name = "TransRefNoTransHist";
            this.TransRefNoTransHist.Width = 237;
            // 
            // CustomerNameTransHist
            // 
            this.CustomerNameTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CustomerNameTransHist.HeaderText = "CUSTOMER NAME";
            this.CustomerNameTransHist.MinimumWidth = 6;
            this.CustomerNameTransHist.Name = "CustomerNameTransHist";
            this.CustomerNameTransHist.Width = 272;
            // 
            // PurchaseItemsTransHist
            // 
            this.PurchaseItemsTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchaseItemsTransHist.HeaderText = "PURCHASE ITEMS";
            this.PurchaseItemsTransHist.MinimumWidth = 6;
            this.PurchaseItemsTransHist.Name = "PurchaseItemsTransHist";
            // 
            // AvailedServTransHist
            // 
            this.AvailedServTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AvailedServTransHist.HeaderText = "AVAILED SERVICE";
            this.AvailedServTransHist.MinimumWidth = 6;
            this.AvailedServTransHist.Name = "AvailedServTransHist";
            this.AvailedServTransHist.Width = 256;
            // 
            // TotalTransHist
            // 
            this.TotalTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalTransHist.HeaderText = "TOTAL";
            this.TotalTransHist.MinimumWidth = 6;
            this.TotalTransHist.Name = "TotalTransHist";
            this.TotalTransHist.Width = 122;
            // 
            // PaymentTermsTransHist
            // 
            this.PaymentTermsTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PaymentTermsTransHist.HeaderText = "PAYMENT TERMS";
            this.PaymentTermsTransHist.MinimumWidth = 6;
            this.PaymentTermsTransHist.Name = "PaymentTermsTransHist";
            this.PaymentTermsTransHist.Width = 258;
            // 
            // PaymentStatusTransHist
            // 
            this.PaymentStatusTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PaymentStatusTransHist.HeaderText = "PAYMENT STATUS";
            this.PaymentStatusTransHist.MinimumWidth = 6;
            this.PaymentStatusTransHist.Name = "PaymentStatusTransHist";
            this.PaymentStatusTransHist.Width = 265;
            // 
            // OrderStatusTransHist
            // 
            this.OrderStatusTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OrderStatusTransHist.HeaderText = "ORDER STATUS";
            this.OrderStatusTransHist.MinimumWidth = 6;
            this.OrderStatusTransHist.Name = "OrderStatusTransHist";
            this.OrderStatusTransHist.Width = 234;
            // 
            // DateTransHist
            // 
            this.DateTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DateTransHist.HeaderText = "DATE";
            this.DateTransHist.MinimumWidth = 6;
            this.DateTransHist.Name = "DateTransHist";
            this.DateTransHist.Width = 108;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 108);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.btnClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1307, 108);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DimGray;
            this.panel5.Controls.Add(this.txtSearchTransHist);
            this.panel5.Controls.Add(this.dateTimePicker1);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.dateTimePicker2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1307, 54);
            this.panel5.TabIndex = 35;
            // 
            // txtSearchTransHist
            // 
            this.txtSearchTransHist.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchTransHist.Location = new System.Drawing.Point(661, 9);
            this.txtSearchTransHist.Name = "txtSearchTransHist";
            this.txtSearchTransHist.PlaceholderText = "Search Here";
            this.txtSearchTransHist.Size = new System.Drawing.Size(534, 38);
            this.txtSearchTransHist.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(313, 9);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 34);
            this.dateTimePicker1.TabIndex = 33;
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(486, 9);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(158, 34);
            this.dateTimePicker2.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Transaction History";
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
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 930);
            this.Controls.Add(this.tabControlReports);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmReports";
            this.Text = "frmReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseReports)).EndInit();
            this.tabControlReports.ResumeLayout(false);
            this.History.ResumeLayout(false);
            this.panelSalesHistory.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransHist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnCloseReports;
        private TabControl tabControlReports;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage History;
        private Panel panelSalesHistory;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private TextBox txtSearchTransHist;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private PictureBox btnClose;
        private DataGridView dataGridViewTransHist;
        private DataGridViewTextBoxColumn NumTransHist;
        private DataGridViewTextBoxColumn TransRefNoTransHist;
        private DataGridViewTextBoxColumn CustomerNameTransHist;
        private DataGridViewTextBoxColumn PurchaseItemsTransHist;
        private DataGridViewTextBoxColumn AvailedServTransHist;
        private DataGridViewTextBoxColumn TotalTransHist;
        private DataGridViewTextBoxColumn PaymentTermsTransHist;
        private DataGridViewTextBoxColumn PaymentStatusTransHist;
        private DataGridViewTextBoxColumn OrderStatusTransHist;
        private DataGridViewTextBoxColumn DateTransHist;
    }
}