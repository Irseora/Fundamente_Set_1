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
        public static void Divizori(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti o valoare pentru n: ");
            int n = int.Parse(Console.ReadLine());

            int i = 1, rad = (int)Math.Sqrt(n);
            while (i <= rad)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");
                    if (i != n/i)
                        Console.Write($"{n/i} ");
                }
                    
                if (i == 1 || i == 2) i++;
                else i += 2;
            }
        }
    }
}