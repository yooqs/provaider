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
    public partial class Form_post_edit : Form
    {
        int id;
        string name;
        public Form_post_edit(int id, string name)
        {
            InitializeComponent();
            this.id = id;
            this.name = name;
        }

        private void Form_post_edit_Load(object sender, EventArgs e)
        {
            textBox_city.Text = name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Form_login.sql_connect;
                conn.Open();
                SqlCommand command = new SqlCommand("UPDATE [post] SET  name='" + textBox_city.Text + "' WHERE id=" + id, conn);
                command.ExecuteNonQuery();
                Form_directory_adress.update_table_post = true;
                this.Close();
            }
        }
    }
}
