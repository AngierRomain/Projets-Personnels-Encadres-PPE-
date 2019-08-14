using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * Réalisé par Romain
 **/

namespace M2L_JPO
{
    public partial class LigueEnregistrer : Form
    {
        //Initialisation de la connexion à la base de données
        OleDbConnection maConnexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = ..\..\..\M2L_JPO.accdb");
        OleDbCommand maCommande = new OleDbCommand();
        OleDbDataReader unDR;
 
        public LigueEnregistrer()
        {
            InitializeComponent();
        }
        private void LigueEnregistrer_Load(object sender, EventArgs e)
        {
            
            //Ouverture de la connexion et execution de la requete
            maCommande.Connection = maConnexion;
            maConnexion.Open();
            maCommande.CommandText = "SELECT * FROM LIGUE";
            unDR = maCommande.ExecuteReader();
            while (unDR.Read())
            {
                lbxLigue.Items.Add(unDR.GetValue(1).ToString());
            }
            unDR.Close();
            maConnexion.Close();
            if (lbxLigue.Items.Count != 0)
            {
                lbxLigue.SelectedIndex = 0;
            }
        }

        private void lbxLigue_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Quand on est sur une ligue par défaut on ne peut pas modifier les différents champs
            tbxAdresse.ReadOnly = true;
            tbxDiscipline.ReadOnly = true;
            tbxNom.ReadOnly = true;
            tbxCodePostal.ReadOnly = true;
            tbxVille.ReadOnly = true;

            String nomSelect;


            if (lbxLigue.SelectedItem == null)
            {
                return;
            }
            else
            {
                nomSelect = lbxLigue.SelectedItem.ToString();
            }

            //On récupère toutes les informations de la ligue selectionnée 
            maCommande.Connection = maConnexion;
            maConnexion.Close();
            maConnexion.Open();
            maCommande.CommandText = "SELECT * FROM LIGUE WHERE nom = '" + nomSelect + "';";
            unDR = maCommande.ExecuteReader();
            unDR.Read();

            //On rempli notre interface avec les différentes informations que l'on a sur la ligue
            tbxNom.Text = unDR.GetValue(1).ToString();
            tbxAdresse.Text = unDR.GetValue(2).ToString();
            tbxCodePostal.Text = unDR.GetValue(3).ToString();
            tbxVille.Text = unDR.GetValue(4).ToString();
            tbxDiscipline.Text = unDR.GetValue(5).ToString();


            unDR.Close();
            maConnexion.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (btnAjouter.Text == "Ajouter")
            {
                tbxNom.Text = "";
                tbxAdresse.Text = "";
                tbxCodePostal.Text = "";
                tbxVille.Text = "";
                tbxDiscipline.Text = "";

                tbxNom.ReadOnly = false;
                tbxAdresse.ReadOnly = false;
                tbxCodePostal.ReadOnly = false;
                tbxVille.ReadOnly = false;
                tbxDiscipline.ReadOnly = false;

                lbxLigue.Enabled = false;
                btnModifier.Enabled = false;

                btnAjouter.Text = "Enregistrer";
                btnSupprimer.Text = "Annuler";
            }
            else
            {
                tbxNom.ReadOnly = true;
                tbxAdresse.ReadOnly = true;
                tbxCodePostal.ReadOnly = true;
                tbxVille.ReadOnly = true;
                tbxDiscipline.ReadOnly = true;

                lbxLigue.Enabled = true;
                btnModifier.Enabled = true;

                btnAjouter.Text = "Ajouter";
                btnSupprimer.Text = "Supprimer";

                //Ajouter la nouvelle ligue dans la base de données
                maCommande.Connection = maConnexion;
                maConnexion.Open();
                maCommande.CommandText = "INSERT INTO LIGUE (nom, adresse, codePostal, ville, discipline) values ('" + tbxNom.Text + "', '" + tbxAdresse.Text + "', '" + tbxCodePostal.Text + "', '" + tbxVille.Text + "', '" + tbxDiscipline.Text + "')";
                maCommande.ExecuteNonQuery();
                unDR = maCommande.ExecuteReader();
                unDR.Read();
                unDR.Close();
                MessageBox.Show("La ligue a bien été intégrée à la base de données.");

                //Rafraichir la ListBox
                lbxLigue.Items.Clear();
                maCommande.CommandText = "SELECT * FROM LIGUE";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    lbxLigue.Items.Add(unDR.GetValue(1).ToString());
                }
                unDR.Close();
                maConnexion.Close();
                if (lbxLigue.Items.Count != 0)
                {
                    lbxLigue.SelectedIndex = 0;
                }

            }
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            String nNom = tbxNom.Text.ToString();
            String nAdresse = tbxAdresse.Text.ToString();
            String nCodePostal = tbxCodePostal.Text.ToString();
            String nVille = tbxVille.Text.ToString();
            String nDiscipline = tbxDiscipline.Text.ToString();

