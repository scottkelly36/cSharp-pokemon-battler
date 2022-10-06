using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using pokemon.Pokemon_types;
using pokemon.Pokemon_Species;


namespace pokemon
{
    class Program
    {
        static void Main(string[] args)
        {

            Rattata charmander1 = new Rattata(70, 19);
            Console.WriteLine(charmander1.useMove());
            Console.ReadLine();
        }
    }
}
