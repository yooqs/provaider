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
    public partial class Form_employee : Form
    {

        public Form_employee()
        {
            InitializeComponent();
        }
        public class category
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        private void post_load()
        {
            string string_connection = Properties.Resources.conn_string;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [name] From [post]", conn);
                List<category> employee_list = new List<category>();
                employee_list.Clear();
                SqlDataReader reader = comand.ExecuteReader();


                while (reader.Read())
                {
                    employee_list.Add(new category() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                }


                comboBox_post.DataSource = employee_list;
                comboBox_post.DisplayMember = "name";
                comboBox_post.ValueMember = "id";

            }
        }
        public async void table_combobox_last_name()
        {
            String sql = "SELECT DISTINCT [last_name] FROM [employee]";
            String str_conn = Properties.Resources.conn_string;
            using (SqlConnection conn = new SqlConnection(str_conn))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand(sql, conn);
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    comboBox_last_name.Items.Add(reader.GetValue(0).ToString().Trim());
                }
            }
        }
        public void Textbox_city_update()
        {

            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand("SELECT [name] FROM [city] ", conn);

            conn.ConnectionString = provaider.Properties.Resources.conn_string;
            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                comboBox_city.Items.Clear();
                while (reader.Read())
                {
                    string row = reader.GetValue(0).ToString().Trim();
                    comboBox_city.Items.Add(row);
                }
                reader.Close();
            }
            conn.Close();
        }
        public async void Textbox_street_update()
        {
            comboBox_street.Items.Clear();
            //получение id города

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = provaider.Properties.Resources.conn_string;
            await conn.OpenAsync();
            SqlCommand cmd = new SqlCommand("SELECT [id] FROM [city] WHERE [name]='" + comboBox_city.Text + "'", conn);
            SqlDataReader reader = await cmd.ExecuteReaderAsync();
            reader.ReadAsync();
            if (reader.HasRows)
            {
                int id = (int)reader.GetValue(0);
                reader.Close();
                //заполнение текст бокса
                cmd.CommandText = "SELECT [name] FROM [street] WHERE [id_city]='" + id + "'";
                using (reader = await cmd.ExecuteReaderAsync())
                {
                    while (reader.Read())
                    {
                        string row = reader.GetValue(0).ToString().Trim();
                        comboBox_street.Items.Add(row);
                    }
                    reader.Close();
                }
            }
            conn.Close();
        }
        public async Task table_updateAsync()
        {
            String sql;
            dataGridView_employee.Rows.Clear();

            SqlConnection conn = new SqlConnection();
            sql = "Select [employee].[id],[last_name],[first_name],[patronymic], [telephone], [city],[street], [house],FORMAT(employee.date_conclusion, 'dd/MM/yyyy', 'de-de' ), [flat],[passport_series], [passport_number] ,FORMAT(employee.date_birth, 'dd/MM/yyyy', 'de-de' ),[post].[name],[login],[password],[admin],[post].id  FROM [employee] JOIN [post] ON [post].[id]=[employee].[id_post] WHERE [employee].[id] IS NOT NULL";
            if (checkBox_city.Checked) sql += $" AND [city] = '{comboBox_city.Text}'";
            if (checkBox_street.Checked) sql += $" AND [street] = '{comboBox_street.Text}'";
            if (checkBox_house.Checked) sql += $" AND [house] = '{ textBox_house.Text}'";
            if (checkBox_flat.Checked) sql += $" AND [flat] = '{ textBox_flat.Text}'";
            if (checkBox_post.Checked) sql += $" AND [post].[id] = '{ comboBox_post.SelectedValue}'";
            if (checkBox_telephone.Checked) sql += $" AND [telephone] = '{maskedTextBox_telephone.Text}'";
            if (checkBox_passport_series.Checked) sql += " AND [passport_series] = " + textBox_passport_series.Text;
            if (checkBox_passport_number.Checked) sql += " AND [passport_number] = " + textBox_passport_number.Text;
            if (checkBox_date_conclusion.Checked) sql += " AND [date_conclusion] = convert(varchar, convert(datetime, '" + date_conclusions.Text + "', 104), 121)";


            conn.ConnectionString = provaider.Properties.Resources.conn_string;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
            {
                int i = 1;
                while (reader.Read())
                {
                    
                    string [] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(),
                                    reader.GetValue(2).ToString().Trim(),
                                    reader.GetValue(3).ToString().Trim(),
                                    reader.GetValue(4).ToString().Trim(),
                                    reader.GetValue(5).ToString().Trim()+", "+ reader.GetValue(6).ToString().Trim()+", "+reader.GetValue(7).ToString().Trim()+", "+reader.GetValue(9).ToString().Trim(),

                                    reader.GetValue(8).ToString().Trim(),

                                    reader.GetValue(10).ToString().Trim(),
                                    reader.GetValue(11).ToString().Trim(),
                                    reader.GetValue(12).ToString().Trim(),
                                    reader.GetValue(13).ToString().Trim(),
                                    reader.GetValue(14).ToString().Trim(),
                                    reader.GetValue(15).ToString().Trim(),
                                    reader.GetValue(16).ToString().Trim(),
                                    

                                    };
                    dataGridView_employee.Rows.Add(row);
                    /**  string flag = Convert.ToString(reader.GetValue(17));
                      
                      if (flag== "1")
                      {
                          dataGridView_employee.Rows[i].Cells[14].Value = true;
                      }
                      else
                      {
                          dataGridView_employee.Rows[i].Cells[14].Value = false;
                      }
                      **/




                }
                reader.Close();
            }
            conn.Close();
        }
        public static bool Data_table_employee_load = false;
        public async void table_employee_load()
        {
            String sql;
            dataGridView_employee.Rows.Clear();

            SqlConnection conn = new SqlConnection();
            sql = "Select [id],[last_name],[first_name],[patronymic], [telephone], [city],[street], [house], [flat],[passport_series],FORMAT(employee.date_conclusion, 'dd/MM/yyyy', 'de-de' ),FORMAT(employee.date_birth, 'dd/MM/yyyy', 'de-de' ),[passport_number] FROM [employee]";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.ConnectionString = provaider.Properties.Resources.conn_string;
            conn.Open();
            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
            {
                while (reader.Read())
                {
                    string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(),
                                    reader.GetValue(2).ToString().Trim(),
                                    reader.GetValue(3).ToString().Trim(),
                                    reader.GetValue(4).ToString().Trim(),
                                    reader.GetValue(5).ToString().Trim()+", "+ reader.GetValue(6).ToString().Trim()+", "+reader.GetValue(7).ToString().Trim()+", "+reader.GetValue(8).ToString().Trim(),

                                    reader.GetValue(10).ToString().Trim(),

                                    reader.GetValue(9).ToString().Trim(),
                                    reader.GetValue(12).ToString().Trim(),
                                    reader.GetValue(11).ToString().Trim(),

                                    };

                    dataGridView_employee.Rows.Add(row);
                }
                reader.Close();
            }

            conn.Close();
        }
            private void Form_employee_Load(object sender, EventArgs e)
        {
            // table_employee_load();
            table_updateAsync();
            table_combobox_last_name();
            Textbox_city_update();
            post_load();
        }

        private void button_employee_edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[0].Value);
            Form_employee_edit employee_edit_form = new Form_employee_edit(id);
            employee_edit_form.StartPosition = FormStartPosition.CenterScreen;
            employee_edit_form.Show();
        }

        private void button_employee_new_Click(object sender, EventArgs e)
        {
            Form_employee_new employee_new_form = new Form_employee_new();
            employee_new_form.StartPosition = FormStartPosition.CenterScreen;
            employee_new_form.Show();
        }

        private void Form_employee_Activated(object sender, EventArgs e)
        {
            //обновление таблицы при активации
            if (Data_table_employee_load == true)
            {
                table_updateAsync();
                Data_table_employee_load = false;
            }
        }

        private void button_employee_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = provaider.Properties.Resources.conn_string;
                conn.Open();
                
                SqlCommand command = new SqlCommand("DELETE FROM [employee] WHERE id='" + (string)dataGridView_employee.CurrentRow.Cells[0].Value + "'", conn);
                command.ExecuteNonQuery();
                command.Connection.Close();
                table_updateAsync();
            }
        }

        private void comboBox_last_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_user_search_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            dataGridView_employee.ClearSelection();
            for (int counter = 0; counter < (dataGridView_employee.Rows.Count); counter++)
            {
                string last_name = (String)dataGridView_employee.Rows[counter].Cells[1].Value;
                if (comboBox_last_name.Text.ToLower() == last_name.ToLower())
                {
                    dataGridView_employee.Rows[counter].Selected = true;
                    dataGridView_employee.CurrentCell = dataGridView_employee.Rows[counter].Cells[0];
                    flag = true;
                }
                dataGridView_employee.FirstDisplayedScrollingRowIndex = counter;

            }
            if (flag == false)
            {
                MessageBox.Show("Фамилия не найдена", "Предупреждение");
            }
        }

        private void comboBox_city_Leave(object sender, EventArgs e)
        {
            Textbox_street_update();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table_updateAsync();
        }

        private void dataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_flat_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_house_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_conclusions_ValueChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox_telephone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox_date_conclusion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_passport_number_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox_telephone_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_passport_series_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox_passport_number_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_passport_series_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_street_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_house_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_city_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_flat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_street_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_city_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
