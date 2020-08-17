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
    public partial class register_course : Form
    {
        public register_course()
        {
            InitializeComponent();
        }

        private void btn_register_course_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new student_panel().Show();
        }

        private void btn_register_course_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            new student_panel().Show();
        }
    }
}
