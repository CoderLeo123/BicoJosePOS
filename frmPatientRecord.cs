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
        string title = "BICO-JOSE System";
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
                ODSPH = dr[6].ToString(); ODCYL = dr[7].ToString(); ODAXIS = dr[8].ToString(); ODADD = dr[9].ToString(); ODPD = dr[10].ToString();
            }
            dr.Close();
            cn.Close();
        }
        private void dataGridViewPatientRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewPatientRecord.Columns[e.ColumnIndex].Name;
            string PatID = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[3].Value.ToString();
            string ODSPH, ODCYL, ODAXIS, ODADD, ODPD, OSSPH, OSCYL, OSAXIS, OSADD, OSPD;

            LoadPrescription(PatID, out ODSPH, out ODCYL, out ODAXIS, out ODADD, out ODPD, out OSSPH, out OSCYL, out OSAXIS, out OSADD, out OSPD);

            if (colName == "EditPRecord")
            {
                frmAddPatientRecord frm = new frmAddPatientRecord(this);
                frm.txtAddFName.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtAddLName.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.txtAddAddress.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.txtAddContact.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.comBoxAddGender.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[8].Value.ToString();
                frm.txtAddAge.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[7].Value.ToString();
                frm.txtAddPatientID.Text = dataGridViewPatientRecord.Rows[e.RowIndex].Cells[3].Value.ToString();
                

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


                frm.ShowDialog();

            }
            



        }


    }
}
