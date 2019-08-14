namespace reservationSalles2018
{
    partial class mission3
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
            this.dgvStatistiques = new System.Windows.Forms.DataGridView();
            this.btnValider = new System.Windows.Forms.Button();
            this.dgvResultats = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMois = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistiques)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultats)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStatistiques
            // 
            this.dgvStatistiques.AllowUserToAddRows = false;
            this.dgvStatistiques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatistiques.Location = new System.Drawing.Point(0, -1);
            this.dgvStatistiques.Name = "dgvStatistiques";
            this.dgvStatistiques.Size = new System.Drawing.Size(523, 458);
            this.dgvStatistiques.TabIndex = 1;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(716, 291);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 2;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // dgvResultats
            // 
            this.dgvResultats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultats.Location = new System.Drawing.Point(631, 103);
            this.dgvResultats.Name = "dgvResultats";
            this.dgvResultats.Size = new System.Drawing.Size(240, 150);
            this.dgvResultats.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(600, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choisissez un mois";
            // 
            // cbxMois
            // 
            this.cbxMois.FormattingEnabled = true;
            this.cbxMois.Location = new System.Drawing.Point(701, 42);
            this.cbxMois.Name = "cbxMois";
            this.cbxMois.Size = new System.Drawing.Size(121, 21);
            this.cbxMois.TabIndex = 5;
            this.cbxMois.SelectedIndexChanged += new System.EventHandler(this.cbxMois_SelectedIndexChanged);
            // 
            // mission3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 457);
            this.Controls.Add(this.cbxMois);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvResultats);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.dgvStatistiques);
            this.Name = "mission3";
            this.Text = "statistiques";
            this.Load += new System.EventHandler(this.statistiques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatistiques)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatistiques;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridView dgvResultats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMois;
    }
}