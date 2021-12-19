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
using Word = Microsoft.Office.Interop.Word;

namespace provaider
{
    public partial class Form_otcet_app : Form
    {
        public Form_otcet_app()
        {
            InitializeComponent();
            dataGridView1.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridView1.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
        int id_application;
        class employee
        {
            public int id { get; set; }
            public string name { get; set; }

        }
        private void table_combobox_name_contract()
        {
            String sql = "SELECT DISTINCT [id], [last_name],[first_name],[patronymic] FROM [employee] WHERE [id_post]=1";
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {
                SqlCommand comand = new SqlCommand(sql, conn);
                conn.Open();
                List<employee> employee_list = new List<employee>();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    employee_list.Add(new employee() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() + " " + (string)reader.GetValue(2).ToString().Trim() + " " + (string)reader.GetValue(3).ToString().Trim() });
                }
                comboBox_employee.DataSource = employee_list;
                comboBox_employee.DisplayMember = "name";
                comboBox_employee.ValueMember = "id";
            }
            sql = "SELECT DISTINCT [id], [last_name],[first_name],[patronymic] FROM [contract]";
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {
                SqlCommand comand = new SqlCommand(sql, conn);
                conn.Open();
                List<employee> employee_list = new List<employee>();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    employee_list.Add(new employee() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() + " " + (string)reader.GetValue(2).ToString().Trim() + " " + (string)reader.GetValue(3).ToString().Trim() });
                }
                comboBox_customer.DataSource = employee_list;
                comboBox_customer.DisplayMember = "name";
                comboBox_customer.ValueMember = "id";
            }
            sql = "SELECT [id], [name] FROM [type_application]";
            using (SqlConnection conn = new SqlConnection(Form_login.sql_connect))
            {
                SqlCommand comand = new SqlCommand(sql, conn);
                conn.Open();
                List<employee> employee_list = new List<employee>();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    employee_list.Add(new employee() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                }
                comboBox_type.DataSource = employee_list;
                comboBox_type.DisplayMember = "name";
                comboBox_type.ValueMember = "id";
            }

        }
        public void table_applications_load()
        {
            String sql;
            dataGridView1.Rows.Clear();

            
            using (SqlConnection conn = new SqlConnection())
            {
                sql = "Select [applications].[id],[applications].[description],[applications].[date_receipt],[contract].[last_name],[contract].[first_name],[contract].[patronymic],[contract].[telephone],[contract].[city],[contract].[street],[contract].[house],[contract].[flat],[employee].[last_name],[employee].[first_name],[employee].[patronymic],[type_application].[name],[applications].[status],[applications].[date_completion] FROM  [contract] JOIN [applications] ON [contract].[id] =  [applications].[id_contract]  JOIN[emp_app] ON [emp_app].[id_app] =  [applications].[id] JOIN [employee] ON [emp_app].[id_emp] = [employee].[id] JOIN[type_application] ON[type_application].[id] =  [applications].[type]  where [status] != 'Ожидание' and [status] != 'Выполнение'";
                if (checkBox_status.Checked) sql += $" AND [applications].[status] = '{comboBox_status.Text}'";
                //if (checkBox_type.Checked) sql += $" AND [type_application].[id] = '{comboBox_type.SelectedValue}'";
               
                if (checkBox_employee.Checked)
                {
                    sql += " AND [emp_app].[id_emp] =" + comboBox_employee.SelectedValue; 
                }
                if (checkBox_customer.Checked)
                {
                    sql += " AND [applications].[id_contract] =" + comboBox_customer.SelectedValue;
                }
                if (checkBox_type.Checked)
                {
                    sql += " AND [applications].[type] =" + comboBox_type.SelectedValue; 
                }
                if (checkBox_status.Checked)
                {
                    sql += " AND [applications].[status] ='" + comboBox_status.Text+"'";
                }
                if (checkBox_date_conclusion_from.Checked)
                {
                    sql += " AND [applications].[date_completion] >= '" + date_conclusion_from.Value.ToString("dd/MM/yyyy HH:mm") + "'";
                }
                if (checkBox_date_conclusion_to.Checked)
                {
                    sql += " AND [applications].[date_completion] <= '" + date_conclusion_to.Value.ToString("dd/MM/yyyy HH:mm") + "'";
                }

                //sql += " AND [applications].[date_receipt] < '"+date.ToString("dd/MM/yyyy HH:mm:ss") +"'";


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
                if (reader.Read())
                {
                    table_app[0] = reader.GetValue(0).ToString().Trim();
                    table_app[1] = reader.GetValue(3).ToString().Trim() + " " + reader.GetValue(4).ToString().Trim() + " " + reader.GetValue(5).ToString().Trim();
                    table_app[2] = reader.GetValue(6).ToString().Trim();
                    table_app[3] = reader.GetValue(7).ToString().Trim() + ", " + reader.GetValue(8).ToString().Trim() + ", " + reader.GetValue(9).ToString().Trim() + ", " + reader.GetValue(10).ToString().Trim();
                    table_app[4] = reader.GetValue(14).ToString().Trim();
                    table_app[5] = reader.GetValue(1).ToString().Trim();
                    table_app[6] = reader.GetValue(11).ToString().Trim() + " " + reader.GetValue(12).ToString().Trim() + " " + reader.GetValue(13).ToString().Trim();
                    table_app[7] = reader.GetValue(2).ToString().Trim();
                    table_app[8] = reader.GetValue(16).ToString().Trim();
                    table_app[9] = reader.GetValue(15).ToString().Trim();



                    id_application = Convert.ToInt32(table_app[0]);
                }

                while (reader.Read())
                {
                    if (Convert.ToInt32(reader.GetValue(0)) == id_application)
                    {
                        table_app[6] += "\n" + reader.GetValue(11).ToString().Trim() + " " + reader.GetValue(12).ToString().Trim() + " " + reader.GetValue(13).ToString().Trim();

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
                        table_app[8] = reader.GetValue(16).ToString().Trim();
                        table_app[9] = reader.GetValue(15).ToString().Trim();
                        id_application = Convert.ToInt32(table_app[0]);
                    }

                }
                dataGridView1.Rows.Add(table_app);


            }

        }
        private void Form_otcet_app_Load(object sender, EventArgs e)
        {
            table_combobox_name_contract();
            table_applications_load();
            comboBox_status.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table_applications_load();
        }

        private void button_employee_edit_Click(object sender, EventArgs e)
        {
            var application = new Word.Application();
            Word.Document document = application.Documents.Add();
            document.PageSetup.TopMargin = 40;
            document.PageSetup.BottomMargin = 30;
            document.PageSetup.RightMargin = 30;
            document.PageSetup.LeftMargin = 40;
            document.PageSetup.Orientation = Word.WdOrientation.wdOrientLandscape;

            Word.Paragraph paragraph = document.Paragraphs.Add();
            Word.Range range = paragraph.Range;

            range.Text = "Заявки";
            paragraph.Range.Font.Name = "Times New Roman";
            paragraph.Range.Font.Size = 16;
            paragraph.Range.Font.Bold = 1;
            paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            range.InsertParagraphAfter();

            if (checkBox_date_conclusion_from.Checked || checkBox_date_conclusion_to.Checked)
            {

                string date = "";
                string date2 = "";
                if (checkBox_date_conclusion_from.Checked)
                    date += "c " + date_conclusion_from.Text;
                if (checkBox_date_conclusion_to.Checked)
                    date += "по " + date_conclusion_to.Text;
                paragraph = document.Paragraphs.Add();
                range = paragraph.Range;
                range.Text = "Дата: " + date + " " + date2;
                paragraph.Range.Font.Name = "Times New Roman";
                paragraph.Range.Font.Size = 14;
                paragraph.Range.Font.Bold = 0;
                paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                range.InsertParagraphAfter();
            }

            if (checkBox_type.Checked)
            {
                paragraph = document.Paragraphs.Add();
                range = paragraph.Range;
                range.Text = "Тип услуги: " + comboBox_type.Text;
                paragraph.Range.Font.Name = "Times New Roman";
                paragraph.Range.Font.Size = 14;
                paragraph.Range.Font.Bold = 0;
                paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                range.InsertParagraphAfter();
            }
            if (checkBox_status.Checked)
            {
                paragraph = document.Paragraphs.Add();
                range = paragraph.Range;
                range.Text = "Статус заявки: " + comboBox_status.Text;
                paragraph.Range.Font.Name = "Times New Roman";
                paragraph.Range.Font.Size = 14;
                paragraph.Range.Font.Bold = 0;
                paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                range.InsertParagraphAfter();
            }
            if (checkBox_customer.Checked)
            {
                paragraph = document.Paragraphs.Add();
                range = paragraph.Range;
                range.Text = "Клиент: " + comboBox_customer.Text;
                paragraph.Range.Font.Name = "Times New Roman";
                paragraph.Range.Font.Size = 14;
                paragraph.Range.Font.Bold = 0;
                paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                range.InsertParagraphAfter();
            }
            //checkBox_employee
            if (checkBox_employee.Checked)
            {
                paragraph = document.Paragraphs.Add();
                range = paragraph.Range;
                range.Text = "Техник: " + comboBox_employee.Text;
                paragraph.Range.Font.Name = "Times New Roman";
                paragraph.Range.Font.Size = 14;
                paragraph.Range.Font.Bold = 0;
                paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
                range.InsertParagraphAfter();
            }

            paragraph = document.Paragraphs.Add();
            range = paragraph.Range;

            Word.Table table = document.Tables.Add(range, dataGridView1.Rows.Count + 1, 9);
            table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            range.InsertParagraphAfter();


            Word.Range range1;
            range1 = table.Cell(1, 1).Range;
            range1.Text = "№ заявки";
            range1 = table.Cell(1, 2).Range;
            range1.Text = "Клиент";

            range1 = table.Cell(1, 3).Range;
            range1.Text = "Адрес";
            range1 = table.Cell(1, 4).Range;
            range1.Text = "Тип услуги";
            range1 = table.Cell(1, 5).Range;
            range1.Text = "Описание";
            range1 = table.Cell(1, 6).Range;
            range1.Text = "Техник";
            range1 = table.Cell(1, 7).Range;
            range1.Text = "Дата получения заявки";
            range1 = table.Cell(1, 8).Range;
            range1.Text = "Дата выполнения заявки";
            range1 = table.Cell(1, 9).Range;
            range1.Text = "Статус";
            table.Columns[1].AutoFit();
            table.Rows[1].Range.Bold = 1;
            table.Rows[1].Range.Font.Size = 12;
            table.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            for (int i = 0; i < dataGridView1.RowCount; i++)

            {


                table.Cell(i + 2, 1).Range.Text = (string)dataGridView1[0, i].Value;
                table.Cell(i + 2, 2).Range.Text = (string)dataGridView1[1, i].Value;
                table.Cell(i + 2, 3).Range.Text = (string)dataGridView1[3, i].Value;
                table.Cell(i + 2, 4).Range.Text = (string)dataGridView1[4, i].Value;
                table.Cell(i + 2, 5).Range.Text = (string)dataGridView1[5, i].Value;
                table.Cell(i + 2, 6).Range.Text = (string)dataGridView1[6, i].Value;
                table.Cell(i + 2, 7).Range.Text = (string)dataGridView1[7, i].Value;
                table.Cell(i + 2, 8).Range.Text = (string)dataGridView1[8, i].Value;
                table.Cell(i + 2, 9).Range.Text = (string)dataGridView1[9, i].Value;
               
                table.Rows[i + 2].Range.Font.Size = 12;
            }
            //foreach ()
            application.Visible = true;


        }
    }
}
