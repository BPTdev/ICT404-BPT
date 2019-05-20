using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fnetre_roug_bleu
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }
     
        private void button4_Click(object sender, EventArgs e)
        {
            this.Location = new Point(1505, 600);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int test;
            this.Location = new Point(1505,0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Location = new Point(0, 600);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 50; i++)
            {
                this.BackColor = Color.Red;
                this.BackColor = Color.Blue;
            }
        }
    }
}