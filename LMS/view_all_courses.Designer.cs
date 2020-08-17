namespace LMS
{
    partial class view_all_courses
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
            this.label_all_course = new System.Windows.Forms.Label();
            this.titleLMS = new System.Windows.Forms.Label();
            this.btn_all_course_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.header_course_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_course_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.header_credit_hours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_all_course
            // 
            this.label_all_course.AutoSize = true;
            this.label_all_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_all_course.Location = new System.Drawing.Point(340, 76);
            this.label_all_course.Name = "label_all_course";
            this.label_all_course.Size = new System.Drawing.Size(133, 25);
            this.label_all_course.TabIndex = 7;
            this.label_all_course.Text = "All Courses";
            this.label_all_course.Click += new System.EventHandler(this.label_add_course_Click);
            // 
            // titleLMS
            // 
            this.titleLMS.AutoSize = true;
            this.titleLMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLMS.Location = new System.Drawing.Point(202, 27);
            this.titleLMS.Name = "titleLMS";
            this.titleLMS.Size = new System.Drawing.Size(407, 31);
            this.titleLMS.TabIndex = 6;
            this.titleLMS.Text = "Learning Management System";
            this.titleLMS.Click += new System.EventHandler(this.titleLMS_Click);
            // 
            // btn_all_course_back
            // 
            this.btn_all_course_back.Location = new System.Drawing.Point(321, 385);
            this.btn_all_course_back.Name = "btn_all_course_back";
            this.btn_all_course_back.Size = new System.Drawing.Size(140, 37);
            this.btn_all_course_back.TabIndex = 22;
            this.btn_all_course_back.Text = "Back";
            this.btn_all_course_back.UseVisualStyleBackColor = true;
            this.btn_all_course_back.Click += new System.EventHandler(this.btn_all_course_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.header_course_code,
            this.header_course_name,
            this.header_semester,
            this.header_credit_hours});
            this.dataGridView1.Location = new System.Drawing.Point(175, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // header_course_code
            // 
            this.header_course_code.HeaderText = "Course Code";
            this.header_course_code.Name = "header_course_code";
            // 
            // header_course_name
            // 
            this.header_course_name.HeaderText = "Course Name";
            this.header_course_name.Name = "header_course_name";
            // 
            // header_semester
            // 
            this.header_semester.HeaderText = "Semester";
            this.header_semester.Name = "header_semester";
            // 
            // header_credit_hours
            // 
            this.header_credit_hours.HeaderText = "Credit Hours";
            this.header_credit_hours.Name = "header_credit_hours";
            // 
            // view_all_courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_all_course_back);
            this.Controls.Add(this.label_all_course);
            this.Controls.Add(this.titleLMS);
            this.Name = "view_all_courses";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_all_course;
        private System.Windows.Forms.Label titleLMS;
        private System.Windows.Forms.Button btn_all_course_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_course_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_course_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn header_credit_hours;
    }
}