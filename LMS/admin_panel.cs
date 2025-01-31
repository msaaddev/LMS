﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace LMS
{
    public partial class admin_panel : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ROZINA-PC;Initial Catalog=LMS;Integrated Security=True");

        public admin_panel()
        {
            InitializeComponent();
        }

        private void btn_admin_panel_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new main_window().Show();
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

        private void btn_admin_panel_view_all_courses_Click(object sender, EventArgs e)
        {

            this.Hide();
            new view_all_courses().Show();
        }

        private void btn_admin_panel_add_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            new add_student().Show();
        }

        private void btn_admin_panel_update_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            new update_student().Show();
        }

        private void btn_admin_panel_delete_student_Click(object sender, EventArgs e)
        {
            this.Hide();
            new delete_student().Show();
        }

        private void btn_admin_panel_view_all_students_Click(object sender, EventArgs e)
        {
            this.Hide();
            new view_all_students().Show();
        }
    }
}
