using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using Newtonsoft.Json.Linq;
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

    public partial class Form_customers_new : Form
    {
        public Form_customers_new()
        {
            InitializeComponent();
        }
        public static class products
        {
            public static int id { get; set; }
            public static string id_product { get; set; }
            public static string category { get; set; }
            public static string  idenfity { get; set; }
            public static string volume { get; set; }
            public static string price { get; set; }
            public static string id_category { get; set; }
            public static string id_unit { get; set; }
            public static string name { get; set; }
            public static string unit { get; set; }
            public static string sum { get; set; }
            public static Boolean flag { get; set; } = false;

        }
        public static class product
        {
            public static int id { get; set; }
            public static string volume { get; set; }
            public static Boolean flag { get; set; } = false;


        }
        // обновление родительской формы
        public void table_update ()
        {
            if (products.flag == true)
            {
                dataGridView_employee.Rows.Add("",products.id_product,products.name, products.category, products.idenfity, products.volume, products.price, products.sum, products.id_category, products.id_unit, products.id);
            }
            products.flag = false;
        }
        public class adress_json
        {
            public int place_id { get; set; }
            public string licence { get; set; }
            public string osm_type { get; set; }
            public long osm_id { get; set; }
            public List<string> boundingbox { get; set; }
            public string lat { get; set; }
            public string lon { get; set; }
            public string display_name { get; set; }
            public string @class { get; set; }
            public string type { get; set; }
            public double importance { get; set; }
        }
        public class Path
        {
            public double distance { get; set; }
            public double weight { get; set; }
            public int time { get; set; }
            public int transfers { get; set; }
            public string snapped_waypoints { get; set; }
        }
        public class category
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        private void textbox_tariff_load(ComboBox comboBox)
        {


            string string_connection = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [name] From [tariff]", conn);
                List<category> employee_list = new List<category>();
                employee_list.Clear();
                SqlDataReader reader = comand.ExecuteReader();

                
                while (reader.Read())
                {
                    employee_list.Add(new category() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                }


                comboBox.DataSource = employee_list;
                comboBox.DisplayMember = "name";
                comboBox.ValueMember = "id";

            }
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void Form_customers_new_Activated(object sender, EventArgs e)
        {
            Textbox_city_update();
            table_update();

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {



        }
        string latitude;
        string longtude;
        int id_contract;
        int id_applications;
        private void button_user_new_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {


                using (SqlConnection conn = new SqlConnection())
                {

                    conn.ConnectionString = Form_login.sql_connect;






                    //заполнение таблицы сотруднки
                    SqlCommand command = new SqlCommand("INSERT INTO [contract] ([last_name],[first_name],[patronymic],[telephone],[city],[street],[house],[data_birth],[flat],[passport_series],[passport_number],[date_conclusion],[latitude],[longtude],[distance],[time_before],[id_tariff],[mac],[login_kab],[password_kab],[personal_account],[wifi_login],[wifi_password]) VALUES(@last_name, @first_name, @patronymic, @telephone, @city, @street, @house, convert(varchar, convert(datetime, '" + textBox_birth_date.Text + "', 104), 121), @flat, @passport_series, @passport_number, convert(varchar, convert(datetime, '" + date_conclusion.Text + "', 104), 121), @latitude, @longtude, @distance, convert(varchar, convert(time, '" + maskedTextBox3.Text + "', 104), 121), @tariff, @mac,@login_kab, @password_kab, @personal_account, @wifi_login, @wifi_password)", conn);
                    //@tariff, @mac,@login_kab, @password_kab, @personal_account, @wifi_login, @wifi_password
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
                    command.Parameters.AddWithValue("@distance", textBox1.Text);
                    command.Parameters.AddWithValue("@tariff", comboBox1.SelectedValue);
                    command.Parameters.AddWithValue("@mac", maskedTextBox4.Text);
                    command.Parameters.AddWithValue("@login_kab", textBox3.Text);
                    command.Parameters.AddWithValue("@password_kab", textBox4.Text);
                    command.Parameters.AddWithValue("@personal_account", textBox2.Text);
                    command.Parameters.AddWithValue("@wifi_login", textBox5.Text);
                    command.Parameters.AddWithValue("@wifi_password", textBox6.Text);



                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }

                //получение ид последней записи
                using (SqlConnection conn = new SqlConnection())
                {

                    conn.ConnectionString = Form_login.sql_connect;

                    SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT ('contract')", conn);
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        id_contract = Convert.ToInt32((string)reader.GetValue(0).ToString().Trim());
                    }

                    command.Connection.Close();
                }
                if (dataGridView_employee.Rows.Count > 0)
                {
                    using (SqlConnection conn = new SqlConnection())
                    {

                        conn.ConnectionString = Form_login.sql_connect;


                        string Sql = "INSERT INTO[user_products]([id_products],[id_contract],[volume],[identifier],[price])  VALUES "; //(@id_products, @id_contract, @volume, @identifier, @price)
                        if (dataGridView_employee.Rows.Count == 1)
                        {
                            for (int i = dataGridView_employee.Rows.Count; i > 0; i--)
                            {

                                Sql += " ((" + dataGridView_employee.Rows[i - 1].Cells[1].Value + "), (" + id_contract + "), (" + dataGridView_employee.Rows[i - 1].Cells[5].Value + "), (" + dataGridView_employee.Rows[i - 1].Cells[4].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[6].Value + "))";
                            }
                        }
                        else if (dataGridView_employee.Rows.Count > 0)
                        {
                            for (int i = dataGridView_employee.Rows.Count; i > 0; i--)
                            {

                                Sql += " ((" + dataGridView_employee.Rows[i - 1].Cells[1].Value + "), (" + id_contract + "), (" + dataGridView_employee.Rows[i - 1].Cells[5].Value + "), (" + dataGridView_employee.Rows[i - 1].Cells[4].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[6].Value + ")),";
                            }
                            // индекс последнего символа
                            int ind = Sql.Length - 1;
                            // вырезаем последний символ
                            Sql = Sql.Remove(ind);
                        }

                        //заполнение таблицы сотруднки
                        SqlCommand command = new SqlCommand(Sql, conn);




                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                    }
                    //заявка создание

                    using (SqlConnection conn = new SqlConnection())
                    {

                        conn.ConnectionString = Form_login.sql_connect;


                        DateTime date1 = DateTime.Now;
                        
                        string dat = Convert.ToString(DateTime.Now);

                        //convert(varchar, convert(datetime, '" + textBox_birth_date.Text + "', 104), 121)
                        //заполнение таблицы сотруднки
                        SqlCommand command = new SqlCommand("INSERT INTO [applications] ([status],[type],[description],[date_receipt],[id_contract],[id_employee]) VALUES(@status, @type, @description, '"+ date1.ToString("dd-MM-yyyy HH:mm:ss")+"', @id_contract, @id_employee)", conn);
                        //@tariff, @mac,@login_kab, @password_kab, @personal_account, @wifi_login, @wifi_password
                        command.Parameters.AddWithValue("@status", "Ожидание");
                        command.Parameters.AddWithValue("@type", 3);
                        command.Parameters.AddWithValue("@description", "Подключение к сети");
                        command.Parameters.AddWithValue("@id_contract", id_contract);
                        command.Parameters.AddWithValue("@id_employee", Form_login.id_maneger);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();
                    }

                    //id заявки
                    using (SqlConnection conn = new SqlConnection())
                    {

                        conn.ConnectionString = Form_login.sql_connect;

                        SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT ('applications')", conn);
                        command.Connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            id_applications = Convert.ToInt32((string)reader.GetValue(0).ToString().Trim());
                        }

                        command.Connection.Close();
                    }



                    if (dataGridView_employee.Rows.Count > 0)
                    {
                        using (SqlConnection conn = new SqlConnection())
                        {

                            conn.ConnectionString = Form_login.sql_connect;


                            string Sql = "INSERT INTO[products_purchase]([id_product],[id_applications],[price],[volume],[identifier],[id_sklad])  VALUES "; //(@id_products, @id_contract, @volume, @identifier, @price)
                            if (dataGridView_employee.Rows.Count == 1)
                            {
                                for (int i = dataGridView_employee.Rows.Count; i > 0; i--)
                                {

                                    Sql += " ((" + dataGridView_employee.Rows[i - 1].Cells[1].Value + "), (" + id_applications + "), (" + dataGridView_employee.Rows[i - 1].Cells[6].Value + "), (" + dataGridView_employee.Rows[i - 1].Cells[5].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[4].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[10].Value + "))";
                                }
                            }
                            else if (dataGridView_employee.Rows.Count > 0)
                            {
                                for (int i = dataGridView_employee.Rows.Count; i > 0; i--)
                                {

                                    Sql += " ((" + dataGridView_employee.Rows[i - 1].Cells[1].Value + "), (" + id_applications + "), (" + dataGridView_employee.Rows[i - 1].Cells[6].Value + "), (" + dataGridView_employee.Rows[i - 1].Cells[5].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[4].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[10].Value + ")),";
                                }
                                // индекс последнего символа
                                int ind = Sql.Length - 1;
                                // вырезаем последний символ
                                Sql = Sql.Remove(ind);
                            }

                            //заполнение таблицы сотруднки
                            SqlCommand command = new SqlCommand(Sql, conn);




                            command.Connection.Open();
                            command.ExecuteNonQuery();
                            command.Connection.Close();
                        }


                    }
                    string sql_emp_app;
                    if (dataGridView1.Rows.Count>0) {
                        using (SqlConnection conn = new SqlConnection())
                        {

                            conn.ConnectionString = Form_login.sql_connect;
                            sql_emp_app = "INSERT INTO [emp_app] ([id_app],[id_emp]) VALUES ("+id_applications+"," + Convert.ToString(dataGridView1.Rows[0].Cells[0].Value) +")";
                            for (int i = dataGridView1.Rows.Count-1; i > 1; i--)
                            {

                                sql_emp_app += ", (" + id_applications + "," + Convert.ToString(dataGridView1.Rows[i-1].Cells[0].Value) + ")";
                            }
                           
                            SqlCommand command = new SqlCommand(sql_emp_app, conn);                          
                            command.Connection.Open();
                            command.ExecuteNonQuery();
                            command.Connection.Close();


                        }
                    }



                    //закрытие и обновление формы
                    Form_menu.application_update = true;
                    Form_customers.Data_table_load = true;
                    this.Close();



                }

            }
             }
        class employee
        {
            public int id { get; set; }
            public string name { get; set; }

        }
        private void employe_load(ComboBox comboBox_employee)
        {
            string string_connection = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [last_name], [first_name], [patronymic] From [employee]", conn);
                List<employee> employee_list = new List<employee>();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    employee_list.Add(new employee() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() + " " + (string)reader.GetValue(2).ToString().Trim() + " " + (string)reader.GetValue(3).ToString().Trim() });
                }


                comboBox_employee.DataSource = employee_list;
                comboBox_employee.DisplayMember = "name";
                comboBox_employee.ValueMember = "id";
                Column9.DataSource = employee_list;
                Column9.DisplayMember = "name";
                Column9.ValueMember = "id";

            }
        }

        private void comboBox_street_Enter(object sender, EventArgs e)
        {
            Textbox_street_update();
        }

        private void Form_customers_new_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (checkBox1.Checked = true)
            {
                for (int i = dataGridView_employee.Rows.Count; i > 0; i--)
                {
                    int int_del = Convert.ToInt32(dataGridView_employee.Rows[i - 1].Cells[5].Value);
                    string string_connection = Form_login.sql_connect;
                    using (SqlConnection conn = new SqlConnection(string_connection))
                    {
                        conn.Open();
                        int id = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[10].Value);

                        SqlCommand command = new SqlCommand("UPDATE [products_warehouse] SET [volume] = [volume] + " + int_del + " where [id] = " + id, conn);

                        command.ExecuteNonQuery();


                        command.Connection.Close();

                    }
                }
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form_customers_new_Load(object sender, EventArgs e)
        {
            employe_load(comboBox2);
            textbox_tariff_load(comboBox1);
            

        }
        int value = 0;
        string text = "";
        int value2 = 0;
        string text2 = "";

        private void textBox_house_Leave(object sender, EventArgs e)
        {
            {






                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                //http://nominatim.openstreetmap.org/search.php?q=Острогожск%20ленина%2035&limit=1&format=json
                string zapros = "http://nominatim.openstreetmap.org/search.php?q={0}&limit=1&format=json";
                string url = string.Format(zapros, Uri.EscapeDataString("Воронежская область " + comboBox_city.Text + " " + comboBox_street.Text + " " + textBox_house.Text));
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 11_1_0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.182 Safari/537.36";
                
                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                string responsreader = reader.ReadToEnd();
                response.Close();
                responsreader = responsreader.Substring(1, responsreader.Length - 2);
                adress_json adress = Newtonsoft.Json.JsonConvert.DeserializeObject<adress_json>(responsreader);
                textBox1.Text = adress.lat + " " + adress.lon;
                latitude = adress.lat;
                longtude = adress.lon;
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                //https://graphhopper.com/api/1/route?point=50.858759,39.078589&point={adress.lat},{adress.lon}&profile=car&locale=ru&calc_points=false&key=c9c61c55-b10d-4a26-af02-f9e609466fcb
                zapros = $"http://graphhopper.com/api/1/route?point=50.858759,39.078589&point={adress.lat},{adress.lon}&profile=car&locale=ru&calc_points=false&key=c9c61c55-b10d-4a26-af02-f9e609466fcb";
                request = (HttpWebRequest)WebRequest.Create(zapros);
                request.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 11_1_0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/88.0.4324.182 Safari/537.36";
             
                response = request.GetResponse();
                dataStream = response.GetResponseStream();
                reader = new StreamReader(dataStream);
                responsreader = reader.ReadToEnd();
                response.Close();
                // responsreader = responsreader.Substring(1, responsreader.Length - 2);
                JObject o = JObject.Parse(responsreader);

                string str = Convert.ToString(o.SelectToken(@"$.paths"));
                str = str.Substring(1, str.Length - 2);
                Path Path2 = Newtonsoft.Json.JsonConvert.DeserializeObject<Path>(str.ToString());
                textBox1.Text = Convert.ToString(Math.Round((decimal)Path2.distance));
                value = Path2.time / 1000;


                TimeSpan TS;
                if (value > 60)
                {
                    TS = new TimeSpan(value / 60 / 60, Convert.ToInt32(Math.Floor((double)value % 3600 / 60)), 0);
                }
                else
                {
                    TS = new TimeSpan(0, 1, 0);
                }
                maskedTextBox3.Text = Convert.ToString(TS);
                Double lat = Math.Round(Convert.ToDouble(adress.lat, CultureInfo.InvariantCulture), 6);
                Double lon = Math.Round(Convert.ToDouble(adress.lon, CultureInfo.InvariantCulture), 6);
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
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_house_TextChanged(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            /* GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; //выбор подгрузки карты – онлайн или из ресурсов
             gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleMapProvider.Instance; //какой провайдер карт используется (в нашем случае гугл) 
             gMapControl1.MinZoom = 1; //минимальный зум
             gMapControl1.MaxZoom = 16; //максимальный зум
             gMapControl1.Zoom = 2; // какой используется зум при открытии
             gMapControl1.Position = new GMap.NET.PointLatLng(66.4169575018027, 94.25025752215694);// точка в центре карты при открытии (центр России)
             gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter; // как приближает (просто в центр карты или по положению мыши)
             gMapControl1.CanDragMap = true; // перетаскивание карты мышью
             gMapControl1.DragButton = MouseButtons.Left; // какой кнопкой осуществляется перетаскивание
             gMapControl1.ShowCenter = false; //показывать или скрывать красный крестик в центре
             gMapControl1.ShowTileGridLines = false; //показывать или скрывать тайлы
             */
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load_1(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked==true)
            {

           
            Form_applications_new_products_new form_Applications_New_Products_New = new Form_applications_new_products_new(1);
            form_Applications_New_Products_New.StartPosition = FormStartPosition.CenterScreen;
            form_Applications_New_Products_New.ShowDialog();

            }
            else
            {

            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                comboBox2.Enabled = true;
                dataGridView_employee.Rows.Clear();
            }
            else
            {
                comboBox2.Enabled = false;
                for (int i = dataGridView_employee.Rows.Count; i >0; i--)
                {
                    int int_del = Convert.ToInt32(dataGridView_employee.Rows[i-1].Cells[5].Value);
                    string string_connection = Form_login.sql_connect;
                    using (SqlConnection conn = new SqlConnection(string_connection))
                    {
                        conn.Open();
                        int id = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[10].Value);
                        
                        SqlCommand command = new SqlCommand("UPDATE [products_warehouse] SET [volume] = [volume] + " + int_del + " where [id] = " + id, conn);

                        command.ExecuteNonQuery();


                        command.Connection.Close();

                    }

                }
                dataGridView_employee.Rows.Clear();

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            string string_connection = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                int id = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[10].Value);
                int volume = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[5].Value);
                SqlCommand command = new SqlCommand("UPDATE [products_warehouse] SET [volume] = [volume] + " + volume+" where [id] = " + id, conn);
             
                


                


                command.ExecuteNonQuery();


                command.Connection.Close();

            }
            int ind = dataGridView_employee.SelectedCells[0].RowIndex;
            dataGridView_employee.Rows.RemoveAt(ind);
          
        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
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

        private void textBox_patronymic_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox_flat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_street_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void date_conclusion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            Button temp = new Button();
            temp.Text = "Пример";
            temp.Width = b.Width;
            //Размещаем ее правее (на 10px) кнопки, на которую мы нажали
            temp.Location = new Point(b.Location.X + b.Width + 10, b.Location.Y);
            this.Controls.Add(temp);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridView1.Rows.Count>0)
            {
                
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
          comboBox2.Text= Convert.ToString(dataGridView1.Rows[1].Cells[0].Value);
        }
    }

}
