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
    public partial class Fpartner : Form
    {
        Fmenu fmenu;
        String post;
        DataBase dataBase = new DataBase();

        public Fpartner(Fmenu menu)
        {
            fmenu = menu;
            post = fmenu.post;
            InitializeComponent();
            GetList();
            DataGridViewElementStates states = DataGridViewElementStates.None;
            var totalWidth = dataGridView1.Columns.GetColumnsWidth(states) + dataGridView1.RowHeadersWidth + 100;
            this.Size = new Size(totalWidth, 493);
            this.MinimumSize = new Size(totalWidth, 493);
        }

        public void GetList()
        {
            dataGridView1.DataSource = dataBase.sqlShow("SELECT Код as '№', Название, Адрес, Телефон, Представитель, Обращение, Номер as 'Договор', Вид, ДатаДоговора as 'Дата' FROM Контрагент, Договор WHERE Код = КодКонтрагента");
        }

        private void Bsourse_Click(object sender, EventArgs e)
        {
            string sourseSting = "";
            if (Tfirm.Text != "")
            {
                sourseSting = " AND Название LIKE '%" + Tfirm.Text + "%'";
            }
            if (Tprovider.Text != "")
            {
                sourseSting += " AND Представитель LIKE '%" + Tprovider.Text + "%'";
            }
            if (Tpact.Text != "")
            {
                sourseSting += " AND Номер LIKE '%" + Tpact.Text + "%'";
            }
            if (CBdelivery.Checked == false) 
            {
                sourseSting += " AND Вид <> 'Поставка'";
            }
            if (CBsale.Checked == false)
            {
                sourseSting += " AND Вид <> 'Продажа'";
            }
            dataGridView1.DataSource = dataBase.sqlShow("SELECT Код as '№', Название, Адрес, Телефон, Представитель, Обращение, Номер as 'Договор', Вид, ДатаДоговора as 'Дата' FROM Контрагент, Договор WHERE Код = КодКонтрагента" + sourseSting);
        }

        private void BAddPartner_Click(object sender, EventArgs e)
        {
            if (post == "Администратор" || post == "Менеджер")
            {
                FpartnerAddPartner fpartnerAddPartner = new FpartnerAddPartner();
                fpartnerAddPartner.ShowDialog();
                GetList();
            }
            else
            {
                MessageBox.Show("Недоступно");
            }
        }

        private void BAddPact_Click(object sender, EventArgs e)
        {
            if (post == "Администратор" || post == "Менеджер")
            {
                FpartnerAddPact fpartnerAddPact = new FpartnerAddPact();
                fpartnerAddPact.ShowDialog();
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
                    if (dataBase.sqlToString("SELECT TOP (1) ЗаявкаНаПродажу.НомерДоговора, Поставка.НомерДоговора FROM ЗаявкаНаПродажу, Поставка, Договор WHERE (Номер = ЗаявкаНаПродажу.НомерДоговора OR Номер = Поставка.НомерДоговора) AND КодКонтрагента = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'") == null)
                    {
                        dataBase.sqlUpdate("DELETE Договор WHERE КодКонтрагента = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'");
                        dataBase.sqlUpdate("DELETE Контрагент WHERE Код = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'");
                    }
                    else
                    {
                        MessageBox.Show("Невозможно удалить данного контрагента");
                    }
                }
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
    }
}
