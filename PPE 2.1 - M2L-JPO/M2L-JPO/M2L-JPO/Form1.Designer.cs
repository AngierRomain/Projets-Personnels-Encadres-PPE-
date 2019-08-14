namespace M2L_JPO
{
    partial class frmJPO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJPO));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiLigue = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMembre = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrementToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.inscriptionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Wheat;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLigue,
            this.tsmiMembre});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(834, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiLigue
            // 
            this.tsmiLigue.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrementToolStripMenuItem,
            this.inscriptionToolStripMenuItem});
            this.tsmiLigue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiLigue.Name = "tsmiLigue";
            this.tsmiLigue.Size = new System.Drawing.Size(177, 28);
            this.tsmiLigue.Text = "Gestion des ligues";
            // 
            // enregistrementToolStripMenuItem
            // 
            this.enregistrementToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.enregistrementToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrementToolStripMenuItem.Name = "enregistrementToolStripMenuItem";
            this.enregistrementToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.enregistrementToolStripMenuItem.Text = "Enregistrement";
            this.enregistrementToolStripMenuItem.Click += new System.EventHandler(this.enregistrementToolStripMenuItem_Click);
            // 
            // inscriptionToolStripMenuItem
            // 
            this.inscriptionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inscriptionToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscriptionToolStripMenuItem.Name = "inscriptionToolStripMenuItem";
            this.inscriptionToolStripMenuItem.Size = new System.Drawing.Size(192, 24);
            this.inscriptionToolStripMenuItem.Text = "Inscription";
            this.inscriptionToolStripMenuItem.Click += new System.EventHandler(this.inscriptionToolStripMenuItem_Click);
            // 
            // tsmiMembre
            // 
            this.tsmiMembre.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrementToolStripMenuItem1,
            this.inscriptionToolStripMenuItem1});
            this.tsmiMembre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiMembre.Name = "tsmiMembre";
            this.tsmiMembre.Size = new System.Drawing.Size(207, 28);
            this.tsmiMembre.Text = "Gestion des membres";
            // 
            // enregistrementToolStripMenuItem1
            // 
            this.enregistrementToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.enregistrementToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enregistrementToolStripMenuItem1.Name = "enregistrementToolStripMenuItem1";
            this.enregistrementToolStripMenuItem1.Size = new System.Drawing.Size(202, 24);
            this.enregistrementToolStripMenuItem1.Text = "Enregistrement";
            this.enregistrementToolStripMenuItem1.Click += new System.EventHandler(this.enregistrementToolStripMenuItem1_Click);
            // 
            // inscriptionToolStripMenuItem1
            // 
            this.inscriptionToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.inscriptionToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscriptionToolStripMenuItem1.Name = "inscriptionToolStripMenuItem1";
            this.inscriptionToolStripMenuItem1.Size = new System.Drawing.Size(202, 24);
            this.inscriptionToolStripMenuItem1.Text = "Inscription";
            this.inscriptionToolStripMenuItem1.Click += new System.EventHandler(this.inscriptionToolStripMenuItem1_Click);
            // 
            // frmJPO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(834, 432);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmJPO";
            this.Text = "M2L Journée Portes Ouvertes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiLigue;
        private System.Windows.Forms.ToolStripMenuItem tsmiMembre;
        private System.Windows.Forms.ToolStripMenuItem enregistrementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrementToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem inscriptionToolStripMenuItem1;
    }
}

