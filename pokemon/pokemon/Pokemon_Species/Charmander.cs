using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokemon.Pokemon_types;

namespace pokemon.Pokemon_Species
{
    public class Charmander : FireType
    {
        public Charmander( int hitpoints, int attackDamage, string move = "Tackle", string type = "Fire", string name = "Charmander") : base (name, hitpoints, attackDamage, move, type)
        {
            this.move = "Ember";
        }
    }
}
