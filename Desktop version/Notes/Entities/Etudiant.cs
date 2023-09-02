using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entities
{
    public class Etudiant
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int id_filiere { get; set; }
        public int id_classe { get; set; }
        public int id_user { get; set; }

        public Etudiant(int id,string nom, string prenom, int id_filiere, int id_classe)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.id_filiere = id_filiere;
            this.id_classe = id_classe;
        }
        public Etudiant(string nom, string prenom, int id_filiere, int id_classe)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.id_filiere = id_filiere;
            this.id_classe = id_classe;
        }
        public Etudiant()
        {
        }

        public string toString()
        {
            string s = "Id: " + id + ", nom: " + nom + ", prenom: " + prenom + ", Role: Etudiant , id User: " + id_user;
            return s;
        }
    }
}
