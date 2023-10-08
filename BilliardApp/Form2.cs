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
    public partial class Form2 : Form
    {
        private int selectedTableId;
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public Form2()
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
            while (dr.Read())
            {
                i++;
                dgvTable.Rows.Add(i, dr["tableid"].ToString(), dr["tablename"].ToString(), dr["status"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void dgvTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTable.Rows.Count)
            {
                selectedTableId = Convert.ToInt32(dgvTable.Rows[e.RowIndex].Cells[1].Value);
                // Sử dụng selectedTableId theo nhu cầu của bạn
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedTableId > 0)
            {
                // Bắt đầu phiên chơi
                int phienId = PoolTimeFunctions.StartSession("Admin", selectedTableId);

                // Hiển thị thông báo
                MessageBox.Show("Đã bắt đầu phiên chơi mới. PhienId = " + phienId);

                // Cập nhật lại danh sách bàn chơi
                LoadTable();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bàn để bắt đầu phiên chơi.");
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (selectedTableId > 0)
            {
                // Kết thúc phiên chơi và tính tiền
                PoolTimeFunctions.EndSession(selectedTableId);

                // Hiển thị thông báo hoặc cập nhật giao diện theo yêu cầu của bạn
                MessageBox.Show("Phiên chơi đã kết thúc và tiền đã được tính toán.");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bàn để thanh toán.");
            }
        }
    }
}
