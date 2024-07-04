
namespace Login_page
{
    partial class MAIN_PAGE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAIN_PAGE));
            this.library_panel2 = new System.Windows.Forms.Panel();
            this.librarian_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.Book_btn = new System.Windows.Forms.Button();
            this.Student_btn = new System.Windows.Forms.Button();
            this.library_name = new System.Windows.Forms.Label();
            this.Library_panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.library_panel2.SuspendLayout();
            this.Library_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // library_panel2
            // 
            this.library_panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.library_panel2.Controls.Add(this.librarian_btn);
            this.library_panel2.Controls.Add(this.Exit_btn);
            this.library_panel2.Controls.Add(this.Book_btn);
            this.library_panel2.Controls.Add(this.Student_btn);
            this.library_panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.library_panel2.Location = new System.Drawing.Point(0, 62);
            this.library_panel2.Name = "library_panel2";
            this.library_panel2.Size = new System.Drawing.Size(132, 388);
            this.library_panel2.TabIndex = 3;
            // 
            // librarian_btn
            // 
            this.librarian_btn.BackColor = System.Drawing.Color.White;
            this.librarian_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.librarian_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.librarian_btn.Location = new System.Drawing.Point(12, 157);
            this.librarian_btn.Name = "librarian_btn";
            this.librarian_btn.Size = new System.Drawing.Size(99, 28);
            this.librarian_btn.TabIndex = 2;
            this.librarian_btn.Text = "Librarian";
            this.librarian_btn.UseVisualStyleBackColor = false;
            this.librarian_btn.Click += new System.EventHandler(this.librarian_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.White;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Exit_btn.Location = new System.Drawing.Point(12, 228);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(99, 28);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Book_btn
            // 
            this.Book_btn.BackColor = System.Drawing.Color.White;
            this.Book_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Book_btn.Location = new System.Drawing.Point(12, 92);
            this.Book_btn.Name = "Book_btn";
            this.Book_btn.Size = new System.Drawing.Size(99, 28);
            this.Book_btn.TabIndex = 2;
            this.Book_btn.Text = "Book";
            this.Book_btn.UseVisualStyleBackColor = false;
            this.Book_btn.Click += new System.EventHandler(this.Book_btn_Click);
            // 
            // Student_btn
            // 
            this.Student_btn.BackColor = System.Drawing.Color.White;
            this.Student_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Student_btn.Location = new System.Drawing.Point(12, 33);
            this.Student_btn.Name = "Student_btn";
            this.Student_btn.Size = new System.Drawing.Size(99, 28);
            this.Student_btn.TabIndex = 2;
            this.Student_btn.Text = "Student";
            this.Student_btn.UseVisualStyleBackColor = false;
            this.Student_btn.Click += new System.EventHandler(this.Student_btn_Click);
            // 
            // library_name
            // 
            this.library_name.AutoSize = true;
            this.library_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.library_name.ForeColor = System.Drawing.Color.Tan;
            this.library_name.Location = new System.Drawing.Point(12, 9);
            this.library_name.Name = "library_name";
            this.library_name.Size = new System.Drawing.Size(449, 37);
            this.library_name.TabIndex = 2;
            this.library_name.Text = "Library Management System";
            // 
            // Library_panel1
            // 
            this.Library_panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.Library_panel1.Controls.Add(this.library_name);
            this.Library_panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Library_panel1.Location = new System.Drawing.Point(0, 0);
            this.Library_panel1.Name = "Library_panel1";
            this.Library_panel1.Size = new System.Drawing.Size(1001, 62);
            this.Library_panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(138, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(863, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MAIN_PAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.library_panel2);
            this.Controls.Add(this.Library_panel1);
            this.Name = "MAIN_PAGE";
            this.Text = "main_page";
            this.Load += new System.EventHandler(this.MAIN_PAGE_Load);
            this.library_panel2.ResumeLayout(false);
            this.Library_panel1.ResumeLayout(false);
            this.Library_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel library_panel2;
        private System.Windows.Forms.Button librarian_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Button Book_btn;
        private System.Windows.Forms.Button Student_btn;
        private System.Windows.Forms.Label library_name;
        private System.Windows.Forms.Panel Library_panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}