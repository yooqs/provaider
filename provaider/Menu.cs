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
    public partial class Form_menu : Form
    {
        public Form_menu()
        {
            InitializeComponent();
        }
        public static bool application_update = false;
        
        private void Menu_Activated(object sender, EventArgs e)
        {
           if (application_update)
            {
                table_applications_load();
                application_update = false;
            }

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_login login_form = new Form_login();
            login_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_customers_new_Click(object sender, EventArgs e)
        {
            Form_customers customers_form = new Form_customers();
            customers_form.StartPosition = FormStartPosition.CenterScreen;
            customers_form.Show();
        }

        private void button_employees_Click(object sender, EventArgs e)
        {
            Form_employee employee_form = new Form_employee();
            employee_form.StartPosition = FormStartPosition.CenterScreen;
            employee_form.Show();

        }

        private void button_directory_Click(object sender, EventArgs e)
        {
            Form_directory_adress directory_adress_form = new Form_directory_adress();
            directory_adress_form.StartPosition = FormStartPosition.CenterScreen;
            directory_adress_form.Show();
        }

        private void button_applications_new_Click(object sender, EventArgs e)
        {
            Form_applications_contract applications_contract_form = new Form_applications_contract();
            applications_contract_form.StartPosition = FormStartPosition.CenterScreen;
            applications_contract_form.Show();
        }
        public void table_applications_load()
        {
            String sql;
            dataGridView1.Rows.Clear();

            using (SqlConnection conn = new SqlConnection())
            {
                sql = "Select [applications].[id],[applications].[description],[applications].[date_receipt],[contract].[last_name],[contract].[first_name],[contract].[patronymic],[contract].[telephone],[contract].[city],[contract].[street],[contract].[house],[contract].[flat],[employee].[last_name],[employee].[first_name],[employee].[patronymic],[type_application].[name] FROM  [contract] JOIN [applications] ON [contract].[id] =  [applications].[id_contract]  JOIN[employee] ON [employee].[id] =  [applications].[id_employee] JOIN[type_application] ON[type_application].[id] =  [applications].[type]  where [status] = 'Выполняется'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.ConnectionString = provaider.Properties.Resources.conn_string;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(3).ToString().Trim()+" "+reader.GetValue(4).ToString().Trim()+" "+reader.GetValue(5).ToString().Trim(),
                                    reader.GetValue(6).ToString().Trim(),
                                    reader.GetValue(7).ToString().Trim()+", "+reader.GetValue(8).ToString().Trim()+", "+reader.GetValue(9).ToString().Trim()+", "+reader.GetValue(10).ToString().Trim(),
                                    reader.GetValue(14).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(),
                                    reader.GetValue(11).ToString().Trim()+" "+reader.GetValue(12).ToString().Trim()+" "+reader.GetValue(13).ToString().Trim(),
                                    reader.GetValue(2).ToString().Trim(),

                                    };

                    dataGridView1.Rows.Add(row);
                }

            }

        }
        private void Menu_Load(object sender, EventArgs e)
        {
            table_applications_load();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);

        }
        void timer_Tick(object sender, EventArgs e)
        {
            label_timer.Text = DateTime.Now.ToShortDateString() + ", " + DateTime.Now.ToLongTimeString();
        }
        private void button_applications_new_Click_1(object sender, EventArgs e)
        {

            Form_applications_contract applications_contract_form = new Form_applications_contract();
            applications_contract_form.StartPosition = FormStartPosition.CenterScreen;
            applications_contract_form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
            DialogResult dialogResult = MessageBox.Show("Подтвердите выполнение заявки № "+ (string)dataGridView1.CurrentRow.Cells[0].Value + "!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) { 
                String sql;
            String sql_conn = provaider.Properties.Resources.conn_string; ;
            using (SqlConnection conn = new SqlConnection(sql_conn))
            {
                    string date_time = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
                    date_time = date_time.Substring(0, date_time.Length - 3);
                    sql = $"UPDATE [applications] SET [status]='Выполнена', [date_completion]=CONVERT(varchar(23), '{date_time}', 121) WHERE id= {(string)dataGridView1.CurrentRow.Cells[0].Value}";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
            }
            table_applications_load();
             }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Подтвердите отмену заявки № " + (string)dataGridView1.CurrentRow.Cells[0].Value + "!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String sql;
                String sql_conn = provaider.Properties.Resources.conn_string; ;
                using (SqlConnection conn = new SqlConnection(sql_conn))
                {
                    sql = $"UPDATE [applications] SET [status]='Отменена' WHERE id= {(string)dataGridView1.CurrentRow.Cells[0].Value}";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                table_applications_load();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Form_application_archive application_archive_form = new Form_application_archive();
            application_archive_form.StartPosition = FormStartPosition.CenterScreen;
            application_archive_form.Show();
        }
    }
}
