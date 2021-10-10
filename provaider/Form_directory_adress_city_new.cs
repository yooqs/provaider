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
    public partial class Form_directory_adress_city_new : Form
    {
        public Form_directory_adress_city_new()
        {
            InitializeComponent();
        }

        private void Form_directory_adress_city_new_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connect = provaider.Properties.Resources.conn_string;
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();   // открываем подключение

                SqlCommand comand = new SqlCommand("INSERT INTO [city] VALUES (@city)", conn);
                comand.Parameters.AddWithValue("@city", textBox_city.Text);
                comand.ExecuteNonQuery();
                Form_directory_adress.update_table_city = true;
                this.Close();
                

            }
        }
    }
}
