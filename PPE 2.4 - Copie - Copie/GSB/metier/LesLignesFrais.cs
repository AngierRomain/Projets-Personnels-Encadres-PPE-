using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public class LesLignesFrais
    {
        private static List<LigneFrais> lesLignesFrais;

        public static void remplirLesLignesFrais(List<LigneFrais> uneListeLignesFrais)
        {
            lesLignesFrais = uneListeLignesFrais;
        }

        public static List<LigneFrais> obtenirLesLignesFrais()
        {
            return lesLignesFrais;
        }

        



        public static int nbLignesFrais()
        {
            return lesLignesFrais.Count;
        }
    }
}
