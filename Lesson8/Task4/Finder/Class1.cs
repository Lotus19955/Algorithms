using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finder
{
    public class ArrayMethods
    {
        /// <summary>
        /// Find vowels in word witout duplicates
        /// </summary>
        /// <param name="word">String variable</param>
        /// <returns>Numbers of vowels in your word</returns>
        public static int FindVowelsCount(string word)
        {
            char[] vowelsArray= {'e', 'y', 'u', 'i', 'o', 'a'};
            int counter = 0;
            foreach (char x in word)
            {
                foreach (char i in vowelsArray)
                {
                    if (x == i)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
        /// <summary>
        /// Find vowels in word
        /// </summary>
        /// <param name="word">String variable</param>
        /// <returns>Numbers of vowels in your word witout duplicates</returns>
        public static int FindVowelsCountWithoutDuplicates(string word)
        {
            if (ValidateArray(word) == false)
            {
                return -1;
            }

            char[] vowelsArray = { 'e', 'y', 'u', 'i', 'o', 'a' };
            char[] arrayWithoutDuplicate = new char[0];

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < vowelsArray.Length; j++)
                {
                    if (word[i] == vowelsArray[j])
                    {
                        Array.Resize(ref arrayWithoutDuplicate, arrayWithoutDuplicate.Length + 1);
                        arrayWithoutDuplicate[0] = vowelsArray[j];
                        arrayWithoutDuplicate[0]++;
                    }
                }
            }

            Array.Resize(ref arrayWithoutDuplicate, arrayWithoutDuplicate.Length - 1);
            int counter = arrayWithoutDuplicate.Length;
            return counter;
        }
        private static bool ValidateArray(string Word)
        {
            if (Word != null)
            {
                if (Word.Length > 0 )
                {
                    return true;
                }
            }
            return false;
        }
    }
}
