using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 9. Afisati toti divizorii numarului n.

namespace Rezolvari
{
    class Prob_9
    {
        /// <summary> Afiseaza toti divizorii numarului n. Date de intrare: n </summary>
        public static void Divizori(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("Introduceti o valoare pentru n: ");
            int n = int.Parse(Console.ReadLine());

            int i = 1, rad = (int)Math.Sqrt(n);

            // Divizorii unui numar se gasesc intre 1 si radicalul numarului,
            // divizorii ramasi pot fi calculati prin n/i
            while (i <= rad)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");

                    // Daca i | n => n/i | n
                    if (i != n/i)
                        Console.Write($"{n/i} ");
                }
                    
                if (i == 1 || i == 2) i++;
                else i += 2;
            }
        }
    }
}