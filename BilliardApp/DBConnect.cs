using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilliardApp
{
    internal class DBConnect
    {
        private string con;
        public string myConnection()
        {
            con = @"Data Source=DESKTOP-FC6I5GK;Initial Catalog=BilliardApp;Integrated Security=True";
            return con;
        }
    }
}
