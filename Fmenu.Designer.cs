
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
            this.label1 = new System.Windows.Forms.Label();
            this.Bstatistics = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Border
            // 
            this.Border.BackColor = System.Drawing.Color.LemonChiffon;
            this.Border.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Border.Location = new System.Drawing.Point(177, 46);
            this.Border.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Border.Name = "Border";
            this.Border.Size = new System.Drawing.Size(286, 73);
            this.Border.TabIndex = 0;
            this.Border.Text = "Заявки";
            this.Border.UseVisualStyleBackColor = false;
            this.Border.Click += new System.EventHandler(this.Border_Click);
            // 
            // Bstock
            // 
            this.Bstock.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bstock.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bstock.Location = new System.Drawing.Point(177, 129);
            this.Bstock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bstock.Name = "Bstock";
            this.Bstock.Size = new System.Drawing.Size(286, 73);
            this.Bstock.TabIndex = 1;
            this.Bstock.Text = "Склад";
            this.Bstock.UseVisualStyleBackColor = false;
            this.Bstock.Click += new System.EventHandler(this.Bstock_Click);
            // 
            // Bstaff
            // 
            this.Bstaff.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bstaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bstaff.Location = new System.Drawing.Point(177, 295);
            this.Bstaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bstaff.Name = "Bstaff";
            this.Bstaff.Size = new System.Drawing.Size(286, 73);
            this.Bstaff.TabIndex = 3;
            this.Bstaff.Text = "Сотрудники";
            this.Bstaff.UseVisualStyleBackColor = false;
            this.Bstaff.Click += new System.EventHandler(this.Bstaff_Click);
            // 
            // Bcontr
            // 
            this.Bcontr.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bcontr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bcontr.Location = new System.Drawing.Point(177, 212);
            this.Bcontr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bcontr.Name = "Bcontr";
            this.Bcontr.Size = new System.Drawing.Size(286, 73);
            this.Bcontr.TabIndex = 2;
            this.Bcontr.Text = "Контрагенты";
            this.Bcontr.UseVisualStyleBackColor = false;
            this.Bcontr.Click += new System.EventHandler(this.Bcontr_Click);
            // 
            // Lusername
            // 
            this.Lusername.AutoSize = true;
            this.Lusername.BackColor = System.Drawing.Color.DarkKhaki;
            this.Lusername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lusername.Location = new System.Drawing.Point(615, 129);
            this.Lusername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lusername.Name = "Lusername";
            this.Lusername.Size = new System.Drawing.Size(224, 32);
            this.Lusername.TabIndex = 4;
            this.Lusername.Text = "Имя пользователя";
            // 
            // Tusername
            // 
            this.Tusername.BackColor = System.Drawing.Color.OldLace;
            this.Tusername.Location = new System.Drawing.Point(614, 171);
            this.Tusername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tusername.MaxLength = 20;
            this.Tusername.Name = "Tusername";
            this.Tusername.Size = new System.Drawing.Size(226, 31);
            this.Tusername.TabIndex = 5;
            this.Tusername.Text = "kislitsyn@nngasu.ru";
            // 
            // Tpassword
            // 
            this.Tpassword.BackColor = System.Drawing.Color.OldLace;
            this.Tpassword.Location = new System.Drawing.Point(614, 254);
            this.Tpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tpassword.MaxLength = 20;
            this.Tpassword.Name = "Tpassword";
            this.Tpassword.PasswordChar = '*';
            this.Tpassword.Size = new System.Drawing.Size(226, 31);
            this.Tpassword.TabIndex = 7;
            // 
            // Lpassword
            // 
            this.Lpassword.AutoSize = true;
            this.Lpassword.BackColor = System.Drawing.Color.DarkKhaki;
            this.Lpassword.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lpassword.Location = new System.Drawing.Point(615, 212);
            this.Lpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lpassword.Name = "Lpassword";
            this.Lpassword.Size = new System.Drawing.Size(225, 32);
            this.Lpassword.TabIndex = 6;
            this.Lpassword.Text = "Пароль                  ";
            // 
            // Benter
            // 
            this.Benter.BackColor = System.Drawing.Color.Tan;
            this.Benter.FlatAppearance.BorderSize = 0;
            this.Benter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Benter.Location = new System.Drawing.Point(614, 295);
            this.Benter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Benter.Name = "Benter";
            this.Benter.Size = new System.Drawing.Size(226, 43);
            this.Benter.TabIndex = 1;
            this.Benter.Text = "Войти";
            this.Benter.UseVisualStyleBackColor = false;
            this.Benter.Click += new System.EventHandler(this.Benter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(487, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сделано студенткой 2-курса ИС-30 Смирновой Анной";
            // 
            // Bstatistics
            // 
            this.Bstatistics.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bstatistics.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bstatistics.Location = new System.Drawing.Point(177, 378);
            this.Bstatistics.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bstatistics.Name = "Bstatistics";
            this.Bstatistics.Size = new System.Drawing.Size(286, 73);
            this.Bstatistics.TabIndex = 10;
            this.Bstatistics.Text = "Статистика";
            this.Bstatistics.UseVisualStyleBackColor = false;
            this.Bstatistics.Click += new System.EventHandler(this.Bstatistics_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkKhaki;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(601, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 235);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Tan;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(-10, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1049, 37);
            this.panel2.TabIndex = 12;
            // 
            // Fmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = global::optbaze.Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(1034, 539);
            this.Controls.Add(this.Bstatistics);
            this.Controls.Add(this.Benter);
            this.Controls.Add(this.Tpassword);
            this.Controls.Add(this.Lpassword);
            this.Controls.Add(this.Tusername);
            this.Controls.Add(this.Lusername);
            this.Controls.Add(this.Bstaff);
            this.Controls.Add(this.Bcontr);
            this.Controls.Add(this.Bstock);
            this.Controls.Add(this.Border);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1056, 595);
            this.MinimumSize = new System.Drawing.Size(1056, 595);
            this.Name = "Fmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптовая база";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fmenu_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Bstatistics;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

