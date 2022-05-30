
namespace optbaze
{
    partial class FstockAddGoods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FstockAddGoods));
            this.BAdd = new System.Windows.Forms.Button();
            this.Ldate = new System.Windows.Forms.Label();
            this.CBdelivery = new System.Windows.Forms.ComboBox();
            this.CBcharact = new System.Windows.Forms.ComboBox();
            this.CBprovider = new System.Windows.Forms.ComboBox();
            this.Lnubmer = new System.Windows.Forms.Label();
            this.Lgoods = new System.Windows.Forms.Label();
            this.Lstaff = new System.Windows.Forms.Label();
            this.BCancel = new System.Windows.Forms.Button();
            this.CBdescript = new System.Windows.Forms.ComboBox();
            this.CBamount2 = new System.Windows.Forms.ComboBox();
            this.Lamount = new System.Windows.Forms.Label();
            this.Ladress = new System.Windows.Forms.Label();
            this.CBgoods = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBcost1 = new System.Windows.Forms.ComboBox();
            this.CBcost2 = new System.Windows.Forms.ComboBox();
            this.CBamount1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BAdd
            // 
            this.BAdd.BackColor = System.Drawing.Color.LemonChiffon;
            this.BAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAdd.Location = new System.Drawing.Point(149, 300);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(107, 44);
            this.BAdd.TabIndex = 13;
            this.BAdd.Text = "Добавить";
            this.BAdd.UseVisualStyleBackColor = false;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // Ldate
            // 
            this.Ldate.AutoSize = true;
            this.Ldate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ldate.Location = new System.Drawing.Point(79, 11);
            this.Ldate.Name = "Ldate";
            this.Ldate.Size = new System.Drawing.Size(104, 15);
            this.Ldate.TabIndex = 16;
            this.Ldate.Text = "Название товара";
            // 
            // CBdelivery
            // 
            this.CBdelivery.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBdelivery.FormattingEnabled = true;
            this.CBdelivery.Location = new System.Drawing.Point(169, 73);
            this.CBdelivery.Name = "CBdelivery";
            this.CBdelivery.Size = new System.Drawing.Size(54, 23);
            this.CBdelivery.TabIndex = 17;
            // 
            // CBcharact
            // 
            this.CBcharact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBcharact.FormattingEnabled = true;
            this.CBcharact.Location = new System.Drawing.Point(47, 117);
            this.CBcharact.MaxLength = 60;
            this.CBcharact.Name = "CBcharact";
            this.CBcharact.Size = new System.Drawing.Size(176, 23);
            this.CBcharact.TabIndex = 18;
            // 
            // CBprovider
            // 
            this.CBprovider.BackColor = System.Drawing.SystemColors.Window;
            this.CBprovider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBprovider.FormattingEnabled = true;
            this.CBprovider.Location = new System.Drawing.Point(47, 73);
            this.CBprovider.Name = "CBprovider";
            this.CBprovider.Size = new System.Drawing.Size(116, 23);
            this.CBprovider.TabIndex = 20;
            this.CBprovider.SelectedIndexChanged += new System.EventHandler(this.CBprovider_SelectedIndexChanged);
            // 
            // Lnubmer
            // 
            this.Lnubmer.AutoSize = true;
            this.Lnubmer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lnubmer.Location = new System.Drawing.Point(79, 55);
            this.Lnubmer.Name = "Lnubmer";
            this.Lnubmer.Size = new System.Drawing.Size(73, 15);
            this.Lnubmer.TabIndex = 21;
            this.Lnubmer.Text = "Поставщик";
            // 
            // Lgoods
            // 
            this.Lgoods.AutoSize = true;
            this.Lgoods.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lgoods.Location = new System.Drawing.Point(163, 55);
            this.Lgoods.Name = "Lgoods";
            this.Lgoods.Size = new System.Drawing.Size(60, 15);
            this.Lgoods.TabIndex = 22;
            this.Lgoods.Text = "Поставка";
            // 
            // Lstaff
            // 
            this.Lstaff.AutoSize = true;
            this.Lstaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lstaff.Location = new System.Drawing.Point(79, 99);
            this.Lstaff.Name = "Lstaff";
            this.Lstaff.Size = new System.Drawing.Size(102, 15);
            this.Lstaff.TabIndex = 23;
            this.Lstaff.Text = "Характеристики";
            // 
            // BCancel
            // 
            this.BCancel.BackColor = System.Drawing.Color.LemonChiffon;
            this.BCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BCancel.Location = new System.Drawing.Point(12, 300);
            this.BCancel.Name = "BCancel";
            this.BCancel.Size = new System.Drawing.Size(107, 44);
            this.BCancel.TabIndex = 24;
            this.BCancel.Text = "Отмена";
            this.BCancel.UseVisualStyleBackColor = false;
            this.BCancel.Click += new System.EventHandler(this.BCancel_Click);
            // 
            // CBdescript
            // 
            this.CBdescript.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBdescript.FormattingEnabled = true;
            this.CBdescript.Location = new System.Drawing.Point(47, 161);
            this.CBdescript.MaxLength = 60;
            this.CBdescript.Name = "CBdescript";
            this.CBdescript.Size = new System.Drawing.Size(176, 23);
            this.CBdescript.TabIndex = 25;
            // 
            // CBamount2
            // 
            this.CBamount2.FormattingEnabled = true;
            this.CBamount2.Items.AddRange(new object[] {
            "шт",
            "гр",
            "кг",
            "м",
            "см",
            "л"});
            this.CBamount2.Location = new System.Drawing.Point(138, 249);
            this.CBamount2.MaxLength = 10;
            this.CBamount2.Name = "CBamount2";
            this.CBamount2.Size = new System.Drawing.Size(85, 23);
            this.CBamount2.TabIndex = 26;
            // 
            // Lamount
            // 
            this.Lamount.AutoSize = true;
            this.Lamount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lamount.Location = new System.Drawing.Point(79, 231);
            this.Lamount.Name = "Lamount";
            this.Lamount.Size = new System.Drawing.Size(117, 15);
            this.Lamount.TabIndex = 27;
            this.Lamount.Text = "Количество товара";
            // 
            // Ladress
            // 
            this.Ladress.AutoSize = true;
            this.Ladress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Ladress.Location = new System.Drawing.Point(79, 143);
            this.Ladress.Name = "Ladress";
            this.Ladress.Size = new System.Drawing.Size(65, 15);
            this.Ladress.TabIndex = 28;
            this.Ladress.Text = "Описание";
            // 
            // CBgoods
            // 
            this.CBgoods.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBgoods.FormattingEnabled = true;
            this.CBgoods.Location = new System.Drawing.Point(47, 29);
            this.CBgoods.MaxLength = 40;
            this.CBgoods.Name = "CBgoods";
            this.CBgoods.Size = new System.Drawing.Size(176, 23);
            this.CBgoods.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Цена закупки,";
            // 
            // CBcost1
            // 
            this.CBcost1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBcost1.FormattingEnabled = true;
            this.CBcost1.Location = new System.Drawing.Point(47, 205);
            this.CBcost1.Name = "CBcost1";
            this.CBcost1.Size = new System.Drawing.Size(85, 23);
            this.CBcost1.TabIndex = 30;
            this.CBcost1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_KeyPress);
            // 
            // CBcost2
            // 
            this.CBcost2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBcost2.FormattingEnabled = true;
            this.CBcost2.Location = new System.Drawing.Point(138, 205);
            this.CBcost2.Name = "CBcost2";
            this.CBcost2.Size = new System.Drawing.Size(85, 23);
            this.CBcost2.TabIndex = 32;
            this.CBcost2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_KeyPress);
            // 
            // CBamount1
            // 
            this.CBamount1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBamount1.FormattingEnabled = true;
            this.CBamount1.Location = new System.Drawing.Point(47, 249);
            this.CBamount1.Name = "CBamount1";
            this.CBamount1.Size = new System.Drawing.Size(85, 23);
            this.CBamount1.TabIndex = 33;
            this.CBamount1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(164, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "продажи";
            // 
            // FstockAddGoods
            // 
            this.AcceptButton = this.BAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(268, 356);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CBamount1);
            this.Controls.Add(this.CBcost2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBcost1);
            this.Controls.Add(this.CBgoods);
            this.Controls.Add(this.Ladress);
            this.Controls.Add(this.Lamount);
            this.Controls.Add(this.CBamount2);
            this.Controls.Add(this.CBdescript);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.Lstaff);
            this.Controls.Add(this.Lgoods);
            this.Controls.Add(this.Lnubmer);
            this.Controls.Add(this.CBprovider);
            this.Controls.Add(this.CBcharact);
            this.Controls.Add(this.CBdelivery);
            this.Controls.Add(this.Ldate);
            this.Controls.Add(this.BAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(284, 395);
            this.MinimumSize = new System.Drawing.Size(284, 395);
            this.Name = "FstockAddGoods";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Запись товаров";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.Label Ldate;
            private System.Windows.Forms.ComboBox CBdelivery;
            private System.Windows.Forms.ComboBox CBcharact;
            private System.Windows.Forms.ComboBox CBprovider;
            private System.Windows.Forms.Label Lnubmer;
            private System.Windows.Forms.Label Lgoods;
            private System.Windows.Forms.Label Lstaff;
            private System.Windows.Forms.Button BCancel;
            private System.Windows.Forms.ComboBox CBdescript;
            private System.Windows.Forms.ComboBox CBamount2;
            private System.Windows.Forms.Label Lamount;
            private System.Windows.Forms.Label Ladress;
            public System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.ComboBox CBgoods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBcost1;
        private System.Windows.Forms.ComboBox CBcost2;
        private System.Windows.Forms.ComboBox CBamount1;
        private System.Windows.Forms.Label label2;
    }
    }

