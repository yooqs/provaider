namespace provaider
{
    partial class Form_directory_adress_street_new
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_directory_adress_street_new));
            this.button4 = new System.Windows.Forms.Button();
            this.textBox_street = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(50, 72);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 36);
            this.button4.TabIndex = 175;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox_street
            // 
            this.textBox_street.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_street.Location = new System.Drawing.Point(13, 34);
            this.textBox_street.Multiline = true;
            this.textBox_street.Name = "textBox_street";
            this.textBox_street.Size = new System.Drawing.Size(221, 26);
            this.textBox_street.TabIndex = 174;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 173;
            this.label3.Text = "Улица";
            // 
            // Form_directory_adress_street_new
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 120);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox_street);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_directory_adress_street_new";
            this.Text = "Добавить";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox_street;
        private System.Windows.Forms.Label label3;
    }
}