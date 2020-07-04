using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eks
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            Form registr = new FormRegistr();
            registr.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
