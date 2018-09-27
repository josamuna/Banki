namespace GestionCoopec
{
    partial class EntreeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntreeForm));
            this.bnvAgent = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAddEntree = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshEntree = new System.Windows.Forms.ToolStripButton();
            this.btnSaveEntree = new System.Windows.Forms.ToolStripButton();
            this.btnModifierEntree = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteEntree = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.cboCompte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMontantEntr = new System.Windows.Forms.TextBox();
            this.txtDateEntree = new System.Windows.Forms.DateTimePicker();
            this.dgvEntree = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAgent)).BeginInit();
            this.bnvAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntree)).BeginInit();
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
            this.btnAddEntree,
            this.btnRefreshEntree,
            this.btnSaveEntree,
            this.btnModifierEntree,
            this.btnDeleteEntree,
            this.toolStripButton1});
            this.bnvAgent.Location = new System.Drawing.Point(0, 0);
            this.bnvAgent.MoveFirstItem = null;
            this.bnvAgent.MoveLastItem = null;
            this.bnvAgent.MoveNextItem = null;
            this.bnvAgent.MovePreviousItem = null;
            this.bnvAgent.Name = "bnvAgent";
            this.bnvAgent.PositionItem = null;
            this.bnvAgent.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bnvAgent.Size = new System.Drawing.Size(693, 25);
            this.bnvAgent.TabIndex = 110;
            this.bnvAgent.Text = "bindingNavigator1";
            // 
            // btnAddEntree
            // 
            this.btnAddEntree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddEntree.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEntree.Image")));
            this.btnAddEntree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddEntree.Name = "btnAddEntree";
            this.btnAddEntree.Size = new System.Drawing.Size(23, 22);
            this.btnAddEntree.Text = "Ajouter";
            this.btnAddEntree.Click += new System.EventHandler(this.btnAddEntree_Click);
            // 
            // btnRefreshEntree
            // 
            this.btnRefreshEntree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshEntree.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshEntree.Image")));
            this.btnRefreshEntree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshEntree.Name = "btnRefreshEntree";
            this.btnRefreshEntree.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshEntree.Text = "Refresh";
            this.btnRefreshEntree.Click += new System.EventHandler(this.btnRefreshEntree_Click);
            // 
            // btnSaveEntree
            // 
            this.btnSaveEntree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveEntree.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveEntree.Image")));
            this.btnSaveEntree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveEntree.Name = "btnSaveEntree";
            this.btnSaveEntree.Size = new System.Drawing.Size(23, 22);
            this.btnSaveEntree.Text = "Enregistrer";
            this.btnSaveEntree.Click += new System.EventHandler(this.btnSaveEntree_Click);
            // 
            // btnModifierEntree
            // 
            this.btnModifierEntree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModifierEntree.Image = ((System.Drawing.Image)(resources.GetObject("btnModifierEntree.Image")));
            this.btnModifierEntree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifierEntree.Name = "btnModifierEntree";
            this.btnModifierEntree.Size = new System.Drawing.Size(23, 22);
            this.btnModifierEntree.Text = "Modifier";
            this.btnModifierEntree.Click += new System.EventHandler(this.btnModifierEntree_Click);
            // 
            // btnDeleteEntree
            // 
            this.btnDeleteEntree.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteEntree.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteEntree.Image")));
            this.btnDeleteEntree.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteEntree.Name = "btnDeleteEntree";
            this.btnDeleteEntree.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteEntree.Text = "Supprimer";
            this.btnDeleteEntree.Click += new System.EventHandler(this.btnDeleteEntree_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::GestionCoopec.Properties.Resources.StdClearButton;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Fermer";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // cboCompte
            // 
            this.cboCompte.FormattingEnabled = true;
            this.cboCompte.Location = new System.Drawing.Point(80, 83);
            this.cboCompte.Name = "cboCompte";
            this.cboCompte.Size = new System.Drawing.Size(200, 21);
            this.cboCompte.TabIndex = 162;
            this.cboCompte.SelectedIndexChanged += new System.EventHandler(this.cboCompte_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 161;
            this.label2.Text = "Code :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(80, 31);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(88, 20);
            this.txtId.TabIndex = 160;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 159;
            this.label11.Text = "Date :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 158;
            this.label3.Text = "Compte :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 164;
            this.label1.Text = "Montant :";
            // 
            // txtMontantEntr
            // 
            this.txtMontantEntr.Location = new System.Drawing.Point(80, 110);
            this.txtMontantEntr.Name = "txtMontantEntr";
            this.txtMontantEntr.Size = new System.Drawing.Size(200, 20);
            this.txtMontantEntr.TabIndex = 163;
            // 
            // txtDateEntree
            // 
            this.txtDateEntree.Location = new System.Drawing.Point(80, 57);
            this.txtDateEntree.Name = "txtDateEntree";
            this.txtDateEntree.Size = new System.Drawing.Size(200, 20);
            this.txtDateEntree.TabIndex = 165;
            // 
            // dgvEntree
            // 
            this.dgvEntree.AllowUserToAddRows = false;
            this.dgvEntree.AllowUserToDeleteRows = false;
            this.dgvEntree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntree.Location = new System.Drawing.Point(296, 37);
            this.dgvEntree.MultiSelect = false;
            this.dgvEntree.Name = "dgvEntree";
            this.dgvEntree.ReadOnly = true;
            this.dgvEntree.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntree.Size = new System.Drawing.Size(387, 93);
            this.dgvEntree.TabIndex = 166;
            this.dgvEntree.SelectionChanged += new System.EventHandler(this.dgvEntree_SelectionChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Book", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 19);
            this.label4.TabIndex = 167;
            this.label4.Text = "Entrée - Dépot";
            // 
            // EntreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvEntree);
            this.Controls.Add(this.txtDateEntree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMontantEntr);
            this.Controls.Add(this.cboCompte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bnvAgent);
            this.Name = "EntreeForm";
            this.Size = new System.Drawing.Size(693, 143);
            this.Load += new System.EventHandler(this.EntreeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnvAgent)).EndInit();
            this.bnvAgent.ResumeLayout(false);
            this.bnvAgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntree)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnvAgent;
        private System.Windows.Forms.ToolStripButton btnAddEntree;
        private System.Windows.Forms.ToolStripButton btnRefreshEntree;
        private System.Windows.Forms.ToolStripButton btnSaveEntree;
        private System.Windows.Forms.ToolStripButton btnModifierEntree;
        private System.Windows.Forms.ToolStripButton btnDeleteEntree;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ComboBox cboCompte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMontantEntr;
        private System.Windows.Forms.DateTimePicker txtDateEntree;
        private System.Windows.Forms.DataGridView dgvEntree;
        private System.Windows.Forms.Label label4;
    }
}
