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
    public partial class view_courses_student : Form
    {
        public view_courses_student()
        {
            InitializeComponent();
        }

        private void btn_all_course_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new student_panel().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label_all_course_Click(object sender, EventArgs e)
        {

        }

        private void titleLMS_Click(object sender, EventArgs e)
        {

        }
    }
}
