
namespace optbaze
{
    partial class Fmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fmenu));
            this.Border = new System.Windows.Forms.Button();
            this.Bstock = new System.Windows.Forms.Button();
            this.Bstaff = new System.Windows.Forms.Button();
            this.Bcontr = new System.Windows.Forms.Button();
            this.Lusername = new System.Windows.Forms.Label();
            this.Tusername = new System.Windows.Forms.TextBox();
            this.Tpassword = new System.Windows.Forms.TextBox();
            this.Lpassword = new System.Windows.Forms.Label();
            this.Benter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.LemonChiffon;
            this.Border.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Border.Location = new System.Drawing.Point(119, 87);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(200, 44);
            this.Border.TabIndex = 0;
            this.Border.Text = "Заявки";
            this.Border.UseVisualStyleBackColor = false;
            this.Border.Click += new System.EventHandler(this.Border_Click);
            // 
            // Bstock
            // 
            this.Bstock.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bstock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bstock.Location = new System.Drawing.Point(119, 159);
            this.Bstock.Name = "Bstock";
            this.Bstock.Size = new System.Drawing.Size(200, 44);
            this.Bstock.TabIndex = 1;
            this.Bstock.Text = "Склад";
            this.Bstock.UseVisualStyleBackColor = false;
            this.Bstock.Click += new System.EventHandler(this.Bstock_Click);
            // 
            // Bstaff
            // 
            this.Bstaff.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bstaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bstaff.Location = new System.Drawing.Point(119, 299);
            this.Bstaff.Name = "Bstaff";
            this.Bstaff.Size = new System.Drawing.Size(200, 44);
            this.Bstaff.TabIndex = 3;
            this.Bstaff.Text = "Сотрудники";
            this.Bstaff.UseVisualStyleBackColor = false;
            this.Bstaff.Click += new System.EventHandler(this.Bstaff_Click);
            // 
            // Bcontr
            // 
            this.Bcontr.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bcontr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bcontr.Location = new System.Drawing.Point(119, 227);
            this.Bcontr.Name = "Bcontr";
            this.Bcontr.Size = new System.Drawing.Size(200, 44);
            this.Bcontr.TabIndex = 2;
            this.Bcontr.Text = "Контрагенты";
            this.Bcontr.UseVisualStyleBackColor = false;
            this.Bcontr.Click += new System.EventHandler(this.Bcontr_Click);
            // 
            // Lusername
            // 
            this.Lusername.AutoSize = true;
            this.Lusername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lusername.Location = new System.Drawing.Point(387, 133);
            this.Lusername.Name = "Lusername";
            this.Lusername.Size = new System.Drawing.Size(151, 21);
            this.Lusername.TabIndex = 4;
            this.Lusername.Text = "Имя пользователя";
            // 
            // Tusername
            // 
            this.Tusername.Location = new System.Drawing.Point(387, 157);
            this.Tusername.MaxLength = 20;
            this.Tusername.Name = "Tusername";
            this.Tusername.Size = new System.Drawing.Size(200, 23);
            this.Tusername.TabIndex = 5;
            this.Tusername.Text = "kislitsyn@nngasu.ru";
            // 
            // Tpassword
            // 
            this.Tpassword.Location = new System.Drawing.Point(387, 205);
            this.Tpassword.MaxLength = 20;
            this.Tpassword.Name = "Tpassword";
            this.Tpassword.PasswordChar = '*';
            this.Tpassword.Size = new System.Drawing.Size(200, 23);
            this.Tpassword.TabIndex = 7;
            // 
            // Lpassword
            // 
            this.Lpassword.AutoSize = true;
            this.Lpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lpassword.Location = new System.Drawing.Point(387, 181);
            this.Lpassword.Name = "Lpassword";
            this.Lpassword.Size = new System.Drawing.Size(67, 21);
            this.Lpassword.TabIndex = 6;
            this.Lpassword.Text = "Пароль";
            // 
            // Benter
            // 
            this.Benter.BackColor = System.Drawing.Color.LemonChiffon;
            this.Benter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Benter.Location = new System.Drawing.Point(387, 249);
            this.Benter.Name = "Benter";
            this.Benter.Size = new System.Drawing.Size(200, 44);
            this.Benter.TabIndex = 8;
            this.Benter.Text = "Войти";
            this.Benter.UseVisualStyleBackColor = false;
            this.Benter.Click += new System.EventHandler(this.Benter_Click);
            // 
            // Fmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::optbaze.Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(752, 454);
            this.Controls.Add(this.Benter);
            this.Controls.Add(this.Tpassword);
            this.Controls.Add(this.Lpassword);
            this.Controls.Add(this.Tusername);
            this.Controls.Add(this.Lusername);
            this.Controls.Add(this.Bstaff);
            this.Controls.Add(this.Bcontr);
            this.Controls.Add(this.Bstock);
            this.Controls.Add(this.Border);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(768, 493);
            this.MinimumSize = new System.Drawing.Size(768, 493);
            this.Name = "Fmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптовая база";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fmenu_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Border;
        private System.Windows.Forms.Button Bstock;
        private System.Windows.Forms.Button Bstaff;
        private System.Windows.Forms.Button Bcontr;
        private System.Windows.Forms.Label Lusername;
        private System.Windows.Forms.TextBox Tusername;
        private System.Windows.Forms.TextBox Tpassword;
        private System.Windows.Forms.Label Lpassword;
        private System.Windows.Forms.Button Benter;
    }
}

