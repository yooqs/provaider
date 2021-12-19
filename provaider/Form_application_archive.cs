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

namespace provaider
{
    public partial class Form_application_archive : Form
    {
        public Form_application_archive()
        {
            InitializeComponent();
            dataGridView1.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public class type {
            public int id { get; set; }
            public string name { get; set; }
        }

        public void type_load()
        {
            string string_connection = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {

                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [name] From [type_application]", conn);
                List<type> employee_list = new List<type>();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    employee_list.Add(new type() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                }


                comboBox_type.DataSource = employee_list;
                comboBox_type.DisplayMember = "name";
                comboBox_type.ValueMember = "id";
            }
        }
        public void Textbox_city_update()
        {

            SqlConnection conn = new SqlConnection();
            SqlCommand cmd = new SqlCommand("SELECT [name] FROM [city] ", conn);

            conn.ConnectionString = Form_login.sql_connect;
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
            conn.ConnectionString = Form_login.sql_connect;
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
        public async void table_combobox_name_contract()
        {
            String sql = "SELECT DISTINCT [last_name],[first_name],[patronymic] FROM [contract]";
            String str_conn = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(str_conn))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand(sql, conn);
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    comboBox_customer.Items.Add(reader.GetValue(0).ToString().Trim()+" "+ reader.GetValue(1).ToString().Trim()+" "+ reader.GetValue(2).ToString().Trim());
                }
            }
        }
        public async void table_combobox_name_employee()
        {
            String sql = "SELECT DISTINCT [last_name],[first_name],[patronymic] FROM [employee]";
            String str_conn = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(str_conn))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand(sql, conn);
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    comboBox_employee.Items.Add(reader.GetValue(0).ToString().Trim() + " " + reader.GetValue(1).ToString().Trim() + " " + reader.GetValue(2).ToString().Trim());
                }
            }
        }
        static int id_application;
        public void table_applications_load()
        {
            String sql;
            dataGridView1.Rows.Clear();
            
            using (SqlConnection conn = new SqlConnection())
            {
                sql = "Select [applications].[id],[applications].[description],[applications].[date_receipt],[contract].[last_name],[contract].[first_name],[contract].[patronymic],[contract].[telephone],[contract].[city],[contract].[street],[contract].[house],[contract].[flat],[employee].[last_name],[employee].[first_name],[employee].[patronymic],[type_application].[name],[applications].[status],[applications].[date_completion] FROM  [contract] JOIN [applications] ON [contract].[id] =  [applications].[id_contract]  JOIN[emp_app] ON [emp_app].[id_app] =  [applications].[id] JOIN [employee] ON [emp_app].[id_emp] = [employee].[id] JOIN[type_application] ON[type_application].[id] =  [applications].[type]  where [status] != 'Ожидание' and [status] != 'Выполнение'";
                if (checkBox_status.Checked) sql += $" AND [applications].[status] = '{comboBox_status.Text}'";
                //if (checkBox_type.Checked) sql += $" AND [type_application].[id] = '{comboBox_type.SelectedValue}'";
                if (checkBox_city.Checked) sql += $" AND [contract].[city] = '{comboBox_city.Text}'";
                if (checkBox_street.Checked) sql += $" AND [contract].[street] = '{comboBox_street.Text}'";
                if (checkBox_house.Checked) sql += $" AND [contract].[house] = '{ textBox_house.Text}'";
                if (checkBox_flat.Checked) sql += $" AND[contract].[flat] = '{ textBox_flat.Text}'";
                if (checkBox_type.Checked) sql += $" AND [type_application].[name] = '{comboBox_type.Text}'";
                if (checkBox_status.Checked) sql += $" AND [applications].[status] = '{comboBox_status.Text}'";
                if (checkBox_date_receipt_from.Checked) sql += $" AND [applications].[date_receipt] >= convert(varchar, convert(datetime, '" + _date_receipt_from.Text + "', 104), 121)"; 
                if (checkBox_date_receipt_to.Checked) sql += $" AND [applications].[date_receipt] <= convert(varchar, convert(datetime, '" + date_receipt_to.Text + "', 104), 121)";
                if (checkBox_date_conclusion_from.Checked) sql += $" AND [applications].[date_completion] >= convert(varchar, convert(datetime, '" + date_conclusion_from.Text + "', 104), 121)";
                if (checkBox_date_conclusion_to.Checked) sql += $" AND [applications].[date_completion] <= convert(varchar, convert(datetime, '" + date_conclusion_to.Text + "', 104), 121)";
                if (checkBox_employee.Checked)
                {
                    string[] fio= comboBox_employee.Text.Split(new char[] { ' ' });
                    // if (fio[0] == "")
                    int i = fio.Length;
                    if (i==1)  sql += $" AND [employee].[last_name] = '{fio[0]}'";
                    else if (i==2)  sql += $" AND [employee].[last_name] = '{fio[0]}' AND [employee].[first_name] ='{fio[1]}'";
                    else if (i==3)  sql += $" AND [employee].[last_name] = '{fio[0]}' AND [employee].[first_name] ='{fio[1]}'  AND [employee].[patronymic] ='{fio[2]}'";
                }
                if (checkBox_customer.Checked)
                {
                    string[] fio = comboBox_customer.Text.Split(new char[] { ' ' });
                    // if (fio[0] == "")
                    int i = fio.Length;
                    if (i == 1) sql += $" AND [contract].[last_name] = '{fio[0]}'";
                    else if (i == 2) sql += $" AND [contract].[last_name] = '{fio[0]}' AND [contract].[first_name] ='{fio[1]}'";
                    else if (i == 3) sql += $" AND [contract].[last_name] = '{fio[0]}' AND [contract].[first_name] ='{fio[1]}'  AND [contract].[patronymic] ='{fio[2]}'";
                }

                //   if (checkBox_passport_number.Checked) sql += " AND [passport_number] = " + textBox_passport_number.Text;
                // if (checkBox_date_conclusion.Checked) sql += " AND [date_conclusion] = convert(varchar, convert(datetime, '" + date_conclusions.Text + "', 104), 121)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.ConnectionString = Form_login.sql_connect;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                /* while (reader.Read())
                 {
                     string[] row = {reader.GetValue(0).ToString().Trim(),
                                     reader.GetValue(3).ToString().Trim()+" "+reader.GetValue(4).ToString().Trim()+" "+reader.GetValue(5).ToString().Trim(),
                                     reader.GetValue(6).ToString().Trim(),
                                     reader.GetValue(7).ToString().Trim()+", "+reader.GetValue(8).ToString().Trim()+", "+reader.GetValue(9).ToString().Trim()+", "+reader.GetValue(10).ToString().Trim(),
                                     reader.GetValue(14).ToString().Trim(),
                                     reader.GetValue(1).ToString().Trim(),
                                     reader.GetValue(11).ToString().Trim()+" "+reader.GetValue(12).ToString().Trim()+" "+reader.GetValue(13).ToString().Trim(),
                                     reader.GetValue(2).ToString().Trim(),
                                     reader.GetValue(16).ToString().Trim(),
                                     reader.GetValue(15).ToString().Trim(),
                                     };

                     dataGridView1.Rows.Add(row);
                 }
                */
               
                 string[] table_app;
                 table_app = new string[10];
                 if (reader.Read()) {
                    table_app[0] = reader.GetValue(0).ToString().Trim();
                    table_app[1] = reader.GetValue(3).ToString().Trim() + " " + reader.GetValue(4).ToString().Trim() + " " + reader.GetValue(5).ToString().Trim();
                    table_app[2] = reader.GetValue(6).ToString().Trim();
                    table_app[3] = reader.GetValue(7).ToString().Trim() + ", " + reader.GetValue(8).ToString().Trim() + ", " + reader.GetValue(9).ToString().Trim() + ", " + reader.GetValue(10).ToString().Trim();
                    table_app[4] = reader.GetValue(14).ToString().Trim();
                    table_app[5] = reader.GetValue(1).ToString().Trim();
                    table_app[6] = reader.GetValue(11).ToString().Trim() + " " + reader.GetValue(12).ToString().Trim() + " " + reader.GetValue(13).ToString().Trim();
                    table_app[7] = reader.GetValue(2).ToString().Trim();
                    table_app[8]= reader.GetValue(16).ToString().Trim();
                    table_app[9]= reader.GetValue(15).ToString().Trim();



                    id_application = Convert.ToInt32(table_app[0]);
                }

                while (reader.Read())
                {
                    if (Convert.ToInt32(reader.GetValue(0)) == id_application)
                    {
                        table_app[6]+= "\n"+reader.GetValue(11).ToString().Trim() + " " + reader.GetValue(12).ToString().Trim() + " " + reader.GetValue(13).ToString().Trim();

                    }
                    else
                    {
                        dataGridView1.Rows.Add(table_app);
                         table_app[0] = reader.GetValue(0).ToString().Trim();
                    table_app[1] = reader.GetValue(3).ToString().Trim() + " " + reader.GetValue(4).ToString().Trim() + " " + reader.GetValue(5).ToString().Trim();
                    table_app[2] = reader.GetValue(6).ToString().Trim();
                    table_app[3] = reader.GetValue(7).ToString().Trim() + ", " + reader.GetValue(8).ToString().Trim() + ", " + reader.GetValue(9).ToString().Trim() + ", " + reader.GetValue(10).ToString().Trim();
                    table_app[4] = reader.GetValue(14).ToString().Trim();
                    table_app[5] = reader.GetValue(1).ToString().Trim();
                    table_app[6] = reader.GetValue(11).ToString().Trim() + " " + reader.GetValue(12).ToString().Trim() + " " + reader.GetValue(13).ToString().Trim();
                    table_app[7] = reader.GetValue(2).ToString().Trim();
                    table_app[8]= reader.GetValue(16).ToString().Trim();
                    table_app[9]= reader.GetValue(15).ToString().Trim();
                        id_application = Convert.ToInt32(table_app[0]);
                    }
                    
                }
                dataGridView1.Rows.Add(table_app); 
                 

            }

        }
        private void Form_application_archive_Load(object sender, EventArgs e)
        {
            table_applications_load();
            Textbox_city_update();
            table_combobox_name_contract();
            table_combobox_name_employee();
            type_load();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            table_applications_load();
        }

        private void comboBox_city_Leave(object sender, EventArgs e)
        {
            Textbox_street_update();
        }

        private void button_customers_new_Click(object sender, EventArgs e)
        {
            try
            {
                var WordApp = new Microsoft.Office.Interop.Word.Application();
                WordApp.Visible = false;
                string woo = Path.Combine(Application.StartupPath);
                woo = woo + @"\dogovor_uslugi.dotx";
                //string woo = @"C:\Users\Дмитрий\Desktop\12\dogovor_uslugi.dotx";
                //  woo = woo + @"\prikaz_na_otpusk.dotx";
                // var WordDocument = WordApp.Documents.Open(@"C:\Users\Дмитрий\Documents\sql_S\Basa_sql\Basa_sql\prikaz_na_otpusk.dotx");
                var WordDocument = WordApp.Documents.Open(woo);
                var range = WordDocument.Content;
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: "{number}", ReplaceWith: (string)dataGridView1.CurrentRow.Cells[0].Value.ToString());
                range = WordDocument.Content;
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: "{date}", ReplaceWith: (string)dataGridView1.CurrentRow.Cells[7].Value.ToString());
                range.Find.ClearFormatting();
                range = WordDocument.Content;
                range.Find.Execute(FindText: "{name}", ReplaceWith: (string)dataGridView1.CurrentRow.Cells[1].Value.ToString());
                range.Find.ClearFormatting();
                range = WordDocument.Content;
                range.Find.Execute(FindText: "{type}", ReplaceWith: (string)dataGridView1.CurrentRow.Cells[4].Value.ToString());
                range.Find.ClearFormatting();
                range = WordDocument.Content;


                WordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Form_login.sql_connect;
                conn.Open();
                SqlCommand command = new SqlCommand("DELETE FROM [applications] WHERE id='" + (String)dataGridView1.CurrentRow.Cells[0].Value + "'", conn);
                command.ExecuteNonQuery();
                command.Connection.Close();
                table_applications_load();
            }
        }

        private void button_user_search_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_application_archive_open _Application_Archive_Load = new Form_application_archive_open(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()));
            _Application_Archive_Load.StartPosition = FormStartPosition.CenterScreen;
            _Application_Archive_Load.ShowDialog();
        }
    }
}
