
namespace provaider
{
    partial class Form_otcet_app
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
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_conclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_employee_edit = new System.Windows.Forms.Button();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
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
            this.dataGridView1.Location = new System.Drawing.Point(9, 127);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1189, 266);
            this.dataGridView1.TabIndex = 34;
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
            // button_employee_edit
            // 
            this.button_employee_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_employee_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_employee_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_employee_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_employee_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_employee_edit.Location = new System.Drawing.Point(525, 404);
            this.button_employee_edit.Name = "button_employee_edit";
            this.button_employee_edit.Size = new System.Drawing.Size(165, 39);
            this.button_employee_edit.TabIndex = 245;
            this.button_employee_edit.Text = "Печать";
            this.button_employee_edit.UseVisualStyleBackColor = true;
            this.button_employee_edit.Click += new System.EventHandler(this.button_employee_edit_Click);
            // 
            // comboBox_employee
            // 
            this.comboBox_employee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_employee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_employee.FormattingEnabled = true;
            this.comboBox_employee.Location = new System.Drawing.Point(348, 75);
            this.comboBox_employee.Name = "comboBox_employee";
            this.comboBox_employee.Size = new System.Drawing.Size(266, 24);
            this.comboBox_employee.TabIndex = 257;
            // 
            // checkBox_employee
            // 
            this.checkBox_employee.AutoSize = true;
            this.checkBox_employee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_employee.Location = new System.Drawing.Point(348, 57);
            this.checkBox_employee.Name = "checkBox_employee";
            this.checkBox_employee.Size = new System.Drawing.Size(73, 21);
            this.checkBox_employee.TabIndex = 256;
            this.checkBox_employee.Text = "Техник";
            this.checkBox_employee.UseVisualStyleBackColor = true;
            // 
            // comboBox_customer
            // 
            this.comboBox_customer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_customer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_customer.FormattingEnabled = true;
            this.comboBox_customer.Location = new System.Drawing.Point(3, 75);
            this.comboBox_customer.Name = "comboBox_customer";
            this.comboBox_customer.Size = new System.Drawing.Size(291, 24);
            this.comboBox_customer.TabIndex = 255;
            // 
            // checkBox_customer
            // 
            this.checkBox_customer.AutoSize = true;
            this.checkBox_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_customer.Location = new System.Drawing.Point(5, 57);
            this.checkBox_customer.Name = "checkBox_customer";
            this.checkBox_customer.Size = new System.Drawing.Size(75, 21);
            this.checkBox_customer.TabIndex = 254;
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
            this.comboBox_status.Location = new System.Drawing.Point(214, 22);
            this.comboBox_status.Name = "comboBox_status";
            this.comboBox_status.Size = new System.Drawing.Size(177, 24);
            this.comboBox_status.TabIndex = 253;
            this.comboBox_status.Tag = "";
            // 
            // checkBox_status
            // 
            this.checkBox_status.AutoSize = true;
            this.checkBox_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_status.Location = new System.Drawing.Point(214, 3);
            this.checkBox_status.Name = "checkBox_status";
            this.checkBox_status.Size = new System.Drawing.Size(121, 21);
            this.checkBox_status.TabIndex = 252;
            this.checkBox_status.Text = "Статус заявки";
            this.checkBox_status.UseVisualStyleBackColor = true;
            // 
            // comboBox_type
            // 
            this.comboBox_type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_type.FormattingEnabled = true;
            this.comboBox_type.Location = new System.Drawing.Point(3, 22);
            this.comboBox_type.Name = "comboBox_type";
            this.comboBox_type.Size = new System.Drawing.Size(179, 24);
            this.comboBox_type.TabIndex = 251;
            // 
            // checkBox_type
            // 
            this.checkBox_type.AutoSize = true;
            this.checkBox_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_type.Location = new System.Drawing.Point(3, 1);
            this.checkBox_type.Name = "checkBox_type";
            this.checkBox_type.Size = new System.Drawing.Size(105, 21);
            this.checkBox_type.TabIndex = 250;
            this.checkBox_type.Text = "Вид работы";
            this.checkBox_type.UseVisualStyleBackColor = true;
            // 
            // date_conclusion_to
            // 
            this.date_conclusion_to.CustomFormat = "d.MM.yyyy HH:mm";
            this.date_conclusion_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_conclusion_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_conclusion_to.Location = new System.Drawing.Point(635, 22);
            this.date_conclusion_to.Name = "date_conclusion_to";
            this.date_conclusion_to.Size = new System.Drawing.Size(213, 24);
            this.date_conclusion_to.TabIndex = 249;
            // 
            // checkBox_date_conclusion_to
            // 
            this.checkBox_date_conclusion_to.AutoSize = true;
            this.checkBox_date_conclusion_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_date_conclusion_to.Location = new System.Drawing.Point(636, 1);
            this.checkBox_date_conclusion_to.Name = "checkBox_date_conclusion_to";
            this.checkBox_date_conclusion_to.Size = new System.Drawing.Size(215, 21);
            this.checkBox_date_conclusion_to.TabIndex = 248;
            this.checkBox_date_conclusion_to.Text = "Дата выполнения заказа по";
            this.checkBox_date_conclusion_to.UseVisualStyleBackColor = true;
            // 
            // date_conclusion_from
            // 
            this.date_conclusion_from.CustomFormat = "d.MM.yyyy HH:mm";
            this.date_conclusion_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.date_conclusion_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_conclusion_from.Location = new System.Drawing.Point(412, 22);
            this.date_conclusion_from.Name = "date_conclusion_from";
            this.date_conclusion_from.Size = new System.Drawing.Size(202, 24);
            this.date_conclusion_from.TabIndex = 247;
            // 
            // checkBox_date_conclusion_from
            // 
            this.checkBox_date_conclusion_from.AutoSize = true;
            this.checkBox_date_conclusion_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_date_conclusion_from.Location = new System.Drawing.Point(413, 1);
            this.checkBox_date_conclusion_from.Name = "checkBox_date_conclusion_from";
            this.checkBox_date_conclusion_from.Size = new System.Drawing.Size(206, 21);
            this.checkBox_date_conclusion_from.TabIndex = 246;
            this.checkBox_date_conclusion_from.Text = "Дата выполнения заказа с";
            this.checkBox_date_conclusion_from.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.comboBox_type);
            this.panel1.Controls.Add(this.comboBox_employee);
            this.panel1.Controls.Add(this.checkBox_date_conclusion_from);
            this.panel1.Controls.Add(this.checkBox_employee);
            this.panel1.Controls.Add(this.date_conclusion_from);
            this.panel1.Controls.Add(this.comboBox_customer);
            this.panel1.Controls.Add(this.checkBox_date_conclusion_to);
            this.panel1.Controls.Add(this.checkBox_customer);
            this.panel1.Controls.Add(this.date_conclusion_to);
            this.panel1.Controls.Add(this.comboBox_status);
            this.panel1.Controls.Add(this.checkBox_type);
            this.panel1.Controls.Add(this.checkBox_status);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 109);
            this.panel1.TabIndex = 258;
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(636, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(212, 30);
            this.button3.TabIndex = 258;
            this.button3.Text = "Применить фильтр";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form_otcet_app
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1205, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_employee_edit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_otcet_app";
            this.Text = "Form_otcet_app";
            this.Load += new System.EventHandler(this.Form_otcet_app_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
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
        private System.Windows.Forms.Button button_employee_edit;
        private System.Windows.Forms.ComboBox comboBox_employee;
        private System.Windows.Forms.CheckBox checkBox_employee;
        private System.Windows.Forms.ComboBox comboBox_customer;
        private System.Windows.Forms.CheckBox checkBox_customer;
        private System.Windows.Forms.ComboBox comboBox_status;
        private System.Windows.Forms.CheckBox checkBox_status;
        private System.Windows.Forms.ComboBox comboBox_type;
        private System.Windows.Forms.CheckBox checkBox_type;
        private System.Windows.Forms.DateTimePicker date_conclusion_to;
        private System.Windows.Forms.CheckBox checkBox_date_conclusion_to;
        private System.Windows.Forms.DateTimePicker date_conclusion_from;
        private System.Windows.Forms.CheckBox checkBox_date_conclusion_from;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
    }
}