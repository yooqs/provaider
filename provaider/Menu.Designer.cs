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
            this.dgv_za.Location = new System.Drawing.Point(191, 99);
            this.dgv_za.Name = "dgv_za";
            this.dgv_za.Size = new System.Drawing.Size(341, 82);
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
            this.button_customers.Location = new System.Drawing.Point(79, 245);
            this.button_customers.Name = "button_customers";
            this.button_customers.Size = new System.Drawing.Size(75, 23);
            this.button_customers.TabIndex = 1;
            this.button_customers.Text = "button1";
            this.button_customers.UseVisualStyleBackColor = true;
            this.button_customers.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}