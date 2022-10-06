using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon.Pokemon_types
{
    public class GrassType : Pokemon
    {
        public GrassType(string name, int hitpoints, int attackDamage, string move = "Tackle", string type = "Normal") : base(name, hitpoints, attackDamage, move)
        {
            this.type = "Grass";
        }

        public bool isEffectiveAgainst(string type)
        {
            if (type == "Water")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isWeakTo(string type)
        {
            if (type == "Fire")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
