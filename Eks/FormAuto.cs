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
    public partial class FormAuto : Form
    {
        public FormAuto()
        {
            InitializeComponent();
            ShowAuto();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxColor.SelectedItem != null)
            {
                Auto auto = new Auto();
                auto.Model = textBoxModel.Text;
                auto.Number = Convert.ToString(textBoxNumber.Text);
                auto.Release = Convert.ToDateTime(textBoxRelease.Text);
                auto.Price = Convert.ToInt32(textBoxPrice.Text);


                if (comboBoxColor.SelectedIndex == 0)
                {
                    auto.Color = 0;
                }
                if (comboBoxColor.SelectedIndex == 1)
                {
                    auto.Color = 1;
                }
                if (comboBoxColor.SelectedIndex == 2)
                {
                    auto.Color = 2;
                }
                if (comboBoxColor.SelectedIndex == 3)
                {
                    auto.Color = 3;
                }
                Program.eks.Auto.Add(auto);
                Program.eks.SaveChanges();
                ShowAuto();
            }
        }
        void ShowAuto()
        {
            listViewAuto.Items.Clear();
            foreach (Auto auto in Program.eks.Auto)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    auto.idAuto.ToString(), auto.Model, auto.Color.ToString(), auto.Price.ToString(),
                    auto.Number, auto.Release.ToString(),
                });
                item.Tag = auto;
                listViewAuto.Items.Add(item);
            }
            listViewAuto.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listViewAuto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAuto.SelectedItems.Count == 1)
            {
                Auto auto = listViewAuto.SelectedItems[0].Tag as Auto;
                textBoxModel.Text = auto.Model;
                textBoxNumber.Text = auto.Number;
                textBoxRelease.Text = auto.Release.ToString();
                textBoxPrice.Text = Convert.ToString(auto.Price);
                comboBoxColor.SelectedIndex = comboBoxColor.FindString(auto.Color.ToString());
            }
            else
            {
                textBoxModel.Text = "";
                textBoxNumber.Text = "";
                textBoxRelease.Text = "";
                textBoxPrice.Text = "";
                comboBoxColor.SelectedItem = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAuto.SelectedItems.Count == 1)
            {
                Auto auto = listViewAuto.SelectedItems[0].Tag as Auto;
                if (comboBoxColor.SelectedIndex == 0)
                {
                    auto.Model = textBoxModel.Text;
                    auto.Number = Convert.ToString(textBoxNumber.Text);
                    auto.Release = Convert.ToDateTime(textBoxRelease.Text);
                    auto.Price = Convert.ToInt32(textBoxPrice.Text);
                    auto.Color = 0;
                    Program.eks.SaveChanges();
                    ShowAuto();
                }
                if (comboBoxColor.SelectedIndex == 1)
                {
                    auto.Model = textBoxModel.Text;
                    auto.Number = Convert.ToString(textBoxNumber.Text);
                    auto.Release = Convert.ToDateTime(textBoxRelease.Text);
                    auto.Price = Convert.ToInt32(textBoxPrice.Text);
                    auto.Color = 1;
                    Program.eks.SaveChanges();
                    ShowAuto();
                }
                if (comboBoxColor.SelectedIndex == 2)
                {
                    auto.Model = textBoxModel.Text;
                    auto.Number = Convert.ToString(textBoxNumber.Text);
                    auto.Release = Convert.ToDateTime(textBoxRelease.Text);
                    auto.Price = Convert.ToInt32(textBoxPrice.Text);
                    auto.Color = 2;
                    Program.eks.SaveChanges();
                    ShowAuto();
                }
                if (comboBoxColor.SelectedIndex == 3)
                {
                    auto.Model = textBoxModel.Text;
                    auto.Number = Convert.ToString(textBoxNumber.Text);
                    auto.Release = Convert.ToDateTime(textBoxRelease.Text);
                    auto.Price = Convert.ToInt32(textBoxPrice.Text);
                    auto.Color = 3;
                    Program.eks.SaveChanges();
                    ShowAuto();
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAuto.SelectedItems.Count == 1)
                {
                    Auto auto = listViewAuto.SelectedItems[0].Tag as Auto;
                    Program.eks.Auto.Remove(auto);
                    Program.eks.SaveChanges();
                    ShowAuto();
                }
                textBoxModel.Text = "";
                textBoxNumber.Text = "";
                textBoxRelease.Text = "";
                textBoxPrice.Text = "";
                comboBoxColor.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
