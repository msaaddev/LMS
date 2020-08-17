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
    public partial class student_login : Form
    {
        public student_login()
        {
            InitializeComponent();
        }

        private void btn_student_login_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new main_window().Show();
        }

        private void btn_student_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            new student_panel().Show();
        }
    }
}
