using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardApp
{
    public partial class login : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        public string _password = "";
        public bool _isactive;

        public login()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }



        private void btn_DangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            register rt = new register();
            rt.ShowDialog();
            this.Close();
        }

        private void link_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            resetPassword rp = new resetPassword();
            rp.ShowDialog();
            this.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        

private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string _account = "", _role = "";
            string tentk = TB_TaiKhoan.Text;
            string mk = TB_MatKhau.Text;
            try
            {
                if (tentk.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập tên tài khỏan");
                    return;
                }

                else if (mk.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu");
                    return;
                }
                else
                {
                    bool found;
                    cn.Open();
                    cm = new SqlCommand("select * from Users where account = @account and password = @password", cn);
                    cm.Parameters.AddWithValue("@account", TB_TaiKhoan.Text);
                    cm.Parameters.AddWithValue("@password", TB_MatKhau.Text);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        found = true;
                        _account = dr["account"].ToString();
                        _role = dr["role"].ToString();
                        _password = dr["Password"].ToString();

                    }
                    else
                    {
                        found = false;
                    }
                    dr.Close();
                    cn.Close();

                    if (found)
                    {
                        if (_role == "Admin")
                        {
                            MessageBox.Show("Chào mừng " + _account + "", "Chấp nhận truy cập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TB_TaiKhoan.Clear();
                            TB_MatKhau.Clear();
                            this.Hide();
                            Form1 form1 = new Form1();
                            form1.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Chào mừng :" + _account + "", "Chấp nhận truy cập", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            TB_TaiKhoan.Clear();
                            TB_MatKhau.Clear();
                            this.Hide();
                            Form2 nvt = new Form2();
                            nvt.ShowDialog();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
                    }
                }

            }catch(Exception) {
                throw;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
