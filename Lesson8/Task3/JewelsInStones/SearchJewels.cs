using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsInStones
{
    public class SearchJewels
    {
        /// <summary>
        /// The method finds an element in a string array.
        /// </summary>
        /// <param name="stones">Array of string. Array of search</param>
        /// <param name="jewels">Array of string. What you need to find</param>
        /// <returns></returns>
        public static int Searcher(string stones, string jewels)
        {
            if (ValidateArray(stones, jewels) == false)
            {
                return 0;
            }

            int counter = 0;

            foreach (char i in stones)
            {
                foreach (char j in jewels)
                {
                    if (j == i)
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }

        private static bool ValidateArray(string stones, string jewels)
        {
            if (stones != null && jewels != null)
            {
                if (stones.Length > 0 && jewels.Length > 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
