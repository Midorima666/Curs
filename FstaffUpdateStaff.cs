using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace optbaze
{
    public partial class FstaffUpdateStaff : Form
    {
        DataBase dataBase = new DataBase();
        Fmenu fmenu;
        public FstaffUpdateStaff(Fmenu menu)
            {
                InitializeComponent();
                fmenu = menu;
                string selectSting = "SELECT DISTINCT Должность from Сотрудник";
                this.CBpost.DataSource = dataBase.sqlShow(selectSting);
                this.CBpost.DisplayMember = "Должность"; // столбец для отображения
                this.CBpost.ValueMember = "Должность"; //столбец с id
                this.CBpost.SelectedIndex = -1;

                selectSting = "SELECT Паспорт from Сотрудник Where Паспорт != '"+ fmenu.pass + "'";
                this.CBpass.DataSource = dataBase.sqlShow(selectSting);
                this.CBpass.DisplayMember = "Паспорт"; // столбец для отображения
                this.CBpass.ValueMember = "Паспорт"; //столбец с id
                this.CBpass.SelectedIndex = -1;
            }
            private void CBpass_SelectedIndexChanged(object sender, EventArgs e)
            {
                string selectSting = " FROM Сотрудник WHERE Паспорт = '"+ CBpass.SelectedValue +"'";
                CBsecondName.Text = dataBase.sqlToString("SELECT Фамилия" + selectSting);
                CBname.Text = dataBase.sqlToString("SELECT Имя" + selectSting);
                CBpatronymic.Text = dataBase.sqlToString("SELECT Отчество" + selectSting); 
                CBpost.Text = dataBase.sqlToString("SELECT Должность" + selectSting); 
                CBadress.Text = dataBase.sqlToString("SELECT Адрес" + selectSting);
                TBphone.Text = dataBase.sqlToString("SELECT Телефон" + selectSting);
                TBemail.Text = dataBase.sqlToString("SELECT email" + selectSting);
                TBpass.Text = dataBase.sqlToString("SELECT password" + selectSting);
            }

            private void amountspace_KeyPress(object sender, KeyPressEventArgs e)
            {
                char number = e.KeyChar;
                if (!Char.IsDigit(number) && number != 8 && number != 43) // цифры, клавиша BackSpace, пробел
                {
                    e.Handled = true;
                }
            }

            private void amountplus_KeyPress(object sender, KeyPressEventArgs e)
            {
                char number = e.KeyChar;
                if (!Char.IsDigit(number) && number != 8 && number != 240) // цифры, клавиша BackSpace, +
                {
                    e.Handled = true;
                }
            }

            private void BAdd_Click(object sender, EventArgs e)
            {
                string updateString = "";
                if ((CBpass.Text == "") || (CBsecondName.Text == "") || (CBname.Text == "") || (CBpatronymic.Text == "") || (CBpost.Text == "") || (CBadress.Text == "") || (CBstatus.Text == ""))
                {
                    MessageBox.Show("Ошибка! Неккоретные данные. \n Попробуйте ещё раз");
                }
                else
                {
                    updateString = "UPDATE Сотрудник SET Фамилия = '" + CBsecondName.Text + "', Имя = '" + CBname.Text + "', Отчество = '" + CBpatronymic.Text + "', Должность = '" + CBpost.Text + "', Адрес = '" + CBadress.Text + "'";
                    if (TBphone.Text != "")
                    {
                        updateString += ", Телефон = '" + TBphone.Text + "'";
                    }
                    else
                    {
                        updateString += ", Телефон = NULL";
                    }
                    if (TBemail.Text != "")
                    {
                        updateString += ", email = '" + TBemail.Text + "'";
                    }
                    else
                    {
                        updateString += ", email = NULL";
                    }
                    if (TBpass.Text != "")
                    {
                        updateString += ", password = '" + TBpass.Text + "'";
                    }
                    else
                    {
                        updateString += ", password = NULL";
                    }
                    updateString += ", Статус = '" + CBstatus.Text + "'" + " WHERE Паспорт = '" + CBpass.Text + "'";
                    dataBase.sqlUpdate(updateString);
                    this.Close();
                }
            }

            private void BCancel_Click(object sender, EventArgs e)
            {
                this.Close();
            }


    }
}
