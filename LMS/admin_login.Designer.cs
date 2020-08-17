namespace LMS
{
    partial class admin_login
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
            this.btn_admin_login_back = new System.Windows.Forms.Button();
            this.btn_admin_login = new System.Windows.Forms.Button();
            this.label_admin_login = new System.Windows.Forms.Label();
            this.titleLMS = new System.Windows.Forms.Label();
            this.txt_login_admin_password = new System.Windows.Forms.TextBox();
            this.txt_login_admin_username = new System.Windows.Forms.TextBox();
            this.login_admin_password = new System.Windows.Forms.Label();
            this.login_admin_username = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_admin_login_back
            // 
            this.btn_admin_login_back.Location = new System.Drawing.Point(429, 384);
            this.btn_admin_login_back.Name = "btn_admin_login_back";
            this.btn_admin_login_back.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_login_back.TabIndex = 35;
            this.btn_admin_login_back.Text = "Back";
            this.btn_admin_login_back.UseVisualStyleBackColor = true;
            this.btn_admin_login_back.Click += new System.EventHandler(this.btn_admin_login_back_Click);
            // 
            // btn_admin_login
            // 
            this.btn_admin_login.Location = new System.Drawing.Point(213, 384);
            this.btn_admin_login.Name = "btn_admin_login";
            this.btn_admin_login.Size = new System.Drawing.Size(140, 37);
            this.btn_admin_login.TabIndex = 34;
            this.btn_admin_login.Text = "Login";
            this.btn_admin_login.UseVisualStyleBackColor = true;
            this.btn_admin_login.Click += new System.EventHandler(this.btn_admin_login_Click);
            // 
            // label_admin_login
            // 
            this.label_admin_login.AutoSize = true;
            this.label_admin_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_admin_login.Location = new System.Drawing.Point(324, 76);
            this.label_admin_login.Name = "label_admin_login";
            this.label_admin_login.Size = new System.Drawing.Size(142, 25);
            this.label_admin_login.TabIndex = 33;
            this.label_admin_login.Text = "Admin Login";
            // 
            // titleLMS
            // 
            this.titleLMS.AutoSize = true;
            this.titleLMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLMS.Location = new System.Drawing.Point(197, 30);
            this.titleLMS.Name = "titleLMS";
            this.titleLMS.Size = new System.Drawing.Size(407, 31);
            this.titleLMS.TabIndex = 32;
            this.titleLMS.Text = "Learning Management System";
            // 
            // txt_login_admin_password
            // 
            this.txt_login_admin_password.Location = new System.Drawing.Point(300, 239);
            this.txt_login_admin_password.Name = "txt_login_admin_password";
            this.txt_login_admin_password.Size = new System.Drawing.Size(341, 20);
            this.txt_login_admin_password.TabIndex = 39;
            // 
            // txt_login_admin_username
            // 
            this.txt_login_admin_username.Location = new System.Drawing.Point(300, 193);
            this.txt_login_admin_username.Name = "txt_login_admin_username";
            this.txt_login_admin_username.Size = new System.Drawing.Size(341, 20);
            this.txt_login_admin_username.TabIndex = 38;
            // 
            // login_admin_password
            // 
            this.login_admin_password.AutoSize = true;
            this.login_admin_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_admin_password.Location = new System.Drawing.Point(160, 239);
            this.login_admin_password.Name = "login_admin_password";
            this.login_admin_password.Size = new System.Drawing.Size(86, 20);
            this.login_admin_password.TabIndex = 37;
            this.login_admin_password.Text = "Password";
            // 
            // login_admin_username
            // 
            this.login_admin_username.AutoSize = true;
            this.login_admin_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_admin_username.Location = new System.Drawing.Point(160, 191);
            this.login_admin_username.Name = "login_admin_username";
            this.login_admin_username.Size = new System.Drawing.Size(91, 20);
            this.login_admin_username.TabIndex = 36;
            this.login_admin_username.Text = "Username";
            // 
            // admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_login_admin_password);
            this.Controls.Add(this.txt_login_admin_username);
            this.Controls.Add(this.login_admin_password);
            this.Controls.Add(this.login_admin_username);
            this.Controls.Add(this.btn_admin_login_back);
            this.Controls.Add(this.btn_admin_login);
            this.Controls.Add(this.label_admin_login);
            this.Controls.Add(this.titleLMS);
            this.Name = "admin_login";
            this.Text = "admin_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_admin_login_back;
        private System.Windows.Forms.Button btn_admin_login;
        private System.Windows.Forms.Label label_admin_login;
        private System.Windows.Forms.Label titleLMS;
        private System.Windows.Forms.TextBox txt_login_admin_password;
        private System.Windows.Forms.TextBox txt_login_admin_username;
        private System.Windows.Forms.Label login_admin_password;
        private System.Windows.Forms.Label login_admin_username;
    }
}