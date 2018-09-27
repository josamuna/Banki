namespace GestionCoopec
{
    partial class Comptefrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Comptefrm));
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnCloseLoadDb = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblRapport = new System.Windows.Forms.Label();
            this.lblSortie = new System.Windows.Forms.Label();
            this.lblEntree = new System.Windows.Forms.Label();
            this.lblCompte = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.AutoSize = false;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCloseLoadDb});
            this.bindingNavigator2.Location = new System.Drawing.Point(4, 4);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator2.Size = new System.Drawing.Size(888, 24);
            this.bindingNavigator2.TabIndex = 150;
            this.bindingNavigator2.Text = "bindingNavigator2";
            this.bindingNavigator2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bindingNavigator2_MouseUp);
            this.bindingNavigator2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bindingNavigator2_MouseDown);
            this.bindingNavigator2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bindingNavigator2_MouseMove);
            // 
            // btnCloseLoadDb
            // 
            this.btnCloseLoadDb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCloseLoadDb.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseLoadDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCloseLoadDb.Image = global::GestionCoopec.Properties.Resources.StdClearButton;
            this.btnCloseLoadDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCloseLoadDb.Name = "btnCloseLoadDb";
            this.btnCloseLoadDb.Size = new System.Drawing.Size(23, 21);
            this.btnCloseLoadDb.Text = "Quitter";
            this.btnCloseLoadDb.Click += new System.EventHandler(this.btnCloseLoadDb_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(4, 31);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel1.Controls.Add(this.lblRapport);
            this.splitContainer1.Panel1.Controls.Add(this.lblSortie);
            this.splitContainer1.Panel1.Controls.Add(this.lblEntree);
            this.splitContainer1.Panel1.Controls.Add(this.lblCompte);
            this.splitContainer1.Panel1.MouseEnter += new System.EventHandler(this.splitContainer1_Panel1_MouseEnter);
            this.splitContainer1.Size = new System.Drawing.Size(893, 353);
            this.splitContainer1.SplitterDistance = 145;
            this.splitContainer1.TabIndex = 151;
            // 
            // lblRapport
            // 
            this.lblRapport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRapport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblRapport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRapport.Image = global::GestionCoopec.Properties.Resources.mixed_doc_off_2x1;
            this.lblRapport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRapport.Location = new System.Drawing.Point(1, 217);
            this.lblRapport.Name = "lblRapport";
            this.lblRapport.Size = new System.Drawing.Size(142, 45);
            this.lblRapport.TabIndex = 3;
            this.lblRapport.Text = "Rapport";
            this.lblRapport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRapport.Click += new System.EventHandler(this.lblRapport_Click);
            this.lblRapport.MouseEnter += new System.EventHandler(this.lblRapport_MouseEnter);
            // 
            // lblSortie
            // 
            this.lblSortie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSortie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSortie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortie.Image = global::GestionCoopec.Properties.Resources.changephoto_02_2x1;
            this.lblSortie.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSortie.Location = new System.Drawing.Point(1, 161);
            this.lblSortie.Name = "lblSortie";
            this.lblSortie.Size = new System.Drawing.Size(141, 52);
            this.lblSortie.TabIndex = 2;
            this.lblSortie.Text = "Sortie";
            this.lblSortie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSortie.Click += new System.EventHandler(this.lblSortie_Click);
            this.lblSortie.MouseEnter += new System.EventHandler(this.lblSortie_MouseEnter);
            // 
            // lblEntree
            // 
            this.lblEntree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEntree.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEntree.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntree.Image = global::GestionCoopec.Properties.Resources.mp_createpdf_ios_n_lt_2x;
            this.lblEntree.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEntree.Location = new System.Drawing.Point(3, 106);
            this.lblEntree.Name = "lblEntree";
            this.lblEntree.Size = new System.Drawing.Size(139, 51);
            this.lblEntree.TabIndex = 1;
            this.lblEntree.Text = "Entrée";
            this.lblEntree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEntree.Click += new System.EventHandler(this.lblEntree_Click);
            this.lblEntree.MouseEnter += new System.EventHandler(this.lblEntree_MouseEnter);
            // 
            // lblCompte
            // 
            this.lblCompte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCompte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompte.Image = global::GestionCoopec.Properties.Resources.Googledocs_off_2xOK;
            this.lblCompte.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompte.Location = new System.Drawing.Point(3, 57);
            this.lblCompte.Name = "lblCompte";
            this.lblCompte.Size = new System.Drawing.Size(139, 45);
            this.lblCompte.TabIndex = 0;
            this.lblCompte.Text = "Compte";
            this.lblCompte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCompte.Click += new System.EventHandler(this.lblCompte_Click);
            this.lblCompte.MouseEnter += new System.EventHandler(this.lblCompte_MouseEnter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(380, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 22);
            this.label6.TabIndex = 152;
            this.label6.Text = "Mouvements Compte";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(901, 388);
            this.panel1.TabIndex = 153;
            // 
            // Comptefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 388);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Comptefrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compte";
            this.Load += new System.EventHandler(this.Comptefrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton btnCloseLoadDb;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblEntree;
        private System.Windows.Forms.Label lblCompte;
        private System.Windows.Forms.Label lblRapport;
        private System.Windows.Forms.Label lblSortie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;

    }
}