using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1
{
    class Program
    {
        // ---------------------------------------------- FUNCTII AJUTATOARE --------------------------------------------------------------

        static int Afis(string[] indicatii)
        {
            Console.Clear();
            for (int i = 0; i < indicatii.Length; i++)
                Console.WriteLine(indicatii[i]);
            
            int prob = 0;
            while (prob < 1)
            {
                Console.WriteLine("\nAlegeti o problema: ");
                prob = int.Parse(Console.ReadLine());
            }

            return prob;
        }

        // ---------------------------------------------------- MAIN ---------------------------------------------------------------------

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
                case  1: EcGrad1(indicatii[1]);           break;
                case  2: EcGrad2(indicatii[2]);           break;
                case  3: DivizibilK(indicatii[3]);        break;
                case  4: Bisect(indicatii[4]);            break;
                case  5: CifraK(indicatii[5]);            break;
                case  6: LaturiTriunghi(indicatii[6]);    break; 
                case  7: Swap(indicatii[7]);              break;
                case  8: SwapRestrictionat(indicatii[8]); break;
                case  9: Divizori(indicatii[9]);          break;
                case 10: Primalitate(indicatii[10]);      break;
                case 11: Oglindit(indicatii[11]);         break;
                case 12: CateDivN(indicatii[12]);         break;
                case 13: CatiBisecti(indicatii[13]);      break;
                case 14: Palindrom(indicatii[14]);        break;
                case 15: Crescator3(indicatii[15]);       break;
                case 16: Crescator5(indicatii[16]);       break;
                case 17: Euclid(indicatii[17]);           break;
                case 18: FactoriPrimi(indicatii[18]);     break;
                case 19: Doar2Cif(indicatii[19]);         break;
                case 20: FractiiPeriodice(indicatii[20]); break;
                case 21: CautareBinara(indicatii[21]);    break;

                default: break;
            }
        }

        // -------------------------------------------------- REZOLVARI ------------------------------------------------------------------

        // 1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare.
        static void EcGrad1(string indicatie)
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
    
        // 2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
        // Tratati toate cazurile posibile.
        static void EcGrad2(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti valorile indicilor a, b si c: ");
            string[] input = Console.ReadLine().Split(' ');
            double a = double.Parse(input[0]), b = double.Parse(input[1]), c = double.Parse(input[2]);

            Console.Write("Rezolvare: ");

            if (a == 0)  // a=0
            {
                if (b == 0)  // a=0, b=0
                {
                    if (c == 0)  // a=0, b=0, c=0
                        Console.WriteLine("x = orice numar real");
                    else  // a=0, b=0, c!=0  =>  c=0 "Fals"
                        Console.WriteLine("Ecuatia nu are solutie in multimea numerelor reale");
                }
                else  // a=0, b!=0
                {
                    if (c == 0)  // a=0, b!=0, c=0  =>  bx = 0
                        Console.WriteLine("x = 0");
                    else  // a=0, b!=0, c!=0  => bx + c = 0
                        Console.WriteLine("x = " + -c/b);
                }
            }
            else  // a!=0
            {
                if (b == 0)  // a!=0, b=0
                {
                    if (c == 0)  // a!=0, b=0, c=0  =>  ax^2 = 0
                        Console.WriteLine("x = 0");
                    else  // a!=0, b=0, c!=0  =>  ax^2 + c = 0
                        Console.WriteLine("x = " + Math.Sqrt(-c/a));
                }
                else  // a!=0, b!=0
                {
                    if (c == 0)  // a!=0, b!=0, c=0  =>  ax^2 + bx = 0  =>  x * (ax + b) = 0
                        Console.WriteLine("x1 = 0, x2 = " + (-b/a));
                    else  // a!=0, b!=0, c!=0  =>  ax^2 + bx + c = 0
                    {
                        double delta = b*b - 4*a*c;
                        if (delta > 0)
                        {
                            double radDelta = Math.Sqrt(delta);
                            Console.WriteLine("x1 = " + ((-b+radDelta)/(2*a)) + ", x2 = " + ((-b-radDelta)/(2*a)));
                        }
                        else if (delta == 0)
                        {
                            Console.WriteLine("x = " + (-b/(2*a)));
                        }
                        else
                            Console.WriteLine("Ecuatia nu are solutie in multimea numerelor reale");
                            
                    }
                }
            }
        }

        // 3. Determinati daca n se divide cu k, unde n si k sunt date de intrare.
        static void DivizibilK(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti valorile lui n si k: ");
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), k = int.Parse(input[1]);

            if (k == 0)
                Console.WriteLine("Divizia cu 0 nu este permisa.");
            else if (n % k == 0)
                Console.WriteLine($"Da, {n} se divide cu {k}.");
            else
                Console.WriteLine($"Nu, {n} nu se divide cu {k}.");
        }

        // 4. Determinati daca un an y este an bisect.
        static void Bisect(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti un an: ");
            int y = int.Parse(Console.ReadLine());

            if (y % 400 == 0 || (y % 4 == 0 && y % 100 != 0))
                Console.WriteLine($"Da, {y} este an bisect.");
            else
                Console.WriteLine($"Nu, {y} nu este an bisect.");
        }

        // 5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.
        static void CifraK(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti valorile lui n si k: ");
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), k = int.Parse(input[1]);

            int putere = (int)Math.Pow(10, k);
            
            Console.Write($"A {k}-a cifra de la sfarsitul lui {n} este ");
            if (putere > n)
                Console.WriteLine("0.");
            else
                Console.WriteLine(n % putere / (putere/10) + ".");
        }

        // 6. Determinati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.
        static void LaturiTriunghi(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti valorile celor 3 laturi: ");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]);
            bool ok = true;

            if (a < 0 || b < 0 || c < 0)
                Console.WriteLine("Nu, laturile unui triunghi nu pot avea lungimi negative.");
            else
            {
                if (a > b)
                {
                    if (c > a)  // c > a > b
                    {
                        if (a+b <= c)
                            ok = false;
                    }
                    else  // a > b,c
                    {
                        if (b+c <= a)
                            ok = false;
                    }
                }
                else
                {
                    if (c > b)  // c > b > a
                    {
                        if (b+a <= c)
                            ok = false;
                    }
                    else  // b > a,c
                    {
                        if (a+c <= b)
                            ok = false;
                    }
                }

                if (ok)
                    Console.WriteLine($"Da, {a}, {b} si {c} pot fi lungimile laturilor unui triunghi.");
                else
                    Console.WriteLine($"Nu, {a}, {b} si {c} nu pot fi lungimile laturilor unui triunghi.");
            }
        }

        // 7. (Swap) Se dau doua variabile numerice a si b ale caror valori sunt date de intrare. Se cere sa se inverseze valorile lor.
        static void Swap(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti valorile lui a si b: ");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]);

            int aux = a;
            a = b;
            b = aux;

            Console.WriteLine($"Valorile inversate: {a} {b}");
        }

        // 8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
        // Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.
        static void SwapRestrictionat(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti valorile lui a si b: ");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]);

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Valorile inversate: {a} {b}");
        }

        // 9. Afisati toti divizorii numarului n.
        static void Divizori(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti o valoare pentru n: ");
            int n = int.Parse(Console.ReadLine());

            int i = 1, rad = (int)Math.Sqrt(n);
            while (i <= rad)
            {
                if (n % i == 0)
                {
                    Console.Write($"{i} ");
                    if (i != n/i)
                        Console.Write($"{n/i} ");
                }
                    
                if (i == 1 || i == 2) i++;
                else i += 2;
            }
        }

        // 10. Test de primalitate: determinati daca un numar n este prim.
        static void Primalitate(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti o valoare pentru n: ");
            int n = int.Parse(Console.ReadLine());

            bool prim = true;

            if (n < 2)
                prim = false;
            else if (n == 2)
                prim = true;
            else if (n % 2 == 0)
                prim = false;
            else
                for (int div = 3; div * div <= n; div += 2)
                    if (n % div == 0)
                        prim = false;

            if (prim) Console.WriteLine($"Da, {n} este prim.");
            else Console.WriteLine($"Nu, {n} nu este prim.");
        }

        // 11. Afisati in ordine inversa cifrele unui numar n.
        static void Oglindit(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti o valoare pentru n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write($"Oglinditul lui {n} este ");
            while (n > 0)
            {
                Console.Write(n % 10);
                n /= 10;
            }
        }

        // 12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].
        static void CateDivN(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti valorile lui n, a si b: ");
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]), a = int.Parse(input[1]), b = int.Parse(input[2]);

            int nr = 0;
            for (int i = a; i <= b; i++)
                if (i % n == 0)
                    nr++;

            Console.WriteLine($"In intervalul [{a}, {b}] sunt {nr} numere divizibile cu {n}.");
        }

        // 13. Determinati cati ani bisecti sunt intre anii y1 si y2.
        static void CatiBisecti(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti anii y1 si y2: ");
            string[] input = Console.ReadLine().Split(' ');
            int y1 = int.Parse(input[0]), y2 = int.Parse(input[1]);

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

            int nr = 0;
            while (an <= y2)
            {
                nr++;
                an += 4;
            }

            Console.WriteLine($"Intre anii {y1} si {y2} sunt {nr} ani bisecti.");
        }

        // 14. Determinati daca un numar n este palindrom.
        static void Palindrom(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti o valoare pentru n: ");
            int n = int.Parse(Console.ReadLine());

            int auxN = n, oglindit = 0;
            while (auxN > 0)
            {
                oglindit = oglindit * 10 + (auxN % 10);
                auxN /= 10;
            }

            if (n == oglindit)
                Console.WriteLine($"Da, numarul {n} este palindrom.");
            else
                Console.WriteLine($"Nu, numarul {n} nu este palindrom.");
        }

        // 15. Se dau 3 numere. Sa se afiseze in ordine crescatoare.
        static void Crescator3(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti 3 numere intregi: ");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]);

            int aux;
            if (a > b) { aux = a; a = b; b = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (b > c) { aux = b; b = c; b = aux; }
            Console.WriteLine($"In ordine crescatoare: {a} {b} {c}");
        }

        // 16. Se dau 5 numere. Sa se afiseze in ordine crescatoare (nu folositi tablouri).
        static void Crescator5(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.WriteLine("Introduceti 5 numere intregi: ");
            string[] input = Console.ReadLine().Split(' ');
            int a = int.Parse(input[0]), b = int.Parse(input[1]), c = int.Parse(input[2]), d = int.Parse(input[3]), e = int.Parse(input[4]);

            int aux;
            if (a > b) { aux = a; a = b; b = aux; }
            if (a > c) { aux = a; a = c; c = aux; }
            if (a > d) { aux = a; a = d; d = aux; }
            if (a > e) { aux = a; a = e; e = aux; }
            if (b > c) { aux = b; b = c; c = aux; }
            if (b > d) { aux = b; b = d; d = aux; }
            if (b > e) { aux = b; b = e; e = aux; }
            if (c > d) { aux = c; c = d; d = aux; }
            if (c > e) { aux = c; c = e; e = aux; }
            if (d > e) { aux = d; d = e; e = aux; }
            Console.WriteLine($"In ordine crescatoare: {a} {b} {c} {d} {e}");
        }

        // 17. Determinati cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.
        // Folositi algoritmul lui Euclid.
        static void Euclid(string indicatie)
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

        // 18. Afisati descompunerea in factori primi ai unui numar n.
        static void FactoriPrimi(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("Introduceti o valoare pentru N: ");
            int n = int.Parse(Console.ReadLine());


            if (n != 1 && n != 0 && n != -1)
            {
                Console.Write(n + " = ");

                // Daca n este negativ, afiseaza semnul -, apoi continua cu modulul lui n
                if (n < 0)
                {
                    n = -n;
                    Console.Write("- ");
                }
    
                int divizor = 2;
                while (divizor <= n)
                {
                    // Numara de cate ori se divide n cu divizorul curent
                    int nrDivizorCurent = 0;
                    while (n % divizor == 0)
                    {
                        n /= divizor;
                        nrDivizorCurent++;
                    }

                    // Daca se divide cu divizorul curent
                    if (nrDivizorCurent > 0)
                        Console.Write(divizor);

                    // Afiseaza puterea divizorului, daca este mai mare decat 1
                    if (nrDivizorCurent > 1)
                        Console.Write("^" + nrDivizorCurent);

                    if (divizor == 2) divizor++;
                    else divizor += 2;

                    // Daca mai urmeaza factori primi, afiseaza semnul * delimitator
                    if (divizor <= n && nrDivizorCurent > 0)
                        Console.Write(" * ");
                }

                Console.WriteLine();
            }
            else
                Console.WriteLine("Nu se poate descompune in factori primi.");
        }

        // 19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta.
        static void Doar2Cif(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("Introduceti un numar: ");
            string numar = Console.ReadLine();

            bool doar2Cif = true;
            char cif1 = numar[0], cif2 = ' ';
            int i = 1, lungime = numar.Length;

            if (lungime < 2)
                doar2Cif = false;

            while (i < lungime && doar2Cif)
            {
                if (numar[i] != cif1 && numar[i] != cif2)
                {
                    if (cif2 == ' ')
                        cif2 = numar[i];
                    else
                        doar2Cif = false;
                }

                i++;
            }

            if (doar2Cif)
                Console.WriteLine($"Numarul {numar} este format doar cu 2 cifre care se repeta.");
            else
                Console.WriteLine($"Numarul {numar} nu este format doar cu 2 cifre care se repeta.");

        }

        // 20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul).
        // O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0.
        // O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5.
        // O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5.
        static void FractiiPeriodice(string indicatie)
        {
            Console.Clear();
            Console.WriteLine(indicatie + "\n");

            Console.Write("Introduceti o fractie: ");
            string[] input = Console.ReadLine().Split('/');
            int numarator = int.Parse(input[0]), numitor = int.Parse(input[1]);

            // Cel mai mare divizor comun [numarator, numitor]
            int copyA = numarator, copyB = numitor;
            while (copyB != 0)
            {
                int r = copyA % copyB;
                copyA = copyB;
                copyB = r;
            }

            // Forma ireductibila
            numarator /= copyA;
            numitor /= copyA;

            // Afiseaza partea intreaga a fractiei
            Console.Write(numarator / numitor + ",");

            int parteFractionara = numarator % numitor;

            // Lista resturilor partiale provenite din impartirea repetata a partii fractionare la numitor
            List<int> resturi = new List<int>();
            resturi.Add(parteFractionara);

            // Lista cifrelor de dupa virgula
            List<int> cifre = new List<int>();

            int rest = -1;
            bool periodica = false;
            do
            {
                cifre.Add(parteFractionara * 10 / numitor);
                rest = parteFractionara * 10 % numitor;

                // Daca restul nu apare deja in lista, il adauga
                if (!resturi.Contains(rest))
                    resturi.Add(rest);
                // Daca se repeta un rest => fractia este periodica
                else
                {
                    periodica = true;
                    break;
                }

                parteFractionara = rest;
            } while (rest != 0);

            // Daca fractia nu este periodica, afiseaza cifrele de dupa virgula
            if (!periodica)
                for (int i = 0; i < cifre.Count; i++)
                    Console.Write(cifre[i]);
            // Daca fractia este periodica, afiseaza intai cifrele din afara perioadei, apoi cele din perioda intre paranteze
            else
            {
                for (int i = 0; i < resturi.Count; i++)
                {
                    // Daca a ajuns la inceputul perioadei, afiseaza paranteza deschisa
                    if (resturi[i] == rest)
                        Console.Write("(");
                    
                    Console.Write(cifre[i]);
                }

                Console.Write(")");
            }
        }

        // 21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma "Numarul este mai mare sau egal decat x?"
        static void CautareBinara(string indicatie)
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