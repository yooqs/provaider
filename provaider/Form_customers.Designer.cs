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
            this.button_customers_edit = new System.Windows.Forms.Button();
            this.button_customers_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(1, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1104, 165);
            this.dataGridView1.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "№ договора";
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // last_name
            // 
            this.last_name.HeaderText = "Фамилия";
            this.last_name.Name = "last_name";
            // 
            // first_name
            // 
            this.first_name.HeaderText = "Имя";
            this.first_name.Name = "first_name";
            // 
            // patronymic
            // 
            this.patronymic.HeaderText = "Отчество";
            this.patronymic.Name = "patronymic";
            // 
            // telephone
            // 
            this.telephone.HeaderText = "Телефон";
            this.telephone.Name = "telephone";
            // 
            // adress
            // 
            this.adress.HeaderText = "Адрес";
            this.adress.Name = "adress";
            this.adress.Width = 200;
            // 
            // date_birth
            // 
            this.date_birth.HeaderText = "Дата заключения договора";
            this.date_birth.Name = "date_birth";
            // 
            // passport_series
            // 
            this.passport_series.HeaderText = "Серия паспорта";
            this.passport_series.Name = "passport_series";
            // 
            // passport_number
            // 
            this.passport_number.HeaderText = "Номер паспорта";
            this.passport_number.Name = "passport_number";
            // 
            // date_conclusion
            // 
            this.date_conclusion.HeaderText = "Дата рождения";
            this.date_conclusion.Name = "date_conclusion";
            // 
            // button_customers_new
            // 
            this.button_customers_new.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_customers_new.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_customers_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customers_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_customers_new.Location = new System.Drawing.Point(243, 301);
            this.button_customers_new.Name = "button_customers_new";
            this.button_customers_new.Size = new System.Drawing.Size(165, 39);
            this.button_customers_new.TabIndex = 24;
            this.button_customers_new.Text = "Добавить";
            this.button_customers_new.UseVisualStyleBackColor = true;
            this.button_customers_new.Click += new System.EventHandler(this.button_customers_new_Click_1);
            // 
            // button_customers_edit
            // 
            this.button_customers_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_customers_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_customers_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customers_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_customers_edit.Location = new System.Drawing.Point(443, 301);
            this.button_customers_edit.Name = "button_customers_edit";
            this.button_customers_edit.Size = new System.Drawing.Size(165, 39);
            this.button_customers_edit.TabIndex = 25;
            this.button_customers_edit.Text = "Изменить";
            this.button_customers_edit.UseVisualStyleBackColor = true;
            this.button_customers_edit.Click += new System.EventHandler(this.button_customers_edit_Click);
            // 
            // button_customers_delete
            // 
            this.button_customers_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_customers_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_customers_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_customers_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_customers_delete.Location = new System.Drawing.Point(630, 301);
            this.button_customers_delete.Name = "button_customers_delete";
            this.button_customers_delete.Size = new System.Drawing.Size(165, 39);
            this.button_customers_delete.TabIndex = 26;
            this.button_customers_delete.Text = "Удалить";
            this.button_customers_delete.UseVisualStyleBackColor = true;
            this.button_customers_delete.Click += new System.EventHandler(this.button_customers_delete_Click);
            // 
            // Form_customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 450);
            this.Controls.Add(this.button_customers_delete);
            this.Controls.Add(this.button_customers_edit);
            this.Controls.Add(this.button_customers_new);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_customers";
            this.Text = "Form_customers";
            this.Activated += new System.EventHandler(this.Form_customers_Activated);
            this.Load += new System.EventHandler(this.Form_customers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button_customers_edit;
        private System.Windows.Forms.Button button_customers_delete;
    }
}