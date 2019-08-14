using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public class TypeFrais
    {
        private String s_Id;
        private String s_Libelle;
        private Decimal d_Montant;
     


        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="unId"></param>
        /// <param name="unLibelle"></param>
        /// <param name="unMontant"></param>
        /// <param name="unCodeTarifKM"></param>
        public TypeFrais(String unId, String unLibelle, Decimal unMontant)
        {
            s_Id = unId;
            s_Libelle = unLibelle;
            d_Montant = unMontant;
        }



        public String getId()
        {
            return s_Id;
        }

        public String getLibelle()
        {
            return s_Libelle;
        }

        public Decimal getMontant()
        {
            return d_Montant;
        }

    }
}
