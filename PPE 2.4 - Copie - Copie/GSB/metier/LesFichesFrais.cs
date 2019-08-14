using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public class LesFichesFrais
    {
        private static List<FicheFrais> lesFichesFrais;

        public static void remplirLesFichesFrais(List<FicheFrais> uneListeFchesFrais)
        {
            lesFichesFrais = uneListeFchesFrais;
        }

        public static List<FicheFrais>  obtenirLesFichesFrais()
        {
            return lesFichesFrais;
        }

        public static FicheFrais chercherFicheFrais(int idFicheFrais)
        {
            foreach (FicheFrais uneFicheFrais in lesFichesFrais)
            {
                if (uneFicheFrais.getId() == idFicheFrais)
                {
                    return uneFicheFrais;
                }
            }
            return null;
        }



        public static int nbFichesFrais()
        {
            return lesFichesFrais.Count;
        }
    }
}
