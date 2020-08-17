namespace LMS
{
    partial class delete_course
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
            this.delete_course_txt_course_code = new System.Windows.Forms.TextBox();
            this.delete_course_course_code = new System.Windows.Forms.Label();
            this.btn_delete_course_back = new System.Windows.Forms.Button();
            this.btn_delete_course_course_confirm = new System.Windows.Forms.Button();
            this.label_delete_course = new System.Windows.Forms.Label();
            this.titleLMS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete_course_txt_course_code
            // 
            this.delete_course_txt_course_code.Location = new System.Drawing.Point(307, 207);
            this.delete_course_txt_course_code.Name = "delete_course_txt_course_code";
            this.delete_course_txt_course_code.Size = new System.Drawing.Size(341, 20);
            this.delete_course_txt_course_code.TabIndex = 41;
            // 
            // delete_course_course_code
            // 
            this.delete_course_course_code.AutoSize = true;
            this.delete_course_course_code.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_course_course_code.Location = new System.Drawing.Point(152, 205);
            this.delete_course_course_code.Name = "delete_course_course_code";
            this.delete_course_course_code.Size = new System.Drawing.Size(113, 20);
            this.delete_course_course_code.TabIndex = 40;
            this.delete_course_course_code.Text = "Course Code";
            // 
            // btn_delete_course_back
            // 
            this.btn_delete_course_back.Location = new System.Drawing.Point(426, 324);
            this.btn_delete_course_back.Name = "btn_delete_course_back";
            this.btn_delete_course_back.Size = new System.Drawing.Size(140, 37);
            this.btn_delete_course_back.TabIndex = 39;
            this.btn_delete_course_back.Text = "Back";
            this.btn_delete_course_back.UseVisualStyleBackColor = true;
            this.btn_delete_course_back.Click += new System.EventHandler(this.btn_add_course_back_Click);
            // 
            // btn_delete_course_course_confirm
            // 
            this.btn_delete_course_course_confirm.Location = new System.Drawing.Point(210, 324);
            this.btn_delete_course_course_confirm.Name = "btn_delete_course_course_confirm";
            this.btn_delete_course_course_confirm.Size = new System.Drawing.Size(140, 37);
            this.btn_delete_course_course_confirm.TabIndex = 38;
            this.btn_delete_course_course_confirm.Text = "Delete";
            this.btn_delete_course_course_confirm.UseVisualStyleBackColor = true;
            this.btn_delete_course_course_confirm.Click += new System.EventHandler(this.btn_delete_course_course_confirm_Click);
            // 
            // label_delete_course
            // 
            this.label_delete_course.AutoSize = true;
            this.label_delete_course.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_delete_course.Location = new System.Drawing.Point(322, 100);
            this.label_delete_course.Name = "label_delete_course";
            this.label_delete_course.Size = new System.Drawing.Size(162, 25);
            this.label_delete_course.TabIndex = 37;
            this.label_delete_course.Text = "Delete Course";
            // 
            // titleLMS
            // 
            this.titleLMS.AutoSize = true;
            this.titleLMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLMS.Location = new System.Drawing.Point(218, 51);
            this.titleLMS.Name = "titleLMS";
            this.titleLMS.Size = new System.Drawing.Size(407, 31);
            this.titleLMS.TabIndex = 36;
            this.titleLMS.Text = "Learning Management System";
            // 
            // delete_course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delete_course_txt_course_code);
            this.Controls.Add(this.delete_course_course_code);
            this.Controls.Add(this.btn_delete_course_back);
            this.Controls.Add(this.btn_delete_course_course_confirm);
            this.Controls.Add(this.label_delete_course);
            this.Controls.Add(this.titleLMS);
            this.Name = "delete_course";
            this.Text = "delete_course";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox delete_course_txt_course_code;
        private System.Windows.Forms.Label delete_course_course_code;
        private System.Windows.Forms.Button btn_delete_course_back;
        private System.Windows.Forms.Button btn_delete_course_course_confirm;
        private System.Windows.Forms.Label label_delete_course;
        private System.Windows.Forms.Label titleLMS;
    }
}