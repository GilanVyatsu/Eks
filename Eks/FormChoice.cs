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
    public partial class FormChoice : Form
    {
        public FormChoice()
        {
            InitializeComponent();
        }

        private void buttonManager_Click(object sender, EventArgs e)
        {
            Form manager = new FormLogin();
            manager.Show();
        }

        private void buttonBuyer_Click(object sender, EventArgs e)
        {
            Form loginB = new FormLoginB();
            loginB.Show();
        }
    }
}
