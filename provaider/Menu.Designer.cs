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
            this.dgv_za = new System.Windows.Forms.DataGridView();
            this.Заявка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ФИО = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_customers = new System.Windows.Forms.Button();
            this.button_customers_new = new System.Windows.Forms.Button();
            this.button_employees = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_za)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_za
            // 
            this.dgv_za.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_za.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Заявка,
            this.ФИО,
            this.Column1});
            this.dgv_za.Location = new System.Drawing.Point(44, 26);
            this.dgv_za.Name = "dgv_za";
            this.dgv_za.Size = new System.Drawing.Size(705, 171);
            this.dgv_za.TabIndex = 0;
            // 
            // Заявка
            // 
            this.Заявка.HeaderText = "Column";
            this.Заявка.Name = "Заявка";
            // 
            // ФИО
            // 
            this.ФИО.HeaderText = "Column1";
            this.ФИО.Name = "ФИО";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
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
            this.button_customers_new.Location = new System.Drawing.Point(44, 285);
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
            this.button_employees.Location = new System.Drawing.Point(44, 330);
            this.button_employees.Name = "button_employees";
            this.button_employees.Size = new System.Drawing.Size(165, 39);
            this.button_employees.TabIndex = 26;
            this.button_employees.Text = "Сотрудники";
            this.button_employees.UseVisualStyleBackColor = true;
            this.button_employees.Click += new System.EventHandler(this.button_employees_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(320, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 39);
            this.button2.TabIndex = 27;
            this.button2.Text = "Справочники";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(251, 214);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 28);
            this.button3.TabIndex = 28;
            this.button3.Text = "Новая заявка";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(423, 214);
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
            this.button5.Location = new System.Drawing.Point(595, 214);
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
            this.button6.Location = new System.Drawing.Point(320, 339);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(165, 39);
            this.button6.TabIndex = 31;
            this.button6.Text = "Архив заявок";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_employees);
            this.Controls.Add(this.button_customers_new);
            this.Controls.Add(this.button_customers);
            this.Controls.Add(this.dgv_za);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Activated += new System.EventHandler(this.Menu_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Menu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_za)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_za;
        private System.Windows.Forms.DataGridViewTextBoxColumn Заявка;
        private System.Windows.Forms.DataGridViewTextBoxColumn ФИО;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button button_customers;
        private System.Windows.Forms.Button button_customers_new;
        private System.Windows.Forms.Button button_employees;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}