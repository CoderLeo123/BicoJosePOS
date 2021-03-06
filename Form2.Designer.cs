namespace Capstone
{
    partial class frmItemsList
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
            this.btnAddFrame = new System.Windows.Forms.Button();
            this.btnAddLense = new System.Windows.Forms.Button();
            this.btnAddAccessories = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PCODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDIT = new System.Windows.Forms.DataGridViewImageColumn();
            this.DELETE = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchTransHist = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1315, 116);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // btnAddFrame
            // 
            this.btnAddFrame.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddFrame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFrame.FlatAppearance.BorderSize = 0;
            this.btnAddFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFrame.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFrame.ForeColor = System.Drawing.Color.White;
            this.btnAddFrame.Location = new System.Drawing.Point(983, 8);
            this.btnAddFrame.Name = "btnAddFrame";
            this.btnAddFrame.Size = new System.Drawing.Size(153, 49);
            this.btnAddFrame.TabIndex = 23;
            this.btnAddFrame.Text = "Frame";
            this.btnAddFrame.UseVisualStyleBackColor = false;
            this.btnAddFrame.Click += new System.EventHandler(this.btnAddFrame_Click);
            // 
            // btnAddLense
            // 
            this.btnAddLense.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddLense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLense.FlatAppearance.BorderSize = 0;
            this.btnAddLense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLense.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddLense.ForeColor = System.Drawing.Color.White;
            this.btnAddLense.Location = new System.Drawing.Point(813, 8);
            this.btnAddLense.Name = "btnAddLense";
            this.btnAddLense.Size = new System.Drawing.Size(153, 49);
            this.btnAddLense.TabIndex = 22;
            this.btnAddLense.Text = "Lense";
            this.btnAddLense.UseVisualStyleBackColor = false;
            this.btnAddLense.Click += new System.EventHandler(this.btnAddLense_Click);
            // 
            // btnAddAccessories
            // 
            this.btnAddAccessories.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAddAccessories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAccessories.FlatAppearance.BorderSize = 0;
            this.btnAddAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAccessories.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddAccessories.ForeColor = System.Drawing.Color.White;
            this.btnAddAccessories.Location = new System.Drawing.Point(1152, 8);
            this.btnAddAccessories.Name = "btnAddAccessories";
            this.btnAddAccessories.Size = new System.Drawing.Size(153, 49);
            this.btnAddAccessories.TabIndex = 21;
            this.btnAddAccessories.Text = "Accessories";
            this.btnAddAccessories.UseVisualStyleBackColor = false;
            this.btnAddAccessories.Click += new System.EventHandler(this.btnAddAccessories_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items List";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(1259, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(3);
            this.pictureBox1.Size = new System.Drawing.Size(40, 38);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // dataGridViewItems
            // 
            this.dataGridViewItems.AllowUserToResizeColumns = false;
            this.dataGridViewItems.AllowUserToResizeRows = false;
            this.dataGridViewItems.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewItems.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewItems.ColumnHeadersHeight = 40;
            this.dataGridViewItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ID,
            this.PCODE,
            this.DESCRIPTION,
            this.TYPE,
            this.PRICE,
            this.EDIT,
            this.DELETE});
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
            this.dataGridViewItems.Location = new System.Drawing.Point(0, 116);
            this.dataGridViewItems.Name = "dataGridViewItems";
            this.dataGridViewItems.RowHeadersVisible = false;
            this.dataGridViewItems.RowHeadersWidth = 51;
            this.dataGridViewItems.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewItems.RowTemplate.Height = 29;
            this.dataGridViewItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewItems.Size = new System.Drawing.Size(1315, 814);
            this.dataGridViewItems.TabIndex = 2;
            this.dataGridViewItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "#";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 51;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 125;
            // 
            // PCODE
            // 
            this.PCODE.HeaderText = "PCODE";
            this.PCODE.MinimumWidth = 6;
            this.PCODE.Name = "PCODE";
            this.PCODE.Width = 125;
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.MinimumWidth = 6;
            this.DESCRIPTION.Name = "DESCRIPTION";
            // 
            // TYPE
            // 
            this.TYPE.HeaderText = "TYPE";
            this.TYPE.MinimumWidth = 6;
            this.TYPE.Name = "TYPE";
            this.TYPE.Width = 125;
            // 
            // PRICE
            // 
            this.PRICE.HeaderText = "PRICE";
            this.PRICE.MinimumWidth = 6;
            this.PRICE.Name = "PRICE";
            this.PRICE.Width = 125;
            // 
            // EDIT
            // 
            this.EDIT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EDIT.HeaderText = "";
            this.EDIT.Image = global::Capstone.Properties.Resources.Edit;
            this.EDIT.MinimumWidth = 6;
            this.EDIT.Name = "EDIT";
            this.EDIT.Width = 24;
            // 
            // DELETE
            // 
            this.DELETE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DELETE.HeaderText = "";
            this.DELETE.Image = global::Capstone.Properties.Resources.Delete;
            this.DELETE.MinimumWidth = 6;
            this.DELETE.Name = "DELETE";
            this.DELETE.Width = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DimGray;
            this.panel2.Controls.Add(this.txtSearchTransHist);
            this.panel2.Controls.Add(this.btnAddFrame);
            this.panel2.Controls.Add(this.btnAddLense);
            this.panel2.Controls.Add(this.btnAddAccessories);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1315, 63);
            this.panel2.TabIndex = 36;
            // 
            // txtSearchTransHist
            // 
            this.txtSearchTransHist.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearchTransHist.Location = new System.Drawing.Point(12, 14);
            this.txtSearchTransHist.Name = "txtSearchTransHist";
            this.txtSearchTransHist.PlaceholderText = "Search Here";
            this.txtSearchTransHist.Size = new System.Drawing.Size(534, 38);
            this.txtSearchTransHist.TabIndex = 0;
            // 
            // frmItemsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 930);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewItems);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmItemsList";
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewItems)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridViewItems;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnAddAccessories;
        private Button btnAddFrame;
        private Button btnAddLense;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn PCODE;
        private DataGridViewTextBoxColumn DESCRIPTION;
        private DataGridViewTextBoxColumn TYPE;
        private DataGridViewTextBoxColumn PRICE;
        private DataGridViewImageColumn EDIT;
        private DataGridViewImageColumn DELETE;
        private Panel panel2;
        private TextBox txtSearchTransHist;
    }
}