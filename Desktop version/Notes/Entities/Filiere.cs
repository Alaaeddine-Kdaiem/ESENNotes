using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entities
{
    public class Filiere
    {
        public int id { get; set; }
        public string filiere { get; set; }


        public Filiere(int id, string filiere)
        {
            this.id = id;
            this.filiere = filiere;
        }

        public Filiere()
        {
        }

        public string toString()
        {
            string s = "Id: " + id + ", devoir: " + filiere;
            return s;
        }
    }
}
