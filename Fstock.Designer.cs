﻿
namespace optbaze
{
    partial class Fstock
    {
            /// <summary>
            ///  Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            ///  Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            ///  Required method for Designer support - do not modify
            ///  the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fstock));
            this.Tgoods = new System.Windows.Forms.TextBox();
            this.Bsourse = new System.Windows.Forms.Button();
            this.Bback = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BAddGoods = new System.Windows.Forms.Button();
            this.Tprovider = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BAddDelivery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tgoods
            // 
            this.Tgoods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tgoods.Location = new System.Drawing.Point(54, 33);
            this.Tgoods.MaxLength = 16;
            this.Tgoods.Name = "Tgoods";
            this.Tgoods.PlaceholderText = "Название товара";
            this.Tgoods.Size = new System.Drawing.Size(125, 23);
            this.Tgoods.TabIndex = 5;
            // 
            // Bsourse
            // 
            this.Bsourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Bsourse.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bsourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bsourse.Location = new System.Drawing.Point(626, 26);
            this.Bsourse.Name = "Bsourse";
            this.Bsourse.Size = new System.Drawing.Size(80, 36);
            this.Bsourse.TabIndex = 8;
            this.Bsourse.Text = "Искать";
            this.Bsourse.UseVisualStyleBackColor = false;
            this.Bsourse.Click += new System.EventHandler(this.Bsourse_Click);
            // 
            // Bback
            // 
            this.Bback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bback.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bback.Location = new System.Drawing.Point(54, 398);
            this.Bback.Name = "Bback";
            this.Bback.Size = new System.Drawing.Size(200, 44);
            this.Bback.TabIndex = 10;
            this.Bback.Text = "Назад";
            this.Bback.UseVisualStyleBackColor = false;
            this.Bback.Click += new System.EventHandler(this.Bback_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Olive;
            this.dateTimePicker1.Location = new System.Drawing.Point(339, 33);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 23);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.Olive;
            this.dateTimePicker2.Location = new System.Drawing.Point(475, 33);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(125, 23);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.Value = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            // 
            // BAddGoods
            // 
            this.BAddGoods.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BAddGoods.BackColor = System.Drawing.Color.LemonChiffon;
            this.BAddGoods.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAddGoods.Location = new System.Drawing.Point(506, 398);
            this.BAddGoods.Name = "BAddGoods";
            this.BAddGoods.Size = new System.Drawing.Size(200, 44);
            this.BAddGoods.TabIndex = 13;
            this.BAddGoods.Text = "Добавить товар";
            this.BAddGoods.UseVisualStyleBackColor = false;
            this.BAddGoods.Click += new System.EventHandler(this.BAddGoods_Click);
            // 
            // Tprovider
            // 
            this.Tprovider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tprovider.Location = new System.Drawing.Point(185, 33);
            this.Tprovider.MaxLength = 16;
            this.Tprovider.Name = "Tprovider";
            this.Tprovider.PlaceholderText = "Поставщик";
            this.Tprovider.Size = new System.Drawing.Size(125, 23);
            this.Tprovider.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(339, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Дата поставки (с, по)";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkKhaki;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.NullValue = "— ";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Olive;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = " — ";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.DarkOliveGreen;
            this.dataGridView1.Location = new System.Drawing.Point(0, 68);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.NullValue = " — ";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Olive;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(752, 324);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // BAddDelivery
            // 
            this.BAddDelivery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BAddDelivery.BackColor = System.Drawing.Color.LemonChiffon;
            this.BAddDelivery.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAddDelivery.Location = new System.Drawing.Point(280, 398);
            this.BAddDelivery.Name = "BAddDelivery";
            this.BAddDelivery.Size = new System.Drawing.Size(200, 44);
            this.BAddDelivery.TabIndex = 18;
            this.BAddDelivery.Text = "Добавить поставку";
            this.BAddDelivery.UseVisualStyleBackColor = false;
            this.BAddDelivery.Click += new System.EventHandler(this.BAddDelivery_Click);
            // 
            // Fstock
            // 
            this.AcceptButton = this.Bsourse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::optbaze.Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(752, 454);
            this.Controls.Add(this.BAddDelivery);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tprovider);
            this.Controls.Add(this.BAddGoods);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Bback);
            this.Controls.Add(this.Bsourse);
            this.Controls.Add(this.Tgoods);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(768, 493);
            this.Name = "Fstock";
            this.Text = "Оптовая база | Cклад";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Forder_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.TextBox Tgoods;
            private System.Windows.Forms.Button Bsourse;
            private System.Windows.Forms.Button Bback;
            private System.Windows.Forms.DateTimePicker dateTimePicker1;
            private System.Windows.Forms.DateTimePicker dateTimePicker2;
            private System.Windows.Forms.Button BAddGoods;
            private System.Windows.Forms.TextBox Tprovider;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BAddDelivery;
    }
    }

