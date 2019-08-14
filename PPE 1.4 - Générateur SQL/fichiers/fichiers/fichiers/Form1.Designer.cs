namespace fichiers
{
    partial class Form1
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
            this.btnDriveInfo = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFBD = new System.Windows.Forms.Button();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.btnOFD = new System.Windows.Forms.Button();
            this.lbxFichiers = new System.Windows.Forms.ListBox();
            this.txbDossier = new System.Windows.Forms.TextBox();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.btnSFD = new System.Windows.Forms.Button();
            this.tbxMonTexte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnDriveInfo
            // 
            this.btnDriveInfo.Location = new System.Drawing.Point(31, 24);
            this.btnDriveInfo.Name = "btnDriveInfo";
            this.btnDriveInfo.Size = new System.Drawing.Size(163, 44);
            this.btnDriveInfo.TabIndex = 2;
            this.btnDriveInfo.Text = "DriveInfo";
            this.btnDriveInfo.UseVisualStyleBackColor = true;
            this.btnDriveInfo.Click += new System.EventHandler(this.btnDriveInfo_Click);
            // 
            // btnFBD
            // 
            this.btnFBD.Location = new System.Drawing.Point(31, 209);
            this.btnFBD.Name = "btnFBD";
            this.btnFBD.Size = new System.Drawing.Size(171, 46);
            this.btnFBD.TabIndex = 3;
            this.btnFBD.Text = "FolderBrowserDialog";
            this.btnFBD.UseVisualStyleBackColor = true;
            this.btnFBD.Click += new System.EventHandler(this.FBD_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "OFD";
            // 
            // btnOFD
            // 
            this.btnOFD.Location = new System.Drawing.Point(267, 20);
            this.btnOFD.Name = "btnOFD";
            this.btnOFD.Size = new System.Drawing.Size(171, 46);
            this.btnOFD.TabIndex = 4;
            this.btnOFD.Text = "OpenFileDialog";
            this.btnOFD.UseVisualStyleBackColor = true;
            this.btnOFD.Click += new System.EventHandler(this.btnOFD_Click);
            // 
            // lbxFichiers
            // 
            this.lbxFichiers.FormattingEnabled = true;
            this.lbxFichiers.Location = new System.Drawing.Point(246, 78);
            this.lbxFichiers.Name = "lbxFichiers";
            this.lbxFichiers.Size = new System.Drawing.Size(217, 264);
            this.lbxFichiers.TabIndex = 5;
            // 
            // txbDossier
            // 
            this.txbDossier.Location = new System.Drawing.Point(31, 274);
            this.txbDossier.Name = "txbDossier";
            this.txbDossier.Size = new System.Drawing.Size(171, 20);
            this.txbDossier.TabIndex = 11;
            // 
            // SFD
            // 
            //this.SFD.FileOk += new System.ComponentModel.CancelEventHandler(this.sFD_FileOk);
            // 
            // btnSFD
            // 
            this.btnSFD.Location = new System.Drawing.Point(547, 20);
            this.btnSFD.Name = "btnSFD";
            this.btnSFD.Size = new System.Drawing.Size(171, 46);
            this.btnSFD.TabIndex = 12;
            this.btnSFD.Text = "SaveFileDialog";
            this.btnSFD.UseVisualStyleBackColor = true;
            this.btnSFD.Click += new System.EventHandler(this.btnSFD_Click);
            // 
            // tbxMonTexte
            // 
            this.tbxMonTexte.Location = new System.Drawing.Point(547, 78);
            this.tbxMonTexte.Multiline = true;
            this.tbxMonTexte.Name = "tbxMonTexte";
            this.tbxMonTexte.Size = new System.Drawing.Size(394, 264);
            this.tbxMonTexte.TabIndex = 13;
            //this.tbxMonTexte.TextChanged += new System.EventHandler(this.tbxMonTexte_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 377);
            this.Controls.Add(this.tbxMonTexte);
            this.Controls.Add(this.btnSFD);
            this.Controls.Add(this.txbDossier);
            this.Controls.Add(this.lbxFichiers);
            this.Controls.Add(this.btnOFD);
            this.Controls.Add(this.btnFBD);
            this.Controls.Add(this.btnDriveInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDriveInfo;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.Button btnFBD;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.Button btnOFD;
        private System.Windows.Forms.ListBox lbxFichiers;
        private System.Windows.Forms.TextBox txbDossier;
        private System.Windows.Forms.SaveFileDialog SFD;
        private System.Windows.Forms.Button btnSFD;
        private System.Windows.Forms.TextBox tbxMonTexte;
    }
}

