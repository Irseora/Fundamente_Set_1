using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare.

namespace Rezolvari
{
    class Prob_1
    {
        public static void EcGrad1(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti valorile indicilor a si b: ");
            string[] input = Console.ReadLine().Split(' ');
            double a = double.Parse(input[0]), b = double.Parse(input[1]);

            Console.Write("Rezolvare: ");

            if (a == 0)
            {
                if (b == 0)
                    Console.Write("x = Orice numar real");
                else
                    Console.Write("Nu exista solutie");
            }
            else
                Console.Write(-b/a);
        }
    }
}