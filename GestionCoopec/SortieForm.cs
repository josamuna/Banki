using System;
using System.Windows.Forms;
using Coopec_Lib;

namespace GestionCoopec
{
    public partial class SortieForm : UserControl
    {
        public SortieForm()
        {
            InitializeComponent();
        }
        Sortie sortie= new Sortie();

        private void closeSortie_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAddSortie_Click(object sender, EventArgs e)
        {
            try
            {
                sortie.Id = Factory.Instance.ReNewIdValue(sortie);
                txtId.Text = sortie.Id.ToString();
                initialiseSortie();
                btnSaveSortie.Enabled = true;
            }
            catch (Exception) { btnSaveSortie.Enabled = false; }
        }

        private void initialiseSortie()
        {
            txtDateSortie.Text = Convert.ToString(DateTime.Today);
 	        txtMontantSortie.Clear();
            txtMontantSortie.Focus(); 
        }

        private void btnRefreshSortie_Click(object sender, EventArgs e)
        {
            try
            {
                refreshSortie();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'actualisation des sorties", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void refreshSortie()
        {
            if (Factory.idAgentConnecte > 0)
            {
                //On affiche uniquement les clients de l'agent connecte 
                cboCompte.DataSource = Factory.Instance.GetComptes(Factory.idAgentConnecte);
                //On affiche les sotie des agent attache au client connecte
                dgvSortie.DataSource = Factory.Instance.GetSorties(Factory.idAgentConnecte);
            }
            else
            {
                //On affiche tous
                cboCompte.DataSource = Factory.Instance.GetComptes();
                dgvSortie.DataSource = Factory.Instance.GetSorties();
            }

            if (dgvSortie.RowCount > 0)
            {
                btnModifierSortie.Enabled = true;
                if (Factory.idAgentConnecte > 0) btnDeleteSortie.Enabled = false;
                else btnDeleteSortie.Enabled = true;
            }
            else
            {
                btnDeleteSortie.Enabled = false;
                btnSaveSortie.Enabled = false;
                btnModifierSortie.Enabled = false;
            }
            int col = 0;
            foreach (DataGridViewColumn dgvc in dgvSortie.Columns)
            {
                dgvSortie.AutoResizeColumn(col);
                col++;
            }
        }

        private void btnSaveSortie_Click(object sender, EventArgs e)
        {
            try
            {
                if (sortie != null)
                {
                    getAttributSortie();
                    Double solde = Factory.Instance.CalculEntree(sortie.Id_compte) - Factory.Instance.CalculSortie(sortie.Id_compte);
                    //Verification que l'on ne retire pas plus que ce qu'on a dans son compte
                    if (solde < sortie.Montant)
                    {
                        MessageBox.Show("la sortie ne peut pas être supérieure au solde", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        //On effectue l'enregistrement et on met a jour le solde du compte
                        sortie.Enregistrer();
                        btnSaveSortie.Enabled = false;
                        MessageBox.Show("Enregistrement éffectué", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        //Mis a jour du solde du compte du client
                        
                        try
                        {
                            refreshSortie();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Erreur lors de l'actualisation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }  
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de l'enregistrement " + ex.Message, "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void getAttributSortie()
        {
            sortie.Id = Convert.ToInt32(txtId.Text);
            sortie.Montant = Convert.ToDouble(txtMontantSortie.Text);
            sortie.Date_sortie = Convert.ToDateTime(txtDateSortie.Text);
        }

        private void btnModifierSortie_Click(object sender, EventArgs e)
        {
            try
            {
                if (sortie != null)
                {
                    getAttributSortie();
                    sortie.Modifier();
                    MessageBox.Show("Modification effectuée!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                try
                {
                    refreshSortie();
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

        private void btnDeleteSortie_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez - vous vraiment supprimer cet enregistrement ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    sortie.Id = Convert.ToInt32(txtId.Text);
                    sortie.Supprimer();
                    MessageBox.Show("Suppression éffectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        refreshSortie();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur lors de l'actualisation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    if (dgvSortie.RowCount <= 0)
                    {
                        btnSaveSortie.Enabled = false;
                        btnModifierSortie.Enabled = false;
                        btnDeleteSortie.Enabled = false;
                    }

                    initialiseSortie();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la suppression " + ex.Message, "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvSortie_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvSortie.SelectedRows.Count > 0)
                {
                    btnModifierSortie.Enabled = true;
                    if (Factory.idAgentConnecte > 0) btnDeleteSortie.Enabled = false;
                    else btnDeleteSortie.Enabled = true;

                    sortie = (Sortie)dgvSortie.SelectedRows[0].DataBoundItem;
                    txtId.Text = sortie.Id.ToString();
                    txtMontantSortie.Text = sortie.Montant.ToString();
                    txtDateSortie.Text = sortie.Date_sortie.ToString();
                    cboCompte.Text = Factory.Instance.GetCompte(sortie.Id_compte).ToString();
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
        }

        private void cboCompteSortie_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                sortie.Id_compte = Convert.ToInt32(((Compte)cboCompte.SelectedItem).Id);
            }
            catch (Exception) { }
        }

        private void SortieForm_Load(object sender, EventArgs e)
        {
            txtId.Enabled = false;
            try
            {
                cboCompte.AutoCompleteSource = AutoCompleteSource.ListItems;
                cboCompte.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                if (Factory.idAgentConnecte > 0)
                {
                    //On affiche uniquement les clients de l'agent connecte 
                    cboCompte.DataSource = Factory.Instance.GetComptes(Factory.idAgentConnecte);
                    //On affiche les sotie des agent attache au client connecte
                    dgvSortie.DataSource = Factory.Instance.GetSorties(Factory.idAgentConnecte);
                }
                else
                {
                    //On affiche tous
                    cboCompte.DataSource = Factory.Instance.GetComptes();
                    dgvSortie.DataSource = Factory.Instance.GetSorties();
                } 

                foreach (DataGridViewColumn dgvc in dgvSortie.Columns)
                {
                    if (dgvc.DataPropertyName == "Id") dgvc.Visible = false;
                    else if (dgvc.DataPropertyName == "Id_compte") dgvc.Visible = false;
                    dgvSortie.AutoResizeColumn(0);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'affichage", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            btnSaveSortie.Enabled = false;

            if (dgvSortie.RowCount <= 0)
            {
                btnSaveSortie.Enabled = false;
                btnModifierSortie.Enabled = false;
                btnDeleteSortie.Enabled = false;
            }
        }
    }
}
