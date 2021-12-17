namespace provaider
{
    partial class Form_employee_new
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_employee_new));
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_street = new System.Windows.Forms.ComboBox();
            this.textBox_flat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button_user_new = new System.Windows.Forms.Button();
            this.textBox_passport_number = new System.Windows.Forms.MaskedTextBox();
            this.textBox_passport_series = new System.Windows.Forms.MaskedTextBox();
            this.textBox_birth_date = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_house = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.textBox_middle_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.date_conclusion = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.comboBox_post = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBox_admin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(279, 262);
            this.maskedTextBox1.Mask = "+7(000)-000-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(221, 26);
            this.maskedTextBox1.TabIndex = 11;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // comboBox_street
            // 
            this.comboBox_street.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_street.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_street.FormattingEnabled = true;
            this.comboBox_street.Location = new System.Drawing.Point(279, 89);
            this.comboBox_street.Name = "comboBox_street";
            this.comboBox_street.Size = new System.Drawing.Size(219, 26);
            this.comboBox_street.TabIndex = 8;
            this.comboBox_street.SelectedIndexChanged += new System.EventHandler(this.comboBox_street_SelectedIndexChanged);
            this.comboBox_street.Enter += new System.EventHandler(this.comboBox_street_Enter);
            // 
            // textBox_flat
            // 
            this.textBox_flat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_flat.Location = new System.Drawing.Point(281, 201);
            this.textBox_flat.Multiline = true;
            this.textBox_flat.Name = "textBox_flat";
            this.textBox_flat.Size = new System.Drawing.Size(221, 26);
            this.textBox_flat.TabIndex = 10;
            this.textBox_flat.TextChanged += new System.EventHandler(this.textBox_flat_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(277, 178);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 217;
            this.label9.Text = "Квартира";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(275, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 216;
            this.label8.Text = "Улица";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button_user_new
            // 
            this.button_user_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_user_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_user_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_user_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_user_new.Location = new System.Drawing.Point(189, 475);
            this.button_user_new.Name = "button_user_new";
            this.button_user_new.Size = new System.Drawing.Size(170, 34);
            this.button_user_new.TabIndex = 213;
            this.button_user_new.Text = "Добавить";
            this.button_user_new.UseVisualStyleBackColor = true;
            this.button_user_new.Click += new System.EventHandler(this.button_user_new_Click);
            // 
            // textBox_passport_number
            // 
            this.textBox_passport_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_passport_number.Location = new System.Drawing.Point(26, 201);
            this.textBox_passport_number.Mask = "000000";
            this.textBox_passport_number.Name = "textBox_passport_number";
            this.textBox_passport_number.Size = new System.Drawing.Size(221, 26);
            this.textBox_passport_number.TabIndex = 4;
            this.textBox_passport_number.ValidatingType = typeof(int);
            this.textBox_passport_number.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBox_passport_number_MaskInputRejected);
            // 
            // textBox_passport_series
            // 
            this.textBox_passport_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_passport_series.Location = new System.Drawing.Point(26, 255);
            this.textBox_passport_series.Mask = "0000";
            this.textBox_passport_series.Name = "textBox_passport_series";
            this.textBox_passport_series.Size = new System.Drawing.Size(221, 26);
            this.textBox_passport_series.TabIndex = 5;
            this.textBox_passport_series.ValidatingType = typeof(int);
            this.textBox_passport_series.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBox_passport_series_MaskInputRejected);
            // 
            // textBox_birth_date
            // 
            this.textBox_birth_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_birth_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textBox_birth_date.Location = new System.Drawing.Point(28, 316);
            this.textBox_birth_date.Name = "textBox_birth_date";
            this.textBox_birth_date.Size = new System.Drawing.Size(219, 26);
            this.textBox_birth_date.TabIndex = 6;
            this.textBox_birth_date.ValueChanged += new System.EventHandler(this.textBox_birth_date_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(275, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 20);
            this.label10.TabIndex = 208;
            this.label10.Text = "Населеный пункт";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(281, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 206;
            this.label11.Text = "Телефон";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // textBox_house
            // 
            this.textBox_house.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_house.Location = new System.Drawing.Point(279, 143);
            this.textBox_house.Multiline = true;
            this.textBox_house.Name = "textBox_house";
            this.textBox_house.Size = new System.Drawing.Size(221, 26);
            this.textBox_house.TabIndex = 9;
            this.textBox_house.TextChanged += new System.EventHandler(this.textBox_house_TextChanged);
            this.textBox_house.Leave += new System.EventHandler(this.textBox_house_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(275, 120);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 204;
            this.label12.Text = "Дом";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 203;
            this.label7.Text = "Отчество";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 202;
            this.label5.Text = "Серия паспорта";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(22, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 201;
            this.label6.Text = "Номер паспорта";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 200;
            this.label1.Text = "Дата рождения";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_last_name.Location = new System.Drawing.Point(26, 143);
            this.textBox_last_name.Multiline = true;
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(221, 26);
            this.textBox_last_name.TabIndex = 3;
            this.textBox_last_name.TextChanged += new System.EventHandler(this.textBox_last_name_TextChanged);
            // 
            // textBox_middle_name
            // 
            this.textBox_middle_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_middle_name.Location = new System.Drawing.Point(26, 89);
            this.textBox_middle_name.Multiline = true;
            this.textBox_middle_name.Name = "textBox_middle_name";
            this.textBox_middle_name.Size = new System.Drawing.Size(221, 26);
            this.textBox_middle_name.TabIndex = 2;
            this.textBox_middle_name.TextChanged += new System.EventHandler(this.textBox_middle_name_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 197;
            this.label4.Text = "Имя";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_first_name.Location = new System.Drawing.Point(26, 32);
            this.textBox_first_name.Multiline = true;
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(221, 26);
            this.textBox_first_name.TabIndex = 1;
            this.textBox_first_name.TextChanged += new System.EventHandler(this.textBox_first_name_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 195;
            this.label3.Text = "Фамилия";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comboBox_city
            // 
            this.comboBox_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.Location = new System.Drawing.Point(279, 32);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(219, 26);
            this.comboBox_city.TabIndex = 7;
            this.comboBox_city.SelectedIndexChanged += new System.EventHandler(this.comboBox_city_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(281, 293);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(244, 20);
            this.label13.TabIndex = 221;
            this.label13.Text = "Дата заключения договора";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // date_conclusion
            // 
            this.date_conclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_conclusion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_conclusion.Location = new System.Drawing.Point(279, 316);
            this.date_conclusion.Name = "date_conclusion";
            this.date_conclusion.Size = new System.Drawing.Size(219, 26);
            this.date_conclusion.TabIndex = 12;
            this.date_conclusion.ValueChanged += new System.EventHandler(this.date_conclusion_ValueChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(264, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 453);
            this.panel2.TabIndex = 247;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 249;
            this.label2.Text = "Логин";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(277, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 20);
            this.label14.TabIndex = 251;
            this.label14.Text = "Пароль";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(28, 378);
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(221, 26);
            this.textBox_login.TabIndex = 252;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(281, 378);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(221, 26);
            this.textBox_password.TabIndex = 253;
            // 
            // comboBox_post
            // 
            this.comboBox_post.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_post.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_post.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_post.FormattingEnabled = true;
            this.comboBox_post.Location = new System.Drawing.Point(28, 437);
            this.comboBox_post.Name = "comboBox_post";
            this.comboBox_post.Size = new System.Drawing.Size(219, 26);
            this.comboBox_post.TabIndex = 255;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(24, 414);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 20);
            this.label15.TabIndex = 256;
            this.label15.Text = "Должность";
            // 
            // checkBox_admin
            // 
            this.checkBox_admin.AutoSize = true;
            this.checkBox_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_admin.Location = new System.Drawing.Point(279, 414);
            this.checkBox_admin.Name = "checkBox_admin";
            this.checkBox_admin.Size = new System.Drawing.Size(148, 24);
            this.checkBox_admin.TabIndex = 257;
            this.checkBox_admin.Text = "администратор";
            this.checkBox_admin.UseVisualStyleBackColor = true;
            this.checkBox_admin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Form_employee_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 515);
            this.Controls.Add(this.checkBox_admin);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.comboBox_post);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.date_conclusion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox_street);
            this.Controls.Add(this.textBox_flat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_user_new);
            this.Controls.Add(this.textBox_passport_number);
            this.Controls.Add(this.textBox_passport_series);
            this.Controls.Add(this.textBox_birth_date);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox_house);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_last_name);
            this.Controls.Add(this.textBox_middle_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_city);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_employee_new";
            this.Text = "Сотрудники: добавить";
            this.Load += new System.EventHandler(this.Form_employee_new_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox_street;
        private System.Windows.Forms.TextBox textBox_flat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_user_new;
        private System.Windows.Forms.MaskedTextBox textBox_passport_number;
        private System.Windows.Forms.MaskedTextBox textBox_passport_series;
        private System.Windows.Forms.DateTimePicker textBox_birth_date;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_house;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.TextBox textBox_middle_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_city;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker date_conclusion;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.ComboBox comboBox_post;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBox_admin;
    }
}