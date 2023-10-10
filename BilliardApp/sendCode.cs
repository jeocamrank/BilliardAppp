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
    public partial class sendCode : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        string email = resetPassword.to;
        public sendCode()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }

        private void BT_QuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.ShowDialog();
            this.Close();
        }

        private void BT_DongY_Click(object sender, EventArgs e)
        {
            if (TB_MatKhauMoi.Text == TB_NhapLaiMatKhauMoi.Text)
            {
                cn.Open();
                string newPassword = TB_MatKhauMoi.Text;
                string q = "update [Users] set [Password]='" + newPassword + "' where Email='" + email + "'";
                SqlCommand cmd = new SqlCommand(q, cn);
                cmd.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("Mật khẩu đã được thay đổi thành công!");
                this.Hide();
                login lg = new login();
                lg.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Mật khẩu mới của bạn không trùng khớp!");
            }

        }
    }
}
