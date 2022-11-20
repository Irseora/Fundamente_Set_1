using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma "Numarul este mai mare sau egal decat x?"

namespace Rezolvari
{
    class Prob_21
    {
        /// <summary> Ghiceste un numar intre 1 si 1024 prin cautare binara </summary>
        public static void CautareBinara(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");
            Console.WriteLine("Ganditi-va la un numar intre 1 si 1024.\n");

            string raspuns = "";

            // Cautare binara
            int limJos = 1, limSus = 1023, mijloc = 0;
            while (limJos <= limSus && raspuns != "egal" && raspuns != "Egal")
            {
                mijloc = (limJos + limSus) / 2;
                Console.WriteLine($"\nNumarul este mai mic, mai mare sau egal cu {mijloc}?");
                raspuns = Console.ReadLine();

                if (raspuns == "Mai mic" || raspuns == "mai mic")
                    limSus = mijloc - 1;
                else
                    limJos = mijloc + 1;
            }

            Console.WriteLine($"Numarul gandit: {mijloc}");
        }
    }
}