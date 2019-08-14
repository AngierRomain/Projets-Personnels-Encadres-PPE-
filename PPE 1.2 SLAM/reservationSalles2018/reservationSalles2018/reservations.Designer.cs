namespace reservationSalles2018
{
    partial class reservations
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
            this.rtbCommentaires = new System.Windows.Forms.RichTextBox();
            this.btnSupprimerReservation = new System.Windows.Forms.Button();
            this.btnModifierReservation = new System.Windows.Forms.Button();
            this.btnAjouterReservation = new System.Windows.Forms.Button();
            this.btnSemaineSuivante = new System.Windows.Forms.Button();
            this.btnSemainePrecedente = new System.Windows.Forms.Button();
            this.tbxPlageReservation = new System.Windows.Forms.TextBox();
            this.tbxDateReservation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxSemaines = new System.Windows.Forms.ComboBox();
            this.dgvSemaine = new System.Windows.Forms.DataGridView();
            this.cbxReservants = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSallesReservation = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemaine)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbCommentaires
            // 
            this.rtbCommentaires.Location = new System.Drawing.Point(26, 209);
            this.rtbCommentaires.Name = "rtbCommentaires";
            this.rtbCommentaires.Size = new System.Drawing.Size(304, 148);
            this.rtbCommentaires.TabIndex = 51;
            this.rtbCommentaires.Text = "";
            // 
            // btnSupprimerReservation
            // 
            this.btnSupprimerReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimerReservation.Location = new System.Drawing.Point(239, 366);
            this.btnSupprimerReservation.Name = "btnSupprimerReservation";
            this.btnSupprimerReservation.Size = new System.Drawing.Size(91, 33);
            this.btnSupprimerReservation.TabIndex = 50;
            this.btnSupprimerReservation.Text = "Supprimer";
            this.btnSupprimerReservation.UseVisualStyleBackColor = true;
            this.btnSupprimerReservation.Click += new System.EventHandler(this.btnSupprimerReservation_Click);
            // 
            // btnModifierReservation
            // 
            this.btnModifierReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifierReservation.Location = new System.Drawing.Point(133, 366);
            this.btnModifierReservation.Name = "btnModifierReservation";
            this.btnModifierReservation.Size = new System.Drawing.Size(91, 33);
            this.btnModifierReservation.TabIndex = 49;
            this.btnModifierReservation.Text = "Modifier";
            this.btnModifierReservation.UseVisualStyleBackColor = true;
            // 
            // btnAjouterReservation
            // 
            this.btnAjouterReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouterReservation.Location = new System.Drawing.Point(26, 366);
            this.btnAjouterReservation.Name = "btnAjouterReservation";
            this.btnAjouterReservation.Size = new System.Drawing.Size(91, 33);
            this.btnAjouterReservation.TabIndex = 48;
            this.btnAjouterReservation.Text = "Ajouter";
            this.btnAjouterReservation.UseVisualStyleBackColor = true;
            this.btnAjouterReservation.Click += new System.EventHandler(this.btnAjouterReservation_Click);
            // 
            // btnSemaineSuivante
            // 
            this.btnSemaineSuivante.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemaineSuivante.Location = new System.Drawing.Point(845, 71);
            this.btnSemaineSuivante.Name = "btnSemaineSuivante";
            this.btnSemaineSuivante.Size = new System.Drawing.Size(174, 39);
            this.btnSemaineSuivante.TabIndex = 47;
            this.btnSemaineSuivante.Text = "Semaine Suivante";
            this.btnSemaineSuivante.UseVisualStyleBackColor = true;
            this.btnSemaineSuivante.Click += new System.EventHandler(this.btnSemaineSuivante_Click);
            // 
            // btnSemainePrecedente
            // 
            this.btnSemainePrecedente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemainePrecedente.Location = new System.Drawing.Point(380, 71);
            this.btnSemainePrecedente.Name = "btnSemainePrecedente";
            this.btnSemainePrecedente.Size = new System.Drawing.Size(174, 39);
            this.btnSemainePrecedente.TabIndex = 46;
            this.btnSemainePrecedente.Text = "Semaine précédente";
            this.btnSemainePrecedente.UseVisualStyleBackColor = true;
            this.btnSemainePrecedente.Click += new System.EventHandler(this.btnSemainePrecedente_Click);
            // 
            // tbxPlageReservation
            // 
            this.tbxPlageReservation.Enabled = false;
            this.tbxPlageReservation.Location = new System.Drawing.Point(119, 132);
            this.tbxPlageReservation.Name = "tbxPlageReservation";
            this.tbxPlageReservation.Size = new System.Drawing.Size(211, 20);
            this.tbxPlageReservation.TabIndex = 45;
            // 
            // tbxDateReservation
            // 
            this.tbxDateReservation.Enabled = false;
            this.tbxDateReservation.Location = new System.Drawing.Point(119, 93);
            this.tbxDateReservation.Name = "tbxDateReservation";
            this.tbxDateReservation.Size = new System.Drawing.Size(211, 20);
            this.tbxDateReservation.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 33);
            this.label5.TabIndex = 43;
            this.label5.Text = "Gestion des réservations";
            // 
            // cbxSemaines
            // 
            this.cbxSemaines.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSemaines.FormattingEnabled = true;
            this.cbxSemaines.Location = new System.Drawing.Point(615, 79);
            this.cbxSemaines.Name = "cbxSemaines";
            this.cbxSemaines.Size = new System.Drawing.Size(166, 24);
            this.cbxSemaines.TabIndex = 42;
            this.cbxSemaines.SelectedIndexChanged += new System.EventHandler(this.cbxSemaines_SelectedIndexChanged);
            // 
            // dgvSemaine
            // 
            this.dgvSemaine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSemaine.Location = new System.Drawing.Point(380, 132);
            this.dgvSemaine.Name = "dgvSemaine";
            this.dgvSemaine.ReadOnly = true;
            this.dgvSemaine.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvSemaine.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvSemaine.Size = new System.Drawing.Size(640, 280);
            this.dgvSemaine.TabIndex = 41;
            // 
            // cbxReservants
            // 
            this.cbxReservants.FormattingEnabled = true;
            this.cbxReservants.Location = new System.Drawing.Point(119, 170);
            this.cbxReservants.Name = "cbxReservants";
            this.cbxReservants.Size = new System.Drawing.Size(211, 21);
            this.cbxReservants.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Reservant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Plage";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Salle";
            // 
            // cbxSallesReservation
            // 
            this.cbxSallesReservation.FormattingEnabled = true;
            this.cbxSallesReservation.Location = new System.Drawing.Point(120, 42);
            this.cbxSallesReservation.Name = "cbxSallesReservation";
            this.cbxSallesReservation.Size = new System.Drawing.Size(210, 21);
            this.cbxSallesReservation.TabIndex = 35;
            this.cbxSallesReservation.SelectedIndexChanged += new System.EventHandler(this.cbxSallesReservation_SelectedIndexChanged);
            // 
            // reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 444);
            this.Controls.Add(this.rtbCommentaires);
            this.Controls.Add(this.btnSupprimerReservation);
            this.Controls.Add(this.btnModifierReservation);
            this.Controls.Add(this.btnAjouterReservation);
            this.Controls.Add(this.btnSemaineSuivante);
            this.Controls.Add(this.btnSemainePrecedente);
            this.Controls.Add(this.tbxPlageReservation);
            this.Controls.Add(this.tbxDateReservation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxSemaines);
            this.Controls.Add(this.dgvSemaine);
            this.Controls.Add(this.cbxReservants);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSallesReservation);
            this.Name = "reservations";
            this.Text = "reservations";
            this.Load += new System.EventHandler(this.reservations_Load);
            this.Leave += new System.EventHandler(this.reservations_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSemaine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbCommentaires;
        private System.Windows.Forms.Button btnSupprimerReservation;
        private System.Windows.Forms.Button btnModifierReservation;
        private System.Windows.Forms.Button btnAjouterReservation;
        private System.Windows.Forms.Button btnSemaineSuivante;
        private System.Windows.Forms.Button btnSemainePrecedente;
        private System.Windows.Forms.TextBox tbxPlageReservation;
        private System.Windows.Forms.TextBox tbxDateReservation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxSemaines;
        private System.Windows.Forms.DataGridView dgvSemaine;
        private System.Windows.Forms.ComboBox cbxReservants;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSallesReservation;
    }
}