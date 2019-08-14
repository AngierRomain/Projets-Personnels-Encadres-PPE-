namespace GSB
{
    partial class frmVisiteurListeFiches
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVisiteurListeFiches));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnCreerFiche = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnOuvrirFiche = new System.Windows.Forms.Button();
            this.dgvFichesVisiteur = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichesVisiteur)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreerFiche
            // 
            this.btnCreerFiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreerFiche.Location = new System.Drawing.Point(715, 278);
            this.btnCreerFiche.Name = "btnCreerFiche";
            this.btnCreerFiche.Size = new System.Drawing.Size(237, 38);
            this.btnCreerFiche.TabIndex = 21;
            this.btnCreerFiche.Text = "Créer une fiche";
            this.btnCreerFiche.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.Location = new System.Drawing.Point(715, 322);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(237, 38);
            this.btnQuitter.TabIndex = 20;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxLogo.BackgroundImage")));
            this.pbxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxLogo.Location = new System.Drawing.Point(715, 43);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(237, 139);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLogo.TabIndex = 19;
            this.pbxLogo.TabStop = false;
            // 
            // btnOuvrirFiche
            // 
            this.btnOuvrirFiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOuvrirFiche.Location = new System.Drawing.Point(715, 234);
            this.btnOuvrirFiche.Name = "btnOuvrirFiche";
            this.btnOuvrirFiche.Size = new System.Drawing.Size(237, 38);
            this.btnOuvrirFiche.TabIndex = 18;
            this.btnOuvrirFiche.Text = "Ouvrir fiche sélectionnée";
            this.btnOuvrirFiche.UseVisualStyleBackColor = true;
            // 
            // dgvFichesVisiteur
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFichesVisiteur.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvFichesVisiteur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFichesVisiteur.Location = new System.Drawing.Point(12, 23);
            this.dgvFichesVisiteur.Name = "dgvFichesVisiteur";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvFichesVisiteur.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvFichesVisiteur.Size = new System.Drawing.Size(680, 388);
            this.dgvFichesVisiteur.TabIndex = 17;
            // 
            // frmVisiteurListeFiches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 433);
            this.Controls.Add(this.btnCreerFiche);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnOuvrirFiche);
            this.Controls.Add(this.dgvFichesVisiteur);
            this.Name = "frmVisiteurListeFiches";
            this.Text = "frmVisiteurListeFiches";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFichesVisiteur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreerFiche;
        private System.Windows.Forms.Button btnQuitter;
        internal System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Button btnOuvrirFiche;
        private System.Windows.Forms.DataGridView dgvFichesVisiteur;
    }
}