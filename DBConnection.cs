using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
namespace Capstone
{
    internal class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=.\SQLEXPRESS01;AttachDbFilename=C:\Users\leomar\source\repos\BicoJosePOS\Database.mdf;Integrated Security=True;User Instance=True";
            return con;

        }

        

    }
}
