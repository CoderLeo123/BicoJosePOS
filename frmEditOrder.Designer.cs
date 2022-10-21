namespace Capstone
{
    partial class frmEditOrder
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCloseAccessories = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerClaimDate = new System.Windows.Forms.DateTimePicker();
            this.txtReleaseBy = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.lblTransNo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAccessories)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 61);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblTransNo);
            this.panel2.Controls.Add(this.btnSaveOrder);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtReleaseBy);
            this.panel2.Controls.Add(this.dateTimePickerClaimDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 287);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(719, 61);
            this.panel3.TabIndex = 19;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCloseAccessories);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(651, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(68, 61);
            this.panel4.TabIndex = 39;
            // 
            // btnCloseAccessories
            // 
            this.btnCloseAccessories.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseAccessories.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnCloseAccessories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseAccessories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseAccessories.Location = new System.Drawing.Point(14, 9);
            this.btnCloseAccessories.Name = "btnCloseAccessories";
            this.btnCloseAccessories.Padding = new System.Windows.Forms.Padding(3);
            this.btnCloseAccessories.Size = new System.Drawing.Size(40, 38);
            this.btnCloseAccessories.TabIndex = 0;
            this.btnCloseAccessories.TabStop = false;
            this.btnCloseAccessories.Click += new System.EventHandler(this.btnCloseAccessories_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Claim Item";
            // 
            // dateTimePickerClaimDate
            // 
            this.dateTimePickerClaimDate.Location = new System.Drawing.Point(252, 132);
            this.dateTimePickerClaimDate.Name = "dateTimePickerClaimDate";
            this.dateTimePickerClaimDate.Size = new System.Drawing.Size(423, 43);
            this.dateTimePickerClaimDate.TabIndex = 0;
            this.dateTimePickerClaimDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtReleaseBy
            // 
            this.txtReleaseBy.Enabled = false;
            this.txtReleaseBy.Location = new System.Drawing.Point(252, 62);
            this.txtReleaseBy.Name = "txtReleaseBy";
            this.txtReleaseBy.Size = new System.Drawing.Size(257, 43);
            this.txtReleaseBy.TabIndex = 1;
            this.txtReleaseBy.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Claim Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Release By";
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveOrder.FlatAppearance.BorderSize = 0;
            this.btnSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveOrder.ForeColor = System.Drawing.Color.White;
            this.btnSaveOrder.Location = new System.Drawing.Point(252, 201);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(153, 49);
            this.btnSaveOrder.TabIndex = 49;
            this.btnSaveOrder.Text = "Save";
            this.btnSaveOrder.UseVisualStyleBackColor = false;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // lblTransNo
            // 
            this.lblTransNo.AutoSize = true;
            this.lblTransNo.Location = new System.Drawing.Point(529, 67);
            this.lblTransNo.Name = "lblTransNo";
            this.lblTransNo.Size = new System.Drawing.Size(57, 38);
            this.lblTransNo.TabIndex = 50;
            this.lblTransNo.Text = "     ";
            this.lblTransNo.Visible = false;
            // 
            // frmEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 348);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "frmEditOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditOrder";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAccessories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox btnCloseAccessories;
        private Label label1;
        private Panel panel2;
        public TextBox txtReleaseBy;
        private DateTimePicker dateTimePickerClaimDate;
        private Label label2;
        private Label label3;
        public Button btnSaveOrder;
        public Label lblTransNo;
    }
}