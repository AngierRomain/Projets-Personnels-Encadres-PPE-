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

namespace M2L_JPO
{
    public partial class LigueEnregistrer : Form
    {
        //Initialisation de la connexion à la base de données
        OleDbConnection maConnexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = ..\..\..\M2L_JPO1.accdb");
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
        }

        private void lbxLigue_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxAdresse.ReadOnly = true;
            tbxDiscipline.ReadOnly = true;
            tbxNom.ReadOnly = true;

            String nomSelect = lbxLigue.SelectedItem.ToString();

            maCommande.Connection = maConnexion;
            maConnexion.Open();
            maCommande.CommandText = "SELECT * FROM LIGUE WHERE nom = '" + nomSelect + "';";
            unDR = maCommande.ExecuteReader();
            unDR.Read();


            tbxNom.Text = unDR.GetValue(1).ToString();
            tbxAdresse.Text = unDR.GetValue(2).ToString();
            tbxDiscipline.Text = unDR.GetValue(3).ToString();

            unDR.Close();
            maConnexion.Close();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
           if(tbxNom.Text != "" && tbxAdresse.Text != "" && tbxDiscipline.Text != "")
            {
                maCommande.Connection = maConnexion;
                maConnexion.Open();
                maCommande.CommandText = "INSERT INTO LIGUE (nom, adresse, discipline) values ('" + tbxNom.Text + "', '" + tbxAdresse.Text + "', '" + tbxDiscipline.Text + "')";
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
            }
        }
    }
}
