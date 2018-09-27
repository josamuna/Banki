namespace GestionCoopec
{
    partial class Rapport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rapport));
            this.lblAffichage = new System.Windows.Forms.Label();
            this.lblSitGen = new System.Windows.Forms.Label();
            this.lblDetCompte = new System.Windows.Forms.Label();
            this.lblSitFin = new System.Windows.Forms.Label();
            this.lblListeCli = new System.Windows.Forms.Label();
            this.lblListAg = new System.Windows.Forms.Label();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnCloseLoadDb = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAffichage
            // 
            this.lblAffichage.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffichage.ForeColor = System.Drawing.Color.DarkGray;
            this.lblAffichage.Location = new System.Drawing.Point(25, 227);
            this.lblAffichage.Name = "lblAffichage";
            this.lblAffichage.Size = new System.Drawing.Size(456, 73);
            this.lblAffichage.TabIndex = 0;
            // 
            // lblSitGen
            // 
            this.lblSitGen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSitGen.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSitGen.Image = ((System.Drawing.Image)(resources.GetObject("lblSitGen.Image")));
            this.lblSitGen.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblSitGen.Location = new System.Drawing.Point(40, 30);
            this.lblSitGen.Name = "lblSitGen";
            this.lblSitGen.Size = new System.Drawing.Size(361, 35);
            this.lblSitGen.TabIndex = 1;
            this.lblSitGen.Text = "         Mouvements de sortie des comptes Clients";
            this.lblSitGen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSitGen.Click += new System.EventHandler(this.lblSitGen_Click);
            this.lblSitGen.MouseEnter += new System.EventHandler(this.lblSitGen_MouseEnter);
            // 
            // lblDetCompte
            // 
            this.lblDetCompte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblDetCompte.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetCompte.Image = global::GestionCoopec.Properties.Resources.sort_icon1;
            this.lblDetCompte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDetCompte.Location = new System.Drawing.Point(37, 71);
            this.lblDetCompte.Name = "lblDetCompte";
            this.lblDetCompte.Size = new System.Drawing.Size(465, 30);
            this.lblDetCompte.TabIndex = 2;
            this.lblDetCompte.Text = "         Situation générale des Mouvements des comptes des clients";
            this.lblDetCompte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDetCompte.Click += new System.EventHandler(this.lblDetCompte_Click);
            this.lblDetCompte.MouseEnter += new System.EventHandler(this.lblDetCompte_MouseEnter);
            // 
            // lblSitFin
            // 
            this.lblSitFin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSitFin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSitFin.Image = ((System.Drawing.Image)(resources.GetObject("lblSitFin.Image")));
            this.lblSitFin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSitFin.Location = new System.Drawing.Point(40, 107);
            this.lblSitFin.Name = "lblSitFin";
            this.lblSitFin.Size = new System.Drawing.Size(375, 30);
            this.lblSitFin.TabIndex = 3;
            this.lblSitFin.Text = "          Mouvement d\'entrée des Comptes";
            this.lblSitFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSitFin.Click += new System.EventHandler(this.lblSitFin_Click);
            this.lblSitFin.MouseEnter += new System.EventHandler(this.lblSitFin_MouseEnter);
            // 
            // lblListeCli
            // 
            this.lblListeCli.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListeCli.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListeCli.Image = global::GestionCoopec.Properties.Resources.w_aim_2x1;
            this.lblListeCli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblListeCli.Location = new System.Drawing.Point(40, 143);
            this.lblListeCli.Name = "lblListeCli";
            this.lblListeCli.Size = new System.Drawing.Size(375, 30);
            this.lblListeCli.TabIndex = 4;
            this.lblListeCli.Text = "          Liste des clients et compte associé";
            this.lblListeCli.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblListeCli.Click += new System.EventHandler(this.lblListeCli_Click);
            this.lblListeCli.MouseEnter += new System.EventHandler(this.lblListeCli_MouseEnter);
            // 
            // lblListAg
            // 
            this.lblListAg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblListAg.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListAg.Image = global::GestionCoopec.Properties.Resources.b_msn_alpha_2x1;
            this.lblListAg.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblListAg.Location = new System.Drawing.Point(40, 179);
            this.lblListAg.Name = "lblListAg";
            this.lblListAg.Size = new System.Drawing.Size(375, 30);
            this.lblListAg.TabIndex = 5;
            this.lblListAg.Text = "          Liste des agents";
            this.lblListAg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblListAg.Click += new System.EventHandler(this.lblListAg_Click);
            this.lblListAg.MouseEnter += new System.EventHandler(this.lblListAg_MouseEnter);
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.AutoSize = false;
            this.bindingNavigator2.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCloseLoadDb});
            this.bindingNavigator2.Location = new System.Drawing.Point(8, 1);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator2.Size = new System.Drawing.Size(488, 25);
            this.bindingNavigator2.TabIndex = 150;
            this.bindingNavigator2.Text = "bindingNavigator2";
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
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblListAg);
            this.panel1.Controls.Add(this.lblListeCli);
            this.panel1.Controls.Add(this.lblSitFin);
            this.panel1.Controls.Add(this.lblDetCompte);
            this.panel1.Controls.Add(this.lblSitGen);
            this.panel1.Controls.Add(this.lblAffichage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 313);
            this.panel1.TabIndex = 151;
            // 
            // Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::GestionCoopec.Properties.Resources.img_emissions_player_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Rapport";
            this.Size = new System.Drawing.Size(503, 313);
            this.Load += new System.EventHandler(this.Rapport_Load);
            this.MouseEnter += new System.EventHandler(this.Rapport_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAffichage;
        private System.Windows.Forms.Label lblSitGen;
        private System.Windows.Forms.Label lblDetCompte;
        private System.Windows.Forms.Label lblSitFin;
        private System.Windows.Forms.Label lblListeCli;
        private System.Windows.Forms.Label lblListAg;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton btnCloseLoadDb;
        private System.Windows.Forms.Panel panel1;
    }
}
