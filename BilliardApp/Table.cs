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
            dgvTable.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM TABLES ORDER BY TABLENAME", cn);
            dr = cm.ExecuteReader();
            while(dr.Read())
            {
                i++;
                dgvTable.Rows.Add(i, dr["tableid"].ToString(), dr["tablename"].ToString(), dr["status"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            TableModule moduleForm =  new TableModule(this);
            moduleForm.ShowDialog();
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Để thiết lập chỉnh sửa và xóa trong bảng dgv
            string colName = dgvTable.Columns[e.ColumnIndex].Name;
            if(colName == "Delete")
            {
                if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không?", "Xóa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("DELETE FROM TABLES WHERE TableID LIKE '"+ dgvTable[1, e.RowIndex].Value.ToString() +"'", cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Bản ghi đã được xóa thành công!", "POS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (colName == "Edit")
            {
                TableModule tableModule = new TableModule(this);
                tableModule.lblid.Text = dgvTable[1, e.RowIndex].Value.ToString();
                tableModule.txtTableName.Text = dgvTable[2, e.RowIndex].Value.ToString();
                tableModule.btnSave.Enabled = false;
                tableModule.btnUpdate.Enabled = true;
                tableModule.ShowDialog();
            }
            LoadTable();
        }
    }
}
