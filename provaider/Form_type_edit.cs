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
    public partial class Form_type_edit : Form
    {
        int id;
        public Form_type_edit(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Form_type_edit_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Properties.Resources.conn_string;
                conn.Open();
                SqlCommand command = new SqlCommand("Select [name] FROM [type_application] WHERE id=" + id, conn);


                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox_city.Text = (string)reader.GetValue(0);
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection conn = new SqlConnection())
            {
                //conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Дмитрий\Desktop\1234\basa.mdf;Integrated Security=True;Connect Timeout=30";
                conn.ConnectionString = Properties.Resources.conn_string;
                conn.Open();
                SqlCommand command = new SqlCommand("UPDATE [type_application] SET  name='" + textBox_city.Text + "' WHERE id=" + id, conn);
                command.ExecuteNonQuery();
                

                this.Close();
            }
            Form_directory_adress.update_table_type = true;
        }
    }
}
