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
        /// <summary> Rezolva o ecuatie de gradul 1 cu o necunoscuta: ax + b = 0. Date de intrare: a, b </summary>
        /// <param name="indicatie"> Indicatia problemei pe care o rezolva functia </param>
        public static void EcGrad1(string indicatie)
        {
            Console.Clear();
            Console.WriteLine($"{indicatie}{Environment.NewLine}");
            Console.WriteLine("------------------------------------------------------");

            Console.Write("Introduceti valorile indicilor a si b: ");
            string[] input = Console.ReadLine().Split(' ');
            double a = double.Parse(input[0]), b = double.Parse(input[1]);

            Console.Write("Rezolvare: ");

            // E: b = 0
            if (a == 0)
            {
                // E: 0 = 0
                if (b == 0)
                    Console.Write("x = Orice numar real");
                // E: b = 0, dar b != 0
                else
                    Console.Write("Nu exista solutie in multimea numerelor reale");
            }
            // E: ax + b = 0
            else
            {
                // E: ax = 0, dar a != 0
                if (b == 0)
                    Console.Write("Nu exista solutie");
                // E: ax + b = 0  =>  x = -b / a
                else
                    Console.Write(-b/a);
            }
        }
    }
}