
namespace optbaze
{
    partial class Fpartner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fpartner));
            this.Tfirm = new System.Windows.Forms.TextBox();
            this.Bsourse = new System.Windows.Forms.Button();
            this.Bback = new System.Windows.Forms.Button();
            this.BAddPact = new System.Windows.Forms.Button();
            this.Tprovider = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BAddPartner = new System.Windows.Forms.Button();
            this.Tpact = new System.Windows.Forms.TextBox();
            this.CBdelivery = new System.Windows.Forms.CheckBox();
            this.CBsale = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tfirm
            // 
            this.Tfirm.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tfirm.Location = new System.Drawing.Point(54, 33);
            this.Tfirm.MaxLength = 16;
            this.Tfirm.Name = "Tfirm";
            this.Tfirm.PlaceholderText = "Название фирмы";
            this.Tfirm.Size = new System.Drawing.Size(125, 23);
            this.Tfirm.TabIndex = 5;
            // 
            // Bsourse
            // 
            this.Bsourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Bsourse.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bsourse.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bsourse.Location = new System.Drawing.Point(626, 26);
            this.Bsourse.Name = "Bsourse";
            this.Bsourse.Size = new System.Drawing.Size(80, 36);
            this.Bsourse.TabIndex = 8;
            this.Bsourse.Text = "Искать";
            this.Bsourse.UseVisualStyleBackColor = false;
            this.Bsourse.Click += new System.EventHandler(this.Bsourse_Click);
            // 
            // Bback
            // 
            this.Bback.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Bback.BackColor = System.Drawing.Color.LemonChiffon;
            this.Bback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bback.Location = new System.Drawing.Point(54, 398);
            this.Bback.Name = "Bback";
            this.Bback.Size = new System.Drawing.Size(200, 44);
            this.Bback.TabIndex = 10;
            this.Bback.Text = "Назад";
            this.Bback.UseVisualStyleBackColor = false;
            this.Bback.Click += new System.EventHandler(this.Bback_Click);
            // 
            // BAddPact
            // 
            this.BAddPact.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BAddPact.BackColor = System.Drawing.Color.LemonChiffon;
            this.BAddPact.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAddPact.Location = new System.Drawing.Point(506, 398);
            this.BAddPact.Name = "BAddPact";
            this.BAddPact.Size = new System.Drawing.Size(200, 44);
            this.BAddPact.TabIndex = 13;
            this.BAddPact.Text = "Добавить договор";
            this.BAddPact.UseVisualStyleBackColor = false;
            this.BAddPact.Click += new System.EventHandler(this.BAddPact_Click);
            // 
            // Tprovider
            // 
            this.Tprovider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tprovider.Location = new System.Drawing.Point(185, 33);
            this.Tprovider.MaxLength = 16;
            this.Tprovider.Name = "Tprovider";
            this.Tprovider.PlaceholderText = "Представитель";
            this.Tprovider.Size = new System.Drawing.Size(125, 23);
            this.Tprovider.TabIndex = 15;
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
            this.dataGridView1.Location = new System.Drawing.Point(0, 68);
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LemonChiffon;
            dataGridViewCellStyle4.NullValue = " — ";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Olive;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(752, 324);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // BAddPartner
            // 
            this.BAddPartner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BAddPartner.BackColor = System.Drawing.Color.LemonChiffon;
            this.BAddPartner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAddPartner.Location = new System.Drawing.Point(280, 398);
            this.BAddPartner.Name = "BAddPartner";
            this.BAddPartner.Size = new System.Drawing.Size(200, 44);
            this.BAddPartner.TabIndex = 18;
            this.BAddPartner.Text = "Добавить контрагента";
            this.BAddPartner.UseVisualStyleBackColor = false;
            this.BAddPartner.Click += new System.EventHandler(this.BAddPartner_Click);
            // 
            // Tpact
            // 
            this.Tpact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tpact.Location = new System.Drawing.Point(316, 33);
            this.Tpact.MaxLength = 16;
            this.Tpact.Name = "Tpact";
            this.Tpact.PlaceholderText = "Номер договора";
            this.Tpact.Size = new System.Drawing.Size(125, 23);
            this.Tpact.TabIndex = 19;
            // 
            // CBdelivery
            // 
            this.CBdelivery.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBdelivery.BackColor = System.Drawing.Color.Tan;
            this.CBdelivery.Checked = true;
            this.CBdelivery.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBdelivery.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CBdelivery.Location = new System.Drawing.Point(447, 33);
            this.CBdelivery.Name = "CBdelivery";
            this.CBdelivery.Size = new System.Drawing.Size(82, 23);
            this.CBdelivery.TabIndex = 20;
            this.CBdelivery.Text = "Поставка";
            this.CBdelivery.UseVisualStyleBackColor = false;
            // 
            // CBsale
            // 
            this.CBsale.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBsale.BackColor = System.Drawing.Color.Tan;
            this.CBsale.Checked = true;
            this.CBsale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBsale.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CBsale.Location = new System.Drawing.Point(535, 33);
            this.CBsale.Name = "CBsale";
            this.CBsale.Size = new System.Drawing.Size(82, 23);
            this.CBsale.TabIndex = 21;
            this.CBsale.Text = "Продажа";
            this.CBsale.UseVisualStyleBackColor = false;
            // 
            // Fpartner
            // 
            this.AcceptButton = this.Bsourse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::optbaze.Properties.Resources.fon;
            this.ClientSize = new System.Drawing.Size(752, 454);
            this.Controls.Add(this.CBsale);
            this.Controls.Add(this.CBdelivery);
            this.Controls.Add(this.Tpact);
            this.Controls.Add(this.BAddPartner);
            this.Controls.Add(this.Tprovider);
            this.Controls.Add(this.BAddPact);
            this.Controls.Add(this.Bback);
            this.Controls.Add(this.Bsourse);
            this.Controls.Add(this.Tfirm);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(768, 493);
            this.Name = "Fpartner";
            this.Text = "Оптовая база | Контрагенты";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Forder_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

            #endregion
            private System.Windows.Forms.TextBox Tfirm;
            private System.Windows.Forms.Button Bsourse;
            private System.Windows.Forms.Button Bback;
            private System.Windows.Forms.Button BAddPact;
            private System.Windows.Forms.TextBox Tprovider;
            private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Tpact;
        private System.Windows.Forms.CheckBox CBdelivery;
        private System.Windows.Forms.CheckBox CBsale;
        private System.Windows.Forms.Button BAddPartner;
    }
    }

