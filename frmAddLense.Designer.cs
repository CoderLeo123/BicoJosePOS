namespace Capstone
{
    partial class frmAddLense
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
            this.txtPriceLense = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelLense = new System.Windows.Forms.Button();
            this.btnUpdateLense = new System.Windows.Forms.Button();
            this.btnSaveLense = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseLense = new System.Windows.Forms.PictureBox();
            this.comBoxTypeLense = new System.Windows.Forms.ComboBox();
            this.checkedListFeaturesLense = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GeneratePCodeLense = new System.Windows.Forms.LinkLabel();
            this.txtIDLense = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLense)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPriceLense
            // 
            this.txtPriceLense.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPriceLense.Location = new System.Drawing.Point(241, 210);
            this.txtPriceLense.Name = "txtPriceLense";
            this.txtPriceLense.PlaceholderText = "0.00";
            this.txtPriceLense.Size = new System.Drawing.Size(347, 38);
            this.txtPriceLense.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(45, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 38);
            this.label3.TabIndex = 24;
            this.label3.Text = "Price";
            // 
            // btnCancelLense
            // 
            this.btnCancelLense.BackColor = System.Drawing.Color.Red;
            this.btnCancelLense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelLense.FlatAppearance.BorderSize = 0;
            this.btnCancelLense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelLense.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelLense.ForeColor = System.Drawing.Color.White;
            this.btnCancelLense.Location = new System.Drawing.Point(363, 489);
            this.btnCancelLense.Name = "btnCancelLense";
            this.btnCancelLense.Size = new System.Drawing.Size(153, 49);
            this.btnCancelLense.TabIndex = 23;
            this.btnCancelLense.Text = "Cancel";
            this.btnCancelLense.UseVisualStyleBackColor = false;
            this.btnCancelLense.Click += new System.EventHandler(this.btnCancelLense_Click);
            // 
            // btnUpdateLense
            // 
            this.btnUpdateLense.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdateLense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateLense.Enabled = false;
            this.btnUpdateLense.FlatAppearance.BorderSize = 0;
            this.btnUpdateLense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateLense.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnUpdateLense.ForeColor = System.Drawing.Color.White;
            this.btnUpdateLense.Location = new System.Drawing.Point(204, 489);
            this.btnUpdateLense.Name = "btnUpdateLense";
            this.btnUpdateLense.Size = new System.Drawing.Size(153, 49);
            this.btnUpdateLense.TabIndex = 22;
            this.btnUpdateLense.Text = "Update";
            this.btnUpdateLense.UseVisualStyleBackColor = false;
            // 
            // btnSaveLense
            // 
            this.btnSaveLense.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveLense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveLense.FlatAppearance.BorderSize = 0;
            this.btnSaveLense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveLense.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveLense.ForeColor = System.Drawing.Color.White;
            this.btnSaveLense.Location = new System.Drawing.Point(45, 489);
            this.btnSaveLense.Name = "btnSaveLense";
            this.btnSaveLense.Size = new System.Drawing.Size(153, 49);
            this.btnSaveLense.TabIndex = 21;
            this.btnSaveLense.Text = "Save";
            this.btnSaveLense.UseVisualStyleBackColor = false;
            this.btnSaveLense.Click += new System.EventHandler(this.btnSaveLense_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 38);
            this.label2.TabIndex = 19;
            this.label2.Text = "Type of Lense";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseLense);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 57);
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
            this.label1.Size = new System.Drawing.Size(222, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Eyeglass Lense";
            // 
            // btnCloseLense
            // 
            this.btnCloseLense.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseLense.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnCloseLense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseLense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseLense.Location = new System.Drawing.Point(574, 12);
            this.btnCloseLense.Name = "btnCloseLense";
            this.btnCloseLense.Padding = new System.Windows.Forms.Padding(3);
            this.btnCloseLense.Size = new System.Drawing.Size(40, 38);
            this.btnCloseLense.TabIndex = 0;
            this.btnCloseLense.TabStop = false;
            this.btnCloseLense.Click += new System.EventHandler(this.btnCloseLense_Click);
            // 
            // comBoxTypeLense
            // 
            this.comBoxTypeLense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comBoxTypeLense.FormattingEnabled = true;
            this.comBoxTypeLense.Location = new System.Drawing.Point(241, 147);
            this.comBoxTypeLense.Name = "comBoxTypeLense";
            this.comBoxTypeLense.Size = new System.Drawing.Size(347, 36);
            this.comBoxTypeLense.TabIndex = 35;
            // 
            // checkedListFeaturesLense
            // 
            this.checkedListFeaturesLense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkedListFeaturesLense.FormattingEnabled = true;
            this.checkedListFeaturesLense.Location = new System.Drawing.Point(241, 314);
            this.checkedListFeaturesLense.Name = "checkedListFeaturesLense";
            this.checkedListFeaturesLense.Size = new System.Drawing.Size(309, 149);
            this.checkedListFeaturesLense.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 38);
            this.label4.TabIndex = 37;
            this.label4.Text = "Features";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(313, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 38);
            this.label5.TabIndex = 38;
            this.label5.Text = "Description";
            // 
            // GeneratePCodeLense
            // 
            this.GeneratePCodeLense.AutoSize = true;
            this.GeneratePCodeLense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GeneratePCodeLense.LinkColor = System.Drawing.Color.Navy;
            this.GeneratePCodeLense.Location = new System.Drawing.Point(511, 102);
            this.GeneratePCodeLense.Name = "GeneratePCodeLense";
            this.GeneratePCodeLense.Size = new System.Drawing.Size(103, 28);
            this.GeneratePCodeLense.TabIndex = 41;
            this.GeneratePCodeLense.TabStop = true;
            this.GeneratePCodeLense.Text = "[Generate]";
            // 
            // txtIDLense
            // 
            this.txtIDLense.Enabled = false;
            this.txtIDLense.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtIDLense.Location = new System.Drawing.Point(241, 96);
            this.txtIDLense.Name = "txtIDLense";
            this.txtIDLense.PlaceholderText = "P000000";
            this.txtIDLense.Size = new System.Drawing.Size(256, 34);
            this.txtIDLense.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(36, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 38);
            this.label8.TabIndex = 39;
            this.label8.Text = "Product Code";
            // 
            // frmAddLense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 571);
            this.Controls.Add(this.GeneratePCodeLense);
            this.Controls.Add(this.txtIDLense);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListFeaturesLense);
            this.Controls.Add(this.comBoxTypeLense);
            this.Controls.Add(this.txtPriceLense);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelLense);
            this.Controls.Add(this.btnUpdateLense);
            this.Controls.Add(this.btnSaveLense);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddLense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddLense";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseLense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtPriceLense;
        private Label label3;
        private Button btnCancelLense;
        private Button btnUpdateLense;
        private Button btnSaveLense;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox btnCloseLense;
        private ComboBox comBoxTypeLense;
        private CheckedListBox checkedListFeaturesLense;
        private Label label4;
        private Label label5;
        private LinkLabel GeneratePCodeLense;
        private TextBox txtIDLense;
        private Label label8;
    }
}