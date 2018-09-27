namespace GestionCoopec
{
    partial class AgentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgentForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblLoadPhoto = new System.Windows.Forms.LinkLabel();
            this.pbPhotoPersonne = new System.Windows.Forms.PictureBox();
            this.txtDateNaissanceAgent = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.dgvAgent = new System.Windows.Forms.DataGridView();
            this.cmbRechercheAgent = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelephoneAgent = new System.Windows.Forms.TextBox();
            this.cboEtatCivAgent = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSexeAgent = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomAgent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPNomAgent = new System.Windows.Forms.TextBox();
            this.txtPrenomAgent = new System.Windows.Forms.TextBox();
            this.bnvAgent = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAddAgent = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshAgent = new System.Windows.Forms.ToolStripButton();
            this.btnSaveAgent = new System.Windows.Forms.ToolStripButton();
            this.btnModifierAgent = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteAgent = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnCloseLoadDb = new System.Windows.Forms.ToolStripButton();
            this.dlgFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotoPersonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAgent)).BeginInit();
            this.bnvAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.lblLoadPhoto);
            this.groupBox2.Controls.Add(this.pbPhotoPersonne);
            this.groupBox2.Controls.Add(this.txtDateNaissanceAgent);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtId);
            this.groupBox2.Controls.Add(this.dgvAgent);
            this.groupBox2.Controls.Add(this.cmbRechercheAgent);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTelephoneAgent);
            this.groupBox2.Controls.Add(this.cboEtatCivAgent);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cboSexeAgent);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtNomAgent);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPNomAgent);
            this.groupBox2.Controls.Add(this.txtPrenomAgent);
            this.groupBox2.Controls.Add(this.bnvAgent);
            this.groupBox2.Location = new System.Drawing.Point(3, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(766, 287);
            this.groupBox2.TabIndex = 136;
            this.groupBox2.TabStop = false;
            // 
            // lblLoadPhoto
            // 
            this.lblLoadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblLoadPhoto.Location = new System.Drawing.Point(331, 186);
            this.lblLoadPhoto.Name = "lblLoadPhoto";
            this.lblLoadPhoto.Size = new System.Drawing.Size(103, 50);
            this.lblLoadPhoto.TabIndex = 192;
            this.lblLoadPhoto.TabStop = true;
            this.lblLoadPhoto.Text = "Ajouter une photo";
            this.lblLoadPhoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLoadPhoto.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLoadPhoto_LinkClicked);
            // 
            // pbPhotoPersonne
            // 
            this.pbPhotoPersonne.BackColor = System.Drawing.SystemColors.Control;
            this.pbPhotoPersonne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPhotoPersonne.InitialImage = null;
            this.pbPhotoPersonne.Location = new System.Drawing.Point(322, 50);
            this.pbPhotoPersonne.Name = "pbPhotoPersonne";
            this.pbPhotoPersonne.Size = new System.Drawing.Size(122, 133);
            this.pbPhotoPersonne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhotoPersonne.TabIndex = 193;
            this.pbPhotoPersonne.TabStop = false;
            // 
            // txtDateNaissanceAgent
            // 
            this.txtDateNaissanceAgent.Location = new System.Drawing.Point(111, 164);
            this.txtDateNaissanceAgent.Name = "txtDateNaissanceAgent";
            this.txtDateNaissanceAgent.Size = new System.Drawing.Size(203, 20);
            this.txtDateNaissanceAgent.TabIndex = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 146;
            this.label2.Text = "Code :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(111, 51);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(205, 20);
            this.txtId.TabIndex = 145;
            // 
            // dgvAgent
            // 
            this.dgvAgent.AllowUserToAddRows = false;
            this.dgvAgent.AllowUserToDeleteRows = false;
            this.dgvAgent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgent.Location = new System.Drawing.Point(452, 51);
            this.dgvAgent.MultiSelect = false;
            this.dgvAgent.Name = "dgvAgent";
            this.dgvAgent.ReadOnly = true;
            this.dgvAgent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAgent.Size = new System.Drawing.Size(311, 229);
            this.dgvAgent.TabIndex = 144;
            this.dgvAgent.SelectionChanged += new System.EventHandler(this.dgvAgent_SelectionChanged);
            // 
            // cmbRechercheAgent
            // 
            this.cmbRechercheAgent.DropDownWidth = 300;
            this.cmbRechercheAgent.FormattingEnabled = true;
            this.cmbRechercheAgent.Location = new System.Drawing.Point(620, 18);
            this.cmbRechercheAgent.Name = "cmbRechercheAgent";
            this.cmbRechercheAgent.Size = new System.Drawing.Size(141, 21);
            this.cmbRechercheAgent.TabIndex = 141;
            this.cmbRechercheAgent.SelectedIndexChanged += new System.EventHandler(this.cmbRechercheAgent_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.Control;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label23.Location = new System.Drawing.Point(546, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 140;
            this.label23.Text = "Rechercher:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Télephone :";
            // 
            // txtTelephoneAgent
            // 
            this.txtTelephoneAgent.Location = new System.Drawing.Point(109, 260);
            this.txtTelephoneAgent.Name = "txtTelephoneAgent";
            this.txtTelephoneAgent.Size = new System.Drawing.Size(207, 20);
            this.txtTelephoneAgent.TabIndex = 7;
            // 
            // cboEtatCivAgent
            // 
            this.cboEtatCivAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEtatCivAgent.FormattingEnabled = true;
            this.cboEtatCivAgent.Location = new System.Drawing.Point(109, 227);
            this.cboEtatCivAgent.Name = "cboEtatCivAgent";
            this.cboEtatCivAgent.Size = new System.Drawing.Size(181, 21);
            this.cboEtatCivAgent.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 119;
            this.label15.Text = "Etat civil :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Date de naissance :";
            // 
            // cboSexeAgent
            // 
            this.cboSexeAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexeAgent.FormattingEnabled = true;
            this.cboSexeAgent.Location = new System.Drawing.Point(110, 196);
            this.cboSexeAgent.Name = "cboSexeAgent";
            this.cboSexeAgent.Size = new System.Drawing.Size(181, 21);
            this.cboSexeAgent.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 118;
            this.label5.Text = "Sexe :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prénom :";
            // 
            // txtNomAgent
            // 
            this.txtNomAgent.Location = new System.Drawing.Point(111, 75);
            this.txtNomAgent.Name = "txtNomAgent";
            this.txtNomAgent.Size = new System.Drawing.Size(205, 20);
            this.txtNomAgent.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Post - nom :";
            // 
            // txtPNomAgent
            // 
            this.txtPNomAgent.Location = new System.Drawing.Point(110, 104);
            this.txtPNomAgent.Name = "txtPNomAgent";
            this.txtPNomAgent.Size = new System.Drawing.Size(206, 20);
            this.txtPNomAgent.TabIndex = 3;
            // 
            // txtPrenomAgent
            // 
            this.txtPrenomAgent.Location = new System.Drawing.Point(110, 135);
            this.txtPrenomAgent.Name = "txtPrenomAgent";
            this.txtPrenomAgent.Size = new System.Drawing.Size(206, 20);
            this.txtPrenomAgent.TabIndex = 4;
            // 
            // bnvAgent
            // 
            this.bnvAgent.AddNewItem = null;
            this.bnvAgent.BackColor = System.Drawing.Color.Transparent;
            this.bnvAgent.CountItem = null;
            this.bnvAgent.DeleteItem = null;
            this.bnvAgent.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnvAgent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddAgent,
            this.btnRefreshAgent,
            this.btnSaveAgent,
            this.btnModifierAgent,
            this.btnDeleteAgent});
            this.bnvAgent.Location = new System.Drawing.Point(3, 16);
            this.bnvAgent.MoveFirstItem = null;
            this.bnvAgent.MoveLastItem = null;
            this.bnvAgent.MoveNextItem = null;
            this.bnvAgent.MovePreviousItem = null;
            this.bnvAgent.Name = "bnvAgent";
            this.bnvAgent.PositionItem = null;
            this.bnvAgent.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bnvAgent.Size = new System.Drawing.Size(760, 25);
            this.bnvAgent.TabIndex = 147;
            this.bnvAgent.Text = "bindingNavigator1";
            // 
            // btnAddAgent
            // 
            this.btnAddAgent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddAgent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAgent.Image")));
            this.btnAddAgent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddAgent.Name = "btnAddAgent";
            this.btnAddAgent.Size = new System.Drawing.Size(23, 22);
            this.btnAddAgent.Text = "Ajouter";
            this.btnAddAgent.Click += new System.EventHandler(this.btnAddAgent_Click);
            // 
            // btnRefreshAgent
            // 
            this.btnRefreshAgent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshAgent.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshAgent.Image")));
            this.btnRefreshAgent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshAgent.Name = "btnRefreshAgent";
            this.btnRefreshAgent.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshAgent.Text = "Refresh";
            this.btnRefreshAgent.Click += new System.EventHandler(this.btnRefreshAgent_Click);
            // 
            // btnSaveAgent
            // 
            this.btnSaveAgent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveAgent.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveAgent.Image")));
            this.btnSaveAgent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveAgent.Name = "btnSaveAgent";
            this.btnSaveAgent.Size = new System.Drawing.Size(23, 22);
            this.btnSaveAgent.Text = "Enregistrer";
            this.btnSaveAgent.Click += new System.EventHandler(this.btnSaveAgent_Click);
            // 
            // btnModifierAgent
            // 
            this.btnModifierAgent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModifierAgent.Image = ((System.Drawing.Image)(resources.GetObject("btnModifierAgent.Image")));
            this.btnModifierAgent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifierAgent.Name = "btnModifierAgent";
            this.btnModifierAgent.Size = new System.Drawing.Size(23, 22);
            this.btnModifierAgent.Text = "Modifier";
            this.btnModifierAgent.Click += new System.EventHandler(this.btnModifierAgent_Click);
            // 
            // btnDeleteAgent
            // 
            this.btnDeleteAgent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteAgent.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAgent.Image")));
            this.btnDeleteAgent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteAgent.Name = "btnDeleteAgent";
            this.btnDeleteAgent.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteAgent.Text = "Supprimer";
            this.btnDeleteAgent.Click += new System.EventHandler(this.btnDeleteAgent_Click);
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
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 1);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator2.Size = new System.Drawing.Size(766, 26);
            this.bindingNavigator2.TabIndex = 149;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // btnCloseLoadDb
            // 
            this.btnCloseLoadDb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCloseLoadDb.BackColor = System.Drawing.SystemColors.Control;
            this.btnCloseLoadDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCloseLoadDb.Image = global::GestionCoopec.Properties.Resources.StdClearButton;
            this.btnCloseLoadDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCloseLoadDb.Name = "btnCloseLoadDb";
            this.btnCloseLoadDb.Size = new System.Drawing.Size(23, 23);
            this.btnCloseLoadDb.Text = "Quitter";
            this.btnCloseLoadDb.Click += new System.EventHandler(this.btnCloseLoadDb_Click);
            // 
            // dlgFile
            // 
            this.dlgFile.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 311);
            this.panel1.TabIndex = 150;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(341, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 20);
            this.label6.TabIndex = 151;
            this.label6.Text = "Agent";
            // 
            // AgentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 311);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AgentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agent";
            this.Load += new System.EventHandler(this.AgentForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotoPersonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAgent)).EndInit();
            this.bnvAgent.ResumeLayout(false);
            this.bnvAgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvAgent;
        private System.Windows.Forms.ComboBox cmbRechercheAgent;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelephoneAgent;
        private System.Windows.Forms.ComboBox cboEtatCivAgent;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSexeAgent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomAgent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPNomAgent;
        private System.Windows.Forms.TextBox txtPrenomAgent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.BindingNavigator bnvAgent;
        private System.Windows.Forms.ToolStripButton btnAddAgent;
        private System.Windows.Forms.ToolStripButton btnRefreshAgent;
        private System.Windows.Forms.ToolStripButton btnSaveAgent;
        private System.Windows.Forms.ToolStripButton btnModifierAgent;
        private System.Windows.Forms.ToolStripButton btnDeleteAgent;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton btnCloseLoadDb;
        private System.Windows.Forms.DateTimePicker txtDateNaissanceAgent;
        private System.Windows.Forms.LinkLabel lblLoadPhoto;
        private System.Windows.Forms.PictureBox pbPhotoPersonne;
        private System.Windows.Forms.OpenFileDialog dlgFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
    }
}