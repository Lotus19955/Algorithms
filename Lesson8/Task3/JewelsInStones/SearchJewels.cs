using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JewelsInStones
{
    public class SearchJewels
    {
        public static void Searcher (string stones, string jewels)
        {
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
        }
    }
}
