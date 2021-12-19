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
    public partial class Form_applications_new_products_new : Form
    {
        DataTable produst_data;
        int flag_form;
        
        public Form_applications_new_products_new(int flag_form)
        {
            InitializeComponent();
            this.flag_form = flag_form;
        }
        Boolean flag_textbox_name = false;
    
        private void button_employee_edit_Click(object sender, EventArgs e)
        {
            if (flag_form == 1)
            {
                if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[5].Value) && textBox1.Text != "" && Convert.ToInt32(textBox1.Text) <= 0)
                {
                    MessageBox.Show("Проверьте количество выбранного товара", "Ошибка")
    ;
                }


                string string_connection = Form_login.sql_connect;
                //класс заполнитть
                Form_customers_new.products.id = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[0].Value);
                Form_customers_new.products.id_product = (string)dataGridView_employee.CurrentRow.Cells[8].Value;
                Form_customers_new.products.id_category = (string)dataGridView_employee.CurrentRow.Cells[6].Value;
                Form_customers_new.products.id_unit = (string)dataGridView_employee.CurrentRow.Cells[7].Value;
                Form_customers_new.products.price = (string)dataGridView_employee.CurrentRow.Cells[5].Value;
                Form_customers_new.products.volume = textBox1.Text;
                Form_customers_new.products.name = (string)dataGridView_employee.CurrentRow.Cells[1].Value;
                Form_customers_new.products.category = (string)dataGridView_employee.CurrentRow.Cells[2].Value;
                Form_customers_new.products.unit = (string)dataGridView_employee.CurrentRow.Cells[3].Value;
                decimal sum = Convert.ToDecimal((string)dataGridView_employee.CurrentRow.Cells[5].Value) * Convert.ToDecimal(textBox1.Text);
                Form_customers_new.products.sum = Convert.ToString(sum);
                Form_customers_new.products.idenfity = textBox2.Text;


                Form_customers_new.products.flag = true;



                using (SqlConnection conn = new SqlConnection(string_connection))
                {
                    conn.Open();
                    int id = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[0].Value);
                    SqlCommand command = new SqlCommand("UPDATE [products_warehouse] SET [volume] = [volume] - " + Convert.ToInt32(textBox1.Text) + " where [id] = " + id, conn);







                    command.ExecuteNonQuery();


                    command.Connection.Close();

                }
                this.Close();

            }
            if (flag_form==2)
            {
                if (Convert.ToInt32(textBox1.Text) > Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[5].Value) && textBox1.Text != "" && Convert.ToInt32(textBox1.Text) <= 0)
                {
                    MessageBox.Show("Проверьте количество выбранного товара", "Ошибка")
    ;
                }

                else
                {
                    string string_connection = Form_login.sql_connect;
                    //класс заполнитть
                    Form_applications_new.products_new.id = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[0].Value);
                    Form_applications_new.products_new.id_product = (string)dataGridView_employee.CurrentRow.Cells[8].Value;
                    Form_applications_new.products_new.id_category = (string)dataGridView_employee.CurrentRow.Cells[6].Value;
                    Form_applications_new.products_new.id_unit = (string)dataGridView_employee.CurrentRow.Cells[7].Value;
                    Form_applications_new.products_new.price = (string)dataGridView_employee.CurrentRow.Cells[5].Value;
                    Form_applications_new.products_new.volume = textBox1.Text;
                    Form_applications_new.products_new.name = (string)dataGridView_employee.CurrentRow.Cells[1].Value;
                    Form_applications_new.products_new.category = (string)dataGridView_employee.CurrentRow.Cells[2].Value;
                    Form_applications_new.products_new.unit = (string)dataGridView_employee.CurrentRow.Cells[3].Value;
                    decimal sum = Convert.ToDecimal((string)dataGridView_employee.CurrentRow.Cells[5].Value) * Convert.ToDecimal(textBox1.Text);
                    Form_applications_new.products_new.sum = Convert.ToString(sum);
                    Form_applications_new.products_new.idenfity = textBox2.Text;


                    Form_applications_new.products_new.flag = true;



                    using (SqlConnection conn = new SqlConnection(string_connection))
                    {
                        conn.Open();
                        int id = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[0].Value);
                        SqlCommand command = new SqlCommand("UPDATE [products_warehouse] SET [volume] = [volume] - " + Convert.ToInt32(textBox1.Text) + " where [id] = " + id, conn);







                        command.ExecuteNonQuery();


                        command.Connection.Close();

                    }
                    this.Close();
                }
            }
            if (flag_form == 3)
            {
                if ((Convert.ToInt32(textBox1.Text) > Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[4].Value)) || (textBox1.Text == "" || Convert.ToInt32(textBox1.Text) <= 0) || (Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[4].Value) <= 0))
                {
                    MessageBox.Show("Проверьте количество выбранного товара", "Ошибка");

                }

                else
                {
                    string string_connection = Form_login.sql_connect;
                    //класс заполнитть
                    Form_application_edit.products_new.id = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[0].Value);
                    Form_application_edit.products_new.id_product = (string)dataGridView_employee.CurrentRow.Cells[8].Value;
                    Form_application_edit.products_new.id_category = (string)dataGridView_employee.CurrentRow.Cells[6].Value;
                    Form_application_edit.products_new.id_unit = (string)dataGridView_employee.CurrentRow.Cells[7].Value;
                    Form_application_edit.products_new.price = (string)dataGridView_employee.CurrentRow.Cells[5].Value;
                    Form_application_edit.products_new.volume = textBox1.Text;
                    Form_application_edit.products_new.name = (string)dataGridView_employee.CurrentRow.Cells[1].Value;
                    Form_application_edit.products_new.category = (string)dataGridView_employee.CurrentRow.Cells[2].Value;
                    Form_application_edit.products_new.unit = (string)dataGridView_employee.CurrentRow.Cells[3].Value;
                    decimal sum = Convert.ToDecimal((string)dataGridView_employee.CurrentRow.Cells[5].Value) * Convert.ToDecimal(textBox1.Text);
                    Form_application_edit.products_new.sum = Convert.ToString(sum);
                    Form_application_edit.products_new.idenfity = textBox2.Text;


                    Form_application_edit.products_new.flag = true;



                    using (SqlConnection conn = new SqlConnection(string_connection))
                    {
                        conn.Open();
                        int id = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[0].Value);
                        SqlCommand command = new SqlCommand("UPDATE [products_warehouse] SET [volume] = [volume] - " + Convert.ToInt32(textBox1.Text) + " where [id] = " + id, conn);







                        command.ExecuteNonQuery();


                        command.Connection.Close();

                    }
                    this.Close();

                }
            }
        }
        private void table_load(DataGridView dataGrid, ComboBox combo_category)
        {
            string string_connection = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                string SqlString;
                if (combo_category.Text == "Все")
                {
                    SqlString = "Select [products_warehouse].[id], [products].[name],[products_categories].[name], [unit_products].name,[products_warehouse].[volume],[products_warehouse].[price], [products].[id_category],[products].[id_unit],[products].[id]  FROM  [products] JOIN [products_warehouse] ON [products_warehouse].[id_products] =  [products].[id]  JOIN [products_categories] ON [products_categories].[id] =  [products].[id_category] JOIN [unit_products] ON [unit_products].[id] =  [products].[id_unit]  ";
                }
                else
                {
                    SqlString = "Select [products_warehouse].[id], [products].[name],[products_categories].[name], [unit_products].name,[products_warehouse].[volume],[products_warehouse].[price], [products].[id_category],[products].[id_unit],[products].[id] FROM  [products] JOIN [products_warehouse] ON [products_warehouse].[id_products] =  [products].[id]  JOIN [products_categories] ON [products_categories].[id] =  [products].[id_category] JOIN [unit_products] ON [unit_products].[id] =  [products].[id_unit]    where [products].[id_category]=" + combo_category.SelectedValue;
                }


                SqlCommand comand = new SqlCommand(SqlString, conn);

                SqlDataReader reader = comand.ExecuteReader();
                //combo_name.Items.Clear();
                dataGrid.Rows.Clear();
                while (reader.Read())
                {
                    string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(),
                                    reader.GetValue(2).ToString().Trim(),
                                    reader.GetValue(3).ToString().Trim(),
                                    reader.GetValue(4).ToString().Trim(),
                                    reader.GetValue(5).ToString().Trim(),
                                    reader.GetValue(6).ToString().Trim(),
                                    reader.GetValue(7).ToString().Trim(),
                                    reader.GetValue(8).ToString().Trim(),

                                    };

                    dataGrid.Rows.Add(row);
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
                    SqlString = "SELECT  [name] From [products] JOIN [products_warehouse] ON [products].[id] =[products_warehouse].[id_products]";
                }
                else
                {
                    SqlString = "SELECT  [name] From [products] JOIN [products_warehouse] ON [products].[id] =[products_warehouse].[id_products] where [products].[id_category]=" + comboBox1.SelectedValue;
                }


                SqlCommand comand = new SqlCommand(SqlString, conn);

                SqlDataReader reader = comand.ExecuteReader();
                combo_name.Items.Clear();
                while (reader.Read())
                {
                    combo_name.Items.Add(reader.GetValue(0));
                }

            }


            flag_textbox_name = true;
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
        private void Form_applications_new_products_new_Load(object sender, EventArgs e)
        {
            textbox_category_load(comboBox1);
            textbox_name_load(comboBox2, comboBox1);
               table_load(dataGridView_employee,comboBox1);
            flag_textbox_name = true;
            //dataGridView_employee.AutoGenerateColumns = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag_textbox_name == true)
            {
                textbox_name_load(comboBox2, comboBox1);
                table_load(dataGridView_employee, comboBox1);
            }
        }

        private void Form_applications_new_products_new_FormClosed(object sender, FormClosedEventArgs e)
        {
            flag_textbox_name = false;
        }

        private void button_user_search_Click(object sender, EventArgs e)
        {
            Boolean flag = false;
            dataGridView_employee.ClearSelection();
            for (int counter = 0; counter < (dataGridView_employee.Rows.Count); counter++)
            {
                string last_name = (String)dataGridView_employee.Rows[counter].Cells[1].Value;
                if (comboBox2.Text.ToLower() == last_name.ToLower())
                {
                    dataGridView_employee.Rows[counter].Selected = true;
                    dataGridView_employee.CurrentCell = dataGridView_employee.Rows[counter].Cells[1];
                    flag = true;
                }
                dataGridView_employee.FirstDisplayedScrollingRowIndex = counter;

            }
            if (flag == false)
            {
                MessageBox.Show("Совпадений не обнаружено", "Предупреждение");
            }
        }
    }
}
