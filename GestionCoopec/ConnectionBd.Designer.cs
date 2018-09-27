namespace GestionCoopec
{
    partial class ConnectionBd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionBd));
            this.txtCheminAcces = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdLoad = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.btnCloseLoadDb = new System.Windows.Forms.ToolStripButton();
            this.dlgOpen = new System.Windows.Forms.OpenFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCheminAcces
            // 
            this.txtCheminAcces.Location = new System.Drawing.Point(5, 92);
            this.txtCheminAcces.Name = "txtCheminAcces";
            this.txtCheminAcces.Size = new System.Drawing.Size(342, 20);
            this.txtCheminAcces.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 30);
            this.label1.TabIndex = 82;
            this.label1.Text = "Veuillez choisir l\'emplacement de la Base des données";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdLoad
            // 
            this.cmdLoad.Image = global::GestionCoopec.Properties.Resources.xtc1;
            this.cmdLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdLoad.Location = new System.Drawing.Point(354, 91);
            this.cmdLoad.Name = "cmdLoad";
            this.cmdLoad.Size = new System.Drawing.Size(73, 23);
            this.cmdLoad.TabIndex = 85;
            this.cmdLoad.Text = "&Charger";
            this.cmdLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cmdLoad.UseVisualStyleBackColor = true;
            this.cmdLoad.Click += new System.EventHandler(this.cmdLoad_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Image = ((System.Drawing.Image)(resources.GetObject("cmdOk.Image")));
            this.cmdOk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdOk.Location = new System.Drawing.Point(431, 91);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(90, 23);
            this.cmdOk.TabIndex = 84;
            this.cmdOk.Text = "      &Connexion";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
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
            this.bindingNavigator2.Location = new System.Drawing.Point(4, 2);
            this.bindingNavigator2.MoveFirstItem = null;
            this.bindingNavigator2.MoveLastItem = null;
            this.bindingNavigator2.MoveNextItem = null;
            this.bindingNavigator2.MovePreviousItem = null;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator2.Size = new System.Drawing.Size(523, 25);
            this.bindingNavigator2.TabIndex = 81;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // btnCloseLoadDb
            // 
            this.btnCloseLoadDb.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCloseLoadDb.BackColor = System.Drawing.Color.Transparent;
            this.btnCloseLoadDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCloseLoadDb.Image = global::GestionCoopec.Properties.Resources.StdClearButton;
            this.btnCloseLoadDb.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCloseLoadDb.Name = "btnCloseLoadDb";
            this.btnCloseLoadDb.Size = new System.Drawing.Size(23, 22);
            this.btnCloseLoadDb.Text = "Quitter";
            this.btnCloseLoadDb.Click += new System.EventHandler(this.btnCloseLoadDb_Click);
            // 
            // dlgOpen
            // 
            this.dlgOpen.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmdLoad);
            this.panel1.Controls.Add(this.bindingNavigator2);
            this.panel1.Controls.Add(this.cmdOk);
            this.panel1.Controls.Add(this.txtCheminAcces);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(530, 130);
            this.panel1.TabIndex = 86;
            // 
            // ConnectionBd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(530, 130);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConnectionBd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConnectionBd";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdLoad;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.TextBox txtCheminAcces;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripButton btnCloseLoadDb;
        private System.Windows.Forms.OpenFileDialog dlgOpen;
        private System.Windows.Forms.Panel panel1;
    }
}