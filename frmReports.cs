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
    public partial class frmReports : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        ClassLoadData classLoadData = new ClassLoadData();
        ClassReports classReport = new ClassReports();
        string title = "BICO-JOSE System", transNo = "";
        //List<ItemList> List = new List<ItemList>();
        public frmReports()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.MyConnection());
        }

        private void printDocumentSales_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int x = 0, y = 0;
            System.Drawing.Font printFont = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Regular);
            System.Drawing.Font printFontBold = new System.Drawing.Font("Arial", 15, System.Drawing.FontStyle.Bold);
            System.Drawing.Font printFontItallic = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Italic);

            e.Graphics.DrawString("Bico-Jose Optical Clinic", printFontBold, Brushes.Black, 175, 30);
            e.Graphics.DrawString("Address: 3rd Floor Susana Mart, Tungko San Jose Del Monte Bulacan", printFont, Brushes.Black, 80, 80);            
            e.Graphics.DrawString("Clinic's Contact: 09178326666", printFont, Brushes.Black, 120, 30);//140
            y = 140; x = 320;
            e.Graphics.DrawString("SALES REPORT", printFontBold, Brushes.Black, 175, 30);


        }

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {
            //printPreviewControl preview = new printPreviewControl();
            printPreviewControl.Document = printDocumentSales;

            int pLength = 950;
            //paperSizeUpdate(out pLength);
            printDocumentSales.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("RECEIPT", 610, pLength);
            printPreviewControl.Zoom = 0.75;
            //printPreviewControl.Size = new System.Drawing.Size(400, 650);
            //printPreviewControl.ShowDialog();

        }
    }
}
