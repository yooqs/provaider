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
    public partial class Form_warehouse_edit : Form
    {
        int id;
        string name;
        int categorys;
        int unit;
        string volume;
        decimal price;
        public Form_warehouse_edit(int id,string name, int category, int unit, string volume,decimal price)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
            this.categorys = category;
            this.unit = unit;
            this.volume = volume;
            this.price = price;
        }
        class products
        {
            public int id { set; get; }
            public string name { get; set; }
        }

        int category;
        Boolean flag = false;
        private void Form_warehouse_edit_Load(object sender, EventArgs e)
        {
           

            
            
           
            string string_connection = Properties.Resources.conn_string;
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
            comboBox_name.Text = name;
            comboBox1.SelectedValue = categorys;
            comboBox2.SelectedValue = unit;
            textBox_volume.Text = volume;
            textBox_price.Text = Convert.ToString(price);
        }

        private void button_user_new_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection(provaider.Properties.Resources.conn_string))
            {
                //conn.Open();


                SqlCommand command = new SqlCommand("UPDATE [products_warehouse] SET  volume = @volume,price = @price where [id] = " + id, conn);
                //command.Parameters.AddWithValue("@id_products", comboBox_name.SelectedValue);
                command.Parameters.AddWithValue("@volume", textBox_volume.Text);
                command.Parameters.AddWithValue("@price", textBox_price.Text);
                
                


                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            Form_warehouse.flag_table_update = true;
            this.Close();

        }
    }
}
