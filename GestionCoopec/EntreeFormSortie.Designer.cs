namespace GestionCoopec
{
    partial class EntreeFormSortie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntreeFormSortie));
            this.crvEntree = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdFc = new System.Windows.Forms.RadioButton();
            this.rdUsd = new System.Windows.Forms.RadioButton();
            this.chk = new System.Windows.Forms.CheckBox();
            this.dtEntree = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboClient = new System.Windows.Forms.ComboBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvEntree
            // 
            this.crvEntree.ActiveViewIndex = -1;
            this.crvEntree.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvEntree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvEntree.Location = new System.Drawing.Point(0, 25);
            this.crvEntree.Name = "crvEntree";
            this.crvEntree.SelectionFormula = "";
            this.crvEntree.Size = new System.Drawing.Size(1005, 445);
            this.crvEntree.TabIndex = 0;
            this.crvEntree.ViewTimeSelectionFormula = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.chk);
            this.panel1.Controls.Add(this.dtEntree);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAfficher);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cboClient);
            this.panel1.Location = new System.Drawing.Point(3, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 216);
            this.panel1.TabIndex = 111;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdFc);
            this.groupBox1.Controls.Add(this.rdUsd);
            this.groupBox1.Location = new System.Drawing.Point(4, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 41);
            this.groupBox1.TabIndex = 117;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type de Compte";
            // 
            // rdFc
            // 
            this.rdFc.AutoSize = true;
            this.rdFc.Location = new System.Drawing.Point(14, 17);
            this.rdFc.Name = "rdFc";
            this.rdFc.Size = new System.Drawing.Size(38, 17);
            this.rdFc.TabIndex = 118;
            this.rdFc.TabStop = true;
            this.rdFc.Text = "FC";
            this.rdFc.UseVisualStyleBackColor = true;
            // 
            // rdUsd
            // 
            this.rdUsd.AutoSize = true;
            this.rdUsd.Location = new System.Drawing.Point(111, 15);
            this.rdUsd.Name = "rdUsd";
            this.rdUsd.Size = new System.Drawing.Size(48, 17);
            this.rdUsd.TabIndex = 116;
            this.rdUsd.TabStop = true;
            this.rdUsd.Text = "USD";
            this.rdUsd.UseVisualStyleBackColor = true;
            // 
            // chk
            // 
            this.chk.AutoSize = true;
            this.chk.Location = new System.Drawing.Point(10, 107);
            this.chk.Name = "chk";
            this.chk.Size = new System.Drawing.Size(50, 17);
            this.chk.TabIndex = 111;
            this.chk.Text = "Tous";
            this.chk.UseVisualStyleBackColor = true;
            this.chk.CheckedChanged += new System.EventHandler(this.chk_CheckedChanged);
            // 
            // dtEntree
            // 
            this.dtEntree.Location = new System.Drawing.Point(6, 76);
            this.dtEntree.Name = "dtEntree";
            this.dtEntree.Size = new System.Drawing.Size(170, 20);
            this.dtEntree.TabIndex = 110;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Choix de la date:";
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(8, 188);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(75, 23);
            this.btnAfficher.TabIndex = 107;
            this.btnAfficher.Text = "Afficher";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 106;
            this.label1.Text = "Choix du client:";
            // 
            // cboClient
            // 
            this.cboClient.FormattingEnabled = true;
            this.cboClient.Location = new System.Drawing.Point(6, 37);
            this.cboClient.Name = "cboClient";
            this.cboClient.Size = new System.Drawing.Size(170, 21);
            this.cboClient.TabIndex = 105;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btClose});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1005, 25);
            this.bindingNavigator1.TabIndex = 112;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bindingNavigator1_MouseUp);
            this.bindingNavigator1.DoubleClick += new System.EventHandler(this.bindingNavigator1_DoubleClick);
            this.bindingNavigator1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bindingNavigator1_MouseDown);
            this.bindingNavigator1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.bindingNavigator1_MouseMove);
            // 
            // btClose
            // 
            this.btClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btClose.BackColor = System.Drawing.Color.Transparent;
            this.btClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btClose.Image = global::GestionCoopec.Properties.Resources.StdClearButton;
            this.btClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(23, 22);
            this.btClose.Text = "toolStripButton1";
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1005, 470);
            this.panel2.TabIndex = 113;
            // 
            // EntreeFormSortie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.crvEntree);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntreeFormSortie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EntreeFormSortie";
            this.Load += new System.EventHandler(this.EntreeFormSortie_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvEntree;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtEntree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboClient;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.CheckBox chk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdFc;
        private System.Windows.Forms.RadioButton rdUsd;

    }
}