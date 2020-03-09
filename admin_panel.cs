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
    public partial class admin_panel : Form
    {
        public admin_panel()
        {
            InitializeComponent();
        }

        private void btn_admin_panel_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form2().Show();
        }

        private void btn_admin_panel_add_course_Click(object sender, EventArgs e)
        {
            this.Hide();
            new add_course().Show();
        }

        private void btn_admin_panel_update_course_Click(object sender, EventArgs e)
        {
            this.Hide();
            new update_course().Show();
        }

        private void btn_admin_panel_delete_course_Click(object sender, EventArgs e)
        {
            this.Hide();
            new delete_course().Show();
        }
    }
}
