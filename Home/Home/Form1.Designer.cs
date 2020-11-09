namespace Home
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
            this.Browse = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Search = new System.Windows.Forms.Button();
            this.Bookname = new System.Windows.Forms.TextBox();
            this.About = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.Color.Green;
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Browse.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Browse.Location = new System.Drawing.Point(480, 89);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(123, 33);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Green;
            this.Login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Login.Location = new System.Drawing.Point(627, 89);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(128, 33);
            this.Login.TabIndex = 1;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox1.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 14;
            this.listBox1.Location = new System.Drawing.Point(580, 344);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(624, 186);
            this.listBox1.TabIndex = 2;
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.Color.Green;
            this.Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Search.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Search.Location = new System.Drawing.Point(962, 243);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(118, 30);
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Bookname
            // 
            this.Bookname.Font = new System.Drawing.Font("Bookman Old Style", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookname.Location = new System.Drawing.Point(680, 251);
            this.Bookname.Name = "Bookname";
            this.Bookname.Size = new System.Drawing.Size(261, 22);
            this.Bookname.TabIndex = 4;
            // 
            // About
            // 
            this.About.BackColor = System.Drawing.Color.Green;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.About.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.About.Location = new System.Drawing.Point(780, 89);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(126, 33);
            this.About.TabIndex = 5;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = false;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Green;
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("Bookman Old Style", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Exit.Location = new System.Drawing.Point(933, 89);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(129, 33);
            this.Exit.TabIndex = 6;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(791, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1089, 564);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Clear ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.Search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Home.Properties.Resources._000aaaaa1;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(1265, 603);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Bookname);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Browse);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox Bookname;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

