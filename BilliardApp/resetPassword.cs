using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardApp
{
    public partial class resetPassword : Form
    {
        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnect dbcon = new DBConnect();
        SqlDataReader dr;

        string randomcode;
        public static string to;

        public resetPassword()
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

        private void BT_GuiMa_Click(object sender, EventArgs e)
        {
            string from, password, messagebody;
            Random rand = new Random();
            randomcode = rand.Next( 999999).ToString(); 
            MailMessage message = new MailMessage();
            string to = (TB_Email.Text).ToString();
            from = "violetbaka03@gmail.com";
            password = "jmbyxxgecrertzod";
            messagebody = $"Your reset code is {randomcode}";
            message.To.Add(to);
            message.From = new MailAddress(from);
            message.Body = messagebody;
            message.Subject = "Password reset Code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential(from, password);

            try
            {
                smtp.Send(message);
                MessageBox.Show("Code Successfully Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void BT_XacMinh_Click(object sender, EventArgs e)
        {
            if(randomcode == (TB_Code.Text).ToString())
            {
                to = TB_Email.Text;
                this.Hide();
                sendCode sc= new sendCode();
                sc.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Wrong Code");
            }
        }
    }
}
