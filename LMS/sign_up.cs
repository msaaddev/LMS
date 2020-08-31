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
    public partial class sign_up : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ROZINA-PC;Initial Catalog=LMS;Integrated Security=True;MultipleActiveResultSets=true");

        public sign_up()
        {
            InitializeComponent();
        }

        private void sign_up_Load(object sender, EventArgs e)
        {

        }

        private void btn_admin_signup_confirm_Click(object sender, EventArgs e)
        {
            con.Open();

            string primaryKey = "SELECT * FROM ADMIN WHERE id = @id";
            string username = "SELECT * FROM ADMIN_CREDENTIALS WHERE admin_username = @username";
            SqlCommand cmd2 = new SqlCommand(primaryKey, con);
            SqlCommand cmd3 = new SqlCommand(username, con);
            cmd2.Parameters.AddWithValue("@id", signup_txt_admin_id.Text);
            cmd3.Parameters.AddWithValue("@username", signup_txt_admin_username.Text);
            cmd2.ExecuteNonQuery();
            cmd3.ExecuteNonQuery();

            SqlDataReader read = cmd2.ExecuteReader();
            SqlDataReader read2 = cmd3.ExecuteReader();
            bool flag = read.HasRows;
            bool flag2 = read2.HasRows;

            con.Close();

            if (flag || flag2)
            {
                MessageBox.Show("An admin with this id or username already exists.");
            }
            else
            {
                string id = signup_txt_admin_id.Text;
                string name = signup_txt_admin_name.Text;
                string designation = sign_up_txt_admin_designation.Text;
                string usrname = signup_txt_admin_username.Text;
                string password = signup_txt_admin_password.Text;

                if (id == "" || name == "" || designation == "" || usrname == "" || password == "")
                {
                    MessageBox.Show("Please fill all the fields.");
                }
                else
                {
                    con.Open();

                    string insertIntoAdmin = "INSERT INTO ADMIN(id, admin_name, designation) " +
                        "values(@id, @admin_name, @designation)";
                    SqlCommand cmd4 = new SqlCommand(insertIntoAdmin, con);
                    cmd4.Parameters.AddWithValue("@id", id);
                    cmd4.Parameters.AddWithValue("@admin_name", name);
                    cmd4.Parameters.AddWithValue("@designation", designation);
                    cmd4.ExecuteNonQuery();

                    string insertIntoAdminCredentials = "INSERT INTO ADMIN_CREDENTIALS(admin_id, admin_username, admin_password) " +
                        "values(@admin_id, @admin_username, @admin_password)";
                    SqlCommand cmd5 = new SqlCommand(insertIntoAdminCredentials, con);
                    cmd5.Parameters.AddWithValue("@admin_id", id);
                    cmd5.Parameters.AddWithValue("@admin_username", usrname);
                    cmd5.Parameters.AddWithValue("@admin_password", password);
                    cmd5.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Admin successfully added.");

                    this.Hide();
                    new main_window().Show();
                }

            }
        }

        private void btn_admin_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_login().Show();
        }
    }
}
