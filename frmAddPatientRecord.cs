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
        string title = "BICO-JOSE System";
        frmPatientRecord frmL;
        public frmAddPatientRecord(frmPatientRecord frmA)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
            frmL = frmA;
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
            txtAddTransRefNo.Clear();
            txtAddNote.Clear();
            txtAddFeature.Clear();
            txtAddLensePrice.Clear();
            txtAddFramePrice.Clear();
            txtAddOthersPrice.Clear();
            txtAddTotal.Clear();
            txtAddDeposit.Clear();
            txtAddBalance.Clear();
            

        }
        private void btnSavePatientRecord_Click(object sender, EventArgs e)
        {
            string firstName = txtAddFName.Text;
            string lastName = txtAddLName.Text;
            string address = txtAddAddress.Text;
            string contact = txtAddContact.Text;
            string gender = comBoxAddGender.Text;
            string age = txtAddAge.Text;

            string ODSPH = txtAddODSPH.Text;
            string ODCYL = txtADDODCYL.Text;
            string ODAXIS = txtAddODAXIS.Text;
            string ODPD = txtAddODPD.Text;

            string OSSPH = txtAddOSSPH.Text;
            string OSCYL = txtADDOSCYL.Text;
            string OSAXIS = txtAddOSAXIS.Text;
            string OSPD = txtAddOSPD.Text;
            string checkUp = dateTimePickerCheckUpDate.Value.ToString();
            string birth = dateTimePickerBirthDate.Value.ToString();
            string CName = txtAddFName.Text + " " + txtAddLName.Text;
            int ageCalculated = int.Parse(txtAddAge.Text);

            if (firstName != "" && lastName != "" && address != "" && contact != "" && gender != "" && age != "" && ODSPH != "" &&
                ODCYL != "" && ODAXIS != "" && ODPD != "" && OSSPH != "" && OSCYL != "" && OSAXIS != "" && OSPD != "")
            {
                cn.Open();
                cm = new SqlCommand("INSERT INTO tblPatientRecord (Patient_ID, Customer_Name, Address, Contact, Age, Gender, Check_Up_Date, Prescript_No, Birth_Date) VALUES(@Patient_ID, @Customer_Name, @Address, @Contact, @Age, @Gender, @Check_Up_Date, @Prescript_No, @Birth_Date)", cn);
                cm.Parameters.AddWithValue("@Patient_ID", txtAddPatientID.Text);
                cm.Parameters.AddWithValue("@Prescript_No", txtAddPrescNum.Text);
                cm.Parameters.AddWithValue("@Customer_Name", CName);
                cm.Parameters.AddWithValue("@Address", txtAddAddress.Text);
                cm.Parameters.AddWithValue("@Contact", txtAddContact.Text);
                cm.Parameters.AddWithValue("@Age", ageCalculated);
                cm.Parameters.AddWithValue("@Gender", comBoxAddGender.Text);
                cm.Parameters.AddWithValue("@Check_Up_Date", checkUp);
                cm.Parameters.AddWithValue("@Birth_Date", birth);

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
            else
            {
                MethodCheckForBlank();
            }
            
        }

        private void dateTimePickerBirthDate_ValueChanged(object sender, EventArgs e)
        {
            int years = DateTime.Now.Year - dateTimePickerBirthDate.Value.Year;
            if(dateTimePickerBirthDate.Value.AddYears(years) > DateTime.Now)
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
            int years = DateTime.Now.Year - dateTimePickerBirthDate.Value.Year;
            if (dateTimePickerBirthDate.Value.AddYears(years) < DateTime.Now)
            { 
                years--;
                txtAddAge.Text = years.ToString();
            }
        }
    }
}
