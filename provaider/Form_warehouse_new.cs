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
    public partial class Form_warehouse_new : Form
    {
        public Form_warehouse_new()
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
        private void Form_warehouse_new_Load(object sender, EventArgs e)
        {
            //заполнение вид услуг
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

            
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                if (flag == true)
                {
                    conn.Open();
                    int id = Convert.ToInt32(comboBox1.SelectedValue);
                    SqlCommand comand = new SqlCommand("SELECT [id], [name], [id_unit] From [products] where [id_category]=" + id, conn);//where [id_category]="+ comboBox1.SelectedValue
                    List<products> employee_list2 = new List<products>();
                    SqlDataReader reader = comand.ExecuteReader();
                    employee_list2.Clear();
                    while (reader.Read())
                    {
                        employee_list2.Add(new products() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                        category = int.Parse(reader.GetValue(2).ToString().Trim());
                    }


                    comboBox_name.DataSource = employee_list2;
                    comboBox_name.DisplayMember = "name";
                    comboBox_name.ValueMember = "id";
                   
                    }
            }
           
        }

        private void button_user_new_Click(object sender, EventArgs e)
        {
            int id_end = 0;
            if (comboBox_name.SelectedIndex > -1)
            {
                //из списка
                string string_connection = Form_login.sql_connect;
                using (SqlConnection conn = new SqlConnection(string_connection))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("INSERT INTO [products_warehouse] ([id_products],[volume],[price])  VALUES(@id_products,@volume,@price)", conn);
                    command.Parameters.AddWithValue("@id_products", comboBox_name.SelectedValue);
                    command.Parameters.AddWithValue("@volume", textBox_volume.Text);
                    command.Parameters.AddWithValue("@price", textBox_price.Text);
                  
                    command.ExecuteNonQuery();
                    
                }
            }
            else
            {
                
                //не из списка
                string string_connection = Form_login.sql_connect;
                using (SqlConnection conn = new SqlConnection(string_connection))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO [products] ([name],[id_unit],[id_category])  VALUES(@name,@id_unit,@id_category)", conn);
                    command.Parameters.AddWithValue("@name", comboBox_name.Text);
                    command.Parameters.AddWithValue("@id_unit", comboBox2.SelectedValue);
                    command.Parameters.AddWithValue("@id_category", comboBox1.SelectedValue);
                    command.ExecuteNonQuery();
                }
                using(SqlConnection conn = new SqlConnection(string_connection))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT('products')", conn);

                    
                    SqlDataReader reder = command.ExecuteReader();
                    while (reder.Read()) {
                        id_end = Convert.ToInt32(reder.GetValue(0));
                    }
                }
                using (SqlConnection conn = new SqlConnection(string_connection))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("INSERT INTO [products_warehouse] ([id_products],[volume],[price])  VALUES(@id_products,@volume,@price)", conn);
                    command.Parameters.AddWithValue("@id_products", id_end);
                    command.Parameters.AddWithValue("@volume", textBox_volume.Text);
                    command.Parameters.AddWithValue("@price", textBox_price.Text);
                    command.ExecuteNonQuery();




                }
            }
            Form_warehouse.flag_table_update = true;
            this.Close();
        }
        
        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
          
            
        }

        private void comboBox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_name.SelectedIndex > -1)
            {
                string string_connection = Form_login.sql_connect;
                using (SqlConnection conn = new SqlConnection(string_connection))
                {
                    int id = Convert.ToInt32(comboBox1.SelectedValue);
                    conn.Open();
                    SqlCommand comand = new SqlCommand("SELECT [id_unit] From [products] where [id_category]=" + id, conn);
                    
                    SqlDataReader reader = comand.ExecuteReader();
                    while (reader.Read())
                    {
                        comboBox2.SelectedValue  = int.Parse(reader.GetValue(0).ToString().Trim());
                    }


                   

                }
               // comboBox2.SelectedValue = category;
            }
            else
            {

            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_name.Text = "";
            string string_connection = Form_login.sql_connect;
          
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                if (flag ==true)
                {
                    conn.Open();
                    int id = Convert.ToInt32(comboBox1.SelectedValue);
                    SqlCommand comand = new SqlCommand("SELECT [id], [name] From [products] where [id_category]=" + id, conn);//where [id_category]="+ comboBox1.SelectedValue
                    List<products> employee_list2 = new List<products>();
                    SqlDataReader reader = comand.ExecuteReader();
                    employee_list2.Clear();
                    while (reader.Read())
                    {
                        employee_list2.Add(new products() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                    }


                    comboBox_name.DataSource = employee_list2;
                    comboBox_name.DisplayMember = "name";
                    comboBox_name.ValueMember = "id";
                    
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox_patronymic_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_name_Leave(object sender, EventArgs e)
        {
            if (comboBox_name.SelectedIndex > -1)
            {
                comboBox2.Enabled = false;
                //comboBox2.Text = 
            }
            else
            {
                comboBox2.Enabled = true;
            }

        }
    }
}
