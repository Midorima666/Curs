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
    public partial class FstaffAddStaff : Form
    {
        DataBase dataBase = new DataBase();
        public FstaffAddStaff()
        {
            InitializeComponent();
            string selectSting = "SELECT DISTINCT Должность from Сотрудник";
            this.CBpost.DataSource = dataBase.sqlShow(selectSting);
            this.CBpost.DisplayMember = "Должность"; // столбец для отображения
            this.CBpost.ValueMember = "Должность"; //столбец с id
            this.CBpost.SelectedIndex = -1;
        }

        private void amountspace_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 32) // цифры, клавиша BackSpace, пробел
            {
                e.Handled = true;
            }
        }

        private void amountplus_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 43) // цифры, клавиша BackSpace, +
            {
                e.Handled = true;
            }
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            string updateString = "";
            if ((CBpass.Text == "") || (CBsecondName.Text == "") || (CBname.Text == "") || (CBpatronymic.Text == "") || (CBpost.Text == "") || (CBadress.Text == "") || ((dataBase.sqlToString("SELECT Паспорт FROM Сотрудник WHERE Паспорт = '" + CBpass.Text + "'") != null)))
            {
                MessageBox.Show("Ошибка! Неккоретные данные. \n Попробуйте ещё раз");
            }
            else
            {
                updateString = "INSERT INTO Сотрудник VALUES('" + CBpass.Text + "', '" + CBsecondName.Text + "', '" + CBname.Text + "', '" + CBpatronymic.Text + "', '" + CBpost.Text + "', '" + CBadress.Text + "'";
                if (TBphone.Text != "")
                {
                    updateString += ", '" + TBphone.Text + "'";
                }
                else
                {
                    updateString += ", NULL";
                }
                if (TBemail.Text != "")
                {
                    updateString += ", '" + TBemail.Text + "'";
                }
                else
                {
                    updateString += ", NULL";
                }
                updateString += ", NULL, DEFAULT)";

                dataBase.closeConnection();
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
