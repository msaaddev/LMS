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
    public partial class add_course : Form
    {
        public add_course()
        {
            InitializeComponent();
        }

        private void btn_add_course_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }
    }
}