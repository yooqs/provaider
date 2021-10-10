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
    public partial class Form_directory_adress_street_new : Form
    {
        private int id;
        public Form_directory_adress_street_new(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connect = provaider.Properties.Resources.conn_string;
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();   // открываем подключение

                SqlCommand comand = new SqlCommand("INSERT INTO [street] ([name],[id_city]) VALUES (@street, @id_city)", conn);
                comand.Parameters.AddWithValue("@street", textBox_street.Text);
                comand.Parameters.AddWithValue("@id_city", id);
                comand.ExecuteNonQuery();
                Form_directory_adress.update_table_street = true;
                this.Close();


            }
        }
    }
}
