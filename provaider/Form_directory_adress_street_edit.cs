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
    public partial class Form_directory_adress_street_edit : Form
    {
        private int id;
        public Form_directory_adress_street_edit(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void Form_directory_adress_street_edit_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = Form_login.sql_connect;
                conn.Open();
                SqlCommand command = new SqlCommand("Select [name] FROM [street] WHERE id=" + id, conn);


                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    textBox_street.Text = (string)reader.GetValue(0);
                }

               
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                //conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Дмитрий\Desktop\1234\basa.mdf;Integrated Security=True;Connect Timeout=30";
                conn.ConnectionString = Form_login.sql_connect;
                conn.Open();
                SqlCommand command = new SqlCommand("UPDATE [street] SET  name='" + textBox_street.Text + "' WHERE id=" + id, conn);
                command.ExecuteNonQuery();
                Form_directory_adress.update_table_street = true;
                
                this.Close();
            }
        }
    }
}
