using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finder
{
    public class ArrayMethods
    {
        static char[] vowelsArray = { 'e', 'y', 'u', 'i', 'o', 'a' };

        /// <summary>
        /// Find vowels in word
        /// </summary>
        /// <param name="word">Input string</param>
        /// <returns>Numbers of vowels in your word</returns>
        public static int FindVowelsCount(string word)
        {
            if (ValidateString(word) == false)
            {
                return -1;
            }
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
        /// Find vowels in word witout duplicates
        /// </summary>
        /// <param name="word">Input string</param>
        /// <returns>Numbers of vowels in your word witout duplicates</returns>
        public static int FindVowelsCountWithoutDuplicates(string word)
        {
            if (ValidateString(word) == false)
            {
                return -1;
            }
            
            char[] arrayWithoutDuplicate = new char[0];
            int counterForArrayWithoutDuplicate = 0;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < vowelsArray.Length; j++)
                {
                    if (word[i] == vowelsArray[j])
                    {
                        Array.Resize(ref arrayWithoutDuplicate, arrayWithoutDuplicate.Length + 1);
                        arrayWithoutDuplicate[counterForArrayWithoutDuplicate] = vowelsArray[j];
                        counterForArrayWithoutDuplicate++;
                    }
                }
            }
            return GetCountValueWithoutDuplicates(arrayWithoutDuplicate);
          
        }

        /// <summary>
        /// Gets vowels counter without duplicates
        /// </summary>
        /// <param name="array">Array of char</param>
        /// <returns>Vowels counter without duplicates</returns>
        private static int GetCountValueWithoutDuplicates(char[] array)
        {
            int counter = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        counter--;
                    }

                }
            }
            return counter;
        }

        /// <summary>
        /// Gets vowels in string
        /// </summary>
        /// <param name="word">Input string</param>
        /// <returns>Vowels in strings</returns>
        public static string GetVowelsString(string word)
        {
            if (ValidateString(word) == false)
            {
                return null;
            }

            char[] vowelsWithoutDuplicate = new char[0];
            int GetVowelsString = 0;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < vowelsArray.Length; j++)
                {
                    if (word[i] == vowelsArray[j])
                    {
                        Array.Resize(ref vowelsWithoutDuplicate, vowelsWithoutDuplicate.Length + 1);
                        vowelsWithoutDuplicate[GetVowelsString] = vowelsArray[j];
                        GetVowelsString++;
                    }
                }
            }
            string result = new string(vowelsWithoutDuplicate);
            return result;
        }

        /// <summary>
        /// Gets vowels in string without duplicates
        /// </summary>
        /// <param name="word">Input string</param>
        /// <returns>Vowels in string without duplicates</returns>
        public static string GetVowelsStringWithoutDuplicates(string word)
        {
            if (ValidateString(word) == false)
            {
                return null;
            }

            char[] vowelsWithoutDuplicate = new char[0];
            int counterForArrayWithoutDuplicate = 0;

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < vowelsArray.Length; j++)
                {
                    if (word[i] == vowelsArray[j])
                    {
                        Array.Resize(ref vowelsWithoutDuplicate, vowelsWithoutDuplicate.Length + 1);
                        vowelsWithoutDuplicate[counterForArrayWithoutDuplicate] = vowelsArray[j];
                        counterForArrayWithoutDuplicate++;
                    }
                }
            }

            return GetVowelsWithoutDuplicates(vowelsWithoutDuplicate);
        }

        /// <summary>
        /// Delete duplicates in array string
        /// </summary>
        /// <param name="array">Array of char</param>
        /// <returns>Vowels in string without duplicates</returns>
        private static string GetVowelsWithoutDuplicates(char[] array)
        {
            char[] arrayWithoutDuplicate = new char[0];
            int counterForArrayWithoutDuplicate = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (arrayWithoutDuplicate.Length > 0)
                {
                    bool isHasDuplicate = false;
                    for (int j = 0; j < arrayWithoutDuplicate.Length; j++)
                    {
                        if (array[i] == arrayWithoutDuplicate[j])
                        {
                            isHasDuplicate = true;
                        }
                        if (isHasDuplicate == true)
                        {
                            break;
                        }
                    }
                    if (isHasDuplicate == false)
                    {
                        Array.Resize(ref arrayWithoutDuplicate, arrayWithoutDuplicate.Length + 1);
                        arrayWithoutDuplicate[counterForArrayWithoutDuplicate] = array[i];
                        counterForArrayWithoutDuplicate++;
                    }
                }
                else
                {
                    Array.Resize(ref arrayWithoutDuplicate, arrayWithoutDuplicate.Length + 1);
                    arrayWithoutDuplicate[counterForArrayWithoutDuplicate] = array[i];
                    counterForArrayWithoutDuplicate++;
                }
            }
            return new string(arrayWithoutDuplicate);
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
                if (word.Length > 0 )
                {
                    return true;
                }
            }
            return false;
        }
    }
}
