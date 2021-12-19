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
    public partial class Form_warehouse : Form
    {
        public Form_warehouse()
        {
            InitializeComponent();
        }

        public static Boolean flag_textbox_name = false;
        public static Boolean flag_table_update = false;

        private void table_load(DataGridView dataGrid,ComboBox combo_category)
        {
            string string_connection = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                string SqlString;
                if (combo_category.Text == "Все")
                {
                    SqlString = "Select [products_warehouse].[id], [products].[name],[products_categories].[name], [unit_products].name,[products_warehouse].[volume],[products_warehouse].[price], [products].[id_category],[products].[id_unit] FROM  [products] JOIN [products_warehouse] ON [products_warehouse].[id_products] =  [products].[id]  JOIN [products_categories] ON [products_categories].[id] =  [products].[id_category] JOIN [unit_products] ON [unit_products].[id] =  [products].[id_unit]  ";
                }
                else
                {
                    SqlString = "Select [products_warehouse].[id], [products].[name],[products_categories].[name], [unit_products].name,[products_warehouse].[volume],[products_warehouse].[price], [products].[id_category],[products].[id_unit] FROM  [products] JOIN [products_warehouse] ON [products_warehouse].[id_products] =  [products].[id]  JOIN [products_categories] ON [products_categories].[id] =  [products].[id_category] JOIN [unit_products] ON [unit_products].[id] =  [products].[id_unit]    where [products].[id_category]=" + combo_category.SelectedValue;
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
                        SqlString = "SELECT  [name] From [products] JOIN [products_warehouse] ON [products].[id] =[products_warehouse].[id_products] where [products].[id_category]=" + combo_category.SelectedValue;
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

        private void button_employee_new_Click(object sender, EventArgs e)
        {
            Form_warehouse_new warehouse_new_form = new Form_warehouse_new();
            warehouse_new_form.StartPosition = FormStartPosition.CenterParent;
            warehouse_new_form.Show();
        }

        private void Form_warehouse_Load(object sender, EventArgs e)
        {

            //textbox_category_load(comboBox1);
            flag_table_update = true;
          //  textbox_name_load(comboBox2, comboBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (flag_textbox_name == true) { 
              textbox_name_load(comboBox2, comboBox1);
              table_load(dataGridView_employee, comboBox1);
            }
        }

        private void Form_warehouse_Activated(object sender, EventArgs e)
        {
            textbox_category_load(comboBox1);
            textbox_name_load(comboBox2, comboBox1);
            if (flag_table_update == true)
            {
                table_load(dataGridView_employee, comboBox1);
                flag_table_update = false;
            }
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

        private void button_employee_edit_Click(object sender, EventArgs e)
        {
            Form_warehouse_edit warehouse_edit_form = new Form_warehouse_edit(Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[0].Value), Convert.ToString(dataGridView_employee.CurrentRow.Cells[1].Value), Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[6].Value), Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[7].Value), Convert.ToString(dataGridView_employee.CurrentRow.Cells[4].Value), Convert.ToDecimal(dataGridView_employee.CurrentRow.Cells[5].Value));
            warehouse_edit_form.StartPosition = FormStartPosition.CenterParent;
            warehouse_edit_form.Show();
        }

        private void Form_warehouse_Deactivate(object sender, EventArgs e)
        {

        }

        private void Form_warehouse_FormClosed(object sender, FormClosedEventArgs e)
        {
            flag_textbox_name = false;
        }

        private void button_employee_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Form_login.sql_connect;
                conn.Open();

                SqlCommand command = new SqlCommand("DELETE FROM [products_warehouse] WHERE id='" + (string)dataGridView_employee.CurrentRow.Cells[0].Value + "'", conn);
                command.ExecuteNonQuery();
                command.Connection.Close();
                table_load(dataGridView_employee, comboBox1);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
