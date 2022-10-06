using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokemon.Pokemon_types;

namespace pokemon.Pokemon_Species
{
    public class Squirtle : WaterType
    {
        public Squirtle(int hitpoints, int attackDamage, string move = "Tackle", string type = "Water", string name = "Squirtle") : base(name, hitpoints, attackDamage, move, type)
        {
            this.move = "Water gun";
        }
    }
}
