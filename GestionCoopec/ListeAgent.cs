using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Coopec_Lib;
using Coopec_rpt;

namespace GestionCoopec
{
    public partial class ListeAgent : Form
    {
        public ListeAgent()
        {
            InitializeComponent();
        }
        private int idAgent = 0;
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
        private void btClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ListeAgent_Load(object sender, EventArgs e)
        {
            try
            {
                cboAgent.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cboAgent.AutoCompleteSource = AutoCompleteSource.ListItems;
                cboAgent.DataSource = Factory.Instance.GetAgents();
                cboAgent.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("Erreur lors du chargement des agents", "Chargement des agents", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            chkTous.Checked = true;
        }

        private void bindingNavigator1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
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

        private void cmdOk_Click(object sender, EventArgs e)
        {
            if (chkTous.Checked)
            {
                try
                {
                    rptListeAgent rpt = new rptListeAgent();
                    OleDbCommand cmd = new OleDbCommand(@"SELECT Agent.matricule, Agent.nom, Agent.postnom, Agent.prenom, Agent.sexe, Agent.numeroTel, Client.nom, Client.postnom, Client.prenom, Client.matricule, Client.numeroTel, Client.sexe, PhotoAgent.photo
                    FROM (Agent INNER JOIN Client ON Agent.id=Client.id_agent) INNER JOIN PhotoAgent ON Agent.id=PhotoAgent.id_agent", Factory.Instance.connectDB());
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
            else
            {
                try
                {
                    rptListeAgent rpt = new rptListeAgent();
                    OleDbCommand cmd = new OleDbCommand(@"SELECT Agent.matricule, Agent.nom, Agent.postnom, Agent.prenom, Agent.sexe, Agent.numeroTel, Client.nom, Client.postnom, Client.prenom, Client.matricule, Client.numeroTel, Client.sexe, PhotoAgent.photo
                    FROM (Agent INNER JOIN Client ON Agent.id=Client.id_agent) INNER JOIN PhotoAgent ON Agent.id=PhotoAgent.id_agent WHERE Agent.id=@id", Factory.Instance.connectDB());
                    OleDbDataAdapter sa = new OleDbDataAdapter(cmd);
                    OleDbParameter paramId = cmd.CreateParameter();
                    paramId.ParameterName = "@id";
                    paramId.Value = idAgent;
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
        }

        private void cboAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                idAgent = ((Agent)cboAgent.SelectedItem).Id;
            }
            catch (Exception) { }
        }

        private void chkTous_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTous.Checked) cboAgent.Enabled = false;
            else cboAgent.Enabled = true;
        }
    }
}
