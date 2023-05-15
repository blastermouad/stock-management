using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABRIME.mouad.BL
{
    internal class CLS_Client
    {
        private dbStockContext db=new dbStockContext();
        private Client C;
        
        public bool Ajoute_Client(string Nom,string Prenom,string Adresse,string Telephone,string Email,string Pays,string Ville)
        {
            C = new Client();
            C.Nom_Client = Nom;
            C.Prenom_Client = Prenom;
            C.Adresse_Client = Adresse;
            C.Telephonne_Client = Telephone;
            C.Pays_Client = Pays; 
            C.Ville_Client = Ville;
            C.Email_Client = Email;
            
           
            
            
            //verif db:
            if(db.Clients.SingleOrDefault(s=>s.Nom_Client==Nom && C.Prenom_Client == Prenom) == null)
            {
                db.Clients.Add(C);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Modifier_Client(int id, string Nom, string Prenom, string Adresse, string Telephone, string Email, string Pays, string Ville)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id);
            if(C != null)
            {
                C.Nom_Client = Nom;
                C.Email_Client= Email;
                C.Ville_Client= Ville;
                C.Prenom_Client= Prenom;
                C.Adresse_Client= Adresse;
                C.Telephonne_Client= Telephone;
                C.Pays_Client = Pays;
                db.SaveChanges();
            }
        }
        //suprimer
        public void suprimer_Client(int id)
        {
            C = new Client();
            C = db.Clients.SingleOrDefault(s => s.ID_Client == id );
            if(C != null)
            {
                db.Clients.Remove(C);
                db.SaveChanges();
            }
        }
    }
}
