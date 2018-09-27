namespace GestionCoopec
{
    partial class SituationSoldeCptClient
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SituationSoldeCptClient));
            this.crvSituationSoldeCompteClient = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvSituationSoldeCompteClient
            // 
            this.crvSituationSoldeCompteClient.ActiveViewIndex = -1;
            this.crvSituationSoldeCompteClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvSituationSoldeCompteClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvSituationSoldeCompteClient.Location = new System.Drawing.Point(0, 25);
            this.crvSituationSoldeCompteClient.Name = "crvSituationSoldeCompteClient";
            this.crvSituationSoldeCompteClient.SelectionFormula = "";
            this.crvSituationSoldeCompteClient.Size = new System.Drawing.Size(1043, 442);
            this.crvSituationSoldeCompteClient.TabIndex = 108;
            this.crvSituationSoldeCompteClient.ViewTimeSelectionFormula = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btClose});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1043, 25);
            this.bindingNavigator1.TabIndex = 107;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bindingNavigator1_MouseUp);
            this.bindingNavigator1.DoubleClick += new System.EventHandler(this.bindingNavigator1_DoubleClick);
            this.bindingNavigator1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bindingNavigator1_MouseDown);
            this.bindingNavigator1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bindingNavigator1_MouseMove);
            // 
            // btClose
            // 
            this.btClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btClose.Image = global::GestionCoopec.Properties.Resources.StdClearButton;
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 22);
            this.btClose.Text = "toolStripButton1";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 467);
            this.panel1.TabIndex = 109;
            // 
            // SituationSoldeCptClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 467);
            this.Controls.Add(this.crvSituationSoldeCompteClient);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SituationSoldeCptClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SituationSoldeCptClient";
            this.Load += new System.EventHandler(this.SituationSoldeCptClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvSituationSoldeCompteClient;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.Panel panel1;
    }
}