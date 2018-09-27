using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using Coopec_Lib;
using Coopec_rpt;

namespace GestionCoopec
{
    public partial class SituationSoldeCptClient : Form
    {
        public SituationSoldeCptClient()
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
        private void SituationSoldeCptClient_Load(object sender, EventArgs e)
        {
            try
            {
                SituationDeCompteClient rpt = new SituationDeCompteClient();
                OleDbCommand cmd = new OleDbCommand(@"SELECT rSolde1.nom, Sum(rSolde1.TotalEntree) AS SommeDeTotalEntree, Sum(rSolde1.TotalSortie) AS SommeDeTotalSortie, rSolde1.typeCompte, Sum(rSolde1.solde) AS SommeDesolde, rSolde1.postnom, rSolde1.prenom, rSolde1.sexe, rSolde1.date_entree, rSolde1.Client.id 
                FROM rSolde1 GROUP BY rSolde1.nom, rSolde1.typeCompte, rSolde1.postnom, rSolde1.prenom, rSolde1.sexe, rSolde1.date_entree, rSolde1.Client.id ", Factory.Instance.connectDB());
                               
                OleDbDataAdapter sa = new OleDbDataAdapter(cmd);

                DataSet ds = new DataSet();

                sa.Fill(ds, "doc");
                rpt.SetDataSource(ds.Tables["doc"]);
                crvSituationSoldeCompteClient.ReportSource = rpt;
                crvSituationSoldeCompteClient.Refresh();
                sa.Dispose();
                ds.Dispose();
                cmd.Dispose();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erreur de l'afichage du rapport", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
