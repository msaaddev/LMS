using System;
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
    public partial class add_course : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ROZINA-PC;Initial Catalog=LMS;Integrated Security=True");
        public add_course()
        {
            InitializeComponent();
        }

        private void btn_add_course_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }

        private void btn_add_course_course_confirm_Click(object sender, EventArgs e)
        {
            con.Open();

            string primaryKey = "SELECT * FROM COURSES WHERE course_code = @id"; 
            SqlCommand cmd2 = new SqlCommand(primaryKey, con); 
            cmd2.Parameters.AddWithValue("@id", add_course_txt_course_code.Text); 
            cmd2.ExecuteNonQuery();

            SqlDataReader read = cmd2.ExecuteReader();
            bool flag = read.HasRows;

            con.Close();

            if(flag)
            {
                MessageBox.Show("A course with this course id exists already.");
            }
            else
            {
                string courseCode = add_course_txt_course_code.Text;
                string courseName = add_course_txt_course_name.Text;
                int creditHrs = int.Parse(add_course_txt_course_credit_hours.Text);
                int sem = int.Parse(add_course_txt_course_semester.Text);

                if (courseCode == "" || courseName == "")
                {
                    MessageBox.Show("Please fill all the fields.");
                }else
                {
                    con.Open();

                    string insertIntoCourses = "INSERT INTO COURSES(course_code, course_name, credit_hours, semester) " +
                        "values(@course_id, @course_name, @credit_hours , @semester)";
                    SqlCommand cmd3 = new SqlCommand(insertIntoCourses, con);
                    cmd3.Parameters.AddWithValue("@course_id", courseCode);
                    cmd3.Parameters.AddWithValue("@course_name", courseName);
                    cmd3.Parameters.AddWithValue("@credit_hours", creditHrs);
                    cmd3.Parameters.AddWithValue("@semester", sem);
                    cmd3.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Course successfully added.");
                }
            }


            this.Hide();
            new admin_panel().Show();
        }
    }
}