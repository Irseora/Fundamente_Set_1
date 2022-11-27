using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 18. Afisati descompunerea in factori primi ai unui numar n.

namespace Rezolvari
{
    class Prob_18
    {
        /// <summary> Afiseaza descompunerea in factori primi ai unui numar n. Date de intrare: n </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void FactoriPrimi(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");

            Console.Write("Introduceti o valoare pentru N: ");
            int n = int.Parse(Console.ReadLine());

            // Numerele 1, 0 si -1 nu se pot descompune in factori primi
            if (n != 1 && n != 0 && n != -1)
            {
                Console.Write(n + " = ");

                // Daca n este negativ, afiseaza semnul -, apoi continua cu modulul lui n
                if (n < 0)
                {
                    n = -n;
                    Console.Write('-');
                }
    
                int divizor = 2;
                while (divizor <= n)
                {
                    // Numara de cate ori se divide n cu divizorul curent
                    int nrDivizorCurent = 0;
                    while (n % divizor == 0)
                    {
                        n /= divizor;
                        nrDivizorCurent++;
                    }

                    // Daca se divide cu divizorul curent
                    if (nrDivizorCurent > 0)
                        Console.Write(divizor);

                    // Afiseaza puterea divizorului, daca este mai mare decat 1
                    if (nrDivizorCurent > 1)
                        Console.Write("^" + nrDivizorCurent);

                    if (divizor == 2) divizor++;
                    else divizor += 2;

                    // Daca mai urmeaza factori primi, afiseaza semnul de inmultire delimitator
                    if (divizor <= n && nrDivizorCurent > 0)
                        Console.Write(" x ");
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("Nu se poate descompune in factori primi.");
        }
    }
}