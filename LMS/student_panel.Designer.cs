namespace LMS
{
    partial class student_panel
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
            this.btn_student_panel_logout = new System.Windows.Forms.Button();
            this.btn_student_registered_courses = new System.Windows.Forms.Button();
            this.btn_register_course = new System.Windows.Forms.Button();
            this.admin_area = new System.Windows.Forms.Label();
            this.titleLMS = new System.Windows.Forms.Label();
            this.btn_student_view_courses = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_student_panel_logout
            // 
            this.btn_student_panel_logout.Location = new System.Drawing.Point(346, 353);
            this.btn_student_panel_logout.Name = "btn_student_panel_logout";
            this.btn_student_panel_logout.Size = new System.Drawing.Size(140, 37);
            this.btn_student_panel_logout.TabIndex = 17;
            this.btn_student_panel_logout.Text = "Logout";
            this.btn_student_panel_logout.UseVisualStyleBackColor = true;
            this.btn_student_panel_logout.Click += new System.EventHandler(this.btn_student_panel_logout_Click);
            // 
            // btn_student_registered_courses
            // 
            this.btn_student_registered_courses.Location = new System.Drawing.Point(345, 270);
            this.btn_student_registered_courses.Name = "btn_student_registered_courses";
            this.btn_student_registered_courses.Size = new System.Drawing.Size(140, 37);
            this.btn_student_registered_courses.TabIndex = 16;
            this.btn_student_registered_courses.Text = "View Registered Courses";
            this.btn_student_registered_courses.UseVisualStyleBackColor = true;
            this.btn_student_registered_courses.Click += new System.EventHandler(this.btn_student_registered_courses_Click);
            // 
            // btn_register_course
            // 
            this.btn_register_course.Location = new System.Drawing.Point(345, 208);
            this.btn_register_course.Name = "btn_register_course";
            this.btn_register_course.Size = new System.Drawing.Size(140, 37);
            this.btn_register_course.TabIndex = 15;
            this.btn_register_course.Text = "Register Course";
            this.btn_register_course.UseVisualStyleBackColor = true;
            this.btn_register_course.Click += new System.EventHandler(this.btn_register_course_Click);
            // 
            // admin_area
            // 
            this.admin_area.AutoSize = true;
            this.admin_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_area.Location = new System.Drawing.Point(341, 105);
            this.admin_area.Name = "admin_area";
            this.admin_area.Size = new System.Drawing.Size(144, 25);
            this.admin_area.TabIndex = 13;
            this.admin_area.Text = "Admin Panel";
            // 
            // titleLMS
            // 
            this.titleLMS.AutoSize = true;
            this.titleLMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLMS.Location = new System.Drawing.Point(223, 51);
            this.titleLMS.Name = "titleLMS";
            this.titleLMS.Size = new System.Drawing.Size(407, 31);
            this.titleLMS.TabIndex = 12;
            this.titleLMS.Text = "Learning Management System";
            // 
            // btn_student_view_courses
            // 
            this.btn_student_view_courses.Location = new System.Drawing.Point(345, 150);
            this.btn_student_view_courses.Name = "btn_student_view_courses";
            this.btn_student_view_courses.Size = new System.Drawing.Size(140, 37);
            this.btn_student_view_courses.TabIndex = 18;
            this.btn_student_view_courses.Text = "View All Courses";
            this.btn_student_view_courses.UseVisualStyleBackColor = true;
            this.btn_student_view_courses.Click += new System.EventHandler(this.btn_student_view_courses_Click);
            // 
            // student_panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_student_view_courses);
            this.Controls.Add(this.btn_student_panel_logout);
            this.Controls.Add(this.btn_student_registered_courses);
            this.Controls.Add(this.btn_register_course);
            this.Controls.Add(this.admin_area);
            this.Controls.Add(this.titleLMS);
            this.Name = "student_panel";
            this.Text = "student_panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_student_panel_logout;
        private System.Windows.Forms.Button btn_student_registered_courses;
        private System.Windows.Forms.Button btn_register_course;
        private System.Windows.Forms.Label admin_area;
        private System.Windows.Forms.Label titleLMS;
        private System.Windows.Forms.Button btn_student_view_courses;
    }
}