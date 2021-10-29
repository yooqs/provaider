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
            double latitude = 0.0;
            double longtude = 0.0;
            string zapros = "https://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false or false&language=ru&key=" + provaider.Properties.Resources.api_string;
            string url = string.Format(zapros, Uri.EscapeDataString("Воронежская область" + comboBox_city.Text + " " + comboBox_street.Text + " " + textBox_house.Text));
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream  dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responsreader = reader.ReadToEnd();
                response.Close();
            //парсинг
            XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(responsreader);
                label1.Text = xmlDoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText;
                if (xmlDoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
                {
                    XmlNodeList nodes = xmlDoc.SelectNodes("//location");
                    //координаты
                    
                    foreach (XmlNode node in nodes)
                    {
                        latitude = XmlConvert.ToDouble(node.SelectSingleNode("lat").InnerText.ToString());
                        longtude = XmlConvert.ToDouble(node.SelectSingleNode("lng").InnerText.ToString());
                    }
                    // }
                    //   catch { }
                }
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = provaider.Properties.Resources.conn_string;






                //заполнение таблицы сотруднки
                SqlCommand command = new SqlCommand("INSERT INTO [contract]  VALUES(@last_name, @first_name, @patronymic, @telephone, @city, @street, @house,convert(varchar, convert(datetime, '" + textBox_birth_date.Text + "', 104), 121), @flat, @passport_series, @passport_number, convert(varchar, convert(datetime, '" + date_conclusion.Text + "', 104), 121),@latitude,@longtude,@distance,convert(varchar, convert(time, '" + maskedTextBox3.Text + "', 104), 121))", conn);
                command.Parameters.AddWithValue("@last_name", textBox_last_name.Text);
                command.Parameters.AddWithValue("@first_name", textBox_first_name.Text);
                command.Parameters.AddWithValue("@patronymic", textBox_patronymic.Text);
                command.Parameters.AddWithValue("@telephone", maskedTextBox1.Text);
                command.Parameters.AddWithValue("@city", comboBox_city.Text);
                command.Parameters.AddWithValue("@street", comboBox_street.Text);
                command.Parameters.AddWithValue("@house", textBox_house.Text);
                command.Parameters.AddWithValue("@flat", textBox_flat.Text);
                command.Parameters.AddWithValue("@passport_series", textBox_passport_series.Text);
                command.Parameters.AddWithValue("@passport_number", textBox_passport_number.Text);
                command.Parameters.AddWithValue("@latitude", latitude);
                command.Parameters.AddWithValue("@longtude", longtude);
                command.Parameters.AddWithValue("@distance", value2); 
               


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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form_customers_new_Load(object sender, EventArgs e)
        {

        }
        int value = 0;
        string text = "";
        int value2 = 0;
        string text2 = "";
        private void textBox_house_Leave(object sender, EventArgs e)
        {
            {
                //  try
                //  {
                string zapros = "https://maps.googleapis.com/maps/api/distancematrix/xml?origins={0}&destinations={1}&mode=driving&key=" + provaider.Properties.Resources.api_string;
                string destinations = "Воронежская область" + comboBox_city.Text + " " + comboBox_street.Text + " " + textBox_house.Text;
                string origins = "Воронежская область Острогожск Ленина 35";
                string url = string.Format(zapros, Uri.EscapeDataString(destinations), Uri.EscapeDataString(origins));
                // textBox1.Text = url;
                //url = string.Format(zapros, Uri.EscapeDataString(origins));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responsreader = reader.ReadToEnd();
                response.Close();
                //парсинг
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(responsreader);
                // label1.Text = xmlDoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText;
                if (xmlDoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
                {
                    XmlNodeList nodes = xmlDoc.SelectNodes("//duration");

                    
                    //double longtude = 0.0;
                    foreach (XmlNode node in nodes)
                    {
                        value = Convert.ToInt32(node.SelectSingleNode("value").InnerText.ToString());
                        text = node.SelectSingleNode("text").InnerText.ToString();
                        //longtude = XmlConvert.ToDouble(node.SelectSingleNode("lng").InnerText.ToString());
                    }
                    TimeSpan TS;
                    if (value > 60) { 
                         TS = new TimeSpan(value / 60 / 60, Convert.ToInt32(Math.Floor((double)value % 3600 / 60)), 0); 
                    }
                    else
                    {
                        TS = new TimeSpan(0,1,0);
                    }
                    nodes = xmlDoc.SelectNodes("//distance");

                    
                    //double longtude = 0.0;
                    foreach (XmlNode node in nodes)
                    {
                        value2 = Convert.ToInt32(node.SelectSingleNode("value").InnerText.ToString());
                        text2 = node.SelectSingleNode("text").InnerText.ToString();
                        //longtude = XmlConvert.ToDouble(node.SelectSingleNode("lng").InnerText.ToString());
                    }
                    // Console.WriteLine(TS.ToString());

                    // text = value / 60 / 60 + ":" + Math.Floor((double)value % 3600 / 60);
                    maskedTextBox3.Text = TS.ToString()+" "+ value;
                    
                    textBox1.Text = Convert.ToString(value2);


                }
                
                
            }
        }
    }
    
}
