namespace reservationSalles2018
{
    partial class factures
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
            this.dgvFactures = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactures)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFactures
            // 
            this.dgvFactures.AllowUserToAddRows = false;
            this.dgvFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFactures.Location = new System.Drawing.Point(12, 29);
            this.dgvFactures.Name = "dgvFactures";
            this.dgvFactures.Size = new System.Drawing.Size(908, 387);
            this.dgvFactures.TabIndex = 0;
            // 
            // factures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 463);
            this.Controls.Add(this.dgvFactures);
            this.Name = "factures";
            this.Text = "factures";
            this.Load += new System.EventHandler(this.factures_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFactures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFactures;
    }
}