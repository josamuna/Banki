using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Coopec_Lib;
using Coopec_rpt;

namespace GestionCoopec
{
    public partial class SortieFormSortie : Form
    {
        public SortieFormSortie()
        {
            InitializeComponent();
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

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (chk.Checked && rdFc.Checked)
            {
                if (Factory.idAgentConnecte > 0) loadReportTous1(rdFc.Text.ToString());
                else loadReportTous(rdFc.Text.ToString());
            }
            else if (chk.Checked && rdUsd.Checked)
            {
                if (Factory.idAgentConnecte > 0) loadReportTous1(rdUsd.Text.ToString());
                else loadReportTous(rdUsd.Text.ToString());
            }
            else
            {
                if (Factory.idAgentConnecte > 0)
                {
                    try
                    {
                        FicheDepot rpt = new FicheDepot();
                        OleDbCommand cmd = new OleDbCommand(@"SELECT Sortie.date_sortie, Sortie.montant, Client.matricule, Client.nom, Client.postnom, Client.prenom, Compte.designation, Compte.typeCompte FROM Agent 
                        INNER JOIN ((Client INNER JOIN Compte ON Client.id = Compte.id_Client) 
                        INNER JOIN Sortie ON Compte.id = Sortie.id_compte) ON Agent.id = Client.id_agent
                        WHERE (((Sortie.date_sortie)=@date) AND ((Client.id)=@idClient) AND ((Agent.id)=@idAgent))", Factory.Instance.connectDB());

                        IDataParameter paramDate = cmd.CreateParameter();
                        paramDate.ParameterName = "@date";
                        paramDate.Value = Convert.ToDateTime(dtSortie.Text);

                        IDataParameter paramid = cmd.CreateParameter();
                        paramid.ParameterName = "@idClient";
                        paramid.Value = ((Client)cboClient.SelectedItem).Id;

                        IDataParameter paramidAgent = cmd.CreateParameter();
                        paramidAgent.ParameterName = "@idClient";
                        paramidAgent.Value = Factory.idAgentConnecte;

                        cmd.Parameters.Add(paramDate);
                        cmd.Parameters.Add(paramid);
                        cmd.Parameters.Add(paramidAgent);

                        cmd.ExecuteNonQuery();

                        OleDbDataAdapter sa = new OleDbDataAdapter(cmd);

                        DataSet ds = new DataSet();

                        sa.Fill(ds, "doc");
                        rpt.SetDataSource(ds.Tables["doc"]);
                        crvEntree.ReportSource = rpt;
                        crvEntree.Refresh();
                        sa.Dispose();
                        ds.Dispose();
                        cmd.Dispose();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Erreur de l'afichage du rapport", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else loadReport();
            }
        }

        private void loadReport()
        {
            try
            {
                FicheRetrait rpt = new FicheRetrait();
                OleDbCommand cmd = new OleDbCommand(@"SELECT Sortie.date_sortie, Sortie.montant, Client.matricule, Client.nom, Client.postnom, Client.prenom, Compte.designation, Compte.typeCompte
                FROM (Client INNER JOIN Compte ON Client.id=Compte.id_Client) INNER JOIN Sortie ON Compte.id=Sortie.id_compte where Client.id=@id and Sortie.date_sortie=@date", Factory.Instance.connectDB());

                IDataParameter paramid = cmd.CreateParameter();
                paramid.ParameterName = "@id";
                paramid.Value = ((Client)cboClient.SelectedItem).Id;

                IDataParameter paramDate = cmd.CreateParameter();
                paramDate.ParameterName = "@date";
                paramDate.Value = Convert.ToDateTime(dtSortie.Text);

                cmd.Parameters.Add(paramid);
                cmd.Parameters.Add(paramDate);
                cmd.ExecuteNonQuery();

                OleDbDataAdapter sa = new OleDbDataAdapter(cmd);

                DataSet ds = new DataSet();

                sa.Fill(ds, "doc");
                rpt.SetDataSource(ds.Tables["doc"]);
                crvEntree.ReportSource = rpt;
                crvEntree.Refresh();
                sa.Dispose();
                ds.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de l'afichage du rapport", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void loadReportTous(string s)
        {
            try
            {
                FicheRetrait rpt = new FicheRetrait();
                OleDbCommand cmd = new OleDbCommand(@"SELECT Sortie.date_sortie, Sortie.montant, Client.matricule, Client.nom, Client.postnom, Client.prenom, Compte.designation, Compte.typeCompte
                FROM (Client INNER JOIN Compte ON Client.id=Compte.id_Client) INNER JOIN Sortie ON Compte.id=Sortie.id_compte where Compte.typeCompte=@string", Factory.Instance.connectDB());

                OleDbDataAdapter sa = new OleDbDataAdapter(cmd);

                DataSet ds = new DataSet();

                IDataParameter paramString = cmd.CreateParameter();
                paramString.ParameterName = "@string";
                paramString.Value = Convert.ToString (s);

                cmd.Parameters.Add(paramString);
                cmd.ExecuteNonQuery();

                sa.Fill(ds, "doc");
                rpt.SetDataSource(ds.Tables["doc"]);
                crvEntree.ReportSource = rpt;
                crvEntree.Refresh();
                sa.Dispose();
                ds.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de l'afichage du rapport", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void loadReportTous1(string s)
        {
            try
            {
                FicheRetrait rpt = new FicheRetrait();
                OleDbCommand cmd = new OleDbCommand(@"SELECT Sortie.date_sortie, Sortie.montant, Client.matricule, Client.nom, Client.postnom, Client.prenom, Compte.designation, Compte.typeCompte
                FROM (Client INNER JOIN Compte ON Client.id=Compte.id_Client) INNER JOIN Sortie ON Compte.id=Sortie.id_compte where Compte.typeCompte=@string", Factory.Instance.connectDB());

                OleDbDataAdapter sa = new OleDbDataAdapter(cmd);

                DataSet ds = new DataSet();

                IDataParameter paramString = cmd.CreateParameter();
                paramString.ParameterName = "@string";
                paramString.Value = Convert.ToString(s);

                cmd.Parameters.Add(paramString);
                cmd.ExecuteNonQuery();

                sa.Fill(ds, "doc");
                rpt.SetDataSource(ds.Tables["doc"]);
                crvEntree.ReportSource = rpt;
                crvEntree.Refresh();
                sa.Dispose();
                ds.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de l'afichage du rapport", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void SortieFormSortie_Load(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            chk.Enabled = true;
            try
            {
                cboClient.AutoCompleteSource = AutoCompleteSource.ListItems;
                cboClient.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

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
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message, "Erreur de Chargement de la liste déroulante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            if (chk.Checked)
            {
                cboClient.Enabled = false;
                dtSortie.Enabled = false;
                groupBox1.Enabled = true;
            }
            else 
            {
                cboClient.Enabled = true;
                dtSortie.Enabled = true;
                groupBox1.Enabled = false;
            }
        }

        private void bindingNavigator1_DoubleClick(object sender, EventArgs e)
        {
            if (!(this.WindowState == FormWindowState.Maximized))
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void bindingNavigator1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void bindingNavigator1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void bindingNavigator1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
