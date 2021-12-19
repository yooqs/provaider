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
    public partial class Form_new_edit_archive : Form
    {
        int status;
        int id;
        public Form_new_edit_archive(int status)
        {
            InitializeComponent();
            this.status = status;
        }
        public Form_new_edit_archive(int status, int id)
        {
            InitializeComponent();
            this.status = status;
            this.id = id;
        }

        private void Form_new_edit_archive_Load(object sender, EventArgs e)
        {
            
          if (status == 1)
            {
                this.Text = "Добавить";
                label3.Text = "Категория";
                button4.Text = "Добавить";
            }
          else if (status == 2)
            {
                this.Text = "Изменить";
                label3.Text = "Категория";
                button4.Text = "Изменить";

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Form_login.sql_connect;
                    conn.Open();
                    SqlCommand command = new SqlCommand("Select [name] FROM [products_categories] WHERE id=" + id, conn);


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
            if (status == 1)
            {
                string connect = Form_login.sql_connect;
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();   // открываем подключение

                    SqlCommand comand = new SqlCommand("INSERT INTO [products_categories] VALUES (@categories)", conn);
                    comand.Parameters.AddWithValue("@categories", textBox_city.Text);
                    comand.ExecuteNonQuery();
                    Form_directory_adress.update_table_category = true;
                    this.Close();


                }
            }
            if (status == 2)
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = Form_login.sql_connect;
                    conn.Open();
                    SqlCommand command = new SqlCommand("UPDATE [products_categories] SET  name='" + textBox_city.Text + "' WHERE id=" + id, conn);
                    command.ExecuteNonQuery();
                    Form_directory_adress.update_table_category = true;
                    this.Close();
                }
            }
        }
    }
}
