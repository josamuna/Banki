using System;
using System.Windows.Forms;
using Coopec_Lib;

namespace GestionCoopec
{
    public partial class Utilisateur : Form
    {
        private UtilisateurClasse utilisateur = new UtilisateurClasse();
        private Agent agent = new Agent();

        public Utilisateur()
        {
            InitializeComponent();
        }

        private void getAttributUtilisateur()
        {
            utilisateur.Id = Convert.ToInt32(lblIdUser.Text);
            utilisateur.NomUser = txtUserName.Text;
            utilisateur.PassWord = txtPwd.Text;
            utilisateur.Categorie = cboCategorie.Text;
            //On verifie que si l'utilisateur est agent qu'on l'a selectione sinon on renvoie une erreur
            if (cboCategorie.SelectedIndex == 1 && cboAgent.Text == "") throw new Exception("Veuillez sélectionner l'agent svp ?");
        }

        private void loadAllCbo()
        {
            cboUser.DataSource = Factory.Instance.GetUtilisateurs();
            if (cboUser.Items.Count > 0) cboUser.SelectedIndex = 0;
            else { }

            txtOldUserName.Text = cboUser.Text;
        }

        private void cmdAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                lblIdUser.Text = Factory.Instance.ReNewIdValue(utilisateur).ToString();
                txtUserName.Clear();
                txtPwd.Clear();
                txtConfirmPwd.Clear();
                txtUserName.Focus();
                cmdSaveUser.Enabled = true;
                lblConfirmPwd.Visible = true;
                txtConfirmPwd.Visible = true;
                doActivateAdmin();
            }
            catch (Exception) { cmdSaveUser.Enabled = false; }
        }

        private void UtilisateurForm_Load(object sender, EventArgs e)
        {
            cboCategorie.Items.Add("Administrateur");
            cboCategorie.Items.Add("Agent");
            cboCategorie.SelectedIndex = 1;

            //Chargement des combo box : Utilisateur
            try
            {
                this.loadAllCbo();
            }
            catch (Exception) { }

            cboAgent.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboAgent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            cboUser.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboUser.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

            try
            {
                cboAgent.DataSource = Factory.Instance.GetAgents();
            }
            catch (Exception) { }

            try
            {
                dgvUser.DataSource = Factory.Instance.GetUtilisateurs();
            }
            catch (Exception) { }

            foreach (DataGridViewColumn dgvc in dgvUser.Columns)
            {
                int col = 0;
                if (dgvc.DataPropertyName == "Id") dgvc.Visible = false;
                if (dgvc.DataPropertyName == "Id_agent") dgvc.Visible = false;
                if (dgvc.DataPropertyName == "PassWord") dgvc.Visible = false;
                dgvUser.AutoResizeColumn(col);
                col++;
            }
            lblConfirmPwd.Visible = false;

            if (dgvUser.RowCount <= 0)
            {
                cmdSaveUser.Enabled = false;
                cmdDeleteUser.Enabled = false;
            }
        }

        private void dgvUser_SelectionChanged(object sender, EventArgs e)
        {
            cmdSaveUser.Enabled = false;
            txtPwd.Clear();
            if (dgvUser.SelectedRows.Count > 0)
            {
                cmdDeleteUser.Enabled = true;

                utilisateur = (UtilisateurClasse)dgvUser.SelectedRows[0].DataBoundItem;
                lblIdUser.Text = utilisateur.Id.ToString();
                if (utilisateur.Categorie.Equals("Administrateur"))
                {
                    cboAgent.Text = "";
                    cboAgent.Enabled = false;
                }
                else
                {
                    cboAgent.Text = Factory.Instance.GetAgentNotNull(utilisateur.Id_agent).ToString();
                    cboAgent.Enabled = true;
                }
                txtUserName.Text = utilisateur.NomUser;
                cboCategorie.Text = utilisateur.Categorie;
                //doActivateAdmin();
            }

            lblConfirmPwd.Visible = false;
            txtConfirmPwd.Visible = false;
        }

        private void doActivateAdmin()
        {
            if (cboCategorie.SelectedIndex == 0)
            {
                cboAgent.Text = "";
                cboAgent.Enabled = false;
                utilisateur.Id_agent = null;
            }
            else cboAgent.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btModifierUserName_Click(object sender, EventArgs e)
        {
            try
            {
                utilisateur.NomUser = cboUser.Text;

                if (!txtOldUserName.Text.Equals(""))
                {
                    if (!txtNewUserName.Text.Equals(""))
                    {
                        Factory.Instance.UpdateUserName(utilisateur.NomUser, txtNewUserName.Text);
                        MessageBox.Show("Modification éffectué", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Chargement des combo box : Utilisateur
                        try
                        {
                            this.loadAllCbo();
                        }
                        catch (Exception) { }

                        try
                        {
                            dgvUser.DataSource = Factory.Instance.GetUtilisateurs();
                        }
                        catch (Exception) { }

                        this.btClearUserName_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Le nouveau nom d'utilisateur que vous avez saisis est invalide", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("L'ancien nom d'utilisateur que vous avez saisis est invalide", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la modification, " + ex.Message, "Modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btClearUserName_Click(object sender, EventArgs e)
        {
            txtOldUserName.Clear();
            txtNewUserName.Clear();
            txtOldUserName.Focus();
            if (cboUser.Items.Count != 0) cboUser.SelectedIndex = 0;
        }

        private void cboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtOldUserName.Text = cboUser.Text;
            }
            catch (Exception) { }
        }

        private void cmdSaveUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (utilisateur != null)
                {
                    if (txtPwd.Text == txtConfirmPwd.Text)
                    {
                        getAttributUtilisateur();
                        if (cboCategorie.SelectedIndex == 0)
                        {
                            //Verification de l'unicite de l'Administrateur
                            if (Factory.Instance.VerifieUniqueAdmin())
                            {
                                //Pas encore d'Admin, alors on l'ajoute
                                utilisateur.Enregistrer();
                                cmdSaveUser.Enabled = false;
                                MessageBox.Show("Enregistrement éffectué", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else throw new Exception("Vous ne pouvez ajouter qu'une seul Administrateur");
                        }
                        else
                        {
                            utilisateur.Enregistrer();
                            cmdSaveUser.Enabled = false;
                            MessageBox.Show("Enregistrement éffectué", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        

                        try
                        {
                            dgvUser.DataSource = Factory.Instance.GetUtilisateurs();
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show(e1.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        //Chargement des combo box : Utilisateur
                        try
                        {
                            this.loadAllCbo();
                        }
                        catch (Exception) { }
                    }
                    else
                    {
                        MessageBox.Show("Les mots de passe que vous avez entrés ne correspondent pas", "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de l'enregistrement, " + ex.Message, "Enregistrement", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Voulez - vous vraiment supprimer cet utilisateur ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    utilisateur.Id = Convert.ToInt32(lblIdUser.Text);
                    utilisateur.Supprimer();
                    MessageBox.Show("Suppression éffectuée", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    try
                    {
                        dgvUser.DataSource = Factory.Instance.GetUtilisateurs();
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    //Chargement des combo box : Utilisateur
                    try
                    {
                        this.loadAllCbo();
                    }
                    catch (Exception) { }

                    if (dgvUser.RowCount <= 0)
                    {
                        cmdSaveUser.Enabled = false;
                        cmdDeleteUser.Enabled = false;
                    }
                    txtUserName.Clear();
                    txtPwd.Clear();
                    txtUserName.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmdUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                utilisateur.Id = Convert.ToInt32(lblIdUser.Text);
                utilisateur.NomUser = txtUserName.Text;

                utilisateur.Modifier();

                MessageBox.Show("Modification éffectuée", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    dgvUser.DataSource = Factory.Instance.GetUtilisateurs();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Echec de la modification, " + ex.Message, "Modification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cboAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                utilisateur.Id_agent = Convert.ToInt32(((Agent)cboAgent.SelectedItem).Id);
            }
            catch (Exception) { }
        }

        private void cboCategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            doActivateAdmin();
        }
    }
}
