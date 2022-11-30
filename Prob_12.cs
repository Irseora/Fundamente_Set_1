using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 12. Determinati cate numere intregi divizibile cu n se afla in intervalul [a, b].

namespace Rezolvari
{
    class Prob_12
    {
        /// <summary> Determina cate numere intregi din intervalul [a, b] sunt divizibile cu k. Date de intrare: k, a, b </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void CateDivN(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine("------------------------------------------------------");

            Console.Write("Introduceti valorile lui k, a si b: ");
            string[] input = Console.ReadLine().Split(' ');
            int k = int.Parse(input[0]), a = int.Parse(input[1]), b = int.Parse(input[2]);

            int nr = 0;
            for (int i = a; i <= b; i++)
                if (i % k == 0)
                    nr++;

            Console.WriteLine($"In intervalul [{a}, {b}] sunt {nr} numere divizibile cu {k}.");
        }
    }
}