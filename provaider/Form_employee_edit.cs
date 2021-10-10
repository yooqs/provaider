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
    public partial class Form_employee_edit : Form
    {
        private int id;
        public Form_employee_edit(int id)
        {
            this.id = id;
            InitializeComponent();
        }
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
        private async Task date_contract_loadAsync()
        {
            string[] row;
            String sql;
            SqlConnection conn = new SqlConnection();
            sql = "SELECT * From [employee] Where [id] =" + id;
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.ConnectionString = provaider.Properties.Resources.conn_string;
            conn.Open();
            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
            {
                while (reader.Read())
                {
                    row = new string[] {reader.GetValue(0).ToString().Trim(), 
                                    reader.GetValue(1).ToString().Trim(),
                                    reader.GetValue(2).ToString().Trim(),
                                    reader.GetValue(3).ToString().Trim(),
                                    reader.GetValue(4).ToString().Trim(),
                                    reader.GetValue(5).ToString().Trim(),
                                    reader.GetValue(6).ToString().Trim(),
                                    reader.GetValue(7).ToString().Trim(),
                                    reader.GetValue(8).ToString().Trim(),
                                    reader.GetValue(9).ToString().Trim(),
                                    reader.GetValue(10).ToString().Trim(),
                                    reader.GetValue(11).ToString().Trim(),
                                    reader.GetValue(12).ToString().Trim(),
                    };
                    textBox_last_name.Text = row[1];
                    textBox_first_name.Text = row[2];
                    textBox_patronymic.Text = row[3];
                    maskedTextBox1.Text = row[4];
                    comboBox_city.Text = row[5];
                    comboBox_street.Text = row[6];
                    textBox_house.Text = row[7];
                    textBox_birth_date.Value = Convert.ToDateTime(row[10]);
                    textBox_flat.Text = row[8];
                    textBox_passport_series.Text = row[9];
                    textBox_passport_number.Text = row[12];
                    date_conclusion.Value = Convert.ToDateTime(row[11]);



                }
                reader.Close();
            }
            conn.Close();

            //обновление
            Form_customers.Data_table_load = true;

        }
        private void button_user_new_Click(object sender, EventArgs e)
        {
            
        }

        private void Form_employee_edit_Load(object sender, EventArgs e)
        {
            date_contract_loadAsync();
            Textbox_city_update();
        }

        private void comboBox_city_Leave(object sender, EventArgs e)
        {
            Textbox_street_update();
        }
    }
}
