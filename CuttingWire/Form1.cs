using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuttingWire
{
    public partial class Form1 : Form
    {
        List<int> varguCmimet = new List<int>();
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

        private void btnGjejPrerjenOptimale_Click(object sender, EventArgs e)
        {
            lblRezultati.Text = "Zgjidhja më e mirë: ";
            int gjatesia = Int32.Parse(txtGjatesia.Text);
            PrejTelin prejTelin = new PrejTelin();

            PrejTelinZgjidhja rezultati = prejTelin.Prej(varguCmimet.ToArray(), gjatesia);
            int profitiMaksimal = rezultati.getMaxProfiti();
            string zgjidhja = rezultati.getZgjidhja();
            int nrNdarjeve = rezultati.getNrNdarjeve();
            int gjatesiaNdarjes = rezultati.getGjatesiaNdarjes();

            lblRezultati.Text = lblRezultati.Text + "Teli ndahet në " + nrNdarjeve + " pjesë me gjatësi "+ gjatesiaNdarjes + " për përfitimin maksimal "+ zgjidhja ;
            lblRezultati.Text = lblRezultati.Text + " = " + profitiMaksimal;
            //lblRezultati.Text = lblRezultati.Text + "Teli ndahet në x pjesë me gjatësi për përfitimin maksimal " + zgj;
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
