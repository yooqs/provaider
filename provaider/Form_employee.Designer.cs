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
            this.button_employee_delete = new System.Windows.Forms.Button();
            this.button_employee_edit = new System.Windows.Forms.Button();
            this.button_employee_new = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).BeginInit();
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
            this.date_conclusion});
            this.dataGridView_employee.Location = new System.Drawing.Point(12, 123);
            this.dataGridView_employee.Name = "dataGridView_employee";
            this.dataGridView_employee.Size = new System.Drawing.Size(1216, 165);
            this.dataGridView_employee.TabIndex = 27;
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
            // button_employee_delete
            // 
            this.button_employee_delete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_employee_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_employee_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_employee_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_employee_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_employee_delete.Location = new System.Drawing.Point(690, 294);
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
            this.button_employee_edit.Location = new System.Drawing.Point(495, 294);
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
            this.button_employee_new.Location = new System.Drawing.Point(295, 294);
            this.button_employee_new.Name = "button_employee_new";
            this.button_employee_new.Size = new System.Drawing.Size(165, 39);
            this.button_employee_new.TabIndex = 28;
            this.button_employee_new.Text = "Добавить";
            this.button_employee_new.UseVisualStyleBackColor = true;
            this.button_employee_new.Click += new System.EventHandler(this.button_employee_new_Click);
            // 
            // Form_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1240, 450);
            this.Controls.Add(this.dataGridView_employee);
            this.Controls.Add(this.button_employee_delete);
            this.Controls.Add(this.button_employee_edit);
            this.Controls.Add(this.button_employee_new);
            this.Name = "Form_employee";
            this.Text = "Form_employee";
            this.Activated += new System.EventHandler(this.Form_employee_Activated);
            this.Load += new System.EventHandler(this.Form_employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_employee;
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
        private System.Windows.Forms.Button button_employee_delete;
        private System.Windows.Forms.Button button_employee_edit;
        private System.Windows.Forms.Button button_employee_new;
    }
}