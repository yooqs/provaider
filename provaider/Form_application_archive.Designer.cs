namespace provaider
{
    partial class Form_application_archive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_application_archive));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_conclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox_last_name = new System.Windows.Forms.ComboBox();
            this.button_user_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_employee = new System.Windows.Forms.ComboBox();
            this.checkBox_employee = new System.Windows.Forms.CheckBox();
            this.comboBox_customer = new System.Windows.Forms.ComboBox();
            this.checkBox_customer = new System.Windows.Forms.CheckBox();
            this.comboBox_status = new System.Windows.Forms.ComboBox();
            this.checkBox_status = new System.Windows.Forms.CheckBox();
            this.comboBox_type = new System.Windows.Forms.ComboBox();
            this.checkBox_type = new System.Windows.Forms.CheckBox();
            this.date_conclusion_to = new System.Windows.Forms.DateTimePicker();
            this.checkBox_date_conclusion_to = new System.Windows.Forms.CheckBox();
            this.date_conclusion_from = new System.Windows.Forms.DateTimePicker();
            this.checkBox_date_conclusion_from = new System.Windows.Forms.CheckBox();
            this.date_receipt_to = new System.Windows.Forms.DateTimePicker();
            this.checkBox_date_receipt_to = new System.Windows.Forms.CheckBox();
            this.textBox_flat = new System.Windows.Forms.TextBox();
            this.textBox_house = new System.Windows.Forms.TextBox();
            this._date_receipt_from = new System.Windows.Forms.DateTimePicker();
            this.checkBox_date_receipt_from = new System.Windows.Forms.CheckBox();
            this.comboBox_street = new System.Windows.Forms.ComboBox();
            this.checkBox_house = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox_city = new System.Windows.Forms.ComboBox();
            this.checkBox_flat = new System.Windows.Forms.CheckBox();
            this.checkBox_street = new System.Windows.Forms.CheckBox();
            this.checkBox_city = new System.Windows.Forms.CheckBox();
            this.button_customers_new = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.adress,
            this.date_birth,
            this.passport_series,
            this.passport_number,
            this.date_conclusion,
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 198);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1326, 236);
            this.dataGridView1.TabIndex = 33;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.FillWeight = 253.8071F;
            this.id.HeaderText = "№ заяки";
            this.id.Name = "id";
            this.id.Width = 70;
            // 
            // last_name
            // 
            this.last_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.last_name.FillWeight = 82.91032F;
            this.last_name.HeaderText = "Клиент";
            this.last_name.Name = "last_name";
            this.last_name.Width = 68;
            // 
            // first_name
            // 
            this.first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.first_name.FillWeight = 82.91032F;
            this.first_name.HeaderText = "Телефон";
            this.first_name.Name = "first_name";
            this.first_name.Visible = false;
            // 
            // adress
            // 
            this.adress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adress.FillWeight = 82.91032F;
            this.adress.HeaderText = "Адрес";
            this.adress.Name = "adress";
            // 
            // date_birth
            // 
            this.date_birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date_birth.FillWeight = 82.91032F;
            this.date_birth.HeaderText = "Тип услуги";
            this.date_birth.Name = "date_birth";
            this.date_birth.Width = 80;
            // 
            // passport_series
            // 
            this.passport_series.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.passport_series.FillWeight = 82.91032F;
            this.passport_series.HeaderText = "Описание";
            this.passport_series.Name = "passport_series";
            this.passport_series.Width = 82;
            // 
            // passport_number
            // 
            this.passport_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.passport_number.FillWeight = 82.91032F;
            this.passport_number.HeaderText = "Техник";
            this.passport_number.Name = "passport_number";
            this.passport_number.Width = 68;
            // 
            // date_conclusion
            // 
            this.date_conclusion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date_conclusion.FillWeight = 82.91032F;
            this.date_conclusion.HeaderText = "Время получения заявки";
            this.date_conclusion.Name = "date_conclusion";
            this.date_conclusion.Width = 113;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.FillWeight = 82.91032F;
            this.Column1.HeaderText = "Время выполнения заявки";
            this.Column1.Name = "Column1";
            this.Column1.Width = 122;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Статус";
            this.Column2.Name = "Column2";
            this.Column2.Width = 66;
            // 
            // comboBox_last_name
            // 
            this.comboBox_last_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_last_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_last_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_last_name.FormattingEnabled = true;
            this.comboBox_last_name.Location = new System.Drawing.Point(26, 40);
            this.comboBox_last_name.Name = "comboBox_last_name";
            this.comboBox_last_name.Size = new System.Drawing.Size(274, 26);
            this.comboBox_last_name.TabIndex = 229;
            // 
            // button_user_search
            // 
            this.button_user_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_user_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_user_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_user_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_user_search.Location = new System.Drawing.Point(315, 40);
            this.button_user_search.Name = "button_user_search";
            this.button_user_search.Size = new System.Drawing.Size(115, 26);
            this.button_user_search.TabIndex = 227;
            this.button_user_search.Text = "Поиск";
            this.button_user_search.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 226;
            this.label1.Text = "Поиск по фамилии";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBox_employee);
            this.panel1.Controls.Add(this.checkBox_employee);
            this.panel1.Controls.Add(this.comboBox_customer);
            this.panel1.Controls.Add(this.checkBox_customer);
            this.panel1.Controls.Add(this.comboBox_status);
            this.panel1.Controls.Add(this.checkBox_status);
            this.panel1.Controls.Add(this.comboBox_type);
            this.panel1.Controls.Add(this.checkBox_type);
            this.panel1.Controls.Add(this.date_conclusion_to);
            this.panel1.Controls.Add(this.checkBox_date_conclusion_to);
            this.panel1.Controls.Add(this.date_conclusion_from);
            this.panel1.Controls.Add(this.checkBox_date_conclusion_from);
            this.panel1.Controls.Add(this.date_receipt_to);
            this.panel1.Controls.Add(this.checkBox_date_receipt_to);
            this.panel1.Controls.Add(this.textBox_flat);
            this.panel1.Controls.Add(this.textBox_house);
            this.panel1.Controls.Add(this._date_receipt_from);
            this.panel1.Controls.Add(this.checkBox_date_receipt_from);
            this.panel1.Controls.Add(this.comboBox_street);
            this.panel1.Controls.Add(this.checkBox_house);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.comboBox_city);
            this.panel1.Controls.Add(this.checkBox_flat);
            this.panel1.Controls.Add(this.checkBox_street);
            this.panel1.Controls.Add(this.checkBox_city);
            this.panel1.Location = new System.Drawing.Point(463, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(875, 173);
            this.panel1.TabIndex = 228;
            // 
            // comboBox_employee
            // 
            this.comboBox_employee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_employee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_employee.FormattingEnabled = true;
            this.comboBox_employee.Location = new System.Drawing.Point(347, 137);
            this.comboBox_employee.Name = "comboBox_employee";
            this.comboBox_employee.Size = new System.Drawing.Size(284, 24);
            this.comboBox_employee.TabIndex = 243;
            // 
            // checkBox_employee
            // 
            this.checkBox_employee.AutoSize = true;
            this.checkBox_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_employee.Location = new System.Drawing.Point(347, 119);
            this.checkBox_employee.Name = "checkBox_employee";
            this.checkBox_employee.Size = new System.Drawing.Size(73, 21);
            this.checkBox_employee.TabIndex = 242;
            this.checkBox_employee.Text = "Техник";
            this.checkBox_employee.UseVisualStyleBackColor = true;
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Location = new System.Drawing.Point(8, 137);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(293, 24);
            this.comboBox_customer.TabIndex = 241;
            // 
            // checkBox_customer
            // 
            this.checkBox_customer.AutoSize = true;
            this.checkBox_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_customer.Location = new System.Drawing.Point(7, 119);
            this.checkBox_customer.Name = "checkBox_customer";
            this.checkBox_customer.Size = new System.Drawing.Size(75, 21);
            this.checkBox_customer.TabIndex = 240;
            this.checkBox_customer.Text = "Клиент";
            this.checkBox_customer.UseVisualStyleBackColor = true;
            // 
            // comboBox_status
            // 
            this.comboBox_status.AllowDrop = true;
            this.comboBox_status.AutoCompleteCustomSource.AddRange(new string[] {
            "Выполнена",
            "Отменена"});
            this.comboBox_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_status.FormattingEnabled = true;
            this.comboBox_status.Items.AddRange(new object[] {
            "Выполнена",
            "Отменена"});
            this.comboBox_status.Location = new System.Drawing.Point(748, 21);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(117, 24);
            this.comboBox_status.TabIndex = 239;
            this.comboBox_status.Tag = "";
            // 
            // checkBox_status
            // 
            this.checkBox_status.AutoSize = true;
            this.checkBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_status.Location = new System.Drawing.Point(748, 2);
            this.checkBox_status.Name = "checkBox_status";
            this.checkBox_status.Size = new System.Drawing.Size(121, 21);
            this.checkBox_status.TabIndex = 238;
            this.checkBox_status.Text = "Статус заявки";
            this.checkBox_status.UseVisualStyleBackColor = true;
            this.checkBox_status.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // comboBox_type
            // 
            this.comboBox_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(620, 22);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(117, 24);
            this.comboBox_type.TabIndex = 237;
            // 
            // checkBox_type
            // 
            this.checkBox_type.AutoSize = true;
            this.checkBox_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_type.Location = new System.Drawing.Point(620, 3);
            this.checkBox_type.Name = "checkBox_type";
            this.checkBox_type.Size = new System.Drawing.Size(105, 21);
            this.checkBox_type.TabIndex = 236;
            this.checkBox_type.Text = "Вид работы";
            this.checkBox_type.UseVisualStyleBackColor = true;
            // 
            // date_conclusion_to
            // 
            this.date_conclusion_to.CustomFormat = "d.MM.yyyy HH:mm";
            this.date_conclusion_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_conclusion_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_conclusion_to.Location = new System.Drawing.Point(652, 80);
            this.date_conclusion_to.Name = "date_conclusion_to";
            this.date_conclusion_to.Size = new System.Drawing.Size(213, 24);
            this.date_conclusion_to.TabIndex = 235;
            // 
            // checkBox_date_conclusion_to
            // 
            this.checkBox_date_conclusion_to.AutoSize = true;
            this.checkBox_date_conclusion_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_date_conclusion_to.Location = new System.Drawing.Point(653, 59);
            this.checkBox_date_conclusion_to.Name = "checkBox_date_conclusion_to";
            this.checkBox_date_conclusion_to.Size = new System.Drawing.Size(215, 21);
            this.checkBox_date_conclusion_to.TabIndex = 234;
            this.checkBox_date_conclusion_to.Text = "Дата выполнения заказа по";
            this.checkBox_date_conclusion_to.UseVisualStyleBackColor = true;
            // 
            // date_conclusion_from
            // 
            this.date_conclusion_from.CustomFormat = "d.MM.yyyy HH:mm";
            this.date_conclusion_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_conclusion_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_conclusion_from.Location = new System.Drawing.Point(440, 80);
            this.date_conclusion_from.Name = "date_conclusion_from";
            this.date_conclusion_from.Size = new System.Drawing.Size(202, 24);
            this.date_conclusion_from.TabIndex = 233;
            // 
            // checkBox_date_conclusion_from
            // 
            this.checkBox_date_conclusion_from.AutoSize = true;
            this.checkBox_date_conclusion_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_date_conclusion_from.Location = new System.Drawing.Point(441, 59);
            this.checkBox_date_conclusion_from.Name = "checkBox_date_conclusion_from";
            this.checkBox_date_conclusion_from.Size = new System.Drawing.Size(206, 21);
            this.checkBox_date_conclusion_from.TabIndex = 232;
            this.checkBox_date_conclusion_from.Text = "Дата выполнения заказа с";
            this.checkBox_date_conclusion_from.UseVisualStyleBackColor = true;
            // 
            // date_receipt_to
            // 
            this.date_receipt_to.CustomFormat = "d.MM.yyyy HH:mm";
            this.date_receipt_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_receipt_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_receipt_to.Location = new System.Drawing.Point(217, 80);
            this.date_receipt_to.Name = "date_receipt_to";
            this.date_receipt_to.Size = new System.Drawing.Size(213, 24);
            this.date_receipt_to.TabIndex = 231;
            // 
            // checkBox_date_receipt_to
            // 
            this.checkBox_date_receipt_to.AutoSize = true;
            this.checkBox_date_receipt_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_date_receipt_to.Location = new System.Drawing.Point(218, 59);
            this.checkBox_date_receipt_to.Name = "checkBox_date_receipt_to";
            this.checkBox_date_receipt_to.Size = new System.Drawing.Size(219, 21);
            this.checkBox_date_receipt_to.TabIndex = 230;
            this.checkBox_date_receipt_to.Text = "Дата поступления заказа по";
            this.checkBox_date_receipt_to.UseVisualStyleBackColor = true;
            // 
            // textBox_flat
            // 
            this.textBox_flat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_flat.Location = new System.Drawing.Point(519, 22);
            this.textBox_flat.Name = "textBox_flat";
            this.textBox_flat.Size = new System.Drawing.Size(81, 24);
            this.textBox_flat.TabIndex = 229;
            // 
            // textBox_house
            // 
            this.textBox_house.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_house.Location = new System.Drawing.Point(401, 20);
            this.textBox_house.Name = "textBox_house";
            this.textBox_house.Size = new System.Drawing.Size(96, 24);
            this.textBox_house.TabIndex = 228;
            // 
            // _date_receipt_from
            // 
            this._date_receipt_from.CustomFormat = "d.MM.yyyy HH:mm";
            this._date_receipt_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._date_receipt_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this._date_receipt_from.Location = new System.Drawing.Point(5, 80);
            this._date_receipt_from.Name = "_date_receipt_from";
            this._date_receipt_from.Size = new System.Drawing.Size(202, 24);
            this._date_receipt_from.TabIndex = 227;
            // 
            // checkBox_date_receipt_from
            // 
            this.checkBox_date_receipt_from.AutoSize = true;
            this.checkBox_date_receipt_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_date_receipt_from.Location = new System.Drawing.Point(6, 59);
            this.checkBox_date_receipt_from.Name = "checkBox_date_receipt_from";
            this.checkBox_date_receipt_from.Size = new System.Drawing.Size(202, 21);
            this.checkBox_date_receipt_from.TabIndex = 55;
            this.checkBox_date_receipt_from.Text = "Дата поступленя заказа с";
            this.checkBox_date_receipt_from.UseVisualStyleBackColor = true;
            // 
            // comboBox_street
            // 
            this.comboBox_street.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_street.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_street.FormattingEnabled = true;
            this.comboBox_street.Location = new System.Drawing.Point(192, 21);
            this.comboBox_street.Name = "comboBox_street";
            this.comboBox_street.Size = new System.Drawing.Size(187, 24);
            this.comboBox_street.TabIndex = 45;
            // 
            // checkBox_house
            // 
            this.checkBox_house.AutoSize = true;
            this.checkBox_house.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_house.Location = new System.Drawing.Point(401, 3);
            this.checkBox_house.Name = "checkBox_house";
            this.checkBox_house.Size = new System.Drawing.Size(90, 21);
            this.checkBox_house.TabIndex = 40;
            this.checkBox_house.Text = "Квартира";
            this.checkBox_house.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(652, 131);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 30);
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
            this.comboBox_city.Location = new System.Drawing.Point(5, 22);
            this.comboBox_city.Name = "comboBox_city";
            this.comboBox_city.Size = new System.Drawing.Size(168, 24);
            this.comboBox_city.TabIndex = 36;
            this.comboBox_city.Leave += new System.EventHandler(this.comboBox_city_Leave);
            // 
            // checkBox_flat
            // 
            this.checkBox_flat.AutoSize = true;
            this.checkBox_flat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_flat.Location = new System.Drawing.Point(519, 5);
            this.checkBox_flat.Name = "checkBox_flat";
            this.checkBox_flat.Size = new System.Drawing.Size(55, 21);
            this.checkBox_flat.TabIndex = 30;
            this.checkBox_flat.Text = "Дом";
            this.checkBox_flat.UseVisualStyleBackColor = true;
            // 
            // checkBox_street
            // 
            this.checkBox_street.AutoSize = true;
            this.checkBox_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_street.Location = new System.Drawing.Point(192, 2);
            this.checkBox_street.Name = "checkBox_street";
            this.checkBox_street.Size = new System.Drawing.Size(68, 21);
            this.checkBox_street.TabIndex = 32;
            this.checkBox_street.Text = "Улица";
            this.checkBox_street.UseVisualStyleBackColor = true;
            // 
            // checkBox_city
            // 
            this.checkBox_city.AutoSize = true;
            this.checkBox_city.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_city.Location = new System.Drawing.Point(5, 3);
            this.checkBox_city.Name = "checkBox_city";
            this.checkBox_city.Size = new System.Drawing.Size(67, 21);
            this.checkBox_city.TabIndex = 28;
            this.checkBox_city.Text = "Город";
            this.checkBox_city.UseVisualStyleBackColor = true;
            // 
            // button_customers_new
            // 
            this.button_customers_new.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_customers_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_customers_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_customers_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customers_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_customers_new.Location = new System.Drawing.Point(463, 440);
            this.button_customers_new.Name = "button_customers_new";
            this.button_customers_new.Size = new System.Drawing.Size(201, 39);
            this.button_customers_new.TabIndex = 230;
            this.button_customers_new.Text = "Печать";
            this.button_customers_new.UseVisualStyleBackColor = true;
            this.button_customers_new.Click += new System.EventHandler(this.button_customers_new_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(693, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 39);
            this.button1.TabIndex = 231;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_application_archive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 488);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_customers_new);
            this.Controls.Add(this.comboBox_last_name);
            this.Controls.Add(this.button_user_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_application_archive";
            this.Text = "Архив заявок";
            this.Load += new System.EventHandler(this.Form_application_archive_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_last_name;
        private System.Windows.Forms.Button button_user_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_flat;
        private System.Windows.Forms.TextBox textBox_house;
        private System.Windows.Forms.DateTimePicker _date_receipt_from;
        private System.Windows.Forms.CheckBox checkBox_date_receipt_from;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_series;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_conclusion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DateTimePicker date_conclusion_to;
        private System.Windows.Forms.CheckBox checkBox_date_conclusion_to;
        private System.Windows.Forms.DateTimePicker date_conclusion_from;
        private System.Windows.Forms.CheckBox checkBox_date_conclusion_from;
        private System.Windows.Forms.DateTimePicker date_receipt_to;
        private System.Windows.Forms.CheckBox checkBox_date_receipt_to;
        private System.Windows.Forms.ComboBox comboBox_employee;
        private System.Windows.Forms.CheckBox checkBox_employee;
        private System.Windows.Forms.ComboBox comboBox_customer;
        private System.Windows.Forms.CheckBox checkBox_customer;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.CheckBox checkBox_status;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.CheckBox checkBox_type;
        private System.Windows.Forms.Button button_customers_new;
        private System.Windows.Forms.Button button1;
    }
}