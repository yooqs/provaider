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
    public partial class Form_application_conf_edid : Form
    {
        int id_p;
        int id_w;
        int id_u;
        int id_c;
        string name;
        string volume;
        public Form_application_conf_edid(int id_p,int id_w,int id_u, int id_c,string name, string volume)
        {
            InitializeComponent();
            this.id_p= id_p;
            this.id_w= id_w;
            this.id_u= id_u;
            this.id_c= id_c;
            this.name = name;
            this.volume = volume;
        }
        class products
        {
            public int id { set; get; }
            public string name { get; set; }
        }

        private void Form_application_conf_edid_Load(object sender, EventArgs e)
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
                

            }
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
                
            }
            //
            comboBox_name.Text = name;
            comboBox2.SelectedValue =id_c;
            textBox_volume.Text = volume;
            comboBox1.SelectedValue = id_u;


        }

        private void button_user_new_Click(object sender, EventArgs e)
        {
            if (textBox_volume.Text==""||Convert.ToInt32(textBox_volume.Text)> Convert.ToInt32(volume) || Convert.ToInt32(textBox_volume.Text) <=0 )
            {
                MessageBox.Show("Проверьте количество товара","Ошибка");
                
            }
            else if (Convert.ToInt32(textBox_volume.Text) == Convert.ToInt32(volume))
            {
                this.Close();
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
                {
                    conn.Open();
                    
                    int volumes = Convert.ToInt32(Convert.ToInt32(volume) - Convert.ToInt32(textBox_volume.Text));
                    SqlCommand command = new SqlCommand("UPDATE [products_warehouse] SET [volume] = [volume] + " + volumes + " where [id] = " + id_w, conn);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
                using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
                {
                    conn.Open();
                    
                    int volumes = Convert.ToInt32(Convert.ToInt32(volume) - Convert.ToInt32(textBox_volume.Text));
                    SqlCommand command = new SqlCommand("UPDATE [products_purchase] SET [volume] = [volume] - " + volumes + " where [id] = " + id_p, conn);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }
                this.Close();
                Form_application_confirmation.flag = true;
            }
        }
    }
}
