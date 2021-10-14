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
        private void Form_applications_new_Load(object sender, EventArgs e)
        {
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

            //заполнение техников
            string string_connection = provaider.Properties.Resources.conn_string;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [last_name], [first_name], [patronymic] From [employee]", conn);
                List<employee> employee_list = new List<employee>();
                SqlDataReader reader = comand.ExecuteReader();
                while(reader.Read())
                {
                   employee_list.Add(new employee() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim()+" "+ (string)reader.GetValue(2).ToString().Trim()+" "+ (string)reader.GetValue(3).ToString().Trim() });
                }
                

                comboBox2.DataSource = employee_list;
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "id";
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
            string string_connection = provaider.Properties.Resources.conn_string;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                
                SqlCommand command = new SqlCommand("INSERT INTO [applications] ([status],[type],[description],[date_receipt],[id_contract],[id_employee])  VALUES('Выполняется', @type,@description,convert(varchar, convert(datetime, '" + date_receipt.Text + "', 104), 121),@id_contract,@id_employee )", conn);
                command.Parameters.AddWithValue("@description", textBox_description.Text);
                command.Parameters.AddWithValue("@id_contract", data_contract[0]);
                command.Parameters.AddWithValue("@id_employee", comboBox2.SelectedValue);
                command.Parameters.AddWithValue("@type", comboBox1.SelectedValue);                                            
                command.ExecuteNonQuery();
                Form_menu.application_update = true;
            }


            DialogResult dialogResult = MessageBox.Show("Распечатать договор об указание услуг?", "Предупреждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                
                using (SqlConnection conn = new SqlConnection(string_connection))
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand("SELECT IDENT_CURRENT('contract')", conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read()) {
                        id = reader.GetValue(0).ToString(); }
                  
                }
               // string s = date_receipt.Text;
                //string[] city = s.Split(new char[] { ' ' });
                try
                {
                    var WordApp = new Microsoft.Office.Interop.Word.Application();
                    WordApp.Visible = false;
                    string woo = Path.Combine(Application.StartupPath);
                    woo = woo + @"\dogovor_uslugi.dotx";
                   // string woo = @"C:\Users\Дмитрий\Desktop\12\dogovor_uslugi.dotx";
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
                    range.Find.Execute(FindText: "{name}", ReplaceWith: textBox_last_name.Text+" "+textBox_first_name.Text+" "+textBox_patronymic.Text);
                    range.Find.ClearFormatting();
                    range = WordDocument.Content;
                    range.Find.Execute(FindText: "{type}", ReplaceWith: comboBox1.Text);
                    range.Find.ClearFormatting();
                    range = WordDocument.Content;


                    WordApp.Visible = true;
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка");
                }
            }
                this.Close();
        }
    }
}
