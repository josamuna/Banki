using System;
using System.Windows.Forms;
using Coopec_Lib;

namespace GestionCoopec
{
    public partial class CategorieForm : Form
    {
        public CategorieForm()
        {
            InitializeComponent();
        }
        Categorie cat = new Categorie();

        private void btnAddCategorie_Click(object sender, EventArgs e)
        {
            try
            {

                cat.Id  = Factory.Instance.ReNewIdValue(cat);
                txtId.Text = cat.Id.ToString();
                initialiseCategorie();
                btnSaveCategorie.Enabled = true;
            }
            catch (Exception) { btnSaveCategorie.Enabled = false; }
        }

        private void initialiseCategorie()
        {
            txtDesignation.Clear();
            txtDesignation.Focus();
        }

        private void CategorieForm_Load(object sender, EventArgs e)
        {
            try
            {
                dgvCategorie.DataSource = Factory.Instance.GetCategories();

                foreach (DataGridViewColumn dgvc in dgvCategorie.Columns)
                {
                    if (dgvc.DataPropertyName == "Id") dgvc.Visible = false;
                    dgvCategorie.AutoResizeColumn(0);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'affichage", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
         
            btnSaveCategorie.Enabled = false;

            if (dgvCategorie.RowCount <= 0)
            {
                btnSaveCategorie.Enabled = false;
                btnModifierCategorie.Enabled = false;
                btnDeleteCategorie.Enabled = false;
            }
        }

        private void btnRefreshCategorie_Click(object sender, EventArgs e)
        {
            try
            {
                refreshCategorie();
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors de l'actualisation des Categories", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void refreshCategorie()
        {
            dgvCategorie.DataSource = Factory.Instance.GetCategories();

            if (dgvCategorie.RowCount > 0)
            {
                btnSaveCategorie.Enabled = true;
                btnModifierCategorie.Enabled = true;
            }
            else
            {
                btnDeleteCategorie.Enabled = false;
                btnSaveCategorie.Enabled = true;
                btnModifierCategorie.Enabled = true; 
            }
            int col = 0;
            foreach (DataGridViewColumn dgvc in dgvCategorie.Columns)
            {
                dgvCategorie.AutoResizeColumn(col);
                col++;
            }
        }

        private void btnSaveCategorie_Click(object sender, EventArgs e)
        {
            try
            {
                if (cat != null)
                {
                    getAttributCategorie();

                    cat.Enregistrer();
                    btnSaveCategorie.Enabled = false;
                    //Permet l'actualisation des valeurs des categories sur le formulair des comptes
                    Factory.EnterForFormCategorie = true;
                    MessageBox.Show("Enregistrement éffectué", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        refreshCategorie();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur lors de l'actualisation des Categories", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de l'enregistrement " + ex.Message, "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void getAttributCategorie()
        {
            cat.Id = Convert.ToInt32(txtId.Text);
            cat.Designation = txtDesignation.Text;
        }

        private void btnModifierCategorie_Click(object sender, EventArgs e)
        {
            try
            {
                if (cat != null)
                {
                    getAttributCategorie();
                    cat.Modifier();
                    //Permet l'actualisation des valeurs des categories sur le formulair des comptes
                    Factory.EnterForFormCategorie = true;
                    MessageBox.Show("Modification effectuée!", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                try
                {
                    refreshCategorie();
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

        private void btnDeleteCategorie_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez - vous vraiment supprimer cet enregistrement ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    cat.Id = Convert.ToInt32(txtId.Text);
                    cat.Supprimer();
                    //Permet l'actualisation des valeurs des categories sur le formulair des comptes
                    Factory.EnterForFormCategorie = true;
                    MessageBox.Show("Suppression éffectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        refreshCategorie();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Erreur lors de l'actualisation", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    if (dgvCategorie.RowCount <= 0)
                    {
                        btnSaveCategorie.Enabled = false;
                        btnModifierCategorie.Enabled = false;
                        btnDeleteCategorie.Enabled = false;
                    }

                    initialiseCategorie();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la suppression " + ex.Message, "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void dgvCategorie_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategorie.SelectedRows.Count > 0)
                {
                    btnModifierCategorie.Enabled = true;
                    btnDeleteCategorie.Enabled = true;

                    cat = (Categorie)dgvCategorie.SelectedRows[0].DataBoundItem;
                    txtId.Text = cat.Id.ToString();
                    txtDesignation.Text = cat.Designation;
                }
            }
            catch (Exception) { MessageBox.Show("Erreur dans la zone d'affichage", "Erreur d'affichage"); }
        }

        private void closeCategorie_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
