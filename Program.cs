using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rezolvari;


namespace Set1
{
    class Program
    {
        static int Afis(string[] indicatii)
        {
            Console.Clear();
            for (int i = 0; i < indicatii.Length; i++)
                Console.WriteLine(indicatii[i]);
            
            int prob = 0;
            while (prob < 1 || prob > 21)
            {
                Console.WriteLine("\nAlegeti o problema din lista: ");
                prob = int.Parse(Console.ReadLine());
            }

            return prob;
        }

        static void Main(string[] args)
        {
            string[] indicatii = {"Setul de probleme 1:",
                                  " 1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare.",
                                  " 2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.\n    Tratati toate cazurile posibile.",
                                  " 3. Determinati daca n se divide cu k, unde n si k sunt date de intrare.",
                                  " 4. Determinati daca un an y este an bisect.",
                                  " 5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.",
                                  " 6. Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.",
                                  " 7. (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.\n    Se cere sa se inverseze valorile lor.",
                                  " 8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.\n    Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.",
                                  " 9. Afisati toti divizorii numarului n.",
                                  "10. Test de primalitate: determinati daca un numar n este prim.",
                                  "11. Afisati in ordine inversa cifrele unui numar n.",
                                  "12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].",
                                  "13. Determinati cati ani bisecti sunt intre anii y1 si y2.",
                                  "14. Determinati daca un numar n este palindrom.",
                                        // Un numar este palindrom daca citit invers obtinem un numar egal cu el.
                                        // Exemplu: 121 sau 12321
                                  "15. Se dau 3 numere. Sa se afiseze in ordine crescatoare.",
                                  "16. Se dau 5 numere. Sa se afiseze in ordine crescatoare (nu folositi tablouri).",
                                  "17. Determinati cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.\n    Folositi algoritmul lui Euclid.",
                                  "18. Afisati descompunerea in factori primi ai unui numar n.",
                                        // Exemplu: pentru n = 1176 afisati 2^3 x 3^1 x 7^2
                                  "19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta.",
                                        // Exemplu: 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt
                                  "20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul).",
                                        // Exemplu: 13/30 = 0.4(3).
                                        // (https://github.com/HoreaOros/ROSE2020/blob/master/2611/Program.cs)
                                        // O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0.
                                        // O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5.
                                        // O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5.
                                  "21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"Numarul este mai mare sau egal decat x?\"."};
        
            int prob = Afis(indicatii);
            switch (prob)
            {
                case  1: Prob_1.EcGrad1(indicatii[1]);            break;
                case  2: Prob_2.EcGrad2(indicatii[2]);            break;
                case  3: Prob_3.DivizibilK(indicatii[3]);         break;
                case  4: Prob_4.Bisect(indicatii[4]);             break;
                case  5: Prob_5.CifraK(indicatii[5]);             break;
                case  6: Prob_6.LaturiTriunghi(indicatii[6]);     break; 
                case  7: Prob_7.Swap(indicatii[7]);               break;
                case  8: Prob_8.SwapRestrictionat(indicatii[8]);  break;
                case  9: Prob_9.Divizori(indicatii[9]);           break;
                case 10: Prob_10.Primalitate(indicatii[10]);      break;
                case 11: Prob_11.Oglindit(indicatii[11]);         break;
                case 12: Prob_12.CateDivN(indicatii[12]);         break;
                case 13: Prob_13.CatiBisecti(indicatii[13]);      break;
                case 14: Prob_14.Palindrom(indicatii[14]);        break;
                case 15: Prob_15.Crescator3(indicatii[15]);       break;
                case 16: Prob_16.Crescator5(indicatii[16]);       break;
                case 17: Prob_17.Euclid(indicatii[17]);           break;
                case 18: Prob_18.FactoriPrimi(indicatii[18]);     break;
                case 19: Prob_19.Doar2Cif(indicatii[19]);         break;
                case 20: Prob_20.FractiiPeriodice(indicatii[20]); break;
                case 21: Prob_21.CautareBinara(indicatii[21]);    break;
                default: break;
            }
        }
    }
}