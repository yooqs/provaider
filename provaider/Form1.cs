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
            if (provaider.Properties.Settings.Default.Local_flag == true)
            {
                sql_connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\basa.mdf;Integrated Security=True;Connect Timeout=30";
            }
            else
            {
                sql_connect = provaider.Properties.Settings.Default.Connect_string_db;
            }
        }
        Point LastPoint;
        string ssg = provaider.Properties.Resources.conn_string;
        public static string sql_connect;
        
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

        string fio;
        public static int id_maneger;
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

                /**
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
                    Form_menu form_menu = new Form_menu();
                    form_menu.StartPosition = FormStartPosition.CenterScreen;
                    form_menu.Show();
                }

                else MessageBox.Show("Пароль или логин введен не верно!");
                conn.Close();
            **/
                string sqlconnection = sql_connect;
                using (SqlConnection conn = new SqlConnection(sql_connect))
                {
                     SqlCommand command = new SqlCommand("SELECT [employee].[id],[employee].[last_name],[employee].[first_name],[employee].[patronymic]From [employee] JOIN [post] ON [employee].[id_post] = [post].[id] WHERE login = '" + LoginUser + "' and password = '" + PassUser + "' and [post].[name]='Менеджер'", conn);

                    conn.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        


                        reader.Read();
                        id_maneger = (int)reader.GetValue(0);
                        fio = reader.GetValue(1).ToString().Trim() +" "+ reader.GetValue(2).ToString().Trim()+" "+ reader.GetValue(3).ToString().Trim();

                        reader.Close();
                        conn.Close();
                        this.Hide();
                        Form_menu form_menu = new Form_menu(fio);
                        form_menu.StartPosition = FormStartPosition.CenterScreen;
                        form_menu.Show();

                    }
                    else
                    {
                        MessageBox.Show("Пароль или логин введен не верно!");
                    }
                    conn.Close();
                }
            
            }
        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            if (provaider.Properties.Settings.Default.Local_flag == true)
            {
                sql_connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\basa.mdf;Integrated Security=True;Connect Timeout=30";
            }
            else
            {
                sql_connect = provaider.Properties.Settings.Default.Connect_string_db;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_setting_load form_Setting = new Form_setting_load();
            form_Setting.StartPosition = FormStartPosition.CenterScreen;
            form_Setting.ShowDialog();
        }

        private void Form_login_Activated(object sender, EventArgs e)
        {
            if (provaider.Properties.Settings.Default.Local_flag == true)
            {
                sql_connect = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\basa.mdf;Integrated Security=True;Connect Timeout=30";
            }
            else
            {
                sql_connect = provaider.Properties.Settings.Default.Connect_string_db;
            }
        }
    }
}
