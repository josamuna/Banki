namespace GestionCoopec
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.txtDateNaissanceClient = new System.Windows.Forms.GroupBox();
            this.lblLoadPhoto = new System.Windows.Forms.LinkLabel();
            this.pbPhotoPersonne = new System.Windows.Forms.PictureBox();
            this.txtDateNaissanceCli = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblFormAgent = new System.Windows.Forms.Label();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.cboAgent = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbRechercheClient = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.bnvAgent = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnAddClient = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshClient = new System.Windows.Forms.ToolStripButton();
            this.btnSaveClient = new System.Windows.Forms.ToolStripButton();
            this.btnModifierClient = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteClient = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelephoneClient = new System.Windows.Forms.TextBox();
            this.cboEtatCivClient = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSexeClient = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomClient = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPNomClient = new System.Windows.Forms.TextBox();
            this.txtPrenomClient = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.dlgFile = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDateNaissanceClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotoPersonne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAgent)).BeginInit();
            this.bnvAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDateNaissanceClient
            // 
            this.txtDateNaissanceClient.BackColor = System.Drawing.SystemColors.Control;
            this.txtDateNaissanceClient.Controls.Add(this.lblLoadPhoto);
            this.txtDateNaissanceClient.Controls.Add(this.pbPhotoPersonne);
            this.txtDateNaissanceClient.Controls.Add(this.txtDateNaissanceCli);
            this.txtDateNaissanceClient.Controls.Add(this.label7);
            this.txtDateNaissanceClient.Controls.Add(this.txtId);
            this.txtDateNaissanceClient.Controls.Add(this.lblFormAgent);
            this.txtDateNaissanceClient.Controls.Add(this.dgvClient);
            this.txtDateNaissanceClient.Controls.Add(this.cboAgent);
            this.txtDateNaissanceClient.Controls.Add(this.label2);
            this.txtDateNaissanceClient.Controls.Add(this.cmbRechercheClient);
            this.txtDateNaissanceClient.Controls.Add(this.label23);
            this.txtDateNaissanceClient.Controls.Add(this.bnvAgent);
            this.txtDateNaissanceClient.Controls.Add(this.label1);
            this.txtDateNaissanceClient.Controls.Add(this.txtTelephoneClient);
            this.txtDateNaissanceClient.Controls.Add(this.cboEtatCivClient);
            this.txtDateNaissanceClient.Controls.Add(this.label15);
            this.txtDateNaissanceClient.Controls.Add(this.label8);
            this.txtDateNaissanceClient.Controls.Add(this.cboSexeClient);
            this.txtDateNaissanceClient.Controls.Add(this.label5);
            this.txtDateNaissanceClient.Controls.Add(this.label11);
            this.txtDateNaissanceClient.Controls.Add(this.label4);
            this.txtDateNaissanceClient.Controls.Add(this.txtNomClient);
            this.txtDateNaissanceClient.Controls.Add(this.label3);
            this.txtDateNaissanceClient.Controls.Add(this.txtPNomClient);
            this.txtDateNaissanceClient.Controls.Add(this.txtPrenomClient);
            this.txtDateNaissanceClient.Location = new System.Drawing.Point(3, 18);
            this.txtDateNaissanceClient.Name = "txtDateNaissanceClient";
            this.txtDateNaissanceClient.Size = new System.Drawing.Size(766, 321);
            this.txtDateNaissanceClient.TabIndex = 135;
            this.txtDateNaissanceClient.TabStop = false;
            // 
            // lblLoadPhoto
            // 
            this.lblLoadPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadPhoto.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblLoadPhoto.Location = new System.Drawing.Point(348, 193);
            this.lblLoadPhoto.Name = "lblLoadPhoto";
            this.lblLoadPhoto.Size = new System.Drawing.Size(103, 50);
            this.lblLoadPhoto.TabIndex = 190;
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
            this.pbPhotoPersonne.Location = new System.Drawing.Point(339, 57);
            this.pbPhotoPersonne.Name = "pbPhotoPersonne";
            this.pbPhotoPersonne.Size = new System.Drawing.Size(122, 133);
            this.pbPhotoPersonne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPhotoPersonne.TabIndex = 191;
            this.pbPhotoPersonne.TabStop = false;
            // 
            // txtDateNaissanceCli
            // 
            this.txtDateNaissanceCli.Location = new System.Drawing.Point(119, 174);
            this.txtDateNaissanceCli.Name = "txtDateNaissanceCli";
            this.txtDateNaissanceCli.Size = new System.Drawing.Size(203, 20);
            this.txtDateNaissanceCli.TabIndex = 149;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 148;
            this.label7.Text = "Code :";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(117, 56);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(205, 20);
            this.txtId.TabIndex = 147;
            // 
            // lblFormAgent
            // 
            this.lblFormAgent.Image = global::GestionCoopec.Properties.Resources.AddFonct12;
            this.lblFormAgent.Location = new System.Drawing.Point(329, 265);
            this.lblFormAgent.Name = "lblFormAgent";
            this.lblFormAgent.Size = new System.Drawing.Size(20, 21);
            this.lblFormAgent.TabIndex = 145;
            this.lblFormAgent.Click += new System.EventHandler(this.lblFormAgent_Click);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(466, 53);
            this.dgvClient.MultiSelect = false;
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(295, 264);
            this.dgvClient.TabIndex = 144;
            this.dgvClient.SelectionChanged += new System.EventHandler(this.dgvClient_SelectionChanged);
            // 
            // cboAgent
            // 
            this.cboAgent.FormattingEnabled = true;
            this.cboAgent.Location = new System.Drawing.Point(115, 266);
            this.cboAgent.Name = "cboAgent";
            this.cboAgent.Size = new System.Drawing.Size(207, 21);
            this.cboAgent.TabIndex = 142;
            this.cboAgent.SelectedIndexChanged += new System.EventHandler(this.cboAgent_SelectedIndexChanged);
            this.cboAgent.DropDown += new System.EventHandler(this.cboAgent_DropDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 143;
            this.label2.Text = "Agent :";
            // 
            // cmbRechercheClient
            // 
            this.cmbRechercheClient.DropDownWidth = 300;
            this.cmbRechercheClient.FormattingEnabled = true;
            this.cmbRechercheClient.Location = new System.Drawing.Point(535, 18);
            this.cmbRechercheClient.Name = "cmbRechercheClient";
            this.cmbRechercheClient.Size = new System.Drawing.Size(226, 21);
            this.cmbRechercheClient.TabIndex = 141;
            this.cmbRechercheClient.SelectedIndexChanged += new System.EventHandler(this.cmbRechercheClient_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.SystemColors.Control;
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label23.Location = new System.Drawing.Point(463, 21);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 140;
            this.label23.Text = "Rechercher:";
            // 
            // bnvAgent
            // 
            this.bnvAgent.AddNewItem = null;
            this.bnvAgent.BackColor = System.Drawing.Color.Transparent;
            this.bnvAgent.CountItem = null;
            this.bnvAgent.DeleteItem = null;
            this.bnvAgent.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnvAgent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddClient,
            this.btnRefreshClient,
            this.btnSaveClient,
            this.btnModifierClient,
            this.btnDeleteClient});
            this.bnvAgent.Location = new System.Drawing.Point(3, 16);
            this.bnvAgent.MoveFirstItem = null;
            this.bnvAgent.MoveLastItem = null;
            this.bnvAgent.MoveNextItem = null;
            this.bnvAgent.MovePreviousItem = null;
            this.bnvAgent.Name = "bnvAgent";
            this.bnvAgent.PositionItem = null;
            this.bnvAgent.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bnvAgent.Size = new System.Drawing.Size(760, 25);
            this.bnvAgent.TabIndex = 108;
            this.bnvAgent.Text = "bindingNavigator1";
            // 
            // btnAddClient
            // 
            this.btnAddClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddClient.Image = ((System.Drawing.Image)(resources.GetObject("btnAddClient.Image")));
            this.btnAddClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(23, 22);
            this.btnAddClient.Text = "Ajouter";
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnRefreshClient
            // 
            this.btnRefreshClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshClient.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshClient.Image")));
            this.btnRefreshClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshClient.Name = "btnRefreshClient";
            this.btnRefreshClient.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshClient.Text = "Refresh";
            this.btnRefreshClient.Click += new System.EventHandler(this.btnRefreshClient_Click);
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveClient.Image = ((System.Drawing.Image)(resources.GetObject("btnSaveClient.Image")));
            this.btnSaveClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(23, 22);
            this.btnSaveClient.Text = "Enregistrer";
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnModifierClient.Image = ((System.Drawing.Image)(resources.GetObject("btnModifierClient.Image")));
            this.btnModifierClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(23, 22);
            this.btnModifierClient.Text = "Modifier";
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteClient.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteClient.Image")));
            this.btnDeleteClient.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(23, 22);
            this.btnDeleteClient.Text = "Supprimer";
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Télephone :";
            // 
            // txtTelephoneClient
            // 
            this.txtTelephoneClient.Location = new System.Drawing.Point(115, 294);
            this.txtTelephoneClient.Name = "txtTelephoneClient";
            this.txtTelephoneClient.Size = new System.Drawing.Size(207, 20);
            this.txtTelephoneClient.TabIndex = 7;
            // 
            // cboEtatCivClient
            // 
            this.cboEtatCivClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEtatCivClient.FormattingEnabled = true;
            this.cboEtatCivClient.Location = new System.Drawing.Point(115, 234);
            this.cboEtatCivClient.Name = "cboEtatCivClient";
            this.cboEtatCivClient.Size = new System.Drawing.Size(181, 21);
            this.cboEtatCivClient.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(15, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 119;
            this.label15.Text = "Etat civil :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 78;
            this.label8.Text = "Date de naissance :";
            // 
            // cboSexeClient
            // 
            this.cboSexeClient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexeClient.FormattingEnabled = true;
            this.cboSexeClient.Location = new System.Drawing.Point(116, 203);
            this.cboSexeClient.Name = "cboSexeClient";
            this.cboSexeClient.Size = new System.Drawing.Size(181, 21);
            this.cboSexeClient.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 118;
            this.label5.Text = "Sexe :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Nom :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Prénom :";
            // 
            // txtNomClient
            // 
            this.txtNomClient.Location = new System.Drawing.Point(117, 82);
            this.txtNomClient.Name = "txtNomClient";
            this.txtNomClient.Size = new System.Drawing.Size(205, 20);
            this.txtNomClient.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Post - nom :";
            // 
            // txtPNomClient
            // 
            this.txtPNomClient.Location = new System.Drawing.Point(116, 111);
            this.txtPNomClient.Name = "txtPNomClient";
            this.txtPNomClient.Size = new System.Drawing.Size(206, 20);
            this.txtPNomClient.TabIndex = 3;
            // 
            // txtPrenomClient
            // 
            this.txtPrenomClient.Location = new System.Drawing.Point(117, 139);
            this.txtPrenomClient.Name = "txtPrenomClient";
            this.txtPrenomClient.Size = new System.Drawing.Size(206, 20);
            this.txtPrenomClient.TabIndex = 4;
            // 
            // btnClose
            // 
            this.btnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClose.Image = global::GestionCoopec.Properties.Resources.StdClearButton;
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(23, 22);
            this.btnClose.Text = "Quitter";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
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
            this.btnClose});
            this.bindingNavigator2.Location = new System.Drawing.Point(3, 2);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator2.Size = new System.Drawing.Size(766, 25);
            this.bindingNavigator2.TabIndex = 150;
            this.bindingNavigator2.Text = "bindingNavigator2";
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
            this.panel1.Size = new System.Drawing.Size(772, 351);
            this.panel1.TabIndex = 151;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 351);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.txtDateNaissanceClient);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.txtDateNaissanceClient.ResumeLayout(false);
            this.txtDateNaissanceClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhotoPersonne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnvAgent)).EndInit();
            this.bnvAgent.ResumeLayout(false);
            this.bnvAgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox txtDateNaissanceClient;
        private System.Windows.Forms.ComboBox cmbRechercheClient;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTelephoneClient;
        private System.Windows.Forms.ComboBox cboEtatCivClient;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSexeClient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNomClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPNomClient;
        private System.Windows.Forms.TextBox txtPrenomClient;
        private System.Windows.Forms.ComboBox cboAgent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Label lblFormAgent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DateTimePicker txtDateNaissanceCli;
        private System.Windows.Forms.BindingNavigator bnvAgent;
        private System.Windows.Forms.ToolStripButton btnAddClient;
        private System.Windows.Forms.ToolStripButton btnRefreshClient;
        private System.Windows.Forms.ToolStripButton btnSaveClient;
        private System.Windows.Forms.ToolStripButton btnModifierClient;
        private System.Windows.Forms.ToolStripButton btnDeleteClient;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.LinkLabel lblLoadPhoto;
        private System.Windows.Forms.PictureBox pbPhotoPersonne;
        private System.Windows.Forms.OpenFileDialog dlgFile;
        private System.Windows.Forms.Panel panel1;
    }
}