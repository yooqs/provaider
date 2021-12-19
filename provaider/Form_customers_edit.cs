using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
            conn.ConnectionString = Form_login.sql_connect;
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

            conn.ConnectionString = Form_login.sql_connect;
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

            conn.ConnectionString = Form_login.sql_connect;
            conn.Open();
            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
            {
                while (reader.Read())
                {
                    row  = new string[] {reader.GetValue(0).ToString().Trim(), 
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
                                    reader.GetValue(13).ToString().Trim(),
                                    reader.GetValue(14).ToString().Trim(),
                                    reader.GetValue(15).ToString().Trim(),
                                    reader.GetValue(16).ToString().Trim(),
                                    reader.GetValue(17).ToString().Trim(),
                                    reader.GetValue(18).ToString().Trim(),
                                    reader.GetValue(19).ToString().Trim(),
                                    reader.GetValue(20).ToString().Trim(),
                                    reader.GetValue(21).ToString().Trim(),
                                    reader.GetValue(22).ToString().Trim(),
                                    reader.GetValue(23).ToString().Trim(),
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
                    textBox1.Text = row[15];
                    maskedTextBox3.Text = row[16];
                    textBox2.Text= row[21];
                    maskedTextBox4.Text= row[18];
                    textBox3.Text = row[19];
                    textBox4.Text = row[20];
                    textBox5.Text = row[22];
                    textBox6.Text = row[23];



                    //
                    Double lat = Math.Round(Convert.ToDouble(row[13], CultureInfo.InvariantCulture), 6);
                    Double lon = Math.Round(Convert.ToDouble(row[14], CultureInfo.InvariantCulture), 6);
                    GMapOverlay markers = new GMapOverlay("markers");
                    // Создаем метку, устанавливаем позицию и стиль
                    // GMapMarker marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(adress.lat), Convert.ToDouble(adress.lon)), GMarkerGoogleType.blue_pushpin);
                    GMapMarker marker = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.blue_pushpin);
                    // Добавляем маркер к слою
                    markers.Markers.Add(marker);
                    // Добавляем слой на карту
                    this.gMapControl1.Overlays.Add(markers);


                    gMapControl1.Position = new GMap.NET.PointLatLng(lat, lon);
                    gMapControl1.Zoom = 17;


                }
                reader.Close();
            }
            conn.Close();

            //обновление
            Form_customers.Data_table_load = true;
            
            
        }
        private void button_user_new_Click(object sender, EventArgs e)
        {
          
            SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Дмитрий\Desktop\1234\basa.mdf;Integrated Security=True;Connect Timeout=30";
            conn.ConnectionString = Form_login.sql_connect;


            
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
          //  command.Parameters.AddWithValue("@latitude", );
          //  command.Parameters.AddWithValue("@longtude", );
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
           


            
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //выбор подгрузки карты – онлайн или из ресурсов
            gMapControl1.MapProvider = GMap.NET.MapProviders.CzechMapProvider.Instance; //какой провайдер карт используется (в нашем случае гугл) 
            gMapControl1.MinZoom = 1; //минимальный зум
            gMapControl1.MaxZoom = 20; //максимальный зум
            gMapControl1.Zoom = 12; // какой используется зум при открытии
            gMapControl1.Position = new GMap.NET.PointLatLng(50.85484, 39.06328);// точка в центре карты при открытии (центр России)
            gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)
            gMapControl1.CanDragMap = true; // перетаскивание карты мышью
            gMapControl1.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
            gMapControl1.ShowCenter = false; //показывать или скрывать красный крестик в центре
            gMapControl1.ShowTileGridLines = false;
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Button button_employee = new Button();
            Button b = (Button)sender;
            button_employee.Text = "Пример";
            button_employee.Width = b.Width;
            //Размещаем ее правее (на 10px) кнопки, на которую мы нажали
            button_employee.Location = new Point(b.Location.X + b.Width + 10, b.Location.Y);
        }
    }
}
