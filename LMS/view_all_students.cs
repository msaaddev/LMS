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
    public partial class view_all_students : Form
    {
        SqlConnection con = new SqlConnection("Data Source=ROZINA-PC;Initial Catalog=LMS;Integrated Security=True");

        public view_all_students()
        {
            InitializeComponent();
            populateData();
        }

        private void view_all_students_Load(object sender, EventArgs e)
        {

        }

        private void btn_all_course_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            new admin_panel().Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void populateData()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            adapter.Fill(ds);
            view_all_students_table.Rows.Clear();

            con.Close();

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                string reg_no = ds.Tables[0].Rows[i].ItemArray[0].ToString();
                string name = ds.Tables[0].Rows[i].ItemArray[1].ToString();
                string department = ds.Tables[0].Rows[i].ItemArray[2].ToString();
                string isHostelite = ds.Tables[0].Rows[i].ItemArray[3].ToString();
                string sem = ds.Tables[0].Rows[i].ItemArray[4].ToString();



                DataGridViewRow row1 = new DataGridViewRow();
                row1.CreateCells(view_all_students_table);
                row1.Cells[0].Value = reg_no;
                row1.Cells[1].Value = name;
                row1.Cells[2].Value = sem;
                row1.Cells[3].Value = department;
                row1.Cells[4].Value = isHostelite;
                view_all_students_table.Rows.Add(row1);
            }
        }
    }
}
