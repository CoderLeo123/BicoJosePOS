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
            this.btnSaveAccessories = new System.Windows.Forms.Button();
            this.txtPriceAccessories = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseAccessories = new System.Windows.Forms.PictureBox();
            this.txtDescAccessories = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comBoxTypeAccessories = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GeneratePCodeAccessories = new System.Windows.Forms.LinkLabel();
            this.txtPCodeAccessories = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.btnCancelAccessories.Location = new System.Drawing.Point(354, 325);
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
            this.btnUpdateAccessories.Location = new System.Drawing.Point(195, 325);
            this.btnUpdateAccessories.Name = "btnUpdateAccessories";
            this.btnUpdateAccessories.Size = new System.Drawing.Size(153, 49);
            this.btnUpdateAccessories.TabIndex = 22;
            this.btnUpdateAccessories.Text = "Update";
            this.btnUpdateAccessories.UseVisualStyleBackColor = false;
            // 
            // btnSaveAccessories
            // 
            this.btnSaveAccessories.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveAccessories.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveAccessories.FlatAppearance.BorderSize = 0;
            this.btnSaveAccessories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAccessories.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveAccessories.ForeColor = System.Drawing.Color.White;
            this.btnSaveAccessories.Location = new System.Drawing.Point(36, 325);
            this.btnSaveAccessories.Name = "btnSaveAccessories";
            this.btnSaveAccessories.Size = new System.Drawing.Size(153, 49);
            this.btnSaveAccessories.TabIndex = 21;
            this.btnSaveAccessories.Text = "Save";
            this.btnSaveAccessories.UseVisualStyleBackColor = false;
            this.btnSaveAccessories.Click += new System.EventHandler(this.btnSaveAccessories_Click);
            // 
            // txtPriceAccessories
            // 
            this.txtPriceAccessories.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPriceAccessories.Location = new System.Drawing.Point(237, 265);
            this.txtPriceAccessories.Name = "txtPriceAccessories";
            this.txtPriceAccessories.PlaceholderText = "0.00";
            this.txtPriceAccessories.Size = new System.Drawing.Size(256, 38);
            this.txtPriceAccessories.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 263);
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
            // txtDescAccessories
            // 
            this.txtDescAccessories.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescAccessories.Location = new System.Drawing.Point(237, 208);
            this.txtDescAccessories.Name = "txtDescAccessories";
            this.txtDescAccessories.PlaceholderText = "Ex. Eyeglass Cleaning Solution Spray Bottle 50ml";
            this.txtDescAccessories.Size = new System.Drawing.Size(566, 38);
            this.txtDescAccessories.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 38);
            this.label3.TabIndex = 24;
            this.label3.Text = "Description";
            // 
            // comBoxTypeAccessories
            // 
            this.comBoxTypeAccessories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxTypeAccessories.FormattingEnabled = true;
            this.comBoxTypeAccessories.Location = new System.Drawing.Point(237, 150);
            this.comBoxTypeAccessories.Name = "comBoxTypeAccessories";
            this.comBoxTypeAccessories.Size = new System.Drawing.Size(256, 36);
            this.comBoxTypeAccessories.TabIndex = 26;
            this.comBoxTypeAccessories.SelectedIndexChanged += new System.EventHandler(this.comBoxTypeAccessories_SelectedIndexChanged);
            this.comBoxTypeAccessories.TextChanged += new System.EventHandler(this.comBoxTypeAccessories_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 38);
            this.label4.TabIndex = 27;
            this.label4.Text = "Type";
            // 
            // GeneratePCodeAccessories
            // 
            this.GeneratePCodeAccessories.AutoSize = true;
            this.GeneratePCodeAccessories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GeneratePCodeAccessories.LinkColor = System.Drawing.Color.Navy;
            this.GeneratePCodeAccessories.Location = new System.Drawing.Point(518, 102);
            this.GeneratePCodeAccessories.Name = "GeneratePCodeAccessories";
            this.GeneratePCodeAccessories.Size = new System.Drawing.Size(103, 28);
            this.GeneratePCodeAccessories.TabIndex = 30;
            this.GeneratePCodeAccessories.TabStop = true;
            this.GeneratePCodeAccessories.Text = "[Generate]";
            // 
            // txtPCodeAccessories
            // 
            this.txtPCodeAccessories.Enabled = false;
            this.txtPCodeAccessories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPCodeAccessories.Location = new System.Drawing.Point(237, 96);
            this.txtPCodeAccessories.Name = "txtPCodeAccessories";
            this.txtPCodeAccessories.PlaceholderText = "P000000";
            this.txtPCodeAccessories.Size = new System.Drawing.Size(256, 34);
            this.txtPCodeAccessories.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 38);
            this.label5.TabIndex = 28;
            this.label5.Text = "Product Code";
            // 
            // frmAddAccessories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 413);
            this.Controls.Add(this.GeneratePCodeAccessories);
            this.Controls.Add(this.txtPCodeAccessories);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comBoxTypeAccessories);
            this.Controls.Add(this.txtDescAccessories);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelAccessories);
            this.Controls.Add(this.btnUpdateAccessories);
            this.Controls.Add(this.btnSaveAccessories);
            this.Controls.Add(this.txtPriceAccessories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddAccessories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddAccessories";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAccessories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnCancelAccessories;
        private Button btnUpdateAccessories;
        private Button btnSaveAccessories;
        private TextBox txtPriceAccessories;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox btnCloseAccessories;
        private TextBox txtDescAccessories;
        private Label label3;
        private ComboBox comBoxTypeAccessories;
        private Label label4;
        private LinkLabel GeneratePCodeAccessories;
        private TextBox txtPCodeAccessories;
        private Label label5;
    }
}