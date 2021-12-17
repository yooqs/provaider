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
    public partial class Form_application_archive_open : Form
    {
        int id;
        public Form_application_archive_open(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        class employee
        {
            public int id { get; set; }
            public string name { get; set; }

        }
        private void ComboBox_vid()
        {
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {

                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [name] From [type_application]", conn);
                List<employee> employee_list = new List<employee>();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    employee_list.Add(new employee() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                }


                comboBox1.DataSource = employee_list;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
            }

            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {

                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [description],[description_texnik], [type], Format([date_receipt],'dd.MM.yyyy H:mm:ss') From [applications] WHERE id=" + id, conn);
                SqlDataReader reader = comand.ExecuteReader();
                if (reader.Read())
                {
                    textBox_description.Text = reader.GetValue(0).ToString();
                    textBox1.Text = reader.GetValue(1).ToString();
                    comboBox1.SelectedValue = Convert.ToInt32(reader.GetValue(2).ToString());
                    date_receipt.Value = Convert.ToDateTime(reader.GetValue(3).ToString());

                }



            }
        }

        private void table_tex()
        {
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {

                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [last_name], [first_name], [patronymic] From [employee] where [id_post]=1", conn);
                List<employee> employee_list = new List<employee>();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    employee_list.Add(new employee() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() + " " + (string)reader.GetValue(2).ToString().Trim() + " " + (string)reader.GetValue(3).ToString().Trim() });
                }
                //products_purchase 
                Column9.DataSource = employee_list;
                Column9.DisplayMember = "name";
                Column9.ValueMember = "id";

            }
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {

                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT  employee.id From employee JOIN [emp_app] ON [emp_app].id_emp = [employee].id JOIN [applications] ON [applications].id = [emp_app].id_app where applications.id =" + id, conn);
                SqlDataReader reader = comand.ExecuteReader();
                int id_grid = 0;
                while (reader.Read())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, id_grid].Value = Convert.ToInt32(reader.GetValue(0).ToString());
                    id_grid++;
                }
                //products_purchase 



            }

        }
        private void table_pur()
        {
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {

                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [products_purchase].[id], [products].[id] ,[products].name,[products_categories].[name],[identifier],[products_purchase].[volume],[products_purchase].[price],[products].[id_unit],[products].[id_category],[id_sklad] FROM[provaider_basa].[dbo].[products_purchase] JOIN[applications] ON[applications].id = [products_purchase].[id_applications] JOIN[products] ON[products].id = [products_purchase].[id_product] JOIN[products_categories] ON[products].[id_category] = [products_categories].id Where[applications].id=" + id, conn);

                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView_employee.Rows.Add(reader.GetValue(0).ToString().Trim(), reader.GetValue(1).ToString().Trim(), reader.GetValue(2).ToString().Trim(), reader.GetValue(3).ToString().Trim(), reader.GetValue(4).ToString().Trim(), reader.GetValue(5).ToString().Trim(), reader.GetValue(6).ToString().Trim(), Convert.ToDecimal(reader.GetValue(6).ToString().Trim()) * Convert.ToDecimal(reader.GetValue(5).ToString().Trim()), reader.GetValue(7).ToString().Trim(), reader.GetValue(8).ToString().Trim(), reader.GetValue(9).ToString().Trim());
                }


            }
        }
        private void contract_load()
        {
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {
                string sql = "Select [last_name],[first_name],[patronymic],[city]+', '+[street]+', '+[house]+', '+[flat], [distance], [telephone], [passport_series], [passport_number], [time_before],FORMAT([data_birth], 'dd/MM/yyyy' ),FORMAT([date_conclusion], 'dd/MM/yyyy' )   From [contract] JOIN [applications] ON  [applications].[id_contract] = [contract].[id] where applications.id =" + id;
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    label2.Text += id; //id
                    textBox_last_name.Text = reader.GetValue(0).ToString().Trim();    //фамилия
                    textBox_first_name.Text = reader.GetValue(1).ToString().Trim();   //имя
                    textBox_patronymic.Text = reader.GetValue(2).ToString().Trim();   //очетсво
                    textBox_adres.Text = reader.GetValue(3).ToString().Trim();       //адресc
                    textBox3.Text = reader.GetValue(4).ToString().Trim();       //расстояние
                    maskedTextBox1.Text = reader.GetValue(5).ToString().Trim();      //телефон
                    textBox_passport_series.Text = reader.GetValue(6).ToString().Trim();      //серия паспорта
                    textBox_passport_number.Text = reader.GetValue(7).ToString().Trim();      //номер паспорта
                    textBox2.Text = reader.GetValue(8).ToString().Trim(); //время прибытия
                    textBox_birth_date.Value = Convert.ToDateTime(reader.GetValue(9).ToString().Trim());   //дата рождения
                    date_conclusion.Value = Convert.ToDateTime(reader.GetValue(10).ToString().Trim());        //дата заключения договора  

                }

            }
        }
        private void Form_application_archive_open_Load(object sender, EventArgs e)
        {
            contract_load();
            ComboBox_vid();
            table_tex();
            table_pur();
        }
    }
}
