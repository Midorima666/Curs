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
    public partial class ForderAdd : Form
    {
        DataBase dataBase = new DataBase();

        public ForderAdd()
        {
            InitializeComponent();
            string selectSting = "Select distinct * from Договор WHERE Вид = 'Продажа'";
            this.CBnubmer.DataSource = dataBase.sqlShow(selectSting);
            this.CBnubmer.DisplayMember = "Номер"; // столбец для отображения
            this.CBnubmer.ValueMember = "Номер"; //столбец с id
            this.CBnubmer.SelectedIndex = -1;

            selectSting = "Select Код, (Код + ' ' + Наименование + ' ' + CONVERT(varchar(10), ЦенаПродажи)) as 'Имя' from Товар";
            this.CBgoods.DataSource = dataBase.sqlShow(selectSting);
            this.CBgoods.DisplayMember = "Имя"; // столбец для отображения
            this.CBgoods.ValueMember = "Код"; //столбец с id
            this.CBgoods.SelectedIndex = -1;

            selectSting = "Select distinct Паспорт, Фамилия + ' ' + Имя + ' ' + Отчество As ФИО from Сотрудник WHERE Должность = 'Менеджер' AND Статус = 'Работает'";
            this.CBstaff.DataSource = dataBase.sqlShow(selectSting);
            this.CBstaff.DisplayMember = "ФИО"; // столбец для отображения
            this.CBstaff.ValueMember = "Паспорт"; //столбец с id
            this.CBstaff.SelectedIndex = -1;
             dateTimePicker1.MaxDate = DateTime.Today;
        }


        private void CBgoods_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBgoods.Text != "")
            {
                string selectSting = "Select Количество From Товар Where Код = '" + CBgoods.SelectedValue.ToString() + "'";
                this.CBamount.DataSource = dataBase.sqlShow(selectSting);
                this.CBamount.DisplayMember = "Количество"; // столбец для отображения 
            }
        }

        private void CBnubmer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBnubmer.Text != "")
            {
                string selectSting = "Select distinct Адрес From Контрагент, Договор Where Код = КодКонтрагента AND Номер ='" + CBnubmer.SelectedValue.ToString() + "'";
                this.CBadress.DataSource = dataBase.sqlShow(selectSting);
                this.CBadress.DisplayMember = "Адрес"; // столбец для отображения 
            }
        }

        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры, клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            string updateString = "";
            int result, last;
            if ((CBnubmer.Text == "") || (CBgoods.Text == "") || (CBstaff.Text == "") || (CBadress.Text == "") || (CBamount.Text == "") || (System.Int32.TryParse(CBamount.Text, out result) == false))
            {
                MessageBox.Show("Ошибка! Неккоретные данные. \n Попробуйте ещё раз");
            }
            else
            {
                last = Convert.ToInt32(dataBase.sqlToString("SELECT TOP 1 Код FROM ЗаявкаНаПродажу ORDER BY Код DESC")) + 1;
                dataBase.closeConnection();
                updateString = "INSERT INTO ЗаявкаНаПродажу VALUES(" + last + ", CAST('" + dateTimePicker1.Text.Replace(".", "-") + "' as date), '" + CBnubmer.SelectedValue.ToString() + "', '" + CBgoods.SelectedValue.ToString() + "', '" + CBstaff.SelectedValue.ToString() + "', NULL, '" + CBadress.Text + "' , NULL, " + Convert.ToInt32(CBamount.Text) + ", DEFAULT, DEFAULT)";
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
