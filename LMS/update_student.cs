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
    public partial class update_student : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ROZINA-PC;Initial Catalog=LMS;Integrated Security=True");

        public update_student()
        {
            InitializeComponent();
        }

        private void label_update_course_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_student_Click(object sender, EventArgs e)
        {
            con.Open();

            string primaryKey = "SELECT * FROM STUDENT WHERE reg_no = @reg";
            SqlCommand cmd2 = new SqlCommand(primaryKey, con);
            cmd2.Parameters.AddWithValue("@reg", txt_update_student_reg_num.Text);
            cmd2.ExecuteNonQuery();

            SqlDataReader read = cmd2.ExecuteReader();
            bool flag = read.HasRows;

            con.Close();

            if (!flag)
            {
                MessageBox.Show("No student with this registration number exists.");
            }
            else
            {
                string reg_no = txt_update_student_reg_num.Text;
                string name = txt_update_student_name.Text;
                string department = txt_update_student_department.Text;
                string isHostelite = txt_update_is_hostelite.Text;
                int sem = int.Parse(txt_update_student_semester.Text);

                if (reg_no == "" || name == "" || department == "" || isHostelite == "")
                {
                    MessageBox.Show("Please fill all the fields.");
                }
                else
                {
                    con.Open();
                    string updateStudent = "UPDATE STUDENT SET name=@name, department=@department, hostelite=@hostelite" +
                        ", semester=@semester WHERE reg_no=@reg_no";
                    SqlCommand cmd4 = new SqlCommand(updateStudent, con);
                    cmd4.Parameters.AddWithValue("@reg_no", reg_no);
                    cmd4.Parameters.AddWithValue("@name", name);
                    cmd4.Parameters.AddWithValue("@department", department);
                    cmd4.Parameters.AddWithValue("@hostelite", isHostelite);
                    cmd4.Parameters.AddWithValue("@semester", sem);
                    cmd4.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Student successfully updated.");
                    this.Hide();
                    new admin_panel().Show();
                }
            }

        }

        private void btn_update_student_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }
    }
}
