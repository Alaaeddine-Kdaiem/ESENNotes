using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entities
{
    public class Employe
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int id_user { get; set; }


         
        public Employe(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
        }

        
        public Employe(int id, string nom, string prenom)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
        }
        public Employe()
        {
        }

        public string toString()
        {
            string s = "Id: " + id + ", nom: " + nom + ", prenom: " + prenom + ", Role: Employe , id User: " + id_user;
            return s;
        }
    }
}
