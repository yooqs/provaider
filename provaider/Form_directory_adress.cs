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
    public partial class Form_directory_adress : Form
    {
        public Form_directory_adress()
        {
            InitializeComponent();
        }
        private async Task table_city_loadAsync()
        {
            string connect = provaider.Properties.Resources.conn_string;
            using (SqlConnection conn = new SqlConnection(connect))
            {
                await conn.OpenAsync();   // открываем подключение
                SqlCommand comand = new SqlCommand("Select * From [city]", conn);
               // comand.ExecuteNonQueryAsync();
                SqlDataReader reader = await comand.ExecuteReaderAsync();

                while (reader.Read())
                {
                    string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(), };
                    dataGridView1.Rows.Add(row);
                }
            }
            
        }
        private async Task table_street_updateAsync()
        {
            dataGridView2.Rows.Clear();
            string connect = provaider.Properties.Resources.conn_string;
            using (SqlConnection conn = new SqlConnection(connect))
            {
                await conn.OpenAsync();   // открываем подключение
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                SqlCommand comand = new SqlCommand("Select [id],[name] From [street] where id_city = "+id, conn);
                // comand.ExecuteNonQueryAsync();
                SqlDataReader reader = await comand.ExecuteReaderAsync();

                while (reader.Read())
                {
                    string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(), };
                    dataGridView2.Rows.Add(row);
                }
            }

        }

        private void Form_directory_adress_Load(object sender, EventArgs e)
        {
            string connect = provaider.Properties.Resources.conn_string + ";MultipleActiveResultSets = True";
            using (SqlConnection conn = new SqlConnection(connect))
            {
                conn.Open();   // открываем подключение
                SqlCommand comand = new SqlCommand("Select * From [city]", conn);
                // comand.ExecuteNonQueryAsync();
                SqlDataReader reader = comand.ExecuteReader();
               
                while (reader.Read())
                {
                    string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(), };
                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
                conn.Close();
                conn.Open();
            }
            if (dataGridView1.RowCount != null)
            {
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();   // открываем подключение
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    SqlCommand comand = new SqlCommand("Select [id], [name] From [street] Where [id_city] = " + id, conn);

                    // comand.ExecuteNonQueryAsync();
                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(), };
                        dataGridView2.Rows.Add(row);
                    }
                    reader.Close();
                    conn.Close();
                    conn.Open();
                }
            }
            

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            table_street_updateAsync();
        }
    }
}
