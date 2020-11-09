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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text.ToString();
            if (radioButton1.Checked == true)
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=Bookstore;" + "UID=yash;" + "PASSWORD=yash1234;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command1 = connection.CreateCommand();
                connection.Open();
                label3.Visible = false;
                label13.Visible = false;
                if (checkBox1.Checked == true && checkBox2.Checked==true)
                {
                    if (textBox3.Text.ToString() == "" && textBox2.Text.ToString() == "")
                    {
                        label13.Text = "ISBN must not be Empty";
                        label13.Visible = true;
                        label3.Text = "Title cannot be Empty";
                        label3.Visible = true;
                        return;
                    }
                }
                if (checkBox2.Checked == true)
                {
                    if (textBox3.Text.ToString() == "")
                    {
                        label13.Text = "ISBN must not be Empty";
                        label13.Visible = true;
                        return;
                    }
                }
                if (checkBox1.Checked == true)
                {
                    if (textBox2.Text.ToString() == "")
                    {
                        label3.Text = "Empty Title cannot be updated";
                        label3.Visible = true;
                        return;
                    }
                }
                if (checkBox1.Checked == true)
                {
                    command.CommandText = "Update Books set title = '" + textBox2.Text.ToString() + "' WHERE title='" + a + "'";
                    a = textBox2.Text.ToString();
                    command.ExecuteNonQuery();
                }


                if (checkBox2.Checked == true)
                {
                    
                    command.CommandText = "Update Books set ISBN = '" + textBox3.Text.ToString() + "' WHERE title='" + a + "'";
                    command.ExecuteNonQuery();

                }
                if (checkBox3.Checked == true)
                {
                    command.CommandText = "Update Books set Publisher = '" + textBox4.Text.ToString() + "' WHERE title='" + a + "'";
                    command.ExecuteNonQuery();
                }
                if (checkBox4.Checked == true)
                {
                    command.CommandText = "Update Books set Author = '" + textBox5.Text.ToString() + "' WHERE title='" + a + "'";
                    command.ExecuteNonQuery();
                }
                if (checkBox5.Checked == true)
                {
                    command.CommandText = "Update Books set Language = '" + textBox6.Text.ToString() + "' WHERE title='" + a + "'";
                    command.ExecuteNonQuery();
                }
                if (checkBox6.Checked == true)
                {
                    command.CommandText = "Update Books set Price = '" + textBox7.Text.ToString() + "' WHERE title='" + a + "'";
                    command.ExecuteNonQuery();
                }
                if (checkBox7.Checked == true)
                {
                    command.CommandText = "Update Books set Category = '" + textBox8.Text.ToString() + "' WHERE title='" + a + "'";
                    command.ExecuteNonQuery();
                }
                button1.Visible = false;
                textBox1.Clear();
                   label1.Visible = true;
                   label1.Text = "Book Updated!";
           
                connection.Close();
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;

                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                checkBox5.Visible = true;
                checkBox6.Visible = true;
                checkBox7.Visible = true;
                button2.Visible = true;
                label2.Visible = true;
                label12.Visible = false;
                label3.Visible = false;
                label4.Visible = false;

                textBox2.Visible = false;
                label5.Visible = false;
                textBox3.Visible = false;
                label6.Visible = false;
                textBox4.Visible = false;
                label7.Visible = false;
                textBox5.Visible = false;
                label8.Visible = false;
                textBox6.Visible = false;
                label9.Visible = false;
                textBox7.Visible = false;
                label10.Visible = false;
                textBox8.Visible = false;
                label11.Visible = false;




            }

            if (radioButton2.Checked == true)
            {
                string MyConString = "SERVER=localhost;" + "DATABASE=Bookstore;" + "UID=yash;" + "PASSWORD=yash1234;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlCommand command1 = connection.CreateCommand();
                connection.Open();
                if (checkBox1.Checked == true && checkBox2.Checked == true)
                {
                    if (textBox3.Text.ToString() == "" && textBox2.Text.ToString() == "")
                    {
                        label13.Text = "ISBN must not be Empty";
                        label13.Visible = true;
                        label3.Text = "Title cannot be Empty";
                        label3.Visible = true;
                        return;
                    }
                }
                if (checkBox2.Checked == true)
                {
                    if (textBox3.Text.ToString() == "")
                    {
                        label13.Text = "ISBN must not be Empty";
                        label13.Visible = true;
                        return;
                    }
                }
                if (checkBox1.Checked == true)
                {
                    if (textBox2.Text.ToString() == "")
                    {
                        label3.Text = "Empty Title cannot be updated";
                        label3.Visible = true;
                        return;
                    }
                }
                if (checkBox1.Checked == true)
                {
                    command.CommandText = "Update Books set title = '" + textBox2.Text.ToString() + "' WHERE isbn='" + a + "'";
                    a = textBox2.Text.ToString();
                    textBox2.Visible = false;
                    command.ExecuteNonQuery();
                }


                if (checkBox2.Checked == true)
                {
                    command.CommandText = "Update Books set ISBN = '" + textBox3.Text.ToString() + "' WHERE isbn='" + a + "'";
                    textBox3.Visible = false;
                    command.ExecuteNonQuery();

                }
                if (checkBox3.Checked == true)
                {
                    command.CommandText = "Update Books set Publisher = '" + textBox4.Text.ToString() + "' WHERE isbn='" + a + "'";
                    textBox4.Visible = false;
                    command.ExecuteNonQuery();
                }
                if (checkBox4.Checked == true)
                {
                    command.CommandText = "Update Books set Author = '" + textBox5.Text.ToString() + "' WHERE isbn='" + a + "'";
                    textBox5.Visible = false;
                    command.ExecuteNonQuery();
                }
                if (checkBox5.Checked == true)
                {
                    command.CommandText = "Update Books set Language = '" + textBox6.Text.ToString() + "' WHERE isbn='" + a + "'";
                    textBox6.Visible = false;
                    command.ExecuteNonQuery();
                }
                if (checkBox6.Checked == true)
                {
                    command.CommandText = "Update Books set Price = '" + textBox7.Text.ToString() + "' WHERE isbn='" + a + "'";
                    textBox7.Visible = false;
                    command.ExecuteNonQuery();
                }
                if (checkBox7.Checked == true)
                {
                    command.CommandText = "Update Books set Category = '" + textBox8.Text.ToString() + "' WHERE isbn='" + a + "'";
                    textBox8.Visible = false;
                    command.ExecuteNonQuery();
                }
                button1.Visible = false;
                textBox1.Clear();
                label1.Visible = true;
                label1.Text = "Book Updated!";
                connection.Close();

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                checkBox6.Checked = false;
                checkBox7.Checked = false;

                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                checkBox5.Visible = true;
                checkBox6.Visible = true;
                checkBox7.Visible = true;
                button2.Visible = true;
                label2.Visible = true;
                label12.Visible = false;
                label3.Visible = false;

                textBox2.Visible = false;
                label5.Visible = false;
                textBox3.Visible = false;
                label6.Visible = false;
                textBox4.Visible = false;
                label7.Visible = false;
                textBox5.Visible = false;
                label8.Visible = false;
                textBox6.Visible = false;
                label9.Visible = false;
                textBox7.Visible = false;
                label10.Visible = false;
                textBox8.Visible = false;
                label11.Visible = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = 0;
            string MyConString = "SERVER=localhost;" + "DATABASE=Bookstore;" + "UID=yash;" + "PASSWORD=yash1234;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            if (radioButton1.Checked == true)
            {
                command.CommandText = "select * from books where title = '" + textBox1.Text.ToString() + "'";
                connection.Open();
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    num = 1;

                }
                label4.Visible = true;
                label4.Text = "Book found!";
                connection.Close();
            }
            if (radioButton2.Checked == true)
            {
                command.CommandText = "select * from books where isbn = '" + textBox1.Text.ToString() + "'";
                connection.Open();
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    num = 1;

                }
                label4.Visible = true;
                label4.Text = "Book found!";
                connection.Close();
            }
            if (num == 0)
            {
                if (radioButton1.Checked == true)
                {
                    label4.Visible = true;
                    label3.Visible = false;
                    label4.Text = "No Books Found for " + radioButton1.Text + ":" + " \"" + textBox1.Text.ToString() + "\" to Update";
                    textBox1.Clear();
                    return;
                }
                if (radioButton2.Checked == true)
                {
                    label4.Visible = true;
                    label3.Visible = false;
                    label4.Text = "No Books Found for " + radioButton2.Text + ":" + " \"" + textBox1.Text.ToString() + "\" to Update";
                    textBox1.Clear();
                    return;
                }
            }
                if (textBox1.Text != "")
                {
                    if (checkBox1.Checked == true)
                    {
                        textBox2.Visible = true;
                    label5.Visible = true;
                        button1.Visible = true;
                    }
                    if (checkBox2.Checked == true)
                    {
                        textBox3.Visible = true;
                    label6.Visible = true;
                    button1.Visible = true;
                    }
                    if (checkBox3.Checked == true)
                    {
                        textBox4.Visible = true;
                    label7.Visible = true;
                    button1.Visible = true;
                    }
                    if (checkBox4.Checked == true)
                    {
                        textBox5.Visible = true;
                    label8.Visible = true;
                    button1.Visible = true;
                    }
                    if (checkBox5.Checked == true)
                    {
                        textBox6.Visible = true;
                    label9.Visible = true;
                    button1.Visible = true;
                    }
                    if (checkBox6.Checked == true)
                    {
                        textBox7.Visible = true;
                    label10.Visible = true;
                    button1.Visible = true;
                    }
                    if (checkBox7.Checked == true)
                    {
                        textBox8.Visible = true;
                    label11.Visible = true;
                    button1.Visible = true;
                    }
                    if (checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true || checkBox7.Checked == true)
                    {
                        
                        checkBox1.Visible = false;
                        checkBox2.Visible = false;
                        checkBox3.Visible = false;
                        checkBox4.Visible = false;
                        checkBox5.Visible = false;
                        checkBox6.Visible = false;
                        checkBox7.Visible = false;
                    label3.Visible = false;
                    button2.Visible = false;
                    label2.Visible = false;
                    label12.Visible = true;
                   }
                    else
                    {
                        label3.Visible = true;
                        label3.Text = "To Proceed,check the item to be updated.";
                    }
                    

                }
                else
                { label3.Text="Please enter the Input for Title/ISBN to Proceed"; }
                 }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            Admin a = new Admin();
            a.ShowDialog();
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Hide();
            login fm = new login();
            fm.ShowDialog();
            Close();
        }
    }
}
