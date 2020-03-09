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
    public partial class signup_txt_admin_designation : Form
    {
        public signup_txt_admin_designation()
        {
            InitializeComponent();
        }

        private void admin_username_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_admin_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void btn_admin_signup_confirm_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }
    }
}
