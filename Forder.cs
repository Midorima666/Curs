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
    public partial class Forder : Form
    {
        Fmenu fmenu;
        String post;
        DataBase dataBase = new DataBase();
        public Forder(Fmenu menu)
        {
            fmenu = menu;
            post = fmenu.post;
            InitializeComponent();
            GetList();
            DataGridViewElementStates states = DataGridViewElementStates.None;
            var totalWidth = dataGridView1.Columns.GetColumnsWidth(states) + dataGridView1.RowHeadersWidth + 100;
            this.Size = new Size(totalWidth, 493);
            this.MinimumSize = new Size(totalWidth, 493);
            CBstatus.SelectedIndex = 0;
            dateTimePicker2.MaxDate = DateTime.Today;
        }

        public void GetList()
        {
            dataGridView1.DataSource = dataBase.sqlShow("Select ЗаявкаНаПродажу.Код, TRIM(НомерДоговора) as Договор, Название as Потребитель, Наименование as Товар, КоличествоТовара as [Кол-во], КоличествоОтправленного as [Отпр.], ДатаРазмещения as [Размещно], ДатаИсполнения as [Исполнено], ПунктНазначения as [Адрес назначения], ПунктТекущий as [Адрес текущий], Фамилия  + ' ' +  Имя  + ' ' +  Отчество As Сотрудник, ЗаявкаНаПродажу.Статус From ЗаявкаНаПродажу, Сотрудник, Товар, Договор, Контрагент Where Товар.Код = КодТовара AND Паспорт = КодСотрудника AND Договор.Номер = НомерДоговора AND Контрагент.Код = КодКонтрагента");
        }

        private void Bsourse_Click(object sender, EventArgs e)
        {
            string sourseSting = "";
            if (Tusername.Text != "")
            {
                sourseSting = " AND Фамилия  + ' ' +  Имя  + ' ' +  Отчество LIKE '%" + Tusername.Text + "%'";
            }
            if (Tgoods.Text != "")
            {
                sourseSting += " AND Наименование LIKE '%" + Tgoods.Text + "%'";
            }
            if (TCode.Text != "")
            {
                sourseSting += " AND Договор.Номер LIKE '%" + TCode.Text + "%'";
            }
            if (CBstatus.SelectedIndex != 0 && CBstatus.Text != "Любой")
            {
                sourseSting += " AND ЗаявкаНаПродажу.Статус = '" + CBstatus.Text.ToString()+"'";
            }
            sourseSting += " AND ДатаРазмещения >= '" + Convert.ToDateTime(dateTimePicker1.Text) + "' AND ДатаРазмещения <= '" + Convert.ToDateTime(dateTimePicker2.Text) + "'";
            dataGridView1.DataSource = dataBase.sqlShow("Select ЗаявкаНаПродажу.Код, TRIM(НомерДоговора) as Договор, Название as Потребитель, Наименование as Товар, КоличествоТовара as [Кол-во], КоличествоОтправленного as [Отпр.], ДатаРазмещения as [Размещно], ДатаИсполнения as [Исполнено], ПунктНазначения as [Адрес назначения], ПунктТекущий as [Адрес текущий], Фамилия  + ' ' +  Имя  + ' ' +  Отчество As Сотрудник, ЗаявкаНаПродажу.Статус From ЗаявкаНаПродажу, Сотрудник, Товар, Договор, Контрагент Where Товар.Код = КодТовара AND Паспорт = КодСотрудника AND Договор.Номер = ЗаявкаНаПродажу.НомерДоговора AND Контрагент.Код = КодКонтрагента" + sourseSting);
        }

        private void BChange_Click(object sender, EventArgs e)
        {
            if (post == "Администратор" || post == "Менеджер")
            {
                ForderChange forderChange = new ForderChange();
                forderChange.ShowDialog();
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

        private void Forder_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (fmenu.Visible == false)
            {
                Application.Exit();
            } 
        }

        private void BAdd_Click(object sender, EventArgs e)
        {
            if (post == "Администратор" || post == "Менеджер")
            {
                ForderAdd forderAdd = new ForderAdd();
                forderAdd.ShowDialog();
                GetList();
            }
            else
            {
                MessageBox.Show("Недоступно");
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if ((e.ColumnIndex != 7 && e.ColumnIndex != 9) || post != "Менеджер")
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (post == "Менеджер")
            {
                if (e.ColumnIndex == 7)
                {
                    dataBase.sqlUpdate("UPDATE ЗаявкаНаПродажу SET ДатаИсполнения = CAST('" + Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) + "' as date) WHERE Код = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'");
                }
                else if (e.ColumnIndex == 9)
                {
                    dataBase.sqlUpdate("UPDATE ЗаявкаНаПродажу SET ПунктТекущий = '" + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value + "' WHERE Код = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'");
                    if (dataBase.sqlToString("SELECT * FROM ЗаявкаНаПродажу WHERE КоличествоТовара=КоличествоОтправленного AND ПунктТекущий=ПунктНазначения AND Код = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'") !=null)
                        dataBase.sqlUpdate("UPDATE ЗаявкаНаПродажу SET Статус = 'Выполнено', ДатаИсполнения = '" + DateTime.Today.Date + "' WHERE Код = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'");
                    else dataBase.sqlUpdate("UPDATE ЗаявкаНаПродажу SET Статус = 'Отправлено' WHERE Код = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'");
                }
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (post == "Администратор")
            {
                DialogResult result = MessageBox.Show("Удалить строку " + Convert.ToInt32(e.RowIndex + 1) + "?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (result == DialogResult.Yes)
                {
                    dataBase.sqlUpdate("DELETE ЗаявкаНаПродажу WHERE Код = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'");
                }
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Неправильная дата");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = dateTimePicker2.Value;
        }
    }
}
