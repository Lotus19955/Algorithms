using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shuffle
{
    public class ArrayShuffle
    {
        /// <summary>
        /// The method which swap letter in the word
        /// </summary>
        /// <param name="word">Word you want to shuffle</param>
        /// <param name="indices">Array of integers</param>
        public static string ShuffleString(string word, int[] indices)
        {
            if (ValidateArray(word, indices) == false)
            {
                return null;
            }

            char[] wordArray = new char[word.Length];
            for (int i = 0; i < wordArray.Length; i++)
            {
                wordArray[indices[i]] = word[i];
            }
            return new string(wordArray);
        }
        private static bool ValidateArray(string word, int[] indices)
        {
            if (word != null)
            {
                if (word.Length == indices.Length)
                {
                    for (int i = 0; i < word.Length; i++)
                    {
                        if (indices[i] >= word.Length)
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            return false;
        }
    }
}

