
namespace optbaze
{
    partial class FstaffAddStaff
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
            this.CBpatronymic = new System.Windows.Forms.ComboBox();
            this.CBadress = new System.Windows.Forms.ComboBox();
            this.CBsecondName = new System.Windows.Forms.ComboBox();
            this.L2 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.L4 = new System.Windows.Forms.Label();
            this.BCancel = new System.Windows.Forms.Button();
            this.CBpost = new System.Windows.Forms.ComboBox();
            this.L5 = new System.Windows.Forms.Label();
            this.CBpass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CBname = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TBpass = new System.Windows.Forms.TextBox();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.TBphone = new System.Windows.Forms.TextBox();
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
            this.L1.Size = new System.Drawing.Size(54, 15);
            this.L1.TabIndex = 16;
            this.L1.Text = "Паспорт";
            // 
            // CBpatronymic
            // 
            this.CBpatronymic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBpatronymic.FormattingEnabled = true;
            this.CBpatronymic.Location = new System.Drawing.Point(47, 117);
            this.CBpatronymic.MaxLength = 20;
            this.CBpatronymic.Name = "CBpatronymic";
            this.CBpatronymic.Size = new System.Drawing.Size(176, 23);
            this.CBpatronymic.TabIndex = 17;
            // 
            // CBadress
            // 
            this.CBadress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBadress.FormattingEnabled = true;
            this.CBadress.Location = new System.Drawing.Point(47, 161);
            this.CBadress.MaxLength = 60;
            this.CBadress.Name = "CBadress";
            this.CBadress.Size = new System.Drawing.Size(176, 23);
            this.CBadress.TabIndex = 18;
            // 
            // CBsecondName
            // 
            this.CBsecondName.BackColor = System.Drawing.SystemColors.Window;
            this.CBsecondName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBsecondName.FormattingEnabled = true;
            this.CBsecondName.Location = new System.Drawing.Point(129, 73);
            this.CBsecondName.MaxLength = 20;
            this.CBsecondName.Name = "CBsecondName";
            this.CBsecondName.Size = new System.Drawing.Size(94, 23);
            this.CBsecondName.TabIndex = 20;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L2.Location = new System.Drawing.Point(79, 55);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(32, 15);
            this.L2.TabIndex = 21;
            this.L2.Text = "Имя";
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L3.Location = new System.Drawing.Point(79, 99);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(60, 15);
            this.L3.TabIndex = 22;
            this.L3.Text = "Отчество";
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L4.Location = new System.Drawing.Point(79, 143);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(42, 15);
            this.L4.TabIndex = 23;
            this.L4.Text = "Адрес";
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
            // CBpost
            // 
            this.CBpost.FormattingEnabled = true;
            this.CBpost.Location = new System.Drawing.Point(147, 29);
            this.CBpost.MaxLength = 20;
            this.CBpost.Name = "CBpost";
            this.CBpost.Size = new System.Drawing.Size(76, 23);
            this.CBpost.TabIndex = 25;
            // 
            // L5
            // 
            this.L5.AutoSize = true;
            this.L5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L5.Location = new System.Drawing.Point(151, 11);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(72, 15);
            this.L5.TabIndex = 28;
            this.L5.Text = "Должность";
            // 
            // CBpass
            // 
            this.CBpass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBpass.FormattingEnabled = true;
            this.CBpass.Location = new System.Drawing.Point(47, 29);
            this.CBpass.MaxLength = 20;
            this.CBpass.Name = "CBpass";
            this.CBpass.Size = new System.Drawing.Size(94, 23);
            this.CBpass.TabIndex = 29;
            this.CBpass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountspace_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(79, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Телефон";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(79, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Email";
            // 
            // CBname
            // 
            this.CBname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBname.FormattingEnabled = true;
            this.CBname.Location = new System.Drawing.Point(47, 73);
            this.CBname.MaxLength = 20;
            this.CBname.Name = "CBname";
            this.CBname.Size = new System.Drawing.Size(76, 23);
            this.CBname.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(151, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 35;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(159, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 36;
            this.label4.Text = "Пароль";
            // 
            // TBpass
            // 
            this.TBpass.Location = new System.Drawing.Point(159, 248);
            this.TBpass.MaxLength = 20;
            this.TBpass.Name = "TBpass";
            this.TBpass.PasswordChar = '*';
            this.TBpass.PlaceholderText = "*******";
            this.TBpass.Size = new System.Drawing.Size(64, 23);
            this.TBpass.TabIndex = 38;
            // 
            // TBemail
            // 
            this.TBemail.Location = new System.Drawing.Point(47, 248);
            this.TBemail.MaxLength = 20;
            this.TBemail.Name = "TBemail";
            this.TBemail.PlaceholderText = "Необязательно";
            this.TBemail.Size = new System.Drawing.Size(106, 23);
            this.TBemail.TabIndex = 39;
            // 
            // TBphone
            // 
            this.TBphone.Location = new System.Drawing.Point(47, 205);
            this.TBphone.MaxLength = 20;
            this.TBphone.Name = "TBphone";
            this.TBphone.PlaceholderText = "Необязательно";
            this.TBphone.Size = new System.Drawing.Size(176, 23);
            this.TBphone.TabIndex = 40;
            this.TBphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amountplus_KeyPress);
            // 
            // FstaffAddStaff
            // 
            this.AcceptButton = this.BAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(268, 356);
            this.ControlBox = false;
            this.Controls.Add(this.TBphone);
            this.Controls.Add(this.TBemail);
            this.Controls.Add(this.TBpass);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBpass);
            this.Controls.Add(this.L5);
            this.Controls.Add(this.CBpost);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.L4);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.CBsecondName);
            this.Controls.Add(this.CBadress);
            this.Controls.Add(this.CBpatronymic);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.BAdd);
            this.MaximumSize = new System.Drawing.Size(284, 395);
            this.MinimumSize = new System.Drawing.Size(284, 395);
            this.Name = "FstaffAddStaff";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Добавление сотрудника";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.Label L1;
            private System.Windows.Forms.ComboBox CBpatronymic;
            private System.Windows.Forms.ComboBox adress;
            private System.Windows.Forms.ComboBox CBsecondName;
            private System.Windows.Forms.Label L2;
            private System.Windows.Forms.Label L3;
            private System.Windows.Forms.Label L4;
            private System.Windows.Forms.Button BCancel;
            private System.Windows.Forms.ComboBox CBadress;
            private System.Windows.Forms.Label L5;
            public System.Windows.Forms.Button BAdd;
            private System.Windows.Forms.ComboBox CBpass;
            private System.Windows.Forms.ComboBox CBpost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TBpass;
        private System.Windows.Forms.TextBox TBemail;
        private System.Windows.Forms.TextBox TBphone;
    }
    }

