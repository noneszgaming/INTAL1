using System;
using System.Collections;

namespace PeldaHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //feladat1();
            //feladat2();
            //feladat3();
            //feladat4();
            //feladat5();

        }

        static void feladat1()
        {
            char betu = Console.ReadKey().KeyChar;
            Console.WriteLine();
            string szoveg = Console.ReadLine();

            if (szoveg.Length > 0)
            {
                if (szoveg.Contains(betu))
                {
                    Console.WriteLine(szoveg.IndexOf(betu));
                }
            }
        }

        static void feladat2()
        {
                //elveszett
        }

        static void feladat3()
        {
            Console.Write("Írj be egy szöveget: ");
            int bek = Convert.ToInt32(Console.ReadLine());
            int[] tomb = { 1, 2, 3, 4, 5, 6, 7 };
            bool talalt = false;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == bek)
                {
                    Console.Write("Megvan a(z)" + bek + " a(z) " + (i + 1) + ". volt");
                    talalt = true;
                    break;
                }
            }
            if (!talalt)
            {
                Console.Write("Nem találta meg a(z): " + bek);
            }
        }

        static void feladat4()
        {
            Console.Write("Írj be a méretet: ");
            int meret = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[meret];
            for (int i = 0; i < meret; i++)
            {
                Console.Write("Írd be a értékeket: ");
                tomb[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] hashTabla = new int[meret];
            for (int i = 0; i < meret; i++)
            {
                hashTabla[tomb[i] % meret] = tomb[i];
            }
        }
        static void feladat5()
        {
            //class ListaElem(){public in adat; public ListaElem koviElem;}
            //hozzaad();
            //olvas();
            //torles();
            //frissites();
            
        }

    }
}
