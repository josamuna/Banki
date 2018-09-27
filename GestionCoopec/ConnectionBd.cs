using System;
using System.IO;
using System.Windows.Forms;
using Coopec_Lib;

namespace GestionCoopec
{
    public partial class ConnectionBd : Form
    {
        public ConnectionBd()
        {
            InitializeComponent();
        }
        private string cheminAccesBD = "";

        private void cmdLoad_Click(object sender, EventArgs e)
        {
            try
            {
                dlgOpen.ShowDialog();
                cheminAccesBD = dlgOpen.FileName;
                if (File.Exists(cheminAccesBD)) txtCheminAcces.Text = cheminAccesBD;
            }
            catch (Exception)
            {
                MessageBox.Show("Echec du chargement du fichier choisi", "Chargement du fichier", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }  
        }

        private void btnCloseLoadDb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtCheminAcces.Text))
                {
                    MessageBox.Show("Veuillez charger un fichier svp !!", "Connexion à la base des données", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCheminAcces.Focus();
                }
                else
                {
                    Factory.ParmaFileValue = Factory.Instance.loadParam();
                    if (!string.IsNullOrEmpty(Factory.ParmaFileValue))
                    {
                        if (Factory.Instance.VerifieDoConnect(Factory.ParmaFileValue))
                        {
                            MessageBox.Show("Connexion réussie", "Connexion à la base des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        }
                        else MessageBox.Show("Echec de la connexion", "Connexion à la base des données sélectionée", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else if (string.IsNullOrEmpty(Factory.ParmaFileValue))
                    {
                        if (Factory.Instance.VerifieDoConnect(cheminAccesBD))
                        {
                            MessageBox.Show("Connexion réussie", "Connexion à la base des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Dispose();
                        } 
                        else MessageBox.Show("Echec de la connexion", "Connexion à la base des données sélectionée", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else MessageBox.Show("Echec de la connexion", "Connexion à la base des données sélectionée", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur inattendue", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
