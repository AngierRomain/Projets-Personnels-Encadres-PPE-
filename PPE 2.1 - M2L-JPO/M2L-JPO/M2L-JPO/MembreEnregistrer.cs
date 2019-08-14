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


namespace M2L_JPO
{
    public partial class MembreEnregistrer : Form
    {
        OleDbConnection maConnexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = ..\..\..\M2L_JPO.accdb");
        OleDbCommand maCommande = new OleDbCommand();
        OleDbDataReader unDR;


        public MembreEnregistrer()
        {
            InitializeComponent();
        }

        private void MembreEnregistrer_Load(object sender, EventArgs e)
        {
            lbxMembre.Items.Clear();

            tbxNom.ReadOnly = true;
            tbxPrenom.ReadOnly = true;
            tbxTel.ReadOnly = true;
            tbxMail.ReadOnly = true;


            maCommande.Connection = maConnexion;
            maConnexion.Open();
            maCommande.CommandText = "SELECT nom, prénom FROM MEMBRE";
            unDR = maCommande.ExecuteReader();
            while(unDR.Read())
            {
                lbxMembre.Items.Add(unDR.GetValue(0).ToString() + " " + unDR.GetValue(1).ToString());
            }
            unDR.Close();
            maConnexion.Close();
        }

        private void lbxMembre_SelectedIndexChanged(object sender, EventArgs e)
        {
            maCommande.Connection = maConnexion;
            maConnexion.Open();

            String nomSelect;

            if (lbxMembre.SelectedItem == null)
            {
                return;
            }
            else
            {
                nomSelect = lbxMembre.SelectedItem.ToString().Split(' ')[0];
            }

            
            maCommande.CommandText = "SELECT * FROM MEMBRE WHERE nom = '" + nomSelect + "';";
            unDR = maCommande.ExecuteReader();
            unDR.Read();


            tbxNom.Text = unDR.GetValue(1).ToString();
            tbxPrenom.Text = unDR.GetValue(2).ToString();
            tbxTel.Text = unDR.GetValue(3).ToString();
            tbxMail.Text = unDR.GetValue(4).ToString();

            unDR.Close();
            maConnexion.Close();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            String nNom = tbxNom.Text.ToString();
            String nPrenom = tbxPrenom.Text.ToString();
            String nTel = tbxTel.Text.ToString();
            String nMail = tbxMail.Text.ToString();

            if (btnModifier.Text == "Modifier") //si on appuie sur le bouton modifier
            {

                //Activer la saisie
                tbxNom.ReadOnly = false;
                tbxPrenom.ReadOnly = false;
                tbxTel.ReadOnly = false;
                tbxMail.ReadOnly = false;
                
                //désactiver les elements clickables
                lbxMembre.Enabled = false;

                btnAjouter.Enabled = false; 

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

                //réactiver les elements clickables
                lbxMembre.Enabled = true;
                btnAjouter.Enabled = true;

                btnModifier.Text = "Modifier"; //transformer le bouton modifier en bouton enregistrer
                btnSupprimer.Text = "Supprimer"; //transformer le bouton supprimer en bouton annuler

                //ouvrir la connexion
                maCommande.Connection = maConnexion;
                maConnexion.Open();

                //faire la requette
                maCommande.CommandText = "UPDATE MEMBRE SET nom = '" + nNom + "', prénom = '" + nPrenom + "', téléphone = '" + nTel + "', mail = '" + nMail + "'WHERE nom = '" + lbxMembre.SelectedItem.ToString() + "';";
                maCommande.ExecuteNonQuery();

                //Clear la listbox et remettre les nouvelles valeurs à l'interieur
                lbxMembre.Items.Clear();
                maCommande.CommandText = "SELECT nom FROM MEMBRE";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    lbxMembre.Items.Add(unDR.GetValue(0).ToString());
                }
                unDR.Close();
                maConnexion.Close();
            }
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            String nNom = tbxNom.Text.ToString();
            String nPrenom = tbxPrenom.Text.ToString();
            String nTel = tbxTel.Text.ToString();
            String nMail = tbxMail.Text.ToString();

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

                lbxMembre.Enabled = true;
                btnModifier.Enabled = true;

                btnAjouter.Text = "Ajouter";
                btnSupprimer.Text = "Supprimer";


                maCommande.Connection = maConnexion;
                maConnexion.Open();
/*!\\ régler le problème codeLigue
-------->*/     maCommande.CommandText = "INSERT INTO MEMBRE (nom, prénom, téléphone, mail, codeLigue) values ('" + nNom + "','" + nPrenom + "','" + nTel + "','" + nMail + "', 1)";
                maCommande.ExecuteNonQuery();

                //Clear la listbox et remettre les nouvelles valeurs à l'interieur
                lbxMembre.Items.Clear();
                maCommande.CommandText = "SELECT nom FROM MEMBRE";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    lbxMembre.Items.Add(unDR.GetValue(0).ToString());
                }
                unDR.Close();
                maConnexion.Close();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            //Affichier un message de confirmation lors du clique sur le bouton Supprimer
            DialogResult dr = MessageBox.Show("Voulez vous vraiment supprimer ce membre ?", "Supprimer ?", MessageBoxButtons.YesNo,
            MessageBoxIcon.Information);

            //si on clique sur OUI, on le supprimer. Si on clique sur NON,  rien ne se passe
            if (dr == DialogResult.Yes)
            {
                maCommande.Connection = maConnexion;
                maConnexion.Open();

                maCommande.CommandText = "DELETE FROM MEMBRE WHERE nom = '" + tbxNom.Text.ToString() + "'";
                maCommande.ExecuteNonQuery();

                //Clear la listbox et remettre les nouvelles valeurs à l'interieur
                lbxMembre.Items.Clear();
                maCommande.CommandText = "SELECT nom FROM MEMBRE";
                unDR = maCommande.ExecuteReader();
                while (unDR.Read())
                {
                    lbxMembre.Items.Add(unDR.GetValue(0).ToString());
                }
                unDR.Close();
                maConnexion.Close();
            }
        }

        private void btnFiltreMembre_Click(object sender, EventArgs e)
        {
            lbxMembre.Items.Clear();
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
            maConnexion.Close();
        }
    }
}
