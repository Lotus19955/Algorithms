using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    public class Methods
    {
        /// <summary>
        /// Finds the number of numbers in the string
        /// </summary>
        /// <param name="word">Input string</param>
        /// <returns>Return number of numbers</returns>
        public static int FindNumbersInString(string word)
        {
            if (ValidateString(word) == false)
            {
                return -1;
            }
            
            int counter = 0;
            int number;
            for (int i = 0; i < word.Length; i++)
            {
                if (int.TryParse(word[i].ToString(), out number))
                {
                    counter++;
                }
            }
            return counter;
        }

        /// <summary>
        /// Finds the string with max length
        /// </summary>
        /// <param name="setOfWords">Input string</param>
        /// <returns>Max length word</returns>
        public static string GetMaxLengthWord (string[] setOfWords)
        {
            if (ValidateArrayString(setOfWords) == false)
            {
                return null;
            }
            string maxLengthWord = null;
            for (int i = 0; i < setOfWords.Length; i++)
            {
                for (int j = 0; j < setOfWords.Length; j++)
                {
                    if (setOfWords[i].Length > setOfWords[j].Length)
                    {
                        maxLengthWord = setOfWords[i];
                    }
                }
            }
            return maxLengthWord;
        }

        /// <summary>
        /// Validates string
        /// </summary>
        /// <param name="word">Input string</param>
        /// <returns>true or false</returns>
        private static bool ValidateString(string word)
        {
            if (word != null)
            {
                if (word.Length > 0)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Validates string
        /// </summary>
        /// <param name="word">Input string array</param>
        /// <returns>true or false</returns>
        private static bool ValidateArrayString(string[] setOfWords)
        {
            if (setOfWords != null)
            {
                if (setOfWords.Length > 0)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
