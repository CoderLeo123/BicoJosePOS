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
    public partial class frmDailySales : Form
    {
        public frmDailySales()
        {
            InitializeComponent();
        }

        private void btnCloseDailySales_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
