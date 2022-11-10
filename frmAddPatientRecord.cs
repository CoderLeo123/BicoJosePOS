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
    public partial class frmAddPatientRecord : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassComputations classCompute = new ClassComputations();
        ClassLoadData classLoadData = new ClassLoadData();
        ClassLoginAndSignUp classLoginMethod = new ClassLoginAndSignUp();
        ClassPatientTransaction classPatient = new ClassPatientTransaction();
        string title = "BICO-JOSE System";
        frmPatientRecord frmL;
        private bool mouseDown;
        private Point lastLocation;
        public frmAddPatientRecord(frmPatientRecord frmA)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmL = frmA;
            //classPatient.LoadPatientTransactionList(frmL.dataGridViewTrans, pID);
        }
        public void MethodCheckForBlank()
        {
            classLoginMethod.checkForBlank(txtAddFName, lblFNotice, "First Name");
            classLoginMethod.checkForBlank(txtAddLName, lblLNotice, "Cabug Name");
            classLoginMethod.checkForBlank(txtAddAddress, lblAddNotice, "Address");
            classLoginMethod.checkForBlank(txtAddContact, lblConNotice, "Contact");

            classLoginMethod.checkForBlank(txtAddODSPH, lblSpODNotice, "Right SPH");
            classLoginMethod.checkForBlank(txtADDODCYL, lblCyODNotice, "Right CYL");
            classLoginMethod.checkForBlank(txtAddODAXIS, lblAxODNotice, "Right AXIS");
            classLoginMethod.checkForBlank(txtAddODPD, lblPdODNotice, "Right PD");

            classLoginMethod.checkForBlank(txtAddOSSPH, lblSpOSNotice, "Left SPH");
            classLoginMethod.checkForBlank(txtADDOSCYL, lblCyOSNotice, "Left CYL");
            classLoginMethod.checkForBlank(txtAddOSAXIS, lblAxOSNotice, "Left AXIS");
            classLoginMethod.checkForBlank(txtAddODPD, lblPDOSNotice, "Left PD");
            //classLoginMethod.textMinimumCharacter(txtPasswordCreate, lblPasswordNotice);
        }

        private void btnClosePatientRecord_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelPatientRecord_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        public void Clear()
        {
            btnSavePatientRecord.Enabled = true;
            btnUpdatePatientRecord.Enabled = false;
            txtAddFName.Clear();
            txtAddLName.Clear();
            txtAddAddress.Clear();
            txtAddContact.Clear();
            txtAddAge.Clear();
            //txtAddTransRefNo.Clear();
            txtAddNote.Clear();
            //txtAddFeature.Clear();
            //txtAddLensePrice.Clear();
            //txtAddFramePrice.Clear();
           // txtAddOthersPrice.Clear();
            //txtAddTotal.Clear();
            //txtAddDeposit.Clear();
            //txtAddBalance.Clear();            
        }
        public void getValueGeneralInfo(out string firstName, out string lastName, out string address, out string contact, out string gender, out string age, out string checkUp, out string birth)
        {
            //dateTimePickerCheckUpDate.Format = DateTimePickerFormat.Custom;
            //dateTimePickerCheckUpDate.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            firstName = txtAddFName.Text;
             lastName = txtAddLName.Text;
             address = txtAddAddress.Text;
             contact = txtAddContact.Text;
             gender = comBoxAddGender.Text;
             age = txtAddAge.Text;
            checkUp = dateTimePickerCheckUpDate.Value.ToString();
             birth = dateTimePickerBirthDate.Value.ToString();
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";

        }
        public void getValueOD(out string ODSPH, out string ODCYL, out string ODAXIS, out string ODPD)
        {
            ODSPH = txtAddODSPH.Text;
             ODCYL = txtADDODCYL.Text;
             ODAXIS = txtAddODAXIS.Text;
             ODPD = txtAddODPD.Text;
        }
        public void getValueOS(out string OSSPH, out string OSCYL, out string OSAXIS, out string OSPD)
        {
            OSSPH = txtAddOSSPH.Text;
             OSCYL = txtADDOSCYL.Text;
             OSAXIS = txtAddOSAXIS.Text;
             OSPD = txtAddOSPD.Text;
        }

        private void btnSavePatientRecord_Click(object sender, EventArgs e)
        {
            string firstName ="", lastName = "", address = "", contact = "", gender = "", age = "", checkUp = "", birth = "";
            getValueGeneralInfo(out firstName, out lastName, out address, out contact, out gender, out age, out checkUp, out birth);
            string ODSPH = "", ODCYL = "", ODAXIS = "", ODPD = "";
            getValueOD(out ODSPH, out ODCYL, out ODAXIS, out ODPD);
            string OSSPH = "", OSCYL = "", OSAXIS = "", OSPD = "";
            getValueOS(out OSSPH, out OSCYL, out OSAXIS, out OSPD);
            //int ageCalculated = int.Parse(txtAddAge.Text); 
            string CName = firstName + " " + lastName;

            if (firstName != "" && lastName != "" && address != "" && contact != "" && gender != "" && age != "" && ODSPH != "" &&
                ODCYL != "" && ODAXIS != "" && ODPD != "" && OSSPH != "" && OSCYL != "" && OSAXIS != "" && OSPD != "")
            {
                if (MessageBox.Show("Are you sure you want to save this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblPatientRecord (Patient_ID, Customer_Name, Address, Contact, Age, Gender, Check_Up_Date, Prescript_No, Birth_Date, First_Name, Last_Name) VALUES(@Patient_ID, @Customer_Name, @Address, @Contact, @Age, @Gender, @Check_Up_Date, @Prescript_No, @Birth_Date, @First_Name, @Last_Name)", cn);
                    cm.Parameters.AddWithValue("@Patient_ID", txtAddPatientID.Text);
                    cm.Parameters.AddWithValue("@Prescript_No", txtAddPrescNum.Text);
                    cm.Parameters.AddWithValue("@Customer_Name", CName);
                    cm.Parameters.AddWithValue("@Address", txtAddAddress.Text);
                    cm.Parameters.AddWithValue("@Contact", txtAddContact.Text);
                    cm.Parameters.AddWithValue("@Age", age);
                    cm.Parameters.AddWithValue("@Gender", comBoxAddGender.Text);
                    cm.Parameters.AddWithValue("@Check_Up_Date", checkUp);
                    cm.Parameters.AddWithValue("@Birth_Date", birth);
                    cm.Parameters.AddWithValue("@First_Name", firstName);
                    cm.Parameters.AddWithValue("@Last_Name", lastName);
                    cm.Parameters.AddWithValue("@Note", txtAddNote.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblPrescription (Patient_ID, Prescript_No, SPH_OD, CYL_OD, AXIS_OD, PD_OD, ADD_OD, SPH_OS, CYL_OS, AXIS_OS, ADD_OS, PD_OS) VALUES(@Patient_ID, @Prescript_No, @SPH_OD, @CYL_OD, @AXIS_OD, @PD_OD, @ADD_OD, @SPH_OS, @CYL_OS, @AXIS_OS, @ADD_OS, @PD_OS)", cn);
                    cm.Parameters.AddWithValue("@Patient_ID", txtAddPatientID.Text);
                    cm.Parameters.AddWithValue("@Prescript_No", txtAddPrescNum.Text);
                    cm.Parameters.AddWithValue("@SPH_OD", txtAddODSPH.Text);
                    cm.Parameters.AddWithValue("@CYL_OD", txtADDODCYL.Text);
                    cm.Parameters.AddWithValue("@AXIS_OD", txtAddODAXIS.Text);
                    cm.Parameters.AddWithValue("@PD_OD", txtAddODPD.Text);
                    cm.Parameters.AddWithValue("@ADD_OD", txtAddODADD.Text);
                    cm.Parameters.AddWithValue("@SPH_OS", txtAddOSSPH.Text);
                    cm.Parameters.AddWithValue("@CYL_OS", txtADDODCYL.Text);
                    cm.Parameters.AddWithValue("@AXIS_OS", txtAddOSAXIS.Text);
                    cm.Parameters.AddWithValue("@PD_OS", txtAddOSPD.Text);
                    cm.Parameters.AddWithValue("@ADD_OS", txtAddOSADD.Text);

                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Record has been successfully saved.");
                    Clear();

                    classLoadData.LoadRecordsPatient(frmL.dataGridViewPatientRecord, frmL.txtSearchPatientRecord);
                    this.Close();
                }
            }
            else
            {
                MethodCheckForBlank();
            }
            
        }

        private void dateTimePickerBirthDate_ValueChanged(object sender, EventArgs e)
        {
            int years = DateTime.Now.Year - dateTimePickerBirthDate.Value.Year;
            if(dateTimePickerBirthDate.Value.AddYears(years) < DateTime.Now)
            {
                years--;
                txtAddAge.Text = years.ToString();
            }
        }

        private void txtAddOSAXIS_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelAddPresc_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtAddContact_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void txtAddContact_KeyPress(object sender, KeyPressEventArgs e)
        {   
            if (e.KeyChar == 46){ }//accept . character
            else if (e.KeyChar == 8) {}//accept backspace
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)){e.Handled = true;  }
            //ascii code 48 - 57 = characters between 0 - 9
        }

        private void txtAddODPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46) { }//accept . character
            else if (e.KeyChar == 8) { }//accept backspace
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) { e.Handled = true; }
            //ascii code 48 - 57 = characters between 0 - 9
        }

        private void txtAddOSPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46) { }//accept . character
            else if (e.KeyChar == 8) { }//accept backspace
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) { e.Handled = true; }
            //ascii code 48 - 57 = characters between 0 - 9
        }

        private void txtAddODAXIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46) { }//accept . character
            else if (e.KeyChar == 8) { }//accept backspace
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) { e.Handled = true; }
            //ascii code 48 - 57 = characters between 0 - 9
        }

        private void txtAddOSAXIS_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 46) { }//accept . character
            else if (e.KeyChar == 8) { }//accept backspace
            
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) { e.Handled = true; }
            //ascii code 48 - 57 = characters between 0 - 9
        }

        private void txtADDODCYL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) { e.Handled = true; }
            
            // only allow minus sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0) { e.Handled = true; }
               


            if (e.KeyChar == 8) { }//accept backspace
           
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) { e.Handled = true; }
            //ascii code 48 - 57 = characters between 0 - 9
        }

        private void txtADDOSCYL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1) { e.Handled = true; }

            // only allow minus sign at the beginning
            if (e.KeyChar == '-' && (sender as TextBox).Text.Length > 0) { e.Handled = true; }

            if (e.KeyChar == 8) { }//accept backspace
           
            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) { e.Handled = true; }
            //ascii code 48 - 57 = characters between 0 - 9
        }

        private void dateTimePickerCheckUpDate_ValueChanged(object sender, EventArgs e)
        {
            //int years = DateTime.Now.Year - dateTimePickerBirthDate.Value.Year;
            //if (dateTimePickerBirthDate.Value.AddYears(years) < DateTime.Now)
            //{ 
            //    years--;
            //    txtAddAge.Text = years.ToString();
            //}
            //dateTimePicker1.Format = DateTimePickerFormat.Custom;
            //dateTimePicker1.CustomFormat = "MM/dd/yyyy hh:mm:ss";
        }

        private void btnUpdatePatientRecord_Click(object sender, EventArgs e)
        {
            string firstName = "", lastName = "", address = "", contact = "", gender = "", age = "", checkUp = "", birth = "";
            getValueGeneralInfo(out firstName, out lastName, out address, out contact, out gender, out age, out checkUp, out birth);
            string ODSPH = "", ODCYL = "", ODAXIS = "", ODPD = "";
            getValueOD(out ODSPH, out ODCYL, out ODAXIS, out ODPD);
            string OSSPH = "", OSCYL = "", OSAXIS = "", OSPD = "";
            getValueOS(out OSSPH, out OSCYL, out OSAXIS, out OSPD);
            string CName = firstName + " " + lastName;
            string pID = txtAddPatientID.Text;
            if (firstName != "" && lastName != "" && address != "" && contact != "" && gender != "" && age != "" && ODSPH != "" &&
                ODCYL != "" && ODAXIS != "" && ODPD != "" && OSSPH != "" && OSCYL != "" && OSAXIS != "" && OSPD != "")
            {

                if (MessageBox.Show("Are you sure you want to update this record?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("UPDATE tblPatientRecord SET Customer_Name = @Customer_Name, Address = @Address, Contact = @Contact, Age = @Age, Gender = @Gender, Check_Up_Date = @Check_Up_Date, Birth_Date = @Birth_Date, First_Name = @First_Name, Last_Name = @Last_Name, Note = @Note WHERE Patient_ID LIKE '" + pID + "'", cn);                    
                    cm.Parameters.AddWithValue("@Customer_Name", CName);
                    cm.Parameters.AddWithValue("@Address", address);
                    cm.Parameters.AddWithValue("@Contact", contact);
                    cm.Parameters.AddWithValue("@Age", age);
                    cm.Parameters.AddWithValue("@Gender", gender);
                    cm.Parameters.AddWithValue("@Check_Up_Date", checkUp);
                    cm.Parameters.AddWithValue("@Birth_Date", birth);
                    cm.Parameters.AddWithValue("@First_Name", firstName);
                    cm.Parameters.AddWithValue("@Last_Name", lastName);
                    cm.Parameters.AddWithValue("@Note", txtAddNote.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    cn.Open();
                    cm = new SqlCommand("UPDATE tblPrescription SET SPH_OD = @SPH_OD, CYL_OD = @CYL_OD, AXIS_OD = @AXIS_OD, PD_OD = @PD_OD, ADD_OD = @ADD_OD, SPH_OS = @SPH_OS, CYL_OS = @CYL_OS, AXIS_OS = @AXIS_OS, PD_OS = @PD_OS, ADD_OS = @ADD_OS WHERE Patient_ID LIKE '" + pID + "'", cn);
                    cm.Parameters.AddWithValue("@SPH_OD", ODSPH);
                    cm.Parameters.AddWithValue("@CYL_OD", ODCYL);
                    cm.Parameters.AddWithValue("@AXIS_OD", ODAXIS);
                    cm.Parameters.AddWithValue("@PD_OD", ODPD);
                    cm.Parameters.AddWithValue("@ADD_OD", txtAddODADD.Text);
                    cm.Parameters.AddWithValue("@SPH_OS", OSSPH);
                    cm.Parameters.AddWithValue("@CYL_OS", OSCYL);
                    cm.Parameters.AddWithValue("@AXIS_OS", OSAXIS);
                    cm.Parameters.AddWithValue("@PD_OS", OSPD);
                    cm.Parameters.AddWithValue("@ADD_OS", txtAddOSADD.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();

                    MessageBox.Show("Record has been successfully updated.");
                    Clear();

                    classLoadData.LoadRecordsPatient(frmL.dataGridViewPatientRecord, frmL.txtSearchPatientRecord);
                    classPatient.LoadPatientTransactionList(frmL.dataGridViewTrans, pID);
                    this.Close();
                }
            }
            else
            {
                MethodCheckForBlank();
            }
            MethodCheckForBlank();
        }

        private void btnSearchTrans_Click(object sender, EventArgs e)
        {
            frmTransactionPatient frm = new frmTransactionPatient(this);
            frm.txtSearchRTrans.Text = txtAddFName.Text;
            frm.txtSearchSTrans.Text = txtAddFName.Text;
            frm.lblPatientID.Text = txtAddPatientID.Text;
            classPatient.LoadRecordsTransacHist(frm.dataGridViewRTrans, frm.txtSearchRTrans);
            classPatient.LoadRecordsTransacSettled(frm.dataGridViewSTrans, frm.txtSearchSTrans);
            frm.ShowDialog();
        }

        private void dataGridViewTrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewTrans.Columns[e.ColumnIndex].Name;
            string num = dataGridViewTrans.Rows[e.RowIndex].Cells[1].Value?.ToString();
            string pID = txtAddPatientID.Text;
            if (colName == "dek")
            {
                if (MessageBox.Show("Remove this transaction?", title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frmPermission frmP = new frmPermission();
                    frmP.ShowDialog();
                    if (frmP.lblGrant.Text == "1")
                    {
                        cn.Open();
                        cm = new SqlCommand("DELETE FROM tblPatientTransaction WHERE Num LIKE '" + num + "'", cn);
                        cm.ExecuteNonQuery();
                        cn.Close();
                        MessageBox.Show("Transaction has been successfully removed.", title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        classPatient.LoadPatientTransactionList(dataGridViewTrans, pID);
                    }
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
    }
}
