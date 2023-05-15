using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABRIME.mouad.BL
{
    internal class CLS_Connexion
    {
        public bool ConnexionValide(dbStockContext db,string Nom,string Mot_de_passe)
        {
            Utilisateur U = new Utilisateur();
            U.NomUtilisateur = Nom;
            U.Mot_De_Passe = Mot_de_passe;
            if (db.Utilisateurs.SingleOrDefault(s=>s.NomUtilisateur==Nom && s.Mot_De_Passe==Mot_de_passe)!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}