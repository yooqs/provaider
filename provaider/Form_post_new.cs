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
    public partial class Form_post_new : Form
    {
        public Form_post_new()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connect = provaider.Properties.Resources.conn_string;
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();   // открываем подключение

                SqlCommand comand = new SqlCommand("INSERT INTO [post] VALUES (@post)", conn);
                comand.Parameters.AddWithValue("@post", textBox_city.Text);
                comand.ExecuteNonQuery();
                Form_directory_adress.update_table_post = true;
                this.Close();


            }
        }

        private void Form_post_new_Load(object sender, EventArgs e)
        {

        }

        private void textBox_city_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
