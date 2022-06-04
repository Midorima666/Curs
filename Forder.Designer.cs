
namespace optbaze
{
    partial class Forder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Forder));
            this.Tgoods = new System.Windows.Forms.TextBox();
            this.Bsourse = new System.Windows.Forms.Button();
            this.Bback = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.BAdd = new System.Windows.Forms.Button();
            this.Tusername = new System.Windows.Forms.TextBox();
            this.TCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BChange = new System.Windows.Forms.Button();
            this.CBstatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tgoods
            // 
            this.Tgoods.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tgoods.Location = new System.Drawing.Point(207, 55);
            this.Tgoods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tgoods.MaxLength = 16;
            this.Tgoods.Name = "Tgoods";
            this.Tgoods.PlaceholderText = "Товар";
            this.Tgoods.Size = new System.Drawing.Size(120, 31);
            this.Tgoods.TabIndex = 5;
            // 
            // Bsourse
            // 
            this.Bsourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Bsourse.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bsourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bsourse.Location = new System.Drawing.Point(894, 43);
            this.Bsourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bsourse.Name = "Bsourse";
            this.Bsourse.Size = new System.Drawing.Size(114, 60);
            this.Bsourse.TabIndex = 1;
            this.Bsourse.Text = "Искать";
            this.Bsourse.UseVisualStyleBackColor = false;
            this.Bsourse.Click += new System.EventHandler(this.Bsourse_Click);
            // 
            // Bback
            // 
            this.Bback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bback.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bback.Location = new System.Drawing.Point(77, 663);
            this.Bback.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bback.Name = "Bback";
            this.Bback.Size = new System.Drawing.Size(286, 73);
            this.Bback.TabIndex = 10;
            this.Bback.Text = "Назад";
            this.Bback.UseVisualStyleBackColor = false;
            this.Bback.Click += new System.EventHandler(this.Bback_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.Olive;
            this.dateTimePicker1.Location = new System.Drawing.Point(484, 55);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 31);
            this.dateTimePicker1.TabIndex = 11;
            this.dateTimePicker1.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.Olive;
            this.dateTimePicker2.Location = new System.Drawing.Point(679, 55);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(177, 31);
            this.dateTimePicker2.TabIndex = 12;
            this.dateTimePicker2.Value = new System.DateTime(2032, 5, 7, 0, 0, 0, 0);
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // BAdd
            // 
            this.BAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BAdd.BackColor = System.Drawing.Color.LemonChiffon;
            this.BAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAdd.Location = new System.Drawing.Point(723, 663);
            this.BAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(286, 73);
            this.BAdd.TabIndex = 13;
            this.BAdd.Text = "Добавить";
            this.BAdd.UseVisualStyleBackColor = false;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // Tusername
            // 
            this.Tusername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tusername.Location = new System.Drawing.Point(77, 55);
            this.Tusername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tusername.MaxLength = 16;
            this.Tusername.Name = "Tusername";
            this.Tusername.PlaceholderText = "Сотрудник";
            this.Tusername.Size = new System.Drawing.Size(120, 31);
            this.Tusername.TabIndex = 14;
            // 
            // TCode
            // 
            this.TCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TCode.Location = new System.Drawing.Point(337, 55);
            this.TCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TCode.MaxLength = 16;
            this.TCode.Name = "TCode";
            this.TCode.PlaceholderText = "Договор";
            this.TCode.Size = new System.Drawing.Size(120, 31);
            this.TCode.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(494, 8);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Дата размещения (с, по)";
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Olive;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.NullValue = " — ";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Olive;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 540);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // BChange
            // 
            this.BChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BChange.BackColor = System.Drawing.Color.LemonChiffon;
            this.BChange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BChange.Location = new System.Drawing.Point(429, 663);
            this.BChange.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BChange.Name = "BChange";
            this.BChange.Size = new System.Drawing.Size(286, 73);
            this.BChange.TabIndex = 22;
            this.BChange.Text = "Изменить";
            this.BChange.UseVisualStyleBackColor = false;
            this.BChange.Click += new System.EventHandler(this.BChange_Click);
            // 
            // CBstatus
            // 
            this.CBstatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBstatus.BackColor = System.Drawing.SystemColors.Window;
            this.CBstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBstatus.FormattingEnabled = true;
            this.CBstatus.Items.AddRange(new object[] {
            "Любой",
            "Принято",
            "В процессе",
            "Отправлено",
            "Выполнено"});
            this.CBstatus.Location = new System.Drawing.Point(207, 17);
            this.CBstatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBstatus.Name = "CBstatus";
            this.CBstatus.Size = new System.Drawing.Size(250, 33);
            this.CBstatus.TabIndex = 27;
            this.CBstatus.Tag = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Статус заявки";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(64, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 86);
            this.panel1.TabIndex = 29;
            // 
            // Forder
            // 
            this.AcceptButton = this.Bsourse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::optbaze.Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(1074, 757);
            this.Controls.Add(this.CBstatus);
            this.Controls.Add(this.BChange);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.Bback);
            this.Controls.Add(this.TCode);
            this.Controls.Add(this.Tusername);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Bsourse);
            this.Controls.Add(this.Tgoods);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1088, 784);
            this.Name = "Forder";
            this.Text = "Оптовая база | Заказы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Forder_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
        private System.Windows.Forms.TextBox Tgoods;
        private System.Windows.Forms.Button Bsourse;
        private System.Windows.Forms.Button Bback;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.TextBox Tusername;
        private System.Windows.Forms.TextBox TCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BChange;
        private System.Windows.Forms.ComboBox CBstatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
    }

