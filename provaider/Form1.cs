using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provaider
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }
        Point LastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void label_fold_button_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label_close_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void checkBox_visible_password_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_visible_password.Checked)
            {
                textBox_password.PasswordChar = '\0';
            }
            else textBox_password.PasswordChar = '*';
        }

        private void label_close_button_MouseEnter(object sender, EventArgs e)
        {
            label_close_button.ForeColor = Color.Red;
        }

        private void label_close_button_MouseLeave(object sender, EventArgs e)
        {
            label_close_button.ForeColor = Color.Black;
        }

        private void label_fold_button_MouseEnter(object sender, EventArgs e)
        {
            label_fold_button.ForeColor = Color.Red;
        }

        private void label_fold_button_MouseLeave(object sender, EventArgs e)
        {
            label_fold_button.ForeColor = Color.Black;
        }

        private void button_authorization_Click(object sender, EventArgs e)
        {
            string admin_user;
            String LoginUser = textBox_login.Text;
            String PassUser = textBox_password.Text;
            if (textBox_login.Text == "" || textBox_password.Text == "")
            {
                MessageBox.Show("Введите значения!");
            }
            else
            {


                DataTable table = new DataTable();
                SqlConnection conn = new SqlConnection();
               
                conn.ConnectionString = provaider.Properties.Resources.conn_string;
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand("SELECT *From [authorization] WHERE login = @log and password = @pas", conn);
                command.Parameters.Add("@log", SqlDbType.VarChar).Value = LoginUser;
                command.Parameters.Add("@pas", SqlDbType.VarChar).Value = PassUser;
                adapter.SelectCommand = command;

                adapter.Fill(table);

                if (table.Rows.Count > 0)
                {
                    conn.Close();

                    command = new SqlCommand("SELECT *From [authorization] WHERE login = '" + LoginUser + "' and password = '" + PassUser + "'", conn);

                    conn.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        reader.Read();

                        admin_user = reader.GetValue(3).ToString().Trim();

                        reader.Close();
                    }
                    conn.Close();
                    this.Hide();
                    Menu form_menu = new Menu();
                    form_menu.StartPosition = FormStartPosition.CenterScreen;
                    form_menu.Show();
                }

                else MessageBox.Show("Пароль или логин введен не верно!");
                conn.Close();
            }
        }

        private void Form_login_Load(object sender, EventArgs e)
        {

        }
    }
}
