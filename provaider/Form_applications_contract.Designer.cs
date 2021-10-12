namespace provaider
{
    partial class Form_applications_contract
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
            this.button_customers_new = new System.Windows.Forms.Button();
            this.button_user_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_date5 = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox_post = new System.Windows.Forms.ComboBox();
            this.checkBox_post = new System.Windows.Forms.CheckBox();
            this.checkBox_date3 = new System.Windows.Forms.CheckBox();
            this.checkBox_date1 = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox_passport_number = new System.Windows.Forms.MaskedTextBox();
            this.textBox_passport_series = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_last_name = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 128);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1143, 140);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.FillWeight = 253.8071F;
            this.id.HeaderText = "№ договора";
            this.id.Name = "id";
            this.id.Width = 86;
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
            // button_customers_new
            // 
            this.button_customers_new.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_customers_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_customers_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_customers_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customers_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_customers_new.Location = new System.Drawing.Point(499, 274);
            this.button_customers_new.Name = "button_customers_new";
            this.button_customers_new.Size = new System.Drawing.Size(165, 39);
            this.button_customers_new.TabIndex = 28;
            this.button_customers_new.Text = "Выбрать";
            this.button_customers_new.UseVisualStyleBackColor = true;
            this.button_customers_new.Click += new System.EventHandler(this.button_customers_new_Click);
            // 
            // button_user_search
            // 
            this.button_user_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_user_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_user_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_user_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_user_search.Location = new System.Drawing.Point(237, 35);
            this.button_user_search.Name = "button_user_search";
            this.button_user_search.Size = new System.Drawing.Size(87, 26);
            this.button_user_search.TabIndex = 55;
            this.button_user_search.Text = "Поиск";
            this.button_user_search.UseVisualStyleBackColor = true;
            this.button_user_search.Click += new System.EventHandler(this.button_user_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 53;
            this.label1.Text = "Поиск по фамилии";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.textBox_passport_number);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.textBox_passport_series);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.checkBox_date5);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.comboBox_post);
            this.panel1.Controls.Add(this.checkBox_post);
            this.panel1.Controls.Add(this.checkBox_date3);
            this.panel1.Controls.Add(this.checkBox_date1);
            this.panel1.Location = new System.Drawing.Point(343, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(812, 110);
            this.panel1.TabIndex = 56;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBox_date5
            // 
            this.checkBox_date5.AutoSize = true;
            this.checkBox_date5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_date5.Location = new System.Drawing.Point(420, 5);
            this.checkBox_date5.Name = "checkBox_date5";
            this.checkBox_date5.Size = new System.Drawing.Size(90, 21);
            this.checkBox_date5.TabIndex = 40;
            this.checkBox_date5.Text = "Квартира";
            this.checkBox_date5.UseVisualStyleBackColor = true;
            this.checkBox_date5.CheckedChanged += new System.EventHandler(this.checkBox_date5_CheckedChanged);
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(650, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 30);
            this.button3.TabIndex = 39;
            this.button3.Text = "Применить фильтр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox_post
            // 
            this.comboBox_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_post.FormattingEnabled = true;
            this.comboBox_post.Location = new System.Drawing.Point(9, 22);
            this.comboBox_post.Name = "comboBox_post";
            this.comboBox_post.Size = new System.Drawing.Size(178, 24);
            this.comboBox_post.TabIndex = 36;
            this.comboBox_post.SelectedIndexChanged += new System.EventHandler(this.comboBox_post_SelectedIndexChanged);
            // 
            // checkBox_post
            // 
            this.checkBox_post.AutoSize = true;
            this.checkBox_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_post.Location = new System.Drawing.Point(539, 5);
            this.checkBox_post.Name = "checkBox_post";
            this.checkBox_post.Size = new System.Drawing.Size(55, 21);
            this.checkBox_post.TabIndex = 30;
            this.checkBox_post.Text = "Дом";
            this.checkBox_post.UseVisualStyleBackColor = true;
            this.checkBox_post.CheckedChanged += new System.EventHandler(this.checkBox_post_CheckedChanged);
            // 
            // checkBox_date3
            // 
            this.checkBox_date3.AutoSize = true;
            this.checkBox_date3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_date3.Location = new System.Drawing.Point(215, 2);
            this.checkBox_date3.Name = "checkBox_date3";
            this.checkBox_date3.Size = new System.Drawing.Size(68, 21);
            this.checkBox_date3.TabIndex = 32;
            this.checkBox_date3.Text = "Улица";
            this.checkBox_date3.UseVisualStyleBackColor = true;
            this.checkBox_date3.CheckedChanged += new System.EventHandler(this.checkBox_date3_CheckedChanged);
            // 
            // checkBox_date1
            // 
            this.checkBox_date1.AutoSize = true;
            this.checkBox_date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_date1.Location = new System.Drawing.Point(9, 3);
            this.checkBox_date1.Name = "checkBox_date1";
            this.checkBox_date1.Size = new System.Drawing.Size(67, 21);
            this.checkBox_date1.TabIndex = 28;
            this.checkBox_date1.Text = "Город";
            this.checkBox_date1.UseVisualStyleBackColor = true;
            this.checkBox_date1.CheckedChanged += new System.EventHandler(this.checkBox_date1_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(215, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(187, 24);
            this.comboBox2.TabIndex = 45;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(420, 23);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 24);
            this.comboBox3.TabIndex = 46;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(540, 23);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(80, 24);
            this.comboBox4.TabIndex = 47;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(650, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(87, 21);
            this.checkBox1.TabIndex = 51;
            this.checkBox1.Text = "Телефон";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox2.Location = new System.Drawing.Point(215, 61);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(136, 21);
            this.checkBox2.TabIndex = 49;
            this.checkBox2.Text = "Номер паспорта";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox3.Location = new System.Drawing.Point(9, 62);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(134, 21);
            this.checkBox3.TabIndex = 48;
            this.checkBox3.Text = "Серия паспорта";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox4.Location = new System.Drawing.Point(419, 59);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(209, 21);
            this.checkBox4.TabIndex = 55;
            this.checkBox4.Text = "Дата заключения договора";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(418, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(202, 24);
            this.dateTimePicker1.TabIndex = 227;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Enabled = false;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(650, 24);
            this.maskedTextBox1.Mask = "+7(000)-000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(153, 24);
            this.maskedTextBox1.TabIndex = 226;
            // 
            // textBox_passport_number
            // 
            this.textBox_passport_number.Enabled = false;
            this.textBox_passport_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_passport_number.Location = new System.Drawing.Point(215, 81);
            this.textBox_passport_number.Mask = "000000";
            this.textBox_passport_number.Name = "textBox_passport_number";
            this.textBox_passport_number.Size = new System.Drawing.Size(187, 24);
            this.textBox_passport_number.TabIndex = 225;
            this.textBox_passport_number.ValidatingType = typeof(int);
            // 
            // textBox_passport_series
            // 
            this.textBox_passport_series.Enabled = false;
            this.textBox_passport_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_passport_series.Location = new System.Drawing.Point(9, 81);
            this.textBox_passport_series.Mask = "0000";
            this.textBox_passport_series.Name = "textBox_passport_series";
            this.textBox_passport_series.Size = new System.Drawing.Size(178, 24);
            this.textBox_passport_series.TabIndex = 224;
            this.textBox_passport_series.ValidatingType = typeof(int);
            // 
            // comboBox_last_name
            // 
            this.comboBox_last_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_last_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_last_name.FormattingEnabled = true;
            this.comboBox_last_name.Location = new System.Drawing.Point(21, 33);
            this.comboBox_last_name.Name = "comboBox_last_name";
            this.comboBox_last_name.Size = new System.Drawing.Size(198, 26);
            this.comboBox_last_name.TabIndex = 225;
            // 
            // Form_applications_contract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 314);
            this.Controls.Add(this.comboBox_last_name);
            this.Controls.Add(this.button_user_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_customers_new);
            this.Name = "Form_applications_contract";
            this.Text = "Form_applications_contract";
            this.Load += new System.EventHandler(this.Form_applications_contract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button button_customers_new;
        private System.Windows.Forms.Button button_user_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox checkBox_date5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox_post;
        private System.Windows.Forms.CheckBox checkBox_post;
        private System.Windows.Forms.CheckBox checkBox_date3;
        private System.Windows.Forms.CheckBox checkBox_date1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.MaskedTextBox textBox_passport_number;
        private System.Windows.Forms.MaskedTextBox textBox_passport_series;
        private System.Windows.Forms.ComboBox comboBox_last_name;
    }
}