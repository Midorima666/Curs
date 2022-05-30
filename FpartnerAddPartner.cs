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
    public partial class FpartnerAddPartner : Form
    {
            DataBase dataBase = new DataBase();
            public FpartnerAddPartner()
                {
                    InitializeComponent();
                }


            private void amount_KeyPress(object sender, KeyPressEventArgs e)
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
                int last;
                if ((CBorg.Text == "") || (CBaddress.Text == "") || (CBphone.Text == "") || (CBstaff.Text == "") || (CBname.Text == ""))
                {
                    MessageBox.Show("Ошибка! Неккоретные данные. \n Попробуйте ещё раз");
                }
                else
                {
                    last = Convert.ToInt32(dataBase.sqlToString("SELECT TOP 1 Код FROM Контрагент ORDER BY Код DESC")) + 1;
                    dataBase.closeConnection();
                    updateString = "INSERT INTO Контрагент VALUES('" + last + "', '" + CBorg.Text + "', '" + CBaddress.Text + "', '" + CBphone.Text + "', '" + CBstaff.Text + "', '" + CBname.Text + "')";
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
