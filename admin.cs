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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double sum = 0.0;
            double price;
            double qty;
            double cal = 0.0;

            if (checkBox1.Checked)
            {
                String suger = checkBox1.Text;
                String mes = comboBox1.SelectedItem.ToString();
                price = 140.0;
                qty = int.Parse(textBox1.Text);

                if (mes.Equals("Kg"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(suger, price, qty, cal);

                }
                else
                {
                    cal = ((qty / 1000) * price);

                    this.dataGridView1.Rows.Add(suger, price, qty, cal);
                }

            }

            if (checkBox2.Checked)
            {
                String tea = checkBox2.Text;
                String mes1 = comboBox2.SelectedItem.ToString();
                price = 150.0;
                qty = int.Parse(textBox2.Text);
                
                if (mes1.Equals("Kg"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(tea, price, qty, cal);
                }
                else
                {
                    cal = ((qty / 1000) * price);

                    this.dataGridView1.Rows.Add(tea, price, qty, cal);
                }

            }
            if (checkBox3.Checked)
            {
                String flour = checkBox3.Text;
                String mes2 = comboBox3.SelectedItem.ToString();
                price = 260.0;
                qty = int.Parse(textBox3.Text);

                if (mes2.Equals("Kg"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(flour, price, qty, cal);
                }
                else
                {
                    cal = ((qty / 1000 )* price);
                    this.dataGridView1.Rows.Add(flour, price, qty, cal);
                }

            }

            if (checkBox4.Checked)
            {
                String rice = checkBox4.Text;
                String mes3 = comboBox4.SelectedItem.ToString();
                price = 250.0;
                qty = int.Parse(textBox4.Text);

                if (mes3.Equals("Kg"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(rice, price, qty, cal);
                }
                else
                {
                    cal = ((qty / 1000) * price);
                    this.dataGridView1.Rows.Add(rice, price, qty, cal);
                }

            }

            if (checkBox5.Checked)
            {
                String dhall = checkBox5.Text;
                String mes4 = comboBox5.SelectedItem.ToString();
                price = 300.0;
                qty = int.Parse(textBox5.Text);

                if (mes4.Equals("Kg"))
                {
                    cal = (qty * price);
                    this.dataGridView1.Rows.Add(dhall, price, qty, cal);
                }
                else
                {
                    cal = ((qty / 1000) * price);
                    this.dataGridView1.Rows.Add(dhall, price, qty, cal);
                }
            }

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                sum = sum + Convert.ToInt32(dataGridView1.Rows[row].Cells[3].Value);
            }
            label4.Text = sum.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            selectone obj1 = new selectone();
            this.Hide();
            obj1.ShowDialog();
        }
    }
}
