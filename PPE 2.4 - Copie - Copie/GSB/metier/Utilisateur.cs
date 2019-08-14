using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public class Utilisateur
    {
        private String s_Id;
        private String s_Nom ;
        private String s_Prenom;
        private String s_Login;
        private String s_Mdp;
        private String s_Adresse;
        private String s_Cp;
        private String s_Ville;
        private DateTime dt_DateEmbauche;
        private List<FicheFrais> o_MesFiches;
        

        public Utilisateur(String unId, String unNom , String unPrenom  , String unLogin , String unMdp , String uneAdresse , String unCp , String uneVille , DateTime uneDateEmb)
        {
            s_Id = unId;
            s_Nom = unNom;
            s_Prenom = unPrenom;
            s_Login = unLogin;
            s_Mdp = unMdp;
            s_Adresse = uneAdresse;
            s_Cp = unCp;
            s_Ville = uneVille;
            dt_DateEmbauche = uneDateEmb;
            o_MesFiches = new List<FicheFrais>();
        }


        public String getId()
        {
            return s_Id;
        }

        public String getNom()
        {
            return s_Nom;
        }

        public String getPrenom()
        {
            return s_Prenom;
        }

        public String getAdresse()
        {
            return s_Adresse;
        }

        public String getCodePostal()
        {
            return s_Cp;
        }

        public String getVille()
        {
            return s_Ville;
        }

        public DateTime getDateEmbauche()
        {
            return dt_DateEmbauche;
        }

        public String getNomComplet()
        {
            return s_Prenom + " " + s_Nom.ToUpper();
        }

        public String getCPVille()
        {
            return s_Cp + " " + s_Ville;
        }


        /// <summary>
        /// Retourne la liste des fiches de frais
        /// </summary>
        /// <returns></returns>
        public List<FicheFrais> getFichesDeFrais()
        {
            return o_MesFiches;
        }
       
    
    }
}
