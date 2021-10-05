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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Activated(object sender, EventArgs e)
        {
            
            dgv_za.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            

            dgv_za.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgv_za.Rows.Add("123","Иванов Иван Иванович \n Петров Петр Петрович","225");
        }

        private void Menu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form_login login_form = new Form_login();
            login_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_customers customers_form = new Form_customers();
            customers_form.Show();
        }
    }
}
