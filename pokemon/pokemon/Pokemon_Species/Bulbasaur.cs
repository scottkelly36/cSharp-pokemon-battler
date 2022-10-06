using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokemon.Pokemon_types;

namespace pokemon.Pokemon_Species
{
    public class Bulbasaur : GrassType
    {
        public Bulbasaur(int hitpoints, int attackDamage, string move = "Tackle", string type = "Grass", string name = "Bulbasaur") : base(name, hitpoints, attackDamage, move, type)
        {
            this.move = "Vine whip";
        }
    }
}
