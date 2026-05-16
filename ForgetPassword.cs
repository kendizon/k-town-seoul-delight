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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private bool ChangePassword(string email, string newPassword)
        {
            string connectionString = "server=localhost;database=registration_db;uid=root;pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE users SET password = @NewPassword WHERE email = @Email";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    return result > 0;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string newPassword = newPasswordTextBox.Text;
            string confirmPassword = confirmPasswordTextBox.Text;

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (ChangePassword(email, newPassword))
            {
                MessageBox.Show("Password changed successfully!");
                LogIn log = new LogIn();
                log.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Failed to change password. Please check the email and try again.");
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
