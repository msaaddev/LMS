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
    public partial class update_student : Form
    {
        public update_student()
        {
            InitializeComponent();
        }

        private void label_update_course_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }

        private void btn_update_student_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }
    }
}
