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
    public partial class Admin : Form
    {
        int rowsreturned;
        public Admin()
        {
          InitializeComponent();
        }

        private void Retrieve_Click(object sender, EventArgs e)
        {
            int num = 0;
            string MyConString = "SERVER=localhost;" + "DATABASE=bookstore;" + "UID=yash;" + "PASSWORD=yash1234;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select * from books where title ='" + BookName.Text.ToString() + "'";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                    thisrow += Reader.GetValue(i).ToString() + ", ";
                listBox1.Items.Add(thisrow);
                BookName.Clear();
                label3.Visible = true;
                label3.Text = "Book Found!";
                num = 1;
            }
            
            if (num == 0)
            {
                label3.Visible = true;
                label3.Text = "No Books Found for:" + " \"" + BookName.Text.ToString() + "\"";
                BookName.Clear();
            }
            label2.Visible = false;
            label1.Visible = false;
            connection.Close();

        }

        private void Delete_Click(object sender, EventArgs e)
        {

            string MyConString = "SERVER=localhost;" + "DATABASE=bookstore;" + "UID=yash;" + "PASSWORD=yash1234;";
            MySqlConnection connection1 = new MySqlConnection(MyConString);
            MySqlCommand command1 = connection1.CreateCommand();
            connection1.Open();
            command1.CommandText = "delete from books where title='" + BookName.Text.ToString() + "'";
            int rowsdeleted = command1.ExecuteNonQuery();
            label2.Text = rowsdeleted + " book deleted with name " + BookName.Text.ToString();
            BookName.Clear();
            connection1.Close();
            label2.Visible = true;
            label3.Visible = false;
            label1.Visible = false;
        }

        private void Insert_Click(object sender, EventArgs e)
        {

            string MyConString = "SERVER=localhost;" + "DATABASE=bookstore;" + "UID=yash;" + "PASSWORD=yash1234;";
            MySqlConnection connection1 = new MySqlConnection(MyConString);
            MySqlCommand command1 = connection1.CreateCommand();

            command1.CommandText = "insert into books value ('" + title.Text.ToString() + "'," + "'" + isbn.Text.ToString() + " ',' " + publisher.Text.ToString() + " ',' " + author.Text.ToString() + " ', " + price.Text.ToString() + " ,' " + language.Text.ToString() + "','" + genre.Text.ToString() + "')";
            connection1.Open();
            try
            {

                rowsreturned = command1.ExecuteNonQuery();
            }
            catch (Exception ee)
            {
                label1.Text = ee.ToString();
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;


            }


            label1.Text = rowsreturned.ToString() + " row inserted";
            label1.Visible = true;
            title.Clear();
            isbn.Clear();
            publisher.Clear();
            author.Clear();
            price.Clear();
            language.Clear();
            genre.Clear();
            connection1.Close();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            login fm = new login();
            fm.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Update up = new Update();
            up.ShowDialog();
            Close();
        }
    }
}
