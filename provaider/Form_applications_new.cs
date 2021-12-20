using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace provaider
{
    public partial class Form_applications_new : Form
    {
        private string[] data_contract;
        public Form_applications_new(string[] data_contract)
        {
            InitializeComponent();
            this.data_contract = data_contract;
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
        Boolean flag_closed = false;
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox_flat_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        class employee
        {
            public int id { get; set; }
            public string name { get; set; }

        }
        public static class products
        {
            public static string name0 { get; set; } //1
            public static string name1 { get; set; } //2
            public static string name2 { get; set; } //3
            public static string name3 { get; set; } //4
            public static string name4 { get; set; } //5
            public static string name5 { get; set; } //6
            public static string name6 { get; set; } //7
            public static string name7 { get; set; } //8
            public static string name8 { get; set; } //9
            public static string name9 { get; set; } //10
            public static string name10 { get; set; } //11
            public static Boolean name11 { get; set; } //12
        }
        public void table_update()
        {
            if (products_new.flag == true)
            {
                dataGridView_employee.Rows.Add("", products_new.id_product, products_new.name, products_new.category, products_new.idenfity, products_new.volume, products_new.price, products_new.sum, products_new.id_category, products_new.id_unit, products_new.id);
            }
            products_new.flag = false;
        }
        private void Form_applications_new_Load(object sender, EventArgs e)
        {
            products.name11 = false;
            //заполнение полей
            label2.Text += data_contract[0];
            textBox_last_name.Text = data_contract[1];
            textBox_first_name.Text = data_contract[2];
            textBox_patronymic.Text = data_contract[3];
            maskedTextBox1.Text = data_contract[4];
            textBox_adres.Text = data_contract[5];
            textBox_birth_date.Value = Convert.ToDateTime(data_contract[9]);
            textBox_passport_series.Text = data_contract[7];
            textBox_passport_number.Text = data_contract[8];
            date_conclusion.Value = Convert.ToDateTime(data_contract[6]);
            textBox3.Text= data_contract[10];
            textBox2.Text= data_contract[11];

            //заполнение техников
            string string_connection = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [last_name], [first_name], [patronymic] From [employee] where [id_post]=1", conn);
                List<employee> employee_list = new List<employee>();
                SqlDataReader reader = comand.ExecuteReader();
                while(reader.Read())
                {
                   employee_list.Add(new employee() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim()+" "+ (string)reader.GetValue(2).ToString().Trim()+" "+ (string)reader.GetValue(3).ToString().Trim() });
                }


                //comboBox2.DataSource = employee_list;
                // comboBox2.DisplayMember = "name";
                // comboBox2.ValueMember = "id";
                Column9.DataSource = employee_list;
                Column9.DisplayMember = "name";
                Column9.ValueMember = "id";
            }
            //заполнение вид услуг
            using (SqlConnection conn = new SqlConnection(string_connection))
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

            
        }
        public string id;
        private void button_user_new_Click(object sender, EventArgs e)
        {
           
        }

        private void button18_Click(object sender, EventArgs e)
        {
           // Form_applications_new_products_new applications_new_products_new_form = new Form_applications_new_products_new();
           // applications_new_products_new_form.StartPosition = FormStartPosition.CenterScreen;
           //applications_new_products_new_form.ShowDialog();


        }

        private void Form_applications_new_Activated(object sender, EventArgs e)
        {
            table_update();
            if (products.name11 == true)
            {
                dataGridView_employee.Rows.Add(products.name0, products.name1, products.name2, products.name3, products.name4, products.name5, products.name6, products.name7, products.name8, products.name9, products.name10);
                products.name11 = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1 && dataGridView1.Rows.Count > 0)
            {

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            Form_applications_new_products_new form_Applications_New_Products_New = new Form_applications_new_products_new(2);
            form_Applications_New_Products_New.StartPosition = FormStartPosition.CenterScreen;
            form_Applications_New_Products_New.ShowDialog();
        }
        string tariff, login;
        private void button6_Click(object sender, EventArgs e)
        {
            flag_closed = true;
            if (dataGridView_employee.Rows.Count > 0)
            {
                using (SqlConnection conn = new SqlConnection())
                {

                    conn.ConnectionString = Form_login.sql_connect;


                    string Sql = "INSERT INTO[user_products]([id_products],[id_contract],[volume],[identifier],[price])  VALUES "; //(@id_products, @id_contract, @volume, @identifier, @price)
                    if (dataGridView_employee.Rows.Count == 1)
                    {
                        for (int i = dataGridView_employee.Rows.Count; i > 0; i--)
                        {

                            Sql += " ((" + dataGridView_employee.Rows[i - 1].Cells[1].Value + "), (" + data_contract[0] + "), (" + dataGridView_employee.Rows[i - 1].Cells[5].Value + "), (" + dataGridView_employee.Rows[i - 1].Cells[4].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[6].Value + "))";
                        }
                    }
                    else if (dataGridView_employee.Rows.Count > 0)
                    {
                        for (int i = dataGridView_employee.Rows.Count; i > 0; i--)
                        {

                            Sql += " ((" + dataGridView_employee.Rows[i - 1].Cells[1].Value + "), (" + data_contract[0] + "), (" + dataGridView_employee.Rows[i - 1].Cells[5].Value + "), (" + dataGridView_employee.Rows[i - 1].Cells[4].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[6].Value + ")),";
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
                //заявка создание
            }
                using (SqlConnection conn = new SqlConnection())
                {

                    conn.ConnectionString = Form_login.sql_connect;






                    //заполнение таблицы сотруднки
                    SqlCommand command = new SqlCommand("INSERT INTO [applications] ([status],[type],[description],[date_receipt],[id_contract],[id_employee],[description_texnik]) VALUES(@status, @type, @description, '"+date_receipt.Value.ToString("dd-MM-yyyy HH:mm:ss") +"', @id_contract, @id_employee,@description_texnik)", conn);
                    //@tariff, @mac,@login_kab, @password_kab, @personal_account, @wifi_login, @wifi_password
                    command.Parameters.AddWithValue("@status", "Ожидание");
                    command.Parameters.AddWithValue("@type", comboBox1.SelectedValue);
                    command.Parameters.AddWithValue("@description", textBox_description.Text);
                    command.Parameters.AddWithValue("@description_texnik", textBox1.Text);
                    command.Parameters.AddWithValue("@id_contract", data_contract[0]);
                    command.Parameters.AddWithValue("@id_employee", Form_login.id_maneger);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                    command.Connection.Close();
                }

                //id заявки
                using (SqlConnection conn = new SqlConnection())
                {

                    conn.ConnectionString = Form_login.sql_connect;

                    SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT ('applications')", conn);
                    command.Connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                    data_contract[0] = Convert.ToString((string)reader.GetValue(0).ToString().Trim());
                    }

                    command.Connection.Close();
                }



                if (dataGridView_employee.Rows.Count > 0)
                {
                    using (SqlConnection conn = new SqlConnection())
                    {

                        conn.ConnectionString = Form_login.sql_connect;


                        string Sql = "INSERT INTO[products_purchase]([id_product],[id_applications],[price],[volume],[identifier],[id_sklad])  VALUES "; //(@id_products, @id_contract, @volume, @identifier, @price)
                        if (dataGridView_employee.Rows.Count == 1)
                        {
                            for (int i = dataGridView_employee.Rows.Count; i > 0; i--)
                            {

                                Sql += " ((" + dataGridView_employee.Rows[i - 1].Cells[1].Value + "), (" + data_contract[0] + "), (" + dataGridView_employee.Rows[i - 1].Cells[6].Value + "), (" + dataGridView_employee.Rows[i - 1].Cells[5].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[4].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[10].Value + "))";
                            }
                        }
                        else if (dataGridView_employee.Rows.Count > 0)
                        {
                            for (int i = dataGridView_employee.Rows.Count; i > 0; i--)
                            {

                                Sql += " ((" + dataGridView_employee.Rows[i - 1].Cells[1].Value + "), (" + data_contract[0] + "), (" + dataGridView_employee.Rows[i - 1].Cells[6].Value + "), (" + dataGridView_employee.Rows[i - 1].Cells[5].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[4].Value + ") ,(" + dataGridView_employee.Rows[i - 1].Cells[10].Value + ")),";
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
                string sql_emp_app;
                if (dataGridView1.Rows.Count > 0)
                {
                    using (SqlConnection conn = new SqlConnection())
                    {

                        conn.ConnectionString = Form_login.sql_connect;
                        sql_emp_app = "INSERT INTO [emp_app] ([id_app],[id_emp]) VALUES (" + data_contract[0] + "," + Convert.ToString(dataGridView1.Rows[0].Cells[0].Value) + ")";
                        for (int i = dataGridView1.Rows.Count - 1; i > 1; i--)
                        {

                            sql_emp_app += ", (" + data_contract[0] + "," + Convert.ToString(dataGridView1.Rows[i - 1].Cells[0].Value) + ")";
                        }

                        SqlCommand command = new SqlCommand(sql_emp_app, conn);
                        command.Connection.Open();
                        command.ExecuteNonQuery();
                        command.Connection.Close();


                    }
                }

           
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {
                string sql = "Select  [tariff].[name],[contract].[login_kab]  From [contract] JOIN [applications] ON  [applications].[id_contract] = [contract].[id] JOIN [tariff] ON [contract].[id_tariff] = [tariff].[id] where [applications].[id] = " + data_contract[0];
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {

                    tariff = reader.GetValue(0).ToString().Trim();    //фамилия
                    login = reader.GetValue(1).ToString().Trim();   //имя
                                                                    //дата заключения договора  

                }

            }
            try
            {
                var WordApp = new Microsoft.Office.Interop.Word.Application();
                WordApp.Visible = false;
                // string woo = Path.Combine(Application.StartupPath);
                // woo = woo + @"\dogovor.dotx";

                string woo = Path.Combine(Application.StartupPath);
                woo = woo + @"\task.dotx";
                //  woo = woo + @"\prikaz_na_otpusk.dotx";
                // var WordDocument = WordApp.Documents.Open(@"C:\Users\Дмитрий\Documents\sql_S\Basa_sql\Basa_sql\prikaz_na_otpusk.dotx");
                var WordDocument = WordApp.Documents.Open(woo);
                var range = WordDocument.Content;
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: "{number}", ReplaceWith: id);
                range = WordDocument.Content;
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: "{date}", ReplaceWith: date_receipt.Text);
                range.Find.ClearFormatting();
                range = WordDocument.Content;
                range.Find.Execute(FindText: "{adress}", ReplaceWith: textBox_adres.Text);
                range.Find.ClearFormatting();
                range = WordDocument.Content;
                range.Find.Execute(FindText: "{fio}", ReplaceWith: textBox_last_name.Text + " " + textBox_first_name.Text + " " + textBox_patronymic.Text);
                range.Find.ClearFormatting();
                range = WordDocument.Content;
                range.Find.Execute(FindText: "{login}", ReplaceWith: login);
                range.Find.ClearFormatting();
                range = WordDocument.Content;
                range.Find.Execute(FindText: "{telefon}", ReplaceWith: maskedTextBox1.Text);
                range.Find.ClearFormatting();
                range = WordDocument.Content;
                range.Find.Execute(FindText: "{tarif}", ReplaceWith: tariff);
                range.Find.ClearFormatting();
                range = WordDocument.Content;
                range.Find.Execute(FindText: "{vid}", ReplaceWith: comboBox1.Text);
                range.Find.ClearFormatting();
                range = WordDocument.Content;
                range.Find.Execute(FindText: "{opisanie}", ReplaceWith: textBox1.Text);
                range.Find.ClearFormatting();
                range = WordDocument.Content;
                range.Find.Execute(FindText: "{men}", ReplaceWith: Form_menu.fios);
                range.Find.ClearFormatting();
                range = WordDocument.Content;
                range.Find.Execute(FindText: "{tex}", ReplaceWith: Convert.ToString(dataGridView1.Rows[0].Cells[0].Value));
                range.Find.ClearFormatting();


                //   Microsoft.Office.Interop.Word._Document document;

                //  Microsoft.Office.Interop.Word.Table _table = WordDocument.Tables[1];
                //   WordDocument.Tables.Add(range, 2, 1, Type.Missing, Type.Missing);
                // WordDocument.Tables[1].Cell(2, 1).Range.InsertAfter("v");   
                Microsoft.Office.Interop.Word.Table table2 = WordDocument.Tables[1];
                for (int i = 0; i < dataGridView1.RowCount - 1; i++)

                {
                    DataGridViewComboBoxCell dgvcmbcell = dataGridView1[0, i] as DataGridViewComboBoxCell;
                    String text = dgvcmbcell.EditedFormattedValue.ToString();
                    table2.Rows.Add(Type.Missing);
                    table2.Cell(i + 1, 1).Range.Text = text;

                }

                Microsoft.Office.Interop.Word.Table table = WordDocument.Tables[2];
                for (int i = 0; i < dataGridView_employee.RowCount; i++)

                {

                    table.Rows.Add(Type.Missing);
                    table.Cell(i + 2, 1).Range.Text = (string)dataGridView_employee[3, i].Value;
                    table.Cell(i + 2, 2).Range.Text = (string)dataGridView_employee[2, i].Value;
                    table.Cell(i + 2, 3).Range.Text = (string)dataGridView_employee[4, i].Value;
                    table.Cell(i + 2, 4).Range.Text = (string)dataGridView_employee[6, i].Value;
                    table.Cell(i + 2, 5).Range.Text = (string)dataGridView_employee[5, i].Value;
                    table.Cell(i + 2, 6).Range.Text = Convert.ToString(dataGridView_employee[7, i].Value);
                }



                WordApp.Visible = true;
                // table.Cell(1, 1).Range.Text = "23344";

                // table.Rows.Add();

                //  table.Rows.Add(Type.Missing);




            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }

            Form_menu.application_update = true;
                this.Close();

            }

        private void button16_Click(object sender, EventArgs e)
        {
            string string_connection = Form_login.sql_connect;
            using (SqlConnection conn = new SqlConnection(string_connection))
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

        private void Form_applications_new_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (flag_closed == false)
            {
                for (int i = dataGridView_employee.Rows.Count; i > 0; i--)
                {
                    int int_del = Convert.ToInt32(dataGridView_employee.Rows[i - 1].Cells[5].Value);
                    string string_connection = Form_login.sql_connect;
                    using (SqlConnection conn = new SqlConnection(string_connection))
                    {
                        conn.Open();
                        int id = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[10].Value);

                        SqlCommand command = new SqlCommand("UPDATE [products_warehouse] SET [volume] = [volume] + " + int_del + " where [id] = " + id, conn);

                        command.ExecuteNonQuery();


                        command.Connection.Close();

                    }
                }
            }
        }

        private void date_conclusion_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_passport_number_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox_passport_series_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox_birth_date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_patronymic_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_first_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_last_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void date_receipt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox_adres_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_employee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
