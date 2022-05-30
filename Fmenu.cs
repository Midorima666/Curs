using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace optbaze
{
    public partial class Fmenu : Form
    {
        DataBase dataBase = new DataBase();
        public string post = "";
        public Fmenu()
        {
            InitializeComponent();
        }

        private void Border_Click(object sender, EventArgs e)
        {
            Forder forder = new Forder(this);
            this.Visible = false;
            forder.Show();
        }

        private void Bstock_Click(object sender, EventArgs e)
        {
            Fstock fstock = new Fstock(this);
            this.Visible = false;
            fstock.Show();
        }

        private void Bcontr_Click(object sender, EventArgs e)
        {
            Fpartner fpartner = new Fpartner(this);
            this.Visible = false;
            fpartner.Show();
        }
        private void Bstaff_Click(object sender, EventArgs e)
        {
            if (post != "")
            {
                Fstaff fstaff = new Fstaff(this);
                this.Visible = false;
                fstaff.Show();
            }
            else
            {
                MessageBox.Show("Нет доступа. Авторизируйтесь");
            }
        }

        private void Fmenu_FormClosed(object sender, FormClosedEventArgs e)
        {
             Application.Exit();
        }

        private void Benter_Click(object sender, EventArgs e)
        {
            post = "";
            if ((Tusername.Text == "") || (Tpassword.Text == ""))
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else
            {
                if (dataBase.sqlToString("SELECT email FROM Сотрудник WHERE email = '" + Tusername.Text + "'") == null)
                {
                    MessageBox.Show("Данного пользователя не существует");
                }
                else
                {
                    if ((dataBase.sqlToString("SELECT password FROM Сотрудник WHERE email = '" + Tusername.Text + "'") == ""))
                    {
                        MessageBox.Show("Данный пользователь не зарегестрирован!\nОбратитесь к администратору");
                    }
                    else
                    {
                        if ((dataBase.sqlToString("SELECT password FROM Сотрудник WHERE email = '" + Tusername.Text + "'") != Tpassword.Text))
                        {
                            MessageBox.Show("Неверный пароль!");
                        }
                        else
                        {
                            MessageBox.Show("Добро пожаловать, " + dataBase.sqlToString("SELECT Имя + Отчество FROM Сотрудник WHERE email = '" + Tusername.Text + "'"));
                            post = dataBase.sqlToString("SELECT Должность FROM Сотрудник WHERE email = '" + Tusername.Text + "'");
                        }
                    }
                }
            }
        }
    }
}
