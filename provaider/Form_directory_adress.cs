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
        static public bool update_table_city = false;
        static public bool update_table_street = false;
        static public bool update_table_type = false;
        public async Task table_type_loadAsync()
        {
             
            if (update_table_type == true)
            {
                dataGridView3.Rows.Clear();
                clear();
                update_table_city = false;

                string connect = provaider.Properties.Resources.conn_string;
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    await conn.OpenAsync();   // открываем подключение
                    SqlCommand comand = new SqlCommand("Select * From [type_application]", conn);
                    // comand.ExecuteNonQueryAsync();
                    SqlDataReader reader = await comand.ExecuteReaderAsync();

                    while (reader.Read())
                    {
                        string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(), };
                        dataGridView3.Rows.Add(row);
                    }
                }
            }

        }
        public void table_type_load()
        {

            if (update_table_type == true)
            {
                dataGridView3.Rows.Clear();

                update_table_city = false;

                string connect = provaider.Properties.Resources.conn_string;
                using (SqlConnection conn = new SqlConnection(connect))
                {
                     conn.Open();   // открываем подключение
                    SqlCommand comand = new SqlCommand("Select * From [type_application]", conn);
                    // comand.ExecuteNonQueryAsync();
                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(), };
                        dataGridView3.Rows.Add(row);
                    }
                }
            }

        }
        private async Task table_city_loadAsync()
        {
            if (update_table_city == true)
            {
                update_table_city = false;
                dataGridView1.Rows.Clear();
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

        }
        private async Task table_street_updateAsync()
        {
            if (update_table_street == true)
            {
                update_table_street = false;
                dataGridView2.Rows.Clear();
                string connect = provaider.Properties.Resources.conn_string;
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    await conn.OpenAsync();   // открываем подключение
                    int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                    SqlCommand comand = new SqlCommand("Select [id],[name] From [street] where id_city = " + id, conn);
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

        }

        private void Form_directory_adress_Load(object sender, EventArgs e)
        {
            //tabPage1.Dock = System.Windows.Forms.DockStyle.Bottom;
            update_table_type = true;
            // table_type_loadAsync();
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
            update_table_street = true;
            table_street_updateAsync();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form_directory_adress_city_new directory_adress_city_new_form = new Form_directory_adress_city_new();
            directory_adress_city_new_form.StartPosition = FormStartPosition.CenterScreen;
            directory_adress_city_new_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            Form_directory_adress_city_edit directory_adress_city_edit_form = new Form_directory_adress_city_edit(id);
            directory_adress_city_edit_form.StartPosition = FormStartPosition.CenterScreen;
            directory_adress_city_edit_form.Show();
        }

        private void Form_directory_adress_Activated(object sender, EventArgs e)
        {
            table_city_loadAsync();
            table_street_updateAsync();
            table_type_loadAsync();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = provaider.Properties.Resources.conn_string;
                conn.Open();

                SqlCommand command = new SqlCommand("DELETE FROM [city] WHERE id='" + (string)dataGridView1.CurrentRow.Cells[0].Value + "'", conn);
                command.ExecuteNonQuery();
                command.Connection.Close();
                update_table_city = true;
                table_city_loadAsync();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                Form_directory_adress_street_new directory_adress_street_new = new Form_directory_adress_street_new(id);
                directory_adress_street_new.StartPosition = FormStartPosition.CenterScreen;
                directory_adress_street_new.Show();
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Добавьте город", "Предупреждение!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            Form_directory_adress_street_edit directory_adress_street_edit = new Form_directory_adress_street_edit(id);
            directory_adress_street_edit.StartPosition = FormStartPosition.CenterScreen;
            directory_adress_street_edit.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = provaider.Properties.Resources.conn_string;
                conn.Open();

                SqlCommand command = new SqlCommand("DELETE FROM [street] WHERE id='" + id + "'", conn);
                command.ExecuteNonQuery();
                command.Connection.Close();
                update_table_street = true;

                table_street_updateAsync();

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            //

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            update_table_street = true;
            table_street_updateAsync();

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form_type_new type_new_form = new Form_type_new();
            type_new_form.StartPosition = FormStartPosition.CenterScreen;
            type_new_form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            int id = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
            Form_type_edit type_edit_form = new Form_type_edit(id);
            type_edit_form.StartPosition = FormStartPosition.CenterScreen;
            type_edit_form.Show();
        }
        public void clear()
        {
            dataGridView3.Rows.Clear();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            update_table_type = false;
            int id = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value);
            //int ind = dataGridView3.CurrentRow.Index;
           // dataGridView3.Rows.RemoveAt(ind);
            // dataGridView3.Rows.Clear(); 
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
               
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = provaider.Properties.Resources.conn_string;
                    conn.Open();

                    SqlCommand command = new SqlCommand("DELETE FROM [type_application] WHERE id='" + id + "'", conn);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    string connect = provaider.Properties.Resources.conn_string;
                }
                update_table_type = true ;
                table_type_loadAsync();
                //  dataGridView3.Rows.Clear();



            }
        }
    }
}
