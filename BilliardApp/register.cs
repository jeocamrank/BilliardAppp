using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BilliardApp
{
    public partial class register : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;
        public register()
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
        }
        public bool CheckAccount(string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }

        public bool CheckEmail(string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        private void BT_DangKy_Click(object sender, EventArgs e)
        {
            string tentk = TB_TaiKhoan.Text;
            string matkhau = TB_MatKhau.Text;
            string xnmatkhau = TB_NhapLaiMatKhau.Text;
            string email = TB_Email.Text;
            string quyen = TB_Role.SelectedItem.ToString();
            if (!CheckAccount(tentk))
            {
                MessageBox.Show("Vui lòng nhập lại tên tài khoản cho phù hợp!");
                return;
            }
            if (!CheckAccount(matkhau))
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu cho phù hợp!");
                return;
            }
            if (xnmatkhau != matkhau)
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu chính xác");
                return;
            }
            if (!CheckEmail(email))
            {
                MessageBox.Show("Vui lòng nhập lại email cho phù hợp!");
                return;
            }
            using (SqlConnection cn = new SqlConnection(dbcon.myConnection()))
            {
                cn.Open();

                using (SqlCommand cm = new SqlCommand("SELECT COUNT(*) FROM Users WHERE email = @email", cn))
                {
                    cm.Parameters.AddWithValue("@email", TB_Email.Text);

                    int count = Convert.ToInt32(cm.ExecuteScalar());

                    if (count > 0)
                    {
                        MessageBox.Show("Email đã tồn tại vui lòng nhập email khác.");
                    }
                }
            }
            if (tentk.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khỏan!");
                return;
            }

            else if (matkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!");
                return;
            }
            else if (xnmatkhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập lại mật khẩu!");
                return;
            }
            else if (email.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập Email!");
                return;
            }
            else if (quyen.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn quyền!");
                return;
            }
            else
            {
                try
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO Users (account ,password,email,role) VALUES (@account ,@password,@email,@role)", cn);
                    cm.Parameters.AddWithValue("@account", TB_TaiKhoan.Text);
                    cm.Parameters.AddWithValue("@password", TB_MatKhau.Text);
                    cm.Parameters.AddWithValue("@email", TB_Email.Text);
                    cm.Parameters.AddWithValue("@role", TB_Role.Text);
                    cm.ExecuteNonQuery();
                    if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập hay không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        this.Hide();
                        login lg = new login();
                        lg.ShowDialog();
                        this.Close();
                    }

                }
                catch
                {
                    MessageBox.Show("Đăng ký thất bại!");
                }
            }
            
        }

        private void BT_QuayLai_Click(object sender, EventArgs e)
        {
            this.Hide();
            login lg = new login();
            lg.ShowDialog();
            this.Close();
        }

        private void BT_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
