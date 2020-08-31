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
    public partial class view_all_courses : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ROZINA-PC;Initial Catalog=LMS;Integrated Security=True");

        public view_all_courses()
        {
            InitializeComponent();
            populateData();
        }

        private void titleLMS_Click(object sender, EventArgs e)
        {

        }

        private void label_add_course_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_all_course_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }

        private void populateData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM COURSES", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            all_courses_table.Rows.Clear();

            con.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string course_code = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string course_name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string credit_hours = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string semester = ds.Tables[0].Rows[i].ItemArray[3].ToString();



                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(all_courses_table);
                row1.Cells[0].Value = course_code;
                row1.Cells[1].Value = course_name;
                row1.Cells[2].Value = credit_hours;
                row1.Cells[3].Value = semester;
                all_courses_table.Rows.Add(row1);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
