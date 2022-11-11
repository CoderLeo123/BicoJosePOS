namespace Capstone
{
    partial class frmSettlePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettlePayment));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCloseSettlePayment = new System.Windows.Forms.PictureBox();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.labelTot = new System.Windows.Forms.Label();
            this.labelPay = new System.Windows.Forms.Label();
            this.labelCH = new System.Windows.Forms.Label();
            this.comBoxPaymentTerms = new System.Windows.Forms.ComboBox();
            this.labelPT = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblLeastDeposit = new System.Windows.Forms.Label();
            this.lblNewTransactionSet = new System.Windows.Forms.Label();
            this.lblCheckSettleBalance = new System.Windows.Forms.Label();
            this.lblServRowCount = new System.Windows.Forms.Label();
            this.lblDPercent = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblGrossTotal = new System.Windows.Forms.Label();
            this.labelBal = new System.Windows.Forms.Label();
            this.txtRemBalances = new System.Windows.Forms.TextBox();
            this.lblRowCount = new System.Windows.Forms.Label();
            this.lblPaymentNotice = new System.Windows.Forms.Label();
            this.lblTransacNo = new System.Windows.Forms.Label();
            this.panelDepositDueDate = new System.Windows.Forms.Panel();
            this.dateTimePickerDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblChangeDueDate = new System.Windows.Forms.Label();
            this.labelDueDate = new System.Windows.Forms.Label();
            this.lblCashier = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.comBoxMethodPayment = new System.Windows.Forms.ComboBox();
            this.labelPM = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnReceiptPreview = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btnTwoH = new System.Windows.Forms.Button();
            this.btnTwenty = new System.Windows.Forms.Button();
            this.btnFifty = new System.Windows.Forms.Button();
            this.btnFiveH = new System.Windows.Forms.Button();
            this.btnOneH = new System.Windows.Forms.Button();
            this.btnThousand = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnDoubleZero = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocumentBalance = new System.Drawing.Printing.PrintDocument();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSettlePayment)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelDepositDueDate.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnCloseSettlePayment);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 66);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 45);
            this.label5.TabIndex = 4;
            this.label5.Text = "Settle Payment";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnCloseSettlePayment
            // 
            this.btnCloseSettlePayment.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseSettlePayment.BackgroundImage = global::Capstone.Properties.Resources.CloseTab;
            this.btnCloseSettlePayment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCloseSettlePayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseSettlePayment.Location = new System.Drawing.Point(487, 12);
            this.btnCloseSettlePayment.Name = "btnCloseSettlePayment";
            this.btnCloseSettlePayment.Padding = new System.Windows.Forms.Padding(3);
            this.btnCloseSettlePayment.Size = new System.Drawing.Size(40, 38);
            this.btnCloseSettlePayment.TabIndex = 0;
            this.btnCloseSettlePayment.TabStop = false;
            this.btnCloseSettlePayment.Click += new System.EventHandler(this.btnCloseDiscount_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSeven.FlatAppearance.BorderSize = 0;
            this.btnSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeven.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeven.ForeColor = System.Drawing.Color.White;
            this.btnSeven.Location = new System.Drawing.Point(32, 86);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(54, 63);
            this.btnSeven.TabIndex = 0;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEight.FlatAppearance.BorderSize = 0;
            this.btnEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEight.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEight.ForeColor = System.Drawing.Color.White;
            this.btnEight.Location = new System.Drawing.Point(93, 86);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(54, 63);
            this.btnEight.TabIndex = 1;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNine.FlatAppearance.BorderSize = 0;
            this.btnNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNine.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNine.ForeColor = System.Drawing.Color.White;
            this.btnNine.Location = new System.Drawing.Point(153, 86);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(54, 63);
            this.btnNine.TabIndex = 2;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(213, 86);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 63);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTotal.Location = new System.Drawing.Point(277, 107);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PlaceholderText = "0.00";
            this.txtTotal.Size = new System.Drawing.Size(220, 43);
            this.txtTotal.TabIndex = 0;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPayment
            // 
            this.txtPayment.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPayment.Location = new System.Drawing.Point(277, 156);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.PlaceholderText = "0.00";
            this.txtPayment.Size = new System.Drawing.Size(220, 43);
            this.txtPayment.TabIndex = 1;
            this.txtPayment.Text = "0";
            this.txtPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            this.txtPayment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPayment_KeyPress);
            this.txtPayment.Leave += new System.EventHandler(this.txtPayment_Leave);
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtChange.Location = new System.Drawing.Point(277, 233);
            this.txtChange.Name = "txtChange";
            this.txtChange.PlaceholderText = "0.00";
            this.txtChange.Size = new System.Drawing.Size(220, 43);
            this.txtChange.TabIndex = 2;
            this.txtChange.Text = "0";
            this.txtChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelTot
            // 
            this.labelTot.AutoSize = true;
            this.labelTot.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTot.Location = new System.Drawing.Point(12, 112);
            this.labelTot.Name = "labelTot";
            this.labelTot.Size = new System.Drawing.Size(83, 38);
            this.labelTot.TabIndex = 3;
            this.labelTot.Text = "Total ";
            // 
            // labelPay
            // 
            this.labelPay.AutoSize = true;
            this.labelPay.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPay.Location = new System.Drawing.Point(12, 159);
            this.labelPay.Name = "labelPay";
            this.labelPay.Size = new System.Drawing.Size(124, 38);
            this.labelPay.TabIndex = 4;
            this.labelPay.Text = "Payment";
            // 
            // labelCH
            // 
            this.labelCH.AutoSize = true;
            this.labelCH.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCH.Location = new System.Drawing.Point(12, 233);
            this.labelCH.Name = "labelCH";
            this.labelCH.Size = new System.Drawing.Size(111, 38);
            this.labelCH.TabIndex = 5;
            this.labelCH.Text = "Change";
            // 
            // comBoxPaymentTerms
            // 
            this.comBoxPaymentTerms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxPaymentTerms.FormattingEnabled = true;
            this.comBoxPaymentTerms.Items.AddRange(new object[] {
            "Full",
            "Deposit"});
            this.comBoxPaymentTerms.Location = new System.Drawing.Point(277, 17);
            this.comBoxPaymentTerms.Name = "comBoxPaymentTerms";
            this.comBoxPaymentTerms.Size = new System.Drawing.Size(220, 39);
            this.comBoxPaymentTerms.TabIndex = 7;
            this.comBoxPaymentTerms.SelectedIndexChanged += new System.EventHandler(this.comBoxPaymentTerms_SelectedIndexChanged);
            // 
            // labelPT
            // 
            this.labelPT.AutoSize = true;
            this.labelPT.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPT.Location = new System.Drawing.Point(12, 15);
            this.labelPT.Name = "labelPT";
            this.labelPT.Size = new System.Drawing.Size(205, 38);
            this.labelPT.TabIndex = 6;
            this.labelPT.Text = "Payment Terms";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblLeastDeposit);
            this.panel1.Controls.Add(this.lblNewTransactionSet);
            this.panel1.Controls.Add(this.lblCheckSettleBalance);
            this.panel1.Controls.Add(this.lblServRowCount);
            this.panel1.Controls.Add(this.lblDPercent);
            this.panel1.Controls.Add(this.lblDiscount);
            this.panel1.Controls.Add(this.lblGrossTotal);
            this.panel1.Controls.Add(this.labelBal);
            this.panel1.Controls.Add(this.txtRemBalances);
            this.panel1.Controls.Add(this.lblRowCount);
            this.panel1.Controls.Add(this.lblPaymentNotice);
            this.panel1.Controls.Add(this.lblTransacNo);
            this.panel1.Controls.Add(this.panelDepositDueDate);
            this.panel1.Controls.Add(this.lblCashier);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Controls.Add(this.comBoxMethodPayment);
            this.panel1.Controls.Add(this.labelPM);
            this.panel1.Controls.Add(this.comBoxPaymentTerms);
            this.panel1.Controls.Add(this.labelPT);
            this.panel1.Controls.Add(this.labelCH);
            this.panel1.Controls.Add(this.labelTot);
            this.panel1.Controls.Add(this.labelPay);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.txtPayment);
            this.panel1.Controls.Add(this.txtChange);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 488);
            this.panel1.TabIndex = 31;
            // 
            // lblLeastDeposit
            // 
            this.lblLeastDeposit.AutoSize = true;
            this.lblLeastDeposit.ForeColor = System.Drawing.Color.Red;
            this.lblLeastDeposit.Location = new System.Drawing.Point(501, 296);
            this.lblLeastDeposit.Name = "lblLeastDeposit";
            this.lblLeastDeposit.Size = new System.Drawing.Size(26, 31);
            this.lblLeastDeposit.TabIndex = 28;
            this.lblLeastDeposit.Text = "0";
            this.lblLeastDeposit.Visible = false;
            // 
            // lblNewTransactionSet
            // 
            this.lblNewTransactionSet.AutoSize = true;
            this.lblNewTransactionSet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblNewTransactionSet.Location = new System.Drawing.Point(272, 20);
            this.lblNewTransactionSet.Name = "lblNewTransactionSet";
            this.lblNewTransactionSet.Size = new System.Drawing.Size(26, 31);
            this.lblNewTransactionSet.TabIndex = 27;
            this.lblNewTransactionSet.Text = "0";
            this.lblNewTransactionSet.Visible = false;
            // 
            // lblCheckSettleBalance
            // 
            this.lblCheckSettleBalance.AutoSize = true;
            this.lblCheckSettleBalance.ForeColor = System.Drawing.Color.Red;
            this.lblCheckSettleBalance.Location = new System.Drawing.Point(503, 168);
            this.lblCheckSettleBalance.Name = "lblCheckSettleBalance";
            this.lblCheckSettleBalance.Size = new System.Drawing.Size(26, 31);
            this.lblCheckSettleBalance.TabIndex = 26;
            this.lblCheckSettleBalance.Text = "0";
            this.lblCheckSettleBalance.Visible = false;
            // 
            // lblServRowCount
            // 
            this.lblServRowCount.AutoSize = true;
            this.lblServRowCount.ForeColor = System.Drawing.Color.Red;
            this.lblServRowCount.Location = new System.Drawing.Point(503, 119);
            this.lblServRowCount.Name = "lblServRowCount";
            this.lblServRowCount.Size = new System.Drawing.Size(26, 31);
            this.lblServRowCount.TabIndex = 25;
            this.lblServRowCount.Text = "0";
            this.lblServRowCount.Visible = false;
            // 
            // lblDPercent
            // 
            this.lblDPercent.AutoSize = true;
            this.lblDPercent.ForeColor = System.Drawing.Color.Red;
            this.lblDPercent.Location = new System.Drawing.Point(153, 299);
            this.lblDPercent.Name = "lblDPercent";
            this.lblDPercent.Size = new System.Drawing.Size(32, 31);
            this.lblDPercent.TabIndex = 24;
            this.lblDPercent.Text = "--";
            this.lblDPercent.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.ForeColor = System.Drawing.Color.Red;
            this.lblDiscount.Location = new System.Drawing.Point(153, 264);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(104, 31);
            this.lblDiscount.TabIndex = 23;
            this.lblDiscount.Text = "Discount";
            this.lblDiscount.Visible = false;
            // 
            // lblGrossTotal
            // 
            this.lblGrossTotal.AutoSize = true;
            this.lblGrossTotal.ForeColor = System.Drawing.Color.Red;
            this.lblGrossTotal.Location = new System.Drawing.Point(153, 233);
            this.lblGrossTotal.Name = "lblGrossTotal";
            this.lblGrossTotal.Size = new System.Drawing.Size(71, 31);
            this.lblGrossTotal.TabIndex = 22;
            this.lblGrossTotal.Text = "Gross";
            this.lblGrossTotal.Visible = false;
            // 
            // labelBal
            // 
            this.labelBal.AutoSize = true;
            this.labelBal.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBal.Location = new System.Drawing.Point(12, 282);
            this.labelBal.Name = "labelBal";
            this.labelBal.Size = new System.Drawing.Size(112, 38);
            this.labelBal.TabIndex = 21;
            this.labelBal.Text = "Balance";
            // 
            // txtRemBalances
            // 
            this.txtRemBalances.Enabled = false;
            this.txtRemBalances.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtRemBalances.Location = new System.Drawing.Point(278, 284);
            this.txtRemBalances.Name = "txtRemBalances";
            this.txtRemBalances.PlaceholderText = "0.00";
            this.txtRemBalances.Size = new System.Drawing.Size(220, 43);
            this.txtRemBalances.TabIndex = 20;
            this.txtRemBalances.Text = "0";
            this.txtRemBalances.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.ForeColor = System.Drawing.Color.Red;
            this.lblRowCount.Location = new System.Drawing.Point(503, 70);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(26, 31);
            this.lblRowCount.TabIndex = 19;
            this.lblRowCount.Text = "0";
            this.lblRowCount.Visible = false;
            // 
            // lblPaymentNotice
            // 
            this.lblPaymentNotice.AutoSize = true;
            this.lblPaymentNotice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentNotice.ForeColor = System.Drawing.Color.Red;
            this.lblPaymentNotice.Location = new System.Drawing.Point(18, 205);
            this.lblPaymentNotice.Name = "lblPaymentNotice";
            this.lblPaymentNotice.Size = new System.Drawing.Size(150, 28);
            this.lblPaymentNotice.TabIndex = 18;
            this.lblPaymentNotice.Text = "Payment Notice";
            this.lblPaymentNotice.Visible = false;
            // 
            // lblTransacNo
            // 
            this.lblTransacNo.AutoSize = true;
            this.lblTransacNo.ForeColor = System.Drawing.Color.Red;
            this.lblTransacNo.Location = new System.Drawing.Point(503, 25);
            this.lblTransacNo.Name = "lblTransacNo";
            this.lblTransacNo.Size = new System.Drawing.Size(24, 31);
            this.lblTransacNo.TabIndex = 17;
            this.lblTransacNo.Text = "*";
            this.lblTransacNo.Visible = false;
            // 
            // panelDepositDueDate
            // 
            this.panelDepositDueDate.Controls.Add(this.dateTimePickerDueDate);
            this.panelDepositDueDate.Controls.Add(this.lblChangeDueDate);
            this.panelDepositDueDate.Controls.Add(this.labelDueDate);
            this.panelDepositDueDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDepositDueDate.Location = new System.Drawing.Point(0, 333);
            this.panelDepositDueDate.Name = "panelDepositDueDate";
            this.panelDepositDueDate.Size = new System.Drawing.Size(539, 155);
            this.panelDepositDueDate.TabIndex = 16;
            this.panelDepositDueDate.Visible = false;
            // 
            // dateTimePickerDueDate
            // 
            this.dateTimePickerDueDate.Enabled = false;
            this.dateTimePickerDueDate.Location = new System.Drawing.Point(158, 13);
            this.dateTimePickerDueDate.Name = "dateTimePickerDueDate";
            this.dateTimePickerDueDate.Size = new System.Drawing.Size(366, 38);
            this.dateTimePickerDueDate.TabIndex = 13;
            this.dateTimePickerDueDate.ValueChanged += new System.EventHandler(this.dateTimePickerDueDate_ValueChanged);
            this.dateTimePickerDueDate.Leave += new System.EventHandler(this.dateTimePickerDueDate_Leave);
            // 
            // lblChangeDueDate
            // 
            this.lblChangeDueDate.AutoSize = true;
            this.lblChangeDueDate.ForeColor = System.Drawing.Color.Red;
            this.lblChangeDueDate.Location = new System.Drawing.Point(30, 51);
            this.lblChangeDueDate.Name = "lblChangeDueDate";
            this.lblChangeDueDate.Size = new System.Drawing.Size(492, 124);
            this.lblChangeDueDate.TabIndex = 14;
            this.lblChangeDueDate.Text = "By default, the due date for balance settlement\r\n is 2 days prior to Transaction " +
    "Date. \r\nTo change to date C͟L͟I͟C͟K͟ H͟E͟R͟E͟\r\n\r\n";
            this.lblChangeDueDate.Visible = false;
            this.lblChangeDueDate.Click += new System.EventHandler(this.lblChangeDueDate_Click);
            // 
            // labelDueDate
            // 
            this.labelDueDate.AutoSize = true;
            this.labelDueDate.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDueDate.Location = new System.Drawing.Point(18, 13);
            this.labelDueDate.Name = "labelDueDate";
            this.labelDueDate.Size = new System.Drawing.Size(134, 38);
            this.labelDueDate.TabIndex = 15;
            this.labelDueDate.Text = "Due Date";
            // 
            // lblCashier
            // 
            this.lblCashier.AutoSize = true;
            this.lblCashier.ForeColor = System.Drawing.Color.Red;
            this.lblCashier.Location = new System.Drawing.Point(147, 168);
            this.lblCashier.Name = "lblCashier";
            this.lblCashier.Size = new System.Drawing.Size(89, 31);
            this.lblCashier.TabIndex = 12;
            this.lblCashier.Text = "Cashier";
            this.lblCashier.Visible = false;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.ForeColor = System.Drawing.Color.Black;
            this.lblCustomer.Location = new System.Drawing.Point(263, 289);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(75, 31);
            this.lblCustomer.TabIndex = 11;
            this.lblCustomer.Text = "Name";
            this.lblCustomer.Visible = false;
            // 
            // comBoxMethodPayment
            // 
            this.comBoxMethodPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBoxMethodPayment.FormattingEnabled = true;
            this.comBoxMethodPayment.Items.AddRange(new object[] {
            "Cash",
            "Gcash"});
            this.comBoxMethodPayment.Location = new System.Drawing.Point(278, 62);
            this.comBoxMethodPayment.Name = "comBoxMethodPayment";
            this.comBoxMethodPayment.Size = new System.Drawing.Size(220, 39);
            this.comBoxMethodPayment.TabIndex = 10;
            // 
            // labelPM
            // 
            this.labelPM.AutoSize = true;
            this.labelPM.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPM.Location = new System.Drawing.Point(12, 63);
            this.labelPM.Name = "labelPM";
            this.labelPM.Size = new System.Drawing.Size(262, 38);
            this.labelPM.TabIndex = 9;
            this.labelPM.Text = "Method of Payment";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.btnReceiptPreview);
            this.panel4.Controls.Add(this.btnBackSpace);
            this.panel4.Controls.Add(this.btnTwoH);
            this.panel4.Controls.Add(this.btnTwenty);
            this.panel4.Controls.Add(this.btnFifty);
            this.panel4.Controls.Add(this.btnFiveH);
            this.panel4.Controls.Add(this.btnOneH);
            this.panel4.Controls.Add(this.btnThousand);
            this.panel4.Controls.Add(this.btnEnter);
            this.panel4.Controls.Add(this.btnDoubleZero);
            this.panel4.Controls.Add(this.btnTwo);
            this.panel4.Controls.Add(this.btnThree);
            this.panel4.Controls.Add(this.btnOne);
            this.panel4.Controls.Add(this.btnZero);
            this.panel4.Controls.Add(this.btnFive);
            this.panel4.Controls.Add(this.btnSix);
            this.panel4.Controls.Add(this.btnFour);
            this.panel4.Controls.Add(this.btnClear);
            this.panel4.Controls.Add(this.btnEight);
            this.panel4.Controls.Add(this.btnNine);
            this.panel4.Controls.Add(this.btnSeven);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 554);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(539, 297);
            this.panel4.TabIndex = 32;
            // 
            // btnReceiptPreview
            // 
            this.btnReceiptPreview.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReceiptPreview.FlatAppearance.BorderSize = 0;
            this.btnReceiptPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiptPreview.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReceiptPreview.ForeColor = System.Drawing.Color.White;
            this.btnReceiptPreview.Location = new System.Drawing.Point(272, 154);
            this.btnReceiptPreview.Name = "btnReceiptPreview";
            this.btnReceiptPreview.Size = new System.Drawing.Size(116, 62);
            this.btnReceiptPreview.TabIndex = 20;
            this.btnReceiptPreview.Text = "Preview";
            this.btnReceiptPreview.UseVisualStyleBackColor = false;
            this.btnReceiptPreview.Click += new System.EventHandler(this.btnReceiptPreview_Click);
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBackSpace.FlatAppearance.BorderSize = 0;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackSpace.ForeColor = System.Drawing.Color.White;
            this.btnBackSpace.Location = new System.Drawing.Point(394, 154);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(116, 62);
            this.btnBackSpace.TabIndex = 19;
            this.btnBackSpace.Text = "◄";
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // btnTwoH
            // 
            this.btnTwoH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTwoH.FlatAppearance.BorderSize = 0;
            this.btnTwoH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwoH.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTwoH.ForeColor = System.Drawing.Color.White;
            this.btnTwoH.Location = new System.Drawing.Point(272, 18);
            this.btnTwoH.Name = "btnTwoH";
            this.btnTwoH.Size = new System.Drawing.Size(116, 62);
            this.btnTwoH.TabIndex = 18;
            this.btnTwoH.Text = "200";
            this.btnTwoH.UseVisualStyleBackColor = false;
            this.btnTwoH.Click += new System.EventHandler(this.btnTwoH_Click);
            // 
            // btnTwenty
            // 
            this.btnTwenty.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTwenty.FlatAppearance.BorderSize = 0;
            this.btnTwenty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwenty.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTwenty.ForeColor = System.Drawing.Color.White;
            this.btnTwenty.Location = new System.Drawing.Point(394, 86);
            this.btnTwenty.Name = "btnTwenty";
            this.btnTwenty.Size = new System.Drawing.Size(116, 62);
            this.btnTwenty.TabIndex = 17;
            this.btnTwenty.Text = "20";
            this.btnTwenty.UseVisualStyleBackColor = false;
            this.btnTwenty.Click += new System.EventHandler(this.btnTwenty_Click);
            // 
            // btnFifty
            // 
            this.btnFifty.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFifty.FlatAppearance.BorderSize = 0;
            this.btnFifty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFifty.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFifty.ForeColor = System.Drawing.Color.White;
            this.btnFifty.Location = new System.Drawing.Point(272, 87);
            this.btnFifty.Name = "btnFifty";
            this.btnFifty.Size = new System.Drawing.Size(116, 62);
            this.btnFifty.TabIndex = 16;
            this.btnFifty.Text = "50";
            this.btnFifty.UseVisualStyleBackColor = false;
            this.btnFifty.Click += new System.EventHandler(this.btnFifty_Click);
            // 
            // btnFiveH
            // 
            this.btnFiveH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFiveH.FlatAppearance.BorderSize = 0;
            this.btnFiveH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiveH.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFiveH.ForeColor = System.Drawing.Color.White;
            this.btnFiveH.Location = new System.Drawing.Point(153, 18);
            this.btnFiveH.Name = "btnFiveH";
            this.btnFiveH.Size = new System.Drawing.Size(113, 62);
            this.btnFiveH.TabIndex = 14;
            this.btnFiveH.Text = "500";
            this.btnFiveH.UseVisualStyleBackColor = false;
            this.btnFiveH.Click += new System.EventHandler(this.btnFiveH_Click);
            // 
            // btnOneH
            // 
            this.btnOneH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOneH.FlatAppearance.BorderSize = 0;
            this.btnOneH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneH.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOneH.ForeColor = System.Drawing.Color.White;
            this.btnOneH.Location = new System.Drawing.Point(394, 18);
            this.btnOneH.Name = "btnOneH";
            this.btnOneH.Size = new System.Drawing.Size(116, 62);
            this.btnOneH.TabIndex = 15;
            this.btnOneH.Text = "100";
            this.btnOneH.UseVisualStyleBackColor = false;
            this.btnOneH.Click += new System.EventHandler(this.btnOneH_Click);
            // 
            // btnThousand
            // 
            this.btnThousand.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThousand.FlatAppearance.BorderSize = 0;
            this.btnThousand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThousand.Font = new System.Drawing.Font("Segoe UI Semibold", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThousand.ForeColor = System.Drawing.Color.White;
            this.btnThousand.Location = new System.Drawing.Point(32, 18);
            this.btnThousand.Name = "btnThousand";
            this.btnThousand.Size = new System.Drawing.Size(115, 62);
            this.btnThousand.TabIndex = 13;
            this.btnThousand.Text = "1000";
            this.btnThousand.UseVisualStyleBackColor = false;
            this.btnThousand.Click += new System.EventHandler(this.btnThousand_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEnter.FlatAppearance.BorderSize = 0;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEnter.ForeColor = System.Drawing.Color.White;
            this.btnEnter.Location = new System.Drawing.Point(272, 222);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(238, 66);
            this.btnEnter.TabIndex = 12;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btnDoubleZero
            // 
            this.btnDoubleZero.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDoubleZero.FlatAppearance.BorderSize = 0;
            this.btnDoubleZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoubleZero.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDoubleZero.ForeColor = System.Drawing.Color.White;
            this.btnDoubleZero.Location = new System.Drawing.Point(213, 224);
            this.btnDoubleZero.Name = "btnDoubleZero";
            this.btnDoubleZero.Size = new System.Drawing.Size(54, 63);
            this.btnDoubleZero.TabIndex = 11;
            this.btnDoubleZero.Text = "00";
            this.btnDoubleZero.UseVisualStyleBackColor = false;
            this.btnDoubleZero.Click += new System.EventHandler(this.btnDoubleZero_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTwo.FlatAppearance.BorderSize = 0;
            this.btnTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTwo.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTwo.ForeColor = System.Drawing.Color.White;
            this.btnTwo.Location = new System.Drawing.Point(93, 224);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(54, 63);
            this.btnTwo.TabIndex = 9;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThree.FlatAppearance.BorderSize = 0;
            this.btnThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThree.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThree.ForeColor = System.Drawing.Color.White;
            this.btnThree.Location = new System.Drawing.Point(153, 224);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(54, 63);
            this.btnThree.TabIndex = 10;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOne.FlatAppearance.BorderSize = 0;
            this.btnOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOne.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOne.ForeColor = System.Drawing.Color.White;
            this.btnOne.Location = new System.Drawing.Point(32, 224);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(54, 63);
            this.btnOne.TabIndex = 8;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnZero.FlatAppearance.BorderSize = 0;
            this.btnZero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZero.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnZero.ForeColor = System.Drawing.Color.White;
            this.btnZero.Location = new System.Drawing.Point(213, 155);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(54, 63);
            this.btnZero.TabIndex = 7;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFive.FlatAppearance.BorderSize = 0;
            this.btnFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFive.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFive.ForeColor = System.Drawing.Color.White;
            this.btnFive.Location = new System.Drawing.Point(93, 155);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(54, 63);
            this.btnFive.TabIndex = 5;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSix.FlatAppearance.BorderSize = 0;
            this.btnSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSix.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSix.ForeColor = System.Drawing.Color.White;
            this.btnSix.Location = new System.Drawing.Point(153, 155);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(54, 63);
            this.btnSix.TabIndex = 6;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnFour.FlatAppearance.BorderSize = 0;
            this.btnFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFour.Font = new System.Drawing.Font("Segoe UI Semibold", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFour.ForeColor = System.Drawing.Color.White;
            this.btnFour.Location = new System.Drawing.Point(32, 155);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(54, 63);
            this.btnFour.TabIndex = 4;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // printDocument
            // 
            this.printDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_PrintPage);
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // printDocumentBalance
            // 
            this.printDocumentBalance.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentBalance_PrintPage);
            // 
            // frmSettlePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 851);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmSettlePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSettlePayment";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCloseSettlePayment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelDepositDueDate.ResumeLayout(false);
            this.panelDepositDueDate.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel2;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private PictureBox btnCloseSettlePayment;
        private Label label5;
        private Panel panel4;
        private Button btnEnter;
        private Button btnDoubleZero;
        private Button btnTwo;
        private Button btnThree;
        private Button btnOne;
        private Button btnZero;
        private Button btnFive;
        private Button btnSix;
        private Button btnFour;
        public ComboBox comBoxPaymentTerms;
        public TextBox txtChange;
        public TextBox txtPayment;
        public TextBox txtTotal;
        public Button btnClear;
        public ComboBox comBoxMethodPayment;
        private Button btnTwoH;
        private Button btnTwenty;
        public Button btnFifty;
        private Button btnFiveH;
        private Button btnOneH;
        private Button btnThousand;
        public Label lblCustomer;
        public Label lblCashier;
        public Label lblChangeDueDate;
        private Button btnBackSpace;
        public Panel panelDepositDueDate;
        public Label lblTransacNo;
        private Label lblPaymentNotice;
        private Button btnReceiptPreview;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintDialog printDialog;
        public PrintPreviewDialog printPreviewDialog;
        public Label lblRowCount;
        public TextBox txtRemBalances;
        public Label lblDPercent;
        public Label lblDiscount;
        public Label lblGrossTotal;
        public Label lblServRowCount;
        public Label labelPT;
        public Label labelCH;
        public Label labelPay;
        public Label labelTot;
        public Label labelPM;
        public Label labelBal;
        public Label labelDueDate;
        public DateTimePicker dateTimePickerDueDate;
        public Label lblCheckSettleBalance;
        private System.Drawing.Printing.PrintDocument printDocumentBalance;
        public Panel panel1;
        public Label lblNewTransactionSet;
        public Label lblLeastDeposit;
    }
}