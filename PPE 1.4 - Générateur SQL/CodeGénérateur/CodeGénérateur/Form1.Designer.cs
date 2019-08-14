namespace CodeGénérateur
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
            this.btnOFD = new System.Windows.Forms.Button();
            this.btnSFD = new System.Windows.Forms.Button();
            this.btnGenerer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.lbxFichiers = new System.Windows.Forms.ListBox();
            this.SFD = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnOFD
            // 
            this.btnOFD.Location = new System.Drawing.Point(27, 53);
            this.btnOFD.Name = "btnOFD";
            this.btnOFD.Size = new System.Drawing.Size(158, 23);
            this.btnOFD.TabIndex = 0;
            this.btnOFD.Text = "Selectionner un fichier";
            this.btnOFD.UseVisualStyleBackColor = true;
            this.btnOFD.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // btnSFD
            // 
            this.btnSFD.Location = new System.Drawing.Point(519, 53);
            this.btnSFD.Name = "btnSFD";
            this.btnSFD.Size = new System.Drawing.Size(105, 23);
            this.btnSFD.TabIndex = 1;
            this.btnSFD.Text = "Enregistrer sous ...";
            this.btnSFD.UseVisualStyleBackColor = true;
            // 
            // btnGenerer
            // 
            this.btnGenerer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerer.Location = new System.Drawing.Point(300, 305);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(123, 63);
            this.btnGenerer.TabIndex = 2;
            this.btnGenerer.Text = "Générer";
            this.btnGenerer.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(206, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Générateur SQL";
            //this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // OFD
            // 
            this.OFD.FileName = "openFileDialog1";
            // 
            // lbxFichiers
            // 
            this.lbxFichiers.FormattingEnabled = true;
            this.lbxFichiers.Location = new System.Drawing.Point(27, 97);
            this.lbxFichiers.Name = "lbxFichiers";
            this.lbxFichiers.Size = new System.Drawing.Size(239, 251);
            this.lbxFichiers.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 423);
            this.Controls.Add(this.lbxFichiers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.btnSFD);
            this.Controls.Add(this.btnOFD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOFD;
        private System.Windows.Forms.Button btnSFD;
        private System.Windows.Forms.Button btnGenerer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.ListBox lbxFichiers;
        private System.Windows.Forms.SaveFileDialog SFD;
    }
}

