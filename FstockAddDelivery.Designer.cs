
namespace optbaze
{
    partial class FstockAddDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FstockAddDelivery));
            this.BAdd = new System.Windows.Forms.Button();
            this.Ldate = new System.Windows.Forms.Label();
            this.CBdelivery = new System.Windows.Forms.ComboBox();
            this.CBprovider = new System.Windows.Forms.ComboBox();
            this.Lnubmer = new System.Windows.Forms.Label();
            this.Lgoods = new System.Windows.Forms.Label();
            this.Lstaff = new System.Windows.Forms.Label();
            this.BCancel = new System.Windows.Forms.Button();
            this.CBcode = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
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
            this.Ldate.Size = new System.Drawing.Size(85, 15);
            this.Ldate.TabIndex = 16;
            this.Ldate.Text = "Код поставки";
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
            this.Lgoods.Size = new System.Drawing.Size(56, 15);
            this.Lgoods.TabIndex = 22;
            this.Lgoods.Text = "Договор";
            // 
            // Lstaff
            // 
            this.Lstaff.AutoSize = true;
            this.Lstaff.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lstaff.Location = new System.Drawing.Point(79, 99);
            this.Lstaff.Name = "Lstaff";
            this.Lstaff.Size = new System.Drawing.Size(89, 15);
            this.Lstaff.TabIndex = 23;
            this.Lstaff.Text = "Дата поставки";
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
            // CBcode
            // 
            this.CBcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBcode.FormattingEnabled = true;
            this.CBcode.Location = new System.Drawing.Point(47, 29);
            this.CBcode.MaxLength = 10;
            this.CBcode.Name = "CBcode";
            this.CBcode.Size = new System.Drawing.Size(176, 23);
            this.CBcode.TabIndex = 29;
            this.CBcode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_KeyPress);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(47, 117);
            this.dateTimePicker1.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeftLayout = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(176, 23);
            this.dateTimePicker1.TabIndex = 30;
            this.dateTimePicker1.Value = new System.DateTime(2022, 7, 5, 0, 0, 0, 0);
            // 
            // FstockAddDelivery
            // 
            this.AcceptButton = this.BAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(268, 356);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CBcode);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.Lstaff);
            this.Controls.Add(this.Lgoods);
            this.Controls.Add(this.Lnubmer);
            this.Controls.Add(this.CBprovider);
            this.Controls.Add(this.CBdelivery);
            this.Controls.Add(this.Ldate);
            this.Controls.Add(this.BAdd);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(284, 395);
            this.MinimumSize = new System.Drawing.Size(284, 395);
            this.Name = "FstockAddDelivery";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Запись поставки";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.Label Ldate;
            private System.Windows.Forms.ComboBox CBdelivery;
            private System.Windows.Forms.ComboBox CBprovider;
            private System.Windows.Forms.Label Lnubmer;
            private System.Windows.Forms.Label Lgoods;
            private System.Windows.Forms.Label Lstaff;
            private System.Windows.Forms.Button BCancel;
            public System.Windows.Forms.Button BAdd;
            private System.Windows.Forms.ComboBox CBcode;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
    }

