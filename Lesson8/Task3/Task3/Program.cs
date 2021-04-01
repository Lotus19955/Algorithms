using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JewelsInStones;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string stones = "aAAbbbbaAffsf";
            string jewels = "aA";

            int x = JewelsInStones.SearchJewels.Searcher(stones, jewels);
            if (x != 0)
            {
                Console.WriteLine(x);
            }
            else 
            {
                Console.WriteLine("Your array does not match the conditions or empty");
            }
            Console.ReadLine();
        }
    }
}
