using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Diagnostics;
using metier;

namespace dao
{
    public class DbConnexion
    {
        const String SQL_BASEDEDONNEES = "chavals_GSB";
        const String SQL_USER = "chavals";
        const String SQL_PASSWORD = "chavals";

        private static MySqlConnection o_Connexion = new MySqlConnection();

        public static void connexionBase(String unServeur, int unPort)
        {
            String chaineConnexion = "Server=" + unServeur + ";Port=" + unPort + ";User=" + SQL_USER + ";Password=" + SQL_PASSWORD + ";Database=" + SQL_BASEDEDONNEES;
            o_Connexion.ConnectionString = chaineConnexion;
            o_Connexion.Open();
            
        }

        public static System.Data.ConnectionState etatConnexion()
        {
            return o_Connexion.State;
        }

        
        public static void SeDeconnecter()
        {
            try
            {
                o_Connexion.Close();
            }
            catch ( Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       


        public static MySqlDataReader GetDataReader(string uneRequete)
        {
            try
            {
                MySqlCommand uneCommande = new MySqlCommand(uneRequete, o_Connexion);
                MySqlDataReader reader = uneCommande.ExecuteReader();

                
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

      
        public static int noQuery(string uneRequete)
        {
            MySqlCommand uneCommande = new MySqlCommand(uneRequete, o_Connexion);
            return uneCommande.ExecuteNonQuery();
        }
    }
}
