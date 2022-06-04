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
    public partial class Fstatistics : Form
    {
            Fmenu fmenu;
            String post;
            DataBase dataBase = new DataBase();
            public Fstatistics(Fmenu menu)
            {
                fmenu = menu;
                post = fmenu.post;
                InitializeComponent();
                GetList();
                string selectSting = "Select * from Контрагент";
                this.CBagent.DataSource = dataBase.sqlShow(selectSting);
                this.CBagent.DisplayMember = "Название"; // столбец для отображения
                this.CBagent.ValueMember = "Код"; //столбец с id
                this.CBagent.SelectedIndex = -1;
                dateTimePicker2.MaxDate = DateTime.Today;
            }

            public void GetList()
            {
                dataGridView1.DataSource = dataBase.sqlShow("Select Название as 'Покупатель', SUM(КоличествоОтправленного*ЦенаПродажи) as 'Прибыль' FROM ЗаявкаНаПродажу, Товар, Договор, Контрагент WHERE КодТовара = Товар.Код AND Договор.Номер = НомерДоговора AND Контрагент.Код = КодКонтрагента GROUP BY Название");
                dataGridView2.DataSource = dataBase.sqlShow("Select  Название as 'Продавец', SUM(Количество*ЦенаЗакупки) as 'Затраты' FROM Договор, Контрагент, Поставка, Товар WHERE Поставка.КодПоставки = Товар.КодПоставки AND Номер = НомерДоговора AND Контрагент.Код = КодКонтрагента GROUP BY Название");
            }

            private void Bsourse_Click(object sender, EventArgs e)
            {
                string sourseSting = "";
                if (CBagent.SelectedIndex != -1)
                {
                    sourseSting += " AND Контрагент.Код = '" + CBagent.SelectedValue.ToString() + "'";
                }
                sourseSting += " AND ДатаРазмещения >= '" + Convert.ToDateTime(dateTimePicker1.Text) + "' AND ДатаРазмещения <= '" + Convert.ToDateTime(dateTimePicker2.Text) + "'";
                dataGridView1.DataSource = dataBase.sqlShow("Select Название as 'Покупатель', SUM(КоличествоОтправленного * ЦенаПродажи) as 'Прибыль' FROM ЗаявкаНаПродажу, Товар, Договор, Контрагент WHERE КодТовара = Товар.Код AND Договор.Номер = НомерДоговора AND Контрагент.Код = КодКонтрагента" + sourseSting + " GROUP BY Название");
                sourseSting = "";
                if (CBagent.SelectedIndex != -1)
                {
                    sourseSting += " AND Контрагент.Код = '" + CBagent.SelectedValue.ToString() + "'";
                }
                sourseSting += " AND ДатаПоставки >= '" + Convert.ToDateTime(dateTimePicker1.Text) + "' AND ДатаПоставки <= '" + Convert.ToDateTime(dateTimePicker2.Text) + "'";
                dataGridView2.DataSource = dataBase.sqlShow("Select  Название as 'Продавец', SUM(Количество*ЦенаЗакупки) as 'Затраты' FROM Договор, Контрагент, Поставка, Товар WHERE Поставка.КодПоставки = Товар.КодПоставки AND Номер = НомерДоговора AND Контрагент.Код = КодКонтрагента" + sourseSting + " GROUP BY Название");
                this.CBagent.SelectedIndex = -1;
            }

            private void Bback_Click(object sender, EventArgs e)
            {
                fmenu.Visible = true;
                this.Close();
            }

            private void Forder_FormClosed(object sender, FormClosedEventArgs e)
            {
                if (fmenu.Visible == false)
                {
                    Application.Exit();
                }
            }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = dateTimePicker2.Value;
        }
    }
}
