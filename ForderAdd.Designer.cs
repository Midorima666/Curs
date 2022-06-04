
namespace optbaze
{
    partial class ForderAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForderAdd));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.BAdd = new System.Windows.Forms.Button();
            this.Ldate = new System.Windows.Forms.Label();
            this.CBgoods = new System.Windows.Forms.ComboBox();
            this.CBstaff = new System.Windows.Forms.ComboBox();
            this.CBnubmer = new System.Windows.Forms.ComboBox();
            this.Lnubmer = new System.Windows.Forms.Label();
            this.Lgoods = new System.Windows.Forms.Label();
            this.Lstaff = new System.Windows.Forms.Label();
            this.BCancel = new System.Windows.Forms.Button();
            this.CBadress = new System.Windows.Forms.ComboBox();
            this.CBamount = new System.Windows.Forms.ComboBox();
            this.Lamount = new System.Windows.Forms.Label();
            this.Ladress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 48);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.MaxDate = new System.DateTime(2022, 5, 30, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 31);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2022, 5, 30, 0, 0, 0, 0);
            // 
            // BAdd
            // 
            this.BAdd.BackColor = System.Drawing.Color.LemonChiffon;
            this.BAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAdd.Location = new System.Drawing.Point(208, 478);
            this.BAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(153, 73);
            this.BAdd.TabIndex = 13;
            this.BAdd.Text = "Добавить";
            this.BAdd.UseVisualStyleBackColor = false;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // Ldate
            // 
            this.Ldate.AutoSize = true;
            this.Ldate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ldate.Location = new System.Drawing.Point(113, 18);
            this.Ldate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ldate.Name = "Ldate";
            this.Ldate.Size = new System.Drawing.Size(171, 25);
            this.Ldate.TabIndex = 16;
            this.Ldate.Text = "Дата размещения";
            // 
            // CBgoods
            // 
            this.CBgoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBgoods.FormattingEnabled = true;
            this.CBgoods.Location = new System.Drawing.Point(67, 195);
            this.CBgoods.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBgoods.Name = "CBgoods";
            this.CBgoods.Size = new System.Drawing.Size(250, 33);
            this.CBgoods.TabIndex = 17;
            this.CBgoods.SelectedIndexChanged += new System.EventHandler(this.CBgoods_SelectedIndexChanged);
            // 
            // CBstaff
            // 
            this.CBstaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBstaff.FormattingEnabled = true;
            this.CBstaff.Location = new System.Drawing.Point(67, 268);
            this.CBstaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBstaff.Name = "CBstaff";
            this.CBstaff.Size = new System.Drawing.Size(250, 33);
            this.CBstaff.TabIndex = 18;
            // 
            // CBnubmer
            // 
            this.CBnubmer.BackColor = System.Drawing.SystemColors.Window;
            this.CBnubmer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBnubmer.FormattingEnabled = true;
            this.CBnubmer.Location = new System.Drawing.Point(67, 122);
            this.CBnubmer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBnubmer.Name = "CBnubmer";
            this.CBnubmer.Size = new System.Drawing.Size(250, 33);
            this.CBnubmer.TabIndex = 20;
            this.CBnubmer.SelectedIndexChanged += new System.EventHandler(this.CBnubmer_SelectedIndexChanged);
            // 
            // Lnubmer
            // 
            this.Lnubmer.AutoSize = true;
            this.Lnubmer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lnubmer.Location = new System.Drawing.Point(113, 92);
            this.Lnubmer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lnubmer.Name = "Lnubmer";
            this.Lnubmer.Size = new System.Drawing.Size(159, 25);
            this.Lnubmer.TabIndex = 21;
            this.Lnubmer.Text = "Номер договора";
            // 
            // Lgoods
            // 
            this.Lgoods.AutoSize = true;
            this.Lgoods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lgoods.Location = new System.Drawing.Point(113, 165);
            this.Lgoods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lgoods.Name = "Lgoods";
            this.Lgoods.Size = new System.Drawing.Size(64, 25);
            this.Lgoods.TabIndex = 22;
            this.Lgoods.Text = "Товар";
            // 
            // Lstaff
            // 
            this.Lstaff.AutoSize = true;
            this.Lstaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lstaff.Location = new System.Drawing.Point(113, 238);
            this.Lstaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lstaff.Name = "Lstaff";
            this.Lstaff.Size = new System.Drawing.Size(105, 25);
            this.Lstaff.TabIndex = 23;
            this.Lstaff.Text = "Сотрудник";
            // 
            // BCancel
            // 
            this.BCancel.BackColor = System.Drawing.Color.LemonChiffon;
            this.BCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BCancel.Location = new System.Drawing.Point(13, 478);
            this.BCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(153, 73);
            this.BCancel.TabIndex = 24;
            this.BCancel.Text = "Отмена";
            this.BCancel.UseVisualStyleBackColor = false;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // CBadress
            // 
            this.CBadress.FormattingEnabled = true;
            this.CBadress.Location = new System.Drawing.Point(67, 342);
            this.CBadress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBadress.MaxLength = 60;
            this.CBadress.Name = "CBadress";
            this.CBadress.Size = new System.Drawing.Size(250, 33);
            this.CBadress.TabIndex = 25;
            // 
            // CBamount
            // 
            this.CBamount.FormattingEnabled = true;
            this.CBamount.Location = new System.Drawing.Point(67, 415);
            this.CBamount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBamount.MaxLength = 60;
            this.CBamount.Name = "CBamount";
            this.CBamount.Size = new System.Drawing.Size(250, 33);
            this.CBamount.TabIndex = 26;
            this.CBamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_KeyPress);
            // 
            // Lamount
            // 
            this.Lamount.AutoSize = true;
            this.Lamount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lamount.Location = new System.Drawing.Point(113, 385);
            this.Lamount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lamount.Name = "Lamount";
            this.Lamount.Size = new System.Drawing.Size(181, 25);
            this.Lamount.TabIndex = 27;
            this.Lamount.Text = "Количество товара";
            // 
            // Ladress
            // 
            this.Ladress.AutoSize = true;
            this.Ladress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ladress.Location = new System.Drawing.Point(113, 312);
            this.Ladress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ladress.Name = "Ladress";
            this.Ladress.Size = new System.Drawing.Size(174, 25);
            this.Ladress.TabIndex = 28;
            this.Ladress.Text = "Пункт назначения";
            // 
            // ForderAdd
            // 
            this.AcceptButton = this.BAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(374, 565);
            this.ControlBox = false;
            this.Controls.Add(this.Ladress);
            this.Controls.Add(this.Lamount);
            this.Controls.Add(this.CBamount);
            this.Controls.Add(this.CBadress);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.Lstaff);
            this.Controls.Add(this.Lgoods);
            this.Controls.Add(this.Lnubmer);
            this.Controls.Add(this.CBnubmer);
            this.Controls.Add(this.CBstaff);
            this.Controls.Add(this.CBgoods);
            this.Controls.Add(this.Ldate);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(396, 621);
            this.MinimumSize = new System.Drawing.Size(396, 621);
            this.Name = "ForderAdd";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Запись заявки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Ldate;
        private System.Windows.Forms.ComboBox CBgoods;
        private System.Windows.Forms.ComboBox CBstaff;
        private System.Windows.Forms.ComboBox CBnubmer;
        private System.Windows.Forms.Label Lnubmer;
        private System.Windows.Forms.Label Lgoods;
        private System.Windows.Forms.Label Lstaff;
        private System.Windows.Forms.Button BCancel;
        private System.Windows.Forms.ComboBox CBadress;
        private System.Windows.Forms.ComboBox CBamount;
        private System.Windows.Forms.Label Lamount;
        private System.Windows.Forms.Label Ladress;
        public System.Windows.Forms.Button BAdd;
    }
}

