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
    public partial class drinkservice : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public drinkservice()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            loaddrink();
        }

        public void loaddrink()
        {
            int i = 0;
            dgvdrink.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM drinks ORDER BY namedrink ASC, quantity ASC, price ASC", cn); ;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                int drinkid = Convert.ToInt32(dr["drinkid"]);
                string namedrink = dr["namedrink"].ToString();
                string quantity = dr["quantity"].ToString();
                double price = Convert.ToDouble(dr["price"]);

                dgvdrink.Rows.Add(i, drinkid, namedrink, quantity, price);

            }
            dr.Close();
            cn.Close();
        }

        private void dgvdrink_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvdrink.Columns[e.ColumnIndex].Name;
            if (colName == "dgvdel")
            {
                if (MessageBox.Show("Bạn có muốn xóa bản ghi này không ?", "Xóa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete from drinks where drinkid LIKE '" + dgvdrink[1, e.RowIndex].Value.ToString() + "'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Bản ghi đã được xóa thành công.", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else if (colName == "dgvedit")
            {

            }
            loaddrink();
        }

    }
}
