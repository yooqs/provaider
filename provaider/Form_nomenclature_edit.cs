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
    public partial class Form_nomenclature_edit : Form
    {
        int id, id_unit, id_category;
        string name;

        private void button_user_new_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(provaider.Properties.Resources.conn_string))
            {
                //conn.Open();


                SqlCommand command = new SqlCommand("UPDATE [products] SET  name = @name,id_category = @id_category,id_unit = @id_unit  where [id] = " + id, conn);
                //command.Parameters.AddWithValue("@id_products", comboBox_name.SelectedValue);
                command.Parameters.AddWithValue("@name", textBox_name.Text);
                command.Parameters.AddWithValue("@id_category", comboBox1.SelectedValue);
                command.Parameters.AddWithValue("@id_unit", comboBox2.SelectedValue);




                command.Connection.Open();
                command.ExecuteNonQuery();
            }
            Form_directory_adress.update_table_nomenclature = true;
            this.Close();
        }

        public Form_nomenclature_edit(int id,int id_unit, int id_category, string name)
        {
            InitializeComponent();
             this.id= id;
            this.id_unit= id_unit;
            this.id_category = id_category;
            this.name= name;
        }
        class products
        {
            public int id { set; get; }
            public string name { get; set; }
        }
        Boolean flag = false;
        private void Form_nomenclature_edit_Load(object sender, EventArgs e)
        {
            string string_connection = Properties.Resources.conn_string;
            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [name] From [products_categories]", conn);
                List<products> employee_list = new List<products>();
                employee_list.Clear();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    employee_list.Add(new products() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                }


                comboBox1.DataSource = employee_list;
                comboBox1.DisplayMember = "name";
                comboBox1.ValueMember = "id";
                flag = true;

            }


            using (SqlConnection conn = new SqlConnection(string_connection))
            {
                conn.Open();
                SqlCommand comand = new SqlCommand("SELECT [id], [name] From [unit_products]", conn);
                List<products> employee_list = new List<products>();
                employee_list.Clear();
                SqlDataReader reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    employee_list.Add(new products() { id = int.Parse(reader.GetValue(0).ToString().Trim()), name = (string)reader.GetValue(1).ToString().Trim() });
                }


                comboBox2.DataSource = employee_list;
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "id";
                flag = true;
            }
            comboBox2.SelectedValue = id_unit;
            comboBox1.SelectedValue = id_category;
            textBox_name.Text = name;
        }
    }
}
