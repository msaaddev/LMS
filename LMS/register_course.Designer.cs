namespace LMS
{
    partial class register_course
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
            this.txt_register_course_student = new System.Windows.Forms.TextBox();
            this.label_register_course_student = new System.Windows.Forms.Label();
            this.btn_register_course_back = new System.Windows.Forms.Button();
            this.btn_register_course_student = new System.Windows.Forms.Button();
            this.label_register_course = new System.Windows.Forms.Label();
            this.titleLMS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_register_course_student
            // 
            this.txt_register_course_student.Location = new System.Drawing.Point(307, 207);
            this.txt_register_course_student.Name = "txt_register_course_student";
            this.txt_register_course_student.Size = new System.Drawing.Size(341, 20);
            this.txt_register_course_student.TabIndex = 29;
            // 
            // label_register_course_student
            // 
            this.label_register_course_student.AutoSize = true;
            this.label_register_course_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_register_course_student.Location = new System.Drawing.Point(152, 205);
            this.label_register_course_student.Name = "label_register_course_student";
            this.label_register_course_student.Size = new System.Drawing.Size(113, 20);
            this.label_register_course_student.TabIndex = 28;
            this.label_register_course_student.Text = "Course Code";
            // 
            // btn_register_course_back
            // 
            this.btn_register_course_back.Location = new System.Drawing.Point(451, 363);
            this.btn_register_course_back.Name = "btn_register_course_back";
            this.btn_register_course_back.Size = new System.Drawing.Size(140, 37);
            this.btn_register_course_back.TabIndex = 27;
            this.btn_register_course_back.Text = "Back";
            this.btn_register_course_back.UseVisualStyleBackColor = true;
            this.btn_register_course_back.Click += new System.EventHandler(this.btn_register_course_back_Click);
            // 
            // btn_register_course_student
            // 
            this.btn_register_course_student.Location = new System.Drawing.Point(235, 363);
            this.btn_register_course_student.Name = "btn_register_course_student";
            this.btn_register_course_student.Size = new System.Drawing.Size(140, 37);
            this.btn_register_course_student.TabIndex = 26;
            this.btn_register_course_student.Text = "Register";
            this.btn_register_course_student.UseVisualStyleBackColor = true;
            this.btn_register_course_student.Click += new System.EventHandler(this.btn_register_course_student_Click);
            // 
            // label_register_course
            // 
            this.label_register_course.AutoSize = true;
            this.label_register_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_register_course.Location = new System.Drawing.Point(342, 100);
            this.label_register_course.Name = "label_register_course";
            this.label_register_course.Size = new System.Drawing.Size(182, 25);
            this.label_register_course.TabIndex = 25;
            this.label_register_course.Text = "Register Course";
            // 
            // titleLMS
            // 
            this.titleLMS.AutoSize = true;
            this.titleLMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLMS.Location = new System.Drawing.Point(218, 51);
            this.titleLMS.Name = "titleLMS";
            this.titleLMS.Size = new System.Drawing.Size(407, 31);
            this.titleLMS.TabIndex = 24;
            this.titleLMS.Text = "Learning Management System";
            // 
            // register_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_register_course_student);
            this.Controls.Add(this.label_register_course_student);
            this.Controls.Add(this.btn_register_course_back);
            this.Controls.Add(this.btn_register_course_student);
            this.Controls.Add(this.label_register_course);
            this.Controls.Add(this.titleLMS);
            this.Name = "register_course";
            this.Text = "register_course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_register_course_student;
        private System.Windows.Forms.Label label_register_course_student;
        private System.Windows.Forms.Button btn_register_course_back;
        private System.Windows.Forms.Button btn_register_course_student;
        private System.Windows.Forms.Label label_register_course;
        private System.Windows.Forms.Label titleLMS;
    }
}