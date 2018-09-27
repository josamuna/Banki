namespace GestionCoopec
{
    partial class Authentification
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
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.cmdBd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 56;
            this.label5.Text = "Nom d\'utilisateur :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 57;
            this.label2.Text = "Mot de passe  :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(103, 11);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(172, 20);
            this.txtUserName.TabIndex = 58;
            this.txtUserName.Enter += new System.EventHandler(this.txtUserName_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(104, 41);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '>';
            this.txtPassword.Size = new System.Drawing.Size(171, 20);
            this.txtPassword.TabIndex = 59;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // cmdOk
            // 
            this.cmdOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdOk.ForeColor = System.Drawing.Color.Navy;
            this.cmdOk.Location = new System.Drawing.Point(12, 77);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(83, 24);
            this.cmdOk.TabIndex = 60;
            this.cmdOk.Text = "&Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdAnnuler.ForeColor = System.Drawing.Color.Navy;
            this.cmdAnnuler.Location = new System.Drawing.Point(101, 77);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(81, 24);
            this.cmdAnnuler.TabIndex = 61;
            this.cmdAnnuler.Text = "&Fermer";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            this.cmdAnnuler.Click += new System.EventHandler(this.cmdAnnuler_Click);
            // 
            // cmdBd
            // 
            this.cmdBd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBd.ForeColor = System.Drawing.Color.Green;
            this.cmdBd.Image = global::GestionCoopec.Properties.Resources.xtc1;
            this.cmdBd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBd.Location = new System.Drawing.Point(188, 76);
            this.cmdBd.Name = "cmdBd";
            this.cmdBd.Size = new System.Drawing.Size(86, 25);
            this.cmdBd.TabIndex = 62;
            this.cmdBd.Text = "     >>>>>";
            this.cmdBd.UseVisualStyleBackColor = true;
            this.cmdBd.Click += new System.EventHandler(this.cmdBd_Click);
            // 
            // Authentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 109);
            this.ControlBox = false;
            this.Controls.Add(this.cmdBd);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Authentification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentification de l\'utilisateur";
            this.Load += new System.EventHandler(this.Authentification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdAnnuler;
        private System.Windows.Forms.Button cmdBd;
    }
}