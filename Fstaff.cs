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
    public partial class Fstaff : Form
    {
            Fmenu fmenu;
            String post;
            DataBase dataBase = new DataBase();

            public Fstaff(Fmenu menu)
            {
                fmenu = menu;
                post = fmenu.post;
                InitializeComponent();
                GetList();
                string selectSting = "SELECT DISTINCT Должность from Сотрудник";
                this.CBpost.DataSource = dataBase.sqlShow(selectSting);
                this.CBpost.DisplayMember = "Должность"; // столбец для отображения
                this.CBpost.ValueMember = "Должность"; //столбец с id
                this.CBpost.SelectedIndex = -1;

                DataGridViewElementStates states = DataGridViewElementStates.None;
                var totalWidth = dataGridView1.Columns.GetColumnsWidth(states) + dataGridView1.RowHeadersWidth;
                this.Size = new Size(totalWidth, 493);
                this.MinimumSize = new Size(totalWidth, 493);
                CBstatus.SelectedIndex = 0;
            }

            public void GetList()
            {
                dataGridView1.DataSource = dataBase.sqlShow("SELECT Паспорт, Фамилия, Имя, Отчество, Должность, Адрес, Телефон, email, Статус FROM Сотрудник");
            }

            private void Bsourse_Click(object sender, EventArgs e)
            {
                string sourseSting = " WHERE Фамилия + Имя + Отчество LIKE '%" + Tfio.Text + "%'";

                if (Tpass.Text != "")
                {
                    sourseSting += " AND Паспорт LIKE '" + Tpass.Text + "%'";
                }
                if (Torder.Text != "")
                {
                    sourseSting += " AND Код = '" + Torder.Text + "' AND Паспорт=КодСотрудника";
                }
                if (CBpost.Text != "")
                {
                    sourseSting += " AND Должность LIKE '%" + CBpost.Text + "%'";
                }
                if (CBstatus.SelectedIndex != 0)
                {
                    sourseSting += " AND Сотрудник.Статус = '" + CBstatus.Text.ToString() + "'";
                }
                dataGridView1.DataSource = dataBase.sqlShow("SELECT DISTINCT Паспорт, Фамилия, Имя, Отчество, Должность, Адрес, Телефон, email, Сотрудник.Статус FROM Сотрудник, ЗаявкаНаПродажу" + sourseSting);
                this.CBpost.SelectedIndex = -1;
            }

            private void BAddStaff_Click(object sender, EventArgs e)
            {
                if (post == "Администратор")
                {
                    FstaffAddStaff fstaffAddStaff = new FstaffAddStaff();
                    fstaffAddStaff.ShowDialog();
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
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (post == "Администратор")
            {
                DialogResult result = MessageBox.Show("Удалить строку " + Convert.ToInt32(e.RowIndex + 1) + "?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
                if (result == DialogResult.Yes)
                {
                    if (dataBase.sqlToString("SELECT TOP (1) КодСотрудника FROM ЗаявкаНаПродажу WHERE КодСотрудника = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'") == null)
                    {
                        dataBase.sqlUpdate("DELETE Сотрудник WHERE Паспорт = '" + dataGridView1.Rows[e.RowIndex].Cells[0].Value + "'");
                    }
                    else
                    {
                        MessageBox.Show("Невозможно удалить данного сотрудника");
                    }
                }
            }
        }

        private void BChangePost_Click(object sender, EventArgs e)
        {
            if (post == "Администратор")
            {
                FstaffUpdateStaff fstaffUpdateStaff = new FstaffUpdateStaff(fmenu);
                fstaffUpdateStaff.ShowDialog();
                GetList();
            }
            else
            {
                MessageBox.Show("Недоступно");
            }
        }
    }
}