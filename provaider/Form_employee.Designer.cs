namespace provaider
{
    partial class Form_employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_employee));
            this.dataGridView_employee = new System.Windows.Forms.DataGridView();
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
            this.ss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_employee_delete = new System.Windows.Forms.Button();
            this.button_employee_edit = new System.Windows.Forms.Button();
            this.button_employee_new = new System.Windows.Forms.Button();
            this.comboBox_last_name = new System.Windows.Forms.ComboBox();
            this.button_user_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox_post = new System.Windows.Forms.CheckBox();
            this.comboBox_post = new System.Windows.Forms.ComboBox();
            this.textBox_flat = new System.Windows.Forms.TextBox();
            this.textBox_house = new System.Windows.Forms.TextBox();
            this.date_conclusions = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox_telephone = new System.Windows.Forms.MaskedTextBox();
            this.checkBox_date_conclusion = new System.Windows.Forms.CheckBox();
            this.textBox_passport_number = new System.Windows.Forms.MaskedTextBox();
            this.checkBox_telephone = new System.Windows.Forms.CheckBox();
            this.textBox_passport_series = new System.Windows.Forms.MaskedTextBox();
            this.checkBox_passport_number = new System.Windows.Forms.CheckBox();
            this.checkBox_passport_series = new System.Windows.Forms.CheckBox();
            this.comboBox_street = new System.Windows.Forms.ComboBox();
            this.checkBox_house = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.checkBox_flat = new System.Windows.Forms.CheckBox();
            this.checkBox_street = new System.Windows.Forms.CheckBox();
            this.checkBox_city = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_employee
            // 
            this.dataGridView_employee.AllowUserToAddRows = false;
            this.dataGridView_employee.AllowUserToDeleteRows = false;
            this.dataGridView_employee.AllowUserToOrderColumns = true;
            this.dataGridView_employee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_employee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_employee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_employee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.last_name,
            this.first_name,
            this.patronymic,
            this.telephone,
            this.adress,
            this.date_birth,
            this.passport_series,
            this.passport_number,
            this.date_conclusion,
            this.ss,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView_employee.Location = new System.Drawing.Point(12, 128);
            this.dataGridView_employee.Name = "dataGridView_employee";
            this.dataGridView_employee.Size = new System.Drawing.Size(1330, 188);
            this.dataGridView_employee.TabIndex = 27;
            this.dataGridView_employee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_employee_CellContentClick);
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
            // ss
            // 
            this.ss.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ss.HeaderText = "Должность";
            this.ss.Name = "ss";
            this.ss.Width = 90;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Логин";
            this.Column1.Name = "Column1";
            this.Column1.Width = 63;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Пароль";
            this.Column2.Name = "Column2";
            this.Column2.Width = 70;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Администратор";
            this.Column3.Name = "Column3";
            this.Column3.Width = 92;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "id_post";
            this.Column4.Name = "Column4";
            this.Column4.Visible = false;
            // 
            // button_employee_delete
            // 
            this.button_employee_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_employee_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_employee_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_employee_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_employee_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_employee_delete.Location = new System.Drawing.Point(779, 322);
            this.button_employee_delete.Name = "button_employee_delete";
            this.button_employee_delete.Size = new System.Drawing.Size(165, 39);
            this.button_employee_delete.TabIndex = 30;
            this.button_employee_delete.Text = "Удалить";
            this.button_employee_delete.UseVisualStyleBackColor = true;
            this.button_employee_delete.Click += new System.EventHandler(this.button_employee_delete_Click);
            // 
            // button_employee_edit
            // 
            this.button_employee_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_employee_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_employee_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_employee_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_employee_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_employee_edit.Location = new System.Drawing.Point(593, 322);
            this.button_employee_edit.Name = "button_employee_edit";
            this.button_employee_edit.Size = new System.Drawing.Size(165, 39);
            this.button_employee_edit.TabIndex = 29;
            this.button_employee_edit.Text = "Изменить";
            this.button_employee_edit.UseVisualStyleBackColor = true;
            this.button_employee_edit.Click += new System.EventHandler(this.button_employee_edit_Click);
            // 
            // button_employee_new
            // 
            this.button_employee_new.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_employee_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_employee_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_employee_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_employee_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_employee_new.Location = new System.Drawing.Point(407, 322);
            this.button_employee_new.Name = "button_employee_new";
            this.button_employee_new.Size = new System.Drawing.Size(165, 39);
            this.button_employee_new.TabIndex = 28;
            this.button_employee_new.Text = "Добавить";
            this.button_employee_new.UseVisualStyleBackColor = true;
            this.button_employee_new.Click += new System.EventHandler(this.button_employee_new_Click);
            // 
            // comboBox_last_name
            // 
            this.comboBox_last_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_last_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_last_name.FormattingEnabled = true;
            this.comboBox_last_name.Location = new System.Drawing.Point(15, 33);
            this.comboBox_last_name.Name = "comboBox_last_name";
            this.comboBox_last_name.Size = new System.Drawing.Size(143, 26);
            this.comboBox_last_name.TabIndex = 232;
            this.comboBox_last_name.SelectedIndexChanged += new System.EventHandler(this.comboBox_last_name_SelectedIndexChanged);
            // 
            // button_user_search
            // 
            this.button_user_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_user_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_user_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_user_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_user_search.Location = new System.Drawing.Point(167, 33);
            this.button_user_search.Name = "button_user_search";
            this.button_user_search.Size = new System.Drawing.Size(83, 26);
            this.button_user_search.TabIndex = 231;
            this.button_user_search.Text = "Поиск";
            this.button_user_search.UseVisualStyleBackColor = true;
            this.button_user_search.Click += new System.EventHandler(this.button_user_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 230;
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
            this.panel1.Controls.Add(this.checkBox_post);
            this.panel1.Controls.Add(this.comboBox_post);
            this.panel1.Controls.Add(this.textBox_flat);
            this.panel1.Controls.Add(this.textBox_house);
            this.panel1.Controls.Add(this.date_conclusions);
            this.panel1.Controls.Add(this.maskedTextBox_telephone);
            this.panel1.Controls.Add(this.checkBox_date_conclusion);
            this.panel1.Controls.Add(this.textBox_passport_number);
            this.panel1.Controls.Add(this.checkBox_telephone);
            this.panel1.Controls.Add(this.textBox_passport_series);
            this.panel1.Controls.Add(this.checkBox_passport_number);
            this.panel1.Controls.Add(this.checkBox_passport_series);
            this.panel1.Controls.Add(this.comboBox_street);
            this.panel1.Controls.Add(this.checkBox_house);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.comboBox_city);
            this.panel1.Controls.Add(this.checkBox_flat);
            this.panel1.Controls.Add(this.checkBox_street);
            this.panel1.Controls.Add(this.checkBox_city);
            this.panel1.Location = new System.Drawing.Point(283, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1057, 118);
            this.panel1.TabIndex = 229;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // checkBox_post
            // 
            this.checkBox_post.AutoSize = true;
            this.checkBox_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_post.Location = new System.Drawing.Point(710, 60);
            this.checkBox_post.Name = "checkBox_post";
            this.checkBox_post.Size = new System.Drawing.Size(100, 21);
            this.checkBox_post.TabIndex = 258;
            this.checkBox_post.Text = "Должность";
            this.checkBox_post.UseVisualStyleBackColor = true;
            // 
            // comboBox_post
            // 
            this.comboBox_post.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_post.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_post.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_post.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_post.FormattingEnabled = true;
            this.comboBox_post.Location = new System.Drawing.Point(710, 83);
            this.comboBox_post.Name = "comboBox_post";
            this.comboBox_post.Size = new System.Drawing.Size(159, 26);
            this.comboBox_post.TabIndex = 257;
            // 
            // textBox_flat
            // 
            this.textBox_flat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_flat.Location = new System.Drawing.Point(538, 23);
            this.textBox_flat.Name = "textBox_flat";
            this.textBox_flat.Size = new System.Drawing.Size(126, 24);
            this.textBox_flat.TabIndex = 229;
            this.textBox_flat.TextChanged += new System.EventHandler(this.textBox_flat_TextChanged);
            // 
            // textBox_house
            // 
            this.textBox_house.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_house.Location = new System.Drawing.Point(419, 23);
            this.textBox_house.Name = "textBox_house";
            this.textBox_house.Size = new System.Drawing.Size(96, 24);
            this.textBox_house.TabIndex = 228;
            this.textBox_house.TextChanged += new System.EventHandler(this.textBox_house_TextChanged);
            // 
            // date_conclusions
            // 
            this.date_conclusions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_conclusions.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_conclusions.Location = new System.Drawing.Point(417, 81);
            this.date_conclusions.Name = "date_conclusions";
            this.date_conclusions.Size = new System.Drawing.Size(247, 24);
            this.date_conclusions.TabIndex = 227;
            this.date_conclusions.ValueChanged += new System.EventHandler(this.date_conclusions_ValueChanged);
            // 
            // maskedTextBox_telephone
            // 
            this.maskedTextBox_telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_telephone.Location = new System.Drawing.Point(710, 23);
            this.maskedTextBox_telephone.Mask = "+7(000)-000-00-00";
            this.maskedTextBox_telephone.Name = "maskedTextBox_telephone";
            this.maskedTextBox_telephone.Size = new System.Drawing.Size(159, 24);
            this.maskedTextBox_telephone.TabIndex = 226;
            this.maskedTextBox_telephone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_telephone_MaskInputRejected);
            // 
            // checkBox_date_conclusion
            // 
            this.checkBox_date_conclusion.AutoSize = true;
            this.checkBox_date_conclusion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_date_conclusion.Location = new System.Drawing.Point(418, 60);
            this.checkBox_date_conclusion.Name = "checkBox_date_conclusion";
            this.checkBox_date_conclusion.Size = new System.Drawing.Size(209, 21);
            this.checkBox_date_conclusion.TabIndex = 55;
            this.checkBox_date_conclusion.Text = "Дата заключения договора";
            this.checkBox_date_conclusion.UseVisualStyleBackColor = true;
            this.checkBox_date_conclusion.CheckedChanged += new System.EventHandler(this.checkBox_date_conclusion_CheckedChanged);
            // 
            // textBox_passport_number
            // 
            this.textBox_passport_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_passport_number.Location = new System.Drawing.Point(214, 82);
            this.textBox_passport_number.Mask = "000000";
            this.textBox_passport_number.Name = "textBox_passport_number";
            this.textBox_passport_number.Size = new System.Drawing.Size(187, 24);
            this.textBox_passport_number.TabIndex = 225;
            this.textBox_passport_number.ValidatingType = typeof(int);
            this.textBox_passport_number.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBox_passport_number_MaskInputRejected);
            // 
            // checkBox_telephone
            // 
            this.checkBox_telephone.AutoSize = true;
            this.checkBox_telephone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_telephone.Location = new System.Drawing.Point(710, 4);
            this.checkBox_telephone.Name = "checkBox_telephone";
            this.checkBox_telephone.Size = new System.Drawing.Size(87, 21);
            this.checkBox_telephone.TabIndex = 51;
            this.checkBox_telephone.Text = "Телефон";
            this.checkBox_telephone.UseVisualStyleBackColor = true;
            this.checkBox_telephone.CheckedChanged += new System.EventHandler(this.checkBox_telephone_CheckedChanged);
            // 
            // textBox_passport_series
            // 
            this.textBox_passport_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_passport_series.Location = new System.Drawing.Point(8, 82);
            this.textBox_passport_series.Mask = "0000";
            this.textBox_passport_series.Name = "textBox_passport_series";
            this.textBox_passport_series.Size = new System.Drawing.Size(178, 24);
            this.textBox_passport_series.TabIndex = 224;
            this.textBox_passport_series.ValidatingType = typeof(int);
            this.textBox_passport_series.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textBox_passport_series_MaskInputRejected);
            // 
            // checkBox_passport_number
            // 
            this.checkBox_passport_number.AutoSize = true;
            this.checkBox_passport_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_passport_number.Location = new System.Drawing.Point(214, 62);
            this.checkBox_passport_number.Name = "checkBox_passport_number";
            this.checkBox_passport_number.Size = new System.Drawing.Size(136, 21);
            this.checkBox_passport_number.TabIndex = 49;
            this.checkBox_passport_number.Text = "Номер паспорта";
            this.checkBox_passport_number.UseVisualStyleBackColor = true;
            this.checkBox_passport_number.CheckedChanged += new System.EventHandler(this.checkBox_passport_number_CheckedChanged);
            // 
            // checkBox_passport_series
            // 
            this.checkBox_passport_series.AutoSize = true;
            this.checkBox_passport_series.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_passport_series.Location = new System.Drawing.Point(8, 63);
            this.checkBox_passport_series.Name = "checkBox_passport_series";
            this.checkBox_passport_series.Size = new System.Drawing.Size(134, 21);
            this.checkBox_passport_series.TabIndex = 48;
            this.checkBox_passport_series.Text = "Серия паспорта";
            this.checkBox_passport_series.UseVisualStyleBackColor = true;
            this.checkBox_passport_series.CheckedChanged += new System.EventHandler(this.checkBox_passport_series_CheckedChanged);
            // 
            // comboBox_street
            // 
            this.comboBox_street.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_street.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_street.FormattingEnabled = true;
            this.comboBox_street.Location = new System.Drawing.Point(214, 22);
            this.comboBox_street.Name = "comboBox_street";
            this.comboBox_street.Size = new System.Drawing.Size(187, 24);
            this.comboBox_street.TabIndex = 45;
            this.comboBox_street.SelectedIndexChanged += new System.EventHandler(this.comboBox_street_SelectedIndexChanged);
            // 
            // checkBox_house
            // 
            this.checkBox_house.AutoSize = true;
            this.checkBox_house.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_house.Location = new System.Drawing.Point(419, 6);
            this.checkBox_house.Name = "checkBox_house";
            this.checkBox_house.Size = new System.Drawing.Size(90, 21);
            this.checkBox_house.TabIndex = 40;
            this.checkBox_house.Text = "Квартира";
            this.checkBox_house.UseVisualStyleBackColor = true;
            this.checkBox_house.CheckedChanged += new System.EventHandler(this.checkBox_house_CheckedChanged);
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(907, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(153, 30);
            this.button3.TabIndex = 39;
            this.button3.Text = "Применить фильтр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox_city
            // 
            this.comboBox_city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_city.FormattingEnabled = true;
            this.comboBox_city.Location = new System.Drawing.Point(8, 22);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(178, 24);
            this.comboBox_city.TabIndex = 36;
            this.comboBox_city.SelectedIndexChanged += new System.EventHandler(this.comboBox_city_SelectedIndexChanged);
            this.comboBox_city.Leave += new System.EventHandler(this.comboBox_city_Leave);
            // 
            // checkBox_flat
            // 
            this.checkBox_flat.AutoSize = true;
            this.checkBox_flat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_flat.Location = new System.Drawing.Point(538, 4);
            this.checkBox_flat.Name = "checkBox_flat";
            this.checkBox_flat.Size = new System.Drawing.Size(55, 21);
            this.checkBox_flat.TabIndex = 30;
            this.checkBox_flat.Text = "Дом";
            this.checkBox_flat.UseVisualStyleBackColor = true;
            this.checkBox_flat.CheckedChanged += new System.EventHandler(this.checkBox_flat_CheckedChanged);
            // 
            // checkBox_street
            // 
            this.checkBox_street.AutoSize = true;
            this.checkBox_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_street.Location = new System.Drawing.Point(214, 3);
            this.checkBox_street.Name = "checkBox_street";
            this.checkBox_street.Size = new System.Drawing.Size(68, 21);
            this.checkBox_street.TabIndex = 32;
            this.checkBox_street.Text = "Улица";
            this.checkBox_street.UseVisualStyleBackColor = true;
            this.checkBox_street.CheckedChanged += new System.EventHandler(this.checkBox_street_CheckedChanged);
            // 
            // checkBox_city
            // 
            this.checkBox_city.AutoSize = true;
            this.checkBox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_city.Location = new System.Drawing.Point(8, 4);
            this.checkBox_city.Name = "checkBox_city";
            this.checkBox_city.Size = new System.Drawing.Size(67, 21);
            this.checkBox_city.TabIndex = 28;
            this.checkBox_city.Text = "Город";
            this.checkBox_city.UseVisualStyleBackColor = true;
            this.checkBox_city.CheckedChanged += new System.EventHandler(this.checkBox_city_CheckedChanged);
            // 
            // Form_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 373);
            this.Controls.Add(this.comboBox_last_name);
            this.Controls.Add(this.button_user_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView_employee);
            this.Controls.Add(this.button_employee_delete);
            this.Controls.Add(this.button_employee_edit);
            this.Controls.Add(this.button_employee_new);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_employee";
            this.Text = "Сотрудники";
            this.Activated += new System.EventHandler(this.Form_employee_Activated);
            this.Load += new System.EventHandler(this.Form_employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_employee;
        private System.Windows.Forms.Button button_employee_delete;
        private System.Windows.Forms.Button button_employee_edit;
        private System.Windows.Forms.Button button_employee_new;
        private System.Windows.Forms.ComboBox comboBox_last_name;
        private System.Windows.Forms.Button button_user_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_flat;
        private System.Windows.Forms.TextBox textBox_house;
        private System.Windows.Forms.DateTimePicker date_conclusions;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telephone;
        private System.Windows.Forms.CheckBox checkBox_date_conclusion;
        private System.Windows.Forms.MaskedTextBox textBox_passport_number;
        private System.Windows.Forms.CheckBox checkBox_telephone;
        private System.Windows.Forms.MaskedTextBox textBox_passport_series;
        private System.Windows.Forms.CheckBox checkBox_passport_number;
        private System.Windows.Forms.CheckBox checkBox_passport_series;
        private System.Windows.Forms.ComboBox comboBox_street;
        private System.Windows.Forms.CheckBox checkBox_house;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox_city;
        private System.Windows.Forms.CheckBox checkBox_flat;
        private System.Windows.Forms.CheckBox checkBox_street;
        private System.Windows.Forms.CheckBox checkBox_city;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ss;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.CheckBox checkBox_post;
        private System.Windows.Forms.ComboBox comboBox_post;
    }
}