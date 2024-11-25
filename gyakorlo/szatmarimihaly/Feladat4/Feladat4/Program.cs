// Feladat Terjedelem, Minimum, Maximum

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // Terjedelem Feladat

        int[] szamLista = { 19, 21, 21, 19, 21, 21, 18, 25, 20, 19, 16 };

        int szamListaHossz = szamLista.Length;


        int[] szamListaRendezett = szamLista;

        Array.Sort(szamListaRendezett);


        foreach (int i in szamListaRendezett)
        {
            Console.WriteLine(i);
        }


        Console.WriteLine();

        int terjedelem = szamListaRendezett[szamListaHossz - 1] - szamListaRendezett[0];


        Console.WriteLine(terjedelem);


        Console.WriteLine();
        // Minimum Feladat


        // szamLista = { 19, 21, 21, 19, 21, 21, 18, 25, 20, 19, 16 };

        // szamListaHossz = szamLista.Length;

        int minErtek = szamLista[0];

        for (int i = 0; i < szamListaHossz; i++)
        {

            if (szamLista[i] < minErtek)
            {

                minErtek = szamLista[i];

            }

        }

        Console.WriteLine(minErtek);


        Console.WriteLine();
        // Maximum Feladat


        // szamLista = { 19, 21, 21, 19, 21, 21, 18, 25, 20, 19, 16 };

        // szamListaHossz = szamLista.Length;

        int maxErtek = szamLista[0];

        for (int k = 0; k < szamListaHossz; k++)
        {

            if (szamLista[k] > maxErtek)
            {

                maxErtek = szamLista[k];

            }

        }

        Console.WriteLine(maxErtek);


    }


}

