using System;
using System.Windows.Forms;

namespace GestionCoopec
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        static int t = 0;
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            t = t + 1;
            if (t <= 100)
            {
                pgBar.Value = t;
                label1.Text = t.ToString()+"%";
            }
            else 
            {
                timer1.Enabled = false;
                this.Hide() ;
                MainForm m = new MainForm();
                m.Show();  
            }
            if (t <= 10) 
            {
                label6.Text = "Extraction des liaisons à l'appliction...";
            }
            else if (t <= 20) 
            {
                label6.Text = "chargement des module de traitement des actions parallèles...";
            }
            else if (t <= 30)
            {
                label6.Text = "chargement des modules de gestion de connection...";
            }
            else if (t <= 40)
            {
                label6.Text = "chargement de la base de données...";
            }
            else if (t <= 50)
            {
                label6.Text = "Exctraction des données de la bases de données...";
            }
            else if (t <= 60)
            {
                label6.Text = "chargement des modules de gestion d'affichage...";
            }
            else if (t <= 70)
            {
                label6.Text = "chargement des images...";
            }
            else if (t <= 80)
            {
                label6.Text = "chargement des interfaces...";
            }
            else if (t <= 90)
            {
                label6.Text = "cloture des chargements...";

            }
            else if (t <= 100)
            {
                label6.Text = "Ouverture de l'application...";
            }
        }
    }
}
