using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 4. Determinati daca un an y este an bisect.

namespace Rezolvari
{
    class Prob_4
    {
        public static void Bisect(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("Introduceti un an: ");
            int y = int.Parse(Console.ReadLine());

            if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
                Console.WriteLine($"Da, {y} este an bisect.");
            else
                Console.WriteLine($"Nu, {y} nu este an bisect.");
        }
    }
}