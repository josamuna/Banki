using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Coopec_Lib;
using Coopec_rpt;
using System.Data;
using System.Data.OleDb;

namespace GestionCoopec
{
    public partial class EntreeFormSortie : Form
    {
        public EntreeFormSortie()
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

        private void EntreeFormSortie_Load(object sender, EventArgs e)
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
                        OleDbCommand cmd = new OleDbCommand(@"SELECT Entree.date_entree, Entree.montant, Compte.designation, Compte.typeCompte, Client.matricule, Client.nom, Client.postnom, Client.prenom, Agent.id FROM Agent 
                        INNER JOIN ((Client INNER JOIN Compte ON Client.id = Compte.id_Client) 
                        INNER JOIN Entree ON Compte.id = Entree.id_compte) ON Agent.id = Client.id_agent
                        WHERE (((Entree.date_entree)=@date) AND ((Client.id)=@idClient) AND ((Agent.id)=@idAgent))", Factory.Instance.connectDB());

                        IDataParameter paramDate = cmd.CreateParameter();
                        paramDate.ParameterName = "@date";
                        paramDate.Value = Convert.ToDateTime(dtEntree.Text);

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
                }else loadReport();
            }
        }

        private void loadReport()
        {
            try
            {
                FicheDepot rpt = new FicheDepot();
                OleDbCommand cmd = new OleDbCommand(@"SELECT Entree.date_entree, Entree.montant, Compte.designation, Compte.typeCompte, Client.matricule, Client.nom, Client.postnom, Client.prenom
                FROM (Client INNER JOIN Compte ON Client.id=Compte.id_Client) INNER JOIN Entree ON Compte.id=Entree.id_compte where Client.id=@id and Entree.date_entree=@date", Factory.Instance.connectDB());

                IDataParameter paramid = cmd.CreateParameter();
                paramid.ParameterName = "@id";
                paramid.Value = ((Client)cboClient.SelectedItem).Id;
         
                IDataParameter paramDate = cmd.CreateParameter();
                paramDate.ParameterName = "@date";
                paramDate.Value = Convert.ToDateTime(dtEntree.Text);

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

        private void loadReportTous(String s)
        {
            try
            {
                FicheDepot rpt = new FicheDepot();
                OleDbCommand cmd = new OleDbCommand(@"SELECT Entree.date_entree, Entree.montant, Compte.designation, Compte.typeCompte, Client.matricule, Client.nom, Client.postnom, Client.prenom
                FROM (Client INNER JOIN Compte ON Client.id=Compte.id_Client) INNER JOIN Entree ON Compte.id=Entree.id_compte where Compte.typeCompte=@string ", Factory.Instance.connectDB());

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur de l'afichage du rapport", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void loadReportTous1(String s)
        {
            try
            {
                FicheDepot rpt = new FicheDepot();
                OleDbCommand cmd = new OleDbCommand(@"SELECT Sortie.date_sortie, Sortie.montant, Compte.designation, Compte.typeCompte, Client.matricule, Client.nom, Client.postnom, Client.prenom FROM Agent 
                INNER JOIN ((Client INNER JOIN Compte ON Client.id = Compte.id_Client) 
                INNER JOIN Sortie ON Compte.id = Sortie.id_compte) ON Agent.id = Client.id_agent
                WHERE (((Compte.typeCompte)=@string) AND ((Agent.id)=@id)); ", Factory.Instance.connectDB());

                OleDbDataAdapter sa = new OleDbDataAdapter(cmd);

                DataSet ds = new DataSet();

                IDataParameter paramString = cmd.CreateParameter();
                paramString.ParameterName = "@string";
                paramString.Value = Convert.ToString(s);

                IDataParameter paramId = cmd.CreateParameter();
                paramId.ParameterName = "@id";
                paramId.Value = Factory.idAgentConnecte;
                cmd.Parameters.Add(paramString);
                cmd.Parameters.Add(paramId);
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

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            if (chk.Checked)
            {
                cboClient.Enabled = false;
                dtEntree.Enabled = false;
                groupBox1.Enabled = true;
            }
            else
            {
                cboClient.Enabled = true;
                dtEntree.Enabled = true;
                groupBox1.Enabled = false;
            }
        }
    }
}
