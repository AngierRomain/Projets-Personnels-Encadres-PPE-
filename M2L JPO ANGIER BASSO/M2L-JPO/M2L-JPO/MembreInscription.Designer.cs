namespace M2L_JPO
{
    partial class MembreInscription
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
            this.cbxChoisirMembre = new System.Windows.Forms.ComboBox();
            this.cbMatin = new System.Windows.Forms.CheckBox();
            this.cbAprem = new System.Windows.Forms.CheckBox();
            this.btnInscrire = new System.Windows.Forms.Button();
            this.btnDesinscrire = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.dgvMembreInscription = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMembresInscrits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembreInscription)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxChoisirMembre
            // 
            this.cbxChoisirMembre.FormattingEnabled = true;
            this.cbxChoisirMembre.Location = new System.Drawing.Point(163, 121);
            this.cbxChoisirMembre.Name = "cbxChoisirMembre";
            this.cbxChoisirMembre.Size = new System.Drawing.Size(121, 21);
            this.cbxChoisirMembre.TabIndex = 0;
            // 
            // cbMatin
            // 
            this.cbMatin.AutoSize = true;
            this.cbMatin.Location = new System.Drawing.Point(80, 165);
            this.cbMatin.Name = "cbMatin";
            this.cbMatin.Size = new System.Drawing.Size(52, 17);
            this.cbMatin.TabIndex = 1;
            this.cbMatin.Text = "Matin";
            this.cbMatin.UseVisualStyleBackColor = true;
            // 
            // cbAprem
            // 
            this.cbAprem.AutoSize = true;
            this.cbAprem.Location = new System.Drawing.Point(153, 165);
            this.cbAprem.Name = "cbAprem";
            this.cbAprem.Size = new System.Drawing.Size(75, 17);
            this.cbAprem.TabIndex = 3;
            this.cbAprem.Text = "Après-Midi";
            this.cbAprem.UseVisualStyleBackColor = true;
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(23, 210);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(83, 33);
            this.btnInscrire.TabIndex = 27;
            this.btnInscrire.Text = "Inscrire";
            this.btnInscrire.UseVisualStyleBackColor = true;
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // btnDesinscrire
            // 
            this.btnDesinscrire.Location = new System.Drawing.Point(201, 210);
            this.btnDesinscrire.Name = "btnDesinscrire";
            this.btnDesinscrire.Size = new System.Drawing.Size(83, 33);
            this.btnDesinscrire.TabIndex = 26;
            this.btnDesinscrire.Text = "Désinscrire";
            this.btnDesinscrire.UseVisualStyleBackColor = true;
            this.btnDesinscrire.Click += new System.EventHandler(this.btnDesinscrire_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(112, 210);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(83, 33);
            this.btnModifier.TabIndex = 25;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dgvMembreInscription
            // 
            this.dgvMembreInscription.AllowUserToAddRows = false;
            this.dgvMembreInscription.AllowUserToDeleteRows = false;
            this.dgvMembreInscription.AllowUserToResizeColumns = false;
            this.dgvMembreInscription.AllowUserToResizeRows = false;
            this.dgvMembreInscription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembreInscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembreInscription.Location = new System.Drawing.Point(309, 42);
            this.dgvMembreInscription.Name = "dgvMembreInscription";
            this.dgvMembreInscription.ReadOnly = true;
            this.dgvMembreInscription.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMembreInscription.Size = new System.Drawing.Size(379, 296);
            this.dgvMembreInscription.TabIndex = 28;
            this.dgvMembreInscription.SelectionChanged += new System.EventHandler(this.datagridview1_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Choisir un membre:";
            // 
            // lblMembresInscrits
            // 
            this.lblMembresInscrits.AutoSize = true;
            this.lblMembresInscrits.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembresInscrits.Location = new System.Drawing.Point(401, 23);
            this.lblMembresInscrits.Name = "lblMembresInscrits";
            this.lblMembresInscrits.Size = new System.Drawing.Size(192, 16);
            this.lblMembresInscrits.TabIndex = 31;
            this.lblMembresInscrits.Text = "Liste des membres inscrits";
            // 
            // MembreInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(713, 350);
            this.Controls.Add(this.lblMembresInscrits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMembreInscription);
            this.Controls.Add(this.btnInscrire);
            this.Controls.Add(this.btnDesinscrire);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.cbAprem);
            this.Controls.Add(this.cbMatin);
            this.Controls.Add(this.cbxChoisirMembre);
            this.Name = "MembreInscription";
            this.ShowIcon = false;
            this.Text = "Inscriptions des membres";
            this.Load += new System.EventHandler(this.MembreInscription_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembreInscription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxChoisirMembre;
        private System.Windows.Forms.CheckBox cbMatin;
        private System.Windows.Forms.CheckBox cbAprem;
        private System.Windows.Forms.Button btnInscrire;
        private System.Windows.Forms.Button btnDesinscrire;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.DataGridView dgvMembreInscription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMembresInscrits;
    }
}