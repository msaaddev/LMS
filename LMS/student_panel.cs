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
    public partial class student_panel : Form
    {
        public student_panel()
        {
            InitializeComponent();
        }

        private void btn_student_view_courses_Click(object sender, EventArgs e)
        {
            this.Hide();
            new view_courses_student().Show();
        }

        private void btn_student_panel_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new main_window().Show();
        }

        private void btn_register_course_Click(object sender, EventArgs e)
        {
            this.Hide();
            new register_course().Show();
        }

        private void btn_student_registered_courses_Click(object sender, EventArgs e)
        {
            this.Hide();
            new view_registered_courses().Show();
        }
    }
}
