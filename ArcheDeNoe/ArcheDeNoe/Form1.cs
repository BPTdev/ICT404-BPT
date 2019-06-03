using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcheDeNoe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void butterrebord_Click(object sender, EventArgs e)
        {
            int compteur=0;
            if (ltbterre.SelectedIndex == -1)
            {
                MessageBox.Show("Il faut séléctionner un élément","Erreur");
            }
            else
            {
                if (ltbterre.Items.Count==-1)
                {
                    butterrebord.Enabled = false;
                }
                string txt;
                txt = ltbterre.SelectedItem.ToString();
                ltbbord.Items.Add(txt);
                ltbterre.Items.Remove(txt);             
            }
        }

        private void butbordterre_Click(object sender, EventArgs e)
        {
            int compteur = 0;
            if (ltbbord.SelectedIndex == -1)
            {
                MessageBox.Show("Il faut séléctionner un élément", "Erreur");
            }
            else
            {
                if (compteur == 0)
                {
                    butbordterre.Enabled = false;
                }
                compteur = compteur - 1;
                string txt;
                txt = ltbbord.SelectedItem.ToString();
                ltbbord.Items.Remove(txt);
                ltbterre.Items.Add(txt);
            }
        }
    }
}
