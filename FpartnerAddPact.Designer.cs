
namespace optbaze
{
    partial class FpartnerAddPact
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
            this.BAdd = new System.Windows.Forms.Button();
            this.L1 = new System.Windows.Forms.Label();
            this.CBtype = new System.Windows.Forms.ComboBox();
            this.CBprovider = new System.Windows.Forms.ComboBox();
            this.L2 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.L4 = new System.Windows.Forms.Label();
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
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L1.Location = new System.Drawing.Point(79, 11);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(46, 15);
            this.L1.TabIndex = 16;
            this.L1.Text = "Номер";
            // 
            // CBtype
            // 
            this.CBtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBtype.FormattingEnabled = true;
            this.CBtype.Items.AddRange(new object[] {
            "Поставка",
            "Продажа"});
            this.CBtype.Location = new System.Drawing.Point(169, 73);
            this.CBtype.Name = "CBtype";
            this.CBtype.Size = new System.Drawing.Size(54, 23);
            this.CBtype.TabIndex = 17;
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
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L2.Location = new System.Drawing.Point(79, 55);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(71, 15);
            this.L2.TabIndex = 21;
            this.L2.Text = "Контрагент";
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L3.Location = new System.Drawing.Point(181, 55);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(30, 15);
            this.L3.TabIndex = 22;
            this.L3.Text = "Вид";
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L4.Location = new System.Drawing.Point(79, 99);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(109, 15);
            this.L4.TabIndex = 23;
            this.L4.Text = "Дата заключения";
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
            // FpartnerAddPact
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
            this.Controls.Add(this.L4);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.CBprovider);
            this.Controls.Add(this.CBtype);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.BAdd);
            this.MaximumSize = new System.Drawing.Size(284, 395);
            this.MinimumSize = new System.Drawing.Size(284, 395);
            this.Name = "FpartnerAddPact";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Запись договора";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.Label L1;
            private System.Windows.Forms.ComboBox CBtype;
            private System.Windows.Forms.ComboBox CBprovider;
            private System.Windows.Forms.Label L2;
            private System.Windows.Forms.Label L3;
            private System.Windows.Forms.Label L4;
            private System.Windows.Forms.Button BCancel;
            public System.Windows.Forms.Button BAdd;
            private System.Windows.Forms.ComboBox CBcode;
            private System.Windows.Forms.DateTimePicker dateTimePicker1;
        }
    }

