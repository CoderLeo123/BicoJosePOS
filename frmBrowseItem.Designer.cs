namespace Capstone
{
    partial class frmBrowseItem
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
            this.AddSearchItem = new System.Windows.Forms.DataGridViewImageColumn();
            this.TypeSearchItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescSearchItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBrowseItem = new System.Windows.Forms.TextBox();
            this.PCodeSearchItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumSearchItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.NumBrowseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCodeBrowseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescBrowseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeBrowseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductBrowseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceBrowseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityBrowseItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddToCart = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PriceSearchItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewSearchItem = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchItem)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddSearchItem
            // 
            this.AddSearchItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddSearchItem.HeaderText = "";
            this.AddSearchItem.MinimumWidth = 6;
            this.AddSearchItem.Name = "AddSearchItem";
            this.AddSearchItem.Width = 24;
            // 
            // TypeSearchItem
            // 
            this.TypeSearchItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TypeSearchItem.HeaderText = "TYPE";
            this.TypeSearchItem.MinimumWidth = 6;
            this.TypeSearchItem.Name = "TypeSearchItem";
            this.TypeSearchItem.Width = 81;
            // 
            // DescSearchItem
            // 
            this.DescSearchItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescSearchItem.HeaderText = "DESCRIPTION";
            this.DescSearchItem.MinimumWidth = 6;
            this.DescSearchItem.Name = "DescSearchItem";
            // 
            // txtBrowseItem
            // 
            this.txtBrowseItem.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBrowseItem.Location = new System.Drawing.Point(23, 10);
            this.txtBrowseItem.Name = "txtBrowseItem";
            this.txtBrowseItem.PlaceholderText = "Search Here";
            this.txtBrowseItem.Size = new System.Drawing.Size(619, 38);
            this.txtBrowseItem.TabIndex = 0;
            // 
            // PCodeSearchItem
            // 
            this.PCodeSearchItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PCodeSearchItem.HeaderText = "PCODE";
            this.PCodeSearchItem.MinimumWidth = 6;
            this.PCodeSearchItem.Name = "PCodeSearchItem";
            // 
            // NumSearchItem
            // 
            this.NumSearchItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumSearchItem.HeaderText = "#";
            this.NumSearchItem.MinimumWidth = 6;
            this.NumSearchItem.Name = "NumSearchItem";
            this.NumSearchItem.Width = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Browse Item";
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToResizeColumns = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewItems.ColumnHeadersHeight = 40;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumBrowseItem,
            this.PCodeBrowseItem,
            this.DescBrowseItem,
            this.TypeBrowseItem,
            this.ProductBrowseItem,
            this.PriceBrowseItem,
            this.QuantityBrowseItem,
            this.AddToCart});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewItems.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewItems.EnableHeadersVisualStyles = false;
            this.dataGridViewItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 120);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersVisible = false;
            this.dataGridViewItems.RowHeadersWidth = 51;
            this.dataGridViewItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewItems.RowTemplate.Height = 29;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(1315, 810);
            this.dataGridViewItems.TabIndex = 7;
            // 
            // NumBrowseItem
            // 
            this.NumBrowseItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NumBrowseItem.HeaderText = "#";
            this.NumBrowseItem.MinimumWidth = 6;
            this.NumBrowseItem.Name = "NumBrowseItem";
            this.NumBrowseItem.Width = 51;
            // 
            // PCodeBrowseItem
            // 
            this.PCodeBrowseItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PCodeBrowseItem.HeaderText = "PCODE";
            this.PCodeBrowseItem.MinimumWidth = 6;
            this.PCodeBrowseItem.Name = "PCodeBrowseItem";
            // 
            // DescBrowseItem
            // 
            this.DescBrowseItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DescBrowseItem.HeaderText = "DESCRIPTION";
            this.DescBrowseItem.MinimumWidth = 6;
            this.DescBrowseItem.Name = "DescBrowseItem";
            // 
            // TypeBrowseItem
            // 
            this.TypeBrowseItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TypeBrowseItem.HeaderText = "TYPE";
            this.TypeBrowseItem.MinimumWidth = 6;
            this.TypeBrowseItem.Name = "TypeBrowseItem";
            this.TypeBrowseItem.Width = 81;
            // 
            // ProductBrowseItem
            // 
            this.ProductBrowseItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ProductBrowseItem.HeaderText = "PRODUCT";
            this.ProductBrowseItem.MinimumWidth = 6;
            this.ProductBrowseItem.Name = "ProductBrowseItem";
            this.ProductBrowseItem.Width = 127;
            // 
            // PriceBrowseItem
            // 
            this.PriceBrowseItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PriceBrowseItem.HeaderText = "PRICE";
            this.PriceBrowseItem.MinimumWidth = 6;
            this.PriceBrowseItem.Name = "PriceBrowseItem";
            this.PriceBrowseItem.Width = 89;
            // 
            // QuantityBrowseItem
            // 
            this.QuantityBrowseItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QuantityBrowseItem.HeaderText = "QUANTITY";
            this.QuantityBrowseItem.MinimumWidth = 6;
            this.QuantityBrowseItem.Name = "QuantityBrowseItem";
            this.QuantityBrowseItem.Width = 132;
            // 
            // AddToCart
            // 
            this.AddToCart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.AddToCart.HeaderText = "";
            this.AddToCart.Image = global::Capstone.Properties.Resources.addToCart;
            this.AddToCart.MinimumWidth = 6;
            this.AddToCart.Name = "AddToCart";
            this.AddToCart.Width = 24;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1315, 120);
            this.panel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1263, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // PriceSearchItem
            // 
            this.PriceSearchItem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.PriceSearchItem.HeaderText = "PRICE";
            this.PriceSearchItem.MinimumWidth = 6;
            this.PriceSearchItem.Name = "PriceSearchItem";
            this.PriceSearchItem.Width = 89;
            // 
            // dataGridViewSearchItem
            // 
            this.dataGridViewSearchItem.AllowUserToResizeColumns = false;
            this.dataGridViewSearchItem.AllowUserToResizeRows = false;
            this.dataGridViewSearchItem.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSearchItem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSearchItem.ColumnHeadersHeight = 40;
            this.dataGridViewSearchItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSearchItem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumSearchItem,
            this.PCodeSearchItem,
            this.DescSearchItem,
            this.TypeSearchItem,
            this.PriceSearchItem,
            this.AddSearchItem});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchItem.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSearchItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSearchItem.EnableHeadersVisualStyles = false;
            this.dataGridViewSearchItem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewSearchItem.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewSearchItem.Name = "dataGridViewSearchItem";
            this.dataGridViewSearchItem.RowHeadersVisible = false;
            this.dataGridViewSearchItem.RowHeadersWidth = 51;
            this.dataGridViewSearchItem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSearchItem.RowTemplate.Height = 29;
            this.dataGridViewSearchItem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchItem.Size = new System.Drawing.Size(1315, 930);
            this.dataGridViewSearchItem.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.txtBrowseItem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 54);
            this.panel2.TabIndex = 36;
            // 
            // frmBrowseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 930);
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridViewSearchItem);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBrowseItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBrowseItem";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchItem)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridViewImageColumn AddSearchItem;
        private DataGridViewTextBoxColumn TypeSearchItem;
        private DataGridViewTextBoxColumn DescSearchItem;
        private TextBox txtBrowseItem;
        private DataGridViewTextBoxColumn PCodeSearchItem;
        private DataGridViewTextBoxColumn NumSearchItem;
        private Label label1;
        private DataGridView dataGridViewItems;
        private Panel panel1;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn PriceSearchItem;
        private DataGridView dataGridViewSearchItem;
        private DataGridViewTextBoxColumn NumBrowseItem;
        private DataGridViewTextBoxColumn PCodeBrowseItem;
        private DataGridViewTextBoxColumn DescBrowseItem;
        private DataGridViewTextBoxColumn TypeBrowseItem;
        private DataGridViewTextBoxColumn ProductBrowseItem;
        private DataGridViewTextBoxColumn PriceBrowseItem;
        private DataGridViewTextBoxColumn QuantityBrowseItem;
        private DataGridViewImageColumn AddToCart;
        private Panel panel2;
    }
}