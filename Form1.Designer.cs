namespace LMS
{
    partial class Form1
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
            this.btn_admin_sign_in = new System.Windows.Forms.Button();
            this.btn_student_sign_in = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLMS
            // 
            this.titleLMS.AutoSize = true;
            this.titleLMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLMS.Location = new System.Drawing.Point(198, 61);
            this.titleLMS.Name = "titleLMS";
            this.titleLMS.Size = new System.Drawing.Size(407, 31);
            this.titleLMS.TabIndex = 0;
            this.titleLMS.Text = "Learning Management System";
            // 
            // btn_admin_sign_in
            // 
            this.btn_admin_sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_sign_in.Location = new System.Drawing.Point(132, 187);
            this.btn_admin_sign_in.Name = "btn_admin_sign_in";
            this.btn_admin_sign_in.Size = new System.Drawing.Size(173, 56);
            this.btn_admin_sign_in.TabIndex = 1;
            this.btn_admin_sign_in.Text = "Admin Sign in";
            this.btn_admin_sign_in.UseVisualStyleBackColor = true;
            this.btn_admin_sign_in.Click += new System.EventHandler(this.btn_admin_sign_in_Click);
            // 
            // btn_student_sign_in
            // 
            this.btn_student_sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_student_sign_in.Location = new System.Drawing.Point(474, 187);
            this.btn_student_sign_in.Name = "btn_student_sign_in";
            this.btn_student_sign_in.Size = new System.Drawing.Size(173, 56);
            this.btn_student_sign_in.TabIndex = 2;
            this.btn_student_sign_in.Text = "Student Sign in";
            this.btn_student_sign_in.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_student_sign_in);
            this.Controls.Add(this.btn_admin_sign_in);
            this.Controls.Add(this.titleLMS);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLMS;
        private System.Windows.Forms.Button btn_admin_sign_in;
        private System.Windows.Forms.Button btn_student_sign_in;
    }
}

