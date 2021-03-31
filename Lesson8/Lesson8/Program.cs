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
            string word = "codeleet";
            int[] indices = { 4, 5, 6, 7, 0 ,2, 1, 3, };

            string x = ArrayShuffle.ShuffleString(word, indices);
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
