using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entities
{
    public class Note
    {
        public double note { get; set; }
        public int etudiant { get; set; }
        public int semestre { get; set; }
        public int module { get; set; }
        public int filiere { get; set; }
        public int classe { get; set; }
        public int devoir { get; set; }

        public Note(double note, int etudiant, int semestre, int module, int filiere, int classe, int devoir)
        {
            this.note = note;
            this.etudiant = etudiant;
            this.semestre = semestre;
            this.module = module;
            this.filiere = filiere;
            this.classe = classe;
            this.devoir = devoir;
        }

        public Note( int etudiant, int semestre, int module, int filiere, int classe, int devoir)
        {
            
            this.etudiant = etudiant;
            this.semestre = semestre;
            this.module = module;
            this.filiere = filiere;
            this.classe = classe;
            this.devoir = devoir;
        }

        public Note()
        {
        }

        public string toString()
        {
            string s = "Id Etudiant: " + etudiant + ", Id semestre: " + semestre + ", Id module: " + module + ", Id filiere: " + filiere + ", Id classe: " + classe +", Id devoir: " + devoir + ", Note: "+ note;
            return s;
        }
    }
}
