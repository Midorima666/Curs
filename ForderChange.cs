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
    public partial class ForderChange : Form
    {
        DataBase dataBase = new DataBase();
        int send, require, available;
        public ForderChange()
        {
            InitializeComponent();
            string selectSting = "Select distinct Контрагент.Код,  Контрагент.Название from ЗаявкаНаПродажу, Контрагент, Договор Where Контрагент.Код = КодКонтрагента AND НомерДоговора = Номер";
            this.CBbuyer.DataSource = dataBase.sqlShow(selectSting);
            this.CBbuyer.DisplayMember = "Название"; // столбец для отображения
            this.CBbuyer.ValueMember = "Код"; //столбец с id
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
            if ((CBbuyer.SelectedIndex == -1) || (CBid.SelectedIndex == -1) || (TBgoods.Text == "") || (CBamount.Value == 0))
            {
                MessageBox.Show("Ошибка! Неккоретные данные. \n Попробуйте ещё раз");
            }
            else
            {
                dataBase.closeConnection();
                int k, str;
                dataBase.sqlUpdate("UPDATE ЗаявкаНаПродажу SET КоличествоОтправленного = " + Convert.ToInt32(CBamount.Value+ send) + " WHERE ЗаявкаНаПродажу.Код = '" + CBid.SelectedValue.ToString() + "'");
                int i = Convert.ToInt32(CBamount.Value);
                while (i > 0)
                {
                    k = Convert.ToInt32(dataBase.sqlToString("Select top 1 Количество From Товар Where Наименование = '" + TBgoods.Text + "' AND Количество > 0"));
                    str = Convert.ToInt32(dataBase.sqlToString("Select top 1 Код From Товар Where Наименование = '" + TBgoods.Text + "' AND Количество > 0"));
                    if (i - k > 0) 
                    {
                        dataBase.sqlUpdate("UPDATE Товар SET Количество = " + 0 + " Where Код = '" + str.ToString() + "'");
                        i += -k;
                    }
                    else
                    {
                        dataBase.sqlUpdate("UPDATE Товар SET Количество = " + (k - i) + " Where Код = '" + str.ToString() + "'");
                        i = 0;
                    }
                }
                send = Convert.ToInt32(dataBase.sqlToString("Select КоличествоОтправленного From ЗаявкаНаПродажу Where Код = " + CBid.SelectedValue));
                if (require == send)
                {
                    dataBase.sqlUpdate("UPDATE ЗаявкаНаПродажу SET Статус = 'Отправлено' Where Код = " + CBid.SelectedValue);
                }
                else dataBase.sqlUpdate("UPDATE ЗаявкаНаПродажу SET Статус = 'В процессе' Where Код = " + CBid.SelectedValue);
                this.Close();
            }
        }
        private void BCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TBgoods_TextChanged(object sender, EventArgs e)
        {
            if (TBgoods.Text != "")
            {
                send = Convert.ToInt32(dataBase.sqlToString("Select КоличествоОтправленного From ЗаявкаНаПродажу Where Код = " + CBid.SelectedValue));
                require = Convert.ToInt32(dataBase.sqlToString("Select КоличествоТовара From ЗаявкаНаПродажу Where Код = " + CBid.SelectedValue));
                available = Convert.ToInt32(dataBase.sqlToString("Select SUM(Количество) From Товар Where Наименование = '" + TBgoods.Text + "'"));
                if (require - send <= available)
                    CBamount.Maximum = require - send;
                else CBamount.Maximum = available;
                CBamount.Value = CBamount.Maximum;
            }
        }

        private void CBbuyer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectSting = "Select distinct ЗаявкаНаПродажу.Код from ЗаявкаНаПродажу, Договор, Контрагент Where НомерДоговора = Номер AND КодКонтрагента = '" + this.CBbuyer.SelectedValue.ToString() + "'";
            this.CBid.DataSource = dataBase.sqlShow(selectSting);
            this.CBid.DisplayMember = "Код"; // столбец для отображения
            this.CBid.ValueMember = "Код"; //столбец с id/
        }        

        private void CBid_SelectedIndexChanged(object sender, EventArgs e)
        {
            TBgoods.Text = dataBase.sqlToString("Select Наименование from ЗаявкаНаПродажу, Товар Where Товар.Код = КодТовара AND ЗаявкаНаПродажу.Код = '" + this.CBid.SelectedValue.ToString() + "'");
        }
    }
}
