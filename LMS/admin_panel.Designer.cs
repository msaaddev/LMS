namespace LMS
{
    partial class admin_panel
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
            this.titleLMS = new System.Windows.Forms.Label();
            this.admin_area = new System.Windows.Forms.Label();
            this.btn_admin_panel_add_course = new System.Windows.Forms.Button();
            this.btn_admin_panel_update_course = new System.Windows.Forms.Button();
            this.btn_admin_panel_delete_course = new System.Windows.Forms.Button();
            this.btn_admin_panel_view_all_courses = new System.Windows.Forms.Button();
            this.btn_admin_panel_add_student = new System.Windows.Forms.Button();
            this.btn_admin_panel_update_student = new System.Windows.Forms.Button();
            this.btn_admin_panel_delete_student = new System.Windows.Forms.Button();
            this.btn_admin_panel_logout = new System.Windows.Forms.Button();
            this.btn_admin_panel_view_all_students = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLMS
            // 
            this.titleLMS.AutoSize = true;
            this.titleLMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLMS.Location = new System.Drawing.Point(193, 40);
            this.titleLMS.Name = "titleLMS";
            this.titleLMS.Size = new System.Drawing.Size(407, 31);
            this.titleLMS.TabIndex = 2;
            this.titleLMS.Text = "Learning Management System";
            // 
            // admin_area
            // 
            this.admin_area.AutoSize = true;
            this.admin_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_area.Location = new System.Drawing.Point(311, 94);
            this.admin_area.Name = "admin_area";
            this.admin_area.Size = new System.Drawing.Size(144, 25);
            this.admin_area.TabIndex = 3;
            this.admin_area.Text = "Admin Panel";
            // 
            // btn_admin_panel_add_course
            // 
            this.btn_admin_panel_add_course.Location = new System.Drawing.Point(140, 128);
            this.btn_admin_panel_add_course.Name = "btn_admin_panel_add_course";
            this.btn_admin_panel_add_course.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_panel_add_course.TabIndex = 4;
            this.btn_admin_panel_add_course.Text = "Add Course";
            this.btn_admin_panel_add_course.UseVisualStyleBackColor = true;
            this.btn_admin_panel_add_course.Click += new System.EventHandler(this.btn_admin_panel_add_course_Click);
            // 
            // btn_admin_panel_update_course
            // 
            this.btn_admin_panel_update_course.Location = new System.Drawing.Point(140, 181);
            this.btn_admin_panel_update_course.Name = "btn_admin_panel_update_course";
            this.btn_admin_panel_update_course.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_panel_update_course.TabIndex = 5;
            this.btn_admin_panel_update_course.Text = "Update Course";
            this.btn_admin_panel_update_course.UseVisualStyleBackColor = true;
            this.btn_admin_panel_update_course.Click += new System.EventHandler(this.btn_admin_panel_update_course_Click);
            // 
            // btn_admin_panel_delete_course
            // 
            this.btn_admin_panel_delete_course.Location = new System.Drawing.Point(140, 237);
            this.btn_admin_panel_delete_course.Name = "btn_admin_panel_delete_course";
            this.btn_admin_panel_delete_course.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_panel_delete_course.TabIndex = 6;
            this.btn_admin_panel_delete_course.Text = "Delete Course";
            this.btn_admin_panel_delete_course.UseVisualStyleBackColor = true;
            this.btn_admin_panel_delete_course.Click += new System.EventHandler(this.btn_admin_panel_delete_course_Click);
            // 
            // btn_admin_panel_view_all_courses
            // 
            this.btn_admin_panel_view_all_courses.Location = new System.Drawing.Point(140, 299);
            this.btn_admin_panel_view_all_courses.Name = "btn_admin_panel_view_all_courses";
            this.btn_admin_panel_view_all_courses.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_panel_view_all_courses.TabIndex = 7;
            this.btn_admin_panel_view_all_courses.Text = "View All Courses";
            this.btn_admin_panel_view_all_courses.UseVisualStyleBackColor = true;
            this.btn_admin_panel_view_all_courses.Click += new System.EventHandler(this.btn_admin_panel_view_all_courses_Click);
            // 
            // btn_admin_panel_add_student
            // 
            this.btn_admin_panel_add_student.Location = new System.Drawing.Point(528, 128);
            this.btn_admin_panel_add_student.Name = "btn_admin_panel_add_student";
            this.btn_admin_panel_add_student.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_panel_add_student.TabIndex = 8;
            this.btn_admin_panel_add_student.Text = "Add Student";
            this.btn_admin_panel_add_student.UseVisualStyleBackColor = true;
            this.btn_admin_panel_add_student.Click += new System.EventHandler(this.btn_admin_panel_add_student_Click);
            // 
            // btn_admin_panel_update_student
            // 
            this.btn_admin_panel_update_student.Location = new System.Drawing.Point(528, 181);
            this.btn_admin_panel_update_student.Name = "btn_admin_panel_update_student";
            this.btn_admin_panel_update_student.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_panel_update_student.TabIndex = 9;
            this.btn_admin_panel_update_student.Text = "Update Student";
            this.btn_admin_panel_update_student.UseVisualStyleBackColor = true;
            this.btn_admin_panel_update_student.Click += new System.EventHandler(this.btn_admin_panel_update_student_Click);
            // 
            // btn_admin_panel_delete_student
            // 
            this.btn_admin_panel_delete_student.Location = new System.Drawing.Point(528, 237);
            this.btn_admin_panel_delete_student.Name = "btn_admin_panel_delete_student";
            this.btn_admin_panel_delete_student.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_panel_delete_student.TabIndex = 10;
            this.btn_admin_panel_delete_student.Text = "Delete Student";
            this.btn_admin_panel_delete_student.UseVisualStyleBackColor = true;
            this.btn_admin_panel_delete_student.Click += new System.EventHandler(this.btn_admin_panel_delete_student_Click);
            // 
            // btn_admin_panel_logout
            // 
            this.btn_admin_panel_logout.Location = new System.Drawing.Point(340, 351);
            this.btn_admin_panel_logout.Name = "btn_admin_panel_logout";
            this.btn_admin_panel_logout.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_panel_logout.TabIndex = 11;
            this.btn_admin_panel_logout.Text = "Logout";
            this.btn_admin_panel_logout.UseVisualStyleBackColor = true;
            this.btn_admin_panel_logout.Click += new System.EventHandler(this.btn_admin_panel_logout_Click);
            // 
            // btn_admin_panel_view_all_students
            // 
            this.btn_admin_panel_view_all_students.Location = new System.Drawing.Point(528, 299);
            this.btn_admin_panel_view_all_students.Name = "btn_admin_panel_view_all_students";
            this.btn_admin_panel_view_all_students.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_panel_view_all_students.TabIndex = 12;
            this.btn_admin_panel_view_all_students.Text = "View All Students";
            this.btn_admin_panel_view_all_students.UseVisualStyleBackColor = true;
            this.btn_admin_panel_view_all_students.Click += new System.EventHandler(this.btn_admin_panel_view_all_students_Click);
            // 
            // admin_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_admin_panel_view_all_students);
            this.Controls.Add(this.btn_admin_panel_logout);
            this.Controls.Add(this.btn_admin_panel_delete_student);
            this.Controls.Add(this.btn_admin_panel_update_student);
            this.Controls.Add(this.btn_admin_panel_add_student);
            this.Controls.Add(this.btn_admin_panel_view_all_courses);
            this.Controls.Add(this.btn_admin_panel_delete_course);
            this.Controls.Add(this.btn_admin_panel_update_course);
            this.Controls.Add(this.btn_admin_panel_add_course);
            this.Controls.Add(this.admin_area);
            this.Controls.Add(this.titleLMS);
            this.Name = "admin_panel";
            this.Text = "admin_panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLMS;
        private System.Windows.Forms.Label admin_area;
        private System.Windows.Forms.Button btn_admin_panel_add_course;
        private System.Windows.Forms.Button btn_admin_panel_update_course;
        private System.Windows.Forms.Button btn_admin_panel_delete_course;
        private System.Windows.Forms.Button btn_admin_panel_view_all_courses;
        private System.Windows.Forms.Button btn_admin_panel_add_student;
        private System.Windows.Forms.Button btn_admin_panel_update_student;
        private System.Windows.Forms.Button btn_admin_panel_delete_student;
        private System.Windows.Forms.Button btn_admin_panel_logout;
        private System.Windows.Forms.Button btn_admin_panel_view_all_students;
    }
}