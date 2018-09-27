namespace GestionCoopec
{
    partial class Utilisateur
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.tbUser = new System.Windows.Forms.TabControl();
            this.tbNewUse = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategorie = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmdAddUser = new System.Windows.Forms.Button();
            this.cmdDeleteUser = new System.Windows.Forms.Button();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.cmdSaveUser = new System.Windows.Forms.Button();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboAgent = new System.Windows.Forms.ComboBox();
            this.tabModifier = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.btClearUserName = new System.Windows.Forms.Button();
            this.btModifierUserName = new System.Windows.Forms.Button();
            this.cboUser = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtOldUserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.tbUser.SuspendLayout();
            this.tbNewUse.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.tabModifier.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.AutoSize = false;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose});
            this.bindingNavigator2.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.bindingNavigator2.Size = new System.Drawing.Size(676, 25);
            this.bindingNavigator2.TabIndex = 151;
            this.bindingNavigator2.Text = "bindingNavigator2";
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
            // tbUser
            // 
            this.tbUser.Controls.Add(this.tbNewUse);
            this.tbUser.Controls.Add(this.tabModifier);
            this.tbUser.Location = new System.Drawing.Point(7, 30);
            this.tbUser.Name = "tbUser";
            this.tbUser.SelectedIndex = 0;
            this.tbUser.Size = new System.Drawing.Size(661, 258);
            this.tbUser.TabIndex = 152;
            // 
            // tbNewUse
            // 
            this.tbNewUse.BackColor = System.Drawing.Color.Transparent;
            this.tbNewUse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbNewUse.Controls.Add(this.groupBox9);
            this.tbNewUse.Location = new System.Drawing.Point(4, 22);
            this.tbNewUse.Name = "tbNewUse";
            this.tbNewUse.Padding = new System.Windows.Forms.Padding(3);
            this.tbNewUse.Size = new System.Drawing.Size(653, 232);
            this.tbNewUse.TabIndex = 0;
            this.tbNewUse.Text = "Nouveau";
            this.tbNewUse.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label3);
            this.groupBox9.Controls.Add(this.cboCategorie);
            this.groupBox9.Controls.Add(this.groupBox8);
            this.groupBox9.Controls.Add(this.cmdAddUser);
            this.groupBox9.Controls.Add(this.cmdDeleteUser);
            this.groupBox9.Controls.Add(this.dgvUser);
            this.groupBox9.Controls.Add(this.cmdSaveUser);
            this.groupBox9.Controls.Add(this.lblIdUser);
            this.groupBox9.Controls.Add(this.label5);
            this.groupBox9.Controls.Add(this.label2);
            this.groupBox9.Controls.Add(this.cboAgent);
            this.groupBox9.Location = new System.Drawing.Point(9, 0);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(638, 229);
            this.groupBox9.TabIndex = 93;
            this.groupBox9.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 94;
            this.label3.Text = "Catégorie :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboCategorie
            // 
            this.cboCategorie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategorie.FormattingEnabled = true;
            this.cboCategorie.Location = new System.Drawing.Point(106, 46);
            this.cboCategorie.Name = "cboCategorie";
            this.cboCategorie.Size = new System.Drawing.Size(199, 21);
            this.cboCategorie.TabIndex = 0;
            this.cboCategorie.SelectedIndexChanged += new System.EventHandler(this.cboCategorie_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.lblConfirmPwd);
            this.groupBox8.Controls.Add(this.txtConfirmPwd);
            this.groupBox8.Controls.Add(this.label7);
            this.groupBox8.Controls.Add(this.txtPwd);
            this.groupBox8.Controls.Add(this.txtUserName);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Location = new System.Drawing.Point(313, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(325, 97);
            this.groupBox8.TabIndex = 92;
            this.groupBox8.TabStop = false;
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.AutoSize = true;
            this.lblConfirmPwd.Location = new System.Drawing.Point(8, 69);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(121, 13);
            this.lblConfirmPwd.TabIndex = 86;
            this.lblConfirmPwd.Text = "Confirme Mot de passe :";
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Location = new System.Drawing.Point(132, 65);
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(188, 20);
            this.txtConfirmPwd.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Mot de passe :";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(132, 39);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(188, 20);
            this.txtPwd.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(132, 13);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(188, 20);
            this.txtUserName.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Nom d\'Utilisateur :";
            // 
            // cmdAddUser
            // 
            this.cmdAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmdAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAddUser.Location = new System.Drawing.Point(3, 197);
            this.cmdAddUser.Name = "cmdAddUser";
            this.cmdAddUser.Size = new System.Drawing.Size(68, 22);
            this.cmdAddUser.TabIndex = 5;
            this.cmdAddUser.Text = "&Ajouter";
            this.cmdAddUser.UseVisualStyleBackColor = true;
            this.cmdAddUser.Click += new System.EventHandler(this.cmdAddUser_Click);
            // 
            // cmdDeleteUser
            // 
            this.cmdDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdDeleteUser.ForeColor = System.Drawing.Color.Navy;
            this.cmdDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDeleteUser.Location = new System.Drawing.Point(236, 195);
            this.cmdDeleteUser.Name = "cmdDeleteUser";
            this.cmdDeleteUser.Size = new System.Drawing.Size(68, 23);
            this.cmdDeleteUser.TabIndex = 8;
            this.cmdDeleteUser.Text = "Supprimer";
            this.cmdDeleteUser.UseVisualStyleBackColor = true;
            this.cmdDeleteUser.Click += new System.EventHandler(this.cmdDeleteUser_Click);
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToAddRows = false;
            this.dgvUser.AllowUserToDeleteRows = false;
            this.dgvUser.BackgroundColor = System.Drawing.Color.White;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Location = new System.Drawing.Point(3, 99);
            this.dgvUser.MultiSelect = false;
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUser.Size = new System.Drawing.Size(301, 88);
            this.dgvUser.TabIndex = 9;
            this.dgvUser.SelectionChanged += new System.EventHandler(this.dgvUser_SelectionChanged);
            // 
            // cmdSaveUser
            // 
            this.cmdSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdSaveUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.cmdSaveUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdSaveUser.Location = new System.Drawing.Point(117, 195);
            this.cmdSaveUser.Name = "cmdSaveUser";
            this.cmdSaveUser.Size = new System.Drawing.Size(74, 23);
            this.cmdSaveUser.TabIndex = 6;
            this.cmdSaveUser.Text = "&Enregistrer";
            this.cmdSaveUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdSaveUser.UseVisualStyleBackColor = true;
            this.cmdSaveUser.Click += new System.EventHandler(this.cmdSaveUser_Click);
            // 
            // lblIdUser
            // 
            this.lblIdUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdUser.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblIdUser.Location = new System.Drawing.Point(105, 19);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(106, 21);
            this.lblIdUser.TabIndex = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Code:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "Agent :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboAgent
            // 
            this.cboAgent.FormattingEnabled = true;
            this.cboAgent.Location = new System.Drawing.Point(106, 73);
            this.cboAgent.Name = "cboAgent";
            this.cboAgent.Size = new System.Drawing.Size(199, 21);
            this.cboAgent.TabIndex = 1;
            this.cboAgent.SelectedIndexChanged += new System.EventHandler(this.cboAgent_SelectedIndexChanged);
            // 
            // tabModifier
            // 
            this.tabModifier.BackColor = System.Drawing.Color.Transparent;
            this.tabModifier.Controls.Add(this.label20);
            this.tabModifier.Controls.Add(this.label19);
            this.tabModifier.Controls.Add(this.groupBox4);
            this.tabModifier.Location = new System.Drawing.Point(4, 22);
            this.tabModifier.Name = "tabModifier";
            this.tabModifier.Padding = new System.Windows.Forms.Padding(3);
            this.tabModifier.Size = new System.Drawing.Size(653, 232);
            this.tabModifier.TabIndex = 1;
            this.tabModifier.Text = "Modifier";
            this.tabModifier.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Location = new System.Drawing.Point(149, 32);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(176, 15);
            this.label20.TabIndex = 82;
            this.label20.Text = " Modification  du nom de l\'utilisateur";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(139, 13);
            this.label19.TabIndex = 81;
            this.label19.Text = "Que voulait vous faire?";
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Controls.Add(this.txtNewUserName);
            this.groupBox4.Controls.Add(this.btClearUserName);
            this.groupBox4.Controls.Add(this.btModifierUserName);
            this.groupBox4.Controls.Add(this.cboUser);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Controls.Add(this.txtOldUserName);
            this.groupBox4.Location = new System.Drawing.Point(118, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(456, 196);
            this.groupBox4.TabIndex = 75;
            this.groupBox4.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 79;
            this.label1.Text = "Utilisateur :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(29, 102);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(135, 13);
            this.label24.TabIndex = 73;
            this.label24.Text = "Nouveau nom d\'utilisateur :";
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.Location = new System.Drawing.Point(183, 99);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(254, 20);
            this.txtNewUserName.TabIndex = 2;
            // 
            // btClearUserName
            // 
            this.btClearUserName.Location = new System.Drawing.Point(124, 143);
            this.btClearUserName.Name = "btClearUserName";
            this.btClearUserName.Size = new System.Drawing.Size(87, 23);
            this.btClearUserName.TabIndex = 4;
            this.btClearUserName.Text = "Effa&cer";
            this.btClearUserName.UseVisualStyleBackColor = true;
            this.btClearUserName.Click += new System.EventHandler(this.btClearUserName_Click);
            // 
            // btModifierUserName
            // 
            this.btModifierUserName.Location = new System.Drawing.Point(31, 143);
            this.btModifierUserName.Name = "btModifierUserName";
            this.btModifierUserName.Size = new System.Drawing.Size(87, 23);
            this.btModifierUserName.TabIndex = 3;
            this.btModifierUserName.Text = "&Ok";
            this.btModifierUserName.UseVisualStyleBackColor = true;
            this.btModifierUserName.Click += new System.EventHandler(this.btModifierUserName_Click);
            // 
            // cboUser
            // 
            this.cboUser.FormattingEnabled = true;
            this.cboUser.Items.AddRange(new object[] {
            "Masculin",
            "Feminin"});
            this.cboUser.Location = new System.Drawing.Point(182, 38);
            this.cboUser.Name = "cboUser";
            this.cboUser.Size = new System.Drawing.Size(254, 21);
            this.cboUser.TabIndex = 0;
            this.cboUser.SelectedIndexChanged += new System.EventHandler(this.cboUser_SelectedIndexChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(28, 71);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(124, 13);
            this.label25.TabIndex = 70;
            this.label25.Text = "Ancien nom d\'utilisateur :";
            // 
            // txtOldUserName
            // 
            this.txtOldUserName.Location = new System.Drawing.Point(183, 68);
            this.txtOldUserName.Name = "txtOldUserName";
            this.txtOldUserName.Size = new System.Drawing.Size(254, 20);
            this.txtOldUserName.TabIndex = 1;
            // 
            // Utilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 294);
            this.ControlBox = false;
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.bindingNavigator2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Utilisateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UtilisateurForm";
            this.Load += new System.EventHandler(this.UtilisateurForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.tbUser.ResumeLayout(false);
            this.tbNewUse.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.tabModifier.ResumeLayout(false);
            this.tabModifier.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.TabControl tbUser;
        private System.Windows.Forms.TabPage tbNewUse;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblConfirmPwd;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cmdAddUser;
        private System.Windows.Forms.Button cmdDeleteUser;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.Button cmdSaveUser;
        private System.Windows.Forms.Label lblIdUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboAgent;
        private System.Windows.Forms.TabPage tabModifier;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtNewUserName;
        private System.Windows.Forms.Button btClearUserName;
        private System.Windows.Forms.Button btModifierUserName;
        private System.Windows.Forms.ComboBox cboUser;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtOldUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategorie;

    }
}