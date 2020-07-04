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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonBuyer_Click(object sender, EventArgs e)
        {
            Form formBuyer = new FormBuyer();
            formBuyer.Show();
        }

        private void buttonManagers_Click(object sender, EventArgs e)
        {
            Form formManagers = new FormManagers();
            formManagers.Show();
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            Form formAuto = new FormAuto();
            formAuto.Show();
        }
    }
}
