// Feladat Átlag számítás


using System;

namespace Feladat1
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] szamLista = { 19, 21, 21, 19, 21, 21, 18, 25, 20, 19, 16 };

            int szamListaHossz = szamLista.Length;

            int sum = 0;

            for (int i = 0; i < szamListaHossz; i++)
            {

                sum += szamLista[i];

            }

            double atlag = sum / szamListaHossz;

            Console.WriteLine(atlag);

        }
    }
}

