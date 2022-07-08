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
            this.dataGridViewOrderStatus = new System.Windows.Forms.DataGridView();
            this.NumOrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNameOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseItemOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateClaimedOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseByOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchOrderStatus = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridViewOrderStatus.Location = new System.Drawing.Point(0, 108);
            this.dataGridViewOrderStatus.Name = "dataGridViewOrderStatus";
            this.dataGridViewOrderStatus.RowHeadersVisible = false;
            this.dataGridViewOrderStatus.RowHeadersWidth = 51;
            this.dataGridViewOrderStatus.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewOrderStatus.RowTemplate.Height = 29;
            this.dataGridViewOrderStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrderStatus.Size = new System.Drawing.Size(1315, 822);
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
            // txtSearchOrderStatus
            // 
            this.txtSearchOrderStatus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchOrderStatus.Location = new System.Drawing.Point(685, 10);
            this.txtSearchOrderStatus.Name = "txtSearchOrderStatus";
            this.txtSearchOrderStatus.PlaceholderText = "Search Here";
            this.txtSearchOrderStatus.Size = new System.Drawing.Size(570, 38);
            this.txtSearchOrderStatus.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.txtSearchOrderStatus);
            this.panel2.Controls.Add(this.dateTimePicker3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dateTimePicker4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 54);
            this.panel2.TabIndex = 36;
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(486, 9);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(158, 34);
            this.dateTimePicker4.TabIndex = 34;
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
            // dateTimePicker3
            // 
            this.dateTimePicker3.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(313, 9);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(158, 34);
            this.dateTimePicker3.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 108);
            this.panel1.TabIndex = 3;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrderStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dataGridViewOrderStatus;
        private DataGridViewTextBoxColumn NumOrderStatus;
        private DataGridViewTextBoxColumn CustomerNameOrdStat;
        private DataGridViewTextBoxColumn PurchaseItemOrdStat;
        private DataGridViewTextBoxColumn StatusOrdStat;
        private DataGridViewTextBoxColumn ExpectedArrival;
        private DataGridViewTextBoxColumn DateClaimedOrdStat;
        private DataGridViewTextBoxColumn ReleaseByOrdStat;
        private PictureBox btnClose;
        private Label label1;
        private TextBox txtSearchOrderStatus;
        private Panel panel2;
        private DateTimePicker dateTimePicker3;
        private Label label2;
        private DateTimePicker dateTimePicker4;
        private Panel panel1;
    }
}