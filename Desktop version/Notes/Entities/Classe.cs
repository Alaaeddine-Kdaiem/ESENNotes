using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entities
{
    public class Classe
    {
        public int id { get; set; }
        public string classe { get; set; }


        public Classe(int id, string classe)
        {
            this.id = id;
            this.classe = classe;
        }

        public Classe()
        {
        }

        public string toString()
        {
            string s = "Id: " + id + ", classe: " + classe;
            return s;
        }
    }
}
