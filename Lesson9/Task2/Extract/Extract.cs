using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URLExtract
{
    public class Extract
    {
        /// <summary>
        /// Finds host name in string
        /// </summary>
        /// <param name="site">Input string</param>
        /// <returns>string</returns>
        public static string ExtractsHostName (string site)
        {
            if (ValidateString(site) == false)
            {
                return null;
            }

            char[] chrSite = new char[0];
            int counter = 0;
            for (int i = 0; i < site.Length; i++)
            {
                if (site[i] == '/')
                {
                    if (site[i - 1] == '/')
                    {
                        for (int j = i + 1; j < site.Length; j++)
                        {
                            if (site[j] == '/')
                            {
                                break;
                            }
                            Array.Resize(ref chrSite, chrSite.Length + 1);
                            chrSite[counter] = site[j];
                            counter++;
                        }
                    }
                }
            }
            string result = new string(chrSite);
            return result;
        }

        public static string ExtractsProtocol(Extract c)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Finds protocol in string
        /// </summary>
        /// <param name="site">Input string</param>
        /// <returns>string</returns>
        public static string ExtractsProtocol(string site)
        {
            if (ValidateString(site) == false)
            {
                return null;
            }

            char[] chrSite = new char[0];

            for (int i = 0; i < site.Length; i++)
            {
                if (site[i] ==':')
                {
                    break;
                }
                Array.Resize(ref chrSite, chrSite.Length + 1);
                chrSite[i] = site[i];
            }
            string result = new string(chrSite);
            return result;
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
    }
}
