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
    public partial class Form_applications_contract : Form
    {
        public Form_applications_contract()
        {
            InitializeComponent();
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
        public async void table_combobox_last_name()
        {
            String sql = "SELECT DISTINCT [last_name] FROM [contract]";
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
        public async void table_contract_load()
        {
            String sql;
            dataGridView1.Rows.Clear();

            SqlConnection conn = new SqlConnection();
            sql = "Select [contract].[id],[last_name],[first_name],[patronymic], [telephone], [city],[street], [house],FORMAT(contract.date_conclusion, 'dd/MM/yyyy', 'de-de' ), [flat],[passport_series], [passport_number] ,FORMAT(contract.data_birth, 'dd/MM/yyyy', 'de-de' ),distance,time_before,longtude,latitude,login_kab,[tariff].name FROM [contract] JOIN [tariff] ON [contract].[id_tariff] = [tariff].[id] ";
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
                                    reader.GetValue(5).ToString().Trim()+", "+ reader.GetValue(6).ToString().Trim()+", "+reader.GetValue(7).ToString().Trim()+", "+reader.GetValue(9).ToString().Trim(),

                                    reader.GetValue(8).ToString().Trim(),

                                    reader.GetValue(10).ToString().Trim(),
                                    reader.GetValue(11).ToString().Trim(),
                                    reader.GetValue(12).ToString().Trim(),
                                    reader.GetValue(13).ToString().Trim(),
                                    reader.GetValue(14).ToString().Trim(),
                                    reader.GetValue(15).ToString().Trim(),
                                    reader.GetValue(16).ToString().Trim(),
                                    reader.GetValue(17).ToString().Trim(),
                                    reader.GetValue(18).ToString().Trim(),

                                    };


                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
            }
            conn.Close();
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
        private void Form_applications_contract_Load(object sender, EventArgs e)
        {
            table_contract_load();
            table_combobox_last_name();
            
            Textbox_city_update();
        }

        private void button_customers_new_Click(object sender, EventArgs e)
        {

            string[] data_contract = { (string)dataGridView1.CurrentRow.Cells[0].Value,
                                       (string)dataGridView1.CurrentRow.Cells[1].Value,
                                       (string)dataGridView1.CurrentRow.Cells[2].Value,
                                       (string)dataGridView1.CurrentRow.Cells[3].Value,
                                       (string)dataGridView1.CurrentRow.Cells[4].Value,
                                       (string)dataGridView1.CurrentRow.Cells[5].Value,
                                       (string)dataGridView1.CurrentRow.Cells[6].Value,
                                       (string)dataGridView1.CurrentRow.Cells[7].Value,
                                       (string)dataGridView1.CurrentRow.Cells[8].Value,
                                       (string)dataGridView1.CurrentRow.Cells[9].Value,
                                       (string)dataGridView1.CurrentRow.Cells[10].Value,
                                       (string)dataGridView1.CurrentRow.Cells[11].Value,
                                       (string)dataGridView1.CurrentRow.Cells[12].Value,
                                       (string)dataGridView1.CurrentRow.Cells[13].Value,
                                       (string)dataGridView1.CurrentRow.Cells[14].Value,
                                       (string)dataGridView1.CurrentRow.Cells[15].Value
                                      }; 
                                       
            Form_applications_new applications_new_form = new Form_applications_new(data_contract);
            applications_new_form.StartPosition = FormStartPosition.CenterScreen;
            applications_new_form.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_user_search_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            dataGridView1.ClearSelection();
            for (int counter = 0; counter < (dataGridView1.Rows.Count); counter++)
            {
                string last_name = (String)dataGridView1.Rows[counter].Cells[1].Value;
                if (comboBox_last_name.Text.ToLower() == last_name.ToLower())
                {
                    dataGridView1.Rows[counter].Selected = true;
                    dataGridView1.CurrentCell = dataGridView1.Rows[counter].Cells[0];
                    flag = true;
                }
                dataGridView1.FirstDisplayedScrollingRowIndex = counter;
                
            }
            if (flag == false)
            {
                MessageBox.Show("Фамилия не найдена", "Предупреждение");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_date5_CheckedChanged(object sender, EventArgs e)
        {

        }
        //таблица+фильтры
        public async Task table_updateAsync()
        {
            String sql;
            dataGridView1.Rows.Clear();

            SqlConnection conn = new SqlConnection();
            sql = "Select [id],[last_name],[first_name],[patronymic], [telephone], [city],[street], [house],FORMAT(contract.date_conclusion, 'dd/MM/yyyy', 'de-de' ), [flat],[passport_series], [passport_number] ,FORMAT(contract.data_birth, 'dd/MM/yyyy', 'de-de' ) FROM [contract] WHERE [id] IS NOT NULL";
            if (checkBox_city.Checked) sql += $" AND [city] = '{comboBox_city.Text}'";
            if (checkBox_street.Checked) sql += $" AND [street] = '{comboBox_street.Text}'";
            if (checkBox_house.Checked) sql += $" AND [house] = '{ textBox_house.Text}'";
            if (checkBox_flat.Checked) sql += $" AND [flat] = '{ textBox_flat.Text}'";
            if (checkBox_telephone.Checked) sql += $" AND [telephone] = '{maskedTextBox_telephone.Text}'";
            if (checkBox_passport_series.Checked) sql += " AND [passport_series] = " + textBox_passport_series.Text;
            if (checkBox_passport_number.Checked) sql += " AND [passport_number] = "+ textBox_passport_number.Text;
            if (checkBox_date_conclusion.Checked) sql += " AND [date_conclusion] = convert(varchar, convert(datetime, '" + date_conclusions.Text + "', 104), 121)";
                

            conn.ConnectionString = provaider.Properties.Resources.conn_string;
            conn.Open();
            SqlCommand cmd = new SqlCommand(sql, conn);
            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
            {
                while (reader.Read())
                {
                    string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(),
                                    reader.GetValue(2).ToString().Trim(),
                                    reader.GetValue(3).ToString().Trim(),
                                    reader.GetValue(4).ToString().Trim(),
                                    reader.GetValue(5).ToString().Trim()+", "+ reader.GetValue(6).ToString().Trim()+", "+reader.GetValue(7).ToString().Trim()+", "+reader.GetValue(9).ToString().Trim(),

                                    reader.GetValue(8).ToString().Trim(),

                                    reader.GetValue(10).ToString().Trim(),
                                    reader.GetValue(11).ToString().Trim(),
                                    reader.GetValue(12).ToString().Trim(),

                                    };

                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
            }
            conn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table_updateAsync();
        }

        private void comboBox_post_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_post_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_date3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_date1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form_applications_contract_Leave(object sender, EventArgs e)
        {
            //Textbox_street_update();
        }

        private void comboBox_city_Leave(object sender, EventArgs e)
        {
            Textbox_street_update();
        }
    }
}
