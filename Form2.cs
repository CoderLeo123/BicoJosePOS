﻿using System;
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
    public partial class frmItemsList : Form
    {
        public frmItemsList()
        {
            InitializeComponent();
            for(int i=0; i<=10; i++)
            {
                dataGridView1.Rows.Add(1, "1", "Brand 1");
            }
        }
    }
}
