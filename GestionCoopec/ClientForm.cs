using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Coopec_Lib;

namespace GestionCoopec
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        Client client = new Client();
        PhotoClient photo = new PhotoClient();

        static string matricule = "";
        private bool modiPhoto = false;
        private string pathPhotoLoad = null;

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            try
            {
                client.Id = Factory.Instance.ReNewIdValue(client);
                photo.Id = Factory.Instance.ReNewIdValue(photo);
                matricule = ((Agent)cboAgent.SelectedItem).Matricule + Factory.Instance.generateMatriculeClient(client.Id);
                txtId.Text = matricule;
                initialiseClient();
                btnSaveClient.Enabled = true;
            }
            catch (Exception) { btnSaveClient.Enabled = false; }
        }

        private void initialiseClient()
        {
            txtNomClient.Clear();
            txtPNomClient.Clear();
            txtPrenomClient.Clear();
            txtTelephoneClient.Clear();
            txtNomClient.Focus();
            pbPhotoPersonne.Image = null;
        }

        private void btnRefreshClient_Click(object sender, EventArgs e)
        {
            try
            {
                refreshClient();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'actualisation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void refreshClient()
        {
            if (Factory.idAgentConnecte > 0)
            {
                //On affiche uniquement les clients de l'agent connecte 
                dgvClient.DataSource = Factory.Instance.GetClients(Factory.idAgentConnecte);
                cmbRechercheClient.DataSource = Factory.Instance.GetClients(Factory.idAgentConnecte);
            }
            else
            {
                //On affihe tous
                dgvClient.DataSource = Factory.Instance.GetClients();
                cmbRechercheClient.DataSource = Factory.Instance.GetClients();
            }            
            
            cmbRechercheClient.Text = "";

            if (dgvClient.RowCount > 0)
            {
                btnModifierClient.Enabled = true;
                if(Factory.idAgentConnecte > 0) btnDeleteClient.Enabled = false;
                else btnDeleteClient.Enabled = true;
            }
            else
            {
                btnDeleteClient.Enabled = false;
                btnSaveClient.Enabled = false;
                btnModifierClient.Enabled = false;
            }

            int col = 0;
            foreach (DataGridViewColumn dgvc in dgvClient.Columns)
            {
                dgvClient.AutoResizeColumn(col);
                col++;
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            cmbRechercheClient.Text = "";
            txtId.Text = "";

            //Chargement des tous les Combos
            cboEtatCivClient.Items.Add("CELIBATAIRE");
            cboEtatCivClient.Items.Add("MARIE(E)");
            cboEtatCivClient.Items.Add("VEUF(VE)");
            cboEtatCivClient.SelectedIndex = 0;

            cboSexeClient.Items.Add("M");
            cboSexeClient.Items.Add("F");
            cboSexeClient.SelectedIndex = 0;

            cmbRechercheClient.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbRechercheClient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cboAgent.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboAgent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            try
            {
                if (Factory.idAgentConnecte > 0)
                {
                    //On affiche uniquement les clients de l'agent connecte 
                    cboAgent.DataSource = Factory.Instance.GetAgents(Factory.idAgentConnecte);
                    cmbRechercheClient.DataSource = Factory.Instance.GetClients(Factory.idAgentConnecte);
                    lblFormAgent.Enabled = false;
                }
                else
                {
                    //On affihe tous
                    cboAgent.DataSource = Factory.Instance.GetAgents();
                    cmbRechercheClient.DataSource = Factory.Instance.GetClients();
                    lblFormAgent.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erreur lors du chargement des listes déroulantes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                if (Factory.idAgentConnecte > 0)
                {
                    //On affiche uniquement les clients de l'agent connecte 
                    dgvClient.DataSource = Factory.Instance.GetClients(Factory.idAgentConnecte);
                }
                else
                {
                    //On affihe tous
                    dgvClient.DataSource = Factory.Instance.GetClients();
                }    

                //On rend inisible certaines colonne des DataGridView qui recup les dataproperty
                //correspondant aux noms des accesseurs
                int col1 = 0;
                foreach (DataGridViewColumn dgvc in dgvClient.Columns)
                {
                    if (dgvc.DataPropertyName == "Id") dgvc.Visible = false;
                    else if (dgvc.DataPropertyName == "Id_Agent") dgvc.Visible = false;
                    dgvClient.AutoResizeColumn(col1);
                    col1++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erreur lors de l'affichage", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            btnSaveClient.Enabled = false;
            if (dgvClient.RowCount <= 0)
            {
                btnSaveClient.Enabled = false;
                btnModifierClient.Enabled = false;
                btnDeleteClient.Enabled = false;
            }
        }

        private void cboAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                client.Id_Agent = ((Agent)cboAgent.SelectedItem).Id;
                txtId.Text = ((Agent)cboAgent.SelectedItem).Matricule + Factory.Instance.generateMatriculeClient(client.Id);
            }
            catch (Exception) { }
        }

        private void btnSaveClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {
                    getAttributClient();

                    client.Enregistrer();

                    //Apres l'insertion du client, on insere sa photo
                    photo.Enregistrer();

                    btnSaveClient.Enabled = false;
                    //Permet l'actualisation des valeurs des clients sur le formulair des comptes
                    Factory.EnterForFormClient = true;
                    MessageBox.Show("Enregistrement éffectué", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        refreshClient();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur lors de l'actualisation des Clients", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de l'enregistrement " + ex.Message, "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void getAttributClient()
        {
            client.Nom = txtNomClient.Text;
            client.PostNom = txtPNomClient.Text;
            client.Prenom = txtPrenomClient.Text;
            client.Sexe = cboSexeClient.Text;
            client.EtatCivil = cboEtatCivClient.Text;
            client.Telephone = txtTelephoneClient.Text;
            client.DateNaissance = Convert.ToDateTime(txtDateNaissanceCli.Text);
            client.Matricule = txtId.Text;

            //Photo 
            photo.Id_client = client.Id;
            photo.PhotoPersonne = pathPhotoLoad;
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            try
            {
                if (client != null)
                {
                    getAttributClient();
                    client.Modifier();

                    if (modiPhoto)
                    {
                        //On modifie la photo de l'Agent qui est une personne
                        if (Factory.Instance.GetIdPhotoClient(client.Id) == 0) photo.Id = (Factory.Instance.GetIdPhotoClient(client.Id)) + 1;
                        else photo.Id = Factory.Instance.GetIdPhotoClient(client.Id);
                        photo.Modifier();
                    }
                    //Permet l'actualisation des valeurs des clients sur le formulair des comptes
                    Factory.EnterForFormClient = true;
                    MessageBox.Show("Modification effectuée!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pathPhotoLoad = null;

                    try
                    {
                        refreshClient();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur lors de l'actualisation des Clients", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

                try
                {
                    refreshClient();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur lors de l'actualisation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la modification " + ex.Message, "Modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez - vous vraiment supprimer cet enregistrement ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    client.Supprimer();
                    //Permet l'actualisation des valeurs des clients sur le formulair des comptes
                    Factory.EnterForFormClient = true;
                    MessageBox.Show("Suppression éffectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        refreshClient();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur lors de l'actualisation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    if (dgvClient.RowCount <= 0)
                    {
                        btnSaveClient.Enabled = false;
                        btnModifierClient.Enabled = false;
                        btnDeleteClient.Enabled = false;
                    }

                    initialiseClient();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la suppression " + ex.Message, "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvClient_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvClient.SelectedRows.Count > 0)
                {
                    if (Factory.idAgentConnecte > 0) btnDeleteClient.Enabled = false;
                    else btnDeleteClient.Enabled = true;

                    modiPhoto = false;//initialisation de la variable pour hinibé la modification de la photo
                    client = (Client)dgvClient.SelectedRows[0].DataBoundItem;

                    cboEtatCivClient.Text = client.EtatCivil;
                    cboSexeClient.Text = client.Sexe;

                    //Personne
                    txtNomClient.Text = client.Nom;
                    txtPNomClient.Text = client.PostNom;
                    txtPrenomClient.Text = client.Prenom;
                    cboSexeClient.Text = client.Sexe;
                    cboEtatCivClient.Text = client.EtatCivil;
                    txtTelephoneClient.Text = client.Telephone;
                    txtDateNaissanceCli.Text = Convert.ToString(client.DateNaissance);
                    cboAgent.Text = Factory.Instance.GetAgent(client.Id_Agent).ToString();
                    txtId.Text = client.Matricule;

                    //Chargement de la photo
                    try
                    {
                        pbPhotoPersonne.Image = Bitmap.FromStream(Factory.Instance.GetPhotoPersonneClient(Factory.Instance.GetPhotoClient(client.Id)));
                    }
                    catch (Exception)
                    {
                        pbPhotoPersonne.Image = null;
                    }
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
        }

        private void cmbRechercheClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                client = (Client)cmbRechercheClient.SelectedItem;

                cboEtatCivClient.Text = client.EtatCivil;
                cboSexeClient.Text = client.Sexe;

                //Personne
                txtNomClient.Text = client.Nom;
                txtPNomClient.Text = client.PostNom;
                txtPrenomClient.Text = client.Prenom;
                cboSexeClient.Text = client.Sexe;
                cboEtatCivClient.Text = client.EtatCivil;
                txtTelephoneClient.Text = client.Telephone;
                txtDateNaissanceCli.Text = Convert.ToString(client.DateNaissance);
                cboAgent.Text = Factory.Instance.GetAgent(client.Id_Agent).ToString();
                txtId.Text = client.Matricule;

                //Chargement de la photo
                try
                {
                    pbPhotoPersonne.Image = Bitmap.FromStream(Factory.Instance.GetPhotoPersonneClient(Factory.Instance.GetPhotoClient(client.Id)));
                }
                catch (Exception)
                {
                    pbPhotoPersonne.Image = null;
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblLoadPhoto_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dlgFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    FileInfo file = new FileInfo(dlgFile.FileName);
                    pbPhotoPersonne.Load(dlgFile.FileName);

                    if (Factory.Instance.verifiePhotoExtension(dlgFile.FileName))
                    {
                        pathPhotoLoad = file.FullName;
                        modiPhoto = true; //la variable prand true pour permetre la modification de la photo
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Impossible de charger le fichier", "Photo invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Impossible de charger le fichier, " + ex.Message, "Photo invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void lblFormAgent_Click(object sender, EventArgs e)
        {
            AgentForm agent = new AgentForm();
            agent.ShowDialog();
        }

        private void cboAgent_DropDown(object sender, EventArgs e)
        {
            if (Factory.EnterForFormAgent)
            {
                try
                {
                    cboAgent.DataSource = Factory.Instance.GetAgents();
                }
                catch (Exception) { }
            }
        }
    }
}
