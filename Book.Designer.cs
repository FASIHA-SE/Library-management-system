
namespace Login_page
{
    partial class Book
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
            this.Book_panel = new System.Windows.Forms.Panel();
            this.Book_name = new System.Windows.Forms.Label();
            this.Book_grpbox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.New = new System.Windows.Forms.Button();
            this.Std_delete = new System.Windows.Forms.Button();
            this.Std_update = new System.Windows.Forms.Button();
            this.text6 = new System.Windows.Forms.TextBox();
            this.text5 = new System.Windows.Forms.TextBox();
            this.text4 = new System.Windows.Forms.TextBox();
            this.text3 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.STD_add = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Book_grid = new System.Windows.Forms.DataGridView();
            this.Book_panel.SuspendLayout();
            this.Book_grpbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Book_panel
            // 
            this.Book_panel.BackColor = System.Drawing.Color.SaddleBrown;
            this.Book_panel.Controls.Add(this.Book_name);
            this.Book_panel.Location = new System.Drawing.Point(-4, -1);
            this.Book_panel.Name = "Book_panel";
            this.Book_panel.Size = new System.Drawing.Size(806, 72);
            this.Book_panel.TabIndex = 5;
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
            // Book_grpbox
            // 
            this.Book_grpbox.BackColor = System.Drawing.Color.Sienna;
            this.Book_grpbox.Controls.Add(this.button1);
            this.Book_grpbox.Controls.Add(this.New);
            this.Book_grpbox.Controls.Add(this.Std_delete);
            this.Book_grpbox.Controls.Add(this.Std_update);
            this.Book_grpbox.Controls.Add(this.text6);
            this.Book_grpbox.Controls.Add(this.text5);
            this.Book_grpbox.Controls.Add(this.text4);
            this.Book_grpbox.Controls.Add(this.text3);
            this.Book_grpbox.Controls.Add(this.text2);
            this.Book_grpbox.Controls.Add(this.text1);
            this.Book_grpbox.Controls.Add(this.STD_add);
            this.Book_grpbox.Controls.Add(this.label12);
            this.Book_grpbox.Controls.Add(this.label11);
            this.Book_grpbox.Controls.Add(this.label10);
            this.Book_grpbox.Controls.Add(this.label9);
            this.Book_grpbox.Controls.Add(this.label8);
            this.Book_grpbox.Controls.Add(this.label7);
            this.Book_grpbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book_grpbox.Location = new System.Drawing.Point(0, 92);
            this.Book_grpbox.Name = "Book_grpbox";
            this.Book_grpbox.Size = new System.Drawing.Size(801, 237);
            this.Book_grpbox.TabIndex = 6;
            this.Book_grpbox.TabStop = false;
            this.Book_grpbox.Text = "Books";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "main page";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.Location = new System.Drawing.Point(359, 151);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 10;
            this.New.Text = "New";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // Std_delete
            // 
            this.Std_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Std_delete.Location = new System.Drawing.Point(359, 111);
            this.Std_delete.Name = "Std_delete";
            this.Std_delete.Size = new System.Drawing.Size(75, 23);
            this.Std_delete.TabIndex = 7;
            this.Std_delete.Text = "Delete";
            this.Std_delete.UseVisualStyleBackColor = true;
            this.Std_delete.Click += new System.EventHandler(this.Std_delete_Click);
            // 
            // Std_update
            // 
            this.Std_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Std_update.Location = new System.Drawing.Point(359, 73);
            this.Std_update.Name = "Std_update";
            this.Std_update.Size = new System.Drawing.Size(75, 23);
            this.Std_update.TabIndex = 6;
            this.Std_update.Text = "Update";
            this.Std_update.UseVisualStyleBackColor = true;
            this.Std_update.Click += new System.EventHandler(this.Std_update_Click);
            // 
            // text6
            // 
            this.text6.Location = new System.Drawing.Point(115, 203);
            this.text6.Name = "text6";
            this.text6.Size = new System.Drawing.Size(100, 20);
            this.text6.TabIndex = 5;
            // 
            // text5
            // 
            this.text5.Location = new System.Drawing.Point(115, 177);
            this.text5.Name = "text5";
            this.text5.Size = new System.Drawing.Size(100, 20);
            this.text5.TabIndex = 5;
            // 
            // text4
            // 
            this.text4.Location = new System.Drawing.Point(115, 144);
            this.text4.Name = "text4";
            this.text4.Size = new System.Drawing.Size(100, 20);
            this.text4.TabIndex = 5;
            // 
            // text3
            // 
            this.text3.Location = new System.Drawing.Point(115, 104);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(100, 20);
            this.text3.TabIndex = 5;
            // 
            // text2
            // 
            this.text2.Location = new System.Drawing.Point(115, 67);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(100, 20);
            this.text2.TabIndex = 5;
            // 
            // text1
            // 
            this.text1.Location = new System.Drawing.Point(115, 31);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(100, 20);
            this.text1.TabIndex = 5;
            // 
            // STD_add
            // 
            this.STD_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STD_add.Location = new System.Drawing.Point(359, 29);
            this.STD_add.Name = "STD_add";
            this.STD_add.Size = new System.Drawing.Size(75, 23);
            this.STD_add.TabIndex = 5;
            this.STD_add.Text = "Insert";
            this.STD_add.UseVisualStyleBackColor = true;
            this.STD_add.Click += new System.EventHandler(this.STD_add_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Return Date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Issue Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Authur Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Book Type";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Book Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "BOOK ID";
            // 
            // Book_grid
            // 
            this.Book_grid.BackgroundColor = System.Drawing.Color.SandyBrown;
            this.Book_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Book_grid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Book_grid.Location = new System.Drawing.Point(0, 322);
            this.Book_grid.Name = "Book_grid";
            this.Book_grid.Size = new System.Drawing.Size(800, 128);
            this.Book_grid.TabIndex = 7;
            this.Book_grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Book_grid_CellClick);
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Book_grid);
            this.Controls.Add(this.Book_grpbox);
            this.Controls.Add(this.Book_panel);
            this.Name = "Book";
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            this.Book_panel.ResumeLayout(false);
            this.Book_panel.PerformLayout();
            this.Book_grpbox.ResumeLayout(false);
            this.Book_grpbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Book_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Book_panel;
        private System.Windows.Forms.Label Book_name;
        private System.Windows.Forms.GroupBox Book_grpbox;
        private System.Windows.Forms.Button Std_delete;
        private System.Windows.Forms.Button Std_update;
        private System.Windows.Forms.TextBox text6;
        private System.Windows.Forms.TextBox text5;
        private System.Windows.Forms.TextBox text4;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button STD_add;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Book_grid;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button button1;
    }
}