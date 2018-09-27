using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using Coopec_Lib;
using Coopec_rpt;
using System.Drawing;



namespace GestionCoopec
{
    public partial class ListeClients : Form
    {
        public ListeClients()
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

        private void SituationCompteClient_Load(object sender, EventArgs e)
        {
            try
            {
                loadReport();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erreur de l'afichage du rapport", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void loadReport()
        {
            if (Factory.idAgentConnecte > 0)
            {//On affiche les client lies au seul agent connecte
                try
                {
                    rptListeClients rpt = new rptListeClients();
                    OleDbCommand cmd = new OleDbCommand(@"SELECT Client.matricule, Client.nom, Client.postnom, Client.prenom, Client.sexe, Client.etatcivil, Client.numeroTel, Compte.designation, Compte.typeCompte, Compte.id
                    FROM Agent INNER JOIN (Client INNER JOIN Compte ON Client.id = Compte.id_Client) ON Agent.id = Client.id_agent
                    WHERE (((Agent.id)=@id))", Factory.Instance.connectDB());

                    OleDbDataAdapter sa = new OleDbDataAdapter(cmd);
                    OleDbParameter paramId = cmd.CreateParameter();
                    paramId.ParameterName = "@id";
                    paramId.Value = Factory.idAgentConnecte;
                    cmd.Parameters.Add(paramId);

                    DataSet ds = new DataSet();

                    sa.Fill(ds, "doc");
                    rpt.SetDataSource(ds.Tables["doc"]);
                    crvListeClient.ReportSource = rpt;
                    crvListeClient.Refresh();
                    sa.Dispose();
                    ds.Dispose();
                    cmd.Dispose();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Erreur de l'afichage du rapport", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                //On les affiches tous
                try
                {
                    rptListeClients rpt = new rptListeClients();
                    OleDbCommand cmd = new OleDbCommand(@"SELECT Client.matricule, Client.nom, Client.postnom, Client.prenom, Client.sexe, Client.etatcivil, Client.numeroTel, Compte.designation, Compte.typeCompte, Compte.id
                    FROM Client INNER JOIN Compte ON Client.id = Compte.id_Client", Factory.Instance.connectDB());
                    OleDbDataAdapter sa = new OleDbDataAdapter(cmd);

                    DataSet ds = new DataSet();

                    sa.Fill(ds, "doc");
                    rpt.SetDataSource(ds.Tables["doc"]);
                    crvListeClient.ReportSource = rpt;
                    crvListeClient.Refresh();
                    sa.Dispose();
                    ds.Dispose();
                    cmd.Dispose();
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message, "Erreur de l'afichage du rapport", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
