
namespace provaider
{
    partial class Form_applications_new_products_new
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
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_user_search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_employee_edit = new System.Windows.Forms.Button();
            this.dataGridView_employee = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.first_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(10, 31);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(186, 26);
            this.comboBox2.TabIndex = 250;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(212, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 26);
            this.comboBox1.TabIndex = 249;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(209, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 248;
            this.label2.Text = "Категория";
            // 
            // button_user_search
            // 
            this.button_user_search.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_user_search.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_user_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_user_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_user_search.Location = new System.Drawing.Point(424, 31);
            this.button_user_search.Name = "button_user_search";
            this.button_user_search.Size = new System.Drawing.Size(83, 26);
            this.button_user_search.TabIndex = 247;
            this.button_user_search.Text = "Поиск";
            this.button_user_search.UseVisualStyleBackColor = true;
            this.button_user_search.Click += new System.EventHandler(this.button_user_search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 16);
            this.label1.TabIndex = 246;
            this.label1.Text = "Поиск по наименованию";
            // 
            // button_employee_edit
            // 
            this.button_employee_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_employee_edit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_employee_edit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_employee_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_employee_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_employee_edit.Location = new System.Drawing.Point(361, 426);
            this.button_employee_edit.Name = "button_employee_edit";
            this.button_employee_edit.Size = new System.Drawing.Size(165, 39);
            this.button_employee_edit.TabIndex = 245;
            this.button_employee_edit.Text = "Выбрать";
            this.button_employee_edit.UseVisualStyleBackColor = true;
            this.button_employee_edit.Click += new System.EventHandler(this.button_employee_edit_Click);
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
            this.Column1,
            this.patronymic,
            this.first_name,
            this.telephone,
            this.Column2,
            this.id_unit,
            this.Column3});
            this.dataGridView_employee.Location = new System.Drawing.Point(11, 77);
            this.dataGridView_employee.Name = "dataGridView_employee";
            this.dataGridView_employee.Size = new System.Drawing.Size(835, 267);
            this.dataGridView_employee.TabIndex = 244;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.FillWeight = 253.8071F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // last_name
            // 
            this.last_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.last_name.FillWeight = 82.91032F;
            this.last_name.HeaderText = "Наименование";
            this.last_name.Name = "last_name";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Категория";
            this.Column1.Name = "Column1";
            // 
            // patronymic
            // 
            this.patronymic.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patronymic.FillWeight = 82.91032F;
            this.patronymic.HeaderText = "Единица измерения";
            this.patronymic.Name = "patronymic";
            // 
            // first_name
            // 
            this.first_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.first_name.FillWeight = 82.91032F;
            this.first_name.HeaderText = "Количество";
            this.first_name.Name = "first_name";
            // 
            // telephone
            // 
            this.telephone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.telephone.FillWeight = 82.91032F;
            this.telephone.HeaderText = "Цена";
            this.telephone.Name = "telephone";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "id_категории";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // id_unit
            // 
            this.id_unit.HeaderText = "id_unit";
            this.id_unit.Name = "id_unit";
            this.id_unit.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "id_продукта";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(16, 382);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 29);
            this.textBox1.TabIndex = 251;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 355);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 252;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(306, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 24);
            this.label4.TabIndex = 254;
            this.label4.Text = "Идентификатор";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(310, 382);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(261, 29);
            this.textBox2.TabIndex = 253;
            // 
            // Form_applications_new_products_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 477);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_user_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_employee_edit);
            this.Controls.Add(this.dataGridView_employee);
            this.Name = "Form_applications_new_products_new";
            this.ShowIcon = false;
            this.Text = "Материалы и оборудование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_applications_new_products_new_FormClosed);
            this.Load += new System.EventHandler(this.Form_applications_new_products_new_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_user_search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_employee_edit;
        private System.Windows.Forms.DataGridView dataGridView_employee;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn first_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}