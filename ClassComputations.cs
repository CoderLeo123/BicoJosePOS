using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Capstone
{
    internal class ClassComputations
    {
        SqlConnection cn = new SqlConnection();
        //SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string title = "BICO-JOSE System";

        public void GetCartTotal(Label labelDiscount, Label labelSalesTotal, Label labelPayment, Label labelNetTotal)
        {//lblDiscount, lblSalesTotal, lblPayment, lblNetTotal
            double discount = double.Parse(labelDiscount.Text);
            double grossSales = double.Parse(labelSalesTotal.Text);
            double payment = double.Parse(labelPayment.Text);
            double netTotal = grossSales - discount;
            //double change = netTotal - payment;
            //labelNetTotal = new Label();
            labelNetTotal.Text = netTotal.ToString("#,##0.00");
            //return labelNetTotal;
        }

        public void Compute(TextBox textQuantity, Label labelPrice, Label labelTotal)
        {//txtQuantity, lblPrice2, lblTotal
            try
            {
                float total = float.Parse(labelPrice.Text) * float.Parse(textQuantity.Text);
                labelTotal.Text = total.ToString("#.##");
            }
            catch (Exception ex)
            {
                cn.Close();
                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ComputeUnitTotal(DataGridView dgv)
        {//dataGridViewCart
            if (dgv.Rows.Count > 0)
            {
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    //int i = dataGridViewCart.SelectedRows[0].Index;
                    float price = float.Parse(dgv.Rows[i].Cells[3].Value.ToString());
                    int qty = int.Parse(dgv.Rows[i].Cells[4].Value.ToString());
                    float total;
                    try
                    {
                        total = float.Parse(price.ToString()) * int.Parse(qty.ToString());
                        dgv.Rows[i].Cells[6].Value = total.ToString("00.00");

                    }
                    catch (Exception ex)
                    {
                        cn.Close();
                        MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        

    }
}



//public void ComputeUnitTotal()
        //{
        //    if (dataGridViewCart.Rows.Count > 0)
        //    {
        //        for (int i = 0; i < dataGridViewCart.Rows.Count; i++)
        //        {
        //            //int i = dataGridViewCart.SelectedRows[0].Index;
        //            float price = float.Parse(dataGridViewCart.Rows[i].Cells[3].Value.ToString());
        //            int qty = int.Parse(dataGridViewCart.Rows[i].Cells[4].Value.ToString());
        //            float total;
        //            try
        //            {
        //                total = float.Parse(price.ToString()) * int.Parse(qty.ToString());
        //                dataGridViewCart.Rows[i].Cells[6].Value = total.ToString("00.00");

//            }
//            catch (Exception ex)
//            {
//                cn.Close();
//                MessageBox.Show(ex.Message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
//            }
//        }
//    }
//}