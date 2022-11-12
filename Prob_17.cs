using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 17. Determinati cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.
//     Folositi algoritmul lui Euclid.

namespace Rezolvari
{
    class Prob_17
    {
        public static void Euclid(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti 2 numere intregi: ");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]);

            int copyA = a, copyB = b;
            while (copyB != 0)
            {
                int rest = copyA % copyB;
                copyA = copyB;
                copyB = rest;
            }

            Console.WriteLine($"Cel mai mare divizor comun ({a}, {b}): {copyA}");
            Console.Write($"Cel mai mic multiplu comun [{a}, {b}]: {a*b/copyA}");
        }
    }
}