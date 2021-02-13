using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuttingWire
{
    public partial class Form1 : Form
    {
        List<int> varguCmimet = new List<int>();
        PrejTelin prejTelin = new PrejTelin();
        int numeruesiGjatesive = 1;

        public Form1()
        {
            InitializeComponent();
            btnGjejPrerjenOptimale.Enabled = false;
            btnShtoCmimin.Enabled = false;
        }

        private void btnShtoCmimin_Click(object sender, EventArgs e)
        {
            int cmimi = Int32.Parse(txtCmimi.Text);
            varguCmimet.Add(cmimi);
            if (txtCmimi.Text.Length == 1)
            {
                lblGjatesite.Text = lblGjatesite.Text + numeruesiGjatesive + "  ";
            }
            else if (txtCmimi.Text.Length == 2)
            {
                lblGjatesite.Text = lblGjatesite.Text + "  " + numeruesiGjatesive + "  ";
            } 
            else
            {
                lblGjatesite.Text = lblGjatesite.Text + "   " + numeruesiGjatesive + "  ";
            }
            lblCmimet.Text = lblCmimet.Text + cmimi + "  ";
            numeruesiGjatesive++;
            txtCmimi.Text = "";
        }

        private void btnGjejPrerjenOptimale_Click_1(object sender, EventArgs e)
        {
            int gjatesia = Int32.Parse(txtGjatesia.Text);
            if (varguCmimet.Count != 0)
            {
                btnGjejPrerjenOptimale.Enabled = true;
            }
            int rezultati = prejTelin.prej(varguCmimet.ToArray(), gjatesia);
            if (rezultati == 0)
            {
                lblRezultati.Text = "Ju lutem jepni numër pozitiv më të madh se 0 per gjatësinë";
            }
            else
            {
                lblRezultati.Text = lblRezultati.Text + "përfitimi maksimal " + rezultati;
            }

            //lblRezultati.Text = lblRezultati.Text + "Teli ndahet në " + + " pjesë me gjatësi " + +" për përfitimin maksimal " + rezultati;
        }

        private void lblGjatesia_Click(object sender, EventArgs e)
        {

        }

        private void txtCmimi_TextChanged(object sender, EventArgs e)
        {
            if (txtCmimi.Text == "")
            {
                btnShtoCmimin.Enabled = false;
            }
            else
            {
                btnShtoCmimin.Enabled = true;
            }
        }

        private void txtGjatesia_TextChanged(object sender, EventArgs e)
        {
            if (txtGjatesia.Text == "" && varguCmimet.Count == 0)
            {
                btnGjejPrerjenOptimale.Enabled = false;
            }
            else
            {
                btnGjejPrerjenOptimale.Enabled = true;
            }
        }

        private void txtCmimi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtGjatesia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
