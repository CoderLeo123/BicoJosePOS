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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.NumTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TransRefNoTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNameTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseItemsTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailedServTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentTermsTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentStatusTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusTransHist = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.TabIndex = 4;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewProducts.ColumnHeadersHeight = 40;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumTransHist,
            this.TransRefNoTransHist,
            this.CustomerNameTransHist,
            this.PurchaseItemsTransHist,
            this.AvailedServTransHist,
            this.TotalTransHist,
            this.PaymentTermsTransHist,
            this.PaymentStatusTransHist,
            this.OrderStatusTransHist});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.dataGridViewProducts.TabIndex = 6;
            // 
            // NumTransHist
            // 
            this.NumTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumTransHist.HeaderText = "#";
            this.NumTransHist.MinimumWidth = 6;
            this.NumTransHist.Name = "NumTransHist";
            this.NumTransHist.Width = 47;
            // 
            // TransRefNoTransHist
            // 
            this.TransRefNoTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TransRefNoTransHist.HeaderText = "TRANS REF.NO.";
            this.TransRefNoTransHist.MinimumWidth = 6;
            this.TransRefNoTransHist.Name = "TransRefNoTransHist";
            this.TransRefNoTransHist.Width = 156;
            // 
            // CustomerNameTransHist
            // 
            this.CustomerNameTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CustomerNameTransHist.HeaderText = "CUSTOMER NAME";
            this.CustomerNameTransHist.MinimumWidth = 6;
            this.CustomerNameTransHist.Name = "CustomerNameTransHist";
            this.CustomerNameTransHist.Width = 180;
            // 
            // PurchaseItemsTransHist
            // 
            this.PurchaseItemsTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PurchaseItemsTransHist.HeaderText = "PURCHASE ITEMS";
            this.PurchaseItemsTransHist.MinimumWidth = 6;
            this.PurchaseItemsTransHist.Name = "PurchaseItemsTransHist";
            this.PurchaseItemsTransHist.Width = 176;
            // 
            // AvailedServTransHist
            // 
            this.AvailedServTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.AvailedServTransHist.HeaderText = "AVAILED SERVICE";
            this.AvailedServTransHist.MinimumWidth = 6;
            this.AvailedServTransHist.Name = "AvailedServTransHist";
            this.AvailedServTransHist.Width = 172;
            // 
            // TotalTransHist
            // 
            this.TotalTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalTransHist.HeaderText = "TOTAL";
            this.TotalTransHist.MinimumWidth = 6;
            this.TotalTransHist.Name = "TotalTransHist";
            this.TotalTransHist.Width = 84;
            // 
            // PaymentTermsTransHist
            // 
            this.PaymentTermsTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PaymentTermsTransHist.HeaderText = "PAYMENT TERMS";
            this.PaymentTermsTransHist.MinimumWidth = 6;
            this.PaymentTermsTransHist.Name = "PaymentTermsTransHist";
            this.PaymentTermsTransHist.Width = 172;
            // 
            // PaymentStatusTransHist
            // 
            this.PaymentStatusTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PaymentStatusTransHist.HeaderText = "PAYMENT STATUS";
            this.PaymentStatusTransHist.MinimumWidth = 6;
            this.PaymentStatusTransHist.Name = "PaymentStatusTransHist";
            this.PaymentStatusTransHist.Width = 175;
            // 
            // OrderStatusTransHist
            // 
            this.OrderStatusTransHist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.OrderStatusTransHist.HeaderText = "ORDER STATUS";
            this.OrderStatusTransHist.MinimumWidth = 6;
            this.OrderStatusTransHist.Name = "OrderStatusTransHist";
            this.OrderStatusTransHist.Width = 155;
            // 
            // frmTransactionHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 930);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTransactionHistory";
            this.Text = "frmTransactionHistory";
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
        private DataGridViewTextBoxColumn NumTransHist;
        private DataGridViewTextBoxColumn TransRefNoTransHist;
        private DataGridViewTextBoxColumn CustomerNameTransHist;
        private DataGridViewTextBoxColumn PurchaseItemsTransHist;
        private DataGridViewTextBoxColumn AvailedServTransHist;
        private DataGridViewTextBoxColumn TotalTransHist;
        private DataGridViewTextBoxColumn PaymentTermsTransHist;
        private DataGridViewTextBoxColumn PaymentStatusTransHist;
        private DataGridViewTextBoxColumn OrderStatusTransHist;
    }
}