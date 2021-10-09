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
    public partial class Form_employee : Form
    {

        public Form_employee()
        {
            InitializeComponent();
        }
        public static bool Data_table_employee_load = false;
        public async void table_employee_load()
        {
            String sql;
            dataGridView_employee.Rows.Clear();

            SqlConnection conn = new SqlConnection();
            sql = "Select [id],[last_name],[first_name],[patronymic], [telephone], [city],[street], [house], [flat],[passport_series],FORMAT(employee.date_conclusion, 'dd/MM/yyyy', 'de-de' ),FORMAT(employee.date_birth, 'dd/MM/yyyy', 'de-de' ),[passport_number] FROM [employee]";
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
                                    reader.GetValue(5).ToString().Trim()+", "+ reader.GetValue(6).ToString().Trim()+", "+reader.GetValue(7).ToString().Trim()+", "+reader.GetValue(8).ToString().Trim(),

                                    reader.GetValue(10).ToString().Trim(),

                                    reader.GetValue(9).ToString().Trim(),
                                    reader.GetValue(12).ToString().Trim(),
                                    reader.GetValue(11).ToString().Trim(),

                                    };

                    dataGridView_employee.Rows.Add(row);
                }
                reader.Close();
            }

            conn.Close();
        }
            private void Form_employee_Load(object sender, EventArgs e)
        {
            table_employee_load();
        }

        private void button_employee_edit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dataGridView_employee.CurrentRow.Cells[0].Value);
            Form_employee_edit employee_edit_form = new Form_employee_edit(id);
            employee_edit_form.StartPosition = FormStartPosition.CenterScreen;
            employee_edit_form.Show();
        }

        private void button_employee_new_Click(object sender, EventArgs e)
        {
            Form_employee_new employee_new_form = new Form_employee_new();
            employee_new_form.StartPosition = FormStartPosition.CenterScreen;
            employee_new_form.Show();
        }

        private void Form_employee_Activated(object sender, EventArgs e)
        {
            //обновление таблицы при активации
            if (Data_table_employee_load == true)
            {
                table_employee_load();
                Data_table_employee_load = false;
            }
        }

        private void button_employee_delete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Подтвердите удаление записи, удаленные записи восстановить невозможно!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = provaider.Properties.Resources.conn_string;
                conn.Open();
                
                SqlCommand command = new SqlCommand("DELETE FROM [employee] WHERE id='" + (string)dataGridView_employee.CurrentRow.Cells[0].Value + "'", conn);
                command.ExecuteNonQuery();
                command.Connection.Close();
                table_employee_load();
            }
        }
    }
}
