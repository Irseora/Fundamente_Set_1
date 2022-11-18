using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 3. Determinati daca n se divide cu k, unde n si k sunt date de intrare.

namespace Rezolvari
{
    class Prob_3
    {
        public static void DivizibilK(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("Introduceti valorile lui n si k: ");
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), k = int.Parse(input[1]);

            if (k == 0)
                Console.WriteLine("Divizia cu 0 nu este permisa.");
            else if (n % k == 0)
                Console.WriteLine($"Da, {n} se divide cu {k}.");
            else
                Console.WriteLine($"Nu, {n} nu se divide cu {k}.");
        }
    }
}