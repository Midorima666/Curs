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
    public partial class FpartnerAddPact : Form
    {
        DataBase dataBase = new DataBase();
        public FpartnerAddPact()
        {
            InitializeComponent();
            string selectSting = "Select distinct * from Контрагент";
            CBprovider.DataSource = dataBase.sqlShow(selectSting);
            CBprovider.DisplayMember = "Название"; // столбец для отображения
            CBprovider.ValueMember = "Код"; //столбец с id
            CBprovider.SelectedIndex = -1;
            dateTimePicker1.MaxDate = DateTime.Today;
        }


        private void amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 47) // цифры, клавиша BackSpace, /
            {
                e.Handled = true;
            }
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            string updateString = "";
            if ((CBcode.Text == "") || (CBprovider.Text == "") || (CBtype.Text == "") || (dateTimePicker1.Text == "") || ((dataBase.sqlToString("SELECT Номер FROM Договор WHERE Номер = '" + CBcode.Text + "'") != null)))
            {
                MessageBox.Show("Ошибка! Неккоретные данные. \n Попробуйте ещё раз");
            }
            else
            {
                dataBase.closeConnection();
                updateString = "INSERT INTO Договор VALUES('" + CBcode.Text + "', '" + CBtype.Text + "', '" + CBprovider.SelectedValue.ToString() + "', CAST('" + dateTimePicker1.Text.Replace(".", "-") + "' as date))";
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

