using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon.Pokemon_types
{
    public class FireType : Pokemon
    {
       public FireType(string name, int hitpoints, int attackDamage, string move = "Tackle", string type = "Fire") : base(name, hitpoints, attackDamage, move) {
            this.type = "Fire";        
        }
        public bool isEffectiveAgainst(string type)
            {
                if(type == "Grass")
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
            if(type == "Water")
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
