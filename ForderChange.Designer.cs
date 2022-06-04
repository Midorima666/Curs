
namespace optbaze
{
    partial class ForderChange
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
            this.CBid = new System.Windows.Forms.ComboBox();
            this.Lgoods = new System.Windows.Forms.Label();
            this.Lstaff = new System.Windows.Forms.Label();
            this.BCancel = new System.Windows.Forms.Button();
            this.Lamount = new System.Windows.Forms.Label();
            this.TBgoods = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBbuyer = new System.Windows.Forms.ComboBox();
            this.CBamount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.CBamount)).BeginInit();
            this.SuspendLayout();
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
            // CBid
            // 
            this.CBid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBid.FormattingEnabled = true;
            this.CBid.Location = new System.Drawing.Point(67, 130);
            this.CBid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBid.Name = "CBid";
            this.CBid.Size = new System.Drawing.Size(250, 33);
            this.CBid.TabIndex = 18;
            this.CBid.SelectedIndexChanged += new System.EventHandler(this.CBid_SelectedIndexChanged);
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
            this.Lstaff.Location = new System.Drawing.Point(113, 100);
            this.Lstaff.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lstaff.Name = "Lstaff";
            this.Lstaff.Size = new System.Drawing.Size(137, 25);
            this.Lstaff.TabIndex = 23;
            this.Lstaff.Text = "Номер заявки";
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
            // Lamount
            // 
            this.Lamount.AutoSize = true;
            this.Lamount.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lamount.Location = new System.Drawing.Point(113, 227);
            this.Lamount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lamount.Name = "Lamount";
            this.Lamount.Size = new System.Drawing.Size(181, 25);
            this.Lamount.TabIndex = 27;
            this.Lamount.Text = "Количество товара";
            // 
            // TBgoods
            // 
            this.TBgoods.Location = new System.Drawing.Point(67, 193);
            this.TBgoods.MaxLength = 40;
            this.TBgoods.Name = "TBgoods";
            this.TBgoods.ReadOnly = true;
            this.TBgoods.Size = new System.Drawing.Size(250, 31);
            this.TBgoods.TabIndex = 28;
            this.TBgoods.TextChanged += new System.EventHandler(this.TBgoods_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(113, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Поставщик";
            // 
            // CBbuyer
            // 
            this.CBbuyer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBbuyer.FormattingEnabled = true;
            this.CBbuyer.Location = new System.Drawing.Point(67, 62);
            this.CBbuyer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBbuyer.Name = "CBbuyer";
            this.CBbuyer.Size = new System.Drawing.Size(250, 33);
            this.CBbuyer.TabIndex = 29;
            this.CBbuyer.SelectedIndexChanged += new System.EventHandler(this.CBbuyer_SelectedIndexChanged);
            // 
            // CBamount
            // 
            this.CBamount.Location = new System.Drawing.Point(67, 255);
            this.CBamount.Name = "CBamount";
            this.CBamount.Size = new System.Drawing.Size(250, 31);
            this.CBamount.TabIndex = 31;
            // 
            // ForderChange
            // 
            this.AcceptButton = this.BAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(374, 565);
            this.ControlBox = false;
            this.Controls.Add(this.CBamount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBbuyer);
            this.Controls.Add(this.TBgoods);
            this.Controls.Add(this.Lamount);
            this.Controls.Add(this.BCancel);
            this.Controls.Add(this.Lstaff);
            this.Controls.Add(this.Lgoods);
            this.Controls.Add(this.CBid);
            this.Controls.Add(this.BAdd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(396, 621);
            this.MinimumSize = new System.Drawing.Size(396, 621);
            this.Name = "ForderChange";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Выполнение заявки";
            ((System.ComponentModel.ISupportInitialize)(this.CBamount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.ComboBox CBid;
            private System.Windows.Forms.Label Lgoods;
            private System.Windows.Forms.Label Lstaff;
            private System.Windows.Forms.Button BCancel;
            private System.Windows.Forms.Label Lamount;
            public System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.TextBox TBgoods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBbuyer;
        private System.Windows.Forms.NumericUpDown CBamount;
    }
    }

