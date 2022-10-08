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
            frmAddPatientRecord frm = new frmAddPatientRecord();

            classGenerateID.GeneratePatientID(frm.txtAddPatientID);
            classGenerateID.GeneratePrescriptionID(frm.txtAddPrescNum);
            frm.ShowDialog();
        }
    }
}
