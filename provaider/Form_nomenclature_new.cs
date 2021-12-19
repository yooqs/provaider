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
    public partial class Form_nomenclature_new : Form
    {
        public Form_nomenclature_new()
        {
            InitializeComponent();
        }
        class products
        {
            public int id { set; get; }
            public string name { get; set; }
        }

        int category;
        Boolean flag = false;
        private void Form_nomenclature_new_Load(object sender, EventArgs e)
        {
            string string_connection = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [name] From [products_categories]", conn);
                List<products> employee_list = new List<products>();
                employee_list.Clear();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    employee_list.Add(new products() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                }


                comboBox1.DataSource = employee_list;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
                flag = true;

            }
            

            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [name] From [unit_products]", conn);
                List<products> employee_list = new List<products>();
                employee_list.Clear();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    employee_list.Add(new products() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                }


                comboBox2.DataSource = employee_list;
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "id";
                flag = true;
            }
        }

        private void button_user_new_Click(object sender, EventArgs e)
        {
            string string_connection = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO [products] ([name],[id_unit],[id_category])  VALUES(@name,@id_unit,@id_category)", conn);
                command.Parameters.AddWithValue("@name", textBox_name.Text);
                command.Parameters.AddWithValue("@id_unit", comboBox2.SelectedValue);
                command.Parameters.AddWithValue("@id_category", comboBox1.SelectedValue);
                command.ExecuteNonQuery();
                Form_directory_adress.update_table_nomenclature = true;
                this.Close();
            }
        }
    }
}
