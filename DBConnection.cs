using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone
{
    internal class DBConnection
    {
        public string MyConnection()
        {
            string con = @"Data Source=(localdb)\Capstone;Initial Catalog=CapstoneDB;Integrated Security=True";
            return con;
        }
    }
}
