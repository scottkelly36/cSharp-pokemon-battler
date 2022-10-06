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
            
            FireType fire1 = new FireType("sjnbcjnb", 10, 10);
            Console.WriteLine(fire1.useMove());
            Console.ReadLine();
        }
    }
}
