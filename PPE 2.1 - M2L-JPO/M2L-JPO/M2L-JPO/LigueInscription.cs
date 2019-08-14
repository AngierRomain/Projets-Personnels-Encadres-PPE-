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
    public partial class LigueInscription : Form
    {
        //Initialisation de la connexion à la base de données
        OleDbConnection maConnexion = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0;" + @"Data Source = ..\..\..\M2L_JPO1.accdb");
        OleDbCommand maCommande = new OleDbCommand();
        OleDbDataReader unDR;
        public LigueInscription()
        {
            InitializeComponent();
        }

        private void LigueInscription_Load(object sender, EventArgs e)
        {
           
            //Ouverture de la connexion et execution de la requete
            maCommande.Connection = maConnexion;
            maConnexion.Open();
            maCommande.CommandText = "SELECT nom FROM LIGUE";
            unDR = maCommande.ExecuteReader();
            while (unDR.Read())
            {
                
                cbxChoixLigue.Items.Add(unDR.GetValue(0).ToString());
            }
            unDR.Close();
            unDR.Dispose();
            cbxChoixLigue.SelectedIndex = 0;

        }
    }
}
