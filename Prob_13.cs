using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 13. Determinati cati ani bisecti sunt intre anii y1 si y2.

namespace Rezolvari
{
    class Prob_13
    {
        public static void CatiBisecti(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("Introduceti anii y1 si y2: ");
            string[] input = Console.ReadLine().Split(' ');
            int y1 = int.Parse(input[0]), y2 = int.Parse(input[1]);

            // Daca y1 > y2, le inverseaza
            if (y1 > y2)
            {
                int aux = y1;
                y1 = y2;
                y2 = aux;
            }

            // Cauta primul an bisect intre y1 si y2
            bool gasit = false;
            int an = y1;
            while (an <= y2 && !gasit)
            {
                if (an % 400 == 0 || (an % 4 == 0 && an % 100 != 0))
                    gasit = true;
                else
                    an++;
            }

            // TODO:
            int nr = 0;
            while (an <= y2)
            {
                nr++;
                an += 4;
            }

            Console.WriteLine($"Intre anii {y1} si {y2} sunt {nr} ani bisecti.");
        }
    }
}