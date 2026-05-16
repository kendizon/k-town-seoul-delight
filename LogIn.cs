using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Week6_Activity_Dizon
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            
        }
        private bool VerifyLogin(string username, string password)
        {
            string connectionString = "server=localhost;database=registration_db;uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM users WHERE username = @Username AND password = @Password";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int result = Convert.ToInt32(command.ExecuteScalar());

                    return result > 0;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MainMenu MM = new MainMenu();
           
            MM.SetTextBoxValue(usernameTextBox.Text);


            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            if (VerifyLogin(username, password))
            {
                MessageBox.Show("Login successful!");

                MM.Show();
                Hide();
              
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }


        }


        private void button2_Click(object sender, EventArgs e)
        {
            usernameTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Signup sn = new Signup();
            sn.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassword fp = new ForgetPassword();
            fp.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Usernametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangeUsername cu = new ChangeUsername();
            cu.Show();
            Hide();
        }
    }
}
