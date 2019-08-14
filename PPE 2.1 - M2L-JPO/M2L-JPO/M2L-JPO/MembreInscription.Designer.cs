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
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembreInscription)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxChoisirMembre
            // 
            this.cbxChoisirMembre.FormattingEnabled = true;
            this.cbxChoisirMembre.Location = new System.Drawing.Point(265, 45);
            this.cbxChoisirMembre.Name = "cbxChoisirMembre";
            this.cbxChoisirMembre.Size = new System.Drawing.Size(121, 21);
            this.cbxChoisirMembre.TabIndex = 0;
            // 
            // cbMatin
            // 
            this.cbMatin.AutoSize = true;
            this.cbMatin.Location = new System.Drawing.Point(192, 83);
            this.cbMatin.Name = "cbMatin";
            this.cbMatin.Size = new System.Drawing.Size(52, 17);
            this.cbMatin.TabIndex = 1;
            this.cbMatin.Text = "Matin";
            this.cbMatin.UseVisualStyleBackColor = true;
            //this.cbMatin.CheckedChanged += new System.EventHandler(this.cbMatin_CheckedChanged);
            // 
            // cbAprem
            // 
            this.cbAprem.AutoSize = true;
            this.cbAprem.Location = new System.Drawing.Point(265, 83);
            this.cbAprem.Name = "cbAprem";
            this.cbAprem.Size = new System.Drawing.Size(75, 17);
            this.cbAprem.TabIndex = 3;
            this.cbAprem.Text = "Après-Midi";
            this.cbAprem.UseVisualStyleBackColor = true;
            //this.cbAprem.CheckedChanged += new System.EventHandler(this.cbAprem_CheckedChanged);
            // 
            // btnInscrire
            // 
            this.btnInscrire.Location = new System.Drawing.Point(127, 121);
            this.btnInscrire.Name = "btnInscrire";
            this.btnInscrire.Size = new System.Drawing.Size(83, 33);
            this.btnInscrire.TabIndex = 27;
            this.btnInscrire.Text = "Inscrire";
            this.btnInscrire.UseVisualStyleBackColor = true;
            this.btnInscrire.Click += new System.EventHandler(this.btnInscrire_Click);
            // 
            // btnDesinscrire
            // 
            this.btnDesinscrire.Location = new System.Drawing.Point(336, 121);
            this.btnDesinscrire.Name = "btnDesinscrire";
            this.btnDesinscrire.Size = new System.Drawing.Size(83, 33);
            this.btnDesinscrire.TabIndex = 26;
            this.btnDesinscrire.Text = "Désinscrire";
            this.btnDesinscrire.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(231, 121);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(83, 33);
            this.btnModifier.TabIndex = 25;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // dgvMembreInscription
            // 
            this.dgvMembreInscription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembreInscription.Location = new System.Drawing.Point(153, 178);
            this.dgvMembreInscription.Name = "dgvMembreInscription";
            this.dgvMembreInscription.Size = new System.Drawing.Size(240, 150);
            this.dgvMembreInscription.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 16);
            this.label2.TabIndex = 30;
            this.label2.Text = "Choisir un membre:";
            // 
            // MembreInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(547, 350);
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
            this.Text = "MembreInscription";
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
    }
}