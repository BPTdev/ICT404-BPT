using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traban_pas_graphique
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float caca = 0;
        
        private void cmdquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdreset_Click(object sender, EventArgs e)
        {
            tbxprix.Text = "";
            rbu14.Checked = true;
            rbu16.Checked = false;
            cbxtaxe.Checked = false;
            tbxprixfin.Text = "";
        }

        private void tbxprix_TextChanged(object sender, EventArgs e)
        {
            
            if (float.TryParse(tbxprix.Text,out caca))
            {
                if (float.Parse(tbxprix.Text) <= 9999)
                {
                    MessageBox.Show("Donnée incorecte.", "Erreur");
                }
                }
            else 
            {
                MessageBox.Show("Donnée incorecte.", "Erreur");
            }
        }
    }
}
