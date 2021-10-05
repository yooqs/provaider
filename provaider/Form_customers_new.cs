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
    public partial class Form_customers_new : Form
    {
        public Form_customers_new()
        {
            InitializeComponent();
        }
        // обновление родительской формы
        
        public async void Textbox_street_update()
        {
            comboBox_street.Items.Clear();
            //получение id города

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = provaider.Properties.Resources.conn_string;
            await conn.OpenAsync();
            SqlCommand cmd = new SqlCommand("SELECT [id] FROM [city] WHERE [name]='" + comboBox_city.Text + "'", conn);
            SqlDataReader reader = await cmd.ExecuteReaderAsync();
            reader.ReadAsync();
            if (reader.HasRows)
            {
                int id = (int)reader.GetValue(0);
                reader.Close();
                //заполнение текст бокса

                cmd.CommandText = "SELECT [name] FROM [street] WHERE [id_city]='" + id + "'";


                using (reader = await cmd.ExecuteReaderAsync())
                {

                    
                    while (reader.Read())
                    {

                        string row = reader.GetValue(0).ToString().Trim();



                        comboBox_street.Items.Add(row);
                    }
                    reader.Close();
                }
            }
            conn.Close();
        }
        public void Textbox_city_update()
        {

            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand("SELECT [name] FROM [city] ", conn);

            conn.ConnectionString = provaider.Properties.Resources.conn_string;
            conn.Open();




            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox_city.Items.Clear();
                while (reader.Read())
                {

                    string row = reader.GetValue(0).ToString().Trim();



                    comboBox_city.Items.Add(row);
                }
                reader.Close();
            }
            conn.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void Form_customers_new_Activated(object sender, EventArgs e)
        {
            Textbox_city_update();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
           
        

        }

        private void button_user_new_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = provaider.Properties.Resources.conn_string;






                //заполнение таблицы сотруднки
                SqlCommand command = new SqlCommand("INSERT INTO [contract]  VALUES(@last_name, @first_name, @patronymic, @telephone, @city, @street, @house,convert(varchar, convert(datetime, '" + textBox_birth_date.Text + "', 104), 121), @flat, @passport_series, @passport_number, convert(varchar, convert(datetime, '" + textBox_birth_date.Text + "', 104), 121))", conn);
                command.Parameters.AddWithValue("@last_name", textBox_first_name.Text);
                command.Parameters.AddWithValue("@first_name", textBox_middle_name.Text);
                command.Parameters.AddWithValue("@patronymic", textBox_last_name.Text);
                command.Parameters.AddWithValue("@telephone", textBox_telephone.Text);
                command.Parameters.AddWithValue("@city", comboBox_city.Text);
                command.Parameters.AddWithValue("@street", comboBox_street.Text);
                command.Parameters.AddWithValue("@house", textBox_house.Text);
                command.Parameters.AddWithValue("@flat", textBox_flat.Text);
                command.Parameters.AddWithValue("@passport_series", textBox_passport_series.Text);
                command.Parameters.AddWithValue("@passport_number", textBox_passport_number.Text);
                command.Parameters.AddWithValue("@birth_date", textBox_birth_date.Text);


                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }

            //закрытие и обновление формы
            Form_customers.Data_table_load = true;
            this.Close();
           
        }

        private void comboBox_street_Enter(object sender, EventArgs e)
        {
            Textbox_street_update();
        }

        private void Form_customers_new_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
    
}
