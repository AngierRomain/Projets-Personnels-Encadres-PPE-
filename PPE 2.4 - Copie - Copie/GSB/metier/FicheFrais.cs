using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace metier
{
    public class FicheFrais
    {
        private int i_IdFiche;
        private int i_Mois;
        private int i_Annee;
        private DateTime dt_DateCreation;
        private DateTime? dt_DateCloture;
        private String s_Etat;
        private Decimal? d_MontantDeclare;
        private Utilisateur o_Utilisateur;
        private List<LigneFrais> o_LesLignes;

        
        public FicheFrais(int unIdFiche , int unMois, int uneAnnee,  DateTime uneDateCreation, DateTime? uneDateCloture, String unEtat, Decimal? unMontantDeclare  ,Utilisateur unUtilisateur) {
            i_IdFiche = unIdFiche;
            i_Mois = unMois;
            i_Annee = uneAnnee;
            dt_DateCreation = uneDateCreation;
            dt_DateCloture = uneDateCloture;
            s_Etat = unEtat;
            d_MontantDeclare = unMontantDeclare;

            o_Utilisateur = unUtilisateur;
            o_LesLignes = new List<LigneFrais>();
         }


        public int getId()
        {
            return i_IdFiche;
        }

        public int getMois()
        {
            return i_Mois;
        }
        public int getAnnee()
        {
            return i_Annee;
        }

        public DateTime getDateCreation()
        {
            return dt_DateCreation;
        }
        public DateTime? getDateCloture()
        {
            return dt_DateCloture;
        }

        public String getEtat()
        {
            return s_Etat;
        }

        public Decimal? getMontantDeclare()
        {
            return d_MontantDeclare;
        }

  
        public Utilisateur getUtilisateur()
        {
            return o_Utilisateur;
        }


        /// <summary>
        /// Retourne l'état de la fiche de frais en toutes lettres
        /// </summary>
        /// <returns></returns>
        public String getEtatLong()
        {
           switch (s_Etat){
                case "EC":
                    return "EC-En cours de saisie";
                case "CL":
                    return "CL-Clôturée";
                case "VA":
                    return "VA-Validée";
                case "MP":
                    return "MP-Mise en paiement";
                default:
                    return "RB Remboursée";

            }
                
        }

        
        /// <summary>
        /// Retourne l'année + le mois en lettres
        /// </summary>
        /// <returns></returns>
        public String getMoisAnnee()
        {
            CultureInfo culture = new CultureInfo("fr-Fr");
           
            return i_Annee.ToString() + "-" + i_Mois.ToString("00")+ " ["+ culture.DateTimeFormat.GetMonthName(i_Mois) + "]";
        }

        public String getNomPrenomVisiteur()
        {
            return o_Utilisateur.getNom() +  " " + o_Utilisateur.getPrenom();
        }


        public Decimal? getTotalDeclare()
        {
            
            Decimal? total = 0;
            foreach (LigneFrais unLigneFrais in o_LesLignes)
            {
                total += unLigneFrais.getQuantiteDeclaree() * unLigneFrais.getTypeFrais().getMontant();
            }
            return total;
        }

        public void setLignesFrais(List<LigneFrais> uneListeLignesFrais)
        {
            o_LesLignes = uneListeLignesFrais;
        }

        public void changerEtatFiche(String nouvelEtat)
        {
            s_Etat = nouvelEtat;
        }
    }
}
