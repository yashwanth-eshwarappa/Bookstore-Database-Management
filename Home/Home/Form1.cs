using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            int num = 0;
            string MyConString = "SERVER=localhost;" + "DATABASE=bookstore;" + "UID=yash;" + "PASSWORD=yash1234;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select * from books where title ='" + Bookname.Text.ToString() + "'" + " OR author = '" + Bookname.Text.ToString() + "'" + " OR Isbn ='" + Bookname.Text.ToString() + "'";
            connection.Open();
            Reader = command.ExecuteReader();
            label1.Visible = false;
            while (Reader.Read())
                {
                    string thisrow = "";
                    for (int i = 0; i < Reader.FieldCount; i++)
                    {
                        thisrow += Reader.GetValue(i).ToString();
                        if (i != Reader.FieldCount - 1)
                            thisrow += ", ";
                        else if (i != Reader.FieldCount)
                            thisrow += ".";
                    }
                    listBox1.Items.Add(thisrow);
                    Bookname.Clear();
                     button1.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Book Found!";
                    num = 1;
                }
            if (num==0)
            {
                label1.Visible = true;
                label1.Text = "No Books Found for:"+" \""+ Bookname.Text.ToString()+"\"";
                Bookname.Clear();
            }

            connection.Close();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            login fm = new login();
            fm.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            browse br = new browse();
            br.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button1.Visible = false;
            label1.Visible = false;
        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This will be updated soon \nPlz wait for it :)");
        }
    }
}
