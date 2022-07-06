namespace Capstone
{
    partial class frmOrderStatus
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
            this.txtSearchOrderStatus = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.dataGridViewOrderStatus = new System.Windows.Forms.DataGridView();
            this.NumOrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNameOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseItemOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateClaimedOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseByOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderStatus)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1315, 110);
            this.panel1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(524, 65);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(158, 34);
            this.dateTimePicker2.TabIndex = 34;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(360, 65);
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
            this.label3.Location = new System.Drawing.Point(30, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 38);
            this.label3.TabIndex = 32;
            this.label3.Text = "Filter By Date (From - To)";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtSearchOrderStatus);
            this.panel6.Location = new System.Drawing.Point(685, 50);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(592, 57);
            this.panel6.TabIndex = 31;
            // 
            // txtSearchOrderStatus
            // 
            this.txtSearchOrderStatus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchOrderStatus.Location = new System.Drawing.Point(19, 9);
            this.txtSearchOrderStatus.Name = "txtSearchOrderStatus";
            this.txtSearchOrderStatus.PlaceholderText = "Search Here";
            this.txtSearchOrderStatus.Size = new System.Drawing.Size(570, 38);
            this.txtSearchOrderStatus.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Order Status";
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
            // dataGridViewOrderStatus
            // 
            this.dataGridViewOrderStatus.AllowUserToResizeColumns = false;
            this.dataGridViewOrderStatus.AllowUserToResizeRows = false;
            this.dataGridViewOrderStatus.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewOrderStatus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewOrderStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewOrderStatus.ColumnHeadersHeight = 40;
            this.dataGridViewOrderStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewOrderStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumOrderStatus,
            this.CustomerNameOrdStat,
            this.PurchaseItemOrdStat,
            this.StatusOrdStat,
            this.ExpectedArrival,
            this.DateClaimedOrdStat,
            this.ReleaseByOrdStat});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewOrderStatus.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewOrderStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOrderStatus.EnableHeadersVisualStyles = false;
            this.dataGridViewOrderStatus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewOrderStatus.Location = new System.Drawing.Point(0, 110);
            this.dataGridViewOrderStatus.Name = "dataGridViewOrderStatus";
            this.dataGridViewOrderStatus.RowHeadersVisible = false;
            this.dataGridViewOrderStatus.RowHeadersWidth = 51;
            this.dataGridViewOrderStatus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewOrderStatus.RowTemplate.Height = 29;
            this.dataGridViewOrderStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderStatus.Size = new System.Drawing.Size(1315, 820);
            this.dataGridViewOrderStatus.TabIndex = 5;
            // 
            // NumOrderStatus
            // 
            this.NumOrderStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumOrderStatus.HeaderText = "#";
            this.NumOrderStatus.MinimumWidth = 6;
            this.NumOrderStatus.Name = "NumOrderStatus";
            this.NumOrderStatus.Width = 51;
            // 
            // CustomerNameOrdStat
            // 
            this.CustomerNameOrdStat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerNameOrdStat.HeaderText = "CUSTOMER NAME";
            this.CustomerNameOrdStat.MinimumWidth = 6;
            this.CustomerNameOrdStat.Name = "CustomerNameOrdStat";
            // 
            // PurchaseItemOrdStat
            // 
            this.PurchaseItemOrdStat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PurchaseItemOrdStat.HeaderText = "PURCHASE ITEMS";
            this.PurchaseItemOrdStat.MinimumWidth = 6;
            this.PurchaseItemOrdStat.Name = "PurchaseItemOrdStat";
            // 
            // StatusOrdStat
            // 
            this.StatusOrdStat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StatusOrdStat.HeaderText = "STATUS";
            this.StatusOrdStat.MinimumWidth = 6;
            this.StatusOrdStat.Name = "StatusOrdStat";
            this.StatusOrdStat.Width = 111;
            // 
            // ExpectedArrival
            // 
            this.ExpectedArrival.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ExpectedArrival.HeaderText = "EXPECTED ARRIVAL";
            this.ExpectedArrival.MinimumWidth = 6;
            this.ExpectedArrival.Name = "ExpectedArrival";
            this.ExpectedArrival.Width = 224;
            // 
            // DateClaimedOrdStat
            // 
            this.DateClaimedOrdStat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DateClaimedOrdStat.HeaderText = "DATE CLAIMED";
            this.DateClaimedOrdStat.MinimumWidth = 6;
            this.DateClaimedOrdStat.Name = "DateClaimedOrdStat";
            this.DateClaimedOrdStat.Width = 183;
            // 
            // ReleaseByOrdStat
            // 
            this.ReleaseByOrdStat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReleaseByOrdStat.HeaderText = "RELEASE BY";
            this.ReleaseByOrdStat.MinimumWidth = 6;
            this.ReleaseByOrdStat.Name = "ReleaseByOrdStat";
            this.ReleaseByOrdStat.Width = 151;
            // 
            // frmOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 930);
            this.Controls.Add(this.dataGridViewOrderStatus);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderStatus";
            this.Text = "frmOrderStatus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnClose;
        private DataGridView dataGridViewOrderStatus;
        private DataGridViewTextBoxColumn NumOrderStatus;
        private DataGridViewTextBoxColumn CustomerNameOrdStat;
        private DataGridViewTextBoxColumn PurchaseItemOrdStat;
        private DataGridViewTextBoxColumn StatusOrdStat;
        private DataGridViewTextBoxColumn ExpectedArrival;
        private DataGridViewTextBoxColumn DateClaimedOrdStat;
        private DataGridViewTextBoxColumn ReleaseByOrdStat;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Panel panel6;
        private TextBox txtSearchOrderStatus;
    }
}