using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokemon.Pokemon_types;

namespace pokemon.Pokemon_Species
{
    public class Rattata : Pokemon
    {

        public Rattata(int hitpoints, int attackDamage, string move = "Tackle", string type = "Normal", string name = "Rattata") : base(name, hitpoints, attackDamage, move)
        {
        }
    }
}
