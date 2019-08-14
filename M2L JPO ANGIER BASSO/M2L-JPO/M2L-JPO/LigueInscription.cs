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
    public partial class LigueInscription : Form
    {
        String selectedCodeLigue;
        String nomLigue;
        //Initialisation de la connexion à la base de données
        OleDbConnection maConnexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = ..\..\..\M2L_JPO.accdb");
        OleDbCommand maCommande = new OleDbCommand();
        OleDbDataReader unDR;

        
        public LigueInscription()
        {
            InitializeComponent();
        }

        private void LigueInscription_Load(object sender, EventArgs e)
        {
            String selectedCodeLigue;
            clbEquipement.CheckOnClick = true;
            //Ouverture de la connexion et execution de la requete
            maCommande.Connection = maConnexion;
            maConnexion.Open();
            maCommande.CommandText = "SELECT nom FROM LIGUE";
            unDR = maCommande.ExecuteReader();
            //Ajouter les differentes ligues à la combobox
            while (unDR.Read())
            {
                cbxChoixLigue.Items.Add(unDR.GetValue(0).ToString());
            }
            unDR.Close();
            unDR.Dispose();
            cbxChoixLigue.SelectedIndex = 0;
            //Ajouter les différents equipements à la checkbox
            maCommande.CommandText = "SELECT * FROM EQUIPEMENT";
            unDR = maCommande.ExecuteReader();
            while (unDR.Read())
            {
                clbEquipement.Items.Add(unDR.GetValue(1).ToString());
            }
            unDR.Close();
            maConnexion.Close();
            if (clbEquipement.Items.Count != 0)
            {
                clbEquipement.SelectedIndex = 0;
            }
           

        }
   
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            
            if (btnAjouter.Text  == "Ajouter")
            {
                

                btnModifier.Enabled = false;
                btnAjouter.Text = "Enregistrer";
                btnSupprimer.Text = "Annuler";
                

                btnAjouter.Text = "Ajouter";
                    btnSupprimer.Text = "Supprimer";

                    //Inscrire la ligue à la JPO dans la base de données
                    maCommande.Connection = maConnexion;
                    maConnexion.Open();

                // Determine s'il y a des équipements selectionnés.  
                 if (clbEquipement.CheckedItems.Count != 0)
                  {
                    //On récupère numInscription dans une variable

                    maCommande.CommandText = "SELECT numInscription FROM INSCRIPTION";
                    unDR = maCommande.ExecuteReader();
                    
                    while (unDR.Read())
                    {
                        selectedCodeLigue = (unDR.GetValue(0).ToString());
                    }
                    unDR.Close();
                    //S'il y en a, boucler tous les résultats et les concatener dans une chaîne de caractères.  
                    
                        for (int x = 0; x < clbEquipement.CheckedItems.Count; x++)
                        {
                        maCommande.CommandText = "INSERT INTO DEMANDER (numInscription, codeEquipement) values ('" + selectedCodeLigue + "', '" + clbEquipement.CheckedItems[x].ToString() + "')";
                        }
                    maCommande.CommandText = "SELECT codeLigue FROM LIGUE WHERE nom = '" + cbxChoixLigue.SelectedItem.ToString() + "'"; 
                    unDR = maCommande.ExecuteReader();
                    while (unDR.Read())
                    {
                        nomLigue = unDR.GetValue(0).ToString();
                    }
                    unDR.Close();
                }
                    maConnexion.Close();
                    maConnexion.Open();
                    maCommande.CommandText = "INSERT INTO INSCRIPTION (longueur, largeur, codeLigue) values ('" + tbxLongueur.Text + "', '" + tbxLargeur.Text + "', '" + cbxChoixLigue.SelectedItem.ToString() + "')";
                    maCommande.ExecuteNonQuery();
                    unDR = maCommande.ExecuteReader();
                    unDR.Read();
                    unDR.Close();
                    MessageBox.Show("L'inscription a bien été prise en compte.");

                    //Rafraichir l'interface
                    tbxLongueur.Clear();
                    tbxLargeur.Clear();

                
            }
        }
    }
}
