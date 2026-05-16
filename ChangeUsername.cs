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
    public partial class ChangeUsername : Form
    {
        public ChangeUsername()
        {
            InitializeComponent();
        }
        private bool ValidateUser(string email, string password)
        {
            string connectionString = "server=localhost;database=registration_db;uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM users WHERE email = @Email AND password = @Password";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int userCount = Convert.ToInt32(command.ExecuteScalar());

                    return userCount > 0;
                }
            }
        }
        private bool ChangeUname(string email, string newUsername)
        {
            string connectionString = "server=localhost;database=registration_db;uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE users SET username = @NewUsername WHERE email = @Email";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@NewUsername", newUsername);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            Hide();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string newUsername = newusernametxt.Text;
            string Password = passtxt.Text;

            if (!ValidateUser(email, Password))
            {
                MessageBox.Show("Invalid email or password.");
                return;
            }

            if (ChangeUname(email, newUsername))
            {
                MessageBox.Show("Username changed successfully!");
                LogIn log = new LogIn();
                log.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Failed to change username. Please check the email and try again.");
            }
        }
    }
}

