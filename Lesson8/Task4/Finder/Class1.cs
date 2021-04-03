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
        /// Find vowels in word witout duplicates
        /// </summary>
        /// <param name="word">String variable</param>
        /// <returns>Numbers of vowels in your word</returns>
        public static int FindVowelsCount(string word)
        {
            if (ValidateArray(word) == false)
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
            return SetCorrectValueWithoutDuplicates(arrayWithoutDuplicate);
          
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        private static int SetCorrectValueWithoutDuplicates(char[] array)
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

        public static string GetVowelsString(string word)
        {
            if (ValidateArray(word) == false)
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
            string result = new string(vowelsWithoutDuplicate);
            return result;
        }

        //public static string GetVowelsStringWithoutDuplicates(string word)
        //{
        //    if (ValidateArray(word) == false)
        //    {
        //        return null;
        //    }

        //    char[] vowelsWithoutDuplicate = new char[0];
        //    int counterForArrayWithoutDuplicate = 0;

        //    for (int i = 0; i < word.Length; i++)
        //    {
        //        for (int j = 0; j < vowelsArray.Length; j++)
        //        {
        //            if (word[i] == vowelsArray[j])
        //            {
        //                Array.Resize(ref vowelsWithoutDuplicate, vowelsWithoutDuplicate.Length + 1);
        //                vowelsWithoutDuplicate[counterForArrayWithoutDuplicate] = vowelsArray[j];
        //                counterForArrayWithoutDuplicate++;
        //            }
        //        }
        //    }
            
        //    return GetVowelsWithoutDuplicates(vowelsWithoutDuplicate);
        //}

        //private static string GetVowelsWithoutDuplicates(char[] array)
        //{
        //    char[] arrayWithoutDuplicate = new char [array.Length];
        //    int counterForArrayWithoutDuplicate = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        for (int j = i + 1; j < array.Length; j++)
        //        {
        //            if (array[i] != array[j])
        //            {
        //                arrayWithoutDuplicate[counterForArrayWithoutDuplicate] = array[i];
        //                counterForArrayWithoutDuplicate++;
        //            }

        //        }
        //    }
        //    string result = new string(arrayWithoutDuplicate);
        //    return result;
        //}

        /// <summary>
        /// Check
        /// </summary>
        /// <param name="word"></param>
        /// <returns>true or false</returns>
        private static bool ValidateArray(string word)
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
