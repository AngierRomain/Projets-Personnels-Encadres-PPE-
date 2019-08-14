namespace M2L_JPO
{
    partial class MembreEnregistrer
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.tbxPrenom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMail = new System.Windows.Forms.TextBox();
            this.tbxTel = new System.Windows.Forms.TextBox();
            this.lbxMembre = new System.Windows.Forms.ListBox();
            this.tbxFiltreMembre = new System.Windows.Forms.TextBox();
            this.btnFiltreMembre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(282, 200);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(83, 33);
            this.btnAjouter.TabIndex = 24;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(491, 200);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(83, 33);
            this.btnSupprimer.TabIndex = 23;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(388, 200);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(83, 33);
            this.btnModifier.TabIndex = 22;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(354, 37);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(220, 20);
            this.tbxNom.TabIndex = 21;
            // 
            // tbxPrenom
            // 
            this.tbxPrenom.Location = new System.Drawing.Point(354, 74);
            this.tbxPrenom.Name = "tbxPrenom";
            this.tbxPrenom.Size = new System.Drawing.Size(220, 20);
            this.tbxPrenom.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(278, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prenom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(278, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tel:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(278, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Nom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(278, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Mail:";
            // 
            // tbxMail
            // 
            this.tbxMail.Location = new System.Drawing.Point(354, 155);
            this.tbxMail.Name = "tbxMail";
            this.tbxMail.Size = new System.Drawing.Size(220, 20);
            this.tbxMail.TabIndex = 26;
            // 
            // tbxTel
            // 
            this.tbxTel.Location = new System.Drawing.Point(354, 117);
            this.tbxTel.Name = "tbxTel";
            this.tbxTel.Size = new System.Drawing.Size(220, 20);
            this.tbxTel.TabIndex = 27;
            // 
            // lbxMembre
            // 
            this.lbxMembre.FormattingEnabled = true;
            this.lbxMembre.Location = new System.Drawing.Point(35, 55);
            this.lbxMembre.Name = "lbxMembre";
            this.lbxMembre.ScrollAlwaysVisible = true;
            this.lbxMembre.Size = new System.Drawing.Size(153, 225);
            this.lbxMembre.TabIndex = 28;
            this.lbxMembre.SelectedIndexChanged += new System.EventHandler(this.lbxMembre_SelectedIndexChanged);
            // 
            // tbxFiltreMembre
            // 
            this.tbxFiltreMembre.Location = new System.Drawing.Point(35, 23);
            this.tbxFiltreMembre.Name = "tbxFiltreMembre";
            this.tbxFiltreMembre.Size = new System.Drawing.Size(107, 20);
            this.tbxFiltreMembre.TabIndex = 29;
            // 
            // btnFiltreMembre
            // 
            this.btnFiltreMembre.Location = new System.Drawing.Point(149, 20);
            this.btnFiltreMembre.Name = "btnFiltreMembre";
            this.btnFiltreMembre.Size = new System.Drawing.Size(39, 23);
            this.btnFiltreMembre.TabIndex = 30;
            this.btnFiltreMembre.Text = "...";
            this.btnFiltreMembre.UseVisualStyleBackColor = true;
            // 
            // MembreEnregistrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(608, 335);
            this.Controls.Add(this.btnFiltreMembre);
            this.Controls.Add(this.tbxFiltreMembre);
            this.Controls.Add(this.lbxMembre);
            this.Controls.Add(this.tbxTel);
            this.Controls.Add(this.tbxMail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.tbxPrenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MembreEnregistrer";
            this.ShowIcon = false;
            this.Text = "MembreEnregistrer";
            this.Load += new System.EventHandler(this.MembreEnregistrer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.TextBox tbxPrenom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMail;
        private System.Windows.Forms.TextBox tbxTel;
        private System.Windows.Forms.ListBox lbxMembre;
        private System.Windows.Forms.TextBox tbxFiltreMembre;
        private System.Windows.Forms.Button btnFiltreMembre;
    }
}