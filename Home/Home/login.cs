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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                if (Username.Text == "" || Password.Text == "")
                {
                    MessageBox.Show("Please provide UserName and Password");
                    return;
                }
                try
                {
                    string MyConString = "SERVER=localhost;" + "DATABASE=Bookstore;" + "UID=yash;" + "PASSWORD=yash1234;";
                    MySqlConnection connection = new MySqlConnection(MyConString);
                    MySqlCommand command = connection.CreateCommand();
                    MySqlDataReader Reader;
                   command.CommandText = "select Password from tbl_Login where Username='"+ Username.Text.ToString() +"'";
                    connection.Open();
                    Reader = command.ExecuteReader();
                    while (Reader.Read())
                    {
                        string thisrow = "";
                        for (int i = 0; i < Reader.FieldCount; i++)
                            thisrow += Reader.GetValue(i).ToString();

                        if (thisrow == Password.Text.ToString())
                        {
                            MessageBox.Show("Login Successful!");
                            this.Hide();
                            Admin fm = new Admin();
                            fm.ShowDialog();
                            Close();
                        }

                        else
                        {
                            MessageBox.Show("Login Failed!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
