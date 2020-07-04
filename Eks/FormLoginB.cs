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
    public partial class FormLoginB : Form
    {
        public struct buyers
        {
            public string Login;
            public string Password;
        }
        public FormLoginB()
        {
            InitializeComponent();
            if (FormLogin.login.Login1 == "Buyers") buttonLogin.Enabled = false;
            labelWelcom.Text = "Добро пожаловать!" + FormLogin.login.Login1;
        }

        private void buttonRegistr_Click(object sender, EventArgs e)
        {
            Form registr = new FormRegistr();
            registr.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                bool key = false;
                foreach (Login login in Program.eks.Login)
                {
                    if (textBoxLogin.Text == login.Login1 && textBoxPassword.Text == login.Password)
                    {
                        key = true;
                        login.Login1 = login.Login1;
                        login.Password = login.Password;
                    }
                    if (!key)
                    {
                        MessageBox.Show("Проверьте данные", "Пользователь не найдем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textBoxLogin.Text = " ";
                        textBoxPassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Данные введены верно", "Пользователь найдем", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormMain formMain = new FormMain();
                        formMain.Show();
                        this.Hide();
                    }
                }
            }
        } }}
