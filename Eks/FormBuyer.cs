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
    public partial class FormBuyer : Form
    {
        public FormBuyer()
        {
            InitializeComponent();
            ShowBuyer();
        }
        void ShowBuyer()
        {
            listViewBuyer.Items.Clear();
            foreach (Buyer buyer in Program.eks.Buyer)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    buyer.idBuyer.ToString(), buyer.Login, buyer.Password, buyer.FirstName,
                    buyer.MiddleName, buyer.LastName, buyer.Phone, buyer.Email
                });
                item.Tag = buyer;
                listViewBuyer.Items.Add(item);
            }
            listViewBuyer.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Buyer buyer = new Buyer();
            buyer.idBuyer = textBoxidBuyer.Text;
            buyer.Login = textBoxLogin.Text;
            buyer.Password = textBoxPassword.Text;
            buyer.FirstName = textBoxFirstName.Text;
            buyer.MiddleName = textBoxMiddleName.Text;
            buyer.LastName = textBoxLastName.Text;
            buyer.Phone = textBoxPhone.Text;
            buyer.Email = textBoxEmail.Text;
            Program.eks.Buyer.Add(buyer);
            Program.eks.SaveChanges();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewBuyer.SelectedItems.Count == 1)
            {
                Buyer buyer = listViewBuyer.SelectedItems[0].Tag as Buyer;
                buyer.idBuyer = textBoxidBuyer.Text;
                buyer.Login = textBoxLogin.Text;
                buyer.Password = textBoxPassword.Text;
                buyer.FirstName = textBoxFirstName.Text;
                buyer.MiddleName = textBoxMiddleName.Text;
                buyer.LastName = textBoxLastName.Text;
                buyer.Phone = textBoxPhone.Text;
                buyer.Email = textBoxEmail.Text;
                Program.eks.SaveChanges();
                ShowBuyer();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewBuyer.SelectedItems.Count == 1)
                {
                    Buyer buyer = listViewBuyer.SelectedItems[0].Tag as Buyer;
                    Program.eks.Buyer.Remove(buyer);
                    Program.eks.SaveChanges();
                }
                textBoxidBuyer.Text = "";
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется!", "ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewBuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBuyer.SelectedItems.Count == 1)
            {
                Buyer buyer = listViewBuyer.SelectedItems[0].Tag as Buyer;
                buyer.idBuyer = textBoxidBuyer.Text;
                buyer.Login = textBoxLogin.Text;
                buyer.Password = textBoxPassword.Text;
                buyer.FirstName = textBoxFirstName.Text;
                buyer.MiddleName = textBoxMiddleName.Text;
                buyer.LastName = textBoxLastName.Text;
                buyer.Phone = textBoxPhone.Text;
                buyer.Email = textBoxEmail.Text;
            }

            else
            {
                textBoxidBuyer.Text = "";
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }
    }
}
