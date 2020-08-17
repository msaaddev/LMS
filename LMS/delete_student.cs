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
    public partial class delete_student : Form
    {
        public delete_student()
        {
            InitializeComponent();
        }

        private void titleLMS_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }

        private void btn_delete_student_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }
    }
}
