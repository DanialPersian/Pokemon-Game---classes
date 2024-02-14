using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_Challange
{
    internal class Pokemon
    {
        public string name;
        public int hitpoints;
        public string type;
        public string weakness;

        public Pokemon(string name, string type, int hitpoints, string weakness) : this(name, type,weakness)
        {
            this.hitpoints = hitpoints;
        }
        public Pokemon(string _name, string _type, string _weakness)
        {
            this.name = _name;
            this.type = _type;
            this.weakness = _weakness;
        }
    }
}
