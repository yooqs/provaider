namespace provaider
{
    partial class Form_customers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_customers_new = new System.Windows.Forms.Button();
            this.button_customers_edit = new System.Windows.Forms.Button();
            this.button_customers_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_dismissal = new System.Windows.Forms.CheckBox();
            this.date_date5 = new System.Windows.Forms.DateTimePicker();
            this.date_date6 = new System.Windows.Forms.DateTimePicker();
            this.checkBox_date5 = new System.Windows.Forms.CheckBox();
            this.checkBox_date6 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox_post = new System.Windows.Forms.ComboBox();
            this.checkBox_post = new System.Windows.Forms.CheckBox();
            this.date_date3 = new System.Windows.Forms.DateTimePicker();
            this.date_date4 = new System.Windows.Forms.DateTimePicker();
            this.checkBox_date3 = new System.Windows.Forms.CheckBox();
            this.checkBox_date4 = new System.Windows.Forms.CheckBox();
            this.checkBox_date2 = new System.Windows.Forms.CheckBox();
            this.date_date1 = new System.Windows.Forms.DateTimePicker();
            this.date_date2 = new System.Windows.Forms.DateTimePicker();
            this.checkBox_date1 = new System.Windows.Forms.CheckBox();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_conclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.last_name,
            this.first_name,
            this.patronymic,
            this.telephone,
            this.adress,
            this.date_birth,
            this.passport_series,
            this.passport_number,
            this.date_conclusion});
            this.dataGridView1.Location = new System.Drawing.Point(2, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1135, 165);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_customers_new
            // 
            this.button_customers_new.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_customers_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_customers_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_customers_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customers_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_customers_new.Location = new System.Drawing.Point(244, 293);
            this.button_customers_new.Name = "button_customers_new";
            this.button_customers_new.Size = new System.Drawing.Size(165, 39);
            this.button_customers_new.TabIndex = 24;
            this.button_customers_new.Text = "Добавить";
            this.button_customers_new.UseVisualStyleBackColor = true;
            this.button_customers_new.Click += new System.EventHandler(this.button_customers_new_Click_1);
            // 
            // button_customers_edit
            // 
            this.button_customers_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_customers_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_customers_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_customers_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customers_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_customers_edit.Location = new System.Drawing.Point(444, 293);
            this.button_customers_edit.Name = "button_customers_edit";
            this.button_customers_edit.Size = new System.Drawing.Size(165, 39);
            this.button_customers_edit.TabIndex = 25;
            this.button_customers_edit.Text = "Изменить";
            this.button_customers_edit.UseVisualStyleBackColor = true;
            this.button_customers_edit.Click += new System.EventHandler(this.button_customers_edit_Click);
            // 
            // button_customers_delete
            // 
            this.button_customers_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_customers_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_customers_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_customers_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customers_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_customers_delete.Location = new System.Drawing.Point(639, 293);
            this.button_customers_delete.Name = "button_customers_delete";
            this.button_customers_delete.Size = new System.Drawing.Size(165, 39);
            this.button_customers_delete.TabIndex = 26;
            this.button_customers_delete.Text = "Удалить";
            this.button_customers_delete.UseVisualStyleBackColor = true;
            this.button_customers_delete.Click += new System.EventHandler(this.button_customers_delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.checkBox_dismissal);
            this.panel1.Controls.Add(this.date_date5);
            this.panel1.Controls.Add(this.date_date6);
            this.panel1.Controls.Add(this.checkBox_date5);
            this.panel1.Controls.Add(this.checkBox_date6);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.comboBox_post);
            this.panel1.Controls.Add(this.checkBox_post);
            this.panel1.Controls.Add(this.date_date3);
            this.panel1.Controls.Add(this.date_date4);
            this.panel1.Controls.Add(this.checkBox_date3);
            this.panel1.Controls.Add(this.checkBox_date4);
            this.panel1.Controls.Add(this.checkBox_date2);
            this.panel1.Controls.Add(this.date_date1);
            this.panel1.Controls.Add(this.date_date2);
            this.panel1.Controls.Add(this.checkBox_date1);
            this.panel1.Location = new System.Drawing.Point(504, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 116);
            this.panel1.TabIndex = 53;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBox_dismissal
            // 
            this.checkBox_dismissal.AutoSize = true;
            this.checkBox_dismissal.Location = new System.Drawing.Point(438, 48);
            this.checkBox_dismissal.Name = "checkBox_dismissal";
            this.checkBox_dismissal.Size = new System.Drawing.Size(153, 17);
            this.checkBox_dismissal.TabIndex = 44;
            this.checkBox_dismissal.Text = "не показывать уволеных";
            this.checkBox_dismissal.UseVisualStyleBackColor = true;
            // 
            // date_date5
            // 
            this.date_date5.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_date5.Location = new System.Drawing.Point(294, 23);
            this.date_date5.Name = "date_date5";
            this.date_date5.Size = new System.Drawing.Size(133, 20);
            this.date_date5.TabIndex = 41;
            // 
            // date_date6
            // 
            this.date_date6.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_date6.Location = new System.Drawing.Point(294, 80);
            this.date_date6.Name = "date_date6";
            this.date_date6.Size = new System.Drawing.Size(133, 20);
            this.date_date6.TabIndex = 43;
            // 
            // checkBox_date5
            // 
            this.checkBox_date5.AutoSize = true;
            this.checkBox_date5.Location = new System.Drawing.Point(294, 3);
            this.checkBox_date5.Name = "checkBox_date5";
            this.checkBox_date5.Size = new System.Drawing.Size(133, 17);
            this.checkBox_date5.TabIndex = 40;
            this.checkBox_date5.Text = "Дата возвращения с";
            this.checkBox_date5.UseVisualStyleBackColor = true;
            // 
            // checkBox_date6
            // 
            this.checkBox_date6.AutoSize = true;
            this.checkBox_date6.Location = new System.Drawing.Point(294, 62);
            this.checkBox_date6.Name = "checkBox_date6";
            this.checkBox_date6.Size = new System.Drawing.Size(139, 17);
            this.checkBox_date6.TabIndex = 42;
            this.checkBox_date6.Text = "Дата возвращения до";
            this.checkBox_date6.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(438, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(152, 27);
            this.button3.TabIndex = 39;
            this.button3.Text = "Применить фильтр";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // comboBox_post
            // 
            this.comboBox_post.FormattingEnabled = true;
            this.comboBox_post.Location = new System.Drawing.Point(437, 21);
            this.comboBox_post.Name = "comboBox_post";
            this.comboBox_post.Size = new System.Drawing.Size(154, 21);
            this.comboBox_post.TabIndex = 36;
            // 
            // checkBox_post
            // 
            this.checkBox_post.AutoSize = true;
            this.checkBox_post.Location = new System.Drawing.Point(437, 3);
            this.checkBox_post.Name = "checkBox_post";
            this.checkBox_post.Size = new System.Drawing.Size(84, 17);
            this.checkBox_post.TabIndex = 30;
            this.checkBox_post.Text = "Должность";
            this.checkBox_post.UseVisualStyleBackColor = true;
            // 
            // date_date3
            // 
            this.date_date3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_date3.Location = new System.Drawing.Point(151, 23);
            this.date_date3.Name = "date_date3";
            this.date_date3.Size = new System.Drawing.Size(129, 20);
            this.date_date3.TabIndex = 33;
            // 
            // date_date4
            // 
            this.date_date4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_date4.Location = new System.Drawing.Point(151, 80);
            this.date_date4.Name = "date_date4";
            this.date_date4.Size = new System.Drawing.Size(129, 20);
            this.date_date4.TabIndex = 35;
            // 
            // checkBox_date3
            // 
            this.checkBox_date3.AutoSize = true;
            this.checkBox_date3.Location = new System.Drawing.Point(151, 3);
            this.checkBox_date3.Name = "checkBox_date3";
            this.checkBox_date3.Size = new System.Drawing.Size(129, 17);
            this.checkBox_date3.TabIndex = 32;
            this.checkBox_date3.Text = "Дата отправления с";
            this.checkBox_date3.UseVisualStyleBackColor = true;
            // 
            // checkBox_date4
            // 
            this.checkBox_date4.AutoSize = true;
            this.checkBox_date4.Location = new System.Drawing.Point(151, 62);
            this.checkBox_date4.Name = "checkBox_date4";
            this.checkBox_date4.Size = new System.Drawing.Size(135, 17);
            this.checkBox_date4.TabIndex = 34;
            this.checkBox_date4.Text = "Дата отправления до";
            this.checkBox_date4.UseVisualStyleBackColor = true;
            // 
            // checkBox_date2
            // 
            this.checkBox_date2.AutoSize = true;
            this.checkBox_date2.Location = new System.Drawing.Point(8, 62);
            this.checkBox_date2.Name = "checkBox_date2";
            this.checkBox_date2.Size = new System.Drawing.Size(135, 17);
            this.checkBox_date2.TabIndex = 29;
            this.checkBox_date2.Text = "Дата составления до";
            this.checkBox_date2.UseVisualStyleBackColor = true;
            // 
            // date_date1
            // 
            this.date_date1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_date1.Location = new System.Drawing.Point(8, 23);
            this.date_date1.Name = "date_date1";
            this.date_date1.Size = new System.Drawing.Size(125, 20);
            this.date_date1.TabIndex = 29;
            // 
            // date_date2
            // 
            this.date_date2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_date2.Location = new System.Drawing.Point(8, 80);
            this.date_date2.Name = "date_date2";
            this.date_date2.Size = new System.Drawing.Size(125, 20);
            this.date_date2.TabIndex = 31;
            // 
            // checkBox_date1
            // 
            this.checkBox_date1.AutoSize = true;
            this.checkBox_date1.Location = new System.Drawing.Point(8, 3);
            this.checkBox_date1.Name = "checkBox_date1";
            this.checkBox_date1.Size = new System.Drawing.Size(129, 17);
            this.checkBox_date1.TabIndex = 28;
            this.checkBox_date1.Text = "Дата составления с";
            this.checkBox_date1.UseVisualStyleBackColor = true;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.FillWeight = 253.8071F;
            this.id.HeaderText = "№ договора";
            this.id.Name = "id";
            this.id.Width = 93;
            // 
            // last_name
            // 
            this.last_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.last_name.FillWeight = 82.91032F;
            this.last_name.HeaderText = "Фамилия";
            this.last_name.Name = "last_name";
            this.last_name.Width = 81;
            // 
            // first_name
            // 
            this.first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.first_name.FillWeight = 82.91032F;
            this.first_name.HeaderText = "Имя";
            this.first_name.Name = "first_name";
            this.first_name.Width = 54;
            // 
            // patronymic
            // 
            this.patronymic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.patronymic.FillWeight = 82.91032F;
            this.patronymic.HeaderText = "Отчество";
            this.patronymic.Name = "patronymic";
            this.patronymic.Width = 79;
            // 
            // telephone
            // 
            this.telephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.telephone.FillWeight = 82.91032F;
            this.telephone.HeaderText = "Телефон";
            this.telephone.Name = "telephone";
            this.telephone.Width = 77;
            // 
            // adress
            // 
            this.adress.FillWeight = 82.91032F;
            this.adress.HeaderText = "Адрес";
            this.adress.Name = "adress";
            // 
            // date_birth
            // 
            this.date_birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date_birth.FillWeight = 82.91032F;
            this.date_birth.HeaderText = "Дата заключения договора";
            this.date_birth.Name = "date_birth";
            this.date_birth.Width = 114;
            // 
            // passport_series
            // 
            this.passport_series.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.passport_series.FillWeight = 82.91032F;
            this.passport_series.HeaderText = "Серия паспорта";
            this.passport_series.Name = "passport_series";
            this.passport_series.Width = 104;
            // 
            // passport_number
            // 
            this.passport_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.passport_number.FillWeight = 82.91032F;
            this.passport_number.HeaderText = "Номер паспорта";
            this.passport_number.Name = "passport_number";
            this.passport_number.Width = 106;
            // 
            // date_conclusion
            // 
            this.date_conclusion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date_conclusion.FillWeight = 82.91032F;
            this.date_conclusion.HeaderText = "Дата рождения";
            this.date_conclusion.Name = "date_conclusion";
            this.date_conclusion.Width = 102;
            // 
            // Form_customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 344);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_customers_delete);
            this.Controls.Add(this.button_customers_edit);
            this.Controls.Add(this.button_customers_new);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_customers";
            this.Text = "Form_customers";
            this.Activated += new System.EventHandler(this.Form_customers_Activated);
            this.Load += new System.EventHandler(this.Form_customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_customers_new;
        private System.Windows.Forms.Button button_customers_edit;
        private System.Windows.Forms.Button button_customers_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox_dismissal;
        private System.Windows.Forms.DateTimePicker date_date5;
        private System.Windows.Forms.DateTimePicker date_date6;
        private System.Windows.Forms.CheckBox checkBox_date5;
        private System.Windows.Forms.CheckBox checkBox_date6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox_post;
        private System.Windows.Forms.CheckBox checkBox_post;
        private System.Windows.Forms.DateTimePicker date_date3;
        private System.Windows.Forms.DateTimePicker date_date4;
        private System.Windows.Forms.CheckBox checkBox_date3;
        private System.Windows.Forms.CheckBox checkBox_date4;
        private System.Windows.Forms.CheckBox checkBox_date2;
        private System.Windows.Forms.DateTimePicker date_date1;
        private System.Windows.Forms.DateTimePicker date_date2;
        private System.Windows.Forms.CheckBox checkBox_date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_series;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_conclusion;
    }
}