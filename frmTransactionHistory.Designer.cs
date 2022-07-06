namespace Capstone
{
    partial class frmTransactionHistory
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtSearchTransHist = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
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
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransHist)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 107);
            this.panel1.TabIndex = 4;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(527, 61);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(158, 34);
            this.dateTimePicker2.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(158, 34);
            this.dateTimePicker1.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 38);
            this.label3.TabIndex = 32;
            this.label3.Text = "Filter By Date (From - To)";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtSearchTransHist);
            this.panel6.Location = new System.Drawing.Point(707, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(566, 45);
            this.panel6.TabIndex = 31;
            // 
            // txtSearchTransHist
            // 
            this.txtSearchTransHist.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchTransHist.Location = new System.Drawing.Point(19, 9);
            this.txtSearchTransHist.Name = "txtSearchTransHist";
            this.txtSearchTransHist.PlaceholderText = "Search Here";
            this.txtSearchTransHist.Size = new System.Drawing.Size(534, 38);
            this.txtSearchTransHist.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Transaction History";
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
            // dataGridViewTransHist
            // 
            this.dataGridViewTransHist.AllowUserToResizeColumns = false;
            this.dataGridViewTransHist.AllowUserToResizeRows = false;
            this.dataGridViewTransHist.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewTransHist.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
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
            this.dataGridViewTransHist.Location = new System.Drawing.Point(0, 107);
            this.dataGridViewTransHist.Name = "dataGridViewTransHist";
            this.dataGridViewTransHist.RowHeadersVisible = false;
            this.dataGridViewTransHist.RowHeadersWidth = 51;
            this.dataGridViewTransHist.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewTransHist.RowTemplate.Height = 29;
            this.dataGridViewTransHist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTransHist.Size = new System.Drawing.Size(1315, 823);
            this.dataGridViewTransHist.TabIndex = 6;
            // 
            // NumTransHist
            // 
            this.NumTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumTransHist.HeaderText = "#";
            this.NumTransHist.MinimumWidth = 6;
            this.NumTransHist.Name = "NumTransHist";
            this.NumTransHist.Width = 45;
            // 
            // TransRefNoTransHist
            // 
            this.TransRefNoTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TransRefNoTransHist.HeaderText = "TRANS REF.NO.";
            this.TransRefNoTransHist.MinimumWidth = 6;
            this.TransRefNoTransHist.Name = "TransRefNoTransHist";
            this.TransRefNoTransHist.Width = 145;
            // 
            // CustomerNameTransHist
            // 
            this.CustomerNameTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CustomerNameTransHist.HeaderText = "CUSTOMER NAME";
            this.CustomerNameTransHist.MinimumWidth = 6;
            this.CustomerNameTransHist.Name = "CustomerNameTransHist";
            this.CustomerNameTransHist.Width = 164;
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
            this.AvailedServTransHist.Width = 160;
            // 
            // TotalTransHist
            // 
            this.TotalTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalTransHist.HeaderText = "TOTAL";
            this.TotalTransHist.MinimumWidth = 6;
            this.TotalTransHist.Name = "TotalTransHist";
            this.TotalTransHist.Width = 81;
            // 
            // PaymentTermsTransHist
            // 
            this.PaymentTermsTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PaymentTermsTransHist.HeaderText = "PAYMENT TERMS";
            this.PaymentTermsTransHist.MinimumWidth = 6;
            this.PaymentTermsTransHist.Name = "PaymentTermsTransHist";
            this.PaymentTermsTransHist.Width = 159;
            // 
            // PaymentStatusTransHist
            // 
            this.PaymentStatusTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PaymentStatusTransHist.HeaderText = "PAYMENT STATUS";
            this.PaymentStatusTransHist.MinimumWidth = 6;
            this.PaymentStatusTransHist.Name = "PaymentStatusTransHist";
            this.PaymentStatusTransHist.Width = 164;
            // 
            // OrderStatusTransHist
            // 
            this.OrderStatusTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OrderStatusTransHist.HeaderText = "ORDER STATUS";
            this.OrderStatusTransHist.MinimumWidth = 6;
            this.OrderStatusTransHist.Name = "OrderStatusTransHist";
            this.OrderStatusTransHist.Width = 144;
            // 
            // DateTransHist
            // 
            this.DateTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DateTransHist.HeaderText = "DATE";
            this.DateTransHist.MinimumWidth = 6;
            this.DateTransHist.Name = "DateTransHist";
            this.DateTransHist.Width = 74;
            // 
            // frmTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 930);
            this.Controls.Add(this.dataGridViewTransHist);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactionHistory";
            this.Text = "frmTransactionHistory";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTransactionHistory_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransHist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnClose;
        private DataGridView dataGridViewTransHist;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Panel panel6;
        private TextBox txtSearchTransHist;
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