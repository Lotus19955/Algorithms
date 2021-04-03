using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Finder;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "2aa3bbb1y2rr";
            int value = Finder.ArrayMethods.FindVowelsCount(word);
            int valueWithoutDuplicates = Finder.ArrayMethods.FindVowelsCountWithoutDuplicates(word);
            Console.WriteLine($"Гласные с дубликатом: {value}");
            Console.WriteLine($"Гласные с без дубликатов: {valueWithoutDuplicates}");
            Console.ReadLine();
        }
    }
}
