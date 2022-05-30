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
    public partial class FstockAddGoods : Form
    {
        DataBase dataBase = new DataBase();
        public FstockAddGoods()
        {
            InitializeComponent();
            string selectSting = "Select distinct * from Контрагент";
            this.CBprovider.DataSource = dataBase.sqlShow(selectSting);
            this.CBprovider.DisplayMember = "Название"; // столбец для отображения
            this.CBprovider.ValueMember = "Код"; //столбец с id
            this.CBprovider.SelectedIndex = -1;
        }

        private void CBprovider_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBprovider.Text != "")
            {
                string selectSting = "Select КодПоставки From Поставка, Договор Where Вид = 'Поставка' AND НомерДоговора=Номер AND КодКонтрагента = '" + CBprovider.SelectedValue.ToString() + "'";
                this.CBdelivery.DataSource = dataBase.sqlShow(selectSting);
                this.CBdelivery.DisplayMember = "КодПоставки"; // столбец для отображения 
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
            if ((CBgoods.Text == "") || (CBprovider.Text == "") || (CBdelivery.Text == "") || (CBcharact.Text == "") || (CBdescript.Text == "") || (CBamount2.Text == "") || (System.Int32.TryParse(CBamount1.Text, out result) == false) || (System.Int32.TryParse(CBcost1.Text, out result) == false) || (System.Int32.TryParse(CBcost2.Text, out result) == false))
            {
                MessageBox.Show("Ошибка! Неккоретные данные. \n Попробуйте ещё раз");
            }
            else
            {
                last = Convert.ToInt32(dataBase.sqlToString("SELECT TOP 1 Код FROM Товар ORDER BY Код DESC")) + 1;
                dataBase.closeConnection();
                updateString = "INSERT INTO Товар VALUES(" + last + ", '" + CBgoods.Text + "', '" + CBdelivery.Text + "', '" + CBcharact.Text + "', '" + CBdescript.Text + "', " + Convert.ToInt32(CBcost1.Text) + ", " + Convert.ToInt32(CBcost2.Text) + ", " + Convert.ToInt32(CBamount1.Text) + ", '" + CBamount2.Text + "')";
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
