namespace M2L_JPO
{
    partial class LigueEnregistrer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxDiscipline = new System.Windows.Forms.TextBox();
            this.tbxAdresse = new System.Windows.Forms.TextBox();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnFiltreLigue = new System.Windows.Forms.Button();
            this.tbxFiltreLigue = new System.Windows.Forms.TextBox();
            this.lbxLigue = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(279, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Discipline:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(279, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Adresse:";
            // 
            // tbxDiscipline
            // 
            this.tbxDiscipline.Location = new System.Drawing.Point(386, 132);
            this.tbxDiscipline.Name = "tbxDiscipline";
            this.tbxDiscipline.Size = new System.Drawing.Size(220, 20);
            this.tbxDiscipline.TabIndex = 10;
            // 
            // tbxAdresse
            // 
            this.tbxAdresse.Location = new System.Drawing.Point(386, 89);
            this.tbxAdresse.Name = "tbxAdresse";
            this.tbxAdresse.Size = new System.Drawing.Size(220, 20);
            this.tbxAdresse.TabIndex = 11;
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(386, 52);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(220, 20);
            this.tbxNom.TabIndex = 12;
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(438, 280);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(83, 33);
            this.btnModifier.TabIndex = 13;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(527, 280);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(83, 33);
            this.btnSupprimer.TabIndex = 14;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(346, 280);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(83, 33);
            this.btnAjouter.TabIndex = 15;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnFiltreLigue
            // 
            this.btnFiltreLigue.Location = new System.Drawing.Point(139, 26);
            this.btnFiltreLigue.Name = "btnFiltreLigue";
            this.btnFiltreLigue.Size = new System.Drawing.Size(39, 23);
            this.btnFiltreLigue.TabIndex = 33;
            this.btnFiltreLigue.Text = "button4";
            this.btnFiltreLigue.UseVisualStyleBackColor = true;
            // 
            // tbxFiltreLigue
            // 
            this.tbxFiltreLigue.Location = new System.Drawing.Point(25, 29);
            this.tbxFiltreLigue.Name = "tbxFiltreLigue";
            this.tbxFiltreLigue.Size = new System.Drawing.Size(107, 20);
            this.tbxFiltreLigue.TabIndex = 32;
            // 
            // lbxLigue
            // 
            this.lbxLigue.FormattingEnabled = true;
            this.lbxLigue.Location = new System.Drawing.Point(25, 61);
            this.lbxLigue.Name = "lbxLigue";
            this.lbxLigue.ScrollAlwaysVisible = true;
            this.lbxLigue.Size = new System.Drawing.Size(153, 225);
            this.lbxLigue.TabIndex = 31;
            this.lbxLigue.SelectedIndexChanged += new System.EventHandler(this.lbxLigue_SelectedIndexChanged);
            // 
            // LigueEnregistrer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(710, 333);
            this.Controls.Add(this.btnFiltreLigue);
            this.Controls.Add(this.tbxFiltreLigue);
            this.Controls.Add(this.lbxLigue);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.tbxAdresse);
            this.Controls.Add(this.tbxDiscipline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LigueEnregistrer";
            this.ShowIcon = false;
            this.Text = "LigueEnregistrer";
            this.Load += new System.EventHandler(this.LigueEnregistrer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxDiscipline;
        private System.Windows.Forms.TextBox tbxAdresse;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnFiltreLigue;
        private System.Windows.Forms.TextBox tbxFiltreLigue;
        private System.Windows.Forms.ListBox lbxLigue;
    }
}