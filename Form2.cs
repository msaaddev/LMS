using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_admin_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }

        private void btn_admin_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            new signup_txt_admin_designation().Show();
        }

        private void btn_admin_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }
    }
}
