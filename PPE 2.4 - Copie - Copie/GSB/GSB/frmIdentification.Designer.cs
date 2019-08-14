namespace GSB
{
    partial class frmIdentification
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label Label5;
            System.Windows.Forms.Label Label4;
            System.Windows.Forms.Label Label3;
            System.Windows.Forms.Label Label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIdentification));
            this.PN = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.tbxMdP = new System.Windows.Forms.TextBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tbxPort = new System.Windows.Forms.TextBox();
            this.tbxServeur = new System.Windows.Forms.TextBox();
            this.btEntrer = new System.Windows.Forms.Button();
            this.tbxLogin = new System.Windows.Forms.TextBox();
            this.lblTitre = new System.Windows.Forms.Label();
            Label5 = new System.Windows.Forms.Label();
            Label4 = new System.Windows.Forms.Label();
            Label3 = new System.Windows.Forms.Label();
            Label2 = new System.Windows.Forms.Label();
            this.PN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Label5
            // 
            Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            Label5.Location = new System.Drawing.Point(34, 97);
            Label5.Name = "Label5";
            Label5.Size = new System.Drawing.Size(106, 28);
            Label5.TabIndex = 2;
            Label5.Text = "Port :";
            Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label4
            // 
            Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label4.ForeColor = System.Drawing.Color.DarkSlateGray;
            Label4.Location = new System.Drawing.Point(4, 67);
            Label4.Name = "Label4";
            Label4.Size = new System.Drawing.Size(136, 28);
            Label4.TabIndex = 0;
            Label4.Text = "Serveur MySql :";
            Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label3
            // 
            Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label3.Location = new System.Drawing.Point(20, 178);
            Label3.Name = "Label3";
            Label3.Size = new System.Drawing.Size(120, 28);
            Label3.TabIndex = 6;
            Label3.Text = "&Mot de passe :";
            Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Label2.Location = new System.Drawing.Point(34, 140);
            Label2.Name = "Label2";
            Label2.Size = new System.Drawing.Size(106, 28);
            Label2.TabIndex = 4;
            Label2.Text = "&Login :";
            Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PN
            // 
            this.PN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PN.BackColor = System.Drawing.Color.White;
            this.PN.Controls.Add(this.btnQuitter);
            this.PN.Controls.Add(this.tbxMdP);
            this.PN.Controls.Add(this.pbxLogo);
            this.PN.Controls.Add(this.tbxPort);
            this.PN.Controls.Add(Label5);
            this.PN.Controls.Add(this.tbxServeur);
            this.PN.Controls.Add(Label4);
            this.PN.Controls.Add(this.btEntrer);
            this.PN.Controls.Add(this.tbxLogin);
            this.PN.Controls.Add(Label3);
            this.PN.Controls.Add(Label2);
            this.PN.Controls.Add(this.lblTitre);
            this.PN.Location = new System.Drawing.Point(2, 1);
            this.PN.Margin = new System.Windows.Forms.Padding(4);
            this.PN.Name = "PN";
            this.PN.Size = new System.Drawing.Size(615, 297);
            this.PN.TabIndex = 2;
            this.PN.Paint += new System.Windows.Forms.PaintEventHandler(this.PN_Paint);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(355, 231);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(156, 37);
            this.btnQuitter.TabIndex = 22;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // tbxMdP
            // 
            this.tbxMdP.Location = new System.Drawing.Point(146, 180);
            this.tbxMdP.MaxLength = 20;
            this.tbxMdP.Name = "tbxMdP";
            this.tbxMdP.PasswordChar = '*';
            this.tbxMdP.Size = new System.Drawing.Size(187, 20);
            this.tbxMdP.TabIndex = 7;
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(355, 67);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(237, 139);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 9;
            this.pbxLogo.TabStop = false;
            // 
            // tbxPort
            // 
            this.tbxPort.Location = new System.Drawing.Point(146, 99);
            this.tbxPort.MaxLength = 5;
            this.tbxPort.Name = "tbxPort";
            this.tbxPort.Size = new System.Drawing.Size(187, 20);
            this.tbxPort.TabIndex = 3;
            this.tbxPort.TabStop = false;
            this.tbxPort.Text = "3306";
            // 
            // tbxServeur
            // 
            this.tbxServeur.Location = new System.Drawing.Point(146, 69);
            this.tbxServeur.MaxLength = 20;
            this.tbxServeur.Name = "tbxServeur";
            this.tbxServeur.Size = new System.Drawing.Size(187, 20);
            this.tbxServeur.TabIndex = 1;
            this.tbxServeur.TabStop = false;
            this.tbxServeur.Text = "10.100.0.5";
            this.tbxServeur.TextChanged += new System.EventHandler(this.tbxServeur_TextChanged);
            // 
            // btEntrer
            // 
            this.btEntrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEntrer.Location = new System.Drawing.Point(124, 231);
            this.btEntrer.Name = "btEntrer";
            this.btEntrer.Size = new System.Drawing.Size(156, 37);
            this.btEntrer.TabIndex = 8;
            this.btEntrer.Text = "Valider";
            this.btEntrer.UseVisualStyleBackColor = true;
            this.btEntrer.Click += new System.EventHandler(this.btEntrer_Click);
            // 
            // tbxLogin
            // 
            this.tbxLogin.Location = new System.Drawing.Point(146, 142);
            this.tbxLogin.MaxLength = 20;
            this.tbxLogin.Name = "tbxLogin";
            this.tbxLogin.Size = new System.Drawing.Size(187, 20);
            this.tbxLogin.TabIndex = 5;
            // 
            // lblTitre
            // 
            this.lblTitre.BackColor = System.Drawing.Color.Gray;
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(0, 0);
            this.lblTitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(615, 32);
            this.lblTitre.TabIndex = 0;
            this.lblTitre.Text = "Identification";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmIdentification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 300);
            this.Controls.Add(this.PN);
            this.Name = "frmIdentification";
            this.Text = "GSB Gestion des frais - Connexion";
            this.PN.ResumeLayout(false);
            this.PN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel PN;
        internal System.Windows.Forms.PictureBox pbxLogo;
        internal System.Windows.Forms.TextBox tbxPort;
        internal System.Windows.Forms.TextBox tbxServeur;
        internal System.Windows.Forms.Button btEntrer;
        internal System.Windows.Forms.TextBox tbxMdP;
        internal System.Windows.Forms.TextBox tbxLogin;
        internal System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnQuitter;
    }
}

