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
    public partial class frmExpiration : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";
        
        public frmExpiration()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cn.Open();
            cm = new SqlCommand("DELETE FROM tblBrowseExp", cn);
            cm.ExecuteNonQuery();
            cn.Close();
            this.Close();
        }

        private void dataGridViewExpDate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewExpDate.Columns[e.ColumnIndex].Name;
            string id = dataGridViewExpDate[4, e.RowIndex].Value.ToString();
            
            int i = 0;
            string num = dataGridViewExpDate[0, e.RowIndex].Value.ToString();
            if (colName == "Select")
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO tblBrowseExp (num, Expiration_Date, Quantity, Price) VALUES(@num, @Expiration_Date, @Quantity, @Price)", cn);
                    cm.Parameters.AddWithValue("@num", int.Parse(id.ToString()));
                    cm.Parameters.AddWithValue("@Expiration_Date", DateTime.Parse(dataGridViewExpDate[1, e.RowIndex].Value.ToString()).ToShortDateString());
                    cm.Parameters.AddWithValue("@Quantity", int.Parse(dataGridViewExpDate[2, e.RowIndex].Value.ToString()));
                    cm.Parameters.AddWithValue("@Price", double.Parse(lblPrice.Text));
                    cm.ExecuteNonQuery();
                    dataGridViewExpDate.Rows.RemoveAt(dataGridViewExpDate.CurrentRow.Index);
                    
                    cn.Close();



                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblBrowseExp WHERE num LIKE '" + id.ToString() + "' ", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i += 1;
                        dataGridViewSelected.Rows.Add(i, DateTime.Parse(dr[1].ToString()).ToShortDateString(), dr[2].ToString(), dr[4].ToString(), Properties.Resources._Add, Properties.Resources._Delete, dr[0].ToString());
                        
                    }
                    dr.Close();
                    cn.Close();
                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void dataGridViewSelected_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridViewSelected.Columns[e.ColumnIndex].Name;
            string id = dataGridViewSelected[6, e.RowIndex].Value.ToString();
            int i = 0;
            if (colName == "Delete")
            {

                try
                {
                    dataGridViewSelected.Rows.RemoveAt(dataGridViewSelected.CurrentRow.Index);

                    cn.Open();
                    cm = new SqlCommand("SELECT * FROM tblBrowseExp WHERE num LIKE '" + id.ToString() + "' ", cn);
                    dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        i += 1;
                        dataGridViewExpDate.Rows.Add(i, DateTime.Parse(dr[1].ToString()).ToShortDateString(), dr[2].ToString(), Properties.Resources.AddNew, dr[0].ToString());

                    }
                    dr.Close();
                    cn.Close();

                }
                catch (Exception ex)
                {
                    cn.Close();
                    MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (dataGridViewSelected.Rows.Count == 0)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM tblBrowseExp", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                }
            }else if (colName == "plus")
            {
                
                dataGridViewSelected.Rows[e.RowIndex].Cells["Qty"].ReadOnly = false;
                dataGridViewSelected.CurrentCell = dataGridViewSelected.Rows[e.RowIndex].Cells["Qty"];
                dataGridViewSelected.BeginEdit(true);

                //int stocks = int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString());
                //if ((int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString()) < 1) || ((int.Parse(dataGridViewSelected[2, e.RowIndex].Value.ToString()) > stocks)))
                //{
                //    dataGridViewSelected[2, e.RowIndex].Value = stocks.ToString();
                //}

            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSelected_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {


        }
    }
}
