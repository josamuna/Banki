namespace GestionCoopec
{
    partial class CategorieForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategorieForm));
            this.dgvCategorie = new System.Windows.Forms.DataGridView();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.bnvAgent = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAddCategorie = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshCategorie = new System.Windows.Forms.ToolStripButton();
            this.btnSaveCategorie = new System.Windows.Forms.ToolStripButton();
            this.btnModifierCategorie = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteCategorie = new System.Windows.Forms.ToolStripButton();
            this.closeCategorie = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAgent)).BeginInit();
            this.bnvAgent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategorie
            // 
            this.dgvCategorie.AllowUserToAddRows = false;
            this.dgvCategorie.AllowUserToDeleteRows = false;
            this.dgvCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorie.Location = new System.Drawing.Point(10, 90);
            this.dgvCategorie.MultiSelect = false;
            this.dgvCategorie.Name = "dgvCategorie";
            this.dgvCategorie.ReadOnly = true;
            this.dgvCategorie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategorie.Size = new System.Drawing.Size(279, 68);
            this.dgvCategorie.TabIndex = 165;
            this.dgvCategorie.SelectionChanged += new System.EventHandler(this.dgvCategorie_SelectionChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(84, 40);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(88, 20);
            this.txtId.TabIndex = 163;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 162;
            this.label11.Text = "Désignation:";
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(84, 64);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(205, 20);
            this.txtDesignation.TabIndex = 160;
            // 
            // bnvAgent
            // 
            this.bnvAgent.AddNewItem = null;
            this.bnvAgent.BackColor = System.Drawing.Color.Transparent;
            this.bnvAgent.CountItem = null;
            this.bnvAgent.DeleteItem = null;
            this.bnvAgent.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnvAgent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddCategorie,
            this.btnRefreshCategorie,
            this.btnSaveCategorie,
            this.btnModifierCategorie,
            this.btnDeleteCategorie,
            this.closeCategorie});
            this.bnvAgent.Location = new System.Drawing.Point(0, 0);
            this.bnvAgent.MoveFirstItem = null;
            this.bnvAgent.MoveLastItem = null;
            this.bnvAgent.MoveNextItem = null;
            this.bnvAgent.MovePreviousItem = null;
            this.bnvAgent.Name = "bnvAgent";
            this.bnvAgent.PositionItem = null;
            this.bnvAgent.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bnvAgent.Size = new System.Drawing.Size(296, 25);
            this.bnvAgent.TabIndex = 159;
            this.bnvAgent.Text = "bindingNavigator1";
            // 
            // btnAddCategorie
            // 
            this.btnAddCategorie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddCategorie.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCategorie.Image")));
            this.btnAddCategorie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCategorie.Name = "btnAddCategorie";
            this.btnAddCategorie.Size = new System.Drawing.Size(23, 22);
            this.btnAddCategorie.Text = "Ajouter";
            this.btnAddCategorie.Click += new System.EventHandler(this.btnAddCategorie_Click);
            // 
            // btnRefreshCategorie
            // 
            this.btnRefreshCategorie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshCategorie.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCategorie.Image")));
            this.btnRefreshCategorie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshCategorie.Name = "btnRefreshCategorie";
            this.btnRefreshCategorie.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshCategorie.Text = "Refresh";
            this.btnRefreshCategorie.Click += new System.EventHandler(this.btnRefreshCategorie_Click);
            // 
            // btnSaveCategorie
            // 
            this.btnSaveCategorie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveCategorie.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveCategorie.Image")));
            this.btnSaveCategorie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveCategorie.Name = "btnSaveCategorie";
            this.btnSaveCategorie.Size = new System.Drawing.Size(23, 22);
            this.btnSaveCategorie.Text = "Enregistrer";
            this.btnSaveCategorie.Click += new System.EventHandler(this.btnSaveCategorie_Click);
            // 
            // btnModifierCategorie
            // 
            this.btnModifierCategorie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModifierCategorie.Image = ((System.Drawing.Image)(resources.GetObject("btnModifierCategorie.Image")));
            this.btnModifierCategorie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifierCategorie.Name = "btnModifierCategorie";
            this.btnModifierCategorie.Size = new System.Drawing.Size(23, 22);
            this.btnModifierCategorie.Text = "Modifier";
            this.btnModifierCategorie.Click += new System.EventHandler(this.btnModifierCategorie_Click);
            // 
            // btnDeleteCategorie
            // 
            this.btnDeleteCategorie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteCategorie.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteCategorie.Image")));
            this.btnDeleteCategorie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteCategorie.Name = "btnDeleteCategorie";
            this.btnDeleteCategorie.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteCategorie.Text = "Supprimer";
            this.btnDeleteCategorie.Click += new System.EventHandler(this.btnDeleteCategorie_Click);
            // 
            // closeCategorie
            // 
            this.closeCategorie.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.closeCategorie.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeCategorie.Image = global::GestionCoopec.Properties.Resources.StdClearButton;
            this.closeCategorie.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.closeCategorie.Name = "closeCategorie";
            this.closeCategorie.Size = new System.Drawing.Size(23, 22);
            this.closeCategorie.Text = "Fermer";
            this.closeCategorie.Click += new System.EventHandler(this.closeCategorie_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bnvAgent);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 166);
            this.panel1.TabIndex = 166;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 164;
            this.label2.Text = "Code :";
            // 
            // CategorieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 166);
            this.ControlBox = false;
            this.Controls.Add(this.dgvCategorie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CategorieForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorie";
            this.Load += new System.EventHandler(this.CategorieForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAgent)).EndInit();
            this.bnvAgent.ResumeLayout(false);
            this.bnvAgent.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorie;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.BindingNavigator bnvAgent;
        private System.Windows.Forms.ToolStripButton btnAddCategorie;
        private System.Windows.Forms.ToolStripButton btnRefreshCategorie;
        private System.Windows.Forms.ToolStripButton btnSaveCategorie;
        private System.Windows.Forms.ToolStripButton btnModifierCategorie;
        private System.Windows.Forms.ToolStripButton btnDeleteCategorie;
        private System.Windows.Forms.ToolStripButton closeCategorie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}