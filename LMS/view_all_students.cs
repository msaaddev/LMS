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
    public partial class view_all_students : Form
    {
        public view_all_students()
        {
            InitializeComponent();
        }

        private void view_all_students_Load(object sender, EventArgs e)
        {

        }

        private void btn_all_course_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }
    }
}
