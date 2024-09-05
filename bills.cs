using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace groceryLogin
{
    public partial class bills : Form
    {
        private int nextCustomerID = 1; // Stores the next available customer ID
        public bills()
        {
            InitializeComponent();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Class2 cs = new Class2();
            
            string date = dateTimePicker1.Text;
            
            int customerID = nextCustomerID; // Assign the next available I
            int bill;
            if (!int.TryParse(textBox2.Text, out bill))
            {
                MessageBox.Show("Invalid bill amount. Please enter a valid integer.");
                return;
            }

            int no = cs.add_data(date, customerID, bill);
            if (no > 0)
            {
                MessageBox.Show("Data added successfully. Customer ID: " + customerID);
                nextCustomerID++; // Increment for the next customer

                textBox1.Text = ""; // Clear customer ID field after successful addition
            }
            else
            { MessageBox.Show("Error ! data not added"); }
            DataSet ds = new DataSet();
            ds = cs.Show_data();
        }
        

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            if (comboBox1.SelectedIndex > 0)
            {
                id = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                Class2 cs = new Class2();
                DataSet ds = new DataSet();
                ds = cs.Show_id_data(id);

                DataRow dr = ds.Tables[0].Rows[0];
                dateTimePicker1.Text = dr["date"].ToString();
                textBox1.Text = dr["customerID"].ToString();
                textBox2.Text = dr["bill"].ToString();
            }
        }
        

        private void bills_Load(object sender, EventArgs e)
        {
            
            
                // ... (existing code in Form_Load)

                // Center the panel horizontally and vertically
                panel1.Location = new Point(
                    (this.ClientSize.Width - panel1.Width) / 2,
                    (this.ClientSize.Height - panel1.Height) / 2);
            
            DataSet ds = new DataSet();
            Class2 cs = new Class2();
            ds = cs.Show_data();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "customerID";
            comboBox1.ValueMember = "customerID";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Class2 cs = new Class2();
            DataSet ds = new DataSet();
            ds = cs.Show_data();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Class2 cs = new Class2();
            string date = dateTimePicker1.Text;
            int customerID = int.Parse(textBox1.Text);
            int bill = int.Parse(textBox2.Text);
            int no = cs.update_data(date, customerID, bill);
            if (no > 0)
                MessageBox.Show("updated data succesfully");
            else
                MessageBox.Show("something wrong");
            
            DataSet ds = new DataSet();
            ds = cs.Show_data();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int id;
            if (comboBox1.SelectedIndex > 0)
            {
                id = Convert.ToInt32(comboBox1.SelectedValue.ToString());
                Class2 cs = new Class2();
                DataSet ds = new DataSet();
                ds = cs.Show_id_data(id);

                DataRow dr = ds.Tables[0].Rows[0];
                dateTimePicker1.Text = dr["date"].ToString();
                textBox1.Text = dr["customerID"].ToString();
                textBox2.Text = dr["bill"].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int customerID;
            if (!int.TryParse(textBox1.Text, out customerID))
            {
                MessageBox.Show("Invalid customer ID. Please enter a valid integer.");
                return;
            }

            // Instantiate Class2 and call delete_data method
            Class2 cs = new Class2();
            int no = cs.delete_data(customerID);

            // Check the result and show appropriate message
            if (no > 0)
                MessageBox.Show("Data deleted successfully");
            else
                MessageBox.Show("Error occurred. Data not deleted");
         
            DataSet ds = new DataSet();
            ds = cs.Show_data();
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

            selectone obj1 = new selectone();
            this.Hide();
            obj1.ShowDialog();
        }
    }
}
