using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Entities
{
    public class Module
    {
        public int id { get; set; }
        public string module { get; set; }


        public Module(int id, string module)
        {
            this.id = id;
            this.module = module;
        }

        public Module()
        {
        }

        public string toString()
        {
            string s = "Id: " + id + ", devoir: " + module;
            return s;
        }
    }
}
