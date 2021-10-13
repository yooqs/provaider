namespace provaider
{
    partial class Form_login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_authorization = new System.Windows.Forms.Button();
            this.label_fold_button = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.checkBox_visible_password = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_close_button = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_authorization
            // 
            this.button_authorization.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button_authorization.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.button_authorization.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_authorization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_authorization.Location = new System.Drawing.Point(73, 226);
            this.button_authorization.Name = "button_authorization";
            this.button_authorization.Size = new System.Drawing.Size(151, 42);
            this.button_authorization.TabIndex = 19;
            this.button_authorization.Text = "Войти";
            this.button_authorization.UseVisualStyleBackColor = true;
            this.button_authorization.Click += new System.EventHandler(this.button_authorization_Click);
            // 
            // label_fold_button
            // 
            this.label_fold_button.AutoSize = true;
            this.label_fold_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fold_button.Location = new System.Drawing.Point(261, -1);
            this.label_fold_button.Name = "label_fold_button";
            this.label_fold_button.Size = new System.Drawing.Size(16, 17);
            this.label_fold_button.TabIndex = 12;
            this.label_fold_button.Text = "_";
            this.label_fold_button.Click += new System.EventHandler(this.label_fold_button_Click);
            this.label_fold_button.MouseEnter += new System.EventHandler(this.label_fold_button_MouseEnter);
            this.label_fold_button.MouseLeave += new System.EventHandler(this.label_fold_button_MouseLeave);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_password.Location = new System.Drawing.Point(22, 157);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(232, 26);
            this.textBox_password.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Пароль";
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_login.Location = new System.Drawing.Point(22, 93);
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(232, 26);
            this.textBox_login.TabIndex = 16;
            // 
            // checkBox_visible_password
            // 
            this.checkBox_visible_password.AutoSize = true;
            this.checkBox_visible_password.Location = new System.Drawing.Point(22, 189);
            this.checkBox_visible_password.Name = "checkBox_visible_password";
            this.checkBox_visible_password.Size = new System.Drawing.Size(126, 17);
            this.checkBox_visible_password.TabIndex = 15;
            this.checkBox_visible_password.Text = "показывать пароль";
            this.checkBox_visible_password.UseVisualStyleBackColor = true;
            this.checkBox_visible_password.CheckedChanged += new System.EventHandler(this.checkBox_visible_password_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "Авторизация";
            // 
            // label_close_button
            // 
            this.label_close_button.AutoSize = true;
            this.label_close_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_close_button.Location = new System.Drawing.Point(276, 1);
            this.label_close_button.Name = "label_close_button";
            this.label_close_button.Size = new System.Drawing.Size(17, 17);
            this.label_close_button.TabIndex = 11;
            this.label_close_button.Text = "X";
            this.label_close_button.Click += new System.EventHandler(this.label_close_button_Click);
            this.label_close_button.MouseEnter += new System.EventHandler(this.label_close_button_MouseEnter);
            this.label_close_button.MouseLeave += new System.EventHandler(this.label_close_button_MouseLeave);
            // 
            // Form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 282);
            this.Controls.Add(this.button_authorization);
            this.Controls.Add(this.label_fold_button);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.checkBox_visible_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_close_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_login_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_authorization;
        private System.Windows.Forms.Label label_fold_button;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.CheckBox checkBox_visible_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_close_button;
    }
}

