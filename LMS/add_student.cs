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
    public partial class add_student : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ROZINA-PC;Initial Catalog=LMS;Integrated Security=True;MultipleActiveResultSets=true");

        public add_student()
        {
            InitializeComponent();
        }

        private void signup_admin_id_Click(object sender, EventArgs e)
        {

        }

        private void btn_student_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }

        private void btn_student_add_Click(object sender, EventArgs e)
        {
            con.Open();

            string primaryKey = "SELECT * FROM STUDENT WHERE reg_no = @reg";
            string username = "SELECT * FROM STUDENT_CREDENTIALS WHERE username = @username";
            SqlCommand cmd2 = new SqlCommand(primaryKey, con);
            SqlCommand cmd3 = new SqlCommand(username, con);
            cmd2.Parameters.AddWithValue("@reg", txt_student_reg_num.Text);
            cmd3.Parameters.AddWithValue("@username", txt_student_username.Text);
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();

            SqlDataReader read = cmd2.ExecuteReader();
            SqlDataReader read2 = cmd3.ExecuteReader();
            bool flag = read.HasRows;
            bool flag2 = read2.HasRows;

            con.Close();

            if (flag || flag2)
            {
                MessageBox.Show("A student with this registration number or username already exists.");
            }
            else
            {
                string reg_no = txt_student_reg_num.Text;
                string name = txt_student_name.Text;
                string department = txt_student_department.Text;
                string isHostelite = txt_is_hostelite.Text;
                string usrname = txt_student_username.Text;
                string password = txt_student_password.Text;
                int sem = int.Parse(txt_student_semester.Text);

                if (reg_no == "" || name == "" || department == "" || isHostelite =="" || usrname == "" || password == "")
                {
                    MessageBox.Show("Please fill all the fields.");
                }
                else
                {
                    con.Open();

                    string insertIntoStudents = "INSERT INTO STUDENT(reg_no, name, department, hostelite, semester) " +
                        "values(@reg_no, @name, @department, @hostelite , @semester)";
                    SqlCommand cmd4 = new SqlCommand(insertIntoStudents, con);
                    cmd4.Parameters.AddWithValue("@reg_no", reg_no);
                    cmd4.Parameters.AddWithValue("@name", name);
                    cmd4.Parameters.AddWithValue("@department", department);
                    cmd4.Parameters.AddWithValue("@hostelite", isHostelite);
                    cmd4.Parameters.AddWithValue("@semester", sem);
                    cmd4.ExecuteNonQuery();

                    string insertIntoStudentsCredentials = "INSERT INTO STUDENT_CREDENTIALS(username, password, registration_no) " +
                        "values(@username, @password, @registration_no)";
                    SqlCommand cmd5 = new SqlCommand(insertIntoStudentsCredentials, con);
                    cmd5.Parameters.AddWithValue("@username", usrname);
                    cmd5.Parameters.AddWithValue("@password", password);
                    cmd5.Parameters.AddWithValue("@registration_no", reg_no);
                    cmd5.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Student successfully added.");
                }
            }
            this.Hide();
            new admin_panel().Show();
        }

        private void add_student_Load(object sender, EventArgs e)
        {

        }

        private void txt_student_reg_num_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
