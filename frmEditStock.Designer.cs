namespace Capstone
{
    partial class frmEditStock
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dateExpiration = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPerishable = new System.Windows.Forms.Button();
            this.btnNonPerishable = new System.Windows.Forms.Button();
            this.lblCheck = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 57);
            this.panel1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Edit Stock";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(674, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(3);
            this.btnClose.Size = new System.Drawing.Size(40, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtQuantity.Location = new System.Drawing.Point(258, 232);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PlaceholderText = "0";
            this.txtQuantity.Size = new System.Drawing.Size(199, 38);
            this.txtQuantity.TabIndex = 42;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(41, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 41);
            this.label4.TabIndex = 41;
            this.label4.Text = "Quantity";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(417, 289);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(153, 49);
            this.btnCancel.TabIndex = 38;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(258, 289);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(153, 49);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dateExpiration
            // 
            this.dateExpiration.Location = new System.Drawing.Point(258, 103);
            this.dateExpiration.Name = "dateExpiration";
            this.dateExpiration.Size = new System.Drawing.Size(423, 43);
            this.dateExpiration.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(205, 38);
            this.label6.TabIndex = 43;
            this.label6.Text = "Expiration Date";
            // 
            // btnPerishable
            // 
            this.btnPerishable.BackColor = System.Drawing.Color.LimeGreen;
            this.btnPerishable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerishable.FlatAppearance.BorderSize = 0;
            this.btnPerishable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerishable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPerishable.ForeColor = System.Drawing.Color.White;
            this.btnPerishable.Location = new System.Drawing.Point(258, 163);
            this.btnPerishable.Name = "btnPerishable";
            this.btnPerishable.Size = new System.Drawing.Size(153, 49);
            this.btnPerishable.TabIndex = 45;
            this.btnPerishable.Text = "Perishable";
            this.btnPerishable.UseVisualStyleBackColor = false;
            this.btnPerishable.Click += new System.EventHandler(this.btnPerishable_Click);
            // 
            // btnNonPerishable
            // 
            this.btnNonPerishable.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNonPerishable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNonPerishable.FlatAppearance.BorderSize = 0;
            this.btnNonPerishable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNonPerishable.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNonPerishable.ForeColor = System.Drawing.Color.White;
            this.btnNonPerishable.Location = new System.Drawing.Point(429, 163);
            this.btnNonPerishable.Name = "btnNonPerishable";
            this.btnNonPerishable.Size = new System.Drawing.Size(202, 49);
            this.btnNonPerishable.TabIndex = 46;
            this.btnNonPerishable.Text = "Non-Perishable";
            this.btnNonPerishable.UseVisualStyleBackColor = false;
            this.btnNonPerishable.Click += new System.EventHandler(this.btnNonPerishable_Click);
            // 
            // lblCheck
            // 
            this.lblCheck.AutoSize = true;
            this.lblCheck.Location = new System.Drawing.Point(41, 167);
            this.lblCheck.Name = "lblCheck";
            this.lblCheck.Size = new System.Drawing.Size(81, 38);
            this.lblCheck.TabIndex = 47;
            this.lblCheck.Text = "        ";
            this.lblCheck.Visible = false;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(41, 289);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(81, 38);
            this.lblID.TabIndex = 48;
            this.lblID.Text = "        ";
            this.lblID.Visible = false;
            // 
            // frmEditStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 369);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCheck);
            this.Controls.Add(this.btnNonPerishable);
            this.Controls.Add(this.btnPerishable);
            this.Controls.Add(this.dateExpiration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmEditStock";
            this.Text = "frmEditStock";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnClose;
        public TextBox txtQuantity;
        private Label label4;
        private Button btnCancel;
        public Button btnUpdate;
        public DateTimePicker dateExpiration;
        private Label label6;
        public Button btnPerishable;
        public Button btnNonPerishable;
        private Label lblCheck;
        public Label lblID;
    }
}