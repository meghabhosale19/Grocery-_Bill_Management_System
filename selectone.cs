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
    public partial class selectone : Form
    {
        public selectone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bills obj = new bills();
            this.Hide();
            obj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            admin obj1 = new admin();
            this.Hide();
            obj1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 obj1 = new Form1();
            this.Hide();
            obj1.ShowDialog();
        }
    }
}
