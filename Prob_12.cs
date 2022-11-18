using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].

namespace Rezolvari
{
    class Prob_12
    {
        public static void CateDivN(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("Introduceti valorile lui n, a si b: ");
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), a = int.Parse(input[1]), b = int.Parse(input[2]);

            int nr = 0;
            for (int i = a; i <= b; i++)
                if (i % n == 0)
                    nr++;

            Console.WriteLine($"In intervalul [{a}, {b}] sunt {nr} numere divizibile cu {n}.");
        }
    }
}