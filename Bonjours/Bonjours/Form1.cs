using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bonjours
{
    public partial class FBonjour : Form
    {
        public FBonjour()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bonjour.Text = "Bonjour "+TBox.Text;
            TBox.Text = "";
        }

        private void TBox_TextChanged(object sender, EventArgs e)
        {
            if (TBox.Text != "")
            {
                Button.Enabled = true;
            }else
            {
                Button.Enabled = false;
            }
        }
    }
}
