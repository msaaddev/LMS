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
    public partial class delete_student : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ROZINA-PC;Initial Catalog=LMS;Integrated Security=True;MultipleActiveResultSets=true");

        public delete_student()
        {
            InitializeComponent();
        }

        private void titleLMS_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_student_Click(object sender, EventArgs e)
        {

            con.Open();

            string primaryKey = "SELECT * FROM STUDENT WHERE reg_no = @id";
            SqlCommand cmd2 = new SqlCommand(primaryKey, con);
            cmd2.Parameters.AddWithValue("@id", txt_delete_registration_no.Text);
            cmd2.ExecuteNonQuery();

            SqlDataReader read = cmd2.ExecuteReader();
            bool flag = read.HasRows;

            con.Close();

            if (!flag)
            {
                MessageBox.Show("Student does not exists.");
            }
            else
            {
                string reg_no = txt_delete_registration_no.Text;

                con.Open();

                string deleteStudent = "DELETE FROM STUDENT WHERE reg_no=@reg_no";
                SqlCommand cmd3 = new SqlCommand(deleteStudent, con);
                cmd3.Parameters.AddWithValue("@reg_no", reg_no);
                cmd3.ExecuteNonQuery();

                con.Close();

                con.Open();

                string deleteStudentCredentials = "DELETE FROM STUDENT_CREDENTIALS WHERE registration_no=@reg_number";
                SqlCommand cmd4 = new SqlCommand(deleteStudentCredentials, con);
                cmd4.Parameters.AddWithValue("@reg_number", reg_no);
                cmd4.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Student succesfully deleted.");

            }
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
