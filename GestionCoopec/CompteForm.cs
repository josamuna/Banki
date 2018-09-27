using System;
using System.Windows.Forms;
using Coopec_Lib;

namespace GestionCoopec
{
    public partial class CompteForm : UserControl
    {
        public CompteForm()
        {
            InitializeComponent();
        }
        Compte compte = new Compte();
        Entree entree = new Entree();
        Sortie sortie = new Sortie();

        private void label6_Click(object sender, EventArgs e)
        {
            CategorieForm c = new CategorieForm();
            c.ShowDialog();
           
        }

        private void CompteForm_Load(object sender, EventArgs e)
        {
            try
            {
                chargementCombo();
            }
            catch (Exception)
            {
                MessageBox.Show("erreur lors du chargement des listes déroulantes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            try
            {
                if (Factory.idAgentConnecte > 0)
                {
                    //On affiche uniquement les compte des clients attaches a l'agent connecte
                    dgvCompte.DataSource = Factory.Instance.GetComptes(Factory.idAgentConnecte);
                }
                else
                {
                    //On affihe tous
                    dgvCompte.DataSource = Factory.Instance.GetComptes();
                } 

                //On rend inisible certaines colonne des DataGridView qui recup les dataproperty
                //correspondant aux noms des accesseurs
                int col1 = 0;
                foreach (DataGridViewColumn dgvc in dgvCompte.Columns)
                {
                    if (dgvc.DataPropertyName == "Id") dgvc.Visible = false;
                    else if (dgvc.DataPropertyName == "Id_Client") dgvc.Visible = false;
                    else if (dgvc.DataPropertyName == "Id_Categorie") dgvc.Visible = false;
                    col1++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("erreur lors de l'affichage", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            btnSaveCompte.Enabled = false;

            if (dgvCompte.RowCount <= 0)
            {
                btnSaveCompte.Enabled = false;
                btnModifierCompte.Enabled = false;
                btnDeleteCompte.Enabled = false;
                rdFC.Checked = true;
                rdDollard.Checked = false;
                lblArgent.Text = "";
            }
        }

        private void chargementCombo()
        {
            cboClient.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboClient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cboCategorie.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboCategorie.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboCategorie.DataSource = Factory.Instance.GetCategories();

            if (Factory.idAgentConnecte > 0)
            {
                //On affiche uniquement les clients de l'agent connecte 
                cboClient.DataSource = Factory.Instance.GetClients(Factory.idAgentConnecte);
            }
            else
            {
                //On affihe tous
                cboClient.DataSource = Factory.Instance.GetClients();
            }                        
        }

        private void btnAddCompte_Click(object sender, EventArgs e)
        {
            try
            {
                compte.Id = Factory.Instance.ReNewIdValue(compte);
                txtId.Text = compte.Id.ToString();
                initialiseCompte();
                btnSaveCompte.Enabled = true;
            }
            catch (Exception) { btnSaveCompte.Enabled = false; }
        }

        private void initialiseCompte()
        {
            txtDesignation.Clear();
            txtDesignation.Focus();
            lblSoldeCompte.Text = "";
        }

        private void btnRefreshCompte_Click(object sender, EventArgs e)
        {
            try
            {
                refreshCompte();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'actualisation des Comptes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void refreshCompte()
        {
            if (Factory.idAgentConnecte > 0)
            {
                //On affiche uniquement les compte des clients attaches a l'agent connecte
                dgvCompte.DataSource = Factory.Instance.GetComptes(Factory.idAgentConnecte);
            }
            else
            {
                //On affihe tous
                dgvCompte.DataSource = Factory.Instance.GetComptes();
            }
            cboCategorie.DataSource = Factory.Instance.GetCategories();

            if (dgvCompte.RowCount > 0)
            {
                btnModifierCompte.Enabled = true;
                if (Factory.idAgentConnecte > 0) btnDeleteCompte.Enabled = false;
                else btnDeleteCompte.Enabled = true;
            }
            else
            {
                btnDeleteCompte.Enabled = false;
                btnSaveCompte.Enabled = false;
                btnModifierCompte.Enabled = false;
            }

            int col = 0;
            foreach (DataGridViewColumn dgvc in dgvCompte.Columns)
            {
                dgvCompte.AutoResizeColumn(col);
                col++;
            }
        }

        private void btnSaveCompte_Click(object sender, EventArgs e)
        {
            try
            {
                if (compte != null)
                {
                    getAttributCompte();

                    compte.Enregistrer();
                    btnSaveCompte.Enabled = false;
                    MessageBox.Show("Enregistrement éffectué", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        refreshCompte();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur lors de l'actualisation des Comptes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de l'enregistrement " + ex.Message, "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void getAttributCompte()
        {
            compte.Id = Convert.ToInt32(txtId.Text);
            compte.Designation = txtDesignation.Text;
        }

        private void cmbCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                compte.Id_Categorie = Convert.ToInt32(((Categorie)cboCategorie.SelectedItem).Id);
            }
            catch (Exception) { }
        }

        private void cboClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                compte.Id_Client = Convert.ToInt32(((Client)cboClient.SelectedItem).Id);
            }
            catch (Exception) { }
        }

        private void btnModifierCompte_Click(object sender, EventArgs e)
        {
            try
            {
                if (compte != null)
                {
                    getAttributCompte();
                    compte.Modifier();
                    MessageBox.Show("Modification effectuée!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                try
                {
                    refreshCompte();
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

        private void btnDeleteCompte_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez - vous vraiment supprimer cet enregistrement ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    compte.Id = Convert.ToInt32(txtId.Text);
                    compte.Supprimer();
                    MessageBox.Show("Suppression éffectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        refreshCompte();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur lors de l'actualisation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    if (dgvCompte.RowCount <= 0)
                    {
                        btnSaveCompte.Enabled = false;
                        btnModifierCompte.Enabled = false;
                        btnDeleteCompte.Enabled = false;
                    }

                    initialiseCompte();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la suppression " + ex.Message, "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            ClientForm client = new ClientForm();
            client.ShowDialog();
        }

        private void dgvCompte_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCompte.SelectedRows.Count > 0)
                {
                    if (Factory.idAgentConnecte > 0) btnDeleteCompte.Enabled = false;
                    else btnDeleteCompte.Enabled = true;
                    btnModifierCompte.Enabled = true;

                    compte = (Compte)dgvCompte.SelectedRows[0].DataBoundItem;
                    txtId.Text = compte.Id.ToString();
                    txtDesignation.Text = compte.Designation;
                    cboClient.Text = Factory.Instance.GetClient(compte.Id_Client).ToString();
                    cboCategorie.Text = Factory.Instance.GetCategorie(compte.Id_Categorie).ToString();
                    entree.Id_compte = compte.Id;
                    sortie.Id_compte = compte.Id;
                    lblSoldeCompte.Text =  Convert.ToString(Factory.Instance.CalculEntree(entree.Id_compte)-Factory.Instance.CalculSortie(sortie.Id_compte)) ;

                    if (compte.TypeCompte.Equals("FC"))
                    {
                        rdFC.Checked = true;
                        lblArgent.Text = "FC";
                    }
                    else if (compte.TypeCompte.Equals("USD"))
                    {
                        rdDollard.Checked = true;
                        lblArgent.Text = "USD";
                    }
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
        }

        private void rdFC_CheckedChanged(object sender, EventArgs e)
        {
            compte.TypeCompte = "FC";
        }

        private void rdDollard_CheckedChanged(object sender, EventArgs e)
        {
            compte.TypeCompte = "USD";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cboClient_DropDown(object sender, EventArgs e)
        {
            if (Factory.EnterForFormClient)
            {
                try
                {
                    cboClient.DataSource = Factory.Instance.GetClients();
                }
                catch (Exception) { }
            }
        }

        private void cboCategorie_DropDown(object sender, EventArgs e)
        {
            if (Factory.EnterForFormCategorie)
            {
                try
                {
                    cboCategorie.DataSource = Factory.Instance.GetCategories();
                }
                catch (Exception) { }
            }
        }
    }
}
