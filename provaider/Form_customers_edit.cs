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
    public partial class Form_customers_edit : Form
    {
        public int id;
        public Form_customers_edit(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private async Task date_contract_loadAsync()
        {
            string[] row;
            String sql;
            SqlConnection conn = new SqlConnection();
            sql = "SELECT * From [contract] Where [id] ="+id;
            SqlCommand cmd = new SqlCommand(sql, conn);

            conn.ConnectionString = provaider.Properties.Resources.conn_string;
            conn.Open();
            using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
            {
                while (reader.Read())
                {
                    row  = new string[] {reader.GetValue(0).ToString().Trim(), //last_name
                                    reader.GetValue(1).ToString().Trim(),
                                    reader.GetValue(2).ToString().Trim(),
                                    reader.GetValue(3).ToString().Trim(),
                                    reader.GetValue(4).ToString().Trim(),
                                    reader.GetValue(5).ToString().Trim(), 
                                    reader.GetValue(6).ToString().Trim(), 
                                    reader.GetValue(7).ToString().Trim(),
                                    reader.GetValue(8).ToString().Trim(),
                                    reader.GetValue(9).ToString().Trim(),
                                    reader.GetValue(10).ToString().Trim(),
                                    reader.GetValue(11).ToString().Trim(),
                                    reader.GetValue(12).ToString().Trim(),
                    };
                    textBox_last_name.Text = row[1];
                    textBox_first_name.Text = row[2];
                    textBox_patronymic.Text = row[3];
                    textBox_telephone.Text = row[4];
                    comboBox_city.Text = row[5];
                    comboBox_street.Text = row[6];
                    textBox_house.Text = row[7];
                    textBox_birth_date.Value = Convert.ToDateTime(row[8]);
                    textBox_flat.Text = row[9];
                    textBox_passport_series.Text = row[10];
                    textBox_passport_number.Text = row[11];
                    date_conclusion.Value = Convert.ToDateTime(row[12]);



                }
                reader.Close();
            }
            conn.Close();

            //обновление
            Form_customers.Data_table_load = true;
            
        }
        private void button_user_new_Click(object sender, EventArgs e)
        {

        }

        private async void Form_customers_edit_Load(object sender, EventArgs e)
        {
            await date_contract_loadAsync();
        }

        private void textBox_middle_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
