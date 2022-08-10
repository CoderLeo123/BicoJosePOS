namespace Capstone
{
    partial class frmAddAccessories
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
            this.btnCancelAccessories = new System.Windows.Forms.Button();
            this.btnUpdateAccessories = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseAccessories = new System.Windows.Forms.PictureBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.GenerateID = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAccessories)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelAccessories
            // 
            this.btnCancelAccessories.BackColor = System.Drawing.Color.Red;
            this.btnCancelAccessories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAccessories.FlatAppearance.BorderSize = 0;
            this.btnCancelAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAccessories.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelAccessories.ForeColor = System.Drawing.Color.White;
            this.btnCancelAccessories.Location = new System.Drawing.Point(354, 425);
            this.btnCancelAccessories.Name = "btnCancelAccessories";
            this.btnCancelAccessories.Size = new System.Drawing.Size(153, 49);
            this.btnCancelAccessories.TabIndex = 23;
            this.btnCancelAccessories.Text = "Cancel";
            this.btnCancelAccessories.UseVisualStyleBackColor = false;
            this.btnCancelAccessories.Click += new System.EventHandler(this.btnCancelAccessories_Click);
            // 
            // btnUpdateAccessories
            // 
            this.btnUpdateAccessories.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnUpdateAccessories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateAccessories.Enabled = false;
            this.btnUpdateAccessories.FlatAppearance.BorderSize = 0;
            this.btnUpdateAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateAccessories.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateAccessories.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAccessories.Location = new System.Drawing.Point(195, 425);
            this.btnUpdateAccessories.Name = "btnUpdateAccessories";
            this.btnUpdateAccessories.Size = new System.Drawing.Size(153, 49);
            this.btnUpdateAccessories.TabIndex = 22;
            this.btnUpdateAccessories.Text = "Update";
            this.btnUpdateAccessories.UseVisualStyleBackColor = false;
            this.btnUpdateAccessories.Click += new System.EventHandler(this.btnUpdateAccessories_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(36, 425);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(153, 49);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSaveAccessories_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPrice.Location = new System.Drawing.Point(237, 206);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PlaceholderText = "0.00";
            this.txtPrice.Size = new System.Drawing.Size(256, 38);
            this.txtPrice.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 38);
            this.label2.TabIndex = 19;
            this.label2.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseAccessories);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 57);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Accessories";
            // 
            // btnCloseAccessories
            // 
            this.btnCloseAccessories.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseAccessories.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnCloseAccessories.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseAccessories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseAccessories.Location = new System.Drawing.Point(763, 9);
            this.btnCloseAccessories.Name = "btnCloseAccessories";
            this.btnCloseAccessories.Padding = new System.Windows.Forms.Padding(3);
            this.btnCloseAccessories.Size = new System.Drawing.Size(40, 38);
            this.btnCloseAccessories.TabIndex = 0;
            this.btnCloseAccessories.TabStop = false;
            this.btnCloseAccessories.Click += new System.EventHandler(this.btnCloseAccessories_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescription.Location = new System.Drawing.Point(237, 149);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Ex. Eyeglass Cleaning Solution Spray Bottle 50ml";
            this.txtDescription.Size = new System.Drawing.Size(566, 38);
            this.txtDescription.TabIndex = 25;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 38);
            this.label3.TabIndex = 24;
            this.label3.Text = "Description";
            // 
            // comBoxType
            // 
            this.comBoxType.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxType.FormattingEnabled = true;
            this.comBoxType.Location = new System.Drawing.Point(237, 266);
            this.comBoxType.Name = "comBoxType";
            this.comBoxType.Size = new System.Drawing.Size(256, 39);
            this.comBoxType.TabIndex = 26;
            this.comBoxType.SelectedIndexChanged += new System.EventHandler(this.comBoxTypeAccessories_SelectedIndexChanged);
            this.comBoxType.TextChanged += new System.EventHandler(this.comBoxTypeAccessories_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 38);
            this.label4.TabIndex = 27;
            this.label4.Text = "Type";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtID.Location = new System.Drawing.Point(237, 96);
            this.txtID.Name = "txtID";
            this.txtID.PlaceholderText = "ITM0001";
            this.txtID.Size = new System.Drawing.Size(256, 38);
            this.txtID.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 38);
            this.label5.TabIndex = 28;
            this.label5.Text = "Item ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 316);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 38);
            this.label6.TabIndex = 32;
            this.label6.Text = "Product";
            // 
            // txtProductID
            // 
            this.txtProductID.Enabled = false;
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProductID.Location = new System.Drawing.Point(237, 372);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.PlaceholderText = "P0001";
            this.txtProductID.Size = new System.Drawing.Size(256, 38);
            this.txtProductID.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(31, 370);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 38);
            this.label7.TabIndex = 33;
            this.label7.Text = "Product ID";
            // 
            // txtProduct
            // 
            this.txtProduct.Enabled = false;
            this.txtProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtProduct.Location = new System.Drawing.Point(237, 318);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(256, 38);
            this.txtProduct.TabIndex = 35;
            // 
            // GenerateID
            // 
            this.GenerateID.AutoSize = true;
            this.GenerateID.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenerateID.LinkArea = new System.Windows.Forms.LinkArea(0, 15);
            this.GenerateID.LinkColor = System.Drawing.Color.Navy;
            this.GenerateID.Location = new System.Drawing.Point(518, 96);
            this.GenerateID.Name = "GenerateID";
            this.GenerateID.Size = new System.Drawing.Size(172, 43);
            this.GenerateID.TabIndex = 36;
            this.GenerateID.TabStop = true;
            this.GenerateID.Text = "[Generate ID]";
            this.GenerateID.UseCompatibleTextRendering = true;
            this.GenerateID.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GenerateID_LinkClicked);
            // 
            // frmAddAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 505);
            this.Controls.Add(this.GenerateID);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comBoxType);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelAccessories);
            this.Controls.Add(this.btnUpdateAccessories);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAccessories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddAccessories";
            this.Load += new System.EventHandler(this.frmAddAccessories_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAccessories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCancelAccessories;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox btnCloseAccessories;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        public LinkLabel GenerateID;
        public ComboBox comBoxType;
        public TextBox txtProductID;
        public TextBox txtProduct;
        public Button btnUpdateAccessories;
        public Button btnSave;
        public TextBox txtPrice;
        public TextBox txtDescription;
        public TextBox txtID;
    }
}