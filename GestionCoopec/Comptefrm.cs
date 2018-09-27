using System;
using System.Drawing;
using System.Windows.Forms;
using Coopec_Lib;

namespace GestionCoopec
{
    public partial class Comptefrm : Form
    {
        public Comptefrm()
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
                //CP.Style = WS_SIZEBOX;
                return CP;
            }
        }

        private void lblCompte_MouseEnter(object sender, EventArgs e)
        {
            lblCompte.BackColor = Color.Gainsboro;
            lblEntree.BackColor = Color.Empty;
            lblSortie.BackColor = Color.Empty;
            lblRapport.BackColor = Color.Empty;
        }

        private void lblEntree_MouseEnter(object sender, EventArgs e)
        {
            lblCompte.BackColor = Color.Empty;
            lblEntree.BackColor = Color.Gainsboro;
            lblSortie.BackColor = Color.Empty;
            lblRapport.BackColor = Color.Empty;
        }

        private void lblSortie_MouseEnter(object sender, EventArgs e)
        {
            lblCompte.BackColor = Color.Empty;
            lblEntree.BackColor = Color.Empty;
            lblSortie.BackColor = Color.Gainsboro;
            lblRapport.BackColor = Color.Empty;
        }

        private void lblRapport_MouseEnter(object sender, EventArgs e)
        {
            lblCompte.BackColor = Color.Empty;
            lblEntree.BackColor = Color.Empty;
            lblSortie.BackColor = Color.Empty;
            lblRapport.BackColor = Color.Gainsboro;
        }

        private void splitContainer1_Panel1_MouseEnter(object sender, EventArgs e)
        {
            lblCompte.BackColor = Color.Empty;
            lblEntree.BackColor = Color.Empty;
            lblSortie.BackColor = Color.Empty;
            lblRapport.BackColor = Color.Empty;
        }

        private void btnCloseLoadDb_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigator2_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void bindingNavigator2_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void bindingNavigator2_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void lblCompte_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();

            CompteForm frm = new CompteForm();
            frm.Parent = this.splitContainer1.Panel2;
            this.splitContainer1.Panel2.Controls.Add(frm);
        }

        private void lblEntree_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();

            EntreeForm frm = new EntreeForm();
            frm.Parent = this.splitContainer1.Panel2;
            this.splitContainer1.Panel2.Controls.Add(frm);
        }

        private void lblSortie_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();

            SortieForm frm = new SortieForm();
            frm.Parent = this.splitContainer1.Panel2;
            this.splitContainer1.Panel2.Controls.Add(frm);
        }

        private void lblRapport_Click(object sender, EventArgs e)
        {
            this.splitContainer1.Panel2.Controls.Clear();

            Rapport frm = new Rapport();
            frm.Parent = this.splitContainer1.Panel2;
            this.splitContainer1.Panel2.Controls.Add(frm);
        }

        private void Comptefrm_Load(object sender, EventArgs e)
        {
            if (Factory.okLoginUser == 2)
            {
                //lblCompte.Enabled = true;
                //lblEntree.Enabled = true;
                //lblSortie.Enabled = true;
            }
        }
    }
}
