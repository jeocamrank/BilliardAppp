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
            con = @"Data Source=DESKTOP-8EJEBRE;Initial Catalog=BilliardApp;Integrated Security=True";
            return con;
        }
    }
}
