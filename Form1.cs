namespace Capstone
{
    public partial class frmAdmin : Form
    {
       
        Boolean isCollapsed1, isCollapsed2, isCollapsed3 = true;
        
        public frmAdmin()
        {
            InitializeComponent();
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
                dropBtnSales.Image = Properties.Resources.Down_Arrow;
                dropPanelSales.Height += 10;
                if (dropPanelSales.Size == dropPanelSales.MaximumSize)
                {
                    timerDrpBtnSales.Stop();
                    isCollapsed3 = false;
                }
            }
            else
            {
                dropBtnSales.Image = Properties.Resources.Sales_Report;
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
            btnCollapsed();
            timerStart();
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
            isCollapsed3 = true;
            isCollapsed2 = false;
            isCollapsed1 = false;
            timerStart();
        }
        private void dropBtnPayment_Click_1(object sender, EventArgs e)
        {//isCollapsed2
            isCollapsed2 = true;
            isCollapsed3 = false;
            isCollapsed1 = false;
            timerStart();
        }

        private void dropBtnProducts_Click_1(object sender, EventArgs e)
        {//isCollapsed1
            isCollapsed1 = true;
            isCollapsed2 = false;
            isCollapsed3 = false;
            
            timerStart();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            btnCollapsed();
            timerStart();
        }

        private void btnPatientR_Click(object sender, EventArgs e)
        {
            frmPatientRecord frm = new frmPatientRecord();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
            btnCollapsed();
            timerStart();
        }

        private void button25_Click(object sender, EventArgs e)
        {//btnPayStatus
            frmPaymentStatus frm = new frmPaymentStatus();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnOrderStatus_Click(object sender, EventArgs e)
        {
            frmOrderStatus frm = new frmOrderStatus();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnTranscHist_Click(object sender, EventArgs e)
        {
            frmTransactionHistory frm = new frmTransactionHistory();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
            btnCollapsed();
            timerStart();
        }

        private void btnProd_Click(object sender, EventArgs e)
        {
            frmProductsList frm = new frmProductsList();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            frmItemsList frm = new frmItemsList();
            frm.TopLevel = false;
            panelLoad.Controls.Clear();
            panelLoad.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStockDel_Click(object sender, EventArgs e)
        {
            btnCollapsed();
            timerStart();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            btnCollapsed();
            timerStart();
        }

        private void btnInventoryReport_Click(object sender, EventArgs e)
        {
            btnCollapsed();
            timerStart();
        }

        private void btnBackupArch_Click(object sender, EventArgs e)
        {
            btnCollapsed();
            timerStart();
        }

        private void btnUserSettings_Click(object sender, EventArgs e)
        {
            btnCollapsed();
            timerStart();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            btnCollapsed();
            timerStart();
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