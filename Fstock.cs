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
        public partial class Fstock : Form
        {
            Fmenu fmenu;
            String post;
            DataBase dataBase = new DataBase();

            public Fstock(Fmenu menu)
            {
                fmenu = menu;
                post = fmenu.post;
                InitializeComponent();
                GetList();
                DataGridViewElementStates states = DataGridViewElementStates.None;
                var totalWidth = dataGridView1.Columns.GetColumnsWidth(states) + dataGridView1.RowHeadersWidth + 100;
                this.Size = new Size(totalWidth, 493);
                this.MinimumSize = new Size(totalWidth, 493);
                dateTimePicker2.MaxDate = DateTime.Today;
        }

            public void GetList()
            {
                dataGridView1.DataSource = dataBase.sqlShow("SELECT Товар.Код, Наименование, ДатаПоставки as [Дата поставки], Характеристики, Описание, ЦенаЗакупки as [Цена закупки], ЦенаПродажи as [Цена продажи], Количество, ВидКоличества as [Единица], Контрагент.Название as Поставщик FROM Товар, Поставка, Договор, Контрагент WHERE Товар.КодПоставки = Поставка.КодПоставки AND НомерДоговора = Договор.Номер AND КодКонтрагента = Контрагент.Код");
            }

            private void Bsourse_Click(object sender, EventArgs e)
            {
                string sourseSting = "";
                if (Tgoods.Text != "")
                {
                    sourseSting = " AND Наименование LIKE '%" + Tgoods.Text + "%'";
                }
                if (Tprovider.Text != "")
                {
                    sourseSting += " AND Контрагент.Название LIKE '%" + Tprovider.Text + "%'";
                }
                sourseSting += " AND ДатаПоставки >= '" + Convert.ToDateTime(dateTimePicker1.Text) + "' AND ДатаПоставки <= '" + Convert.ToDateTime(dateTimePicker2.Text) + "'";
                dataGridView1.DataSource = dataBase.sqlShow("SELECT Товар.Код, Наименование, ДатаПоставки as [Дата поставки], Характеристики, Описание, ЦенаЗакупки as [Цена закупки], ЦенаПродажи as [Цена продажи], Количество, ВидКоличества as [Единица], Контрагент.Название as Поставщик FROM Товар, Поставка, Договор, Контрагент WHERE Товар.КодПоставки = Поставка.КодПоставки AND НомерДоговора = Договор.Номер AND КодКонтрагента = Контрагент.Код" + sourseSting);
            }

            private void Forder_FormClosed(object sender, FormClosedEventArgs e)
            {
                if (fmenu.Visible == false)
                {
                    Application.Exit();
                }
            }

            private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
            {
                if ((e.ColumnIndex != 5 && e.ColumnIndex != 6 && e.ColumnIndex != 7) || post != "Менеджер")
                {
                    e.Cancel = true;
                }
            }

            private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
            {
                if (e.ColumnIndex == 5)
                {
                    dataBase.sqlUpdate("UPDATE Товар SET ЦенаЗакупки = " + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + " WHERE Код = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'");
                }
                else if (e.ColumnIndex == 6)
                {
                    dataBase.sqlUpdate("UPDATE Товар SET ЦенаПродажи = " + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + " WHERE Код = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'");
                }
                else if (e.ColumnIndex == 7)
                {
                    dataBase.sqlUpdate("UPDATE Товар SET Количество = " + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + " WHERE Код = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'");
                }

        }

        private void BAddDelivery_Click(object sender, EventArgs e)
        {
            if (post == "Администратор" || post == "Менеджер")
            {
                FstockAddDelivery fstockAddDelivery = new FstockAddDelivery();
            fstockAddDelivery.ShowDialog();
            GetList();
            }
            else
            {
                MessageBox.Show("Недоступно");
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (post == "Администратор")
            {
                DialogResult result = MessageBox.Show("Удалить строку " + Convert.ToInt32(e.RowIndex + 1) + "?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (result == DialogResult.Yes)
                {
                    if (dataBase.sqlToString("SELECT TOP (1) КодТовара FROM ЗаявкаНаПродажу WHERE КодТовара = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'") == null)
                    {
                        dataBase.sqlUpdate("DELETE Товар WHERE Код = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'");
                    }
                    else
                    {
                        MessageBox.Show("Невозможно удалить данный товар");
                    }
                }
            }
        }

        private void BAddGoods_Click(object sender, EventArgs e)
        {
            if (post == "Администратор" || post == "Менеджер")
            {
            FstockAddGoods fstockAddGoods = new FstockAddGoods();
            fstockAddGoods.ShowDialog();
            GetList();
            }
            else
            {
                MessageBox.Show("Недоступно");
            }
        }
        private void Bback_Click(object sender, EventArgs e)
        {
            fmenu.Visible = true;
            this.Close();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неверный тип данных");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = dateTimePicker2.Value;
        }
    }
}
