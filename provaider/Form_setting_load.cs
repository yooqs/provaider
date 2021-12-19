using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace provaider
{
    public partial class Form_setting_load : Form
    {
        public Form_setting_load()
        {
            InitializeComponent();
        }

        private void Form_setting_load_Load(object sender, EventArgs e)
        {
            textBox_last_name.Text = provaider.Properties.Settings.Default.Connect_string_db;
            if (provaider.Properties.Settings.Default.Local_flag)
            {
                checkBox2.Checked = true;
            }
            else
            {
                checkBox2.Checked = false;
            }
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
            provaider.Properties.Settings.Default.Connect_string_db = textBox_last_name.Text;
            Properties.Settings.Default.Save();
            /*
             FolderBrowserDialog FBD = new FolderBrowserDialog();
        
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(FBD.SelectedPath);
            }
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*FolderBrowserDialog FBD = new FolderBrowserDialog();

            if (FBD.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = FBD.SelectedPath; 
            }
            */
            OpenFileDialog OPF = new OpenFileDialog();
            OPF.Filter = "Файл БД|*.mdf";
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text= OPF.FileName;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                provaider.Properties.Settings.Default.Local_flag = true;
            }
            else
            {
                provaider.Properties.Settings.Default.Local_flag = false;
            }
           
        }
    }
}
