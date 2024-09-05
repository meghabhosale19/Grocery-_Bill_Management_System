using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace groceryLogin
{
   
    public partial class SignUpForm : Form
    {
        public string Username { get; private set; }
        public string Password { get; private set; }
        public SignUpForm()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private bool ValidateUsername(string username)
        {
            const string pattern = "^[a-zA-Z]+$";
            return Regex.IsMatch(username, pattern);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string confirmPassword = textBox3.Text;
            if (!ValidateUsername(textBox1.Text)) // Use the ValidateUsername function
            {
                MessageBox.Show( "Username must contain only letters (A-Z or a-z).");
                return;
            }
            // Validate the input
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            // Check if password and confirm password match
            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match. Please try again.");
                return;
            }

            Username = username;
            Password = password;
            MessageBox.Show("Account created successfully!");
            
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point(
                   (this.ClientSize.Width - panel1.Width) / 2,
                   (this.ClientSize.Height - panel1.Height) / 2);
        }
    }
}
