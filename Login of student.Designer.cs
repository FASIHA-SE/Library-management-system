namespace Login_page
{
    partial class Login_of_student
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
            this.Login_btn = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LOGIN_name = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_btn
            // 
            this.Login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_btn.Location = new System.Drawing.Point(348, 322);
            this.Login_btn.Name = "Login_btn";
            this.Login_btn.Size = new System.Drawing.Size(124, 38);
            this.Login_btn.TabIndex = 31;
            this.Login_btn.Text = "Login";
            this.Login_btn.UseVisualStyleBackColor = true;
            this.Login_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(419, 166);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(133, 20);
            this.username.TabIndex = 29;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(419, 244);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(133, 20);
            this.password.TabIndex = 30;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.Yellow;
            this.user.Location = new System.Drawing.Point(248, 158);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(147, 31);
            this.user.TabIndex = 28;
            this.user.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(248, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 31);
            this.label1.TabIndex = 27;
            this.label1.Text = "Password";
            // 
            // LOGIN_name
            // 
            this.LOGIN_name.AutoSize = true;
            this.LOGIN_name.BackColor = System.Drawing.Color.Transparent;
            this.LOGIN_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN_name.ForeColor = System.Drawing.Color.Yellow;
            this.LOGIN_name.Location = new System.Drawing.Point(306, 90);
            this.LOGIN_name.Name = "LOGIN_name";
            this.LOGIN_name.Size = new System.Drawing.Size(189, 37);
            this.LOGIN_name.TabIndex = 26;
            this.LOGIN_name.Text = "Login Page";
            // 
            // Login_of_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.Login_btn);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LOGIN_name);
            this.Name = "Login_of_student";
            this.Text = "Login_of_student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Login_btn;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LOGIN_name;
    }
}