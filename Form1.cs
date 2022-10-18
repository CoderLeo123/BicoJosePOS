using System.Data.SqlClient;

namespace Capstone
{
    public partial class frmAdmin : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        Boolean isCollapsed1, isCollapsed2, isCollapsed3 = true;
        
        public frmAdmin()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            Stock();
            Users();
            frmLogin frmL = new frmLogin();
            frmL.Hide(); 
        }
        public void Stock()
        {
            
            //dataGridViewProduct, txtSearchProduct
                cn = new SqlConnection(dbcon.MyConnection());
                int i = 0;
            int StockTotal = 0;
            int CriticalCount = 0;
            int outOfStockCount = 0;
            int dataPass = 0;
                cn.Open();
                SqlCommand cm = new SqlCommand("SELECT Quantity FROM tblItem WHERE Lense_Check = 1 Order by Item_ID", cn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    //                     2-PATIENT NAME / 2-Customer_Name       4-CONTACT / 4-Contact             6-GENDER / 6-Gender 
                    i += 1; //0-#  1-PATIENT ID / 1-Patient_ID         3-ADDRESS / 3-Address                 5-AGE / 5-Age                   7-CHECK-UP DATE / 7-Check_Up_Date 
                StockTotal += int.Parse(dr[0].ToString());
                dataPass = int.Parse(dr[0].ToString());
                if (dataPass < 3 && dataPass > 0)
                {
                    CriticalCount++;
                }else if (dataPass == 0)
                {
                    outOfStockCount++;
                }

                }
                dr.Close();
                cn.Close();


            lblAvailableStock.Text = StockTotal.ToString();
            lblCriticalStock.Text = CriticalCount.ToString();
            lblOutOfStock.Text = outOfStockCount.ToString();

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
            if (isCollapsed2)
            {
                dropBtnPayment.Image = Properties.Resources.Down_Arrow;
                dropPanelPayment.Height += 10;
                if (dropPanelPayment.Size == dropPanelPayment.MaximumSize)
                {
                    timerDrpBtnPayment.Stop();
                    isCollapsed2 = false;
                }
            }
            else
            {
                dropBtnPayment.Image = Properties.Resources.payment;
                dropPanelPayment.Height -= 10;
                if (dropPanelPayment.Size == dropPanelPayment.MinimumSize)
                {
                    timerDrpBtnPayment.Stop();
                    isCollapsed2 = true;
                }
            }
        }

        private void dropBtnPayment_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dropPanelPayment.Size = dropPanelPayment.MinimumSize;
            dropPanelProducts.Size = dropPanelProducts.MinimumSize;
            dropPanelSales.Size = dropPanelSales.MinimumSize;
            
        }

        private void timerDrpBtnSales_Tick(object sender, EventArgs e)
        {
            if (isCollapsed3)
            {
                dropBtnReports.Image = Properties.Resources.Down_Arrow;
                dropPanelSales.Height += 10;
                if (dropPanelSales.Size == dropPanelSales.MaximumSize)
                {
                    timerDrpBtnSales.Stop();
                    isCollapsed3 = false;
                }
            }
            else
            {
                dropBtnReports.Image = Properties.Resources.Sales_Report;
                dropPanelSales.Height -= 10;
                if (dropPanelSales.Size == dropPanelSales.MinimumSize)
                {
                    timerDrpBtnSales.Stop();
                    isCollapsed3 = true;
                }
            }
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
            isCollapsed2 = false;
            isCollapsed3 = false;
            isCollapsed1 = false;
            
        }
        public void timerStart()
        {
            timerDrpBtnPayment.Start(); 
            timerDrpBtnSales.Start();
            timerDrpBtnProducts.Start();
        }
       
        private void dropBtnSales_Click_1(object sender, EventArgs e)
        {//isCollapsed3
            frmReports frm = new frmReports();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
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
            frm.Show();
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
            frm.Show();
            //btnCollapsed();
            //timerStart();
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
            frmDashboardDetails frm = new frmDashboardDetails();
            
            frm.tabControlDashboardDetails.TabPages.Clear();
            TabPage tab = new TabPage("Critical");
            frm.tabControlDashboardDetails.TabPages.Add(tab);
            tab.Controls.Add(frm.panelCritical);
            TabPage tab2 = new TabPage("Out of Stock");
            frm.tabControlDashboardDetails.TabPages.Add(tab2);
            
            tab2.Controls.Add(frm.panelOutOfStock);
            frm.LoadUsers();
            
            frm.LoadCriticalStock();
            frm.LoadOutOfStock();
            frm.ShowDialog();
        }
        public void Users()
        {
            
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            //dataGridViewUsers.Rows.Clear();
            string role = "";
            int adminCount = 0;
            int cashierCount = 0;
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
                }else if (role.Equals("Cashier"))
                {
                    cashierCount++;
                }
                lblAdmin.Text = adminCount.ToString();
                lblCashier.Text = cashierCount.ToString();
                lblTotalUsers.Text = totalUsers.ToString();

            }
            dr.Close();
            cn.Close();
        }
        private void btnUsersDetails_Click(object sender, EventArgs e)
        {
            frmDashboardDetails frm = new frmDashboardDetails();
            frm.tabControlDashboardDetails.TabPages.Clear();
            TabPage tab = new TabPage("USER INFO");
            frm.tabControlDashboardDetails.TabPages.Add(tab);
            tab.Controls.Add(frm.panelUsers);
            frm.LoadUsers();
            frm.ShowDialog();
        }

        private void btnCategoryDetails_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Dispose(); this.Close();

            frmLogin frm = new frmLogin();
            frm.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)//btnCashier
        {
             this.Dispose(); this.Close();
           
            frmCashier frm = new frmCashier();
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