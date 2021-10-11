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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Activated(object sender, EventArgs e)
        {
            
            
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

            using (SqlConnection conn = new SqlConnection()) { 
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

        }

        private void button_applications_new_Click_1(object sender, EventArgs e)
        {

            Form_applications_contract applications_contract_form = new Form_applications_contract();
            applications_contract_form.StartPosition = FormStartPosition.CenterScreen;
            applications_contract_form.Show();
        }
    }
}
