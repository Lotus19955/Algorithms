using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringMethods;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "dh231n4f8f12h";
            int x = StringMethods.Methods.FindNumbersInString(word);
            if (x != -1)
            {
                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine("Your array is null or empty");
            }

            string[] setOfWords = { "hello", "my", "name", "is", "Andrei" };
            string y = StringMethods.Methods.GetMaxLengthWord(setOfWords);
            if (y != null)
            {
                Console.WriteLine(y);
            }
            else
            {
                Console.WriteLine("Your array is null or empty");
            }
            Console.ReadLine();
        }
    }
}
