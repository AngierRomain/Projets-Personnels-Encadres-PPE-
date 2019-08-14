using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public class LigneFrais
    {

        private int i_IdFiche;
        private String s_IdTypeFrais;
        private int? i_QuantiteDeclaree;

        private TypeFrais o_TypeFrais;

               
        public LigneFrais(int unIdFiche, String unIdTypeFrais, int? uneQuantiteDeclaree , TypeFrais unTypeFrais)
        {
            i_IdFiche = unIdFiche;
            s_IdTypeFrais = unIdTypeFrais;
            i_QuantiteDeclaree = uneQuantiteDeclaree;
            o_TypeFrais = unTypeFrais;
    }



        public int getIdFiche()
        {
            return i_IdFiche;
        }

        public String getIdTypeFrais()
        {
            return s_IdTypeFrais;
        }

        public int? getQuantiteDeclaree()
        {
            return i_QuantiteDeclaree;
        }

        public TypeFrais getTypeFrais()
        {
            return o_TypeFrais;
        }

    }
}
