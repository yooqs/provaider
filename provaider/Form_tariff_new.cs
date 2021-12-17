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
    public partial class Form_tariff_new : Form
    {
        public Form_tariff_new()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connect = provaider.Properties.Resources.conn_string;
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();   // открываем подключение

                SqlCommand comand = new SqlCommand("INSERT INTO [tariff] VALUES (@tariff,@description)", conn);
                comand.Parameters.AddWithValue("@tariff", textBox_city.Text);
                comand.Parameters.AddWithValue("@description", textBox1.Text);
                comand.ExecuteNonQuery();
                Form_directory_adress.update_table_tariff = true;
                this.Close();


            }
        }
    }
}
