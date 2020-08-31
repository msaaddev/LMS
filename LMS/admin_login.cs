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
    public partial class admin_login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ROZINA-PC;Initial Catalog=LMS;Integrated Security=True;MultipleActiveResultSets=true");

        public admin_login()
        {
            InitializeComponent();
        }

        private void btn_admin_login_Click(object sender, EventArgs e)
        {
            string user = txt_login_admin_username.Text;
            string pass = txt_login_admin_password.Text;

            if(user == "" || pass == "")
            {
                MessageBox.Show("Kindly fill all the fields.");
            }
            else
            {
                con.Open();
                string username = "SELECT * FROM ADMIN_CREDENTIALS WHERE admin_username = @username";
                string password = "SELECT * FROM ADMIN_CREDENTIALS WHERE admin_password = @password";
                SqlCommand cmd2 = new SqlCommand(username, con);
                SqlCommand cmd3 = new SqlCommand(password, con);
                cmd2.Parameters.AddWithValue("@username", txt_login_admin_username.Text);
                cmd3.Parameters.AddWithValue("@password", txt_login_admin_password.Text);
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();

                SqlDataReader read = cmd2.ExecuteReader();
                SqlDataReader read2 = cmd3.ExecuteReader();
                bool flag = read.HasRows;
                bool flag2 = read2.HasRows;

                con.Close();

                if (flag && flag2)
                {
                    this.Hide();
                    new admin_panel().Show();
                }
                else
                {
                    MessageBox.Show("Invalid credentials.");
                }
            }

            
        }

        private void btn_admin_login_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new main_window().Show();
        }

        private void admin_sign_up_Click(object sender, EventArgs e)
        {
            this.Hide();
            new sign_up().Show();
        }
    }
}
