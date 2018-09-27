using System;
using System.Windows.Forms;
using Coopec_Lib;

namespace GestionCoopec
{
    public partial class Authentification : Form
    {
        public Authentification()
        {
            InitializeComponent();
        }

        private void cmdAnnuler_Click(object sender, EventArgs e)
        {
            
            this.Dispose();
        }

        private void cmdBd_Click(object sender, EventArgs e)
        {
            ConnectionBd c = new ConnectionBd();
            c.ShowDialog();
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(Factory.ParmaFileValue))
                {
                    //On doit absolument charger la BD car il n'ya aucun param
                    MessageBox.Show("Veuillez sélectionner la Base des données", "Selection de la Base des données recquise", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //On se s'auto connecte a la BD dans le fichier des param et on essaye de s'authentifier
                    Factory.Instance.VerifieDoConnect(Factory.ParmaFileValue);
                    if (Factory.Instance.verifieLoginUser(txtUserName.Text, txtPassword.Text))
                    {
                        MessageBox.Show("Authentification de l'utilisateur réussie", "Authentification de l'utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else MessageBox.Show("Echec d'authentification de l'utilisateur", "Authentification de l'utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec d'authentification de l'utilisateur\n" + ex.Message, "Authentification de l'utilisateur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Authentification_Load(object sender, EventArgs e)
        {
            try
            {
                Factory.ParmaFileValue = Factory.Instance.loadParam();
                if (string.IsNullOrEmpty(Factory.ParmaFileValue)) cmdBd.Enabled = true;
                else cmdBd.Enabled = false;
            }
            catch (Exception) { }
            txtUserName.Focus();
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            txtPassword.Clear();
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            txtUserName.Clear();
        }
    }
}
