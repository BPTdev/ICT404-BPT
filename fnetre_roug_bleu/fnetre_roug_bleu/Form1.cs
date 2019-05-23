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
        int compteurchangement=0;
        int compteurchangement2 = 0;
        int testsichangement = 0;

        private void button4_Click(object sender, EventArgs e)
        {

            if (!this.Location.Equals(new Point(Screen.GetBounds(this).Height - this.Height, 600)))
            {
                compteurchangement2++;
                this.Location = new Point(Screen.GetBounds(this).Height - this.Height, 600);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Location != new Point(0, 0))
            {
                compteurchangement2++;
                this.Location = new Point(0, 0);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
            if (testsichangement==0 || testsichangement == 2)
            {
                testsichangement = 1;
                compteurchangement++;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
            if (testsichangement == 0 || testsichangement == 1)
            {
                testsichangement = 2;
                compteurchangement++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!this.Location.Equals(new Point(Screen.GetBounds(this).Width - this.Width, 0)))
            {
                compteurchangement2++;
                this.Location = new Point(Screen.GetBounds(this).Width - this.Width, 0);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!this.Location.Equals(new Point(Screen.GetBounds(this).Height - this.Height, 0)))
            {
                compteurchangement2++;
                this.Location = new Point(Screen.GetBounds(this).Height - this.Height, 0);
            }

            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fenètre a changer de couleur " + compteurchangement + " fois et " + compteurchangement2 + " de place", "Compteur");
        }
    }
}