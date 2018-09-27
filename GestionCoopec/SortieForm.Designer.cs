namespace GestionCoopec
{
    partial class SortieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortieForm));
            this.dgvSortie = new System.Windows.Forms.DataGridView();
            this.txtDateSortie = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontantSortie = new System.Windows.Forms.TextBox();
            this.cboCompte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bnvAgent = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAddSortie = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshSortie = new System.Windows.Forms.ToolStripButton();
            this.btnSaveSortie = new System.Windows.Forms.ToolStripButton();
            this.btnModifierSortie = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteSortie = new System.Windows.Forms.ToolStripButton();
            this.closeSortie = new System.Windows.Forms.ToolStripButton();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAgent)).BeginInit();
            this.bnvAgent.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSortie
            // 
            this.dgvSortie.AllowUserToAddRows = false;
            this.dgvSortie.AllowUserToDeleteRows = false;
            this.dgvSortie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSortie.Location = new System.Drawing.Point(312, 37);
            this.dgvSortie.MultiSelect = false;
            this.dgvSortie.Name = "dgvSortie";
            this.dgvSortie.ReadOnly = true;
            this.dgvSortie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSortie.Size = new System.Drawing.Size(395, 93);
            this.dgvSortie.TabIndex = 176;
            this.dgvSortie.SelectionChanged += new System.EventHandler(this.dgvSortie_SelectionChanged);
            // 
            // txtDateSortie
            // 
            this.txtDateSortie.Location = new System.Drawing.Point(88, 56);
            this.txtDateSortie.Name = "txtDateSortie";
            this.txtDateSortie.Size = new System.Drawing.Size(200, 20);
            this.txtDateSortie.TabIndex = 175;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 174;
            this.label1.Text = "Montant :";
            // 
            // txtMontantSortie
            // 
            this.txtMontantSortie.Location = new System.Drawing.Point(88, 109);
            this.txtMontantSortie.Name = "txtMontantSortie";
            this.txtMontantSortie.Size = new System.Drawing.Size(200, 20);
            this.txtMontantSortie.TabIndex = 173;
            // 
            // cboCompte
            // 
            this.cboCompte.FormattingEnabled = true;
            this.cboCompte.Location = new System.Drawing.Point(88, 82);
            this.cboCompte.Name = "cboCompte";
            this.cboCompte.Size = new System.Drawing.Size(200, 21);
            this.cboCompte.TabIndex = 172;
            this.cboCompte.SelectedIndexChanged += new System.EventHandler(this.cboCompteSortie_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 171;
            this.label2.Text = "Code :";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(88, 30);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(88, 20);
            this.txtId.TabIndex = 170;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 169;
            this.label11.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 168;
            this.label3.Text = "Compte :";
            // 
            // bnvAgent
            // 
            this.bnvAgent.AddNewItem = null;
            this.bnvAgent.BackColor = System.Drawing.Color.Transparent;
            this.bnvAgent.CountItem = null;
            this.bnvAgent.DeleteItem = null;
            this.bnvAgent.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnvAgent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddSortie,
            this.btnRefreshSortie,
            this.btnSaveSortie,
            this.btnModifierSortie,
            this.btnDeleteSortie,
            this.closeSortie});
            this.bnvAgent.Location = new System.Drawing.Point(0, 0);
            this.bnvAgent.MoveFirstItem = null;
            this.bnvAgent.MoveLastItem = null;
            this.bnvAgent.MoveNextItem = null;
            this.bnvAgent.MovePreviousItem = null;
            this.bnvAgent.Name = "bnvAgent";
            this.bnvAgent.PositionItem = null;
            this.bnvAgent.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bnvAgent.Size = new System.Drawing.Size(717, 25);
            this.bnvAgent.TabIndex = 167;
            this.bnvAgent.Text = "bindingNavigator1";
            // 
            // btnAddSortie
            // 
            this.btnAddSortie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddSortie.Image = ((System.Drawing.Image)(resources.GetObject("btnAddSortie.Image")));
            this.btnAddSortie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddSortie.Name = "btnAddSortie";
            this.btnAddSortie.Size = new System.Drawing.Size(23, 22);
            this.btnAddSortie.Text = "Ajouter";
            this.btnAddSortie.Click += new System.EventHandler(this.btnAddSortie_Click);
            // 
            // btnRefreshSortie
            // 
            this.btnRefreshSortie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshSortie.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshSortie.Image")));
            this.btnRefreshSortie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshSortie.Name = "btnRefreshSortie";
            this.btnRefreshSortie.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshSortie.Text = "Refresh";
            this.btnRefreshSortie.Click += new System.EventHandler(this.btnRefreshSortie_Click);
            // 
            // btnSaveSortie
            // 
            this.btnSaveSortie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveSortie.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveSortie.Image")));
            this.btnSaveSortie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveSortie.Name = "btnSaveSortie";
            this.btnSaveSortie.Size = new System.Drawing.Size(23, 22);
            this.btnSaveSortie.Text = "Enregistrer";
            this.btnSaveSortie.Click += new System.EventHandler(this.btnSaveSortie_Click);
            // 
            // btnModifierSortie
            // 
            this.btnModifierSortie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModifierSortie.Image = ((System.Drawing.Image)(resources.GetObject("btnModifierSortie.Image")));
            this.btnModifierSortie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifierSortie.Name = "btnModifierSortie";
            this.btnModifierSortie.Size = new System.Drawing.Size(23, 22);
            this.btnModifierSortie.Text = "Modifier";
            this.btnModifierSortie.Click += new System.EventHandler(this.btnModifierSortie_Click);
            // 
            // btnDeleteSortie
            // 
            this.btnDeleteSortie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteSortie.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteSortie.Image")));
            this.btnDeleteSortie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteSortie.Name = "btnDeleteSortie";
            this.btnDeleteSortie.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteSortie.Text = "Supprimer";
            this.btnDeleteSortie.Click += new System.EventHandler(this.btnDeleteSortie_Click);
            // 
            // closeSortie
            // 
            this.closeSortie.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeSortie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeSortie.Image = global::GestionCoopec.Properties.Resources.StdClearButton;
            this.closeSortie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeSortie.Name = "closeSortie";
            this.closeSortie.Size = new System.Drawing.Size(23, 22);
            this.closeSortie.Text = "Fermer";
            this.closeSortie.Click += new System.EventHandler(this.closeSortie_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(318, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 177;
            this.label4.Text = "Sortie - Retrait";
            // 
            // SortieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvSortie);
            this.Controls.Add(this.txtDateSortie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontantSortie);
            this.Controls.Add(this.cboCompte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bnvAgent);
            this.Name = "SortieForm";
            this.Size = new System.Drawing.Size(717, 143);
            this.Load += new System.EventHandler(this.SortieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSortie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAgent)).EndInit();
            this.bnvAgent.ResumeLayout(false);
            this.bnvAgent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSortie;
        private System.Windows.Forms.DateTimePicker txtDateSortie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontantSortie;
        private System.Windows.Forms.ComboBox cboCompte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingNavigator bnvAgent;
        private System.Windows.Forms.ToolStripButton btnAddSortie;
        private System.Windows.Forms.ToolStripButton btnRefreshSortie;
        private System.Windows.Forms.ToolStripButton btnSaveSortie;
        private System.Windows.Forms.ToolStripButton btnModifierSortie;
        private System.Windows.Forms.ToolStripButton btnDeleteSortie;
        private System.Windows.Forms.ToolStripButton closeSortie;
        private System.Windows.Forms.Label label4;
    }
}
