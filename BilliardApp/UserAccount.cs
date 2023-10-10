using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardApp
{
    public partial class UserAccount : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public UserAccount()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            loadUserAccount();
        }

        public void loadUserAccount()
        {
            int i = 0;
            dgvUserAccount.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM Users ORDER BY account ASC, password ASC, email ASC, role ASC", cn); ;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                int userid = Convert.ToInt32(dr["UserId"]);
                string account = dr["account"].ToString();
                string password = dr["password"].ToString();
                string email = dr["email"].ToString();
                string role = dr["role"].ToString();
                dgvUserAccount.Rows.Add(i, userid, account, password, email, role);

            }
            dr.Close();
            cn.Close();
        }

        private void txtshare_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            dgvUserAccount.Rows.Clear();
            string searchText = txtshare.Text;
            cn.Open();
            cm = new SqlCommand("SELECT UserId, account, password, email, role  FROM Users WHERE account LIKE @searchText OR password LIKE @searchText OR email LIKE @searchText OR role LIKE @searchText", cn);
            cm.Parameters.AddWithValue("@searchText", "%" + searchText + "%");

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUserAccount.Rows.Add(i, dr["UserId"].ToString(), dr["account"].ToString(), dr["password"].ToString(), dr["email"].ToString(), dr["role"].ToString());
            }
            dr.Close();
            cn.Close();
        }
    }
}
