namespace Home
{
    partial class Admin
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Retrieve = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.BookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.isbn = new System.Windows.Forms.TextBox();
            this.publisher = new System.Windows.Forms.TextBox();
            this.language = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.genre = new System.Windows.Forms.TextBox();
            this.Logout = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.DarkRed;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(-1, 388);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(646, 96);
            this.listBox1.TabIndex = 0;
            // 
            // Insert
            // 
            this.Insert.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.Insert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Insert.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insert.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Insert.Location = new System.Drawing.Point(655, 303);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(101, 23);
            this.Insert.TabIndex = 1;
            this.Insert.Text = "Insert";
            this.Insert.UseVisualStyleBackColor = false;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(678, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // Retrieve
            // 
            this.Retrieve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Retrieve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Retrieve.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Retrieve.Location = new System.Drawing.Point(69, 303);
            this.Retrieve.Name = "Retrieve";
            this.Retrieve.Size = new System.Drawing.Size(160, 23);
            this.Retrieve.TabIndex = 3;
            this.Retrieve.Text = "Retrieve";
            this.Retrieve.UseVisualStyleBackColor = false;
            this.Retrieve.Click += new System.EventHandler(this.Retrieve_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.DarkRed;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Delete.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete.Location = new System.Drawing.Point(283, 303);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(108, 23);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // BookName
            // 
            this.BookName.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName.Location = new System.Drawing.Point(42, 256);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(216, 20);
            this.BookName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(290, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(706, 41);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(100, 20);
            this.title.TabIndex = 7;
            // 
            // author
            // 
            this.author.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.author.Location = new System.Drawing.Point(706, 77);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(100, 20);
            this.author.TabIndex = 8;
            // 
            // isbn
            // 
            this.isbn.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn.Location = new System.Drawing.Point(706, 112);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(100, 20);
            this.isbn.TabIndex = 9;
            // 
            // publisher
            // 
            this.publisher.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publisher.Location = new System.Drawing.Point(706, 148);
            this.publisher.Name = "publisher";
            this.publisher.Size = new System.Drawing.Size(100, 20);
            this.publisher.TabIndex = 10;
            // 
            // language
            // 
            this.language.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.language.Location = new System.Drawing.Point(706, 184);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(100, 20);
            this.language.TabIndex = 11;
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(706, 219);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(100, 20);
            this.price.TabIndex = 12;
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.Location = new System.Drawing.Point(706, 256);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(100, 20);
            this.genre.TabIndex = 13;
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Logout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Logout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Logout.Font = new System.Drawing.Font("Bookman Old Style", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logout.Location = new System.Drawing.Point(978, 77);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(87, 32);
            this.Logout.TabIndex = 14;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(69, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(978, 237);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(950, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "To update Book info";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Home.Properties.Resources.sdvvvvvvvvvv;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.Logout;
            this.ClientSize = new System.Drawing.Size(1250, 583);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.price);
            this.Controls.Add(this.language);
            this.Controls.Add(this.publisher);
            this.Controls.Add(this.isbn);
            this.Controls.Add(this.author);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Retrieve);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.listBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Retrieve;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.TextBox BookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.TextBox publisher;
        private System.Windows.Forms.TextBox language;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox genre;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}