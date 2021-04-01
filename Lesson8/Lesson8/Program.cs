using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shuffle;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Your Array must be the same Langth as integer Array, and Array indices should not be more than a long word 
            string word = "codeleet";                           
            int[] indices = { 4, 5, 6, 7, 0 ,2, 1, 3, };

            string x = ArrayShuffle.ShuffleString(word, indices);
            if (x != null)
            {
                Console.WriteLine(x);
            }
            else 
            {
                Console.WriteLine("Your array does not match the conditions");
            }
            Console.ReadLine();
        }
    }
}
