using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokemon.Pokemon_types;


namespace pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon pokemon1 = new Pokemon("Charmander", 10, 10);
            Console.WriteLine(pokemon1.isEffectiveAgainst());
            
            Console.ReadLine();
        }
    }
}
