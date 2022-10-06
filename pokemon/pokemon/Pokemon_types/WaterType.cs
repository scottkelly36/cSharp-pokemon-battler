using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon.Pokemon_types
{
    public class WaterType : Pokemon
    {
        public WaterType(string name, int hitpoints, int attackDamage, string move = "Tackle", string type = "Normal") : base(name, hitpoints, attackDamage, move)
        {
            this.type = "Water";
        }
        public bool isEffectiveAgainst(string type)
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
        public bool isWeakTo(string type)
        {
            if (type == "Grass")
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
