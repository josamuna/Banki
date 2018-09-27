using System;
using System.Windows.Forms;
using Coopec_Lib;

namespace GestionCoopec
{
    public partial class EntreeForm : UserControl
    {
        public EntreeForm()
        {
            InitializeComponent();
        }

        Entree entree = new Entree();

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        
        private void btnAddEntree_Click(object sender, EventArgs e)
        {
            try
            {

                entree.Id = Factory.Instance.ReNewIdValue(entree);
                txtId.Text = entree.Id.ToString();
                initialiseEntree();
                btnSaveEntree.Enabled = true;
            }
            catch (Exception) { btnSaveEntree.Enabled = false; }
        }

        private void initialiseEntree()
        {
            txtDateEntree.Text = Convert.ToString(DateTime.Today);
            txtMontantEntr.Clear();
            txtMontantEntr.Focus();

        }

        private void cboCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                entree.Id_compte = Convert.ToInt32(((Compte)cboCompte.SelectedItem).Id);
            }
            catch (Exception){ }
        }

        public void refreshEntree()
        {
            if (Factory.idAgentConnecte > 0)
            {
                //On affiche uniquement les clients de l'agent connecte 
                cboCompte.DataSource = Factory.Instance.GetComptes(Factory.idAgentConnecte);
                //On affiche les entrees correspondantes aux clients attaches a l'agent connecte
                dgvEntree.DataSource = Factory.Instance.GetEntrees(Factory.idAgentConnecte);
            }
            else
            {
                //On affiche tous
                cboCompte.DataSource = Factory.Instance.GetComptes();
                dgvEntree.DataSource = Factory.Instance.GetEntrees();
            }

            if (dgvEntree.RowCount > 0)
            {
                btnModifierEntree.Enabled = true;
                if (Factory.idAgentConnecte > 0) btnDeleteEntree.Enabled = false;
                else btnDeleteEntree.Enabled = true;
            }
            else
            {
                btnDeleteEntree.Enabled = false;
                btnSaveEntree.Enabled = false;
                btnModifierEntree.Enabled = false;
            }

            int col = 0;
            foreach (DataGridViewColumn dgvc in dgvEntree.Columns)
            {
                dgvEntree.AutoResizeColumn(col);
                col++;
            }
        }
        private void btnRefreshEntree_Click(object sender, EventArgs e)
        {            
            try
            {
                refreshEntree();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'actualisation des Entrees", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSaveEntree_Click(object sender, EventArgs e)
        {
            try
            {
                if (entree != null)
                {
                    getAttributEntree();
                    
                        entree.Enregistrer();
                        btnSaveEntree.Enabled = false;

                        MessageBox.Show("Enregistrement éffectué", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        try
                        {
                            refreshEntree();
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Erreur lors de l'actualisation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de l'enregistrement " + ex.Message, "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void getAttributEntree()
        {
            entree.Id = Convert.ToInt32(txtId.Text);
            entree.Montant = Convert.ToDouble(txtMontantEntr.Text);
            entree.Date_entree = Convert.ToDateTime(txtDateEntree.Text);
        }

        private void btnModifierEntree_Click(object sender, EventArgs e)
        {
            try
            {
                if (entree != null)
                {
                    getAttributEntree();
                    entree.Modifier();
                    MessageBox.Show("Modification effectuée!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                try
                {
                    refreshEntree();
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

        private void btnDeleteEntree_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez - vous vraiment supprimer cet enregistrement ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    entree.Id = Convert.ToInt32(txtId.Text);
                    entree.Supprimer();
                    MessageBox.Show("Suppression éffectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        refreshEntree();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur lors de l'actualisation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    if (dgvEntree.RowCount <= 0)
                    {
                        btnSaveEntree.Enabled = false;
                        btnModifierEntree.Enabled = false;
                        btnDeleteEntree.Enabled = false;
                    }

                    initialiseEntree();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la suppression " + ex.Message, "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void dgvEntree_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvEntree.SelectedRows.Count > 0)
                {
                    btnModifierEntree.Enabled = true;
                    if (Factory.idAgentConnecte > 0) btnDeleteEntree.Enabled = false;
                    else btnDeleteEntree.Enabled = true;

                    entree = (Entree)dgvEntree.SelectedRows[0].DataBoundItem;
                    txtId.Text = entree.Id.ToString();
                    txtDateEntree.Text = entree.Date_entree.ToString();
                    txtMontantEntr.Text = entree.Montant.ToString();
                    cboCompte.Text = Factory.Instance.GetCompte(entree.Id_compte).ToString();
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
        }

        private void EntreeForm_Load(object sender, EventArgs e)
        {
            try
            {               
                cboCompte.AutoCompleteSource = AutoCompleteSource.ListItems;
                cboCompte.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

                if (Factory.idAgentConnecte > 0)
                {
                    //On affiche uniquement les clients de l'agent connecte 
                    cboCompte.DataSource = Factory.Instance.GetComptes(Factory.idAgentConnecte);
                    //On affiche les entrees correspondantes aux clients attaches a l'agent connecte
                    dgvEntree.DataSource = Factory.Instance.GetEntrees(Factory.idAgentConnecte);
                }
                else
                {
                    //On affiche tous
                    cboCompte.DataSource = Factory.Instance.GetComptes();
                    dgvEntree.DataSource = Factory.Instance.GetEntrees();
                } 
                
                foreach (DataGridViewColumn dgvc in dgvEntree.Columns)
                {
                    if (dgvc.DataPropertyName == "Id") dgvc.Visible = false;
                    else if (dgvc.DataPropertyName == "Id_compte") dgvc.Visible = false;
                    dgvEntree.AutoResizeColumn(0);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'affichage", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            btnSaveEntree.Enabled = false;

            if (dgvEntree.RowCount <= 0)
            {
                btnSaveEntree.Enabled = false;
                btnModifierEntree.Enabled = false;
                btnDeleteEntree.Enabled = false;
            }
        }
    }
}
