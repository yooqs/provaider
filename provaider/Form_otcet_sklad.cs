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
    public partial class Form_otcet_sklad : Form
    {
        public Form_otcet_sklad()
        {
            InitializeComponent();
        }
        private void table_load(DataGridView dataGrid, ComboBox combo_category)
        {
            string string_connection = Properties.Resources.conn_string;
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
        public class category
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        private void textbox_category_load(ComboBox comboBox)
        {

            string string_connection = Properties.Resources.conn_string;
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
        private void Form_otcet_sklad_Load(object sender, EventArgs e)
        {
            flag_table_update = true;
        }
        bool flag_table_update = false;
        private void Form_otcet_sklad_Activated(object sender, EventArgs e)
        {
            textbox_category_load(comboBox1);
           
            if (flag_table_update == true)
            {
                table_load(dataGridView_employee, comboBox1);
                flag_table_update = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            table_load(dataGridView_employee, comboBox1);
        }

        private void button_employee_edit_Click(object sender, EventArgs e)
        {
            var application = new Word.Application();
            Word.Document document = application.Documents.Add();
            document.PageSetup.TopMargin = 40;
            document.PageSetup.BottomMargin =30;
            document.PageSetup.RightMargin = 30;
            document.PageSetup.LeftMargin = 40;

      Word.Paragraph paragraph = document.Paragraphs.Add();
            Word.Range range = paragraph.Range;
            
            range.Text = "Остатки товаров на складе";
            paragraph.Range.Font.Name = "Times New Roman";
            paragraph.Range.Font.Size = 16;
            paragraph.Range.Font.Bold =1;
            paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;
            range.InsertParagraphAfter();

            paragraph = document.Paragraphs.Add();
            range = paragraph.Range;
            range.Text = "Дата: "+ DateTime.Now.ToString("dd MMMM yyyy");
            paragraph.Range.Font.Name = "Times New Roman";
            paragraph.Range.Font.Size = 14;
            paragraph.Range.Font.Bold = 0;
            paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            range.InsertParagraphAfter();

            paragraph = document.Paragraphs.Add();
            range = paragraph.Range;
            range.Text = "Категория: "+comboBox1.Text;
            paragraph.Range.Font.Name = "Times New Roman";
            paragraph.Range.Font.Size = 14;
            paragraph.Range.Font.Bold = 0;
            paragraph.Alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft;
            range.InsertParagraphAfter();


            paragraph = document.Paragraphs.Add();
            range = paragraph.Range;
            
            Word.Table table = document.Tables.Add(range, dataGridView_employee.Rows.Count + 1, 6);
            table.Borders.InsideLineStyle = table.Borders.OutsideLineStyle = Word.WdLineStyle.wdLineStyleSingle;
            range.InsertParagraphAfter();
         
          
            Word.Range range1;
            range1 = table.Cell(1, 1).Range;
            range1.Text = "Наименование";
            range1 = table.Cell(1, 2).Range;
            range1.Text = "Категория";
           
            range1 = table.Cell(1, 3).Range;
            range1.Text = "Единица измерения";
            range1 = table.Cell(1, 4).Range;
            range1.Text = "Количество";
            range1 = table.Cell(1, 5).Range;
            range1.Text = "Цена";
            range1 = table.Cell(1, 6).Range;
            range1.Text = "Сумма";
            table.Columns[1].AutoFit();
            table.Rows[1].Range.Bold = 1;
            table.Rows[1].Range.Font.Size = 12; 
            table.Rows[1].Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphCenter;

            for (int i = 0; i < dataGridView_employee.RowCount; i++)

            {

                
                table.Cell(i + 2, 1).Range.Text = (string)dataGridView_employee[1, i].Value;
                table.Cell(i + 2, 2).Range.Text = (string)dataGridView_employee[2, i].Value;
                table.Cell(i + 2, 3).Range.Text = (string)dataGridView_employee[3, i].Value;
                table.Cell(i + 2, 4).Range.Text = (string)dataGridView_employee[4, i].Value;
                table.Cell(i + 2, 5).Range.Text = (string)dataGridView_employee[5, i].Value;
                table.Cell(i + 2, 6).Range.Text = Convert.ToString (Convert.ToInt32(dataGridView_employee[4, i].Value) * Convert.ToInt32(dataGridView_employee[5, i].Value)) ;
                table.Rows[i+2].Range.Font.Size = 12;
            }
            //foreach ()
            application.Visible = true;



        }
    }
}
