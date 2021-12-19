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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provaider
{
    public partial class Form_maps : Form
    {
        public Form_maps()
        {
            //TopMost = true;
            InitializeComponent();
            
        }
        private void opisanie_update (string id)
        {
            String sql;
            string[] table_app;
            table_app = new string[15];
            using (SqlConnection conn = new SqlConnection())
            {
                //sql = "Select [applications].[id],[applications].[description],[applications].[date_receipt],[contract].[last_name],[contract].[first_name],[contract].[patronymic],[contract].[telephone],[contract].[city],[contract].[street],[contract].[house],[contract].[flat],[employee].[last_name],[employee].[first_name],[employee].[patronymic],[type_application].[name] FROM  [contract] JOIN [applications] ON [contract].[id] =  [applications].[id_contract]  JOIN[employee] ON [employee].[id] =  [applications].[id_employee] JOIN[type_application] ON[type_application].[id] =  [applications].[type]  where [status] = 'Выполняется'";
                sql = "Select [applications].[id],[applications].[description],FORMAT([applications].[date_receipt], 'MM/dd/yyyy hh:mm:ss' ),[contract].[last_name],[contract].[first_name],[contract].[patronymic],[contract].[telephone],[contract].[city],[contract].[street],[contract].[house],[contract].[flat],[employee].[last_name],[employee].[first_name],[employee].[patronymic],[type_application].[name],[applications].status FROM  [applications] JOIN [contract] ON [contract].[id] =  [applications].[id_contract] JOIN emp_app ON applications.id = emp_app.id_app JOIN[employee] ON employee.id = emp_app.id_emp  JOIN[type_application] ON[type_application].[id] =  [applications].[type] where [applications].[id]=" + id;
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.ConnectionString = Form_login.sql_connect;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int id_application = -1;
                //string[] row;
                if (reader.Read())
                {
                    label1.Text = "Заявка № " +reader.GetValue(0).ToString().Trim();
                    textBox_last_name.Text = reader.GetValue(3).ToString().Trim() + " " + reader.GetValue(4).ToString().Trim() + " " + reader.GetValue(5).ToString().Trim();
                    maskedTextBox1.Text = reader.GetValue(6).ToString().Trim();
                    textBox2.Text = reader.GetValue(7).ToString().Trim() + ", " + reader.GetValue(8).ToString().Trim() + ", " + reader.GetValue(9).ToString().Trim() + ", " + reader.GetValue(10).ToString().Trim();
                    
                    textBox_description.Text = reader.GetValue(1).ToString().Trim();
                    textBox1.Text = reader.GetValue(11).ToString().Trim() + " " + reader.GetValue(12).ToString().Trim() + " " + reader.GetValue(13).ToString().Trim();
                    textBox3.Text= reader.GetValue(14).ToString().Trim();
                   



                    id_application = Convert.ToInt32(reader.GetValue(0).ToString().Trim());
                }

                while (reader.Read())
                {
                    if (Convert.ToInt32(reader.GetValue(0)) == id_application)
                    {
                        textBox1.Text += "\r\n" + reader.GetValue(11).ToString().Trim() + " " + reader.GetValue(12).ToString().Trim() + " " + reader.GetValue(13).ToString().Trim();

                    }
                    

                } }
            }
        private void marker_update ()
        {
            GMapMarker marker = new GMarkerGoogle(new PointLatLng(39.923518, 116.539009), GMarkerGoogleType.blue_pushpin);
            using (SqlConnection conn = new SqlConnection())
            {
                //sql = "Select [applications].[id],[applications].[description],[applications].[date_receipt],[contract].[last_name],[contract].[first_name],[contract].[patronymic],[contract].[telephone],[contract].[city],[contract].[street],[contract].[house],[contract].[flat],[employee].[last_name],[employee].[first_name],[employee].[patronymic],[type_application].[name] FROM  [contract] JOIN [applications] ON [contract].[id] =  [applications].[id_contract]  JOIN[employee] ON [employee].[id] =  [applications].[id_employee] JOIN[type_application] ON[type_application].[id] =  [applications].[type]  where [status] = 'Выполняется'";
                string sql = "Select [contract].[latitude],[contract].[longtude], [applications].[id],[applications].[description],[contract].[last_name],[contract].[first_name],[contract].[patronymic],[contract].[telephone],[contract].[city],[contract].[street],[contract].[house],[contract].[flat],[employee].[last_name],[employee].[first_name],[employee].[patronymic],[type_application].[name],[applications].status FROM  [applications] JOIN[employee] on [employee].[id]=[applications].[id_employee]  JOIN [contract] ON [contract].[id] =  [applications].[id_contract]  JOIN[type_application] ON[type_application].[id] =  [applications].[type]     where [status] = 'Выполнение'  OR [status] ='Ожидание'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.ConnectionString = Form_login.sql_connect;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int id_application = -1;
                //string[] row;

                GMapOverlay markers_green = new GMapOverlay("markers_green");
                GMapOverlay markers_yellow = new GMapOverlay("markers_yellow");
                while (reader.Read())
                {

                    Double lat = Math.Round(Convert.ToDouble(reader.GetValue(0).ToString().Trim(), CultureInfo.InvariantCulture), 6);
                    Double lon = Math.Round(Convert.ToDouble(reader.GetValue(1).ToString().Trim(), CultureInfo.InvariantCulture), 6);

                  
                  
                    // Создаем метку, устанавливаем позицию и стиль
                    // GMapMarker marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(adress.lat), Convert.ToDouble(adress.lon)), GMarkerGoogleType.blue_pushpin);
                    if (reader.GetValue(16).ToString().Trim() == "Выполнение")
                    {
                        GMapMarker markerd = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.green_dot);
                        markerd.ToolTipText = reader.GetValue(3).ToString().Trim() + "\n" + reader.GetValue(4).ToString().Trim() + " " + reader.GetValue(5).ToString().Trim() + " " + reader.GetValue(6).ToString().Trim();
                        markerd.ToolTip.Fill = new SolidBrush(Color.FromArgb(100, Color.Black));
                        markerd.ToolTip.Foreground = Brushes.White;
                        markerd.ToolTip.TextPadding = new Size(20, 20);
                        // Добавляем маркер к слою
                        markerd.Tag = reader.GetValue(2).ToString().Trim();
                        markers_green.Markers.Add(markerd);
                        // Добавляем слой на карту
                        
                    }
                    else
                    {
                        GMapMarker markerd = new GMarkerGoogle(new PointLatLng(lat, lon), GMarkerGoogleType.yellow_dot);
                        markerd.ToolTipText = reader.GetValue(3).ToString().Trim() + "\n" + reader.GetValue(4).ToString().Trim() + " " + reader.GetValue(5).ToString().Trim() + " " + reader.GetValue(6).ToString().Trim();
                        markerd.ToolTip.Fill = new SolidBrush(Color.FromArgb(100, Color.Black));
                        markerd.ToolTip.Foreground = Brushes.White;
                        markerd.ToolTip.TextPadding = new Size(20, 20);
                        // Добавляем маркер к слою
                        markerd.Tag = reader.GetValue(2).ToString().Trim();
                        markers_yellow.Markers.Add(markerd);

                        // Добавляем слой на карту
                       
                    }
                    this.gMapControl1.Overlays.Add(markers_green);
                    this.gMapControl1.Overlays.Add(markers_yellow);



                }
            }
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
            GMapOverlay markers_red = new GMapOverlay("markers_red");
             
        }

        private void Form_maps_Load(object sender, EventArgs e)
        {
            marker_update();
            panel1.Location = new Point(this.Width - button1.Width - 15, 29);
            flag_panel = false;
            button1.Text = "Открыть";

        }
        Boolean flag_panel= true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag_panel == true)
            {
               // panel1.Width = button1.Width;
                panel1.Location = new Point(this.Width - button1.Width - 15, 29);
                flag_panel = false;
                button1.Text = "Открыть";
            }
            else
            {
            panel1.Location = new Point(this.Width - panel1.Width -10, 29);
            button1.Text = "Закрыть";
            flag_panel = true;
            }
            //panel1.Dock(Right);

        }

        private void gMapControl1_OnMarkerClick(GMapMarker item, MouseEventArgs e)
        {
            //MessageBox.Show(String.Format("Маркер: был нажат " +item.ToolTipText));
          //  MessageBox.Show(String.Format("Маркер: был нажат "+ Convert.ToString((string)item.Tag)));
            opisanie_update(Convert.ToString((string)item.Tag));


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void date_receipt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {

                 gMapControl1.Overlays.Where(r => r.Id == "markers_green").FirstOrDefault().IsVisibile = true;
               // gMapControl1.Overlays[3].IsVisibile = true;
               // gMapControl1.Overlays[2].IsVisibile = true;


            }
            else
            {

                //
                gMapControl1.Overlays.Where(r => r.Id == "markers_green").FirstOrDefault().IsVisibile = false;
              //  gMapControl1.Overlays[3].IsVisibile = false;
              //  gMapControl1.Overlays[2].IsVisibile = false;
            }
           
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
               // gMapControl1.Overlays[0].IsVisibile = true;
                gMapControl1.Overlays.Where(r => r.Id == "markers_yellow").FirstOrDefault().IsVisibile = true;


            }
            else
            {
                gMapControl1.Overlays.Where(r => r.Id == "markers_yellow").FirstOrDefault().IsVisibile = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                // gMapControl1.Overlays[0].IsVisibile = true;
                TopMost = true;


            }
            else
            {
                TopMost = false;
            }
        }
    }
}
