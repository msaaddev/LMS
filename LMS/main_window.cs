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
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();
        }

        private void btn_admin_sign_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_login().Show();
        }

        private void btn_student_sign_in_Click(object sender, EventArgs e)
        {
            this.Hide();
            new student_login().Show();
        }
    }
}
