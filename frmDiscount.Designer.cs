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
            this.lblID = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlDiscPromo = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelDiscount = new System.Windows.Forms.Panel();
            this.panelPromo = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseDiscount)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControlDiscPromo.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelPromo.SuspendLayout();
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
            this.btnConfirmDiscount.Location = new System.Drawing.Point(209, 187);
            this.btnConfirmDiscount.Name = "btnConfirmDiscount";
            this.btnConfirmDiscount.Size = new System.Drawing.Size(153, 49);
            this.btnConfirmDiscount.TabIndex = 33;
            this.btnConfirmDiscount.Text = "Confirm";
            this.btnConfirmDiscount.UseVisualStyleBackColor = false;
            this.btnConfirmDiscount.Click += new System.EventHandler(this.btnConfirmDiscount_Click);
            // 
            // txtDiscountedAmount
            // 
            this.txtDiscountedAmount.Enabled = false;
            this.txtDiscountedAmount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiscountedAmount.Location = new System.Drawing.Point(269, 131);
            this.txtDiscountedAmount.Name = "txtDiscountedAmount";
            this.txtDiscountedAmount.PlaceholderText = "0.00";
            this.txtDiscountedAmount.Size = new System.Drawing.Size(256, 38);
            this.txtDiscountedAmount.TabIndex = 32;
            this.txtDiscountedAmount.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 38);
            this.label2.TabIndex = 31;
            this.label2.Text = "Discount Amount";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 57);
            this.panel1.TabIndex = 30;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
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
            this.btnCloseDiscount.Location = new System.Drawing.Point(3, 12);
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
            this.txtPriceDiscount.Location = new System.Drawing.Point(269, 25);
            this.txtPriceDiscount.Name = "txtPriceDiscount";
            this.txtPriceDiscount.PlaceholderText = "0.00";
            this.txtPriceDiscount.Size = new System.Drawing.Size(256, 34);
            this.txtPriceDiscount.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(30, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 38);
            this.label5.TabIndex = 36;
            this.label5.Text = "Total";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiscount.Location = new System.Drawing.Point(269, 74);
            this.txtDiscount.MaxLength = 3;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.PlaceholderText = "0.00";
            this.txtDiscount.Size = new System.Drawing.Size(256, 38);
            this.txtDiscount.TabIndex = 35;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscount_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 38);
            this.label3.TabIndex = 34;
            this.label3.Text = "Discount(%)";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(46, 201);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(65, 38);
            this.lblID.TabIndex = 38;
            this.lblID.Text = "      ";
            this.lblID.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCloseDiscount);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(537, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(55, 57);
            this.panel2.TabIndex = 5;
            // 
            // tabControlDiscPromo
            // 
            this.tabControlDiscPromo.Controls.Add(this.tabPage1);
            this.tabControlDiscPromo.Controls.Add(this.tabPage2);
            this.tabControlDiscPromo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlDiscPromo.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlDiscPromo.Location = new System.Drawing.Point(0, 57);
            this.tabControlDiscPromo.Name = "tabControlDiscPromo";
            this.tabControlDiscPromo.SelectedIndex = 0;
            this.tabControlDiscPromo.Size = new System.Drawing.Size(592, 323);
            this.tabControlDiscPromo.TabIndex = 39;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelDiscount);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 273);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Promo";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelPromo);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 273);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Discount";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelDiscount
            // 
            this.panelDiscount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDiscount.Location = new System.Drawing.Point(3, 3);
            this.panelDiscount.Name = "panelDiscount";
            this.panelDiscount.Size = new System.Drawing.Size(578, 267);
            this.panelDiscount.TabIndex = 0;
            // 
            // panelPromo
            // 
            this.panelPromo.Controls.Add(this.txtPriceDiscount);
            this.panelPromo.Controls.Add(this.lblID);
            this.panelPromo.Controls.Add(this.label3);
            this.panelPromo.Controls.Add(this.btnConfirmDiscount);
            this.panelPromo.Controls.Add(this.txtDiscount);
            this.panelPromo.Controls.Add(this.txtDiscountedAmount);
            this.panelPromo.Controls.Add(this.label5);
            this.panelPromo.Controls.Add(this.label2);
            this.panelPromo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPromo.Location = new System.Drawing.Point(3, 3);
            this.panelPromo.Name = "panelPromo";
            this.panelPromo.Size = new System.Drawing.Size(578, 267);
            this.panelPromo.TabIndex = 0;
            // 
            // frmDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 380);
            this.Controls.Add(this.tabControlDiscPromo);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDiscount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDiscount";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseDiscount)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControlDiscPromo.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panelPromo.ResumeLayout(false);
            this.panelPromo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label2;
        private Panel panel1;
        private Label label1;
        private PictureBox btnCloseDiscount;
        private Label label5;
        private Label label3;
        public Button btnConfirmDiscount;
        public TextBox txtDiscountedAmount;
        public TextBox txtPriceDiscount;
        public TextBox txtDiscount;
        public Label lblID;
        private Panel panel2;
        public TabControl tabControlDiscPromo;
        private TabPage tabPage1;
        public Panel panelDiscount;
        private TabPage tabPage2;
        public Panel panelPromo;
    }
}