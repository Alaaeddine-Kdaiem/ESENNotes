using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entities
{
    public class Devoir
    {
        public int id { get; set; }
        public string devoir { get; set; }


        public Devoir(int id, string devoir)
        {
            this.id = id;
            this.devoir = devoir;
        }
        
        public Devoir()
        {
        }

        public string toString()
        {
            string s = "Id: " + id + ", devoir: " + devoir;
            return s;
        }
    }
}
