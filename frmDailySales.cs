﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
namespace Capstone
{
    public partial class frmDailySales : Form
    {
        SQLiteConnection cn = new SQLiteConnection();
        SQLiteCommand cm = new SQLiteCommand();
        DBConnection dbcon = new DBConnection();
        SQLiteDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        ClassReports classReport = new ClassReports();
        string title = "BICO-JOSE System", transNo = "";
        List<ItemList> List = new List<ItemList>();
        List<ServiceList> SList = new List<ServiceList>();
        List<dupliAllInfo> dupAll = new List<dupliAllInfo>();
        List<compareAllInfo> compAll = new List<compareAllInfo>();
        public frmDailySales()
        {
            InitializeComponent();
            cn = new SQLiteConnection(dbcon.MyConnection);
            changeDatePriorCurrent(dateTimePickerStartSold);
            changeDatePriorCurrent(dateTimePickerStartTrans);
            classLoadData.LoadRecordsTransacHist(dataGridViewTransacHist, txtSearchTransac, dateTimePickerStartTrans, dateTimePickerEndTrans);
            classLoadData.LoadRecordsSoldItems(dataGridViewSoldItems, txtSearchSold, dateTimePickerStartSold, dateTimePickerEndSold);
            classLoadData.LoadRecordsTransacSettled(dataGridViewSettle, txtSearchSettleds, dateTimePickerSettStart, dateTimePickerSettEnd);
            textRightAlign();
        }
        public void changeDatePriorCurrent(DateTimePicker date)
        {
            date.Value = DateTime.Today.AddDays(-30);
        }
        public void textRightAlign()
        {
            
            this.dataGridViewSoldItems.Columns["Price"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewSoldItems.Columns["Total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        private void btnCloseDailySales_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewTransacHist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCurrentTransN.Text = dataGridViewTransacHist.Rows[e.RowIndex].Cells[2].Value.ToString();

            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocument;
            int pLength = 1000;
            paperSizeUpdate(out pLength);
            printDocument.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
            preview.PrintPreviewControl.Zoom = 0.75;
            preview.Size = new System.Drawing.Size(400, 650);
            preview.ShowDialog();
        }

        private void dataGridViewSoldItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void tblServiceList(string transacNo, out int rowCount)
        {
            cn = new SQLiteConnection(dbcon.MyConnection);
            //Desc = ""; Price = ""; Quant = ""; Total = ""; UnitM = "";
            rowCount = 0; SList.Clear();
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT Name, Price FROM ViewServiceAvailed WHERE Transaction_No LIKE '" + transacNo + "'", cn);
            dr = cm.ExecuteReader();

            while (dr.Read())
            {
                ServiceList List = new ServiceList();
                List.Name = dr.GetString(0);//"Name"
                List.Price = dr.GetDouble(1);//"Price"

                SList.Add(List);
                rowCount++;

            }
            dr.Close();
            cn.Close();
            //rowCount = List.Count;
        }
        public class ServiceList
        {
            public string Name { get; set; }
            public double Price { get; set; }
          
        }

        public void tblAvailedList(string transacNo, out int rowCount, out int rowCountDesc)
        {
            cn = new SQLiteConnection(dbcon.MyConnection);
            //Desc = ""; Price = ""; Quant = ""; Total = ""; UnitM = "";
            int count, rowCountAll = 0, quanti = 0; string des = "", UnitMe = "";
            double price = 0, total = 0;
            dupAll.Clear(); compAll.Clear(); List.Clear();
            //dupliAllInfo itmAll = new dupliAllInfo();
            //compareAllInfo comp = new compareAllInfo();
            //ItemList comp = new ItemList();

            //itmAll.Desc = " "; itmAll.UnitM = "";
            //dupAll.Add(itmAll);

            //comp.Desc = ""; comp.UnitM = "";
            //compAll.Add(comp);

            rowCount = 0; rowCountDesc = 0; 
            cn.Open();
            SQLiteCommand cm = new SQLiteCommand("SELECT Description, Price, Quantity, Total, Unit_Measure FROM ViewCartStockItem WHERE Transaction_No LIKE '" + transacNo + "'", cn);
            dr = cm.ExecuteReader();
            
            while (dr.Read())
            {
                des = dr[0].ToString(); UnitMe = dr[4].ToString(); price = double.Parse(dr[1].ToString());
                total = double.Parse(dr[3].ToString()); quanti = int.Parse(dr[2].ToString());

                ItemList IList = new ItemList();
                //IList.Desc = dr.GetString(0);//"Description"
                //IList.Price = dr.GetDouble(1);//"Price"
                //IList.Qty = dr.GetInt32(2);//"Quantity"
                //IList.Total = dr.GetDouble(3);//"Total"
                //IList.UnitM = dr.GetString(4);//"Unit_Measure"

                IList.Desc = des;//"Description"
                IList.Price = price;//"Price"
                IList.Qty = quanti;//"Quantity"
                IList.Total = total;//"Total"
                IList.UnitM = UnitMe;//"Unit_Measure"
                //comp.Desc = des;//"Description"
                //comp.Price = price;//"Price"
                //comp.Qty = quanti;//"Quantity"
                //comp.Total = total;//"Total"
                //comp.UnitM = UnitMe;//"Unit_Measure"
                ////compAll.Add(comp);
                rowCount++;
                //List.Add(comp);
                List.Add(IList);
                

                //if (!(itmAll.Desc.Contains(des)))
                //{                   
                //    itmAll.Desc = des;//"Description"
                //    itmAll.Price = price;//"Price"
                //    itmAll.Qty = quanti;//"Quantity"
                //    itmAll.UnitM = UnitMe;//"Unit_Measure"
                //    itmAll.Total = total;//"Total"

                //    dupAll.Add(itmAll);
                //    rowCountDesc++;
                //}

            }
            dr.Close();
            cn.Close();
            //rowCount = List.Count;
        }
        public class ItemList
        {
            public string Desc { get; set; }
            public double Price { get; set; }
            public int Qty { get; set; }
            public string UnitM { get; set; }
            public double Total { get; set; }
        }
        public void calcu(int rowCountDesc, int rowCountAll)
        {
            try
            {
                List.Clear();
                string desc = "", all = "", unitM = "";
                int totalQuantity = 0, Quantity = 0; double totalPrice = 0, totalTotal = 0, Total = 0;
                for (int i = 0; i < rowCountDesc; i++)
                {
                    ItemList itm = new ItemList();
                    dupliAllInfo DescDup = dupAll[i];
                    desc = DescDup.Desc;
                    totalPrice = DescDup.Price;
                    for (int j = 0; j < rowCountAll; j++)
                    {
                        compareAllInfo AllDup = compAll[j];
                        all = AllDup.Desc;
                        unitM = AllDup.UnitM;
                        Quantity = AllDup.Qty;
                        Total = AllDup.Total;
                        if (all == desc)
                        {
                            //totalPrice += AllDup.Price;
                            totalQuantity += Quantity;
                            totalTotal += Total;
                        }
                    }
                    itm.Desc = desc;//"Description"
                    itm.Price = totalPrice;//"Price"
                    itm.Qty = totalQuantity;//"Quantity"
                    itm.Total = totalTotal;//"Total"
                    itm.UnitM = unitM;//"Unit_Measure"
                    List.Add(itm);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, "calcu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public class dupliAllInfo
        {
            public string Desc { get; set; }
            public double Price { get; set; }
            public int Qty { get; set; }
            public string UnitM { get; set; }
            public double Total { get; set; }
        }
        public class compareAllInfo
        {
            public string Desc { get; set; }
            public double Price { get; set; }
            public int Qty { get; set; }
            public string UnitM { get; set; }
            public double Total { get; set; }
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            transNo = lblCurrentTransN.Text; int ITMrowCount = 0; int SrowCount = 0, rowCountDesc = 0;
            string TransDate = "", PMode = "", PTerms = "", Customer = "", GrossT = "", Discoun = "", NetT = "", Payment = "", Balance = "", Change = "", DisPerc = "", SettledDate = "", Cashier = "";
            classReport.tblReceiptValue(transNo, out TransDate, out PMode, out PTerms, out Customer, out GrossT, out Discoun, out NetT, out Payment, out Balance, out Change, out DisPerc, out SettledDate, out Cashier, out ITMrowCount);
           
            string SName = "", SPrice = "";
            classReport.tblServiceAvailedList(transNo, out SName, out SPrice, out SrowCount);

            int x = 0, y = 0, num = 1; 
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            System.Drawing.Font printFontItallic = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Italic);
            e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, 175, 30);
            e.Graphics.DrawString("Address: 3rd Floor Susana Mart, Tungko San Jose Del Monte Bulacan", printFont, Brushes.Black, 80, 60);
            e.Graphics.DrawString("Clinic's Contact: 09178326686", printFont, Brushes.Black, 185, 80);
            y = 140; x = 320;
            e.Graphics.DrawString("TIN: 748-219-944-00000", printFont, Brushes.Black, 20, y);//140
            e.Graphics.DrawString("Date Issued: ", printFont, Brushes.Black, (x += 60), y);
            e.Graphics.DrawString("Mode of Payment:  " + PMode, printFont, Brushes.Black, 20, (y += 30));//170
            e.Graphics.DrawString(TransDate, printFont, Brushes.Black, x, y);
            e.Graphics.DrawString("Payment Terms:  " + PTerms, printFont, Brushes.Black, 20, (y += 30));//200
            e.Graphics.DrawString("Cashier:  " + Cashier, printFont, Brushes.Black, x, y);//200
            e.Graphics.DrawString("Customer Name:  " + Customer, printFont, Brushes.Black, 20, (y += 30));//230
            if (PTerms.Equals("Deposit"))
            {
                e.Graphics.DrawString("Settlement Date for Remaining Balance:  " + SettledDate, printFont, Brushes.Black, 20, (y += 30));//260               
            }

            e.Graphics.DrawString("-----------------------------------------------------------------------------------------------------------------------", printFont, Brushes.Black, 10, (y += 30));//260 or 290
            e.Graphics.DrawString("Invoice No: " + transNo, printFont, Brushes.Black, 20, (y += 50));//310 or 340
            e.Graphics.DrawString("#", printFont, Brushes.Black, 20, (y += 50));//360 or 390
            e.Graphics.DrawString("Description", printFont, Brushes.Black, 60, y);
            e.Graphics.DrawString("Price", printFont, Brushes.Black, x, y);//x=320
            e.Graphics.DrawString("Qty", printFont, Brushes.Black, (x += 60), y);
            e.Graphics.DrawString("Unit", printFont, Brushes.Black, (x += 50), y);
            e.Graphics.DrawString("Total", printFont, Brushes.Black, (x += 50), y);//330

            tblAvailedList(transNo, out ITMrowCount, out rowCountDesc);
            //calcu(rowCountDesc, ITMrowCount);

            if (ITMrowCount > 0)
            {
                for (int i = 0; i < ITMrowCount; i++)
                {
                    ItemList Itms = List[i];
                    x = 370;
                    e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, 20, (y += 30));//330

                    //Description
                    e.Graphics.DrawString(Itms.Desc, printFont, Brushes.Black, 60, y);

                    //Price
                    e.Graphics.DrawString("₱ " + Itms.Price.ToString("00.00"), printFont, Brushes.Black, x, y); ;

                    //Qty
                    e.Graphics.DrawString(Itms.Qty.ToString(), printFont, Brushes.Black, (x += 80), y);

                    //Unit
                    e.Graphics.DrawString(Itms.UnitM, printFont, Brushes.Black, (x += 38), y);

                    //Total
                    e.Graphics.DrawString("₱ " + Itms.Total.ToString("00.00"), printFont, Brushes.Black, (x += 40), y);//330
                    num += 1;
                }
            }
            tblServiceList(transNo, out SrowCount);
            //y = 430;
            if (SrowCount > 0)
            {
                e.Graphics.DrawString("Service:  ", printFont, Brushes.Black, 20, (y += 50));//430 + 50
                num = 1;
                for (int i = 0; i < SrowCount; i++)
                {
                    ServiceList SerList = SList[i];
                    x = 370;
                    e.Graphics.DrawString(num.ToString(), printFont, Brushes.Black, 20, (y += 30));

                    e.Graphics.DrawString(SerList.Name, printFont, Brushes.Black, 60, y);//470      Name

                    e.Graphics.DrawString("₱ " + SerList.Price.ToString("00.00"), printFont, Brushes.Black, x, y);//320   Price
                    num += 1;
                }
            }
            x = 440;
            //y = 550;
            e.Graphics.DrawString("Total Amount: ", printFont, Brushes.Black, 20, (y += 50));//550
            e.Graphics.DrawString("₱ " + GrossT, printFont, Brushes.Black, (x += 50), y);//390 

            e.Graphics.DrawString("Discount: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("₱ " + Discoun, printFont, Brushes.Black, x, y);//370
            //getValueIfAnyElseBlank(frmC.dataGridViewCart, out resultText, 0, 5);//frmC.dataGridViewCart.Rows[0].Cells[5].Value.ToString()
            e.Graphics.DrawString("(" + DisPerc + "%)", printFont, Brushes.Black, (x -= 80), y);//320

            e.Graphics.DrawString("Total Due: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("₱ " + NetT, printFont, Brushes.Black, (x += 80), y);

            e.Graphics.DrawString("Amount Tendered: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("₱ " + Payment, printFont, Brushes.Black, x, y);

            if (PTerms.Equals("Deposit"))
            {
                e.Graphics.DrawString("Remaining Balance: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("₱ " + Balance, printFont, Brushes.Black, x, y);

                e.Graphics.DrawString("Change: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("₱ " + Change, printFont, Brushes.Black, x, y);//710

            }
            else if (PTerms.Equals("Full"))
            {
                e.Graphics.DrawString("Remaining Balance: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("₱ -", printFont, Brushes.Black, x, y);

                e.Graphics.DrawString("Change: ", printFont, Brushes.Black, 20, (y += 30));
                e.Graphics.DrawString("₱ " + Change, printFont, Brushes.Black, x, y);//710

            }



            e.Graphics.DrawString("THIS INVOICE/RECEIPT SHALL BE VALID FOR", printFontItallic, Brushes.Black, 130, (y += 60));//770
            e.Graphics.DrawString("ONE (1)) WEEK FROM THE DATE OF THE PERMIT TO USE", printFontItallic, Brushes.Black, 70, (y += 30));//800
            e.Graphics.DrawString("THANKYOU", printFontBold, Brushes.Black, (x -= 240), (y += 30));//830

        }

        private void dataGridViewSettle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lblCurrentTransN.Text = dataGridViewSettle.Rows[e.RowIndex].Cells[2].Value.ToString();
            PrintPreviewDialog preview = new PrintPreviewDialog();
            preview.Document = printDocumentSettled;
            int pLength = 600;
            printDocumentSettled.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
            preview.PrintPreviewControl.Zoom = 0.75;
            preview.Size = new System.Drawing.Size(400, 500);
            preview.ShowDialog();
        }

        private void printDocumentSettled_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            transNo = lblCurrentTransN.Text;
            string TransDate = "", PMode = "", Customer = "", NetT = "", Payment = "", Change = "", Cashier = "", oldTrans = "", newTrans = "";
            classReport.tblReceiptSettle(transNo, out TransDate, out PMode, out Customer, out NetT, out Payment, out Change, out Cashier, out oldTrans, out newTrans);


            int x = 0, y = 0; // num = 1; string resultText = ""; int dgvCount = int.Parse(lblRowCount.Text), dgvCountService = int.Parse(lblServRowCount.Text);

            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            System.Drawing.Font printFontItallic = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Italic);

            e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, 175, 30);
            e.Graphics.DrawString("Address: 3rd Floor Susana Mart, Tungko San Jose Del Monte Bulacan", printFont, Brushes.Black, 80, 60);
            e.Graphics.DrawString("Clinic's Contact: 09178326686", printFont, Brushes.Black, 185, 80);
            y = 140; x = 320;
            e.Graphics.DrawString("TIN: 748-219-944-00000", printFont, Brushes.Black, 20, y);//140
            e.Graphics.DrawString("Date Issued: ", printFont, Brushes.Black, (x += 60), y);
            e.Graphics.DrawString("Mode of Payment:  " + PMode, printFont, Brushes.Black, 20, (y += 30));//170
            e.Graphics.DrawString(TransDate, printFont, Brushes.Black, x, y);

            e.Graphics.DrawString("Cashier:  " + Cashier, printFont, Brushes.Black, x, (y += 30));//200
            e.Graphics.DrawString("Customer Name:  " + Customer, printFont, Brushes.Black, 20, y);//230
            e.Graphics.DrawString("--------------------------------------------------------------------------------------------------------------------------", printFont, Brushes.Black, 10, (y += 30));//260 or 290
            e.Graphics.DrawString("Invoice No: " + newTrans, printFont, Brushes.Black, 20, (y += 50));//310 or 340
            e.Graphics.DrawString("Balance Settlement for Transaction No:" + oldTrans, printFont, Brushes.Black, 20, (y += 50));//360 or 390
            //e.Graphics.DrawString("For Transaction No:" + oldTrans, printFont, Brushes.Black, 20, (y += 50));//360 or 390

            x = 440;
            //y = 550;
            e.Graphics.DrawString("Total Amount: ", printFont, Brushes.Black, 20, (y += 50));//550
            e.Graphics.DrawString("₱ " + NetT, printFont, Brushes.Black, (x += 70), y);//510 

            e.Graphics.DrawString("Amount Tendered: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("₱ " + Payment, printFont, Brushes.Black, x, y);

            e.Graphics.DrawString("Change: ", printFont, Brushes.Black, 20, (y += 30));
            e.Graphics.DrawString("₱ " + Change, printFont, Brushes.Black, x, y);//710          

            e.Graphics.DrawString("THIS INVOICE/RECEIPT SHALL BE VALID FOR", printFontItallic, Brushes.Black, 130, (y += 60));//770
            e.Graphics.DrawString("ONE (1)) WEEK FROM THE DATE OF THE PERMIT TO USE", printFontItallic, Brushes.Black, 70, (y += 30));//800
            e.Graphics.DrawString("THANKYOU", printFontBold, Brushes.Black, (x -= 280), (y += 30));//830

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchTransac_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchTransac.Text == String.Empty)
                {
                    classLoadData.LoadRecordsTransacHist(dataGridViewTransacHist, txtSearchTransac, dateTimePickerStartTrans, dateTimePickerEndTrans);
                    return;
                }
                else
                {
                    classLoadData.LoadRecordsTransacHist(dataGridViewTransacHist, txtSearchTransac, dateTimePickerStartTrans, dateTimePickerEndTrans);
                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchSold_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchSold.Text == String.Empty)
                {
                    classLoadData.LoadRecordsSoldItems(dataGridViewSoldItems, txtSearchSold, dateTimePickerStartSold, dateTimePickerEndSold);
                    return;
                }
                else
                {
                    classLoadData.LoadRecordsSoldItems(dataGridViewSoldItems, txtSearchSold, dateTimePickerStartSold, dateTimePickerEndSold);

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearchSettleds_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchSettleds.Text == String.Empty)
                {
                    classLoadData.LoadRecordsTransacSettled(dataGridViewSettle, txtSearchSettleds, dateTimePickerSettStart, dateTimePickerSettEnd);
                    return;
                }
                else
                {
                    classLoadData.LoadRecordsTransacSettled(dataGridViewSettle, txtSearchSettleds, dateTimePickerSettStart, dateTimePickerSettEnd);

                }
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dateTimePickerStartSold_ValueChanged(object sender, EventArgs e)
        {

        }

        public void paperSizeUpdate(out int paperL)
        {
            int dgvCount = 0, rowCountDesc = 0; transNo = lblCurrentTransN.Text;
            tblAvailedList(transNo, out dgvCount, out rowCountDesc);
           
            paperL = 0;
            if (dgvCount > 0 && dgvCount <= 4)
            {
                paperL = 1000;
            }
            else if (dgvCount > 4 && dgvCount <= 7)// + 3 items = 30 * 3 = 90
            {
                paperL = 1090;
            }
            else if (dgvCount > 7 && dgvCount <= 10)// + 3 items = 30 * 3 = 90
            {
                paperL = 1180;
            }
            else if (dgvCount > 10 && dgvCount <= 13)// + 3 items = 30 * 3 = 90
            {
                paperL = 1270;
            }
            else
            {
                paperL = 1000;
            }

        }
    }
}
