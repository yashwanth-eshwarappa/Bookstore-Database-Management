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
    public partial class browse : Form
    {
        public browse()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 0;

            if (radioButton1.Checked == true)
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=Bookstore;" + "UID=yash;" + "PASSWORD=yash1234;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from books where Author = '" + textBox1.Text.ToString() + "'";
                connection.Open();
                Reader = command.ExecuteReader();
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
                    textBox1.Clear();
                    listBox1.Visible = true;
                    label1.Visible = true;
                    label1.Text = "Books Found!";
                    num = 1;
                }
                connection.Close();

            }

            if (radioButton2.Checked == true)
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=Bookstore;" + "UID=yash;" + "PASSWORD=yash1234;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from books where Language = '" + textBox1.Text.ToString() + "'";
                connection.Open();
                Reader = command.ExecuteReader();
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
                    textBox1.Clear();
                    listBox1.Visible = true;
                    label1.Visible = true;
                    button3.Visible = true;
                    label1.Text = "Books Found!";
                    num = 1;
                }
                connection.Close();

            }
            if (radioButton3.Checked == true)
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=Bookstore;" + "UID=yash;" + "PASSWORD=yash1234;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from books where Publisher = '" + textBox1.Text.ToString() + "'";
                connection.Open();
                Reader = command.ExecuteReader();
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
                    textBox1.Clear();
                    listBox1.Visible = true;
                    label1.Visible = true;
                    button3.Visible = true;
                    label1.Text = "Books Found!";
                    num = 1;
                }
                connection.Close();

            }
            if (radioButton4.Checked == true)
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=Bookstore;" + "UID=yash;" + "PASSWORD=yash1234;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from books where Category = '" + textBox1.Text.ToString() + "'";
                connection.Open();
                Reader = command.ExecuteReader();
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
                    textBox1.Clear();
                    label1.Visible = true;
                    button3.Visible = true;
                    label1.Text = "Books Found!";
                    num = 1;
                }
                connection.Close();

            }
            if (num == 0)
            {
                if (radioButton1.Checked == true)
                {
                    label1.Visible = true;
                    label1.Text = "No Books Found for " + radioButton1.Text + ":" + " \"" + textBox1.Text.ToString() + "\"";
                    textBox1.Clear();
                }
                if (radioButton2.Checked == true)
                {
                    label1.Visible = true;
                    label1.Text = "No Books Found for " + radioButton2.Text + ":" + " \"" + textBox1.Text.ToString() + "\"";
                    textBox1.Clear();
                }
                if (radioButton3.Checked == true)
                {
                    label1.Visible = true;
                    label1.Text = "No Books Found for " + radioButton3.Text + ":" + " \"" + textBox1.Text.ToString() + "\"";
                    textBox1.Clear();
                }
                if (radioButton4.Checked == true)
                {
                    label1.Visible = true;
                    label1.Text = "No Books Found for " + radioButton4.Text + ":" + " \"" + textBox1.Text.ToString() + "\"";
                    textBox1.Clear();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            button3.Visible = false;
            label1.Visible = false;

        }
        public static string v;
        private void button4_Click(object sender, EventArgs e)
        {
             try
               {
                   System.Diagnostics.Process.Start("http://www.amazon.in/s/ref=nb_sb_noss_2?url=search-alias%3Dstripbooks&field-keywords="+ listBox1.SelectedItem);
               }
               catch { }
           }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/" + listBox1.SelectedItem);
        }

    }
    }

