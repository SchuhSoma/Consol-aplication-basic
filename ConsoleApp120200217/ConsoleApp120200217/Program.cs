using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp120200217
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("\n---------------------------------\n");
            Feladat1();
            Console.WriteLine("\n---------------------------------\n");
            Feladat2();
            Console.WriteLine("\n---------------------------------\n");
            Feladat3();
            Console.WriteLine("\n---------------------------------\n");
            Feladat4();
            Console.WriteLine("\n---------------------------------\n");
            Feladat5();
            Console.WriteLine("\n---------------------------------\n");
            Feladat6();
            Console.WriteLine("\n---------------------------------\n");
            Feladat7();
            Console.WriteLine("\n---------------------------------\n");
            Feladat8();
            Console.WriteLine("\n---------------------------------\n");
            Feladat9();
            Console.WriteLine("\n---------------------------------\n");
            Feladat10();
            Console.ReadKey();

        }

        private static void Feladat10()
        {
            Console.WriteLine("\t10.Feladat");
            int VeletlenSzam;
            int db = 0;
            double Osszeg = 0;
            double Atlag = 0;
            for (int i = 1; i <= 14; i++)
            {
                VeletlenSzam = rnd.Next(60, 121);
                Console.WriteLine("\t{0,-2}. nap légszennyezettség: {1} ", i, VeletlenSzam);
                if (100 < VeletlenSzam)
                {
                    db++;
                }
                Osszeg += VeletlenSzam;
                Atlag = Osszeg / 14;

            }
            Console.WriteLine("\n\tA légszennyezettségi átlag: {0:0.00}", Atlag);
            Console.WriteLine("\n\tEnnyi nap volt szmogriadó: {0}", db);
        }

        private static void Feladat9()
        {
            Console.WriteLine("9.Feladat");
            Console.Write("Kérem adja meg hány számot szeretne generálni: ");
            int CiklusVege = int.Parse(Console.ReadLine());
            double VeletlenSzam;
            double Osszeg = 0;
            double Atlag = 0;
            for (int i = 0; i < CiklusVege; i++)
            {
                VeletlenSzam = rnd.Next(1000, 2001) / 100;
                Osszeg += VeletlenSzam;
                Atlag = Osszeg / CiklusVege;
                Console.Write("{0} , ", VeletlenSzam);
            }
            Console.WriteLine("\n\nA generált számok átlaga: {0:0.00}", Atlag);

        }

        private static void Feladat8()
        {
            Console.WriteLine("8.Feladat");
            double Hatvany;
            for (int i = 1; i <=12; i++)
            {
                Hatvany = Math.Pow(6, i);
                Console.WriteLine("6 ^ {0} := {1}", i, Hatvany);
            }
        }

        private static void Feladat7()
        {
            Console.WriteLine("7.Feladat");
            Console.Write("Kérem adja meg milyen távolságra szeretne utazni: ");
            double Tavolsag = double.Parse(Console.ReadLine());
            double Viteldij = 0;
            if(0<Tavolsag && Tavolsag<501)
            {
                if(0<Tavolsag && Tavolsag<= 20)
                {
                    Viteldij = 100 + Tavolsag * 100;
                    Console.WriteLine("A viteldíj: {0} Ft", Viteldij);
                }
                if (20 < Tavolsag && Tavolsag <= 100)
                {
                    Viteldij = 200 + Tavolsag * 100;
                    Console.WriteLine("A viteldíj: {0} Ft", Viteldij);
                }
                if (100 < Tavolsag && Tavolsag <= 200)
                {
                    Viteldij = 300 + Tavolsag * 100;
                    Console.WriteLine("A viteldíj: {0} Ft", Viteldij);
                }
                if (200 < Tavolsag && Tavolsag <= 300)
                {
                    Viteldij = 350 + Tavolsag * 100;
                    Console.WriteLine("A viteldíj: {0} Ft", Viteldij);
                }
                if (300 < Tavolsag && Tavolsag <= 500)
                {
                    Viteldij = 400 + Tavolsag * 100;
                    Console.WriteLine("A viteldíj: {0} Ft", Viteldij);
                }
            }
            else
            {
                Console.WriteLine("Sajnos rossz adatot adott meg");
            }
        }

        private static void Feladat6()
        {
            Console.WriteLine("6.Feladat");
            int GeneraltSzam;
            int db = 0;
            for (int i = 1; i <= 36; i++)
            {
                GeneraltSzam = rnd.Next(20, 100);
                if (GeneraltSzam % 4 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.Write("{0} , " , GeneraltSzam);
                if(GeneraltSzam%3==0)
                {
                    db++;
                }
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\n\nPéternek ennyi 3-al osztható számot generált a gép: {0}", db);
        }

        private static void Feladat5()
        {
            Console.WriteLine("5.Feladat");
            int Dobas;
            double Osszeg = 0;
            double Atlag = 0;
            int db = 0;
            for (int i = 1; i <= 14; i++)
            {
                Dobas = rnd.Next(1, 7);
                Osszeg += Dobas;
                Atlag = Osszeg / 14;
                Console.WriteLine("{0}. dobás: = {1}", i, Dobas);
                if(Dobas%4==0)
                {
                    db++;
                }
            }
            Console.WriteLine("\nA dobások átlaga: {0:0.00}", Atlag);
            Console.WriteLine("\nPéternek ennyi dobása volt 4-el osztható: {0}", db);
        }

        private static void Feladat4()
        {
            Console.WriteLine("4.Feladat");
            Console.Write("Kérem adja meg a nevét: ");
            string Nev = Console.ReadLine();
            Console.Write("Kérem adjon meg életkorát: ");
            int Eletkor= int.Parse(Console.ReadLine());
            if(0<Eletkor)
            {
                if(0<Eletkor && Eletkor<=6)
                {
                    Console.WriteLine("{0} Ön {1} életévével: kisgyerek kategoriába tartozik", Nev, Eletkor);
                }
                if (6 < Eletkor && Eletkor <= 18)
                {
                    Console.WriteLine("{0} Ön {1} életévével: diák kategoriába tartozik", Nev, Eletkor);
                }
                if (18 < Eletkor && Eletkor <= 60)
                {
                    Console.WriteLine("{0} Ön {1} életévével: felnőtt kategoriába tartozik", Nev, Eletkor);
                }
                if (60 < Eletkor)
                {
                    Console.WriteLine("{0} Ön {1} életévével: nyugdíjas kategoriába tartozik", Nev, Eletkor);
                }
            }
            else
            {
                Console.WriteLine("Sajnos rossz életkort adott meg.");
            }
        }

        private static void Feladat3()
        {
            Console.WriteLine("3.Feladat");
            Console.Write("Kérem adja meg a nevét: ");
            string Nev = Console.ReadLine();
            Console.Write("Kérem adjon meg egy számot: ");
            double BekertSzam1 = double.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg egy számot: ");
            double BekertSzam2 = double.Parse(Console.ReadLine());
            double Osszeg = BekertSzam1 + BekertSzam2;
            double Kulonbseg = BekertSzam1 - BekertSzam2;
            double Szorzat = BekertSzam2 * BekertSzam1;
            double Atlag = Osszeg / 2;
            Console.WriteLine("{0} az Ön által megadott számok \nÖsszege:= {1}\nKülönbsége:= {2}\nSzorzata: {3}\nátlaga:= {4:0.00}", Nev, Osszeg, Kulonbseg, Szorzat, Atlag);
        }

        private static void Feladat2()
        {
            Console.WriteLine("2.Feladat");
            Console.Write("Kérem adja meg hány km-t tett meg az autóval: ");
            double KmUthossza = double.Parse(Console.ReadLine());
            Console.Write("Kérem adja meg hány óra alatt teszi meg az utat: ");
            double MegtettIdo= double.Parse(Console.ReadLine());
            double AtlagSebesseg = KmUthossza / MegtettIdo;
            Console.WriteLine("Az autó átlag sebessége ez alatt az út alatt: {0} km/h", AtlagSebesseg);
        }

        private static void Feladat1()
        {
            Console.WriteLine("1.Feladat");
            Console.Write("Kérem adjon meg egy számot: ");
            double BekertSzam = double.Parse(Console.ReadLine());
            double SzamKetszerese = 2 * BekertSzam;
            double SzamNegyzet = Math.Pow(BekertSzam, 2);
            double SzamGyok = Math.Sqrt(BekertSzam);
            double GeneraltSzam = rnd.Next(1, 100);
            double Osszeg = BekertSzam + GeneraltSzam;
            double Kulonbseg=BekertSzam- GeneraltSzam;
            double Szorzat = BekertSzam * GeneraltSzam;
            Console.WriteLine("A bekért szám kétszerese: {0}", SzamKetszerese);
            Console.WriteLine("A bekért szám négyzete: {0}", SzamNegyzet);
            Console.WriteLine("A bekért szám gyöke: {0:0.00}", SzamGyok);
            Console.WriteLine("A gép által generált szám: {0}", GeneraltSzam);
            Console.WriteLine("A bekért szám és a generált szám összege: {0}", Osszeg);
            Console.WriteLine("A bekért szám és a generált szám különbsége {0}", Kulonbseg);
            Console.WriteLine("A bekért szám és a generált szám szorzata: {0}", Szorzat);
        }
    }
}
