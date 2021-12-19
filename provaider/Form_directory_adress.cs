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
        static public bool update_table_city = false;     //обновление таблицы города
        static public bool update_table_street = false;   //обновление таблицы улицы
        static public bool update_table_type = false;     //обновление таблицы вид услуг
        static public bool update_table_category = false; //обновление таблицы категорий товаров
        static public bool update_table_unit = false;     //обновление таблицы еденицы измерения
        static public bool update_table_nomenclature = false;     //обновление таблицы еденицы измерения
        static public bool update_table_post = false;     //обновление таблицы еденицы измерения
        static public bool update_table_tariff = false;     //обновление таблицы тариффы

        public static Boolean flag_textbox_name = false;


        public async Task table_tariff_loadAsync()
        {

            if (update_table_tariff == true)
            {
                dataGridView8.Rows.Clear();
                clear();
                update_table_tariff = false;

                string connect = Form_login.sql_connect;
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    await conn.OpenAsync();   // открываем подключение
                    SqlCommand comand = new SqlCommand("Select * From [tariff]", conn);
                    // comand.ExecuteNonQueryAsync();
                    SqlDataReader reader = await comand.ExecuteReaderAsync();

                    while (reader.Read())
                    {
                        string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(),
                                    reader.GetValue(2).ToString().Trim(),

                        };
                        dataGridView8.Rows.Add(row);
                    }
                }
            }
        }
        public async Task table_post_loadAsync()
        {

            if (update_table_post == true)
            {
                dataGridView7.Rows.Clear();
                clear();
                update_table_post = false;

                string connect = Form_login.sql_connect;
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    await conn.OpenAsync();   // открываем подключение
                    SqlCommand comand = new SqlCommand("Select * From [post]", conn);
                    // comand.ExecuteNonQueryAsync();
                    SqlDataReader reader = await comand.ExecuteReaderAsync();

                    while (reader.Read())
                    {
                        string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(),

                        };
                        dataGridView7.Rows.Add(row);
                    }
                }
            }
        }
            
            public void table_nomenclature (DataGridView dataGrid, ComboBox combo_category)
        {
            if (update_table_nomenclature == true)
            {
                update_table_nomenclature = false;
                dataGrid.Rows.Clear();
                clear();
                //update_table_unit = false;

                string connect = Form_login.sql_connect;
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    string sqlstring;
                    conn.Open();   // открываем подключение
                    if (Convert.ToInt32(combo_category.SelectedValue)== 0)
                    {
                        sqlstring ="SELECT [products].[id], [products].[name],[products_categories].[name],[unit_products].[name],[products].[id_category],[products].[id_unit] From [products] JOIN [products_categories] ON [products].[id_category] =[products_categories].[id] JOIN [unit_products] ON [products].[id_unit]= [unit_products].[id]  ";
                    }
                    else
                    {
                        sqlstring="SELECT [products].[id], [products].[name],[products_categories].[name],[unit_products].[name],[products].[id_category],[products].[id_unit] From [products] JOIN [products_categories] ON [products].[id_category] =[products_categories].[id] JOIN [unit_products] ON [products].[id_unit]= [unit_products].[id] where [products].[id_category]=" + combo_category.SelectedValue;
                    }
                    SqlCommand comand = new SqlCommand(sqlstring, conn);
                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = {reader.GetValue(0).ToString().Trim(),
                                        reader.GetValue(1).ToString().Trim(),
                                        reader.GetValue(2).ToString().Trim(),
                                        reader.GetValue(3).ToString().Trim(),
                                        reader.GetValue(4).ToString().Trim(),
                                        reader.GetValue(5).ToString().Trim(),

                        };
                        dataGrid.Rows.Add(row);
                    }
                }
            }
        }
        private void textbox_name_load(ComboBox combo_name, ComboBox combo_category)
        {

            string string_connection = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                string SqlString;
                if (combo_category.Text == "Все")
                {
                    SqlString = "SELECT  [name] From [products]";
                }
                else
                {
                    SqlString = "SELECT  [name] From [products]  where [products].[id_category]=" + combo_category.SelectedValue;
                }


                SqlCommand comand = new SqlCommand(SqlString, conn);

                SqlDataReader reader = comand.ExecuteReader();
                combo_name.Items.Clear();
                while (reader.Read())
                {
                    combo_name.Items.Add(reader.GetValue(0));
                }

            }


            
        }
        public class category
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        private void textbox_category_load(ComboBox comboBox)
        {

            string string_connection = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [name] From [products_categories]", conn);
                List<category> employee_list = new List<category>();
                employee_list.Clear();
                SqlDataReader reader = comand.ExecuteReader();

                employee_list.Add(new category() { id = 0, name = "Все" });
                while (reader.Read())
                {
                    employee_list.Add(new category() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                }


                comboBox.DataSource = employee_list;
                comboBox.DisplayMember = "name";
                comboBox.ValueMember = "id";

            }
        }

        public async Task table_unit_loadAsync()
        {

            if (update_table_unit == true)
            {
                dataGridView5.Rows.Clear();
                clear();
                update_table_unit = false;

                string connect = Form_login.sql_connect;
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    await conn.OpenAsync();   // открываем подключение
                    SqlCommand comand = new SqlCommand("Select * From [unit_products]", conn);
                    // comand.ExecuteNonQueryAsync();
                    SqlDataReader reader = await comand.ExecuteReaderAsync();

                    while (reader.Read())
                    {
                        string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(),

                        };
                        dataGridView5.Rows.Add(row);
                    }
                }
            }
        }
        public async Task table_category_loadAsync()
        {

            if (update_table_category == true)
            {
                dataGridView4.Rows.Clear();
                clear();
                update_table_category = false;

                string connect = Form_login.sql_connect;
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    await conn.OpenAsync();   // открываем подключение
                    SqlCommand comand = new SqlCommand("Select * From [products_categories]", conn);
                    // comand.ExecuteNonQueryAsync();
                    SqlDataReader reader = await comand.ExecuteReaderAsync();

                    while (reader.Read())
                    {
                        string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(),

                        };
                        dataGridView4.Rows.Add(row);
                    }
                }
            }
        }
        public async Task table_type_loadAsync()
        {

            if (update_table_type == true)
            {
                dataGridView3.Rows.Clear();
                clear();
                update_table_city = false;

                string connect = Form_login.sql_connect;
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    await conn.OpenAsync();   // открываем подключение
                    SqlCommand comand = new SqlCommand("Select * From [type_application]", conn);
                    // comand.ExecuteNonQueryAsync();
                    SqlDataReader reader = await comand.ExecuteReaderAsync();

                    while (reader.Read())
                    {
                        string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(),
                                    reader.GetValue(2).ToString().Trim(),
                                    reader.GetValue(3).ToString().Trim(),
                        };
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

                string connect = Form_login.sql_connect;
                using (SqlConnection conn = new SqlConnection(connect))
                {
                    conn.Open();   // открываем подключение
                    SqlCommand comand = new SqlCommand("Select * From [type_application]", conn);
                    // comand.ExecuteNonQueryAsync();
                    SqlDataReader reader = comand.ExecuteReader();

                    while (reader.Read())
                    {
                        string[] row = {reader.GetValue(0).ToString().Trim(),
                                        reader.GetValue(1).ToString().Trim(),
                                        reader.GetValue(2).ToString().Trim(),
                                        reader.GetValue(3).ToString().Trim(), };
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
                string connect = Form_login.sql_connect;
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
                string connect = Form_login.sql_connect;
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
            update_table_category = true;
            update_table_unit = true;
            update_table_nomenclature = true;
            update_table_post = true;
            update_table_tariff = true;



            // table_type_loadAsync();
            string connect = Form_login.sql_connect + ";MultipleActiveResultSets = True";
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
            table_category_loadAsync();
            table_unit_loadAsync();
            table_post_loadAsync();
            table_tariff_loadAsync();

            textbox_category_load(comboBox1);
            table_nomenclature(dataGridView6, comboBox1);

            textbox_name_load(comboBox2, comboBox1);
            
            flag_textbox_name = true;
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
                update_table_type = true;
                table_type_loadAsync();
                //  dataGridView3.Rows.Clear();



            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form_new_edit_archive new_edit_archive_form = new Form_new_edit_archive(1);
            new_edit_archive_form.StartPosition = FormStartPosition.CenterScreen;
            new_edit_archive_form.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);
            Form_new_edit_archive new_edit_archive_form = new Form_new_edit_archive(2, id);
            new_edit_archive_form.StartPosition = FormStartPosition.CenterScreen;
            new_edit_archive_form.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            update_table_category = false;
            int id = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value);
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = provaider.Properties.Resources.conn_string;
                    conn.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM [products_categories] WHERE id='" + id + "'", conn);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    string connect = provaider.Properties.Resources.conn_string;
                }
                update_table_category = true;
                table_category_loadAsync();
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

            Form_edit_new_unit edit_new_unit_form = new Form_edit_new_unit(true);
            edit_new_unit_form.StartPosition = FormStartPosition.CenterScreen;
            edit_new_unit_form.Show();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView5.CurrentRow.Cells[0].Value);
            Form_edit_new_unit edit_new_unit_form = new Form_edit_new_unit(false,id);
            edit_new_unit_form.StartPosition = FormStartPosition.CenterScreen;
            edit_new_unit_form.Show();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            update_table_category = false;
            int id = Convert.ToInt32(dataGridView5.CurrentRow.Cells[0].Value);
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = provaider.Properties.Resources.conn_string;
                    conn.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM [unit_products] WHERE id='" + id + "'", conn);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    string connect = provaider.Properties.Resources.conn_string;
                }
                update_table_unit = true;
                table_unit_loadAsync();
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            Form_nomenclature_new nomenclature_new_form = new Form_nomenclature_new();
            nomenclature_new_form.StartPosition = FormStartPosition.CenterScreen;
            nomenclature_new_form.Show();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag_textbox_name == true)
            {
                update_table_nomenclature = true;
                textbox_name_load(comboBox2, comboBox1);
                table_nomenclature(dataGridView6, comboBox1);
            }
          
        }

        private void Form_directory_adress_FormClosed(object sender, FormClosedEventArgs e)
        {
            flag_textbox_name = false;
        }

        private void button_user_search_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            dataGridView6.ClearSelection();
            for (int counter = 0; counter < (dataGridView6.Rows.Count); counter++)
            {
                string last_name = (String)dataGridView6.Rows[counter].Cells[1].Value;
                if (comboBox2.Text.ToLower() == last_name.ToLower())
                {
                    dataGridView6.Rows[counter].Selected = true;
                    dataGridView6.CurrentCell = dataGridView6.Rows[counter].Cells[1];
                    flag = true;
                }
                dataGridView6.FirstDisplayedScrollingRowIndex = counter;

            }
            if (flag == false)
            {
                MessageBox.Show("Совпадений не обнаружено", "Предупреждение");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Form_nomenclature_edit nomenclature_edit_form = new Form_nomenclature_edit(Convert.ToInt32(dataGridView6.CurrentRow.Cells[0].Value), Convert.ToInt32(dataGridView6.CurrentRow.Cells[5].Value), Convert.ToInt32(dataGridView6.CurrentRow.Cells[4].Value), Convert.ToString(dataGridView6.CurrentRow.Cells[1].Value));
            nomenclature_edit_form.StartPosition = FormStartPosition.CenterScreen;
            nomenclature_edit_form.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            update_table_nomenclature = false;
            int id = Convert.ToInt32(dataGridView6.CurrentRow.Cells[0].Value);
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно, данные в связазнных таблицах будут удалены!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = provaider.Properties.Resources.conn_string;
                    conn.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM [products] WHERE id='" + id + "'", conn);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    string connect = provaider.Properties.Resources.conn_string;
                }
                update_table_nomenclature = true;
                table_nomenclature(dataGridView6, comboBox1);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Form_post_new form_Post_New = new Form_post_new();
            form_Post_New.StartPosition = FormStartPosition.CenterScreen;
            form_Post_New.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Form_post_edit form_Post_Edit = new Form_post_edit(Convert.ToInt32(dataGridView7.CurrentRow.Cells[0].Value), Convert.ToString(dataGridView7.CurrentRow.Cells[1].Value));
            form_Post_Edit.StartPosition = FormStartPosition.CenterScreen;
            form_Post_Edit.Show();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            update_table_post = false;
            int id = Convert.ToInt32(dataGridView7.CurrentRow.Cells[0].Value);
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно, данные в связазнных таблицах будут удалены!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = provaider.Properties.Resources.conn_string;
                    conn.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM [post] WHERE id='" + id + "'", conn);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    string connect = provaider.Properties.Resources.conn_string;
                }
                update_table_post = true;
                table_post_loadAsync();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            //
            Form_tariff_new form_Tariff_New = new Form_tariff_new();
            form_Tariff_New.StartPosition = FormStartPosition.CenterScreen;
            form_Tariff_New.Show();

        }

        private void button23_Click(object sender, EventArgs e)
        {
            Form_tariff_edit form_Tariff_Edit = new Form_tariff_edit(Convert.ToInt32(dataGridView8.CurrentRow.Cells[0].Value));
            form_Tariff_Edit.StartPosition = FormStartPosition.CenterScreen;
            form_Tariff_Edit.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            update_table_tariff = false;
            int id = Convert.ToInt32(dataGridView8.CurrentRow.Cells[0].Value);
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно, данные в связазнных таблицах будут удалены!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = provaider.Properties.Resources.conn_string;
                    conn.Open();
                    SqlCommand command = new SqlCommand("DELETE FROM [tariff] WHERE id='" + id + "'", conn);
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                    string connect = provaider.Properties.Resources.conn_string;
                }
                update_table_tariff = true;
                table_tariff_loadAsync();
            }
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }
    }
}
