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
    public partial class MembreEnregistrer : Form
    {
        OleDbConnection maConnexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = ..\..\..\M2L_JPO.accdb");
        OleDbCommand maCommande = new OleDbCommand();
        OleDbDataReader unDR;

        String codeLigue;

        public MembreEnregistrer()
        {
            InitializeComponent();
        }

        private void MembreEnregistrer_Load(object sender, EventArgs e)
        {
            //s'assurer que lbxMembre est vide
            lbxMembre.Items.Clear();

            //Rendre les textbox non modifiables
            tbxNom.ReadOnly = true;
            tbxPrenom.ReadOnly = true;
            tbxTel.ReadOnly = true;
            tbxMail.ReadOnly = true;
            cbxLigue.Enabled = false;

            //ouvrir la connexion
            maCommande.Connection = maConnexion;
            maConnexion.Open();

            //remplir la listbbox
            maCommande.CommandText = "SELECT nom, prénom FROM MEMBRE";
            unDR = maCommande.ExecuteReader();
            while(unDR.Read())
            {
                String nomPrenom = unDR.GetValue(0).ToString() + " " + unDR.GetValue(1).ToString();
                lbxMembre.Items.Add(nomPrenom);  
            }
            unDR.Close();

            //si lbxMembre est vide, alors on ne peux supprimer ou modifier mais seulement ajouter
            if (lbxMembre.Items.Count != 0)
            {
                lbxMembre.SelectedIndex = 0;
            }
            else
            {
                btnSupprimer.Enabled = false;
                btnModifier.Enabled = false;
            }
            maConnexion.Close();         
        }

        private void lbxMembre_SelectedIndexChanged(object sender, EventArgs e)
        {
            //réintialiser la connexion
            maConnexion.Close();
            maConnexion.Open();
            maCommande.Connection = maConnexion;

            String nomSelect;

            //si on clique sur autre chose qu'un Item dans la listbox, rien ne se passe. Sinon On stock dans nomSelect le du membre selectionné
            if (lbxMembre.SelectedItem == null)
            {
                return;
            }
            else
            {
                nomSelect = lbxMembre.SelectedItem.ToString().Split(' ')[0];
            }

            //Remplir les textboxes correspondants au membre selectionné
            maCommande.CommandText = "SELECT * FROM MEMBRE WHERE nom = '" + nomSelect + "';";
            unDR = maCommande.ExecuteReader();
            unDR.Read();

            tbxNom.Text = unDR.GetValue(1).ToString();
            tbxPrenom.Text = unDR.GetValue(2).ToString();
            tbxTel.Text = unDR.GetValue(3).ToString();
            tbxMail.Text = unDR.GetValue(4).ToString();

            unDR.Close();

            //config de la combobox (pour la modifier)
            cbxLigue.Items.Clear();
            maCommande.CommandText = "SELECT nom FROM LIGUE";
            unDR = maCommande.ExecuteReader();
            while (unDR.Read())
            {
                cbxLigue.Items.Add(unDR.GetValue(0).ToString());
            }
            unDR.Close();

            //Remplir cbxLigue correpondant au membre selectionné
            maCommande.CommandText = "SELECT nom FROM LIGUE WHERE codeLigue = (SELECT codeLigue FROM MEMBRE WHERE nom = '" + nomSelect + "')";
            unDR = maCommande.ExecuteReader();
            while (unDR.Read())
            {
                if (cbxLigue.Items.Contains(unDR.GetValue(0).ToString()))
                {
                    int index = cbxLigue.Items.IndexOf(unDR.GetValue(0).ToString());
                    cbxLigue.SelectedIndex = index;
                }
            }
            unDR.Close();

            //couper la connexion
            maConnexion.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            String nNom = tbxNom.Text.ToString();
            String nPrenom = tbxPrenom.Text.ToString();
            String nTel = tbxTel.Text.ToString();
            String nMail = tbxMail.Text.ToString();
            String aNom = lbxMembre.SelectedItem.ToString().Split(' ')[0];
            String nLigue = cbxLigue.SelectedItem.ToString();

            //si on appuie sur le bouton modifier
            if (btnModifier.Text == "Modifier") 
            {
                //Activer la saisie
                tbxNom.ReadOnly = false;
                tbxPrenom.ReadOnly = false;
                tbxTel.ReadOnly = false;
                tbxMail.ReadOnly = false;
                cbxLigue.Enabled = true;

                //désactiver les elements clickables
                lbxMembre.Enabled = false;
                btnAjouter.Enabled = false;
                btnFiltreMembre.Enabled = false;
                tbxFiltreMembre.Enabled = false;

                btnModifier.Text = "Enregistrer"; //transformer le bouton modifier en bouton enregistrer
                btnSupprimer.Text = "Annuler"; //transformer le bouton supprimer en bouton annuler
            }
            else
            {
                //Désactiver la saisie
                tbxNom.ReadOnly = true;
                tbxPrenom.ReadOnly = true;
                tbxTel.ReadOnly = true;
                tbxMail.ReadOnly = true;
                cbxLigue.Enabled = false;

                //réactiver les elements clickables
                lbxMembre.Enabled = true;
                btnAjouter.Enabled = true;
                btnFiltreMembre.Enabled = true;
                tbxFiltreMembre.Enabled = true;

                btnModifier.Text = "Modifier"; //transformer le bouton modifier en bouton enregistrer
                btnSupprimer.Text = "Supprimer"; //transformer le bouton supprimer en bouton annuler

                //ouvrir la connexion
                maCommande.Connection = maConnexion;
                maConnexion.Open();

                //config de cbxLigue
                maCommande.CommandText = "SELECT codeLigue FROM LIGUE WHERE nom = '" + nLigue + "'";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    codeLigue = unDR.GetValue(0).ToString();
                }
                unDR.Close();                

                //envoyer la requete
                maCommande.CommandText = "UPDATE MEMBRE SET nom = '" + nNom + "', prénom = '" + nPrenom + "', téléphone = '" + nTel + "', mail = '" + nMail + "', codeLigue = '" + codeLigue + "'" + "WHERE nom = '" + aNom + "';";
                maCommande.ExecuteNonQuery();

                //Clear la listbox et remettre les nouvelles valeurs à l'interieur
                lbxMembre.Items.Clear();
                maCommande.CommandText = "SELECT * FROM MEMBRE";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    lbxMembre.Items.Add(unDR.GetValue(1).ToString() + " " + unDR.GetValue(2).ToString());
                }
                unDR.Close();

                //si lbxMembre est vide, alors on ne peux supprimer ou modifier mais seulement ajouter
                if (lbxMembre.Items.Count != 0)
                {
                    lbxMembre.SelectedIndex = 0;
                }
                else
                {
                    btnSupprimer.Enabled = false;
                    btnModifier.Enabled = false;
                }

                //couper la connexion
                maConnexion.Close();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            //cbxLigue.SelectedIndex = 0;
            String nNom = tbxNom.Text.ToString();
            String nPrenom = tbxPrenom.Text.ToString();
            String nTel = tbxTel.Text.ToString();
            String nMail = tbxMail.Text.ToString();
            String nLigue = cbxLigue.SelectedItem.ToString();

            //si on appuie sur le bouton ajouter
            if (btnAjouter.Text == "Ajouter")
            {
                tbxNom.Text = "";
                tbxPrenom.Text = "";
                tbxTel.Text = "";
                tbxMail.Text = ""; 

                tbxNom.ReadOnly = false;
                tbxPrenom.ReadOnly = false;
                tbxTel.ReadOnly = false;
                tbxMail.ReadOnly = false;

                cbxLigue.Enabled = true;
                lbxMembre.Enabled = false;
                btnModifier.Enabled = false;

                btnAjouter.Text = "Enregistrer";
                btnSupprimer.Text = "Annuler";
            }
            else
            {
                tbxNom.ReadOnly = true;
                tbxPrenom.ReadOnly = true;
                tbxTel.ReadOnly = true;
                tbxMail.ReadOnly = true;

                cbxLigue.Enabled = false;
                lbxMembre.Enabled = true;
                btnModifier.Enabled = true;

                btnAjouter.Text = "Ajouter";
                btnSupprimer.Text = "Supprimer";

                //config de cbxLigue
                maCommande.Connection = maConnexion;
                maConnexion.Open();
                maCommande.CommandText = "SELECT codeLigue FROM LIGUE WHERE nom = '"+ nLigue + "'";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    codeLigue = unDR.GetValue(0).ToString();
                }
                unDR.Close();

                //enregistrer les données dans la bdd
                maCommande.CommandText = "INSERT INTO MEMBRE (nom, prénom, téléphone, mail, codeLigue) values ('" + nNom + "','" + nPrenom + "','" + nTel + "','" + nMail + "','" + codeLigue + "')";
                maCommande.ExecuteNonQuery();

                //Clear la listbox et remettre les nouvelles valeurs à l'interieur
                lbxMembre.Items.Clear();
                maCommande.CommandText = "SELECT nom, prénom FROM MEMBRE";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    lbxMembre.Items.Add(unDR.GetValue(0).ToString() + " " + unDR.GetValue(1).ToString());
                }
                unDR.Close();
                maConnexion.Close();

                //si lbxMembre est vide, alors on ne peux supprimer ou modifier mais seulement ajouter
                if (lbxMembre.Items.Count != 0)
                {
                    lbxMembre.SelectedIndex = 0;
                }
                else
                {
                    btnSupprimer.Enabled = false;
                    btnModifier.Enabled = false;
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            maCommande.Connection = maConnexion;

            btnAjouter.Text = "Ajouter";
            btnModifier.Text = "Modifier";

            tbxNom.ReadOnly = true;
            tbxPrenom.ReadOnly = true;
            tbxTel.ReadOnly = true;
            tbxMail.ReadOnly = true;

            cbxLigue.Enabled = false;
            lbxMembre.Enabled = true;
            btnAjouter.Enabled = true;

            //si on appuie sur le bouton supprimer
            if (btnSupprimer.Text == "Supprimer")
            {
                //Affichier un message de confirmation lors du clique sur le bouton Supprimer
                DialogResult dr = MessageBox.Show("Voulez vous vraiment supprimer ce membre ?", "Supprimer ?", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                //si on clique sur OUI, on le supprimer. Si on clique sur NON,  rien ne se passe
                if (dr == DialogResult.Yes)
                {
                    //ouvrir la connexion
                    maConnexion.Open();

                    //on supprime d'abord l'enregistrement dépendant dans PARTICIPER
                    maCommande.CommandText = "DELETE FROM PARTICIPER WHERE codeMembre = (SELECT codeMembre FROM MEMBRE WHERE nom = '" + tbxNom.Text.ToString() + "')";
                    maCommande.ExecuteNonQuery();

                    //puis on supprime l'enregistrement de la table MEMBRE
                    maCommande.CommandText = "DELETE FROM MEMBRE WHERE nom = '" + tbxNom.Text.ToString() + "'";
                    maCommande.ExecuteNonQuery();

                    //Clear la listbox et remettre les nouvelles valeurs à l'interieur
                    lbxMembre.Items.Clear();
                    maCommande.CommandText = "SELECT nom, prénom FROM MEMBRE";
                    unDR = maCommande.ExecuteReader();
                    while (unDR.Read())
                    {
                        lbxMembre.Items.Add(unDR.GetValue(0).ToString() + " " + unDR.GetValue(1).ToString());
                    }
                    unDR.Close();
                    maConnexion.Close();

                }
                //couper la connexion
                maConnexion.Close();
            }
            else
            {
                //ouvrir la connexion
                maConnexion.Open();

                //remplir lbxMembre
                maCommande.CommandText = "SELECT nom, prénom FROM MEMBRE";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    lbxMembre.Items.Add(unDR.GetValue(0).ToString() + " " + unDR.GetValue(1).ToString());
                }
                unDR.Close();

                //refresh les valeurs dans les textbox
                lbxMembre.Items.Clear();

                //Clear la listbox et remettre les nouvelles valeurs à l'interieur
                lbxMembre.Items.Clear();
                maCommande.CommandText = "SELECT nom, prénom FROM MEMBRE";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    lbxMembre.Items.Add(unDR.GetValue(0).ToString() + " " + unDR.GetValue(1).ToString());
                }
                unDR.Close();

                //reremplir les textboxes correspondants au membre
                String nomSelect;
                lbxMembre.SelectedIndex = 0;
                nomSelect = lbxMembre.SelectedItem.ToString().Split(' ')[0];

                maConnexion.Open();
                maCommande.CommandText = "SELECT * FROM MEMBRE WHERE nom = '" + nomSelect + "';";
                unDR = maCommande.ExecuteReader();
                unDR.Read();

                tbxNom.Text = unDR.GetValue(1).ToString();
                tbxPrenom.Text = unDR.GetValue(2).ToString();
                tbxTel.Text = unDR.GetValue(3).ToString();
                tbxMail.Text = unDR.GetValue(4).ToString();

                unDR.Close();

                //couper la connexion
                maConnexion.Close();

                //renommer le bouton de "Annuler" à "Supprimer"
                btnSupprimer.Text = "Supprimer";
            }

            //si lbxMembre est vide, alors on ne peux supprimer ou modifier mais seulement ajouter
            if (lbxMembre.Items.Count != 0)
            {
                lbxMembre.SelectedIndex = 0;
            }
            else
            {
                btnSupprimer.Enabled = false;
                btnModifier.Enabled = false;
            } 
        }

        private void btnFiltreMembre_Click(object sender, EventArgs e)
        {
            //clear la listbox avant de la reremplir
            lbxMembre.Items.Clear();

            //ouvrir la connexion
            maCommande.Connection = maConnexion;
            maConnexion.Open();

            //requête qui va chercher les noms qui commencent par les lettres mises dans le textbox
            maCommande.CommandText = "SELECT nom FROM MEMBRE WHERE nom LIKE '" + tbxFiltreMembre.Text.ToString() + "%'";
            unDR = maCommande.ExecuteReader();
            while (unDR.Read())
            {
                lbxMembre.Items.Add(unDR.GetValue(0).ToString());
            }
            unDR.Close();

            //Si la listbox est vide à cause d'une recherche non concluante
            if (lbxMembre.Items.Count == 0)
            {
                //avertir d'un message
                MessageBox.Show("Il n'y a pas de résultat pour ''" + tbxFiltreMembre.Text.ToString() + "'");

                //clear la listbox
                lbxMembre.Items.Clear();
                maCommande.CommandText = "SELECT * FROM MEMBRE";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    lbxMembre.Items.Add(unDR.GetValue(1).ToString() + " " + unDR.GetValue(2).ToString());
                }

                unDR.Close();

                //remettre le filtre à 0
                tbxFiltreMembre.Text = "";

                //si lbxMembre est vide, alors on ne peux supprimer ou modifier mais seulement ajouter
                if (lbxMembre.Items.Count != 0)
                {
                    lbxMembre.SelectedIndex = 0;
                }
                else
                {
                    btnSupprimer.Enabled = false;
                    btnModifier.Enabled = false;
                }
                //couper la connexion
                maConnexion.Close();
            }
            //couper la connexion
            maConnexion.Close();
        }
    }
}
