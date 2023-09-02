using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entities
{
    public class Semestre
    {
        public int id { get; set; }
        public string semestre { get; set; }


        public Semestre(int id, string semestre)
        {
            this.id = id;
            this.semestre = semestre;
        }

        public Semestre()
        {
        }

        public string toString()
        {
            string s = "Id: " + id + ", devoir: " + semestre;
            return s;
        }
    }
}
