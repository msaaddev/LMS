namespace LMS
{
    partial class delete_student
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
            this.txt_delete_registration_no = new System.Windows.Forms.TextBox();
            this.delete_registration_number = new System.Windows.Forms.Label();
            this.btn_delete_student_back = new System.Windows.Forms.Button();
            this.btn_delete_student = new System.Windows.Forms.Button();
            this.label_delete_student = new System.Windows.Forms.Label();
            this.titleLMS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_delete_registration_no
            // 
            this.txt_delete_registration_no.Location = new System.Drawing.Point(307, 226);
            this.txt_delete_registration_no.Name = "txt_delete_registration_no";
            this.txt_delete_registration_no.Size = new System.Drawing.Size(341, 20);
            this.txt_delete_registration_no.TabIndex = 47;
            // 
            // delete_registration_number
            // 
            this.delete_registration_number.AutoSize = true;
            this.delete_registration_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_registration_number.Location = new System.Drawing.Point(152, 224);
            this.delete_registration_number.Name = "delete_registration_number";
            this.delete_registration_number.Size = new System.Drawing.Size(139, 20);
            this.delete_registration_number.TabIndex = 46;
            this.delete_registration_number.Text = "Registration No.";
            // 
            // btn_delete_student_back
            // 
            this.btn_delete_student_back.Location = new System.Drawing.Point(426, 343);
            this.btn_delete_student_back.Name = "btn_delete_student_back";
            this.btn_delete_student_back.Size = new System.Drawing.Size(140, 37);
            this.btn_delete_student_back.TabIndex = 45;
            this.btn_delete_student_back.Text = "Back";
            this.btn_delete_student_back.UseVisualStyleBackColor = true;
            this.btn_delete_student_back.Click += new System.EventHandler(this.btn_delete_student_back_Click);
            // 
            // btn_delete_student
            // 
            this.btn_delete_student.Location = new System.Drawing.Point(210, 343);
            this.btn_delete_student.Name = "btn_delete_student";
            this.btn_delete_student.Size = new System.Drawing.Size(140, 37);
            this.btn_delete_student.TabIndex = 44;
            this.btn_delete_student.Text = "Delete";
            this.btn_delete_student.UseVisualStyleBackColor = true;
            this.btn_delete_student.Click += new System.EventHandler(this.btn_delete_student_Click);
            // 
            // label_delete_student
            // 
            this.label_delete_student.AutoSize = true;
            this.label_delete_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_delete_student.Location = new System.Drawing.Point(322, 119);
            this.label_delete_student.Name = "label_delete_student";
            this.label_delete_student.Size = new System.Drawing.Size(168, 25);
            this.label_delete_student.TabIndex = 43;
            this.label_delete_student.Text = "Delete Student";
            // 
            // titleLMS
            // 
            this.titleLMS.AutoSize = true;
            this.titleLMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLMS.Location = new System.Drawing.Point(218, 70);
            this.titleLMS.Name = "titleLMS";
            this.titleLMS.Size = new System.Drawing.Size(407, 31);
            this.titleLMS.TabIndex = 42;
            this.titleLMS.Text = "Learning Management System";
            this.titleLMS.Click += new System.EventHandler(this.titleLMS_Click);
            // 
            // delete_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_delete_registration_no);
            this.Controls.Add(this.delete_registration_number);
            this.Controls.Add(this.btn_delete_student_back);
            this.Controls.Add(this.btn_delete_student);
            this.Controls.Add(this.label_delete_student);
            this.Controls.Add(this.titleLMS);
            this.Name = "delete_student";
            this.Text = "delete_student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_delete_registration_no;
        private System.Windows.Forms.Label delete_registration_number;
        private System.Windows.Forms.Button btn_delete_student_back;
        private System.Windows.Forms.Button btn_delete_student;
        private System.Windows.Forms.Label label_delete_student;
        private System.Windows.Forms.Label titleLMS;
    }
}