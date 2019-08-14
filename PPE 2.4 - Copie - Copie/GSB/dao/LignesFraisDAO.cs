using metier;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    public class LignesFraisDAO
    {
        public static List<LigneFrais> chargerLignesFrais(int unIdFiche)
        {
            List<LigneFrais> uneListeLignessFrais = new List<LigneFrais>();
            String uneRequete = "SELECT idFiche, idTypeFrais, quantiteDeclaree FROM lignefrais where idFiche = " + unIdFiche;

            MySqlDataReader unDataReader = DbConnexion.GetDataReader(uneRequete);
            LigneFrais uneLigneFrais;

            int? uneQuantiteDeclaree;
            while (unDataReader.Read())
            {

                TypeFrais unTypeFrais = LesTypesFrais.chercherTypeFrais(unDataReader.GetString(1));

                uneQuantiteDeclaree = null;
                if (!unDataReader.IsDBNull(2))
                {
                    uneQuantiteDeclaree = unDataReader.GetInt32(2);
                }



                    uneLigneFrais = new LigneFrais(unDataReader.GetInt32(0), unDataReader.GetString(1), uneQuantiteDeclaree, unTypeFrais);

                    uneListeLignessFrais.Add(uneLigneFrais);
                }
                unDataReader.Close();
            return uneListeLignessFrais;
           



        }
    }
}
