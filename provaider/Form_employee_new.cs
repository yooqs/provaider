using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace provaider
{
    public partial class Form_employee_new : Form
    {
        public Form_employee_new()
        {
            InitializeComponent();
        }
        public class category
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        private void post_load ()
        {
            string string_connection = Properties.Resources.conn_string;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [name] From [post]", conn);
                List<category> employee_list = new List<category>();
                employee_list.Clear();
                SqlDataReader reader = comand.ExecuteReader();

                
                while (reader.Read())
                {
                    employee_list.Add(new category() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                }


                comboBox_post.DataSource = employee_list;
                comboBox_post.DisplayMember = "name";
                comboBox_post.ValueMember = "id";

            }
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
        private void Form_employee_new_Load(object sender, EventArgs e)
        {
            Textbox_city_update();
            post_load();

        }

        private void comboBox_street_Enter(object sender, EventArgs e)
        {
            Textbox_street_update();
        }

        private void button_user_new_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = provaider.Properties.Resources.conn_string;

                //заполнение таблицы сотруднки
                SqlCommand command = new SqlCommand("INSERT INTO [employee]  VALUES(@last_name, @first_name, @patronymic, @telephone, @city, @street, @house, @flat, @passport_series,convert(varchar, convert(datetime, '" + textBox_birth_date.Text + "', 104), 121), convert(varchar, convert(datetime, '" + date_conclusion.Text + "', 104), 121), @passport_number,@id_post,@login,@password,@admin)", conn);
                command.Parameters.AddWithValue("@last_name", textBox_first_name.Text);
                command.Parameters.AddWithValue("@first_name", textBox_middle_name.Text);
                command.Parameters.AddWithValue("@patronymic", textBox_last_name.Text);
                command.Parameters.AddWithValue("@telephone", maskedTextBox1.Text);
                command.Parameters.AddWithValue("@city", comboBox_city.Text);
                command.Parameters.AddWithValue("@street", comboBox_street.Text);
                command.Parameters.AddWithValue("@house", textBox_house.Text);
                command.Parameters.AddWithValue("@flat", textBox_flat.Text);
                command.Parameters.AddWithValue("@passport_series", textBox_passport_series.Text);
                command.Parameters.AddWithValue("@passport_number", textBox_passport_number.Text);
                command.Parameters.AddWithValue("@id_post", comboBox_post.SelectedValue);
                command.Parameters.AddWithValue("@login", textBox_login.Text);
                command.Parameters.AddWithValue("@password", textBox_password.Text);
                command.Parameters.AddWithValue("@admin", (bool)checkBox_admin.Checked );
                //@id_post,@login,@password,@admin
                //command.Parameters.AddWithValue("@birth_date", textBox_birth_date.Text);


                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
                Form_employee.Data_table_employee_load = true;
            }

            //закрытие и обновление формы
            Form_customers.Data_table_load = true;
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox_street_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_flat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_contract_print_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_passport_number_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox_passport_series_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox_birth_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox_house_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_middle_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_city_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void date_conclusion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox_house_Leave(object sender, EventArgs e)
        {
            
                /**
                 zapros = "https://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false or false&language=ru&key=" + provaider.Properties.Resources.api_string;
                url = string.Format(zapros, Uri.EscapeDataString("Острогожск Ленина 23"));
                request = (HttpWebRequest)WebRequest.Create(url);
                response = request.GetResponse();
                dataStream = response.GetResponseStream();
                reader = new StreamReader(dataStream);
                responsreader = reader.ReadToEnd();
                response.Close();
                //парсинг
                xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(responsreader);
                label1.Text = xmlDoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText;
                if (xmlDoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
                {
                    XmlNodeList nodes = xmlDoc.SelectNodes("//duration");
                    //координаты
                    double latitude = 0.0;
                    double longtude = 0.0;
                    foreach (XmlNode node in nodes)
                    {
                        latitude = XmlConvert.ToDouble(node.SelectSingleNode("lat").InnerText.ToString());
                        longtude = XmlConvert.ToDouble(node.SelectSingleNode("lng").InnerText.ToString());
                    }
                    // }
                    //   catch { }
                }
                **/
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
