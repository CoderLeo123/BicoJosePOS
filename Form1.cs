using System.Data.SqlClient;
using System.Data.SQLite;
namespace Capstone
{
    public partial class frmAdmin : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        ClassInventory classInvent = new ClassInventory();
        ClassReports classReport = new ClassReports();
        ClassLoginAndSignUp classLoginMethod = new ClassLoginAndSignUp();
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassPaymentOrderMonitoring classLoad = new ClassPaymentOrderMonitoring();
        Boolean isCollapsed1, isCollapsed2, isCollapsed3 = true;
        List<ExpList> SList = new List<ExpList>();
        frmReports frmR = new frmReports();
        frmDashboardDetails frmDetails = new frmDashboardDetails();
        int row = 0;
        public frmAdmin()
        {
            InitializeComponent();
            cn = new SQLiteConnection(dbcon.MyConnection);
            Stock();
            Users();
            Payment();
            Order();
            Expiration();
            frmLogin frmL = new frmLogin();
            frmL.Hide();
            stockBlinkNotify();
            //classLoginMethod.insertFirstAdmin("USR1000", "Admin", "BicoJose123", "Insert", "Name", "Master");
        }
        public void addToExpList(string stockNum, string Description, string Expiration_Date, string Quantity, string Unit_Measure)
        {
            
            cn.Open();
            cm = new SQLiteCommand("INSERT INTO tblExpList (Stock_Num, Description, Expiration_Date, Quantity, Unit_Measure) VALUES(@Stock_Num, @Description, @Expiration_Date, @Quantity, @Unit_Measure)", cn);
            cm.Parameters.AddWithValue("@Stock_Num", stockNum);
            cm.Parameters.AddWithValue("@Description", Description);
            cm.Parameters.AddWithValue("@Expiration_Date", Expiration_Date);
            cm.Parameters.AddWithValue("@Quantity", Quantity);
            cm.Parameters.AddWithValue("@Unit_Measure", Unit_Measure);            
            cm.ExecuteNonQuery();            
            cn.Close();
        }
        public void clearExpList()
        {
            cn.Open();
            cm = new SQLiteCommand("DELETE FROM tblExpList", cn);            
            cm.ExecuteNonQuery();
            cn.Close();
        }
        public void Expiration()
        {
            cn = new SQLiteConnection(dbcon.MyConnection);
            string expDate = "";
            int expiringCount = 0;
            int i = 0;
            int dateDifference = 0;
            string sNum = "", Description = "", Expiration_Date = "", Quantity = "", Unit_Measure = "";
            DateTime expDateItem;
            DateTime now = DateTime.Now;
            clearExpList();
            SList.Clear();
            
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT * FROM ViewStockItemInventory WHERE Status LIKE 'Available'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                
                expDate = dr[4].ToString();
                sNum = dr[8].ToString(); Description = dr[1].ToString(); Expiration_Date = dr[4].ToString();
                Quantity = dr[3].ToString(); Unit_Measure = dr[5].ToString();

                expDateItem = DateTime.Parse(expDate);
                dateDifference = (expDateItem.Date - now.Date).Days;

                
                if (dateDifference <= 7)
                {
                    ExpList List = new ExpList();
                    
                    expiringCount++; row++;
                    List.sNum = sNum;
                    List.Description = Description;
                    List.Expiration_Date = Expiration_Date;
                    List.Quantity = Quantity;
                    List.Unit_Measure = Unit_Measure;
                    SList.Add(List);
                
                }
                
            }
            dr.Close();
            cn.Close();
            txtExp.Text = expiringCount.ToString();
            if (expiringCount > 0)
            {
                for (int x = 0; x < expiringCount; x++)
                {
                    ExpList Itms = SList[x];
                    addToExpList(Itms.sNum, Itms.Description, Itms.Expiration_Date, Itms.Quantity, Itms.Unit_Measure);
                }
            }
            
        }
        
        public class ExpList
        {
            public string sNum { get; set; }
            public string Description { get; set; }
            public string Expiration_Date { get; set; }
            public string Quantity { get; set; }
            public string Unit_Measure { get; set; }            
        }
        public void Stock()
        {
            cn = new SQLiteConnection(dbcon.MyConnection);            
            int StockLevel = 0;
            int CriticalCount = 0;
            int outOfStockCount = 0;
            int safetyStockCount = 0;
            int reOrderStockCount = 0;
            //int ExpStockCount = 0;
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT Stock_Level FROM tblItem WHERE Lense_Check = 1 Order by Item_ID", cn);
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
            txtAvailStock.Text = safetyStockCount.ToString();
            txtCrit.Text = CriticalCount.ToString();
            txtOutOStk.Text = outOfStockCount.ToString();
            txtReOrd.Text = reOrderStockCount.ToString();
        }
        public void stockBlinkNotify()
        {           
            
            blinkLabel2(txtCrit, Color.Yellow);
            blinkLabel2(txtOutOStk, Color.Red);
            blinkLabel2(txtReOrd, Color.Orange);
            blinkLabel2(txtExp, Color.MediumVioletRed);

            blinkLabel2(txtInLab, Color.Orange);            
            blinkLabel2(txtArrv, Color.Red);
            blinkLabel2(txtPendi, Color.Red);            

        }
      
        public async void blinkLabel2(TextBox labelBlink, Color color)
        {
            bool blink = false;
            int stockC = int.Parse(labelBlink.Text);
            if (stockC > 0)
            {
                blink = true;
                while (blink)
                {
                    await Task.Delay(1000);
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
            cn = new SQLiteConnection(dbcon.MyConnection);
            string status = "";
            int pendingCount = 0;
            int settledCount = 0;
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT Status FROM tblPaymentStatus Order by Num", cn);
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
            cn = new SQLiteConnection(dbcon.MyConnection);
            string status = "";
            int claimedCount = 0;
            int inLabCount = 0;
            int arrivedCount = 0;
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT Status FROM tblOrderStatus Order by Num", cn);
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
         
        }

        private void dropBtnPayment_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void timerDrpBtnSales_Tick(object sender, EventArgs e)
        {
          
        }
        
        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button32_Click(object sender, EventArgs e)
        {
            
        }
        public void btnCollapsed()
        {
                       
        }
        public void timerStart()
        {          
        }
       
        private void dropBtnSales_Click_1(object sender, EventArgs e)
        {
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
      
            frmR.changeDatePriorCurrent(frmR.dateTimePickerStartSold);            
            frmR.changeDatePriorCurrent(frmR.dateTimePickerStartTrans);
            classLoadData.LoadRecordsTransacHist(frmR.dataGridViewTransHist, frmR.txtSearchTransHist, frmR.dateTimePickerStartTrans, frmR.dateTimePickerEndTrans);
            classLoadData.LoadRecordsSoldItems(frmR.dataGridViewSoldItems, frmR.txtSearchSold, frmR.dateTimePickerStartSold, frmR.dateTimePickerEndSold);
            classLoadData.LoadRecordsTransacSettled(frmR.dataGridViewSettle, frmR.txtSearchSettleds, frmR.dateTimePickerSettStart, frmR.dateTimePickerSettEnd);
            frm.pesoPaint = true;         
            frm.Show();

        }
        private void dropBtnPayment_Click_1(object sender, EventArgs e)
        {                  
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
            frm.lblCashier.Text = lblName.Text;
            classLoad.LoadRecordsSettled(frm.dataGridViewSettled, frm.txtSearchSettled);
            classLoad.LoadRecordsUnsettled(frm.dataGridViewPaymentStat, frm.txtSearchPending);
        }

        private void dropBtnProducts_Click_1(object sender, EventArgs e)
        {
            isCollapsed1 = true;
            isCollapsed2 = false;
            isCollapsed3 = false;       
            frmProductsList frm = new frmProductsList();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {      
            Stock();
            Users();
            Payment();
            Order();
            Expiration();
            stockBlinkNotify();
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
        }

        private void button25_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
    
        }

        private void btnTranscHist_Click(object sender, EventArgs e)
        {
        
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
    
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
          
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
         
        }

        private void btnStockDel_Click(object sender, EventArgs e)
        {
            try
            {
                frmStockIn frm = new frmStockIn();
                frm.TopLevel = false;
                panelLoad.Controls.Clear();
                panelLoad.Controls.Add(frm);
                frm.txtStockInBy.Text = lblName.Text;
                if (frm.txtStockID.Text == "0")
                {
                    classGenerateID.GenerateStockID(frm.txtStockID);
                }
                frm.BringToFront();
                frm.Show();
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "Stock Delivery btn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

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
         
        }

        private void btnInventoryReport_Click(object sender, EventArgs e)
        {            
        }

        private void btnBackupArch_Click(object sender, EventArgs e)
        {
 
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
     
        }
        public void Users()
        {            
            cn = new SQLiteConnection(dbcon.MyConnection);
            int i = 0;           
            string role = "";
            int adminCount = 0;
            int cashierCount = 0;
            int MasterCount = 0;
            int totalUsers = 0;
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT User_Type FROM tblUser Order by Num", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {                     
                i += 1;                       
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

        private void txtExp_TextChanged(object sender, EventArgs e)
        {
            int expCount = int.Parse(txtExp.Text);
            if(expCount == 0 )
            {
                btnExpList.Enabled = false;
            }
            else if (expCount > 0)
            {
                btnExpList.Enabled = true;
            }
        }

        private void btnExpList_Click(object sender, EventArgs e)
        {
            frmDashboardDetails frm = new frmDashboardDetails();
            Expiration();
            frm.LoadExpList();       
            frm.ShowDialog();
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

        }


    }
}