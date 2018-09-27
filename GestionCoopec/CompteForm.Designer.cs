namespace GestionCoopec
{
    partial class CompteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompteForm));
            this.bnvAgent = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAddCompte = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshCompte = new System.Windows.Forms.ToolStripButton();
            this.btnSaveCompte = new System.Windows.Forms.ToolStripButton();
            this.btnModifierCompte = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCompte = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvCompte = new System.Windows.Forms.DataGridView();
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addClient = new System.Windows.Forms.Label();
            this.cboClient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdFC = new System.Windows.Forms.RadioButton();
            this.rdDollard = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSoldeCompte = new System.Windows.Forms.Label();
            this.lblArgent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAgent)).BeginInit();
            this.bnvAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompte)).BeginInit();
            this.SuspendLayout();
            // 
            // bnvAgent
            // 
            this.bnvAgent.AddNewItem = null;
            this.bnvAgent.BackColor = System.Drawing.Color.Transparent;
            this.bnvAgent.CountItem = null;
            this.bnvAgent.DeleteItem = null;
            this.bnvAgent.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnvAgent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCompte,
            this.btnRefreshCompte,
            this.btnSaveCompte,
            this.btnModifierCompte,
            this.btnDeleteCompte,
            this.btnClose});
            this.bnvAgent.Location = new System.Drawing.Point(0, 0);
            this.bnvAgent.MoveFirstItem = null;
            this.bnvAgent.MoveLastItem = null;
            this.bnvAgent.MoveNextItem = null;
            this.bnvAgent.MovePreviousItem = null;
            this.bnvAgent.Name = "bnvAgent";
            this.bnvAgent.PositionItem = null;
            this.bnvAgent.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bnvAgent.Size = new System.Drawing.Size(693, 25);
            this.bnvAgent.TabIndex = 109;
            this.bnvAgent.Text = "bindingNavigator1";
            // 
            // btnAddCompte
            // 
            this.btnAddCompte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddCompte.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCompte.Image")));
            this.btnAddCompte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCompte.Name = "btnAddCompte";
            this.btnAddCompte.Size = new System.Drawing.Size(23, 22);
            this.btnAddCompte.Text = "Ajouter";
            this.btnAddCompte.Click += new System.EventHandler(this.btnAddCompte_Click);
            // 
            // btnRefreshCompte
            // 
            this.btnRefreshCompte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshCompte.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCompte.Image")));
            this.btnRefreshCompte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshCompte.Name = "btnRefreshCompte";
            this.btnRefreshCompte.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshCompte.Text = "Refresh";
            this.btnRefreshCompte.Click += new System.EventHandler(this.btnRefreshCompte_Click);
            // 
            // btnSaveCompte
            // 
            this.btnSaveCompte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveCompte.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCompte.Image")));
            this.btnSaveCompte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCompte.Name = "btnSaveCompte";
            this.btnSaveCompte.Size = new System.Drawing.Size(23, 22);
            this.btnSaveCompte.Text = "Enregistrer";
            this.btnSaveCompte.Click += new System.EventHandler(this.btnSaveCompte_Click);
            // 
            // btnModifierCompte
            // 
            this.btnModifierCompte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModifierCompte.Image = ((System.Drawing.Image)(resources.GetObject("btnModifierCompte.Image")));
            this.btnModifierCompte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifierCompte.Name = "btnModifierCompte";
            this.btnModifierCompte.Size = new System.Drawing.Size(23, 22);
            this.btnModifierCompte.Text = "Modifier";
            this.btnModifierCompte.Click += new System.EventHandler(this.btnModifierCompte_Click);
            // 
            // btnDeleteCompte
            // 
            this.btnDeleteCompte.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteCompte.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCompte.Image")));
            this.btnDeleteCompte.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCompte.Name = "btnDeleteCompte";
            this.btnDeleteCompte.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteCompte.Text = "Supprimer";
            this.btnDeleteCompte.Click += new System.EventHandler(this.btnDeleteCompte_Click);
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = global::GestionCoopec.Properties.Resources.StdClearButton;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 22);
            this.btnClose.Text = "toolStripButton1";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 154;
            this.label2.Text = "Code :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(89, 32);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(88, 20);
            this.txtId.TabIndex = 153;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 152;
            this.label11.Text = "Désignation:";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(89, 56);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(244, 20);
            this.txtDesignation.TabIndex = 147;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 150;
            this.label3.Text = "Catégorie :";
            // 
            // dgvCompte
            // 
            this.dgvCompte.AllowUserToAddRows = false;
            this.dgvCompte.AllowUserToDeleteRows = false;
            this.dgvCompte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompte.Location = new System.Drawing.Point(383, 32);
            this.dgvCompte.MultiSelect = false;
            this.dgvCompte.Name = "dgvCompte";
            this.dgvCompte.ReadOnly = true;
            this.dgvCompte.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCompte.Size = new System.Drawing.Size(298, 134);
            this.dgvCompte.TabIndex = 155;
            this.dgvCompte.SelectionChanged += new System.EventHandler(this.dgvCompte_SelectionChanged);
            // 
            // cboCategorie
            // 
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Location = new System.Drawing.Point(89, 111);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(244, 21);
            this.cboCategorie.TabIndex = 156;
            this.cboCategorie.SelectedIndexChanged += new System.EventHandler(this.cmbCategorie_SelectedIndexChanged);
            this.cboCategorie.DropDown += new System.EventHandler(this.cboCategorie_DropDown);
            // 
            // label6
            // 
            this.label6.Image = global::GestionCoopec.Properties.Resources.AddFonct12;
            this.label6.Location = new System.Drawing.Point(343, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 21);
            this.label6.TabIndex = 157;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 158;
            this.label1.Text = "Compte";
            // 
            // addClient
            // 
            this.addClient.Image = global::GestionCoopec.Properties.Resources.AddFonct12;
            this.addClient.Location = new System.Drawing.Point(343, 83);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(20, 21);
            this.addClient.TabIndex = 161;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // cboClient
            // 
            this.cboClient.FormattingEnabled = true;
            this.cboClient.Location = new System.Drawing.Point(89, 84);
            this.cboClient.Name = "cboClient";
            this.cboClient.Size = new System.Drawing.Size(244, 21);
            this.cboClient.TabIndex = 160;
            this.cboClient.SelectedIndexChanged += new System.EventHandler(this.cboClient_SelectedIndexChanged);
            this.cboClient.DropDown += new System.EventHandler(this.cboClient_DropDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 159;
            this.label5.Text = "Client :";
            // 
            // rdFC
            // 
            this.rdFC.AutoSize = true;
            this.rdFC.ForeColor = System.Drawing.Color.Green;
            this.rdFC.Location = new System.Drawing.Point(210, 32);
            this.rdFC.Name = "rdFC";
            this.rdFC.Size = new System.Drawing.Size(68, 17);
            this.rdFC.TabIndex = 162;
            this.rdFC.TabStop = true;
            this.rdFC.Text = "FC (CDF)";
            this.rdFC.UseVisualStyleBackColor = true;
            this.rdFC.CheckedChanged += new System.EventHandler(this.rdFC_CheckedChanged);
            // 
            // rdDollard
            // 
            this.rdDollard.AutoSize = true;
            this.rdDollard.ForeColor = System.Drawing.Color.MediumBlue;
            this.rdDollard.Location = new System.Drawing.Point(282, 33);
            this.rdDollard.Name = "rdDollard";
            this.rdDollard.Size = new System.Drawing.Size(81, 17);
            this.rdDollard.TabIndex = 163;
            this.rdDollard.TabStop = true;
            this.rdDollard.Text = "$ US (USD)";
            this.rdDollard.UseVisualStyleBackColor = true;
            this.rdDollard.CheckedChanged += new System.EventHandler(this.rdDollard_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 18);
            this.label4.TabIndex = 164;
            this.label4.Text = "Solde du compte :";
            // 
            // lblSoldeCompte
            // 
            this.lblSoldeCompte.BackColor = System.Drawing.Color.PaleGreen;
            this.lblSoldeCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldeCompte.ForeColor = System.Drawing.Color.Navy;
            this.lblSoldeCompte.Location = new System.Drawing.Point(154, 148);
            this.lblSoldeCompte.Name = "lblSoldeCompte";
            this.lblSoldeCompte.Size = new System.Drawing.Size(179, 18);
            this.lblSoldeCompte.TabIndex = 165;
            // 
            // lblArgent
            // 
            this.lblArgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArgent.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblArgent.Location = new System.Drawing.Point(335, 147);
            this.lblArgent.Name = "lblArgent";
            this.lblArgent.Size = new System.Drawing.Size(45, 18);
            this.lblArgent.TabIndex = 166;
            // 
            // CompteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblArgent);
            this.Controls.Add(this.lblSoldeCompte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdDollard);
            this.Controls.Add(this.rdFC);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.cboClient);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboCategorie);
            this.Controls.Add(this.dgvCompte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bnvAgent);
            this.Name = "CompteForm";
            this.Size = new System.Drawing.Size(693, 176);
            this.Load += new System.EventHandler(this.CompteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvAgent)).EndInit();
            this.bnvAgent.ResumeLayout(false);
            this.bnvAgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvAgent;
        private System.Windows.Forms.ToolStripButton btnAddCompte;
        private System.Windows.Forms.ToolStripButton btnRefreshCompte;
        private System.Windows.Forms.ToolStripButton btnSaveCompte;
        private System.Windows.Forms.ToolStripButton btnModifierCompte;
        private System.Windows.Forms.ToolStripButton btnDeleteCompte;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvCompte;
        private System.Windows.Forms.ComboBox cboCategorie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addClient;
        private System.Windows.Forms.ComboBox cboClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdFC;
        private System.Windows.Forms.RadioButton rdDollard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSoldeCompte;
        private System.Windows.Forms.Label lblArgent;
    }
}
