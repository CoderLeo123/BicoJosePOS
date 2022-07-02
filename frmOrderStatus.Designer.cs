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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.NumOrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNameOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseItemOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpectedArrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateClaimedOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseByOrdStat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 57);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 38);
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
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToResizeColumns = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewProducts.ColumnHeadersHeight = 40;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewProducts.EnableHeadersVisualStyles = false;
            this.dataGridViewProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewProducts.Location = new System.Drawing.Point(0, 57);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.RowHeadersVisible = false;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewProducts.RowTemplate.Height = 29;
            this.dataGridViewProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1315, 873);
            this.dataGridViewProducts.TabIndex = 5;
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
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrderStatus";
            this.Text = "frmOrderStatus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnClose;
        private DataGridView dataGridViewProducts;
        private DataGridViewTextBoxColumn NumOrderStatus;
        private DataGridViewTextBoxColumn CustomerNameOrdStat;
        private DataGridViewTextBoxColumn PurchaseItemOrdStat;
        private DataGridViewTextBoxColumn StatusOrdStat;
        private DataGridViewTextBoxColumn ExpectedArrival;
        private DataGridViewTextBoxColumn DateClaimedOrdStat;
        private DataGridViewTextBoxColumn ReleaseByOrdStat;
    }
}