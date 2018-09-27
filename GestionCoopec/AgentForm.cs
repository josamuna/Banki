using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Coopec_Lib;

namespace GestionCoopec
{
    public partial class AgentForm : Form
    {
        public AgentForm()
        {
            InitializeComponent();
        }
        Agent agent = new Agent();
        PhotoAgent photo = new PhotoAgent();
        bool modiPhoto = false;
        string pathPhotoLoad = null;

        private void btnAddAgent_Click(object sender, EventArgs e)
        {
            try
            {
                agent.Id = Factory.Instance.ReNewIdValue(agent);
                photo.Id = Factory.Instance.ReNewIdValue(photo);
                txtId.Text = Factory.Instance.generateMatriculeAgent(agent.Id);
                initialiseAgent();
                btnSaveAgent.Enabled = true;
            }
            catch (Exception) { btnSaveAgent.Enabled = false; }
        }

        private void initialiseAgent()
        {
            txtNomAgent.Clear();
            txtPNomAgent.Clear();
            txtPrenomAgent.Clear();
            txtTelephoneAgent.Clear();
            txtNomAgent.Focus();
            pbPhotoPersonne.Image = null;
        }

        private void btnRefreshAgent_Click(object sender, EventArgs e)
        {
            try
            {
                refreshAgent();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'actualisation des Agents", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void refreshAgent()
        {
            dgvAgent.DataSource = Factory.Instance.GetAgents();
            if (dgvAgent.RowCount > 0)
            {
                btnModifierAgent.Enabled = true;
                btnDeleteAgent.Enabled = true;
            }
            else
            {
                btnDeleteAgent.Enabled = false;
                btnSaveAgent.Enabled = false;
                btnModifierAgent.Enabled = false;
            }
            int col = 0;
            foreach (DataGridViewColumn dgvc in dgvAgent.Columns)
            {
                dgvAgent.AutoResizeColumn(col);
                col++;
            }
        }

        private void btnSaveAgent_Click(object sender, EventArgs e)
        {
            try
            {
            if (agent != null)
            {
                getAttributAgent();

                agent.Enregistrer();
                //Apres l'insertion de l'agent, on insere sa photo
                photo.Enregistrer();

                btnSaveAgent.Enabled = false;
                //Permet l'actualisation des valeurs des agents sur le formulair des clients
                Factory.EnterForFormAgent = true;
                MessageBox.Show("Enregistrement éffectué", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    refreshAgent();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur lors de l'actualisation des Agents", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de l'enregistrement " + ex.Message, "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void getAttributAgent()
        {
            agent.Nom = txtNomAgent.Text;
            agent.PostNom = txtPNomAgent.Text;
            agent.Prenom = txtPrenomAgent.Text;
            agent.Sexe = cboSexeAgent.Text;
            agent.EtatCivil = cboEtatCivAgent.Text;
            agent.Telephone = txtTelephoneAgent.Text;
            agent.DateNaissance = Convert.ToDateTime(txtDateNaissanceAgent.Text);
            agent.Matricule = txtId.Text;

            //Photo 
            photo.Id_agent = agent.Id;
            photo.PhotoPersonne = pathPhotoLoad;
        }

        private void btnModifierAgent_Click(object sender, EventArgs e)
        {
            try
            {
            if (agent != null)
            {
                getAttributAgent();
                agent.Modifier();
                if (modiPhoto)
                {
                    //On modifie la photo de l'Agent qui est une personne
                    if (Factory.Instance.GetIdPhotoAgent(agent.Id) == 0) photo.Id = (Factory.Instance.GetIdPhotoAgent(agent.Id)) + 1;
                    else photo.Id = Factory.Instance.GetIdPhotoAgent(agent.Id);
                    photo.Modifier();
                }
                //Permet l'actualisation des valeurs des agents sur le formulair des clients
                Factory.EnterForFormAgent = true;
                MessageBox.Show("Modification effectuée!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                pathPhotoLoad = null;

                try
                {
                    refreshAgent();
                }
                catch (Exception)
                {
                    MessageBox.Show("Erreur lors de l'actualisation des Agents", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            try
            {
                refreshAgent();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'actualisation des agents", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la modification " + ex.Message, "Modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnDeleteAgent_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez - vous vraiment supprimer cet enregistrement ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    agent.Supprimer();
                    //Permet l'actualisation des valeurs des agents sur le formulair des clients
                    Factory.EnterForFormAgent = true;
                    MessageBox.Show("Suppression éffectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        refreshAgent();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur lors de l'actualisation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    if (dgvAgent.RowCount > 0)
                    {
                        btnModifierAgent.Enabled = true;
                        btnDeleteAgent.Enabled = true;
                    }
                    initialiseAgent();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la suppression " + ex.Message, "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void AgentForm_Load(object sender, EventArgs e)
        {
            cmbRechercheAgent.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbRechercheAgent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbRechercheAgent.Text = "";

            cboEtatCivAgent.Items.Add("CELIBATAIRE");
            cboEtatCivAgent.Items.Add("MARIE(E)");
            cboEtatCivAgent.Items.Add("VEUF(VE)");
            cboEtatCivAgent.SelectedIndex = 0;

            cboSexeAgent.Items.Add("M");
            cboSexeAgent.Items.Add("F");
            cboSexeAgent.SelectedIndex = 0;

            try
            {
                if (Factory.idAgentConnecte > 0)
                {
                    //On affiche uniquement les compte des clients attaches a l'agent connecte
                    dgvAgent.DataSource = Factory.Instance.GetComptes(Factory.idAgentConnecte);
                    cmbRechercheAgent.DataSource = Factory.Instance.GetAgents(Factory.idAgentConnecte);
                }
                else
                {
                    //On affihe tous
                    dgvAgent.DataSource = Factory.Instance.GetAgents();
                    cmbRechercheAgent.DataSource = Factory.Instance.GetAgents();
                }  

                //On rend inisible certaines colonne des DataGridView qui recup les dataproperty
                //correspondant aux noms des accesseurs
                int col1 = 0;
                foreach (DataGridViewColumn dgvc in dgvAgent.Columns)
                {
                    if (dgvc.DataPropertyName == "Id") dgvc.Visible = false;
                    dgvAgent.AutoResizeColumn(col1);
                    col1++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erreur lors de l'affichage", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            btnSaveAgent.Enabled = false;
            if (dgvAgent.RowCount <= 0)
            {
                btnSaveAgent.Enabled = false;
                btnModifierAgent.Enabled = false;
                btnDeleteAgent.Enabled = false;
            }
        }

        private void btnCloseLoadDb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvAgent_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvAgent.SelectedRows.Count > 0)
                {
                    btnDeleteAgent.Enabled = true;
                    modiPhoto = false;//initialisation de la variable pour hinibé la modification de la photo
                    agent = (Agent)dgvAgent.SelectedRows[0].DataBoundItem;

                    cboEtatCivAgent.Text = agent.EtatCivil;
                    cboSexeAgent.Text = agent.Sexe;
                    //Personne
                    txtNomAgent.Text = agent.Nom;
                    txtPNomAgent.Text = agent.PostNom;
                    txtPrenomAgent.Text = agent.Prenom;
                    cboSexeAgent.Text = agent.Sexe;
                    cboEtatCivAgent.Text = agent.EtatCivil;
                    txtTelephoneAgent.Text = agent.Telephone;
                    txtId.Text = agent.Matricule;
                    txtDateNaissanceAgent.Text = Convert.ToString(agent.DateNaissance);

                    //Chargement de la photo
                    try
                    {
                        pbPhotoPersonne.Image = Bitmap.FromStream(Factory.Instance.GetPhotoPersonneAgent(Factory.Instance.GetPhotoAgent(agent.Id)));
                    }
                    catch (Exception)
                    {
                        pbPhotoPersonne.Image = null;
                    }
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
        }

        private void cmbRechercheAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                agent = null;
                agent = (Agent)cmbRechercheAgent.SelectedItem;

                cboEtatCivAgent.Text = agent.EtatCivil;
                cboSexeAgent.Text = agent.Sexe;

                //Personne
                txtNomAgent.Text = agent.Nom;
                txtPNomAgent.Text = agent.PostNom;
                txtPrenomAgent.Text = agent.Prenom;
                cboSexeAgent.Text = agent.Sexe;
                cboEtatCivAgent.Text = agent.EtatCivil;
                txtTelephoneAgent.Text = agent.Telephone;
                txtId.Text = agent.Matricule;
                txtDateNaissanceAgent.Text = Convert.ToString(agent.DateNaissance);

                //Chargement de la photo
                try
                {
                    pbPhotoPersonne.Image = Bitmap.FromStream(Factory.Instance.GetPhotoPersonneAgent(Factory.Instance.GetPhotoAgent(agent.Id)));
                }
                catch (Exception)
                {
                    pbPhotoPersonne.Image = null;
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
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
    }
}
