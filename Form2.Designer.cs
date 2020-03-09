namespace LMS
{
    partial class Form2
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
            this.admin_sign_in = new System.Windows.Forms.Label();
            this.btn_admin_login = new System.Windows.Forms.Button();
            this.txt_admin_username = new System.Windows.Forms.TextBox();
            this.admin_username = new System.Windows.Forms.Label();
            this.admin_password = new System.Windows.Forms.Label();
            this.txt_admin_password = new System.Windows.Forms.TextBox();
            this.btn_admin_signup = new System.Windows.Forms.Button();
            this.btn_admin_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLMS
            // 
            this.titleLMS.AutoSize = true;
            this.titleLMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLMS.Location = new System.Drawing.Point(195, 39);
            this.titleLMS.Name = "titleLMS";
            this.titleLMS.Size = new System.Drawing.Size(407, 31);
            this.titleLMS.TabIndex = 1;
            this.titleLMS.Text = "Learning Management System";
            // 
            // admin_sign_in
            // 
            this.admin_sign_in.AutoSize = true;
            this.admin_sign_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_sign_in.Location = new System.Drawing.Point(314, 91);
            this.admin_sign_in.Name = "admin_sign_in";
            this.admin_sign_in.Size = new System.Drawing.Size(157, 25);
            this.admin_sign_in.TabIndex = 2;
            this.admin_sign_in.Text = "Admin Sign In";
            // 
            // btn_admin_login
            // 
            this.btn_admin_login.Location = new System.Drawing.Point(153, 302);
            this.btn_admin_login.Name = "btn_admin_login";
            this.btn_admin_login.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_login.TabIndex = 3;
            this.btn_admin_login.Text = "Login";
            this.btn_admin_login.UseVisualStyleBackColor = true;
            this.btn_admin_login.Click += new System.EventHandler(this.btn_admin_login_Click);
            // 
            // txt_admin_username
            // 
            this.txt_admin_username.Location = new System.Drawing.Point(272, 176);
            this.txt_admin_username.Name = "txt_admin_username";
            this.txt_admin_username.Size = new System.Drawing.Size(341, 20);
            this.txt_admin_username.TabIndex = 4;
            // 
            // admin_username
            // 
            this.admin_username.AutoSize = true;
            this.admin_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_username.Location = new System.Drawing.Point(165, 173);
            this.admin_username.Name = "admin_username";
            this.admin_username.Size = new System.Drawing.Size(91, 20);
            this.admin_username.TabIndex = 5;
            this.admin_username.Text = "Username";
            // 
            // admin_password
            // 
            this.admin_password.AutoSize = true;
            this.admin_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_password.Location = new System.Drawing.Point(165, 221);
            this.admin_password.Name = "admin_password";
            this.admin_password.Size = new System.Drawing.Size(86, 20);
            this.admin_password.TabIndex = 6;
            this.admin_password.Text = "Password";
            this.admin_password.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_admin_password
            // 
            this.txt_admin_password.Location = new System.Drawing.Point(272, 221);
            this.txt_admin_password.Name = "txt_admin_password";
            this.txt_admin_password.Size = new System.Drawing.Size(341, 20);
            this.txt_admin_password.TabIndex = 7;
            this.txt_admin_password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btn_admin_signup
            // 
            this.btn_admin_signup.Location = new System.Drawing.Point(332, 302);
            this.btn_admin_signup.Name = "btn_admin_signup";
            this.btn_admin_signup.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_signup.TabIndex = 8;
            this.btn_admin_signup.Text = "Sign Up";
            this.btn_admin_signup.UseVisualStyleBackColor = true;
            this.btn_admin_signup.Click += new System.EventHandler(this.btn_admin_signup_Click);
            // 
            // btn_admin_back
            // 
            this.btn_admin_back.Location = new System.Drawing.Point(512, 302);
            this.btn_admin_back.Name = "btn_admin_back";
            this.btn_admin_back.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_back.TabIndex = 9;
            this.btn_admin_back.Text = "Back";
            this.btn_admin_back.UseVisualStyleBackColor = true;
            this.btn_admin_back.Click += new System.EventHandler(this.btn_admin_back_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_admin_back);
            this.Controls.Add(this.btn_admin_signup);
            this.Controls.Add(this.txt_admin_password);
            this.Controls.Add(this.admin_password);
            this.Controls.Add(this.admin_username);
            this.Controls.Add(this.txt_admin_username);
            this.Controls.Add(this.btn_admin_login);
            this.Controls.Add(this.admin_sign_in);
            this.Controls.Add(this.titleLMS);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLMS;
        private System.Windows.Forms.Label admin_sign_in;
        private System.Windows.Forms.Button btn_admin_login;
        private System.Windows.Forms.TextBox txt_admin_username;
        private System.Windows.Forms.Label admin_username;
        private System.Windows.Forms.Label admin_password;
        private System.Windows.Forms.TextBox txt_admin_password;
        private System.Windows.Forms.Button btn_admin_signup;
        private System.Windows.Forms.Button btn_admin_back;
    }
}