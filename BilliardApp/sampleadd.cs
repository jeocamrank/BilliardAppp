using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilliardApp
{
    public partial class sampleadd : Form
    {
        public sampleadd()
        {
            InitializeComponent();
        }

        public virtual void btnsave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void btnclose_Click(object sender, EventArgs e)
        {

        }
    }
}
