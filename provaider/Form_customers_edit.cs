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
    public partial class Form_customers_edit : Form
    {
        public int id;
        public Form_customers_edit(int id)
        {
            InitializeComponent();
            this.id = id;
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
            sql = "SELECT * From [contract] Where [id] ="+id;
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.ConnectionString = provaider.Properties.Resources.conn_string;
            conn.Open();
            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
            {
                while (reader.Read())
                {
                    row  = new string[] {reader.GetValue(0).ToString().Trim(), //last_name
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
                                    reader.GetValue(15).ToString().Trim(),
                                    reader.GetValue(16).ToString().Trim(),
                    };
                    textBox_last_name.Text = row[1];
                    textBox_first_name.Text = row[2];
                    textBox_patronymic.Text = row[3];
                    maskedTextBox1.Text = row[4];
                    comboBox_city.Text = row[5];
                    comboBox_street.Text = row[6];
                    textBox_house.Text = row[7];
                    textBox_birth_date.Value = Convert.ToDateTime(row[8]);
                    textBox_flat.Text = row[9];
                    textBox_passport_series.Text = row[10];
                    textBox_passport_number.Text = row[11];
                    date_conclusion.Value = Convert.ToDateTime(row[12]);
                    textBox1.Text = row[13];
                    maskedTextBox3.Text = row[14];



                }
                reader.Close();
            }
            conn.Close();

            //обновление
            Form_customers.Data_table_load = true;
            
            
        }
        private void button_user_new_Click(object sender, EventArgs e)
        {
            double latitude = 0.0;
            double longtude = 0.0;
            string zapros = "https://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false or false&language=ru&key=" + provaider.Properties.Resources.api_string;
            string url = string.Format(zapros, Uri.EscapeDataString("Воронежская область" + comboBox_city.Text + " " + comboBox_street.Text + " " + textBox_house.Text));
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
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
            SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Дмитрий\Desktop\1234\basa.mdf;Integrated Security=True;Connect Timeout=30";
            conn.ConnectionString = Properties.Resources.conn_string;


            
            SqlCommand command = new SqlCommand("UPDATE [contract] SET last_name = @last_name, first_name = @first_name,patronymic = @patronymic, telephone = @telephone, city = @city,street = @street, house = @house,data_birth = convert(varchar, convert(datetime, '" + textBox_birth_date.Text + "', 104), 121), flat = @flat,passport_series = @passport_series, passport_number = @passport_number, date_conclusion = convert(varchar, convert(datetime, '" + date_conclusion.Text + "', 104), 121),latitude=@latitude,longtude=@longtude,distance=@distance,time_before=convert(varchar, convert(time, '" + maskedTextBox3.Text + "', 104), 121) where [id] = " + id, conn);
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
            //command.Parameters.AddWithValue("@birth_date", textBox_birth_date.Text);


            command.Connection.Open();
            command.ExecuteNonQuery();


            command.Connection.Close();


            this.Close();
        }

        private async void Form_customers_edit_Load(object sender, EventArgs e)
        {
            await date_contract_loadAsync();
            Textbox_city_update();
        }

        private void textBox_middle_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_city_Leave(object sender, EventArgs e)
        {
            Textbox_street_update();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int value;
        string text;
        int value2;
        string text2;

        private void textBox_house_Leave(object sender, EventArgs e)
        {
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
                if (value > 60)
                {
                    TS = new TimeSpan(value / 60 / 60, Convert.ToInt32(Math.Floor((double)value % 3600 / 60)), 0);
                }
                else
                {
                    TS = new TimeSpan(0, 1, 0);
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
                maskedTextBox3.Text = TS.ToString() + " " + value;

                textBox1.Text = Convert.ToString(value2);


            }
        }
    }
}
