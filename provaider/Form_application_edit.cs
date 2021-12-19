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
    public partial class Form_application_edit : Form
    {
        int id;
        public Form_application_edit(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        public static class products_new
        {
            public static int id { get; set; }
            public static string id_product { get; set; }
            public static string category { get; set; }
            public static string idenfity { get; set; }
            public static string volume { get; set; }
            public static string price { get; set; }
            public static string id_category { get; set; }
            public static string id_unit { get; set; }
            public static string name { get; set; }
            public static string unit { get; set; }
            public static string sum { get; set; }
            public static Boolean flag { get; set; } = false;

        }
        public void table_update()
        {
            if (products_new.flag == true)
            {
                dataGridView_employee.Rows.Add("", products_new.id_product, products_new.name, products_new.category, products_new.idenfity, products_new.volume, products_new.price, products_new.sum, products_new.id_category, products_new.id_unit, products_new.id);
            }
            products_new.flag = false;
        }
        class employee
        {
            public int id { get; set; }
            public string name { get; set; }

        }
        private void ComboBox_vid()
        {
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {

                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [name] From [type_application]", conn);
                List<employee> employee_list = new List<employee>();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    employee_list.Add(new employee() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                }


                comboBox1.DataSource = employee_list;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
            }

            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {

                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [description],[description_texnik], [type], Format([date_receipt],'dd.MM.yyyy H:mm:ss') From [applications] WHERE id=" + id, conn);
                SqlDataReader reader = comand.ExecuteReader();
                if (reader.Read())
                {
                    textBox_description.Text = reader.GetValue(0).ToString();
                    textBox1.Text = reader.GetValue(1).ToString();
                    comboBox1.SelectedValue = Convert.ToInt32(reader.GetValue(2).ToString());
                    date_receipt.Value = Convert.ToDateTime(reader.GetValue(3).ToString());

                }



            }
        }

        private void table_tex()
        {
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {

                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [last_name], [first_name], [patronymic] From [employee] where [id_post]=1", conn);
                List<employee> employee_list = new List<employee>();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    employee_list.Add(new employee() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() + " " + (string)reader.GetValue(2).ToString().Trim() + " " + (string)reader.GetValue(3).ToString().Trim() });
                }
                //products_purchase 
                Column9.DataSource = employee_list;
                Column9.DisplayMember = "name";
                Column9.ValueMember = "id";

            }
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {

                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT  employee.id From employee JOIN [emp_app] ON [emp_app].id_emp = [employee].id JOIN [applications] ON [applications].id = [emp_app].id_app where applications.id =" + id, conn);
                SqlDataReader reader = comand.ExecuteReader();
                int id_grid = 0;
                while (reader.Read())
                {
                    dataGridView1.Rows.Add();
                    dataGridView1[0, id_grid].Value = Convert.ToInt32(reader.GetValue(0).ToString());
                    id_grid++;
                }
                //products_purchase 



            }

        }
        private void table_pur()
        {
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {

                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [products_purchase].[id], [products].[id] ,[products].name,[products_categories].[name],[identifier],[products_purchase].[volume],[products_purchase].[price],[products].[id_unit],[products].[id_category],[id_sklad] FROM[provaider_basa].[dbo].[products_purchase] JOIN[applications] ON[applications].id = [products_purchase].[id_applications] JOIN[products] ON[products].id = [products_purchase].[id_product] JOIN[products_categories] ON[products].[id_category] = [products_categories].id Where[applications].id=" + id, conn);

                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    dataGridView_employee.Rows.Add(reader.GetValue(0).ToString().Trim(), reader.GetValue(1).ToString().Trim(), reader.GetValue(2).ToString().Trim(), reader.GetValue(3).ToString().Trim(), reader.GetValue(4).ToString().Trim(), reader.GetValue(5).ToString().Trim(), reader.GetValue(6).ToString().Trim(),Convert.ToDecimal(reader.GetValue(6).ToString().Trim())* Convert.ToDecimal(reader.GetValue(5).ToString().Trim()), reader.GetValue(7).ToString().Trim(), reader.GetValue(8).ToString().Trim(), reader.GetValue(9).ToString().Trim());
                }


            }
        }
        private void contract_load()
        {
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {
                string sql = "Select [last_name],[first_name],[patronymic],[city]+', '+[street]+', '+[house]+', '+[flat], [distance], [telephone], [passport_series], [passport_number], [time_before],FORMAT([data_birth], 'dd/MM/yyyy' ),FORMAT([date_conclusion], 'dd/MM/yyyy' )   From [contract] JOIN [applications] ON  [applications].[id_contract] = [contract].[id] where applications.id =" + id;
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    label2.Text += id; //id
                    textBox_last_name.Text = reader.GetValue(0).ToString().Trim();    //фамилия
                    textBox_first_name.Text = reader.GetValue(1).ToString().Trim();   //имя
                    textBox_patronymic.Text = reader.GetValue(2).ToString().Trim();   //очетсво
                    textBox_adres.Text = reader.GetValue(3).ToString().Trim();       //адресc
                    textBox3.Text = reader.GetValue(4).ToString().Trim();       //расстояние
                    maskedTextBox1.Text = reader.GetValue(5).ToString().Trim();      //телефон
                    textBox_passport_series.Text = reader.GetValue(6).ToString().Trim();      //серия паспорта
                    textBox_passport_number.Text = reader.GetValue(7).ToString().Trim();      //номер паспорта
                    textBox2.Text = reader.GetValue(8).ToString().Trim(); //время прибытия
                    textBox_birth_date.Value = Convert.ToDateTime(reader.GetValue(9).ToString().Trim());   //дата рождения
                    date_conclusion.Value = Convert.ToDateTime(reader.GetValue(10).ToString().Trim());        //дата заключения договора  

                }

            }
        }
        private void Form_application_edit_Load(object sender, EventArgs e)
        {
            contract_load();
            ComboBox_vid();
            table_tex();
            table_pur();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridView1.Rows.Count > 0)
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);

            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {
                string sql = "DELETE  FROM [emp_app] where [emp_app].[id_app]=" + id;
                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();
                command.ExecuteNonQuery();
            }
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {
                string sql = "DELETE  FROM [products_purchase] where [products_purchase].[id_applications]=" + id;
                SqlCommand command = new SqlCommand(sql, conn);
                conn.Open();
                command.ExecuteNonQuery();
            }
            if (dataGridView1.Rows.Count > 0)
            {
                using (SqlConnection conn = new SqlConnection())
                {

                    conn.ConnectionString = Form_login.sql_connect;
                    string sql_emp_app = "INSERT INTO [emp_app] ([id_app],[id_emp]) VALUES (" + id + "," + Convert.ToString(dataGridView1.Rows[0].Cells[0].Value) + ")";
                    for (int i = dataGridView1.Rows.Count - 1; i > 1; i--)
                    {

                        sql_emp_app += ", (" + id + "," + Convert.ToString(dataGridView1.Rows[i - 1].Cells[0].Value) + ")";
                    }

                    SqlCommand command = new SqlCommand(sql_emp_app, conn);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();


                }
            }
            if (dataGridView_employee.Rows.Count > 0) { 
            using (SqlConnection conn = new SqlConnection())
            {

                conn.ConnectionString = Form_login.sql_connect;


                string Sql = "INSERT INTO[products_purchase]([id_product],[id_applications],[price],[volume],[identifier],[id_sklad])  VALUES "; //(@id_products, @id_contract, @volume, @identifier, @price)
                if (dataGridView_employee.Rows.Count == 1)
                {
                    for (int i = dataGridView_employee.Rows.Count; i > 0; i--)
                    {

                        Sql += " ((" + dataGridView_employee.Rows[i - 1].Cells[1].Value + "), (" + id + "), (" + dataGridView_employee.Rows[i - 1].Cells[6].Value + "), (" + dataGridView_employee.Rows[i - 1].Cells[5].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[4].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[10].Value + ")) ";
                    }
                }
                else if (dataGridView_employee.Rows.Count > 0)
                {
                    for (int i = dataGridView_employee.Rows.Count; i > 0; i--)
                    {

                        Sql += " ((" + dataGridView_employee.Rows[i - 1].Cells[1].Value + "), (" + id + "), (" + dataGridView_employee.Rows[i - 1].Cells[6].Value + "), (" + dataGridView_employee.Rows[i - 1].Cells[5].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[4].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[10].Value + ")),";
                    }
                    // индекс последнего символа
                    int ind = Sql.Length - 1;
                    // вырезаем последний символ
                    Sql = Sql.Remove(ind);
                }

                //заполнение таблицы сотруднки
                SqlCommand command = new SqlCommand(Sql, conn);




                command.Connection.Open();
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            }
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {
                conn.Open();

                SqlCommand command = new SqlCommand("UPDATE [applications] SET [description] = '" + textBox_description.Text + "', [description_texnik] = '"+textBox1.Text+ "', [type] = '"+comboBox1.SelectedValue+"' where [id] = " + id, conn);







                command.ExecuteNonQuery();


                command.Connection.Close();

            }
            Form_menu.application_update = true;
            flag_closed = true;
            this.Close();
        }
        Boolean flag_closed = false;
        private void button18_Click(object sender, EventArgs e)
        {
            Form_applications_new_products_new form_Applications_New_Products_New = new Form_applications_new_products_new(3);
            form_Applications_New_Products_New.StartPosition = FormStartPosition.CenterScreen;
            form_Applications_New_Products_New.ShowDialog();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void Form_application_edit_Activated(object sender, EventArgs e)
        {
            table_update();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {
                conn.Open();
                int id = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[10].Value);
                int volume = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[5].Value);
                SqlCommand command = new SqlCommand("UPDATE [products_warehouse] SET [volume] = [volume] + " + volume + " where [id] = " + id, conn);
                command.ExecuteNonQuery();
                command.Connection.Close();
            }
            int ind = dataGridView_employee.SelectedCells[0].RowIndex;
            dataGridView_employee.Rows.RemoveAt(ind);
        }

        private void Form_application_edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
