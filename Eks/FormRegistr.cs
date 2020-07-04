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
    public partial class FormRegistr : Form
    {
        public FormRegistr()
        {
            InitializeComponent();
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            Registr registr = new Registr();
            registr.Login = textBoxLogin.Text;
            registr.Password = textBoxPassword.Text;
        }
    }
}
