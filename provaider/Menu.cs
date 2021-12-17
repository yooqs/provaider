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
    public partial class Form_menu : Form
    { 
        string fio;
        public Form_menu(string fio)
        {
            InitializeComponent();
            this.fio = fio;
            fios = fio;
        }
        public static string fios;
        public static bool application_update = false;
        
        private void Menu_Activated(object sender, EventArgs e)
        {
           if (application_update)
            {
                table_applications_load();
                application_update = false;
            }

        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_login login_form = new Form_login();
            login_form.Show();
        }

        private void button_customers_new_Click(object sender, EventArgs e)
        {
            Form_customers customers_form = new Form_customers();
            customers_form.StartPosition = FormStartPosition.CenterScreen;
            customers_form.ShowDialog();
            
        }

        private void button_employees_Click(object sender, EventArgs e)
        {
            Form_employee employee_form = new Form_employee();
            employee_form.StartPosition = FormStartPosition.CenterScreen;
            employee_form.Show();

        }

        private void button_directory_Click(object sender, EventArgs e)
        {
            Form_directory_adress directory_adress_form = new Form_directory_adress();
            directory_adress_form.StartPosition = FormStartPosition.CenterScreen;
            directory_adress_form.Show();
        }

        private void button_applications_new_Click(object sender, EventArgs e)
        {
            Form_applications_contract applications_contract_form = new Form_applications_contract();
            applications_contract_form.StartPosition = FormStartPosition.CenterScreen;
            applications_contract_form.Show();
        }
        private void grid_color (DataGridView gridView)
        {
            foreach (DataGridViewRow row in gridView.Rows)
            {
                if (row.Cells[8].Value.ToString() == "Выполнение")
                    row.DefaultCellStyle.BackColor = Color.Green;
                if (row.Cells[8].Value.ToString() == "Ожидание")
                    row.DefaultCellStyle.BackColor = Color.Yellow ;
                if ((DateTime.Now-Convert.ToDateTime(row.Cells[7].Value)).Days >=2)
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }
        public void table_applications_load()
        {
            String sql;
            dataGridView1.Rows.Clear();
            string[] table_app;
            table_app = new string[9];
            using (SqlConnection conn = new SqlConnection())
            {
                //sql = "Select [applications].[id],[applications].[description],[applications].[date_receipt],[contract].[last_name],[contract].[first_name],[contract].[patronymic],[contract].[telephone],[contract].[city],[contract].[street],[contract].[house],[contract].[flat],[employee].[last_name],[employee].[first_name],[employee].[patronymic],[type_application].[name] FROM  [contract] JOIN [applications] ON [contract].[id] =  [applications].[id_contract]  JOIN[employee] ON [employee].[id] =  [applications].[id_employee] JOIN[type_application] ON[type_application].[id] =  [applications].[type]  where [status] = 'Выполняется'";
                sql = "Select [applications].[id],[applications].[description],FORMAT([applications].[date_receipt], 'dd/MM/yyyy HH:mm:ss' ),[contract].[last_name],[contract].[first_name],[contract].[patronymic],[contract].[telephone],[contract].[city],[contract].[street],[contract].[house],[contract].[flat],[employee].[last_name],[employee].[first_name],[employee].[patronymic],[type_application].[name],[applications].status FROM  [applications] JOIN [contract] ON [contract].[id] =  [applications].[id_contract] JOIN emp_app ON applications.id = emp_app.id_app JOIN[employee] ON employee.id = emp_app.id_emp  JOIN[type_application] ON[type_application].[id] =  [applications].[type]     where [status] = 'Выполнение' OR [status] = 'Ожидание'";
                SqlCommand cmd = new SqlCommand(sql, conn);

                conn.ConnectionString = provaider.Properties.Resources.conn_string;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                int id_application = -1;
                //string[] row;
                if (reader.Read()) {
                    table_app[0] = reader.GetValue(0).ToString().Trim();
                    table_app[1] = reader.GetValue(3).ToString().Trim() + " " + reader.GetValue(4).ToString().Trim() + " " + reader.GetValue(5).ToString().Trim();
                    table_app[2] = reader.GetValue(6).ToString().Trim();
                    table_app[3] = reader.GetValue(7).ToString().Trim() + ", " + reader.GetValue(8).ToString().Trim() + ", " + reader.GetValue(9).ToString().Trim() + ", " + reader.GetValue(10).ToString().Trim();
                    table_app[4] = reader.GetValue(14).ToString().Trim();
                    table_app[5] = reader.GetValue(1).ToString().Trim();
                    table_app[6] = reader.GetValue(11).ToString().Trim() + " " + reader.GetValue(12).ToString().Trim() + " " + reader.GetValue(13).ToString().Trim();
                    table_app[7] = reader.GetValue(2).ToString().Trim();
                    table_app[8]= reader.GetValue(15).ToString().Trim();



                    id_application = Convert.ToInt32(table_app[0]);
                }

                while (reader.Read())
                {
                    if (Convert.ToInt32(reader.GetValue(0)) == id_application)
                    {
                        table_app[6]+= "\n"+reader.GetValue(11).ToString().Trim() + " " + reader.GetValue(12).ToString().Trim() + " " + reader.GetValue(13).ToString().Trim();

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
                        table_app[8] = reader.GetValue(15).ToString().Trim();
                        id_application = Convert.ToInt32(table_app[0]);
                    }
                    
                }
                dataGridView1.Rows.Add(table_app);
               


                /*
                  while (reader.Read())
              {
                  if (Convert.ToInt32(reader.GetValue(0)) == id_application)
                  {
                      string[] row = {reader.GetValue(0).ToString().Trim(),
                                  reader.GetValue(3).ToString().Trim()+" "+reader.GetValue(4).ToString().Trim()+" "+reader.GetValue(5).ToString().Trim(),
                                  reader.GetValue(6).ToString().Trim(),
                                  reader.GetValue(7).ToString().Trim()+", "+reader.GetValue(8).ToString().Trim()+", "+reader.GetValue(9).ToString().Trim()+", "+reader.GetValue(10).ToString().Trim(),
                                  reader.GetValue(14).ToString().Trim(),
                                  reader.GetValue(1).ToString().Trim(),
                                  reader.GetValue(11).ToString().Trim()+" "+reader.GetValue(12).ToString().Trim()+" "+reader.GetValue(13).ToString().Trim(),
                                  reader.GetValue(2).ToString().Trim(),

                                  };

                      dataGridView1.Rows.Add(row);
                  }
              }
              */
            }
            grid_color(dataGridView1);
        }
        private void Menu_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[6].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            label_fio.Text = fio;
            table_applications_load();
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
            panel1.Location = new Point(this.Width - button8.Width - 15, 90);
            flag_panel = false;
            button8.Text = "Фильтры";

        }
        void timer_Tick(object sender, EventArgs e)
        {
            label_timer.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToLongTimeString();
        }
        private void button_applications_new_Click_1(object sender, EventArgs e)
        {

            Form_applications_contract applications_contract_form = new Form_applications_contract();
            applications_contract_form.StartPosition = FormStartPosition.CenterScreen;
            applications_contract_form.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //
            DialogResult dialogResult = MessageBox.Show("Подтвердите выполнение заявки № "+ (string)dataGridView1.CurrentRow.Cells[0].Value + "!", "Предупреждение!", MessageBoxButtons.YesNo);
            
             if (dialogResult == DialogResult.Yes) {
              
                Form_application_confirmation applications_confirmation = new Form_application_confirmation(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                applications_confirmation.StartPosition = FormStartPosition.CenterScreen;
                applications_confirmation.ShowDialog();
            
            
              }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Подтвердите отмену заявки № " + (string)dataGridView1.CurrentRow.Cells[0].Value + "!", "Предупреждение!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String sql;
                String sql_conn = provaider.Properties.Resources.conn_string; ;
                using (SqlConnection conn = new SqlConnection(sql_conn))
                {
                    sql = $"UPDATE [applications] SET [status]='Отменена' WHERE id= {(string)dataGridView1.CurrentRow.Cells[0].Value}";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                table_applications_load();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            Form_application_archive application_archive_form = new Form_application_archive();
            application_archive_form.StartPosition = FormStartPosition.CenterScreen;
            application_archive_form.Show();
        }

        private void заявкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_applications_contract applications_contract_form = new Form_applications_contract();
            applications_contract_form.StartPosition = FormStartPosition.CenterScreen;
            applications_contract_form.Show();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_employee employee_form = new Form_employee();
            employee_form.StartPosition = FormStartPosition.CenterScreen;
            employee_form.Show();
        }

        private void справочникToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_directory_adress directory_adress_form = new Form_directory_adress();
            directory_adress_form.StartPosition = FormStartPosition.CenterScreen;
            directory_adress_form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form_warehouse warehouse_form = new Form_warehouse();
            warehouse_form.StartPosition = FormStartPosition.CenterScreen;
            warehouse_form.Show();
        }

        private void картаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_maps maps_form = new Form_maps();
            maps_form.StartPosition = FormStartPosition.CenterScreen;
            maps_form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Подтвердите выполнение заявки № " + (string)dataGridView1.CurrentRow.Cells[0].Value + "!", "Предупреждение!", MessageBoxButtons.YesNo);
            
             if (dialogResult == DialogResult.Yes) { 
                 String sql;
             String sql_conn = provaider.Properties.Resources.conn_string; ;
             using (SqlConnection conn = new SqlConnection(sql_conn))
             {
                     DateTime date_time = DateTime.Now;
                     
                     sql = $"UPDATE [applications] SET [status]='Выполнение', [date_completion]='"+ date_time.ToString("dd-MM-yyyy hh:mm:ss") + "' WHERE id= "+(string)dataGridView1.CurrentRow.Cells[0].Value;
                 SqlCommand cmd = new SqlCommand(sql, conn);
                 conn.Open();
                 cmd.ExecuteNonQuery();
             }
             table_applications_load();
              }
        }

        private void клиентыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_customers customers_form = new Form_customers();
            customers_form.StartPosition = FormStartPosition.CenterScreen;
            customers_form.ShowDialog();
        }

        private void сотрудникиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_employee employee_form = new Form_employee();
            employee_form.StartPosition = FormStartPosition.CenterScreen;
            employee_form.Show();
        }

        private void справочникToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_directory_adress directory_adress_form = new Form_directory_adress();
            directory_adress_form.StartPosition = FormStartPosition.CenterScreen;
            directory_adress_form.Show();
        }

        private void картаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_maps maps_form = new Form_maps();
            maps_form.StartPosition = FormStartPosition.CenterScreen;
            maps_form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void архивToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_application_archive application_archive_form = new Form_application_archive();
            application_archive_form.StartPosition = FormStartPosition.CenterScreen;
            application_archive_form.Show();
        }

        private void очеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_otcet_sklad form_Otcet_Sklad = new Form_otcet_sklad();
            form_Otcet_Sklad.StartPosition = FormStartPosition.CenterScreen;
            form_Otcet_Sklad.ShowDialog();
        }

        private void выполненымЗаявкамToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        Boolean flag_panel = true;
        private void button8_Click(object sender, EventArgs e)
        {
            //1019; 90
            if (flag_panel == true)
            {
                // panel1.Width = button1.Width;
                panel1.Location = new Point(this.Width - button8.Width - 15, 90);
                flag_panel = false;
                button8.Text = "Фильтры";
            }
            else
            {
                panel1.Location = new Point(this.Width - panel1.Width - 10, 90);
                button8.Text = "Фильтры";
                flag_panel = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[8].Value.ToString()!="Ожидание")
            {
                button3.Enabled = false;
                button7.Enabled = false;
                button4.Enabled = true;
            }
            else
            {
                button3.Enabled = true;
                button7.Enabled = true;
                button4.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form_application_edit form_Application_edit = new Form_application_edit(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            form_Application_edit.StartPosition = FormStartPosition.CenterScreen;
            form_Application_edit.ShowDialog();
        }
    }
}
