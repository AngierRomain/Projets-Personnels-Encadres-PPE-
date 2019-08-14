using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


/**
 * Réalisé par Tony
 **/

namespace M2L_JPO
{
    public partial class MembreInscription : Form
    {
        OleDbConnection maConnexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = ..\..\..\M2L_JPO.accdb");
        OleDbCommand maCommande = new OleDbCommand();
        OleDbDataReader unDR;
        

        String codeMembre;
        byte creneau;

        public MembreInscription()
        {
            InitializeComponent();
        }

        private void MembreInscription_Load(object sender, EventArgs e)
        {
            
            dgvMembreInscription.SelectionMode = DataGridViewSelectionMode.FullRowSelect; //Mettre le mode de selection en ligne
            dgvMembreInscription.MultiSelect = false; //Enlever la selection multiple

            dgvMembreInscription.RowHeadersVisible = false; //enlever les RowHeaders

            //ouvrir la connexion
            maCommande.Connection = maConnexion;
            maConnexion.Open();

            //remplir la combobox des noms et prénoms
            maCommande.CommandText = "SELECT nom, prénom FROM MEMBRE";
            unDR = maCommande.ExecuteReader();
            while (unDR.Read())
            {
                String nomPrenom = unDR.GetValue(0).ToString() + " " + unDR.GetValue(1).ToString();
                cbxChoisirMembre.Items.Add(nomPrenom);

            }
            cbxChoisirMembre.SelectedIndex = 0;
            unDR.Close();

            //couper la connexion
            maConnexion.Close();

            //setup le tableau
            dgvMembreInscription.ColumnCount = 3;
            dgvMembreInscription.Columns[0].HeaderText = "Code Membre";
            dgvMembreInscription.Columns[1].HeaderText = "Membre";
            dgvMembreInscription.Columns[2].HeaderText = "Créneau";

            //generer le dgv
            regenDGV();

            
        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            //gerer les checkboxes
            if(cbMatin.Checked)
            {
                creneau = 1;
            }
            else if (cbAprem.Checked)
            {
                creneau = 2;
            }
            else if(cbMatin.Checked && cbAprem.Checked)
            {
                creneau = 3;
            }
            else
            {
                creneau = 0;
            }

            String nomMembre = cbxChoisirMembre.SelectedItem.ToString().Split(' ')[0];
            //si aucun  créneau est selectionné, avertir. Sinon, inscrire le membre
            if (creneau == 0)
            {
                MessageBox.Show("Vous devez selectionner un créneau", "Erreur de selection");
                regenDGV();
            }
            else
            {
                try
                {
                    //ouvrir la connexion
                    maCommande.Connection = maConnexion;
                    maConnexion.Open();

                    //selectionner dans la bdd membre a inscrire
                    maCommande.CommandText = "SELECT codeMembre FROM MEMBRE WHERE nom = '" + nomMembre + "'";
                    unDR = maCommande.ExecuteReader();
                    while (unDR.Read())
                    {
                        codeMembre = unDR.GetValue(0).ToString();
                        maCommande.CommandText = "INSERT INTO PARTICIPER(codeMembre, codeCréneau) values ('" + codeMembre + "', '" + creneau.ToString() + "')";
                    }
                    unDR.Close();
                    maCommande.ExecuteNonQuery();

                    //Regenerer le dgv
                    regenDGV();

                    //couper la connexion
                    maConnexion.Close();
                }
                catch
                {
                    MessageBox.Show("Ce membre est déjà inscrit!", "Erreur de selection");
                    regenDGV();
                }
            }

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            //gerer les checkboxes
            if (cbMatin.Checked && !cbAprem.Checked)
            {
                creneau = 1;
            }
            else if (cbAprem.Checked && !cbMatin.Checked)
            {
                creneau = 2;
            }
            else if (cbMatin.Checked && cbAprem.Checked)
            {
                creneau = 3;
            }
            else
            {
                creneau = 0;
            }
            if (creneau == 0)
            {
                MessageBox.Show("Vous devez selectionner un créneau", "Erreur de selection");
                regenDGV();
            }
            else 
            {
                String nom = cbxChoisirMembre.SelectedItem.ToString().Split(' ')[0];

                //ouvrir la connexion
                maCommande.Connection = maConnexion;
                maConnexion.Open();

                //update les données
                maCommande.CommandText = "UPDATE PARTICIPER SET codeCréneau = '" + creneau + "' WHERE codeMembre = (SELECT codeMembre FROM MEMBRE WHERE nom = '" + nom + "')";
                maCommande.ExecuteNonQuery();

                //couper la connexion
                maConnexion.Close();

                //avertir 
                MessageBox.Show("Vos modifications ont bien été enregistrées.");

                //rengenere le dgv
                regenDGV();
            }
        }

        private void datagridview1_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMembreInscription.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvMembreInscription.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dgvMembreInscription.Rows[selectedrowindex];

                string nomPrenom = Convert.ToString(selectedRow.Cells[1].Value);

                int index = cbxChoisirMembre.FindString(nomPrenom);
                cbxChoisirMembre.SelectedIndex = index;
            }
            
        }

        public void regenDGV()
        {
            //fonction pour regenerer le dataGridView
            maConnexion.Close();
            maCommande.Connection = maConnexion;
            maConnexion.Open();
            dgvMembreInscription.Rows.Clear();
            maCommande.CommandText = "SELECT * FROM PARTICIPER";
            unDR = maCommande.ExecuteReader();
            int i = 0;

            while (unDR.Read())
            {
                dgvMembreInscription.Rows.Add();

                dgvMembreInscription[0, i].Value = unDR.GetValue(0).ToString();
                dgvMembreInscription[2, i].Value = unDR.GetValue(1).ToString();

                if (unDR.GetValue(1).ToString() == "1")
                {
                    dgvMembreInscription[2, i].Value = "Matin";
                }
                else if (unDR.GetValue(1).ToString() == "2")
                {
                    dgvMembreInscription[2, i].Value = "Après-midi";
                }
                else
                {
                    dgvMembreInscription[2, i].Value = "Journée entière";
                }
                i++;
            }
            unDR.Close();

            for (i = 0; i < dgvMembreInscription.Rows.Count; i++)
            {
                maCommande.CommandText = "SELECT nom, prénom FROM MEMBRE WHERE codeMembre = (SELECT codeMembre FROM PARTICIPER WHERE codeMembre = " + dgvMembreInscription[0, i].Value + ")";
                unDR = maCommande.ExecuteReader();

                while (unDR.Read())
                {
                    dgvMembreInscription[1, i].Value = unDR.GetValue(0).ToString() + " " + unDR.GetValue(1).ToString();
                }
                unDR.Close();
            }
            //fin regeneration
            unDR.Close();
            maConnexion.Close();
        }

        private void btnDesinscrire_Click(object sender, EventArgs e)
        {
            //ouvrir la connexion
            maCommande.Connection = maConnexion;
            maConnexion.Open();

            //désinscrire le membre
            String nom = cbxChoisirMembre.SelectedItem.ToString();
            maCommande.CommandText = "DELETE FROM PARTICIPER WHERE codeMembre = (SELECT codeMembre FROM MEMBRE WHERE nom = '" + nom.Split(' ')[0] + "')";
            maCommande.ExecuteNonQuery();

            MessageBox.Show("Le membre " + nom +" a bien était désinscrit.");

            //regenerer la bdd 
            regenDGV();
        }
    }
}
