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
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace BilliardApp
{
    public partial class userinfo : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public userinfo()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            loadUserInfo();
        }

        public void loadUserInfo()
        {
            int i = 0;
            dgvUserInfo.Rows.Clear();
            cn.Open();
            cm = new SqlCommand("SELECT * FROM UserInfo ORDER BY fullname ASC, gender ASC, age ASC, email ASC, citizencard ASC, phonenumber ASC, dayofword ASC, position ASC, salaryhour ASC", cn);;
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                int infoid = Convert.ToInt32(dr["InfoId"]); 
                string fullname = dr["fullname"].ToString();
                string gender = dr["gender"].ToString();
                int age = Convert.ToInt32(dr["age"]);
                string email = dr["email"].ToString();
                string citizencard = dr["citizencard"].ToString();
                string phonenumber = dr["phonenumber"].ToString();
                DateTime dayofword = Convert.ToDateTime(dr["dayofword"]); 
                string position = dr["position"].ToString();
                double salaryhour = Convert.ToDouble(dr["salaryhour"]); 

                dgvUserInfo.Rows.Add(i, infoid, fullname, gender, age, email, citizencard, phonenumber, dayofword, position, salaryhour);

            }
            dr.Close();
            cn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            userinfomodule us = new userinfomodule(this);
            us.ShowDialog();
        }

        private void dgvUserInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvUserInfo.Columns[e.ColumnIndex].Name;
            if(colName == "Delete")
            {
                if(MessageBox.Show("Bạn có muốn xóa bản ghi này không ?","Xóa bản ghi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("Delete from UserInfo where InfoId LIKE '" + dgvUserInfo[1,e.RowIndex].Value.ToString() + "'",cn);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Bản ghi đã được xóa thành công.","POS",MessageBoxButtons.OK,MessageBoxIcon.Information);

                }
            }else if (colName == "Edit")
            {
                userinfomodule uf= new userinfomodule(this);
                uf.lblId.Text = dgvUserInfo[1,e.RowIndex].Value.ToString();
                uf.txtfullname.Text= dgvUserInfo[2, e.RowIndex].Value.ToString();
                uf.txtgender.Text= dgvUserInfo[3, e.RowIndex].Value.ToString();
                uf.txtage.Text= dgvUserInfo[4, e.RowIndex].Value.ToString();
                uf.txtemail.Text= dgvUserInfo[5, e.RowIndex].Value.ToString();
                uf.txtcitizencard.Text= dgvUserInfo[6, e.RowIndex].Value.ToString();
                uf.txtphonenumber.Text= dgvUserInfo[7, e.RowIndex].Value.ToString();
                uf.dtpdow.Text= dgvUserInfo[8, e.RowIndex].Value.ToString();
                uf.txtposition.Text= dgvUserInfo[9, e.RowIndex].Value.ToString();
                uf.txtsalaryhour.Text= dgvUserInfo[10, e.RowIndex].Value.ToString();
                uf.btnSave.Enabled = false;
                uf.btnUpdate.Enabled = true;
                uf.ShowDialog();
            }
            loadUserInfo();
        }

        private void txtshare_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            dgvUserInfo.Rows.Clear();
            string searchText = txtshare.Text; 
            cn.Open();
            cm = new SqlCommand("SELECT InfoId, fullname, gender, age, email, citizencard, phonenumber, dayofword, position, salaryhour FROM UserInfo WHERE fullname LIKE @searchText OR gender LIKE @searchText OR age LIKE @searchText OR email LIKE @searchText OR citizencard LIKE @searchText OR phonenumber LIKE @searchText OR dayofword LIKE @searchText OR position LIKE @searchText OR salaryhour LIKE @searchText", cn);
            cm.Parameters.AddWithValue("@searchText", "%" + searchText + "%"); 

            SqlDataReader dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dgvUserInfo.Rows.Add(i, dr["InfoId"].ToString(), dr["fullname"].ToString(), dr["gender"].ToString(), dr["age"].ToString(), dr["email"].ToString(), dr["citizencard"].ToString(), dr["phonenumber"].ToString(), dr["dayofword"].ToString(), dr["position"].ToString(), dr["salaryhour"].ToString());
            }
            dr.Close();
            cn.Close();
        }

        private void btnexportexcel_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = workbook.Sheets[1];
            for (int i = 0; i < dgvUserInfo.Columns.Count; i++)
            {
                worksheet.Cells[1, i + 1] = dgvUserInfo.Columns[i].HeaderText;
            }
            for (int i = 0; i < dgvUserInfo.Rows.Count; i++)
            {
                for (int j = 0; j < dgvUserInfo.Columns.Count; j++)
                {
                    object value = dgvUserInfo.Rows[i].Cells[j].Value;
                    if (value != null)
                    {
                        if (dgvUserInfo.Columns[j].Name == "YourDateTimeColumn") 
                        {
                          
                            worksheet.Cells[i + 2, j + 1] = ((DateTime)value).ToString("yyyy-MM-dd"); 
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = value;
                        }
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 1] = DBNull.Value;
                    }
                }
            }

            // Lưu tệp Excel
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Lưu dữ liệu Excel";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                workbook.Close();
                excelApp.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
                MessageBox.Show("Xuất File Excel thành công!");
            }
            else
            {
                workbook.Close();
                excelApp.Quit();
                Marshal.ReleaseComObject(workbook);
                Marshal.ReleaseComObject(excelApp);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
