using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Week6_Activity_Dizon
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }
        private void InsertUser(string firstName, string lastName, string username, string password, string phoneNumber, string email)
        {
            string connectionString = "server=localhost;database=registration_db;uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO users (first_name, last_name, username, password, phone_number, email) VALUES (@FirstName, @LastName, @Username, @Password, @PhoneNumber, @Email)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Usernametxt_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;
            string phoneNumber = phoneNumberTextBox.Text;
            string email = emailTextBox.Text;

            if (password == confirmPassword)
            {
                try
                {
                    InsertUser(firstName, lastName, username, password, phoneNumber, email);
                    MessageBox.Show("Registration successful!");
                    LogIn log = new LogIn();
                    log.Show();
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            Hide();
        }
    }
    }
