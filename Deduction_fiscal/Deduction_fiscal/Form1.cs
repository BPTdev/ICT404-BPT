using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Deduction_fiscal
{
    public partial class Form1 : Form
    {
        float calcul;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float coefficientfamillial; //par quoi on le divise  
            float revenubrut;//le plus grand nombre
            float rabais;//valeur du rabais en %
            float transport;//valeur deduction transport
            float jeune;//valeur deduction jeune
            //Transforme les valeur Text en numérique
            
            
            //Fin de la transformation


            if (tb1.Text == "" || tb2.Text == "")
            {
                MessageBox.Show("Il est nessesaire de mettre des valeur dans les deux premier champ" ,"Erreur") ;
            } else if(float.Parse(tb1.Text) < 20000 || tb1.Text == "")
            {
                MessageBox.Show("Veuillez entrez une valeur dans revenu brut supérieur à 20'000. ", "Erreur");
            } else if(float.Parse(tb2.Text) <= 0 || tb2.Text == "")
            {
                MessageBox.Show("Veuillez entrez une valeur dans coefficiant famillial supérieur à 0. ", "Erreur");
            }

            else //calcul du premier chanp diviser par le second
            {
                coefficientfamillial = float.Parse(tb2.Text);
                revenubrut = float.Parse(tb1.Text);
                calcul =  revenubrut / coefficientfamillial;
            }
            transport = float.Parse(tcb2.Text);
            jeune = float.Parse(tcb1.Text);
            rabais = float.Parse(tcb3.Text);

            //si le rabais est cocher le faire avant les deux soutraction
            if (cb3.Checked)
            {
                calcul = calcul - calcul * (rabais / 100);
            }
            if (cb2.Checked)
            {
                calcul = calcul - transport;
            }
            if (cb1.Checked)
            {
                calcul = calcul - jeune;
            }
            res.Text = "Revenu imposable: fr." + calcul;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void res_Click(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
