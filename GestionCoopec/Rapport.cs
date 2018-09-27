using System;
using System.Drawing;
using System.Windows.Forms;
using Coopec_Lib;

namespace GestionCoopec
{
    public partial class Rapport : UserControl
    {
        public Rapport()
        {
            InitializeComponent();
        }

        private void lblSitGen_MouseEnter(object sender, EventArgs e)
        {
            lblSitGen.BackColor = Color.Gainsboro;
            lblSitFin.BackColor = Color.Transparent;
            lblDetCompte.BackColor = Color.Transparent;
            lblListeCli.BackColor = Color.Transparent;
            lblListAg.BackColor = Color.Transparent;
            lblAffichage.Text = "Affiche la situation situation générale des Sorties des fonds dans les comptes des clients";
          
        }

        private void lblDetCompte_MouseEnter(object sender, EventArgs e)
        {
            lblDetCompte.BackColor = Color.Gainsboro;
            lblSitGen.BackColor = Color.Transparent;
            lblSitFin.BackColor = Color.Transparent;
            lblListeCli.BackColor = Color.Transparent;
            lblListAg.BackColor = Color.Transparent;
            lblAffichage.Text = "Affiche toutes les informations concernant les soldes de tous les comptes Clients";
        }

        private void lblSitFin_MouseEnter(object sender, EventArgs e)
        {
            lblSitFin.BackColor = Color.Gainsboro;
            lblDetCompte.BackColor = Color.Transparent;
            lblSitGen.BackColor = Color.Transparent;
            lblListeCli.BackColor = Color.Transparent;
            lblListAg.BackColor = Color.Transparent;
            lblAffichage.Text = "Affiche toutes les informations liées à tous les mouvements d'entrées des comptes cllients";
        }

        private void lblListeCli_MouseEnter(object sender, EventArgs e)
        {
            lblListeCli.BackColor = Color.Gainsboro;
            lblSitFin.BackColor = Color.Transparent;
            lblDetCompte.BackColor = Color.Transparent;
            lblSitGen.BackColor = Color.Transparent;
            lblListAg.BackColor = Color.Transparent;
            lblAffichage.Text = "Affiche la liste de tous les clients ainsi que leurs comptes associés";
        }

        private void lblListAg_MouseEnter(object sender, EventArgs e)
        {
            lblListAg.BackColor = Color.Gainsboro;
            lblListeCli.BackColor = Color.Transparent;
            lblSitFin.BackColor = Color.Transparent;
            lblDetCompte.BackColor = Color.Transparent;
            lblSitGen.BackColor = Color.Transparent;
            lblAffichage.Text = "Affiche la liste de tous les agents";
        }

        private void lblSitGen_Click(object sender, EventArgs e)
        {
            SortieFormSortie sit = new SortieFormSortie();
            sit.ShowDialog();
        }

        private void Rapport_MouseEnter(object sender, EventArgs e)
        {
            lblListeCli.BackColor = Color.Transparent;
            lblListeCli.BackColor = Color.Transparent;
            lblSitFin.BackColor = Color.Transparent;
            lblDetCompte.BackColor = Color.Transparent;
            lblSitGen.BackColor = Color.Transparent;
            lblListAg.BackColor = Color.Transparent;
            lblAffichage.Text = "";
        }

        private void lblDetCompte_Click(object sender, EventArgs e)
        {
            SituationSoldeCptClient s = new SituationSoldeCptClient();
            s.ShowDialog();
        }

        private void lblListAg_Click(object sender, EventArgs e)
        {
            ListeAgent liste = new ListeAgent();
            liste.ShowDialog();
        }

        private void lblListeCli_Click(object sender, EventArgs e)
        {
            ListeClients ls = new ListeClients();
            ls.ShowDialog();
        }

        private void lblSitFin_Click(object sender, EventArgs e)
        {
            EntreeFormSortie entr = new EntreeFormSortie();
            entr.ShowDialog();
        }

        private void btnCloseLoadDb_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Rapport_Load(object sender, EventArgs e)
        {
            if (Factory.okLoginUser == 2)
            {
                lblSitGen.Enabled = true;
                lblDetCompte.Enabled = false;
                lblSitFin.Enabled = true;
                lblListAg.Enabled = false;
                lblListeCli.Enabled = true;
            }
        }
    }
}
