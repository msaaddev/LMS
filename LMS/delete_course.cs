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
    public partial class delete_course : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ROZINA-PC;Initial Catalog=LMS;Integrated Security=True");

        public delete_course()
        {
            InitializeComponent();
        }

        private void btn_delete_course_course_confirm_Click(object sender, EventArgs e)
        {
            con.Open();

            string primaryKey = "SELECT * FROM COURSES WHERE course_code = @id";
            SqlCommand cmd2 = new SqlCommand(primaryKey, con);
            cmd2.Parameters.AddWithValue("@id", delete_course_txt_course_code.Text);
            cmd2.ExecuteNonQuery();

            SqlDataReader read = cmd2.ExecuteReader();
            bool flag = read.HasRows;

            con.Close();

            if (!flag)
            {
                MessageBox.Show("Course does not exists.");
            }
            else
            {
                string courseCode = delete_course_txt_course_code.Text;

                con.Open();

                string deleteCourse = "DELETE FROM COURSES WHERE course_code=@course_id";
                SqlCommand cmd3 = new SqlCommand(deleteCourse, con);
                cmd3.Parameters.AddWithValue("@course_id", courseCode);
                cmd3.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Course succesfully deleted.");

            }
            this.Hide();
            new admin_panel().Show();
        }

        private void btn_add_course_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }

        private void delete_course_txt_course_code_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
