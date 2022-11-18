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
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCashier = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblSettleTrans = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCloseAccessories = new System.Windows.Forms.PictureBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlEditOrder = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelArrived = new System.Windows.Forms.Panel();
            this.panelFill = new System.Windows.Forms.Panel();
            this.printPreviewControlArvl = new System.Windows.Forms.PrintPreviewControl();
            this.panelTop = new System.Windows.Forms.Panel();
            this.txtReceivedBy = new System.Windows.Forms.TextBox();
            this.dateTimePickerArrival = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.btnArrival = new System.Windows.Forms.Button();
            this.lblTrans = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelClaimed = new System.Windows.Forms.Panel();
            this.btnSettle = new System.Windows.Forms.Button();
            this.txtPaymentStatus = new System.Windows.Forms.TextBox();
            this.dateTimePickerClaimDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReleaseBy = new System.Windows.Forms.TextBox();
            this.lblTransNo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.printDocumentAr = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAccessories)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControlEditOrder.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelArrived.SuspendLayout();
            this.panelFill.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panelClaimed.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(763, 61);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Controls.Add(this.lblCashier);
            this.panel3.Controls.Add(this.lblBalance);
            this.panel3.Controls.Add(this.lblSettleTrans);
            this.panel3.Controls.Add(this.lblName);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.labelTitle);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(763, 61);
            this.panel3.TabIndex = 19;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseUp);
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.Location = new System.Drawing.Point(503, 9);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(108, 38);
            this.lblCashier.TabIndex = 43;
            this.lblCashier.Text = "Cashier";
            this.lblCashier.Visible = false;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(260, 12);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(112, 38);
            this.lblBalance.TabIndex = 42;
            this.lblBalance.Text = "Balance";
            this.lblBalance.Visible = false;
            // 
            // lblSettleTrans
            // 
            this.lblSettleTrans.AutoSize = true;
            this.lblSettleTrans.Location = new System.Drawing.Point(378, 12);
            this.lblSettleTrans.Name = "lblSettleTrans";
            this.lblSettleTrans.Size = new System.Drawing.Size(119, 38);
            this.lblSettleTrans.TabIndex = 41;
            this.lblSettleTrans.Text = "TransNo";
            this.lblSettleTrans.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(163, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 38);
            this.lblName.TabIndex = 40;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnCloseAccessories);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(695, 0);
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
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(100, 41);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Order";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControlEditOrder);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(763, 617);
            this.panel2.TabIndex = 1;
            // 
            // tabControlEditOrder
            // 
            this.tabControlEditOrder.Controls.Add(this.tabPage1);
            this.tabControlEditOrder.Controls.Add(this.tabPage2);
            this.tabControlEditOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlEditOrder.Location = new System.Drawing.Point(0, 0);
            this.tabControlEditOrder.Name = "tabControlEditOrder";
            this.tabControlEditOrder.SelectedIndex = 0;
            this.tabControlEditOrder.Size = new System.Drawing.Size(763, 617);
            this.tabControlEditOrder.TabIndex = 53;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelArrived);
            this.tabPage1.Location = new System.Drawing.Point(4, 46);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(755, 567);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Arrival";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelArrived
            // 
            this.panelArrived.Controls.Add(this.panelFill);
            this.panelArrived.Controls.Add(this.panelTop);
            this.panelArrived.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelArrived.Location = new System.Drawing.Point(3, 3);
            this.panelArrived.Name = "panelArrived";
            this.panelArrived.Size = new System.Drawing.Size(749, 561);
            this.panelArrived.TabIndex = 0;
            // 
            // panelFill
            // 
            this.panelFill.Controls.Add(this.printPreviewControlArvl);
            this.panelFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFill.Location = new System.Drawing.Point(0, 247);
            this.panelFill.Name = "panelFill";
            this.panelFill.Size = new System.Drawing.Size(749, 314);
            this.panelFill.TabIndex = 58;
            // 
            // printPreviewControlArvl
            // 
            this.printPreviewControlArvl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.printPreviewControlArvl.Location = new System.Drawing.Point(0, 0);
            this.printPreviewControlArvl.Name = "printPreviewControlArvl";
            this.printPreviewControlArvl.Size = new System.Drawing.Size(749, 314);
            this.printPreviewControlArvl.TabIndex = 0;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.txtReceivedBy);
            this.panelTop.Controls.Add(this.dateTimePickerArrival);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.btnArrival);
            this.panelTop.Controls.Add(this.lblTrans);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(749, 247);
            this.panelTop.TabIndex = 57;
            // 
            // txtReceivedBy
            // 
            this.txtReceivedBy.Enabled = false;
            this.txtReceivedBy.Location = new System.Drawing.Point(278, 33);
            this.txtReceivedBy.Name = "txtReceivedBy";
            this.txtReceivedBy.Size = new System.Drawing.Size(257, 43);
            this.txtReceivedBy.TabIndex = 52;
            // 
            // dateTimePickerArrival
            // 
            this.dateTimePickerArrival.Enabled = false;
            this.dateTimePickerArrival.Location = new System.Drawing.Point(278, 103);
            this.dateTimePickerArrival.Name = "dateTimePickerArrival";
            this.dateTimePickerArrival.Size = new System.Drawing.Size(423, 43);
            this.dateTimePickerArrival.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 38);
            this.label7.TabIndex = 54;
            this.label7.Text = "Received By";
            // 
            // btnArrival
            // 
            this.btnArrival.BackColor = System.Drawing.Color.LimeGreen;
            this.btnArrival.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArrival.FlatAppearance.BorderSize = 0;
            this.btnArrival.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArrival.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnArrival.ForeColor = System.Drawing.Color.White;
            this.btnArrival.Location = new System.Drawing.Point(278, 177);
            this.btnArrival.Name = "btnArrival";
            this.btnArrival.Size = new System.Drawing.Size(153, 49);
            this.btnArrival.TabIndex = 55;
            this.btnArrival.Text = "Save";
            this.btnArrival.UseVisualStyleBackColor = false;
            this.btnArrival.Click += new System.EventHandler(this.btnArrival_Click);
            // 
            // lblTrans
            // 
            this.lblTrans.AutoSize = true;
            this.lblTrans.Location = new System.Drawing.Point(555, 38);
            this.lblTrans.Name = "lblTrans";
            this.lblTrans.Size = new System.Drawing.Size(57, 38);
            this.lblTrans.TabIndex = 56;
            this.lblTrans.Text = "     ";
            this.lblTrans.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 38);
            this.label6.TabIndex = 53;
            this.label6.Text = "Arrival Date";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panelClaimed);
            this.tabPage2.Location = new System.Drawing.Point(4, 46);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 567);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Claim";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panelClaimed
            // 
            this.panelClaimed.Controls.Add(this.btnSettle);
            this.panelClaimed.Controls.Add(this.txtPaymentStatus);
            this.panelClaimed.Controls.Add(this.dateTimePickerClaimDate);
            this.panelClaimed.Controls.Add(this.label4);
            this.panelClaimed.Controls.Add(this.txtReleaseBy);
            this.panelClaimed.Controls.Add(this.lblTransNo);
            this.panelClaimed.Controls.Add(this.label2);
            this.panelClaimed.Controls.Add(this.btnSaveOrder);
            this.panelClaimed.Controls.Add(this.label3);
            this.panelClaimed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClaimed.Location = new System.Drawing.Point(3, 3);
            this.panelClaimed.Name = "panelClaimed";
            this.panelClaimed.Size = new System.Drawing.Size(749, 561);
            this.panelClaimed.TabIndex = 0;
            // 
            // btnSettle
            // 
            this.btnSettle.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSettle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSettle.Enabled = false;
            this.btnSettle.FlatAppearance.BorderSize = 0;
            this.btnSettle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettle.ForeColor = System.Drawing.Color.White;
            this.btnSettle.Location = new System.Drawing.Point(461, 253);
            this.btnSettle.Name = "btnSettle";
            this.btnSettle.Size = new System.Drawing.Size(153, 49);
            this.btnSettle.TabIndex = 53;
            this.btnSettle.Text = "Settle";
            this.btnSettle.UseVisualStyleBackColor = false;
            this.btnSettle.Click += new System.EventHandler(this.btnSettle_Click);
            // 
            // txtPaymentStatus
            // 
            this.txtPaymentStatus.Enabled = false;
            this.txtPaymentStatus.Location = new System.Drawing.Point(302, 44);
            this.txtPaymentStatus.Name = "txtPaymentStatus";
            this.txtPaymentStatus.Size = new System.Drawing.Size(257, 43);
            this.txtPaymentStatus.TabIndex = 52;
            // 
            // dateTimePickerClaimDate
            // 
            this.dateTimePickerClaimDate.Enabled = false;
            this.dateTimePickerClaimDate.Location = new System.Drawing.Point(302, 179);
            this.dateTimePickerClaimDate.Name = "dateTimePickerClaimDate";
            this.dateTimePickerClaimDate.Size = new System.Drawing.Size(423, 43);
            this.dateTimePickerClaimDate.TabIndex = 0;
            this.dateTimePickerClaimDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(237, 38);
            this.label4.TabIndex = 51;
            this.label4.Text = "Settlement status:";
            // 
            // txtReleaseBy
            // 
            this.txtReleaseBy.Enabled = false;
            this.txtReleaseBy.Location = new System.Drawing.Point(302, 109);
            this.txtReleaseBy.Name = "txtReleaseBy";
            this.txtReleaseBy.Size = new System.Drawing.Size(257, 43);
            this.txtReleaseBy.TabIndex = 1;
            this.txtReleaseBy.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblTransNo
            // 
            this.lblTransNo.AutoSize = true;
            this.lblTransNo.Location = new System.Drawing.Point(579, 114);
            this.lblTransNo.Name = "lblTransNo";
            this.lblTransNo.Size = new System.Drawing.Size(57, 38);
            this.lblTransNo.TabIndex = 50;
            this.lblTransNo.Text = "     ";
            this.lblTransNo.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Claim Date";
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.BackColor = System.Drawing.Color.LimeGreen;
            this.btnSaveOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveOrder.FlatAppearance.BorderSize = 0;
            this.btnSaveOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveOrder.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveOrder.ForeColor = System.Drawing.Color.White;
            this.btnSaveOrder.Location = new System.Drawing.Point(302, 253);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(153, 49);
            this.btnSaveOrder.TabIndex = 49;
            this.btnSaveOrder.Text = "Save";
            this.btnSaveOrder.UseVisualStyleBackColor = false;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 38);
            this.label3.TabIndex = 3;
            this.label3.Text = "Release By";
            // 
            // printDocumentAr
            // 
            this.printDocumentAr.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentAr_PrintPage);
            // 
            // frmEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 678);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmEditOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditOrder";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseAccessories)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControlEditOrder.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panelArrived.ResumeLayout(false);
            this.panelFill.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panelClaimed.ResumeLayout(false);
            this.panelClaimed.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private PictureBox btnCloseAccessories;
        private Panel panel2;
        public TextBox txtReleaseBy;
        private DateTimePicker dateTimePickerClaimDate;
        private Label label2;
        private Label label3;
        public Button btnSaveOrder;
        public Label lblTransNo;
        public TextBox txtPaymentStatus;
        private Label label4;
        private TabPage tabPage1;
        public Panel panelArrived;
        private DateTimePicker dateTimePickerArrival;
        public TextBox txtReceivedBy;
        public Label lblTrans;
        private Label label6;
        public Button btnArrival;
        private Label label7;
        private TabPage tabPage2;
        public TabControl tabControlEditOrder;
        public Panel panelClaimed;
        private Panel panelFill;
        public PrintPreviewControl printPreviewControlArvl;
        private Panel panelTop;
        private System.Drawing.Printing.PrintDocument printDocumentAr;
        public Label labelTitle;
        public Button btnSettle;
        public Label lblCashier;
        public Label lblBalance;
        public Label lblSettleTrans;
        public Label lblName;
    }
}