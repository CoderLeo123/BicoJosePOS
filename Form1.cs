using System.Data.SqlClient;

namespace Capstone
{
    public partial class frmAdmin : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        ClassInventory classInvent = new ClassInventory();
        ClassReports classReport = new ClassReports();
        ClassLoginAndSignUp classLoginMethod = new ClassLoginAndSignUp();
        ClassPaymentOrderMonitoring classLoad = new ClassPaymentOrderMonitoring();
        Boolean isCollapsed1, isCollapsed2, isCollapsed3 = true;
        frmReports frmR = new frmReports();
        int row = 0;
        public frmAdmin()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            Stock();
            Users();
            Payment();
            Order();
            frmLogin frmL = new frmLogin();
            frmL.Hide();
            stockBlinkNotify();

            //frmR.dateSelect(frmR.dataGridViewInitial);
            //classReport.loadSalesPerDay(frmR.dataGridViewSalesR, "Total_Sale");
            //classReport.loadSalesPerDay(frmR.dataGridViewBalR, "Total_Bal");
        }
        public void Stock()
        {
            cn = new SqlConnection(dbcon.MyConnection());            
            int StockLevel = 0;
            int CriticalCount = 0;
            int outOfStockCount = 0;
            int safetyStockCount = 0;
            int reOrderStockCount = 0;
            int ExpStockCount = 0;
            cn.Open();
                SqlCommand cm = new SqlCommand("SELECT Stock_Level FROM tblItem WHERE Lense_Check = 1 Order by Item_ID", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {                                      
                    StockLevel = int.Parse(dr[0].ToString());                    
                    if (StockLevel == 3)
                    {
                        outOfStockCount++;                    
                    }
                    else if (StockLevel == 2)
                    {
                        CriticalCount++;
                    }
                    else if (StockLevel == 1)
                    {
                        reOrderStockCount++;
                    }
                    else if (StockLevel == 0)
                    {
                        safetyStockCount++;
                    }
                }
                dr.Close();
                cn.Close();
            //lblAvailableStock.Text = safetyStockCount.ToString();
            //lblCriticalStock.Text = CriticalCount.ToString();
            //lblOutOfStock.Text = outOfStockCount.ToString();
            //lblReOrder.Text = reOrderStockCount.ToString();

            txtAvailStock.Text = safetyStockCount.ToString();
            txtCrit.Text = CriticalCount.ToString();
            txtOutOStk.Text = outOfStockCount.ToString();
            txtReOrd.Text = reOrderStockCount.ToString();
        }
        public void stockBlinkNotify()
        {
            //blinkLabel(lblCriticalStock, lblCritBlink);
            //blinkLabel(lblReOrder, lblReOrBlink);
            //blinkLabel(lblOutOfStock, lblOofStkBlink);
            //blinkLabel(lblPendingPay, lblPendingBlink);
            //blinkLabel(lblInLab, lblInLabBlink);

            //blinkLabel2(txtAvailStock, Color.LightGreen);
            blinkLabel2(txtCrit, Color.Yellow);
            blinkLabel2(txtOutOStk, Color.Red);
            blinkLabel2(txtReOrd, Color.Orange);
            blinkLabel2(txtExp, Color.MediumVioletRed);

            blinkLabel2(txtInLab, Color.Orange);
            //blinkLabel2(txtClaimed, Color.LightGreen);
            blinkLabel2(txtArrv, Color.Red);

            blinkLabel2(txtPendi, Color.Red);
            //blinkLabel2(txtSett, Color.LightGreen);

        }
        //public async void blinkLabel(Label labelStock, Label labelBlink, Color color)
        //{
        //    bool blink = false;
        //    int stockC = int.Parse(labelStock.Text);
        //    if (stockC > 0)
        //    {
        //        blink = true;
        //        while (blink)
        //        {
        //            await Task.Delay(500);
        //            labelBlink.BackColor = labelBlink.BackColor == color ? Color.White : Color.Red;
        //        }
        //    }
        //    else
        //    {
        //        blink = false;
        //    }
        //}
        public async void blinkLabel2(TextBox labelBlink, Color color)
        {
            bool blink = false;
            int stockC = int.Parse(labelBlink.Text);
            if (stockC > 0)
            {
                blink = true;
                while (blink)
                {
                    await Task.Delay(500);
                    labelBlink.BackColor = labelBlink.BackColor == color ? Color.White : color;
                }
            }
            else
            {
                blink = false;
            }
        }
        public void Payment()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            string status = "";
            int pendingCount = 0;
            int settledCount = 0;
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Status FROM tblPaymentStatus Order by Num", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {               
                status = dr[0].ToString();             
                if (status.Equals("Pending"))
                {
                    pendingCount++;
                }
                else if (status.Equals("Settled"))
                {
                    settledCount++;
                }                
                txtPendi.Text = pendingCount.ToString();
                txtSett.Text = settledCount.ToString();                
            }
            dr.Close();
            cn.Close();
        }
        public void Order()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            string status = "";
            int claimedCount = 0;
            int inLabCount = 0;
            int arrivedCount = 0;
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT Status FROM tblOrderStatus Order by Num", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                status = dr[0].ToString();
                if (status.Equals("In The Lab"))
                {
                    inLabCount++;
                }
                else if (status.Equals("Claimed"))
                {
                    claimedCount++;
                }
                else if (status.Equals("Arrived"))
                {
                    arrivedCount++;
                }
                txtInLab.Text = inLabCount.ToString();
                txtClaimed.Text = claimedCount.ToString();
                txtArrv.Text = arrivedCount.ToString();
            }
            dr.Close();
            cn.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void dropBtnProducts_Click(object sender, EventArgs e)
        {
            
        }

        private void timerDrpBtnPayment_Tick(object sender, EventArgs e)
        {
            //if (isCollapsed2)
            //{
            //    dropBtnPayment.Image = Properties.Resources.Down_Arrow;
            //    dropPanelPayment.Height += 10;
            //    if (dropPanelPayment.Size == dropPanelPayment.MaximumSize)
            //    {
            //        timerDrpBtnPayment.Stop();
            //        isCollapsed2 = false;
            //    }
            //}
            //else
            //{
            //    dropBtnPayment.Image = Properties.Resources.payment;
            //    dropPanelPayment.Height -= 10;
            //    if (dropPanelPayment.Size == dropPanelPayment.MinimumSize)
            //    {
            //        timerDrpBtnPayment.Stop();
            //        isCollapsed2 = true;
            //    }
            //}
        }

        private void dropBtnPayment_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dropPanelPayment.Size = dropPanelPayment.MinimumSize;
            //dropPanelProducts.Size = dropPanelProducts.MinimumSize;
            //dropPanelSales.Size = dropPanelSales.MinimumSize;
            
        }

        private void timerDrpBtnSales_Tick(object sender, EventArgs e)
        {
            //if (isCollapsed3)
            //{
            //    dropBtnReports.Image = Properties.Resources.Down_Arrow;
            //    dropPanelSales.Height += 10;
            //    if (dropPanelSales.Size == dropPanelSales.MaximumSize)
            //    {
            //        timerDrpBtnSales.Stop();
            //        isCollapsed3 = false;
            //    }
            //}
            //else
            //{
            //    dropBtnReports.Image = Properties.Resources.Sales_Report;
            //    dropPanelSales.Height -= 10;
            //    if (dropPanelSales.Size == dropPanelSales.MinimumSize)
            //    {
            //        timerDrpBtnSales.Stop();
            //        isCollapsed3 = true;
            //    }
            //}
        }

        

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {//btnSalesReport
            
        }
        public void btnCollapsed()
        {
            //isCollapsed2 = false;
            //isCollapsed3 = false;
            //isCollapsed1 = false;
            
        }
        public void timerStart()
        {
            //timerDrpBtnPayment.Start(); 
            //timerDrpBtnSales.Start();
            //timerDrpBtnProducts.Start();
        }
       
        private void dropBtnSales_Click_1(object sender, EventArgs e)
        {//isCollapsed3
            frmReports frm = new frmReports();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
            frm.lblCashier.Text = lblName.Text;

            frm.tabControlReports.TabPages.Clear();
            TabPage tab = new TabPage("Sales Report");
            frm.tabControlReports.TabPages.Add(tab);
            tab.Controls.Add(frm.panelSaleRep);
            frmR.checkWhatIsPress(true, false, false, false);
            classReport.loadSalesPerDay(frm.dataGridViewSalesR, "Total_Sale");
            classReport.loadSalesPerDay(frm.dataGridViewBalR, "Total_Bal");
            frmR.dateSelect(frm.dataGridViewInitial);
            //frmR.dateSelect(frmR.dataGridViewInitial, out row);
            //frmR.filterDate(row);
            frmR.changeDatePriorCurrent(frmR.dateTimePickerStartSold);            
            frmR.changeDatePriorCurrent(frmR.dateTimePickerStartTrans);
            classLoadData.LoadRecordsTransacHist(frmR.dataGridViewTransHist, frmR.txtSearchTransHist, frmR.dateTimePickerStartTrans, frmR.dateTimePickerEndTrans);
            classLoadData.LoadRecordsSoldItems(frmR.dataGridViewSoldItems, frmR.txtSearchSold, frmR.dateTimePickerStartSold, frmR.dateTimePickerEndSold);
            classLoadData.LoadRecordsTransacSettled(frmR.dataGridViewSettle, frmR.txtSearchSettleds, frmR.dateTimePickerSettStart, frmR.dateTimePickerSettEnd);
            frm.pesoPaint = true;
            //frmR.lblCheckCell.Text = frmR.dataGridViewInitial.Rows[0].Cells[1].Value?.ToString();
            //frm.tabControlReports.TabPages.Clear();
            TabPage tab4 = new TabPage("Check");
            frm.tabControlReports.TabPages.Add(tab4);
            tab4.Controls.Add(frm.dataGridViewInitial);

            frm.Show();

            //isCollapsed3 = true;
            //isCollapsed2 = false;
            //isCollapsed1 = false;
            //timerStart();
        }
        private void dropBtnPayment_Click_1(object sender, EventArgs e)
        {//isCollapsed2
            //isCollapsed2 = true;
            //isCollapsed3 = false;
            //isCollapsed1 = false;
            //timerStart();

            frmPaymentStatus frm = new frmPaymentStatus();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
            frm.lblUser.Text = lblName.Text;
            frm.Show();
            frm.tabControlPayOrdStatus.TabPages.Clear();
            TabPage tab = new TabPage("Payment Status");
            frm.tabControlPayOrdStatus.TabPages.Add(tab);
            tab.Controls.Add(frm.panelPayment);
            classLoad.LoadRecordsSettled(frm.dataGridViewSettled, frm.txtSearchSettled);
            classLoad.LoadRecordsUnsettled(frm.dataGridViewPaymentStat, frm.txtSearchPending);
        }

        private void dropBtnProducts_Click_1(object sender, EventArgs e)
        {//isCollapsed1
            isCollapsed1 = true;
            isCollapsed2 = false;
            isCollapsed3 = false;
            
            //timerStart();

            frmProductsList frm = new frmProductsList();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            //btnCollapsed();
            //timerStart();
            Stock();
            Users();
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(panelDashboard);
        }

        private void btnPatientR_Click(object sender, EventArgs e)
        {
            frmPatientRecord frm = new frmPatientRecord();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
            //btnCollapsed();
            //timerStart();
        }

        private void button25_Click(object sender, EventArgs e)
        {//btnPayStatus
            //frmPaymentStatus frm = new frmPaymentStatus();
            //frm.TopLevel = false;
            //panelLoad.Controls.Clear();
            //panelLoad.Controls.Add(frm);
            //frm.BringToFront();
            //frm.Show();
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            //frmOrderStatus frm = new frmOrderStatus();
            //frm.TopLevel = false;
            //panelLoad.Controls.Clear();
            //panelLoad.Controls.Add(frm);
            //frm.BringToFront();
            //frm.Show();
        }

        private void btnTranscHist_Click(object sender, EventArgs e)
        {
            //frmTransactionHistory frm = new frmTransactionHistory();
            //frm.TopLevel = false;
            //panelLoad.Controls.Clear();
            //panelLoad.Controls.Add(frm);
            //frm.BringToFront();
            //frm.Show();
            //btnCollapsed();
            //timerStart();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            //frmProductsList frm = new frmProductsList();
            //frm.TopLevel = false;
            //panelLoad.Controls.Clear();
            //panelLoad.Controls.Add(frm);
            //frm.BringToFront();
            //frm.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            //frmItemsList frm = new frmItemsList();
            //frm.TopLevel = false;
            //panelLoad.Controls.Clear();
            //panelLoad.Controls.Add(frm);
            //frm.BringToFront();
            //frm.Show();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            //frmCashier frm = new frmCashier();
            //frm.ShowDialog();
        }

        private void btnStockDel_Click(object sender, EventArgs e)
        {
            frmStockIn frm = new frmStockIn();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.txtStockInBy.Text = lblName.Text;
            frm.BringToFront();
            frm.Show();
            //btnCollapsed();
            //timerStart();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            frmInventory frm = new frmInventory();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();

            frm.tabControlInventory.TabPages.Clear();
            TabPage tab = new TabPage("SAFETY LEVEL");
            frm.tabControlInventory.TabPages.Add(tab);
            tab.Controls.Add(frm.panelSafety);
            classInvent.LoadSafety(frm.dataGridViewSafety, frm.txtSearchSafety);
            frm.checkWhatIsPress(false, false, false, false, true);
            //btnCollapsed();
            //timerStart();
        }

        private void btnInventoryReport_Click(object sender, EventArgs e)
        {            
        }

        private void btnBackupArch_Click(object sender, EventArgs e)
        {
            //btnCollapsed();
            //timerStart();
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            frmUserSetting frm = new frmUserSetting();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
            
            frm.tabControlUser.TabPages.Clear();
            TabPage tab = new TabPage("LOGIN SESSION");
            frm.tabControlUser.TabPages.Add(tab);
            tab.Controls.Add(frm.panelSession);

            frm.checkWhatIsPress(false, true);
            frm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStockDetails_Click(object sender, EventArgs e)
        {
            //frmDashboardDetails frm = new frmDashboardDetails();
            
            //frm.tabControlDashboardDetails.TabPages.Clear();
            //TabPage tab = new TabPage("Critical");
            //frm.tabControlDashboardDetails.TabPages.Add(tab);
            //tab.Controls.Add(frm.panelCritical);
            //TabPage tab2 = new TabPage("Out of Stock");
            //frm.tabControlDashboardDetails.TabPages.Add(tab2);
            
            //tab2.Controls.Add(frm.panelOutOfStock);
            //frm.LoadUsers();
            
            //frm.LoadCriticalStock();
            //frm.LoadOutOfStock();
            //frm.ShowDialog();
        }
        public void Users()
        {
            
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            //dataGridViewUsers.Rows.Clear();
            string role = "";
            int adminCount = 0;
            int cashierCount = 0;
            int MasterCount = 0;
            int totalUsers = 0;
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT User_Type FROM tblUser Order by Num", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //                                          2-ROLE / 2-User_Type       
                i += 1; //          0-#  1-NAME / 1-Name           
                //dataGridViewUsers.Rows.Add(i, dr[4].ToString(), dr[5].ToString());
                role = dr[0].ToString();
                totalUsers++;
                if (role.Equals("Admin"))
                {
                    adminCount++;
                }
                else if (role.Equals("Cashier"))
                {
                    cashierCount++;
                }
                else if (role.Equals("Master"))
                {
                    MasterCount++;
                }
                lblAdmin.Text = adminCount.ToString();
                lblCashier.Text = cashierCount.ToString();
                lblMasterCount.Text = MasterCount.ToString();
                lblTotalUsers.Text = totalUsers.ToString();

            }
            dr.Close();
            cn.Close();
        }
        private void btnUsersDetails_Click(object sender, EventArgs e)
        {
            //frmDashboardDetails frm = new frmDashboardDetails();
            //frm.tabControlDashboardDetails.TabPages.Clear();
            //TabPage tab = new TabPage("USER INFO");
            //frm.tabControlDashboardDetails.TabPages.Add(tab);
            //tab.Controls.Add(frm.panelUsers);
            //frm.LoadUsers();
            //frm.ShowDialog();
        }

        private void btnCategoryDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            string ID = lblUserNum.Text;
            string loginTime = DateTime.Now.ToString();
            classLoginMethod.insertLogOutDateTime(ID, loginTime);
            this.Dispose(); this.Close();
            
            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void panelDashboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAvailStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            //btnMaxi.BackColor = Color.Lime;
            if (btnMaxi.BackColor == Color.Lime)
            {
                this.WindowState = FormWindowState.Normal;
                panelDas.Dock = DockStyle.Fill;
                btnMaxi.BackColor = Color.Red;
            }
            else if (btnMaxi.BackColor == Color.Red)
            {
                this.WindowState = FormWindowState.Maximized;
                btnMaxi.BackColor = Color.Lime;
                panelDas.Dock = DockStyle.Right;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)//btnCashier
        {
             this.Dispose(); this.Close();
           
            frmCashier frm = new frmCashier();
            frm.lblUserNum.Text = lblUserNum.Text;
            frm.ShowDialog();
        }

        

        private void timerDrpBtnProducts_Tick(object sender, EventArgs e)
        {
            if (isCollapsed1)
            {
                dropBtnProducts.Image = Properties.Resources.Down_Arrow;
                dropPanelProducts.Height += 10;
                if (dropPanelProducts.Size == dropPanelProducts.MaximumSize)
                {
                    timerDrpBtnProducts.Stop();
                    isCollapsed1 = false;
                }
            }
            else
            {
                dropBtnProducts.Image = Properties.Resources.ProdItemServ;
                dropPanelProducts.Height -= 10;
                if (dropPanelProducts.Size == dropPanelProducts.MinimumSize)
                {
                    timerDrpBtnProducts.Stop();
                    isCollapsed1 = true;
                }
            }

        }


    }
}