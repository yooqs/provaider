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
    public partial class Form_customers : Form
    {
        public Form_customers()
        {
            InitializeComponent();
        }

        private void button_customers_new_Click(object sender, EventArgs e)
        {
            Form_customers_new customers_new_form = new Form_customers_new();
            customers_new_form.Show();
        }
        public static bool Data_table_load = false;
        public async void table_contract_load()
        {
            String sql;
            dataGridView1.Rows.Clear();

            SqlConnection conn = new SqlConnection();
            sql = "SELECT * From [contract]";
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.ConnectionString = provaider.Properties.Resources.conn_string;
            conn.Open();
            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
            {
                while (reader.Read())
                {
                    string[] row = {reader.GetValue(0).ToString().Trim(),
                                    reader.GetValue(1).ToString().Trim(),
                                    reader.GetValue(2).ToString().Trim(),
                                    reader.GetValue(3).ToString().Trim(),
                                    reader.GetValue(4).ToString().Trim(),
                                    reader.GetValue(5).ToString().Trim()+", "+ reader.GetValue(6).ToString().Trim()+", "+reader.GetValue(7).ToString().Trim()+", "+reader.GetValue(9).ToString().Trim(),

                                    reader.GetValue(8).ToString().Trim(),

                                    reader.GetValue(10).ToString().Trim(),
                                    reader.GetValue(11).ToString().Trim(),
                                    reader.GetValue(12).ToString().Trim(),

                                    };

                    dataGridView1.Rows.Add(row);
                }
                reader.Close();
            }
            conn.Close();
        }
        private void Form_customers_Load(object sender, EventArgs e)
        {
            table_contract_load();
        }

        private void button_customers_new_Click_1(object sender, EventArgs e)
        {
            Form_customers_new customers_new_form = new Form_customers_new();
            customers_new_form.Show();
        }

        private void button_customers_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = provaider.Properties.Resources.conn_string;
                conn.Open();
                SqlCommand command = new SqlCommand("DELETE FROM [contract] WHERE id='" + (String)dataGridView1.CurrentRow.Cells[0].Value + "'", conn);
                command.ExecuteNonQuery();
                command.Connection.Close();
                table_contract_load();
            }
        }

        private void Form_customers_Activated(object sender, EventArgs e)
        {
            if (Form_customers.Data_table_load == true)
            {
                table_contract_load();
                Data_table_load = false;
            }
        }

        private void button_customers_edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
           Form_customers_edit customers_edit_form = new Form_customers_edit(id);
            customers_edit_form.Show();

        }
    }
}
