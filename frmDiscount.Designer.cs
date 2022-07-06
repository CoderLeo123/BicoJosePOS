namespace Capstone
{
    partial class frmDiscount
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
            this.btnConfirmDiscount = new System.Windows.Forms.Button();
            this.txtDiscountedAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseDiscount = new System.Windows.Forms.PictureBox();
            this.txtPriceDiscount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmDiscount
            // 
            this.btnConfirmDiscount.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConfirmDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmDiscount.FlatAppearance.BorderSize = 0;
            this.btnConfirmDiscount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmDiscount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConfirmDiscount.ForeColor = System.Drawing.Color.White;
            this.btnConfirmDiscount.Location = new System.Drawing.Point(200, 250);
            this.btnConfirmDiscount.Name = "btnConfirmDiscount";
            this.btnConfirmDiscount.Size = new System.Drawing.Size(153, 49);
            this.btnConfirmDiscount.TabIndex = 33;
            this.btnConfirmDiscount.Text = "Confirm";
            this.btnConfirmDiscount.UseVisualStyleBackColor = false;
            // 
            // txtDiscountedAmount
            // 
            this.txtDiscountedAmount.Enabled = false;
            this.txtDiscountedAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiscountedAmount.Location = new System.Drawing.Point(260, 194);
            this.txtDiscountedAmount.Name = "txtDiscountedAmount";
            this.txtDiscountedAmount.PlaceholderText = "0.00";
            this.txtDiscountedAmount.Size = new System.Drawing.Size(256, 38);
            this.txtDiscountedAmount.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(31, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 38);
            this.label2.TabIndex = 31;
            this.label2.Text = "Discount Amount";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCloseDiscount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(543, 57);
            this.panel1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Discount";
            // 
            // btnCloseDiscount
            // 
            this.btnCloseDiscount.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseDiscount.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnCloseDiscount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseDiscount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseDiscount.Location = new System.Drawing.Point(491, 12);
            this.btnCloseDiscount.Name = "btnCloseDiscount";
            this.btnCloseDiscount.Padding = new System.Windows.Forms.Padding(3);
            this.btnCloseDiscount.Size = new System.Drawing.Size(40, 38);
            this.btnCloseDiscount.TabIndex = 0;
            this.btnCloseDiscount.TabStop = false;
            this.btnCloseDiscount.Click += new System.EventHandler(this.btnCloseDiscount_Click);
            // 
            // txtPriceDiscount
            // 
            this.txtPriceDiscount.Enabled = false;
            this.txtPriceDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPriceDiscount.Location = new System.Drawing.Point(260, 88);
            this.txtPriceDiscount.Name = "txtPriceDiscount";
            this.txtPriceDiscount.PlaceholderText = "0.00";
            this.txtPriceDiscount.Size = new System.Drawing.Size(256, 34);
            this.txtPriceDiscount.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(31, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 38);
            this.label5.TabIndex = 36;
            this.label5.Text = "Price";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiscount.Location = new System.Drawing.Point(260, 137);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PlaceholderText = "0.00";
            this.txtDiscount.Size = new System.Drawing.Size(256, 38);
            this.txtDiscount.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 38);
            this.label3.TabIndex = 34;
            this.label3.Text = "Discount(%)";
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 324);
            this.Controls.Add(this.btnConfirmDiscount);
            this.Controls.Add(this.txtDiscountedAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtPriceDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDiscount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnConfirmDiscount;
        private TextBox txtDiscountedAmount;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox btnCloseDiscount;
        private TextBox txtPriceDiscount;
        private Label label5;
        private TextBox txtDiscount;
        private Label label3;
    }
}