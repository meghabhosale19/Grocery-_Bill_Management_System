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
    public partial class Form1 : Form
    {

        private string signUpUsername;
        private string signUpPassword;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.Location = new Point(
                   (this.ClientSize.Width - panel1.Width) / 2,
                   (this.ClientSize.Height - panel1.Height) / 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text))
            {
                label3.Text = "Please fill in both username and password fields.";
                return;
            }
            if (!ValidateUsername(textBox1.Text)) // Use regular expression or character checking loop
            {
                label3.Text = "Username must contain only letters (A-Z or a-z).";
                return;
            }


            if (textBox1.Text == "Megha" && textBox2.Text == "2103038")
            {
                label3.Text = "Welcome to Bill Maintenance Department, " + textBox1.Text;
                MessageBox.Show("Logged in successfully");
                selectone obj = new selectone();
                this.Hide();
                obj.ShowDialog();

            }
            if (textBox1.Text== signUpUsername && textBox2.Text == signUpPassword)
            {
                label3.Text = "Welcome to Bill Maintenance Department, " + textBox1.Text;
                MessageBox.Show("Logged in successfully");

                selectone obj = new selectone();
                this.Hide();
                obj.ShowDialog();

            }
            else
            {
                label3.Text = "Invalid Username or Password!";
            }
            bool ValidateUsername(string username)
            {
                const string pattern = "^[a-zA-Z]+$";
                return Regex.IsMatch(username, pattern);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            this.Hide();
            signUpForm.ShowDialog();
            signUpUsername = signUpForm.Username;
            signUpPassword = signUpForm.Password;

            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
