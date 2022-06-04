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
    public partial class FstockAddDelivery : Form
    {
        DataBase dataBase = new DataBase();
        public FstockAddDelivery()
    {
            InitializeComponent();
            string selectSting = "Select distinct * from Контрагент";
            this.CBprovider.DataSource = dataBase.sqlShow(selectSting);
            this.CBprovider.DisplayMember = "Название"; // столбец для отображения
            this.CBprovider.ValueMember = "Код"; //столбец с id
            this.CBprovider.SelectedIndex = -1;
            dateTimePicker1.MaxDate = DateTime.Today;
        }


        private void CBprovider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBprovider.Text != "")
            {
                string selectSting = "Select Номер From Договор Where Вид = 'Поставка' AND КодКонтрагента = '" + CBprovider.SelectedValue.ToString() + "'";
                this.CBdelivery.DataSource = dataBase.sqlShow(selectSting);
                this.CBdelivery.DisplayMember = "Номер"; // столбец для отображения 
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
            if ((CBcode.Text == "") || (CBprovider.Text == "") || (CBdelivery.Text == "") || (dateTimePicker1.Text == "") || ((dataBase.sqlToString("SELECT КодПоставки FROM Поставка WHERE КодПоставки = '" + CBcode.Text + "'") != null)) )
            {
                MessageBox.Show("Ошибка! Неккоретные данные. \n Попробуйте ещё раз");
            }
            else
            {
                dataBase.closeConnection();
                updateString = "INSERT INTO Поставка VALUES('" + CBcode.Text + "', CAST('" + dateTimePicker1.Text.Replace(".", "-") + "' as date), '" + CBdelivery.Text + "')";
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
    
