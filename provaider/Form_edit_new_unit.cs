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
    public partial class Form_edit_new_unit : Form
    {
        Boolean status;
        int id;
        public Form_edit_new_unit(Boolean status)
        {
            InitializeComponent();
            this.status = status;
        }
        public Form_edit_new_unit(Boolean status,int id)
        {
            InitializeComponent();
            this.status = status;
            this.id = id;
        }

        private void Form_edit_new_unit_Load(object sender, EventArgs e)
        {
            if (status == true)
            {
                this.Text = "Добавить";
                label3.Text = "Единица измерения";
                button4.Text = "Добавить";
            }
            else if (status == false)
            {
                this.Text = "Изменить";
                label3.Text = "Единица измерения";
                button4.Text = "Изменить";

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Form_login.sql_connect;
                    conn.Open();
                    SqlCommand command = new SqlCommand("Select [name] FROM [unit_products] WHERE id=" + id, conn);


                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        textBox_city.Text = (string)reader.GetValue(0);
                        
                    }

                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                string connect = Form_login.sql_connect;
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();   // открываем подключение

                    SqlCommand comand = new SqlCommand("INSERT INTO [unit_products] VALUES (@categories)", conn);
                    comand.Parameters.AddWithValue("@categories", textBox_city.Text);
                    comand.ExecuteNonQuery();
                    Form_directory_adress.update_table_unit = true;
                    this.Close();


                }
            }
            if (status == false)
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Form_login.sql_connect;
                    conn.Open();
                    SqlCommand command = new SqlCommand("UPDATE [unit_products] SET  name='" + textBox_city.Text + "' WHERE id=" + id, conn);
                    command.ExecuteNonQuery();
                    Form_directory_adress.update_table_unit = true;
                    this.Close();
                }
            }
        }
    }
}
