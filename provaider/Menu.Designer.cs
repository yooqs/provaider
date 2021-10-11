namespace provaider
{
    partial class Menu
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
            this.button_customers = new System.Windows.Forms.Button();
            this.button_customers_new = new System.Windows.Forms.Button();
            this.button_employees = new System.Windows.Forms.Button();
            this.button_directory = new System.Windows.Forms.Button();
            this.button_applications_new = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_series = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passport_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_conclusion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_customers
            // 
            this.button_customers.Location = new System.Drawing.Point(469, 330);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(75, 23);
            this.button_customers.TabIndex = 1;
            this.button_customers.Text = "button1";
            this.button_customers.UseVisualStyleBackColor = true;
            this.button_customers.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_customers_new
            // 
            this.button_customers_new.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_customers_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_customers_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_customers_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customers_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_customers_new.Location = new System.Drawing.Point(135, 285);
            this.button_customers_new.Name = "button_customers_new";
            this.button_customers_new.Size = new System.Drawing.Size(165, 39);
            this.button_customers_new.TabIndex = 25;
            this.button_customers_new.Text = "Клиенты";
            this.button_customers_new.UseVisualStyleBackColor = true;
            this.button_customers_new.Click += new System.EventHandler(this.button_customers_new_Click);
            // 
            // button_employees
            // 
            this.button_employees.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_employees.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_employees.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_employees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_employees.Location = new System.Drawing.Point(135, 330);
            this.button_employees.Name = "button_employees";
            this.button_employees.Size = new System.Drawing.Size(165, 39);
            this.button_employees.TabIndex = 26;
            this.button_employees.Text = "Сотрудники";
            this.button_employees.UseVisualStyleBackColor = true;
            this.button_employees.Click += new System.EventHandler(this.button_employees_Click);
            // 
            // button_directory
            // 
            this.button_directory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_directory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_directory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_directory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_directory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_directory.Location = new System.Drawing.Point(411, 285);
            this.button_directory.Name = "button_directory";
            this.button_directory.Size = new System.Drawing.Size(165, 39);
            this.button_directory.TabIndex = 27;
            this.button_directory.Text = "Справочники";
            this.button_directory.UseVisualStyleBackColor = true;
            this.button_directory.Click += new System.EventHandler(this.button_directory_Click);
            // 
            // button_applications_new
            // 
            this.button_applications_new.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_applications_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_applications_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_applications_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_applications_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_applications_new.Location = new System.Drawing.Point(342, 214);
            this.button_applications_new.Name = "button_applications_new";
            this.button_applications_new.Size = new System.Drawing.Size(147, 28);
            this.button_applications_new.TabIndex = 28;
            this.button_applications_new.Text = "Новая заявка";
            this.button_applications_new.UseVisualStyleBackColor = true;
            this.button_applications_new.Click += new System.EventHandler(this.button_applications_new_Click_1);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(514, 214);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 28);
            this.button4.TabIndex = 29;
            this.button4.Text = "Вылненена";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(686, 214);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 28);
            this.button5.TabIndex = 30;
            this.button5.Text = "Отмена";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(411, 339);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 39);
            this.button6.TabIndex = 31;
            this.button6.Text = "Архив заявок";
            this.button6.UseVisualStyleBackColor = true;
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
            this.date_conclusion});
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(935, 165);
            this.dataGridView1.TabIndex = 32;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.FillWeight = 253.8071F;
            this.id.HeaderText = "№ заяки";
            this.id.Name = "id";
            this.id.Width = 76;
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
            this.first_name.Width = 77;
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
            this.date_birth.HeaderText = "Тип услуги";
            this.date_birth.Name = "date_birth";
            this.date_birth.Width = 87;
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
            this.date_conclusion.HeaderText = "Дата получения заявки";
            this.date_conclusion.Name = "date_conclusion";
            this.date_conclusion.Width = 106;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button_applications_new);
            this.Controls.Add(this.button_directory);
            this.Controls.Add(this.button_employees);
            this.Controls.Add(this.button_customers_new);
            this.Controls.Add(this.button_customers);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Activated += new System.EventHandler(this.Menu_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            this.Load += new System.EventHandler(this.Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_customers;
        private System.Windows.Forms.Button button_customers_new;
        private System.Windows.Forms.Button button_employees;
        private System.Windows.Forms.Button button_directory;
        private System.Windows.Forms.Button button_applications_new;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_series;
        private System.Windows.Forms.DataGridViewTextBoxColumn passport_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_conclusion;
    }
}