using metier;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dao
{
    public class TypeFraisDAO
    {
        public static List<TypeFrais> chargerTypesFrais()
        {
            List<TypeFrais> uneListeFraisForfait = new List<TypeFrais>();
            String uneRequete = "Select id, libelle, montant from typefrais";

            try
            {
                MySqlDataReader unDataReader = DbConnexion.GetDataReader(uneRequete);
              
                while (unDataReader.Read())
                {
                    TypeFrais unTypeFrais = new TypeFrais(unDataReader.GetString(0), unDataReader.GetString(1), unDataReader.GetDecimal(2));
                    uneListeFraisForfait.Add(unTypeFrais);
                }

                unDataReader.Close();
                return uneListeFraisForfait;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erreur chargement liste typeFrais : ", ex.Message);
                return null;
            }
        }
    }
}






