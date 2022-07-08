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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchOrderStatus = new System.Windows.Forms.TextBox();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseDailySales = new System.Windows.Forms.PictureBox();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.NumDailySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCodeDailySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceDailySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescriptionDailySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceDailySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityDailySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscountDailySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalDailySales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelDailySales = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseDailySales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseDailySales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 108);
            this.panel1.TabIndex = 4;
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
            // txtSearchOrderStatus
            // 
            this.txtSearchOrderStatus.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchOrderStatus.Location = new System.Drawing.Point(685, 10);
            this.txtSearchOrderStatus.Name = "txtSearchOrderStatus";
            this.txtSearchOrderStatus.PlaceholderText = "Search Here";
            this.txtSearchOrderStatus.Size = new System.Drawing.Size(570, 38);
            this.txtSearchOrderStatus.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Daily Sales";
            // 
            // btnCloseDailySales
            // 
            this.btnCloseDailySales.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseDailySales.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnCloseDailySales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseDailySales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseDailySales.Location = new System.Drawing.Point(1260, 9);
            this.btnCloseDailySales.Name = "btnCloseDailySales";
            this.btnCloseDailySales.Padding = new System.Windows.Forms.Padding(3);
            this.btnCloseDailySales.Size = new System.Drawing.Size(40, 38);
            this.btnCloseDailySales.TabIndex = 0;
            this.btnCloseDailySales.TabStop = false;
            this.btnCloseDailySales.Click += new System.EventHandler(this.btnCloseDailySales_Click);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToResizeColumns = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewItems.ColumnHeadersHeight = 40;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumDailySales,
            this.PCodeDailySales,
            this.InvoiceDailySales,
            this.DescriptionDailySales,
            this.PriceDailySales,
            this.QuantityDailySales,
            this.DiscountDailySales,
            this.TotalDailySales,
            this.CancelDailySales});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewItems.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItems.EnableHeadersVisualStyles = false;
            this.dataGridViewItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 108);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersVisible = false;
            this.dataGridViewItems.RowHeadersWidth = 51;
            this.dataGridViewItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewItems.RowTemplate.Height = 29;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(1315, 822);
            this.dataGridViewItems.TabIndex = 8;
            // 
            // NumDailySales
            // 
            this.NumDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumDailySales.HeaderText = "#";
            this.NumDailySales.MinimumWidth = 6;
            this.NumDailySales.Name = "NumDailySales";
            this.NumDailySales.Width = 51;
            // 
            // PCodeDailySales
            // 
            this.PCodeDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PCodeDailySales.HeaderText = "PCODE";
            this.PCodeDailySales.MinimumWidth = 6;
            this.PCodeDailySales.Name = "PCodeDailySales";
            // 
            // InvoiceDailySales
            // 
            this.InvoiceDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.InvoiceDailySales.HeaderText = "INVOICE NO.";
            this.InvoiceDailySales.MinimumWidth = 6;
            this.InvoiceDailySales.Name = "InvoiceDailySales";
            this.InvoiceDailySales.Width = 152;
            // 
            // DescriptionDailySales
            // 
            this.DescriptionDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescriptionDailySales.HeaderText = "DESCRIPTION";
            this.DescriptionDailySales.MinimumWidth = 6;
            this.DescriptionDailySales.Name = "DescriptionDailySales";
            // 
            // PriceDailySales
            // 
            this.PriceDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PriceDailySales.HeaderText = "PRICE";
            this.PriceDailySales.MinimumWidth = 6;
            this.PriceDailySales.Name = "PriceDailySales";
            this.PriceDailySales.Width = 89;
            // 
            // QuantityDailySales
            // 
            this.QuantityDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QuantityDailySales.HeaderText = "QUANTITY";
            this.QuantityDailySales.MinimumWidth = 6;
            this.QuantityDailySales.Name = "QuantityDailySales";
            this.QuantityDailySales.Width = 132;
            // 
            // DiscountDailySales
            // 
            this.DiscountDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DiscountDailySales.HeaderText = "DISCOUNT";
            this.DiscountDailySales.MinimumWidth = 6;
            this.DiscountDailySales.Name = "DiscountDailySales";
            this.DiscountDailySales.Width = 134;
            // 
            // TotalDailySales
            // 
            this.TotalDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalDailySales.HeaderText = "TOTAL";
            this.TotalDailySales.MinimumWidth = 6;
            this.TotalDailySales.Name = "TotalDailySales";
            this.TotalDailySales.Width = 93;
            // 
            // CancelDailySales
            // 
            this.CancelDailySales.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CancelDailySales.HeaderText = "";
            this.CancelDailySales.MinimumWidth = 6;
            this.CancelDailySales.Name = "CancelDailySales";
            this.CancelDailySales.Width = 24;
            // 
            // frmDailySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 930);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmDailySales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDailySales";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseDailySales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtSearchOrderStatus;
        private DateTimePicker dateTimePicker3;
        private Label label2;
        private DateTimePicker dateTimePicker4;
        private Label label1;
        private PictureBox btnCloseDailySales;
        private DataGridView dataGridViewItems;
        private DataGridViewTextBoxColumn NumDailySales;
        private DataGridViewTextBoxColumn PCodeDailySales;
        private DataGridViewTextBoxColumn InvoiceDailySales;
        private DataGridViewTextBoxColumn DescriptionDailySales;
        private DataGridViewTextBoxColumn PriceDailySales;
        private DataGridViewTextBoxColumn QuantityDailySales;
        private DataGridViewTextBoxColumn DiscountDailySales;
        private DataGridViewTextBoxColumn TotalDailySales;
        private DataGridViewImageColumn CancelDailySales;
    }
}