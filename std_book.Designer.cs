namespace Login_page
{
    partial class std_book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(std_book));
            this.Book_grid = new System.Windows.Forms.DataGridView();
            this.Book_name = new System.Windows.Forms.Label();
            this.Book_panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.stdBack_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Book_grid)).BeginInit();
            this.Book_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Book_grid
            // 
            this.Book_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Book_grid.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.Book_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Book_grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Book_grid.Location = new System.Drawing.Point(0, 79);
            this.Book_grid.Name = "Book_grid";
            this.Book_grid.Size = new System.Drawing.Size(752, 375);
            this.Book_grid.TabIndex = 10;
            // 
            // Book_name
            // 
            this.Book_name.AutoSize = true;
            this.Book_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_name.ForeColor = System.Drawing.Color.Tan;
            this.Book_name.Location = new System.Drawing.Point(328, 10);
            this.Book_name.Name = "Book_name";
            this.Book_name.Size = new System.Drawing.Size(135, 37);
            this.Book_name.TabIndex = 3;
            this.Book_name.Text = "BOOKS";
            // 
            // Book_panel
            // 
            this.Book_panel.BackColor = System.Drawing.Color.SaddleBrown;
            this.Book_panel.Controls.Add(this.pictureBox1);
            this.Book_panel.Controls.Add(this.Book_name);
            this.Book_panel.Location = new System.Drawing.Point(-3, 0);
            this.Book_panel.Name = "Book_panel";
            this.Book_panel.Size = new System.Drawing.Size(806, 72);
            this.Book_panel.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(233, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(99, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // stdBack_btn
            // 
            this.stdBack_btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdBack_btn.Location = new System.Drawing.Point(292, 377);
            this.stdBack_btn.Name = "stdBack_btn";
            this.stdBack_btn.Size = new System.Drawing.Size(104, 37);
            this.stdBack_btn.TabIndex = 11;
            this.stdBack_btn.Text = "BACK";
            this.stdBack_btn.UseVisualStyleBackColor = true;
            this.stdBack_btn.Click += new System.EventHandler(this.stdBack_btn_Click);
            // 
            // std_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 454);
            this.Controls.Add(this.stdBack_btn);
            this.Controls.Add(this.Book_grid);
            this.Controls.Add(this.Book_panel);
            this.Name = "std_book";
            this.Text = "std_book";
            this.Load += new System.EventHandler(this.std_book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Book_grid)).EndInit();
            this.Book_panel.ResumeLayout(false);
            this.Book_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Book_grid;
        private System.Windows.Forms.Label Book_name;
        private System.Windows.Forms.Panel Book_panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button stdBack_btn;
    }
}