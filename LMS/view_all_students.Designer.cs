namespace LMS
{
    partial class view_all_students
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.view_all_students_table = new System.Windows.Forms.DataGridView();
            this.header_reg_num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_student_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_student_semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_student_department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_is_hostelite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_all_students_back = new System.Windows.Forms.Button();
            this.label_all_course = new System.Windows.Forms.Label();
            this.titleLMS = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.view_all_students_table)).BeginInit();
            this.SuspendLayout();
            // 
            // view_all_students_table
            // 
            this.view_all_students_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_all_students_table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.header_reg_num,
            this.header_student_name,
            this.header_student_semester,
            this.header_student_department,
            this.header_is_hostelite});
            this.view_all_students_table.Location = new System.Drawing.Point(136, 123);
            this.view_all_students_table.Name = "view_all_students_table";
            this.view_all_students_table.Size = new System.Drawing.Size(545, 150);
            this.view_all_students_table.TabIndex = 27;
            this.view_all_students_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // header_reg_num
            // 
            this.header_reg_num.HeaderText = "Registration No.";
            this.header_reg_num.Name = "header_reg_num";
            // 
            // header_student_name
            // 
            this.header_student_name.HeaderText = "Name";
            this.header_student_name.Name = "header_student_name";
            // 
            // header_student_semester
            // 
            this.header_student_semester.HeaderText = "Semester";
            this.header_student_semester.Name = "header_student_semester";
            // 
            // header_student_department
            // 
            this.header_student_department.HeaderText = "Department";
            this.header_student_department.Name = "header_student_department";
            // 
            // header_is_hostelite
            // 
            this.header_is_hostelite.HeaderText = "Hostelite";
            this.header_is_hostelite.Name = "header_is_hostelite";
            // 
            // btn_all_students_back
            // 
            this.btn_all_students_back.Location = new System.Drawing.Point(325, 386);
            this.btn_all_students_back.Name = "btn_all_students_back";
            this.btn_all_students_back.Size = new System.Drawing.Size(140, 37);
            this.btn_all_students_back.TabIndex = 26;
            this.btn_all_students_back.Text = "Back";
            this.btn_all_students_back.UseVisualStyleBackColor = true;
            this.btn_all_students_back.Click += new System.EventHandler(this.btn_all_course_back_Click);
            // 
            // label_all_course
            // 
            this.label_all_course.AutoSize = true;
            this.label_all_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_all_course.Location = new System.Drawing.Point(326, 82);
            this.label_all_course.Name = "label_all_course";
            this.label_all_course.Size = new System.Drawing.Size(139, 25);
            this.label_all_course.TabIndex = 25;
            this.label_all_course.Text = "All Students";
            // 
            // titleLMS
            // 
            this.titleLMS.AutoSize = true;
            this.titleLMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLMS.Location = new System.Drawing.Point(206, 28);
            this.titleLMS.Name = "titleLMS";
            this.titleLMS.Size = new System.Drawing.Size(407, 31);
            this.titleLMS.TabIndex = 24;
            this.titleLMS.Text = "Learning Management System";
            // 
            // view_all_students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.view_all_students_table);
            this.Controls.Add(this.btn_all_students_back);
            this.Controls.Add(this.label_all_course);
            this.Controls.Add(this.titleLMS);
            this.Name = "view_all_students";
            this.Text = "view_all_students";
            this.Load += new System.EventHandler(this.view_all_students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_all_students_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView view_all_students_table;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_reg_num;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_student_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_student_semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_student_department;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_is_hostelite;
        private System.Windows.Forms.Button btn_all_students_back;
        private System.Windows.Forms.Label label_all_course;
        private System.Windows.Forms.Label titleLMS;
    }
}