using metier;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dao
{
    public class FicheFraisDAO
    {
        public static List<FicheFrais> chargerFichesFrais()
        {
            List<FicheFrais> uneListeFichesFrais = new List<FicheFrais>();
            String uneRequete = "SELECT idFiche, idUtilisateur,  mois, annee, dateCreation, dateCloture , etat , montantDeclare  FROM fichefrais";

            MySqlDataReader unDataReader = DbConnexion.GetDataReader(uneRequete);

            FicheFrais uneFicheFrais;

            DateTime? uneDate;
            Decimal? unMontantD  , unMontantV ;
            while (unDataReader.Read())
            {

                Utilisateur unUtilisateur = LesUtilisateurs.chercherUtilisateur(unDataReader.GetString(1));
                uneDate = null;
                unMontantD = null; 
                unMontantV = null;

                if (!unDataReader.IsDBNull(5)){
                    uneDate = unDataReader.GetDateTime(5);
                }
                if (!unDataReader.IsDBNull(7))
                {
                    unMontantD = unDataReader.GetDecimal(7);      
                }
                
                                        
                uneFicheFrais = new FicheFrais(unDataReader.GetInt32(0), unDataReader.GetInt32(2), unDataReader.GetInt32(3), unDataReader.GetDateTime(4), uneDate, unDataReader.GetString(6), unMontantD,  unUtilisateur);

                uneListeFichesFrais.Add(uneFicheFrais);
            }
            unDataReader.Close();
            return uneListeFichesFrais;
        }


        public static int enregistrerNouvelEtat(FicheFrais ficheFrais)
        {
            String uneRequete = "UPDATE fichefrais  SET etat = '" + ficheFrais.getEtat() + "' WHERE idFiche = " + ficheFrais.getId();
            return DbConnexion.noQuery(uneRequete);
        }
    }
}
