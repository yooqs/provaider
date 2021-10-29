using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Core;

namespace provaider
{
    public partial class Form_customers : Form
    {
        public Form_customers()
        {
            InitializeComponent();
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
            dataGridView1.Rows.Clear();

            SqlConnection conn = new SqlConnection();
            sql = "Select [id],[last_name],[first_name],[patronymic], [telephone], [city],[street], [house],FORMAT(contract.date_conclusion, 'dd/MM/yyyy', 'de-de' ), [flat],[passport_series], [passport_number] ,FORMAT(contract.data_birth, 'dd/MM/yyyy', 'de-de' ),distance,time_before FROM [contract] WHERE [id] IS NOT NULL";
            if (checkBox_city.Checked) sql += $" AND [city] = '{comboBox_city.Text}'";
            if (checkBox_street.Checked) sql += $" AND [street] = '{comboBox_street.Text}'";
            if (checkBox_house.Checked) sql += $" AND [house] = '{ textBox_house.Text}'";
            if (checkBox_flat.Checked) sql += $" AND [flat] = '{ textBox_flat.Text}'";
            if (checkBox_telephone.Checked) sql += $" AND [telephone] = '{maskedTextBox_telephone.Text}'";
            if (checkBox_passport_series.Checked) sql += " AND [passport_series] = " + textBox_passport_series.Text;
            if (checkBox_passport_number.Checked) sql += " AND [passport_number] = " + textBox_passport_number.Text;
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
                                    reader.GetValue(13).ToString().Trim(),
                                    reader.GetValue(14).ToString().Trim(),

                                    };

                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
            }
            conn.Close();
        }

        private void button_customers_new_Click(object sender, EventArgs e)
        {
            Form_customers_new customers_new_form = new Form_customers_new();
            customers_new_form.Show();
        }
        public static bool Data_table_load = false;
        public async void table_contract_load()
        {
            String sql;
            dataGridView1.Rows.Clear();

            SqlConnection conn = new SqlConnection();
            sql = "Select [id],[last_name],[first_name],[patronymic], [telephone], [city],[street], [house],FORMAT(contract.data_birth, 'dd/MM/yyyy', 'de-de' ), [flat],[passport_series], [passport_number] ,FORMAT(contract.date_conclusion, 'dd/MM/yyyy', 'de-de' ),distance,time_before FROM [contract]";
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

                                    };

                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
            }
            conn.Close();
        }
        private void Form_customers_Load(object sender, EventArgs e)
        {
            Textbox_city_update();
            table_updateAsync();
            table_combobox_last_name();
        }

        private void button_customers_new_Click_1(object sender, EventArgs e)
        {
            Form_customers_new customers_new_form = new Form_customers_new();
            customers_new_form.StartPosition = FormStartPosition.CenterScreen;
            customers_new_form.Show();
        }

        private void button_customers_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = provaider.Properties.Resources.conn_string;
                conn.Open();
                SqlCommand command = new SqlCommand("DELETE FROM [contract] WHERE id='" + (String)dataGridView1.CurrentRow.Cells[0].Value + "'", conn);
                command.ExecuteNonQuery();
                command.Connection.Close();
                table_contract_load();
            }
        }

        private void Form_customers_Activated(object sender, EventArgs e)
        {
            if (Data_table_load == true)
            {
                table_updateAsync(); 
                Data_table_load = false;
                table_combobox_last_name();
            }
        }

        private void button_customers_edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
           Form_customers_edit customers_edit_form = new Form_customers_edit(id);
            customers_edit_form.StartPosition = FormStartPosition.CenterScreen;
            customers_edit_form.Show();

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

        private void button3_Click(object sender, EventArgs e)
        {
            table_updateAsync();
        }

        private void comboBox_city_Leave(object sender, EventArgs e)
        {
            Textbox_street_update();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string s = (string)dataGridView1.CurrentRow.Cells[5].Value;
            string[] city = s.Split(new char[] { ' ' });
            try { 
            var WordApp = new Microsoft.Office.Interop.Word.Application();
            WordApp.Visible = false;
                string woo = Path.Combine(Application.StartupPath);
                woo = woo + @"\dogovor.dotx";
                //string woo = @"C:\Users\Дмитрий\Desktop\12\dogovor.dotx";
           //  woo = woo + @"\prikaz_na_otpusk.dotx";
            // var WordDocument = WordApp.Documents.Open(@"C:\Users\Дмитрий\Documents\sql_S\Basa_sql\Basa_sql\prikaz_na_otpusk.dotx");
            var WordDocument = WordApp.Documents.Open(woo);
            var range = WordDocument.Content;
            range.Find.ClearFormatting();
                range.Find.Execute(FindText: "{number}", ReplaceWith: (string)dataGridView1.CurrentRow.Cells[0].Value);
                range = WordDocument.Content;
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: "{date}", ReplaceWith: (string)dataGridView1.CurrentRow.Cells[6].Value);
                range.Find.ClearFormatting();
                range = WordDocument.Content;
                range.Find.Execute(FindText: "{city}", ReplaceWith: city[0]);
                range.Find.ClearFormatting();
                range = WordDocument.Content;
                range.Find.Execute(FindText: "{fio}", ReplaceWith: (string)dataGridView1.CurrentRow.Cells[1].Value + " " + (string)dataGridView1.CurrentRow.Cells[2].Value + " " + (string)dataGridView1.CurrentRow.Cells[3].Value);
                range.Find.ClearFormatting();
                range = WordDocument.Content;


                WordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }

        }

        private void date_conclusions_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_date_conclusion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_house_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_house_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox_flat_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_flat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox_telephone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox_telephone_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
