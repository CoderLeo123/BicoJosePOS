using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data.SQLite;

namespace Capstone
{
    internal class DBConnection
    {
        public SQLiteConnection MyConnections;

        public string MyConnection()
        {
            MyConnections = new SQLiteConnection("Data Source=Database1.db");
            string setting = ConfigurationManager.AppSettings["setting1"];
            string conn = ConfigurationManager.ConnectionStrings["Dev"].ConnectionString;
            //providerName="System.Data.SqlClient"
            string con = @"Data Source=.\SQLEXPRESS01;AttachDbFilename=C:\Users\leomar\source\repos\BicoJosePOS\Database.mdf;Integrated Security=True;User Instance=True";//user id=sa; password=Caps123; Trusted_Connection=False;User Instance=False Database=Caps;
            
            string con1 = @"Data Source=DESKTOP-80MBCB5\;AttachDbFilename=" + System.IO.Path.GetFullPath("Database.mdf")+ ";user id=sa; password=Caps123;";
           
            string con4 = @"Data Source=DESKTOP-80MBCB5\;AttachDbFilename=D:\Database.mdf;user id=sa; password=Caps123;Database=Caps;";// Checked gumagana

            string con3 = @"Data Source=DESKTOP-80MBCB5\;AttachDbFilename=|DataDirectory|\Database.mdf;Database=Caps;user id=sa; password=Caps123;";
                        
            string con2 = @"Data Source=.\SQLEXPRESS01;AttachDbFilename=|DataDirectory|\Database.mdf;Database=Database;Integrated Security=True;User Instance=True";
            return con4;

        }

        

    }
}
