using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace BilliardApp
{
    public partial class userinfomodule : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        userinfo Userinfo;
        public userinfomodule(userinfo ui)
        {
            InitializeComponent();
            cn = new SqlConnection(dbcon.myConnection());
            Userinfo = ui;
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose(); 

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc muốn thêm nhân viên này không?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cn.Open();
                    cm = new SqlCommand("INSERT INTO UserInfo(fullname, gender,age,email,citizencard,phonenumber,dayofword,position,salaryhour) VALUES(@fullname, @gender,@age,@email,@citizencard,@phonenumber,@dayofword,@position,@salaryhour)", cn);
                    cm.Parameters.AddWithValue("@fullname", txtfullname.Text);
                    cm.Parameters.AddWithValue("@gender", txtgender.Text);
                    cm.Parameters.AddWithValue("@age", txtage.Text);
                    cm.Parameters.AddWithValue("@email", txtemail.Text);
                    cm.Parameters.AddWithValue("@citizencard", txtcitizencard.Text);
                    cm.Parameters.AddWithValue("@phonenumber", txtphonenumber.Text);
                    cm.Parameters.AddWithValue("@dayofword", dtpdow.Text);
                    cm.Parameters.AddWithValue("@position", txtposition.Text);
                    cm.Parameters.AddWithValue("@salaryhour", txtsalaryhour.Text);
                    cm.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Bản ghi đã được lưu thành công", "POS");
                    Clear();
                    Userinfo.loadUserInfo();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clear()
        {
            txtfullname.Clear();
            txtgender.SelectedItem = null;
            txtage.Clear();
            txtemail.Clear();
            txtcitizencard.Clear();
            txtphonenumber.Clear();
            dtpdow.Value = DateTime.Now;
            txtposition.SelectedItem = null;
            txtsalaryhour.Clear();
            btnUpdate.Enabled = false;
            btnSave.Enabled = true;
            txtfullname.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn cập nhập không?","Cập nhập", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cn.Open();
                cm = new SqlCommand("UPDATE UserInfo set fullname= @fullname, gender = @gender,age=@age,email=@email,citizencard=@citizencard,phonenumber = @phonenumber,dayofword=@dayofword,position=@position,salaryhour=@salaryhour where InfoId LIKE '"+lblId.Text+"'",cn);
                cm.Parameters.AddWithValue("@fullname", txtfullname.Text);
                cm.Parameters.AddWithValue("@gender", txtgender.Text);
                cm.Parameters.AddWithValue("@age", txtage.Text);
                cm.Parameters.AddWithValue("@email", txtemail.Text);
                cm.Parameters.AddWithValue("@citizencard", txtcitizencard.Text);
                cm.Parameters.AddWithValue("@phonenumber", txtphonenumber.Text);
                cm.Parameters.AddWithValue("@dayofword", dtpdow.Text);
                cm.Parameters.AddWithValue("@position", txtposition.Text);
                cm.Parameters.AddWithValue("@salaryhour", txtsalaryhour.Text);
                cm.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Bạn đã cập nhập thành công!", "POS");
                Clear();
                this.Dispose();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
