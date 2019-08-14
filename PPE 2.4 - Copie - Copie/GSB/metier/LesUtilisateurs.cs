using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metier
{
    public class LesUtilisateurs
    {
        private static List<Utilisateur> lesUtilisateurs;

        public  static void  remplirListeUtilisateurs(List<Utilisateur> uneListeUtilisateurs)
        {
            lesUtilisateurs = uneListeUtilisateurs;
        }

        public static Utilisateur chercherUtilisateur(String idUtilisateur)
        {
            foreach(Utilisateur unUtilisateur in lesUtilisateurs)
            {
                if(unUtilisateur.getId() == idUtilisateur)
                {
                    return unUtilisateur;
                }  
            }
            return null;
        }

    }
}
