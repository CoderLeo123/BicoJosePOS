using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Capstone
{
    public partial class frmPatientRecord : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassGenerateID classGenerateID = new ClassGenerateID();
        ClassLoadData classLoadData = new ClassLoadData();
        ClassPatientTransaction classPatient = new ClassPatientTransaction();
        string title = "BICO-JOSE System", transNo = ""; int paperWidth = 850, paperLength = 550;
        public frmPatientRecord()
        {
            InitializeComponent();
            classLoadData.LoadRecordsPatient(dataGridViewPatientRecord, txtSearchPatientRecord);
        }

        private void btnClosePatientRecord_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
       
        private void txtTypeLensePR_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddPatientRecord_Click(object sender, EventArgs e)
        {
            
        }
        
        private void btnAddPR_Click(object sender, EventArgs e)
        {
            frmAddPatientRecord frm = new frmAddPatientRecord(this);

            classGenerateID.GeneratePatientID(frm.txtAddPatientID);
            classGenerateID.GeneratePrescriptionID(frm.txtAddPrescNum);
            frm.comBoxAddGender.SelectedIndex = 0;
            frm.btnSavePatientRecord.Enabled = true;
            frm.btnUpdatePatientRecord.Enabled = false;
            frm.ShowDialog();
        }
        public void LoadPrescription(string PID, out string ODSPH, out string ODCYL, out string ODAXIS, out string ODADD, out string ODPD, out string OSSPH, out string OSCYL, out string OSAXIS, out string OSADD, out string OSPD)
        {
            cn = new SqlConnection(dbcon.MyConnection());
            ODSPH = ""; ODCYL = ""; ODAXIS = ""; ODADD = ""; ODPD = "";
            OSSPH = ""; OSCYL = ""; OSAXIS = ""; OSADD = ""; OSPD = "";

            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblPrescription WHERE Patient_ID LIKE '%" + PID + "%'", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                ODSPH = dr[1].ToString(); ODCYL = dr[2].ToString(); ODAXIS = dr[3].ToString(); ODADD = dr[4].ToString(); ODPD = dr[5].ToString();
                OSSPH = dr[6].ToString(); OSCYL = dr[7].ToString(); OSAXIS = dr[8].ToString(); OSADD = dr[9].ToString(); OSPD = dr[10].ToString();
            }
            dr.Close();
            cn.Close();
        }
        public void displayPrescription(string ODSPH, string ODCYL, string ODAXIS, string ODADD, string ODPD, string OSSPH, string OSCYL, string OSAXIS, string OSADD, string OSPD)
        {
            txtODSPH.Text = ODSPH; txtODCYL.Text = ODCYL; txtODAXIS.Text = ODAXIS; txtODADD.Text = ODADD; txtODPD.Text = ODPD;
            txtOSSPH.Text = OSSPH; txtOSCYL.Text = OSCYL; txtOSAXIS.Text = OSAXIS;
            txtOSADD.Text = OSADD; txtOSPD.Text = OSPD;
        }
        private void dataGridViewPatientRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewPatientRecord.Columns[e.ColumnIndex].Name;
            string PatID = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[1].Value?.ToString();
            string ODSPH, ODCYL, ODAXIS, ODADD, ODPD, OSSPH, OSCYL, OSAXIS, OSADD, OSPD;
            int genderIndex = 0; DateTime newDateTime;
            string checkUpDate = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[7].Value?.ToString();
            string birthDate = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[11].Value?.ToString();
            string gender = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[6].Value?.ToString();
            lblPrescript.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[8].Value?.ToString();
            lblPatientID.Text = PatID;
            LoadPrescription(PatID, out ODSPH, out ODCYL, out ODAXIS, out ODADD, out ODPD, out OSSPH, out OSCYL, out OSAXIS, out OSADD, out OSPD);
            displayPrescription(ODSPH, ODCYL, ODAXIS, ODADD, ODPD, OSSPH, OSCYL, OSAXIS, OSADD, OSPD);
            if (colName == "EditPRecord")
            {
                frmPermission frmP = new frmPermission();
                frmP.ShowDialog();
                if (frmP.lblGrant.Text == "1")
                {
                    frmAddPatientRecord frm = new frmAddPatientRecord(this);
                    frm.txtAddFName.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[9].Value?.ToString();
                    frm.txtAddLName.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[10].Value?.ToString();
                    frm.txtAddAddress.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[3].Value?.ToString();
                    frm.txtAddContact.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[4].Value?.ToString();
                    //checkGender(out genderIndex);
                    //frm.comBoxAddGender.SelectedIndex = genderIndex;
                    frm.comBoxAddGender.SelectedItem = gender;
                    frm.txtAddAge.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[5].Value?.ToString();
                    frm.txtAddPatientID.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[1].Value?.ToString();
                    frm.txtAddPrescNum.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[8].Value?.ToString();

                    if (DateTime.TryParse(checkUpDate, out newDateTime))
                    {
                        frm.dateTimePickerCheckUpDate.Value = newDateTime;
                        
                    } else { }
                    if (DateTime.TryParse(birthDate, out newDateTime))
                    {
                        frm.dateTimePickerBirthDate.Value = newDateTime;
                        
                    }
                    else { }
                    frm.txtAddODSPH.Text = txtODSPH.Text;
                    frm.txtADDODCYL.Text = txtODCYL.Text;
                    frm.txtAddODAXIS.Text = txtODAXIS.Text;
                    frm.txtAddODADD.Text = txtODADD.Text;
                    frm.txtAddODPD.Text = txtODPD.Text;

                    frm.txtAddOSSPH.Text = txtOSSPH.Text;
                    frm.txtADDOSCYL.Text = txtOSCYL.Text;
                    frm.txtAddOSAXIS.Text = txtOSAXIS.Text;
                    frm.txtAddOSADD.Text = txtOSADD.Text;
                    frm.txtAddOSPD.Text = txtOSPD.Text;
                    frm.btnSavePatientRecord.Enabled = false;
                    frm.btnUpdatePatientRecord.Enabled = true;
                    classPatient.LoadPatientTransactionList(frm.dataGridViewTrans, PatID); 
                    frm.ShowDialog();
                }
            }
            else if (colName == "del")
            {
                frmPermission frmP = new frmPermission();
                frmP.ShowDialog();
                if (frmP.lblGrant.Text == "1")
                {
                    if (MessageBox.Show("Remove this Item?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tblPatientRecord WHERE Patient_ID LIKE '" + PatID + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Record has been successfully deleted.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //LoadStock();
                        classLoadData.LoadRecordsPatient(dataGridViewPatientRecord, txtSearchPatientRecord);
                    }
                }
            }
            else
            {
                LoadPrescription(PatID, out ODSPH, out ODCYL, out ODAXIS, out ODADD, out ODPD, out OSSPH, out OSCYL, out OSAXIS, out OSADD, out OSPD);
                displayPrescription(ODSPH, ODCYL, ODAXIS, ODADD, ODPD, OSSPH, OSCYL, OSAXIS, OSADD, OSPD);
                classPatient.LoadPatientTransactionList(dataGridViewTrans, PatID);
                
            }

             void checkGender(out int result)
            {
                result = 0;
                string check = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[8].Value?.ToString();
                if (check == "Male")
                {
                    result = 0;
                }
                else if (check == "Female")
                {
                    result = 1;
                }
            }


        }

        private void dataGridViewTrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pID = "", prescID = "", transNo = "", transType = "", oldTrans = "";
            transNo = dataGridViewTrans.Rows[e.RowIndex].Cells[2].Value?.ToString();
            oldTrans = dataGridViewTrans.Rows[e.RowIndex].Cells[6].Value?.ToString();
            transType = dataGridViewTrans.Rows[e.RowIndex].Cells[5].Value?.ToString();
            pID = lblPatientID.Text;
            prescID = lblPrescript.Text;
            //previewFinalReceipt();

            frmFinalReceipt frm = new frmFinalReceipt();            
            frm.lblPatientID.Text = pID;
            frm.lblTransNo.Text = transNo;
            frm.lblOldTransNo.Text = oldTrans;
            frm.lblPrescriptNo.Text = prescID;
            frm.lblTransType.Text = transType;
            frm.displayValue(pID, prescID, transNo, oldTrans, transType);
            if (transType == "Regular")
            {
                frm.displayValue(pID, prescID, transNo, oldTrans, transType);
            }
            else if (transType == "Settlement")
            {
                frm.displayValue(pID, prescID, oldTrans, transNo, transType);

            }

            frm.ShowDialog();
        }
        public void previewFinalReceipt()
        {
            PrintPreviewDialog preview = new PrintPreviewDialog();
            
            preview.Document = printDocumentFinalReceipt; // 800, 800 = 8" x 8"
            printDocumentFinalReceipt.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("SHORT Half", paperWidth, paperLength);
            preview.PrintPreviewControl.StartPage = 0;
            preview.PrintPreviewControl.Zoom = 0.75;
            preview.Size = new System.Drawing.Size(900, 700);
            preview.ShowDialog();
        }
        private void printDocumentFinalReceipt_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            transNo = lblCurrentTransN.Text;

            System.Drawing.Font printFont = new System.Drawing.Font("Times New Roman", 12, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Times New Roman", 12, System.Drawing.FontStyle.Bold);

            float leftMargin = e.MarginBounds.Left - 50; //50            
            float topMargin = leftMargin; //50
            float rightMargin = e.MarginBounds.Left; //100
            float bottomMargin = leftMargin; //50
            float pageHeigth = e.PageSettings.PrintableArea.Height; //1100
            float fontHeigth = printFont.GetHeight();
            float yPos = 0;
            float offSetY = 0;
            float offSetX = leftMargin;

            offSetY += (float)fontHeigth;
            yPos = topMargin;

            void header()
            {
                
                e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, (leftMargin + 240), yPos);
                e.Graphics.DrawString("Bico-Jose Optical Clinic 3rd Floor Susana Mart,", printFont, Brushes.Black, (leftMargin + 70), (yPos += offSetY)); //offSetY += (float)fontHeigth;
                e.Graphics.DrawString("Brgy. Tungkong Mangga, City of SJDM, Bulacan ", printFont, Brushes.Black, (leftMargin + 70), (yPos += offSetY)); //offSetY += (float)fontHeigth;
                e.Graphics.DrawString("(+63) 917 832 6686", printFont, Brushes.Black, (leftMargin + 220), (yPos += offSetY)); //offSetY += (float)fontHeigth;
                e.Graphics.DrawString("___________________________________________________________________________________________________________________________________", printFont, Brushes.Black, (leftMargin + 220), (yPos += offSetY)); //offSetY += (float)fontHeigth;

            }

            void generalInfo()
            {
                e.Graphics.DrawString("Px's Name:", printFontBold, Brushes.Black, (leftMargin + 240), yPos);
                e.Graphics.DrawString("Address: ", printFont, Brushes.Black, (leftMargin + 70), (yPos += offSetY)); //offSetY += (float)fontHeigth;
                e.Graphics.DrawString("Age: ", printFont, Brushes.Black, (leftMargin + 70), (yPos += offSetY)); //offSetY += (float)fontHeigth;
                e.Graphics.DrawString("Phone: ", printFont, Brushes.Black, (leftMargin + 70), (yPos += offSetY)); //offSetY += (float)fontHeigth;
                e.Graphics.DrawString("Date: ", printFont, Brushes.Black, (leftMargin + 70), (yPos += offSetY)); //offSetY += (float)fontHeigth;

            }
            header();
            generalInfo();
        }


    }
}
