namespace GestionCoopec
{
    partial class ListeAgent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListeAgent));
            this.crvListeClient = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboAgent = new System.Windows.Forms.ComboBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.chkTous = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvListeClient
            // 
            this.crvListeClient.ActiveViewIndex = -1;
            this.crvListeClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvListeClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvListeClient.Location = new System.Drawing.Point(0, 25);
            this.crvListeClient.Name = "crvListeClient";
            this.crvListeClient.SelectionFormula = "";
            this.crvListeClient.Size = new System.Drawing.Size(1022, 401);
            this.crvListeClient.TabIndex = 105;
            this.crvListeClient.ViewTimeSelectionFormula = "";
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.AutoSize = false;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btClose});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = null;
            this.bindingNavigator1.Size = new System.Drawing.Size(1022, 25);
            this.bindingNavigator1.TabIndex = 104;
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
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 426);
            this.panel1.TabIndex = 106;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cboAgent);
            this.groupBox1.Controls.Add(this.cmdOk);
            this.groupBox1.Controls.Add(this.chkTous);
            this.groupBox1.Location = new System.Drawing.Point(7, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 100);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sélectionon agent";
            // 
            // cboAgent
            // 
            this.cboAgent.FormattingEnabled = true;
            this.cboAgent.Location = new System.Drawing.Point(3, 45);
            this.cboAgent.Name = "cboAgent";
            this.cboAgent.Size = new System.Drawing.Size(187, 21);
            this.cboAgent.TabIndex = 2;
            this.cboAgent.SelectedIndexChanged += new System.EventHandler(this.cboAgent_SelectedIndexChanged);
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(4, 71);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(45, 22);
            this.cmdOk.TabIndex = 1;
            this.cmdOk.Text = "&Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // chkTous
            // 
            this.chkTous.AutoSize = true;
            this.chkTous.Location = new System.Drawing.Point(6, 20);
            this.chkTous.Name = "chkTous";
            this.chkTous.Size = new System.Drawing.Size(91, 17);
            this.chkTous.TabIndex = 0;
            this.chkTous.Text = "Tous/Un seul";
            this.chkTous.UseVisualStyleBackColor = true;
            this.chkTous.CheckedChanged += new System.EventHandler(this.chkTous_CheckedChanged);
            // 
            // ListeAgent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 426);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crvListeClient);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListeAgent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListeAgent";
            this.Load += new System.EventHandler(this.ListeAgent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvListeClient;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton btClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboAgent;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.CheckBox chkTous;
    }
}