            if (btnModifier.Text == "Modifier") //si on appuie sur le bouton modifier
            {
                //Activer la saisie
                tbxNom.ReadOnly = false;
                tbxAdresse.ReadOnly = false;
                tbxCodePostal.ReadOnly = false;
                tbxVille.ReadOnly = false;
                tbxDiscipline.ReadOnly = false;

                //désactiver les elements clickables
                lbxLigue.Enabled = false;
                btnAjouter.Enabled = false;

                btnModifier.Text = "Enregistrer"; //transformer le bouton modifier en bouton enregistrer
                btnSupprimer.Text = "Annuler"; //transformer le bouton supprimer en bouton annuler
            }
            else
            {
                string nomLigue = lbxLigue.SelectedIndex.ToString();
                //Désactiver la saisie
                tbxNom.ReadOnly = true;
                tbxAdresse.ReadOnly = true;
                tbxCodePostal.ReadOnly = true;
                tbxVille.ReadOnly = true;
                tbxDiscipline.ReadOnly = true;

                //réactiver les elements clickables
                lbxLigue.Enabled = true;
                btnAjouter.Enabled = true;

                btnModifier.Text = "Modifier"; //transformer le bouton modifier en bouton modifier
                btnSupprimer.Text = "Supprimer"; //transformer le bouton supprimer en bouton annuler

                //ouvrir la connexion
                maCommande.Connection = maConnexion;
                maConnexion.Open();




                //faire la requette
                maCommande.CommandText = "UPDATE LIGUE SET nom = '" + nNom + "', adresse= '" + nAdresse + "', codePostal= '" + nCodePostal + "', ville = '" + nVille + "', discipline = '" + nDiscipline + "'WHERE nom = '" + lbxLigue.SelectedItem.ToString() + "';";
                maCommande.ExecuteNonQuery();

                //Clear la listbox et remettre les nouvelles valeurs à l'interieur
                lbxLigue.Items.Clear();
                maCommande.CommandText = "SELECT nom FROM LIGUE";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    lbxLigue.Items.Add(unDR.GetValue(0).ToString());
                }
                unDR.Close();
                maConnexion.Close();
                if (lbxLigue.Items.Count != 0)
                {
                    lbxLigue.SelectedIndex = 0;
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            maCommande.Connection = maConnexion;

            btnAjouter.Text = "Ajouter";
            btnModifier.Text = "Modifier";

            tbxNom.ReadOnly = true;
            tbxAdresse.ReadOnly = true;
            tbxCodePostal.ReadOnly = true;
            tbxVille.ReadOnly = true;
            tbxDiscipline.ReadOnly = true;

            
            lbxLigue.Enabled = true;
            btnAjouter.Enabled = true;

            //si on appuie sur le bouton supprimer
            if (btnSupprimer.Text == "Supprimer")
            {

                //Afficher un message de confirmation lors du clic sur le bouton Supprimer
                DialogResult dr = MessageBox.Show("Voulez vous vraiment supprimer cette ligue ?", "Supprimer ?", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

                //si on clique sur OUI, on le supprime. Si on clique sur NON,  rien ne se passe
                if (dr == DialogResult.Yes)
                {
                    maCommande.Connection = maConnexion;
                    maConnexion.Open();

                    maCommande.CommandText = "DELETE * FROM PARTICIPER WHERE codeMembre = (SELECT codeMembre FROM MEMBRE WHERE codeLigue = (SELECT codeLigue FROM LIGUE WHERE nom = '" + tbxNom.Text.ToString() + "'))" + "';";
                    maCommande.ExecuteNonQuery();
                    maCommande.CommandText = "DELETE * FROM MEMBRE WHERE codeLigue = (SELECT codeLigue FROM LIGUE WHERE nom = '" + tbxNom.Text.ToString() + "')";
                    maCommande.ExecuteNonQuery();
                    maCommande.CommandText = "DELETE * FROM DEMANDER WHERE numInscription = (SELECT numInscription FROM INSCRIPTION WHERE codeLigue = (SELECT codeLigue FROM LIGUE WHERE codeLigue = '" + tbxNom.Text.ToString() + "'))" + "';";
                    maCommande.ExecuteNonQuery();
                    maCommande.CommandText = "DELETE * FROM INSCRIPTION WHERE codeLigue = (SELECT codeLigue FROM LIGUE WHERE nom = '" + tbxNom.Text.ToString() + "')" + "';";
                    maCommande.ExecuteNonQuery();
                    maCommande.CommandText = "DELETE * FROM LIGUE WHERE nom = '" + tbxNom.Text.ToString() + "'";
                    maCommande.ExecuteNonQuery();


                    //Clear la listbox et remettre les nouvelles valeurs à l'interieur
                    lbxLigue.Items.Clear();
                    maCommande.CommandText = "SELECT nom FROM LIGUE";
                    unDR = maCommande.ExecuteReader();
                    while (unDR.Read())
                    {
                        lbxLigue.Items.Add(unDR.GetValue(0).ToString());
                    }
                    unDR.Close();
                    maConnexion.Close();
                }
            }
            else
            {
                //ouvrir la connexion
                maConnexion.Open();

                //remplir lbxMembre
                maCommande.CommandText = "SELECT * FROM LIGUE";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    lbxLigue.Items.Add(unDR.GetValue(1).ToString());
                }
                unDR.Close();

                //refresh les valeurs dans les textbox
                lbxLigue.Items.Clear();

                //Clear la listbox et remettre les nouvelles valeurs à l'interieur
                lbxLigue.Items.Clear();
                maCommande.CommandText = "SELECT * FROM LIGUE";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    lbxLigue.Items.Add(unDR.GetValue(1).ToString());
                }
                unDR.Close();

                //reremplir les textboxes correspondants au membre
                String nomSelect;
                lbxLigue.SelectedIndex = 0;
                nomSelect = lbxLigue.SelectedItem.ToString();

                maConnexion.Open();
                maCommande.CommandText = "SELECT * FROM LIGUE WHERE nom = '" + nomSelect + "';";
                unDR = maCommande.ExecuteReader();
                unDR.Read();

                tbxNom.Text = unDR.GetValue(1).ToString();
                tbxAdresse.Text = unDR.GetValue(2).ToString();
                tbxCodePostal.Text = unDR.GetValue(3).ToString();
                tbxVille.Text = unDR.GetValue(4).ToString();
                tbxDiscipline.Text = unDR.GetValue(5).ToString();
                unDR.Close();

                //couper la connexion
                maConnexion.Close();

                //renommer le bouton de "Annuler" à "Supprimer"
                btnSupprimer.Text = "Supprimer";
            }
        }

        private void btnFiltreLigue_Click(object sender, EventArgs e)
        {
            lbxLigue.Items.Clear();
            maCommande.Connection = maConnexion;
            maConnexion.Open();

            //requête qui va chercher les noms qui commencent par les lettres mises dans le textbox
            maCommande.CommandText = "SELECT nom FROM LIGUE WHERE nom LIKE '" + tbxFiltreLigue.Text.ToString() + "%'";
            unDR = maCommande.ExecuteReader();
            while (unDR.Read())
            {
                lbxLigue.Items.Add(unDR.GetValue(0).ToString());
            }
            unDR.Close();

            if (lbxLigue.Items.Count == 0)
            {
                MessageBox.Show("Il n'y a pas de résultat pour ''" + tbxFiltreLigue.Text.ToString() + "'");
                //clear la listbox
                lbxLigue.Items.Clear();
                maCommande.CommandText = "SELECT nom FROM LIGUE";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    lbxLigue.Items.Add(unDR.GetValue(0).ToString());
                }
                unDR.Close();
                maConnexion.Close();
                tbxFiltreLigue.Text = "";
                unDR.Close();

                if (lbxLigue.Items.Count != 0)
                {
                    lbxLigue.SelectedIndex = 0;
                }
                else
                {
                    btnSupprimer.Enabled = false;
                    btnModifier.Enabled = false;
                }
            }

            maConnexion.Close();
           
        }
    }
}
