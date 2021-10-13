namespace provaider
{
    partial class Form_employee_edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_employee_edit));
            this.date_conclusion = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_street = new System.Windows.Forms.ComboBox();
            this.textBox_flat = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_contract_print = new System.Windows.Forms.Button();
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
            this.textBox_patronymic = new System.Windows.Forms.TextBox();
            this.textBox_first_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_last_name = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // date_conclusion
            // 
            this.date_conclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_conclusion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_conclusion.Location = new System.Drawing.Point(276, 319);
            this.date_conclusion.Name = "date_conclusion";
            this.date_conclusion.Size = new System.Drawing.Size(219, 26);
            this.date_conclusion.TabIndex = 233;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(278, 296);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(244, 20);
            this.label13.TabIndex = 249;
            this.label13.Text = "Дата заключения договора";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox1.Location = new System.Drawing.Point(276, 265);
            this.maskedTextBox1.Mask = "+7(000)-00-00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(221, 26);
            this.maskedTextBox1.TabIndex = 232;
            // 
            // comboBox_street
            // 
            this.comboBox_street.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_street.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_street.FormattingEnabled = true;
            this.comboBox_street.Location = new System.Drawing.Point(276, 92);
            this.comboBox_street.Name = "comboBox_street";
            this.comboBox_street.Size = new System.Drawing.Size(219, 26);
            this.comboBox_street.TabIndex = 229;
            // 
            // textBox_flat
            // 
            this.textBox_flat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_flat.Location = new System.Drawing.Point(278, 204);
            this.textBox_flat.Multiline = true;
            this.textBox_flat.Name = "textBox_flat";
            this.textBox_flat.Size = new System.Drawing.Size(221, 26);
            this.textBox_flat.TabIndex = 231;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(274, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 248;
            this.label9.Text = "Квартира";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(272, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 20);
            this.label8.TabIndex = 247;
            this.label8.Text = "Улица";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(260, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 335);
            this.panel1.TabIndex = 246;
            // 
            // button_contract_print
            // 
            this.button_contract_print.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_contract_print.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_contract_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_contract_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_contract_print.Location = new System.Drawing.Point(8, 363);
            this.button_contract_print.Name = "button_contract_print";
            this.button_contract_print.Size = new System.Drawing.Size(170, 34);
            this.button_contract_print.TabIndex = 245;
            this.button_contract_print.Text = " Печать";
            this.button_contract_print.UseVisualStyleBackColor = true;
            this.button_contract_print.Visible = false;
            // 
            // button_user_new
            // 
            this.button_user_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_user_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_user_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_user_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_user_new.Location = new System.Drawing.Point(178, 364);
            this.button_user_new.Name = "button_user_new";
            this.button_user_new.Size = new System.Drawing.Size(170, 34);
            this.button_user_new.TabIndex = 244;
            this.button_user_new.Text = "Изменить";
            this.button_user_new.UseVisualStyleBackColor = true;
            this.button_user_new.Click += new System.EventHandler(this.button_user_new_Click);
            // 
            // textBox_passport_number
            // 
            this.textBox_passport_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_passport_number.Location = new System.Drawing.Point(23, 204);
            this.textBox_passport_number.Mask = "000000";
            this.textBox_passport_number.Name = "textBox_passport_number";
            this.textBox_passport_number.Size = new System.Drawing.Size(221, 26);
            this.textBox_passport_number.TabIndex = 225;
            this.textBox_passport_number.ValidatingType = typeof(int);
            // 
            // textBox_passport_series
            // 
            this.textBox_passport_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_passport_series.Location = new System.Drawing.Point(23, 258);
            this.textBox_passport_series.Mask = "0000";
            this.textBox_passport_series.Name = "textBox_passport_series";
            this.textBox_passport_series.Size = new System.Drawing.Size(221, 26);
            this.textBox_passport_series.TabIndex = 226;
            this.textBox_passport_series.ValidatingType = typeof(int);
            // 
            // textBox_birth_date
            // 
            this.textBox_birth_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_birth_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.textBox_birth_date.Location = new System.Drawing.Point(25, 319);
            this.textBox_birth_date.Name = "textBox_birth_date";
            this.textBox_birth_date.Size = new System.Drawing.Size(219, 26);
            this.textBox_birth_date.TabIndex = 227;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(272, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 20);
            this.label10.TabIndex = 242;
            this.label10.Text = "Город";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(278, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 20);
            this.label11.TabIndex = 241;
            this.label11.Text = "Телефон";
            // 
            // textBox_house
            // 
            this.textBox_house.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_house.Location = new System.Drawing.Point(276, 146);
            this.textBox_house.Multiline = true;
            this.textBox_house.Name = "textBox_house";
            this.textBox_house.Size = new System.Drawing.Size(221, 26);
            this.textBox_house.TabIndex = 230;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(272, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 20);
            this.label12.TabIndex = 240;
            this.label12.Text = "Дом";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 239;
            this.label7.Text = "Отчество";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 20);
            this.label5.TabIndex = 238;
            this.label5.Text = "Серия паспорта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 237;
            this.label6.Text = "Номер паспорта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 20);
            this.label1.TabIndex = 236;
            this.label1.Text = "Дата рождения";
            // 
            // textBox_patronymic
            // 
            this.textBox_patronymic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_patronymic.Location = new System.Drawing.Point(23, 146);
            this.textBox_patronymic.Multiline = true;
            this.textBox_patronymic.Name = "textBox_patronymic";
            this.textBox_patronymic.Size = new System.Drawing.Size(221, 26);
            this.textBox_patronymic.TabIndex = 224;
            // 
            // textBox_first_name
            // 
            this.textBox_first_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_first_name.Location = new System.Drawing.Point(23, 92);
            this.textBox_first_name.Multiline = true;
            this.textBox_first_name.Name = "textBox_first_name";
            this.textBox_first_name.Size = new System.Drawing.Size(221, 26);
            this.textBox_first_name.TabIndex = 223;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 235;
            this.label4.Text = "Имя";
            // 
            // textBox_last_name
            // 
            this.textBox_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_last_name.Location = new System.Drawing.Point(23, 35);
            this.textBox_last_name.Multiline = true;
            this.textBox_last_name.Name = "textBox_last_name";
            this.textBox_last_name.Size = new System.Drawing.Size(221, 26);
            this.textBox_last_name.TabIndex = 222;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 234;
            this.label3.Text = "Фамилия";
            // 
            // comboBox_city
            // 
            this.comboBox_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.Location = new System.Drawing.Point(276, 35);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(219, 26);
            this.comboBox_city.TabIndex = 228;
            this.comboBox_city.Leave += new System.EventHandler(this.comboBox_city_Leave);
            // 
            // Form_employee_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 405);
            this.Controls.Add(this.date_conclusion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.comboBox_street);
            this.Controls.Add(this.textBox_flat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_contract_print);
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
            this.Controls.Add(this.textBox_patronymic);
            this.Controls.Add(this.textBox_first_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_last_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_city);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_employee_edit";
            this.Text = "Сотрудники: изменить";
            this.Load += new System.EventHandler(this.Form_employee_edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date_conclusion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.ComboBox comboBox_street;
        private System.Windows.Forms.TextBox textBox_flat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_contract_print;
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
        private System.Windows.Forms.TextBox textBox_patronymic;
        private System.Windows.Forms.TextBox textBox_first_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_last_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_city;
    }
}