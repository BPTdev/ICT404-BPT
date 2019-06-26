using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_comme_g
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if (cboArticle.Text == "")
            {
                MessageBox.Show("Sélectionnez un article", "Erreur");
            }
            if (cboQuantite.Text == "")
            {
                MessageBox.Show("Introduisez une quantité", "Erreur");
            }
            lstCourses.Items.Add(string.Format("{0}:{1}", cboQuantite.Text, cboArticle.Text));
            cboQuantite.Text = "";
            cboArticle.Text = cboArticle.Text.Remove(0);
        }

        private void cmdImprimer_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cette fonction n'est pas encore disponible", "Erreur");

        }

        private void cmdSuppr_Click(object sender, EventArgs e)
        {
            if (lstCourses.Text == "")
            {
                MessageBox.Show("Veuillez sélectionnez un élement à suprimmer", "Erreur");
            }
            lstCourses.Items.Remove(lstCourses.Text);
        }
    }
}
