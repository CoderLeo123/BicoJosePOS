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
    public partial class frmPatientRecord : Form
    {
        public frmPatientRecord()
        {
            InitializeComponent();
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
            frmAddPatientRecord frm = new frmAddPatientRecord();
            frm.ShowDialog();
        }
    }
}
