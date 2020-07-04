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
    public partial class FormManagers : Form
    {
        public FormManagers()
        {
            InitializeComponent();
            ShowManagers();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewManagers.SelectedItems.Count == 1)
            {
                Managers managers = listViewManagers.SelectedItems[0].Tag as Managers;
                managers.idManager = textBoxidManager.Text;
                managers.Login = textBoxLogin.Text;
                managers.Password = textBoxPassword.Text;
                managers.FirstName = textBoxFirstName.Text;
                managers.MiddleName = textBoxMiddleName.Text;
                managers.LastName = textBoxLastName.Text;
                Program.eks.SaveChanges();
                ShowManagers();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewManagers.SelectedItems.Count == 1)
                {
                    Managers managers = listViewManagers.SelectedItems[0].Tag as Managers;
                    Program.eks.Managers.Remove(managers);
                    Program.eks.SaveChanges();
                }
                textBoxidManager.Text = "";
                textBoxLogin.Text = "";
                textBoxPassword.Text = "";
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись используется!", "ошибка!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Managers managers = new Managers();
            managers.idManager = textBoxidManager.Text;
            managers.Login = textBoxLogin.Text;
            managers.Password = textBoxPassword.Text;
            managers.FirstName = textBoxFirstName.Text;
            managers.MiddleName = textBoxMiddleName.Text;
            managers.LastName = textBoxLastName.Text;
            Program.eks.Managers.Add(managers);
            Program.eks.SaveChanges();
        }
        void ShowManagers()
        {
            listViewManagers.Items.Clear();
            foreach (Managers managers in Program.eks.Managers)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    managers.idManager.ToString(), managers.Login, managers.Password, managers.FirstName, managers.MiddleName,
                    managers.LastName,
                });
                item.Tag = managers;
                listViewManagers.Items.Add(item);
            }
            listViewManagers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
