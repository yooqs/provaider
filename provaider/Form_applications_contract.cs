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
    public partial class Form_applications_contract : Form
    {
        public Form_applications_contract()
        {
            InitializeComponent();
        }
        public async void table_contract_load()
        {
            String sql;
            dataGridView1.Rows.Clear();

            SqlConnection conn = new SqlConnection();
            sql = "Select [id],[last_name],[first_name],[patronymic], [telephone], [city],[street], [house],FORMAT(contract.data_birth, 'dd/MM/yyyy', 'de-de' ), [flat],[passport_series], [passport_number] ,FORMAT(contract.date_conclusion, 'dd/MM/yyyy', 'de-de' ) FROM [contract]";
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
        private void Form_applications_contract_Load(object sender, EventArgs e)
        {
            table_contract_load();
        }

        private void button_customers_new_Click(object sender, EventArgs e)
        {

            string[] data_contract = { (string)dataGridView1.CurrentRow.Cells[0].Value,
                                       (string)dataGridView1.CurrentRow.Cells[1].Value,
                                       (string)dataGridView1.CurrentRow.Cells[2].Value,
                                       (string)dataGridView1.CurrentRow.Cells[3].Value,
                                       (string)dataGridView1.CurrentRow.Cells[4].Value,
                                       (string)dataGridView1.CurrentRow.Cells[5].Value,
                                       (string)dataGridView1.CurrentRow.Cells[6].Value,
                                       (string)dataGridView1.CurrentRow.Cells[7].Value,
                                       (string)dataGridView1.CurrentRow.Cells[8].Value,
                                       (string)dataGridView1.CurrentRow.Cells[9].Value
                                      }; 
                                       
            Form_applications_new applications_new_form = new Form_applications_new(data_contract);
            applications_new_form.StartPosition = FormStartPosition.CenterScreen;
            applications_new_form.Show();
            this.Close();
        }
    }
}
