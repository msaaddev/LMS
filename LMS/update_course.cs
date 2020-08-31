using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    public partial class update_course : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ROZINA-PC;Initial Catalog=LMS;Integrated Security=True");

        public update_course()
        {
            InitializeComponent();
        }

        private void label_add_course_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_course_course_confirm_Click(object sender, EventArgs e)
        {
            con.Open();

            string primaryKey = "SELECT * FROM COURSES WHERE course_code = @id";
            SqlCommand cmd2 = new SqlCommand(primaryKey, con);
            cmd2.Parameters.AddWithValue("@id", update_course_txt_course_code.Text);
            cmd2.ExecuteNonQuery();

            SqlDataReader read = cmd2.ExecuteReader();
            bool flag = read.HasRows;

            con.Close();

            if (!flag)
            {
                MessageBox.Show("No course with this course id exists.");
            }
            else
            {
                string courseCode = update_course_txt_course_name.Text;
                string courseName = update_course_txt_course_code.Text;
                int creditHrs = int.Parse(update_course_txt_course_credit_hours.Text);
                int sem = int.Parse(update_course_txt_course_semester.Text);

                if (courseCode == "" || courseName == "")
                {
                    MessageBox.Show("Please fill all the fields.");
                }
                else
                {
                    con.Open();

                    string updateCourse = "UPDATE COURSES SET course_name=@courseName, " +
                        "credit_hours=@creditHours, semester=@sem WHERE course_code=@course_id";
                    SqlCommand cmd3 = new SqlCommand(updateCourse, con);
                    cmd3.Parameters.AddWithValue("@course_id", courseCode);
                    cmd3.Parameters.AddWithValue("@courseName", courseName);
                    cmd3.Parameters.AddWithValue("@creditHours", creditHrs);
                    cmd3.Parameters.AddWithValue("@sem", sem);
                    cmd3.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Course successfully updated.");
                }
            }


            this.Hide();
            new admin_panel().Show();
        }

        private void btn_add_course_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }

        private void update_course_txt_course_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void update_course_txt_course_code_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
