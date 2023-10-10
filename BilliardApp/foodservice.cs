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
    public partial class foodservice : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public foodservice()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            loadfood();
        }

        public void loadfood()
        {
            int i = 0;
            dgvfood.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM foods ORDER BY namefood ASC, status ASC, price ASC", cn); ;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                int foodid = Convert.ToInt32(dr["foodid"]);
                string namefood = dr["namefood"].ToString();
                string status = dr["status"].ToString();
                double price = Convert.ToDouble(dr["price"]);

                dgvfood.Rows.Add(i, foodid, namefood, status, price);

            }
            dr.Close();
            cn.Close();
        }

        private void dgvfood_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvfood.Columns[e.ColumnIndex].Name;
            if (colName == "dgvdel")
            {
                if (MessageBox.Show("Bạn có muốn xóa bản ghi này không ?", "Xóa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete from foods where foodid LIKE '" + dgvfood[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Bản ghi đã được xóa thành công.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else if (colName == "dgvedit")
            {
             
            }
            loadfood();
        }
    }

}
