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
            string stringVowels = Finder.ArrayMethods.GetVowelsString(word);
            string stringVowelsWithoutDuplicates = Finder.ArrayMethods.GetVowelsStringWithoutDuplicates(word);

            Console.WriteLine($"Колличество гласных с дубликатом: {value}");
            Console.WriteLine($"Колличество гласных с без дубликатов: {valueWithoutDuplicates}");
            Console.WriteLine($"Гласные: {stringVowels}");
            Console.WriteLine($"Гласные без дубликатов: {stringVowelsWithoutDuplicates}");
            Console.ReadLine();
        }
    }
}
