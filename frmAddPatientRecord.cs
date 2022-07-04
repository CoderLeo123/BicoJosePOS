using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capstone
{
    public partial class frmAddPatientRecord : Form
    {
        public frmAddPatientRecord()
        {
            InitializeComponent();
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
            MessageBox.Show("Record has been successfully saved.");
            Clear();
        }
    }
}
