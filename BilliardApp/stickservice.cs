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
    public partial class stickservice : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public stickservice()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            loadstick();
        }

        public void loadstick()
        {
            int i = 0;
            dgvstick.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM sticks ORDER BY namestick ASC, quantity ASC, price ASC", cn); ;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                int stickid = Convert.ToInt32(dr["stickid"]);
                string namestick = dr["namestick"].ToString();
                string quantity = dr["quantity"].ToString();
                double price = Convert.ToDouble(dr["price"]);
                dgvstick.Rows.Add(i, stickid, namestick, quantity, price);
            }
            dr.Close();
            cn.Close();
        }

        private void dgvstick_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvstick.Columns[e.ColumnIndex].Name;
            if (colName == "dgvdel")
            {
                if (MessageBox.Show("Bạn có muốn xóa bản ghi này không ?", "Xóa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete from sticks where stickid LIKE '" + dgvstick[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Bản ghi đã được xóa thành công.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else if (colName == "dgvedit")
            {

            }
            loadstick();
        }
    }
}
