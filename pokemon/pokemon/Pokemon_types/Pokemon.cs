using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon.Pokemon_types
{
    public class Pokemon
    {
       public string name;
       public int hitpoints;
       public int attackDamage;
       public string move;
       public string type;

         public Pokemon(string name, int hitpoints, int attackDamage, string move = "Tackle", string type = "Normal")
        {
            this.name = name;
            this.hitpoints = hitpoints;
            this.attackDamage = attackDamage;
            this.move = move;
            this.type = type;
        }

        public bool isEffectiveAgainst()
            {
                return false;
            }

           public bool isWeakTo()
            {
                return false;
            }

          public void takeDamage(int damage)
        {
            hitpoints = hitpoints -= damage;
        }

        public int useMove()
        {
            Console.WriteLine(name + " used " + move);
            return attackDamage;
        }

        public bool hasFainted()
        {
            if (hitpoints == 0)
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
