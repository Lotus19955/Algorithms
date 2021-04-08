using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using URLExtract;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string site1 = "https://github.com/Lotus19955/Algorithms/commit/88a9c36180595ec9a8b9ee6332e607fb60d24b4b";
            string site1HostName = URLExtract.Extract.ExtractsHostName(site1);
            if (site1HostName != null)
            {
                Console.WriteLine(site1HostName);
            }
            else
            {
                Console.WriteLine("Your array does not match the conditions or empty");
            }

            string site2 = "https://mail.google.com/";
            string site2HostName = URLExtract.Extract.ExtractsHostName(site2);
            if (site2HostName != null)
            {
                Console.WriteLine(site2HostName);
            }
            else
            {
                Console.WriteLine("Your array does not match the conditions or empty");
            }

            string site3 = "https://www.onliner.by/";
            string site3Protocol = URLExtract.Extract.ExtractsProtocol(site3);
            if (site3Protocol != null)
            {
                Console.WriteLine(site3Protocol);
            }
            else
            {
                Console.WriteLine("Your array does not match the conditions or empty");
            }
            string site4 = "http://mail.google.com/";
            string site4Protocol = URLExtract.Extract.ExtractsProtocol(site4);
            if (site4Protocol != null)
            {
                Console.WriteLine(site4Protocol);
            }
            else
            {
                Console.WriteLine("Your array does not match the conditions or empty");
            }
            Console.ReadLine();
        }
    }
}
