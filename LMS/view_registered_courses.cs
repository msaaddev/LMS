﻿using System;
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
    public partial class view_registered_courses : Form
    {
        public view_registered_courses()
        {
            InitializeComponent();
        }

        private void btn_register_course_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new student_panel().Show();
        }
    }
}
