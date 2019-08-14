using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public class LesTypesFrais
    {
        private static List<TypeFrais> lesTypesFrais;

        public static void remplirLesTypesFrais(List<TypeFrais> uneListeTypesFrais)
        {
            lesTypesFrais = uneListeTypesFrais;
        }

        public static List<TypeFrais> obtenirLesTypesFrais()
        {
            return lesTypesFrais;
        }


        public static TypeFrais chercherTypeFrais(String unIdTypeFrais)
        {
            foreach (TypeFrais unTypeFrais in lesTypesFrais)
            {
                if (unTypeFrais.getId() == unIdTypeFrais)
                {
                    return unTypeFrais;
                }
            }
            return null;
        }

    }
}
