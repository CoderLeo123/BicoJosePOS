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
namespace Capstone
{
    public partial class frmDashboardDetails : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        public frmDashboardDetails()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            InitializeComponent();
            LoadCriticalStock();
            LoadOutOfStock();
            LoadUsers();
        }


        public void LoadCriticalStock()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dataGridViewCritical.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblItem WHERE Quantity < 3 AND Quantity > 0 AND Lense_Check = 1 Order by Item_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //                                              2-TYPE / 2-TYPE       
                i += 1; //          0-#  1-DESCRIPTION / 1-Description           3-STOCK / 3-Quantity    
                dataGridViewCritical.Rows.Add(i, dr[3].ToString(), dr[10].ToString(), dr[5].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadOutOfStock()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dataGridViewOutOfStock.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblItem WHERE Quantity = 0 AND Lense_Check = 1 Order by Item_ID", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //                                              2-TYPE / 2-TYPE       
                i += 1; //          0-#  1-DESCRIPTION / 1-Description           3-STOCK / 3-Quantity    
                dataGridViewOutOfStock.Rows.Add(i, dr[3].ToString(), dr[10].ToString(), dr[5].ToString());
            }
            dr.Close();
            cn.Close();
        }

        public void LoadUsers()
        {
            cn = new SqlConnection(dbcon.MyConnection());
            int i = 0;
            dataGridViewUsers.Rows.Clear();
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT * FROM tblUser Order by Num", cn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                //                                          2-ROLE / 2-User_Type       
                i += 1; //          0-#  1-NAME / 1-Name           
                dataGridViewUsers.Rows.Add(i, dr[4].ToString(), dr[5].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}