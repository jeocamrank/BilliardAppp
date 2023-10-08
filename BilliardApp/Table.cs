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
    public partial class Table : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public Table()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            LoadTable();
        }

        public void LoadTable()
        {
            int i = 0;
            dgvEmployee.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM TABLES ORDER BY TABLENAME", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dgvEmployee.Rows.Add(i, dr["tableid"].ToString(), dr["tablename"].ToString(), dr["status"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TableModule moduleForm =  new TableModule(this);
            moduleForm.ShowDialog();
        }
    }
}
