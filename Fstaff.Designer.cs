
namespace optbaze
{
    partial class Fstaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fstaff));
            this.Tfio = new System.Windows.Forms.TextBox();
            this.Bsourse = new System.Windows.Forms.Button();
            this.Bback = new System.Windows.Forms.Button();
            this.BAddStaff = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BChangePost = new System.Windows.Forms.Button();
            this.Tpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBpost = new System.Windows.Forms.ComboBox();
            this.Torder = new System.Windows.Forms.TextBox();
            this.CBstatus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tfio
            // 
            this.Tfio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tfio.Location = new System.Drawing.Point(39, 55);
            this.Tfio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tfio.MaxLength = 16;
            this.Tfio.Name = "Tfio";
            this.Tfio.PlaceholderText = "ФИО";
            this.Tfio.Size = new System.Drawing.Size(177, 31);
            this.Tfio.TabIndex = 5;
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
            // BAddStaff
            // 
            this.BAddStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BAddStaff.BackColor = System.Drawing.Color.LemonChiffon;
            this.BAddStaff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAddStaff.Location = new System.Drawing.Point(723, 663);
            this.BAddStaff.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BAddStaff.Name = "BAddStaff";
            this.BAddStaff.Size = new System.Drawing.Size(286, 73);
            this.BAddStaff.TabIndex = 13;
            this.BAddStaff.Text = "Добавить сотрудника";
            this.BAddStaff.UseVisualStyleBackColor = false;
            this.BAddStaff.Click += new System.EventHandler(this.BAddStaff_Click);
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
            this.dataGridView1.ReadOnly = true;
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
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // BChangePost
            // 
            this.BChangePost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BChangePost.BackColor = System.Drawing.Color.LemonChiffon;
            this.BChangePost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BChangePost.Location = new System.Drawing.Point(400, 663);
            this.BChangePost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BChangePost.Name = "BChangePost";
            this.BChangePost.Size = new System.Drawing.Size(286, 73);
            this.BChangePost.TabIndex = 18;
            this.BChangePost.Text = "Изменить данные";
            this.BChangePost.UseVisualStyleBackColor = false;
            this.BChangePost.Click += new System.EventHandler(this.BChangePost_Click);
            // 
            // Tpass
            // 
            this.Tpass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tpass.Location = new System.Drawing.Point(226, 55);
            this.Tpass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Tpass.MaxLength = 16;
            this.Tpass.Name = "Tpass";
            this.Tpass.PlaceholderText = "Паспорт";
            this.Tpass.Size = new System.Drawing.Size(177, 31);
            this.Tpass.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Tan;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(709, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Должность";
            // 
            // CBpost
            // 
            this.CBpost.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBpost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBpost.FormattingEnabled = true;
            this.CBpost.Location = new System.Drawing.Point(709, 55);
            this.CBpost.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBpost.Name = "CBpost";
            this.CBpost.Size = new System.Drawing.Size(177, 33);
            this.CBpost.TabIndex = 24;
            // 
            // Torder
            // 
            this.Torder.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Torder.Location = new System.Drawing.Point(413, 55);
            this.Torder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Torder.MaxLength = 16;
            this.Torder.Name = "Torder";
            this.Torder.PlaceholderText = "Номер заявки";
            this.Torder.Size = new System.Drawing.Size(128, 31);
            this.Torder.TabIndex = 25;
            // 
            // CBstatus
            // 
            this.CBstatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBstatus.FormattingEnabled = true;
            this.CBstatus.Items.AddRange(new object[] {
            "Любой",
            "Уволен",
            "Работает"});
            this.CBstatus.Location = new System.Drawing.Point(549, 55);
            this.CBstatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CBstatus.Name = "CBstatus";
            this.CBstatus.Size = new System.Drawing.Size(152, 33);
            this.CBstatus.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tan;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(549, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 26;
            this.label2.Text = "Статус";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(26, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 78);
            this.panel1.TabIndex = 31;
            // 
            // Fstaff
            // 
            this.AcceptButton = this.Bsourse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::optbaze.Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(1074, 757);
            this.Controls.Add(this.CBstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Torder);
            this.Controls.Add(this.CBpost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tpass);
            this.Controls.Add(this.BChangePost);
            this.Controls.Add(this.BAddStaff);
            this.Controls.Add(this.Bback);
            this.Controls.Add(this.Bsourse);
            this.Controls.Add(this.Tfio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1088, 784);
            this.Name = "Fstaff";
            this.Text = "Оптовая база | Сотрудники";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Forder_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.TextBox Tfio;
            private System.Windows.Forms.Button Bsourse;
            private System.Windows.Forms.Button Bback;
            private System.Windows.Forms.Button BAddStaff;
            private System.Windows.Forms.DataGridView dataGridView1;
            private System.Windows.Forms.Button BAddDpartner;
            private System.Windows.Forms.TextBox Tpass;
            private System.Windows.Forms.Button BChangePost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBpost;
        private System.Windows.Forms.TextBox Torder;
        private System.Windows.Forms.ComboBox CBstatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
    }

