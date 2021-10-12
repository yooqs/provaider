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
    public partial class Form_application_archive : Form
    {
        public Form_application_archive()
        {
            InitializeComponent();
        }

        public void table_applications_load()
        {
            String sql;
            dataGridView1.Rows.Clear();
            using (SqlConnection conn = new SqlConnection())
            {
                sql = "Select [applications].[id],[applications].[description],[applications].[date_receipt],[contract].[last_name],[contract].[first_name],[contract].[patronymic],[contract].[telephone],[contract].[city],[contract].[street],[contract].[house],[contract].[flat],[employee].[last_name],[employee].[first_name],[employee].[patronymic],[type_application].[name],[applications].[status],[applications].[date_completion] FROM  [contract] JOIN [applications] ON [contract].[id] =  [applications].[id_contract]  JOIN[employee] ON [employee].[id] =  [applications].[id_employee] JOIN[type_application] ON[type_application].[id] =  [applications].[type]  where [status] != 'Выполняется'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.ConnectionString = provaider.Properties.Resources.conn_string;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
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

            }

        }
        private void Form_application_archive_Load(object sender, EventArgs e)
        {
            table_applications_load();
        }
    }
}
