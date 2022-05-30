
namespace optbaze
{
    partial class FpartnerAddPartner
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
            this.CBphone = new System.Windows.Forms.ComboBox();
            this.CBstaff = new System.Windows.Forms.ComboBox();
            this.CBaddress = new System.Windows.Forms.ComboBox();
            this.L2 = new System.Windows.Forms.Label();
            this.L3 = new System.Windows.Forms.Label();
            this.L4 = new System.Windows.Forms.Label();
            this.BCancel = new System.Windows.Forms.Button();
            this.CBname = new System.Windows.Forms.ComboBox();
            this.L5 = new System.Windows.Forms.Label();
            this.CBorg = new System.Windows.Forms.ComboBox();
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
            this.L1.Size = new System.Drawing.Size(95, 15);
            this.L1.TabIndex = 16;
            this.L1.Text = "Наименование";
            // 
            // CBphone
            // 
            this.CBphone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBphone.FormattingEnabled = true;
            this.CBphone.Location = new System.Drawing.Point(47, 117);
            this.CBphone.MaxLength = 12;
            this.CBphone.Name = "CBphone";
            this.CBphone.Size = new System.Drawing.Size(176, 23);
            this.CBphone.TabIndex = 17;
            this.CBphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.amount_KeyPress);
            // 
            // CBstaff
            // 
            this.CBstaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBstaff.FormattingEnabled = true;
            this.CBstaff.Location = new System.Drawing.Point(47, 161);
            this.CBstaff.MaxLength = 60;
            this.CBstaff.Name = "CBstaff";
            this.CBstaff.Size = new System.Drawing.Size(176, 23);
            this.CBstaff.TabIndex = 18;
            // 
            // CBaddress
            // 
            this.CBaddress.BackColor = System.Drawing.SystemColors.Window;
            this.CBaddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBaddress.FormattingEnabled = true;
            this.CBaddress.Location = new System.Drawing.Point(47, 73);
            this.CBaddress.MaxLength = 60;
            this.CBaddress.Name = "CBaddress";
            this.CBaddress.Size = new System.Drawing.Size(176, 23);
            this.CBaddress.TabIndex = 20;
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L2.Location = new System.Drawing.Point(79, 55);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(42, 15);
            this.L2.TabIndex = 21;
            this.L2.Text = "Адрес";
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L3.Location = new System.Drawing.Point(79, 99);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(57, 15);
            this.L3.TabIndex = 22;
            this.L3.Text = "Телефон";
            // 
            // L4
            // 
            this.L4.AutoSize = true;
            this.L4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L4.Location = new System.Drawing.Point(79, 143);
            this.L4.Name = "L4";
            this.L4.Size = new System.Drawing.Size(95, 15);
            this.L4.TabIndex = 23;
            this.L4.Text = "Представитель";
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
            // CBname
            // 
            this.CBname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBname.FormattingEnabled = true;
            this.CBname.Location = new System.Drawing.Point(47, 205);
            this.CBname.MaxLength = 60;
            this.CBname.Name = "CBname";
            this.CBname.Size = new System.Drawing.Size(176, 23);
            this.CBname.TabIndex = 25;
            // 
            // L5
            // 
            this.L5.AutoSize = true;
            this.L5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.L5.Location = new System.Drawing.Point(79, 187);
            this.L5.Name = "L5";
            this.L5.Size = new System.Drawing.Size(76, 15);
            this.L5.TabIndex = 28;
            this.L5.Text = "Обращение";
            // 
            // CBorg
            // 
            this.CBorg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CBorg.FormattingEnabled = true;
            this.CBorg.Location = new System.Drawing.Point(47, 29);
            this.CBorg.MaxLength = 40;
            this.CBorg.Name = "CBorg";
            this.CBorg.Size = new System.Drawing.Size(176, 23);
            this.CBorg.TabIndex = 29;
            // 
            // FpartnerAddPartner
            // 
            this.AcceptButton = this.BAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(268, 356);
            this.ControlBox = false;
            this.Controls.Add(this.CBorg);
            this.Controls.Add(this.L5);
            this.Controls.Add(this.CBname);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.L4);
            this.Controls.Add(this.L3);
            this.Controls.Add(this.L2);
            this.Controls.Add(this.CBaddress);
            this.Controls.Add(this.CBstaff);
            this.Controls.Add(this.CBphone);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.BAdd);
            this.MaximumSize = new System.Drawing.Size(284, 395);
            this.MinimumSize = new System.Drawing.Size(284, 395);
            this.Name = "FpartnerAddPartner";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Добавление контрагента";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.Label L1;
            private System.Windows.Forms.ComboBox CBphone;
            private System.Windows.Forms.ComboBox CBstaff;
            private System.Windows.Forms.ComboBox CBaddress;
            private System.Windows.Forms.Label L2;
            private System.Windows.Forms.Label L3;
            private System.Windows.Forms.Label L4;
            private System.Windows.Forms.Button BCancel;
            private System.Windows.Forms.Label L5;
            public System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.ComboBox CBorg;
        private System.Windows.Forms.ComboBox CBname;
    }
    }

