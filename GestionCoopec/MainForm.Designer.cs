namespace GestionCoopec
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAuthentification = new System.Windows.Forms.ToolStripMenuItem();
            this.mnGestionUser = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDeconnection = new System.Windows.Forms.ToolStripMenuItem();
            this.Fermer = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnAgent = new System.Windows.Forms.ToolStripMenuItem();
            this.mnClient = new System.Windows.Forms.ToolStripMenuItem();
            this.mnCompte = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRapport = new System.Windows.Forms.ToolStripMenuItem();
            this.ssmListeAgent = new System.Windows.Forms.ToolStripMenuItem();
            this.ssmListeClient = new System.Windows.Forms.ToolStripMenuItem();
            this.ssmSitGenEntreeClient = new System.Windows.Forms.ToolStripMenuItem();
            this.ssmSitGenEntre = new System.Windows.Forms.ToolStripMenuItem();
            this.ssmSitGenSortie = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnAuthentification = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCompte = new System.Windows.Forms.ToolStripButton();
            this.btnAgent = new System.Windows.Forms.ToolStripButton();
            this.btnClient = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAide = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnCloseLoadDb = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblTextCPG = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.ouvrirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 25);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAuthentification,
            this.mnGestionUser,
            this.mnDeconnection,
            this.Fermer});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // mnAuthentification
            // 
            this.mnAuthentification.Name = "mnAuthentification";
            this.mnAuthentification.Size = new System.Drawing.Size(174, 22);
            this.mnAuthentification.Text = "Authentification";
            this.mnAuthentification.Click += new System.EventHandler(this.mnAuthentification_Click);
            // 
            // mnGestionUser
            // 
            this.mnGestionUser.Name = "mnGestionUser";
            this.mnGestionUser.Size = new System.Drawing.Size(174, 22);
            this.mnGestionUser.Text = "Gestion utilisateurs";
            this.mnGestionUser.Click += new System.EventHandler(this.mnGestionUser_Click);
            // 
            // mnDeconnection
            // 
            this.mnDeconnection.Name = "mnDeconnection";
            this.mnDeconnection.Size = new System.Drawing.Size(174, 22);
            this.mnDeconnection.Text = "Déconnexion";
            this.mnDeconnection.Click += new System.EventHandler(this.mnDeconnection_Click);
            // 
            // Fermer
            // 
            this.Fermer.Name = "Fermer";
            this.Fermer.Size = new System.Drawing.Size(174, 22);
            this.Fermer.Text = "Fermer";
            this.Fermer.Click += new System.EventHandler(this.Fermer_Click);
            // 
            // ouvrirToolStripMenuItem
            // 
            this.ouvrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnAgent,
            this.mnClient,
            this.mnCompte,
            this.mnRapport});
            this.ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            this.ouvrirToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.ouvrirToolStripMenuItem.Text = "Ouvrir";
            // 
            // mnAgent
            // 
            this.mnAgent.Name = "mnAgent";
            this.mnAgent.Size = new System.Drawing.Size(152, 22);
            this.mnAgent.Text = "Agent";
            this.mnAgent.Click += new System.EventHandler(this.mnAgent_Click);
            // 
            // mnClient
            // 
            this.mnClient.Name = "mnClient";
            this.mnClient.Size = new System.Drawing.Size(152, 22);
            this.mnClient.Text = "Client";
            this.mnClient.Click += new System.EventHandler(this.mnClient_Click);
            // 
            // mnCompte
            // 
            this.mnCompte.Name = "mnCompte";
            this.mnCompte.Size = new System.Drawing.Size(152, 22);
            this.mnCompte.Text = "Compte";
            this.mnCompte.Click += new System.EventHandler(this.mnCompte_Click);
            // 
            // mnRapport
            // 
            this.mnRapport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssmListeAgent,
            this.ssmListeClient,
            this.ssmSitGenEntreeClient,
            this.ssmSitGenEntre,
            this.ssmSitGenSortie});
            this.mnRapport.Name = "mnRapport";
            this.mnRapport.Size = new System.Drawing.Size(152, 22);
            this.mnRapport.Text = "Rapport";
            // 
            // ssmListeAgent
            // 
            this.ssmListeAgent.Name = "ssmListeAgent";
            this.ssmListeAgent.Size = new System.Drawing.Size(285, 22);
            this.ssmListeAgent.Text = "Liste des Agents";
            this.ssmListeAgent.Click += new System.EventHandler(this.listeDesAgentsToolStripMenuItem_Click);
            // 
            // ssmListeClient
            // 
            this.ssmListeClient.Name = "ssmListeClient";
            this.ssmListeClient.Size = new System.Drawing.Size(285, 22);
            this.ssmListeClient.Text = "Liste des Clients";
            this.ssmListeClient.Click += new System.EventHandler(this.listeDesClientsToolStripMenuItem_Click);
            // 
            // ssmSitGenEntreeClient
            // 
            this.ssmSitGenEntreeClient.Name = "ssmSitGenEntreeClient";
            this.ssmSitGenEntreeClient.Size = new System.Drawing.Size(285, 22);
            this.ssmSitGenEntreeClient.Text = "Situation générales des Comptes Clients";
            this.ssmSitGenEntreeClient.Click += new System.EventHandler(this.ssmSitGenEntreeClient_Click);
            // 
            // ssmSitGenEntre
            // 
            this.ssmSitGenEntre.Name = "ssmSitGenEntre";
            this.ssmSitGenEntre.Size = new System.Drawing.Size(285, 22);
            this.ssmSitGenEntre.Text = "Situation générales des entrées";
            this.ssmSitGenEntre.Click += new System.EventHandler(this.ssmSitGenEntre_Click);
            // 
            // ssmSitGenSortie
            // 
            this.ssmSitGenSortie.Name = "ssmSitGenSortie";
            this.ssmSitGenSortie.Size = new System.Drawing.Size(285, 22);
            this.ssmSitGenSortie.Text = "Situation générales des Sorties";
            this.ssmSitGenSortie.Click += new System.EventHandler(this.ssmSitGenSortie_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.WhiteSmoke;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAuthentification,
            this.toolStripSeparator6,
            this.btnCompte,
            this.btnAgent,
            this.btnClient,
            this.toolStripSeparator1,
            this.btnAide});
            this.toolStrip.Location = new System.Drawing.Point(0, 49);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(717, 46);
            this.toolStrip.TabIndex = 9;
            this.toolStrip.Text = "ToolStrip";
            // 
            // btnAuthentification
            // 
            this.btnAuthentification.AutoSize = false;
            this.btnAuthentification.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAuthentification.Image = global::GestionCoopec.Properties.Resources.mp_lock_ios_n_lt_2x;
            this.btnAuthentification.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAuthentification.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAuthentification.Name = "btnAuthentification";
            this.btnAuthentification.Size = new System.Drawing.Size(50, 50);
            this.btnAuthentification.Text = "Manipulations Agent";
            this.btnAuthentification.ToolTipText = "Authentification de l\'utilisateur";
            this.btnAuthentification.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 46);
            // 
            // btnCompte
            // 
            this.btnCompte.AutoSize = false;
            this.btnCompte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCompte.Image = global::GestionCoopec.Properties.Resources.Googledocs_off_2xOK;
            this.btnCompte.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCompte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCompte.Name = "btnCompte";
            this.btnCompte.Size = new System.Drawing.Size(50, 50);
            this.btnCompte.Text = "Quitter";
            this.btnCompte.ToolTipText = "Compte";
            this.btnCompte.Click += new System.EventHandler(this.btnCompte_Click);
            // 
            // btnAgent
            // 
            this.btnAgent.AutoSize = false;
            this.btnAgent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAgent.Image = global::GestionCoopec.Properties.Resources.placeholder_player_man_2x1;
            this.btnAgent.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAgent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAgent.Name = "btnAgent";
            this.btnAgent.Size = new System.Drawing.Size(50, 50);
            this.btnAgent.ToolTipText = "Agent";
            this.btnAgent.Click += new System.EventHandler(this.btnAgent_Click);
            // 
            // btnClient
            // 
            this.btnClient.AutoSize = false;
            this.btnClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClient.Image = ((System.Drawing.Image)(resources.GetObject("btnClient.Image")));
            this.btnClient.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(50, 50);
            this.btnClient.ToolTipText = "Client";
            this.btnClient.Click += new System.EventHandler(this.btnClient_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // btnAide
            // 
            this.btnAide.AutoSize = false;
            this.btnAide.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAide.Image = ((System.Drawing.Image)(resources.GetObject("btnAide.Image")));
            this.btnAide.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAide.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(50, 50);
            this.btnAide.Text = "Aide";
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCloseLoadDb,
            this.toolStripButton1,
            this.toolStripLabel1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator2.Size = new System.Drawing.Size(717, 25);
            this.bindingNavigator2.TabIndex = 151;
            this.bindingNavigator2.Text = "bindingNavigator2";
            this.bindingNavigator2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bindingNavigator2_MouseUp);
            this.bindingNavigator2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.bindingNavigator2_MouseDoubleClick);
            this.bindingNavigator2.RefreshItems += new System.EventHandler(this.bindingNavigator2_RefreshItems);
            this.bindingNavigator2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bindingNavigator2_MouseDown);
            this.bindingNavigator2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bindingNavigator2_MouseMove);
            // 
            // btnCloseLoadDb
            // 
            this.btnCloseLoadDb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCloseLoadDb.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseLoadDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCloseLoadDb.Image = global::GestionCoopec.Properties.Resources.StdClearButton;
            this.btnCloseLoadDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCloseLoadDb.Name = "btnCloseLoadDb";
            this.btnCloseLoadDb.Size = new System.Drawing.Size(23, 22);
            this.btnCloseLoadDb.Text = "Quitter";
            this.btnCloseLoadDb.Click += new System.EventHandler(this.btnCloseLoadDb_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::GestionCoopec.Properties.Resources.QuizButton_Shadow_A;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(91, 22);
            this.toolStripLabel1.Text = "Gestion Coopec";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::GestionCoopec.Properties.Resources.UploadAction_2;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.ToolTipText = "Minimiser";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::GestionCoopec.Properties.Resources.WebDAVIndexDownloadHover;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTipText = "Reduire";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // statusBar
            // 
            this.statusBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.statusBar.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTextCPG});
            this.statusBar.Location = new System.Drawing.Point(0, 234);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(717, 22);
            this.statusBar.TabIndex = 152;
            // 
            // lblTextCPG
            // 
            this.lblTextCPG.BackColor = System.Drawing.Color.Transparent;
            this.lblTextCPG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblTextCPG.Name = "lblTextCPG";
            this.lblTextCPG.Size = new System.Drawing.Size(143, 17);
            this.lblTextCPG.Text = "toolStripStatusLabel1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(717, 256);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bindingNavigator2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Coopec";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Fermer;
        private System.Windows.Forms.ToolStripMenuItem ouvrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnAgent;
        private System.Windows.Forms.ToolStripMenuItem mnClient;
        private System.Windows.Forms.ToolStripMenuItem mnCompte;
        private System.Windows.Forms.ToolStripMenuItem mnRapport;
        private System.Windows.Forms.ToolStripMenuItem ssmListeAgent;
        private System.Windows.Forms.ToolStripMenuItem ssmListeClient;
        private System.Windows.Forms.ToolStripMenuItem ssmSitGenEntreeClient;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnCompte;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton btnAuthentification;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnAgent;
        private System.Windows.Forms.ToolStripButton btnClient;
        private System.Windows.Forms.ToolStripButton btnAide;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton btnCloseLoadDb;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem mnDeconnection;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblTextCPG;
        private System.Windows.Forms.ToolStripMenuItem ssmSitGenEntre;
        private System.Windows.Forms.ToolStripMenuItem ssmSitGenSortie;
        private System.Windows.Forms.ToolStripMenuItem mnGestionUser;
        private System.Windows.Forms.ToolStripMenuItem mnAuthentification;
    }
}

