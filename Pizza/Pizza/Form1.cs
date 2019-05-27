using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int table = 0;
        int compteurcb=0;
        string radiobut;
        string checkbox1;
        private void nbtable_TextChanged(object sender, EventArgs e)
        {
            table = int.Parse(nbtable.Text);
        }

        private void butcommander_Click(object sender, EventArgs e)
        {
            rtb1.Text = "";
            //choix de type de pate
            if (xfine.Checked == true)
            {
                radiobut= "extra-fine";
            }
            if (fine.Checked == true)
            {
                radiobut = "fine";
            }
            if (normal.Checked == true)
            {
                radiobut= "normale";
            }
            if (epaisse.Checked == true)
            {
                radiobut = "épaisse";
            }
            //ajout des ingredients
            if (anchois.Checked)
            {
                compteurcb = compteurcb + 1;
                checkbox1 += "anchois ";
                if (compteurcb >= 2)
                {
                    checkbox1 += ", ";
                }
                if (compteurcb == 4 || compteurcb == 0)
                {
                    checkbox1 += ".";
                }
            }
            if (capres.Checked)
            {
                compteurcb = compteurcb + 1;
                checkbox1 += "câpres ";
                if (compteurcb >= 2)
                {
                    checkbox1 += ", ";
                }
                if (compteurcb == 4||compteurcb==0)
                {
                    checkbox1 += ".";
                }
            }
            if (jambon.Checked)
            {
                compteurcb = compteurcb + 1;
                checkbox1 += "jambon";
                if (compteurcb >= 2)
                {
                    checkbox1 += ", ";
                }
                if (compteurcb == 4 || compteurcb == 0)
                {
                    checkbox1 += ".";
                }
            }
            if (crevette.Checked)
            {
                compteurcb = compteurcb + 1;
                checkbox1 += "crevettes";
                if (compteurcb >= 2)
                {
                    checkbox1 += ", ";
                }
                if (compteurcb == 4 || compteurcb == 0)
                {
                    checkbox1 += ".";
                }
            }
            checkbox1=checkbox1.Substring(0,checkbox1.Length-2);
            rtb1.Text = "Pour la " + table + ": pâte "+radiobut+" avec "+checkbox1+"";
            radiobut = "";
            checkbox1 = "";
        }
    }
}
