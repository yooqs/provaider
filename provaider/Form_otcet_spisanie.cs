﻿using System;
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
    public partial class Form_otcet_spisanie : Form
    {
        public Form_otcet_spisanie()
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
                    SqlString = "Select [products_purchase].[id], [products].[name],[products_categories].[name], [unit_products].name,[products_purchase].[volume],[products_purchase].[price], [products].[id_category],[products].[id_unit] FROM  [products] JOIN [products_purchase] ON [products_purchase].[id_product] =  [products].[id]  JOIN [products_categories] ON [products_categories].[id] =  [products].[id_category] JOIN [unit_products] ON [unit_products].[id] =  [products].[id_unit] JOIN [applications] ON [applications].[id] = [products_purchase].[id_applications] WHERE [applications].[date_completion] !=''   ";
                }
                else
                {
                    SqlString = "Select [products_purchase].[id], [products].[name],[products_categories].[name], [unit_products].name,[products_purchase].[volume],[products_purchase].[price], [products].[id_category],[products].[id_unit] FROM  [products] JOIN [products_purchase] ON [products_purchase].[id_product] =  [products].[id]  JOIN [products_categories] ON [products_categories].[id] =  [products].[id_category] JOIN [unit_products] ON [unit_products].[id] =  [products].[id_unit] JOIN [applications] ON [applications].[id] = [products_purchase].[id_applications] WHERE [applications].[date_completion] !=''    AND [products].[id_category]=" + combo_category.SelectedValue;
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
        private void Form_otcet_spisanie_Load(object sender, EventArgs e)
        {

        }
    }
}
