namespace Login_page
{
    partial class STD__REG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(STD__REG));
            this.rg_btn = new System.Windows.Forms.Button();
            this.regname = new System.Windows.Forms.TextBox();
            this.regpass = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reg_name = new System.Windows.Forms.Label();
            this.BACK_std = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rg_btn
            // 
            this.rg_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rg_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rg_btn.Location = new System.Drawing.Point(197, 337);
            this.rg_btn.Name = "rg_btn";
            this.rg_btn.Size = new System.Drawing.Size(124, 38);
            this.rg_btn.TabIndex = 32;
            this.rg_btn.Text = "Login";
            this.rg_btn.UseVisualStyleBackColor = true;
            this.rg_btn.Click += new System.EventHandler(this.Login_btn_Click);
            // 
            // regname
            // 
            this.regname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regname.Location = new System.Drawing.Point(257, 162);
            this.regname.Name = "regname";
            this.regname.Size = new System.Drawing.Size(185, 21);
            this.regname.TabIndex = 30;
            // 
            // regpass
            // 
            this.regpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regpass.Location = new System.Drawing.Point(257, 209);
            this.regpass.Name = "regpass";
            this.regpass.Size = new System.Drawing.Size(185, 21);
            this.regpass.TabIndex = 31;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.user.ForeColor = System.Drawing.Color.Black;
            this.user.Location = new System.Drawing.Point(53, 162);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(100, 22);
            this.user.TabIndex = 29;
            this.user.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Password";
            // 
            // reg_name
            // 
            this.reg_name.AutoSize = true;
            this.reg_name.BackColor = System.Drawing.Color.Transparent;
            this.reg_name.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reg_name.ForeColor = System.Drawing.Color.Black;
            this.reg_name.Location = new System.Drawing.Point(123, 63);
            this.reg_name.Name = "reg_name";
            this.reg_name.Size = new System.Drawing.Size(281, 41);
            this.reg_name.TabIndex = 27;
            this.reg_name.Text = "Login of student ";
            // 
            // BACK_std
            // 
            this.BACK_std.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BACK_std.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BACK_std.Location = new System.Drawing.Point(197, 422);
            this.BACK_std.Name = "BACK_std";
            this.BACK_std.Size = new System.Drawing.Size(124, 38);
            this.BACK_std.TabIndex = 33;
            this.BACK_std.Text = "BACK";
            this.BACK_std.UseVisualStyleBackColor = true;
            this.BACK_std.Click += new System.EventHandler(this.BACK_std_Click);
            // 
            // STD__REG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 485);
            this.Controls.Add(this.BACK_std);
            this.Controls.Add(this.rg_btn);
            this.Controls.Add(this.regname);
            this.Controls.Add(this.regpass);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reg_name);
            this.DoubleBuffered = true;
            this.Name = "STD__REG";
            this.Text = "STD__REG";
            this.Load += new System.EventHandler(this.STD__REG_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rg_btn;
        private System.Windows.Forms.TextBox regname;
        private System.Windows.Forms.TextBox regpass;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label reg_name;
        private System.Windows.Forms.Button BACK_std;
    }
}