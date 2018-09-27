using System;
using System.Drawing;
using System.Windows.Forms;
using Coopec_Lib;

namespace GestionCoopec
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            lblTextCPG.Text = "© CPGSoft 2013 - Tous droits reservés";
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private const int WS_EX_STATICEDGE = 0x00020000;
        private const int WS_SIZEBOX = 0x00040000;
        protected override System.Windows.Forms.CreateParams CreateParams
        {
            get
            {
                System.Windows.Forms.CreateParams CP = base.CreateParams;
                CP.ExStyle = WS_EX_STATICEDGE;
                CP.Style = WS_SIZEBOX;
                return CP;
            }
        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {
        }

        private void bindingNavigator2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void bindingNavigator2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void bindingNavigator2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void btnCloseLoadDb_Click(object sender, EventArgs e)
        {
            Application.Exit();
            try
            {
                Factory.Instance.closeConnection();
            }
            catch (Exception) { }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (!(this.WindowState == FormWindowState.Maximized))
            {

                this.WindowState = FormWindowState.Maximized;
                toolStripButton2.Image = global::GestionCoopec.Properties.Resources.UploadAction_2;
                toolStripButton2.ToolTipText = "Minimiser";
            }
            else 
            {
                this.WindowState = FormWindowState.Normal;
                toolStripButton2.Image = global::GestionCoopec.Properties.Resources.UploadAction;
                toolStripButton2.ToolTipText = "Agrandir";
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void bindingNavigator2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (!(this.WindowState == FormWindowState.Maximized))
            {

                this.WindowState = FormWindowState.Maximized;
                toolStripButton2.Image = global::GestionCoopec.Properties.Resources.UploadAction_2;
                toolStripButton2.ToolTipText = "Minimiser";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                toolStripButton2.Image = global::GestionCoopec.Properties.Resources.UploadAction;
                toolStripButton2.ToolTipText = "Agrandir";
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Authentification c = new Authentification();
            c.ShowDialog();
        }

        private void desabledItems()
        {
            mnGestionUser.Enabled = false;
            mnDeconnection.Enabled = false;
            btnAuthentification.Enabled = true;
            mnAuthentification.Enabled = true;

            mnAgent.Enabled = false;
            mnClient.Enabled = false;
            mnCompte.Enabled = false;
            mnRapport.Enabled = false;

            btnCompte.Enabled = false;
            btnAgent.Enabled = false;
            btnClient.Enabled = false;
        }

        private void callActivateItemsAdmin()
        {
            mnGestionUser.Enabled = true;
            mnDeconnection.Enabled = true;
            mnAuthentification.Enabled = false;
            btnAuthentification.Enabled = false;

            mnAgent.Enabled = true;
            mnClient.Enabled = true;
            mnCompte.Enabled = true;
            mnRapport.Enabled = true;

            btnCompte.Enabled = true;
            btnAgent.Enabled = true;
            btnClient.Enabled = true;

            ssmListeAgent.Enabled = true;
            ssmListeClient.Enabled = true;
            ssmSitGenEntre.Enabled = true;
            ssmSitGenEntreeClient.Enabled = true;
            ssmSitGenSortie.Enabled = true;
        }

        private void callActivateItemsAgent()
        {
            mnGestionUser.Enabled = false;
            mnDeconnection.Enabled = true;
            mnAuthentification.Enabled = false;
            btnAuthentification.Enabled = false;

            mnAgent.Enabled = false;
            mnClient.Enabled = true;
            mnCompte.Enabled = false;
            mnRapport.Enabled = true;

            btnCompte.Enabled = true;
            btnAgent.Enabled = false;
            btnClient.Enabled = true;

            ssmListeAgent.Enabled = false;
            ssmListeClient.Enabled = true;
            ssmSitGenEntre.Enabled = true;
            ssmSitGenEntreeClient.Enabled = false;
            ssmSitGenSortie.Enabled = false;
        }

        private void btnCompte_Click(object sender, EventArgs e)
        {
            Comptefrm c = new Comptefrm();
            c.ShowDialog();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            AgentForm a = new AgentForm();
            a.ShowDialog();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            ClientForm c = new ClientForm();
            c.ShowDialog();
        }

        private void listeDesAgentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeAgent lsa = new ListeAgent();
            lsa.ShowDialog();
        }

        private void listeDesClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeClients lsc = new ListeClients();
            lsc.ShowDialog();
        }

        private void mnConnection_Click(object sender, EventArgs e)
        {
            try
            {
                if (Factory.Instance.VerifieDoConnect(Factory.Instance.loadParam()))
                {
                    MessageBox.Show("Connexion réussie", "Connexion à la base des données", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Factory.ValueDb = true;
                    //callActivateItems();
                }
                else MessageBox.Show("Echec de la connexion", "Connexion à la base des données", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Connexion à la base des données", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void selectionnerUneBaseDesDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectionBd c = new ConnectionBd();
            c.ShowDialog();
        }

        private void Fermer_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Voulez - vous vraiment quitter l'application ?", "Quitter l'applcation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }

            try
            {
                Factory.Instance.closeConnection();
            }
            catch (Exception) { }
        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.ShowDialog();
        }

        private void mnAgent_Click(object sender, EventArgs e)
        {
            AgentForm agent = new AgentForm();
            agent.ShowDialog();
        }

        private void mnClient_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.ShowDialog();
        }

        private void mnCompte_Click(object sender, EventArgs e)
        {
            Comptefrm compte = new Comptefrm();
            compte.ShowDialog();
        }

        private void mnGestionUser_Click(object sender, EventArgs e)
        {
            Utilisateur srt = new Utilisateur();
            srt.ShowDialog();
        }

        private void mnAuthentification_Click(object sender, EventArgs e)
        {
            Authentification c = new Authentification();
            c.ShowDialog();
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            if (Factory.okLoginUser == 1)
            {
                callActivateItemsAdmin();
                mnDeconnection.Enabled = true;
            }
            else if (Factory.okLoginUser == 2)
            {
                callActivateItemsAgent();
                mnDeconnection.Enabled = true;
            }
        }

        private void mnDeconnection_Click(object sender, EventArgs e)
        {
            this.desabledItems();
            Factory.okLoginUser = 0;
            try
            {
                Factory.Instance.closeConnection();
            }
            catch (Exception) { }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            //Desactivation au lancemnt
            mnGestionUser.Enabled = false;
            mnDeconnection.Enabled = false;
            btnAuthentification.Enabled = true;
            mnAuthentification.Enabled = true;

            mnAgent.Enabled = false;
            mnClient.Enabled = false;
            mnCompte.Enabled = false;
            mnRapport.Enabled = false;

            btnCompte.Enabled = false;
            btnAgent.Enabled = false;
            btnClient.Enabled = false;
            mnDeconnection.Enabled = false;
        }

        private void ssmSitGenEntreeClient_Click(object sender, EventArgs e)
        {
            SituationSoldeCptClient sit = new SituationSoldeCptClient();
            sit.ShowDialog();
        }

        private void ssmSitGenEntre_Click(object sender, EventArgs e)
        {
            EntreeFormSortie entrS = new EntreeFormSortie();
            entrS.ShowDialog();
        }

        private void ssmSitGenSortie_Click(object sender, EventArgs e)
        {
            SortieFormSortie srt = new SortieFormSortie();
            srt.ShowDialog();
        }
    }
}
