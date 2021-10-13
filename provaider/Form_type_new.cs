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
    public partial class Form_type_new : Form
    {
        public Form_type_new()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connect = provaider.Properties.Resources.conn_string;
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();   // открываем подключение

                SqlCommand comand = new SqlCommand("INSERT INTO [type_application] VALUES (@city)", conn);
                comand.Parameters.AddWithValue("@city", textBox_city.Text);
                comand.ExecuteNonQuery();
                Form_directory_adress.update_table_type= true;
                this.Close();


            }
        }
    }
}
