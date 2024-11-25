// Feladat Medián kiszámítása

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        //int[] szamLista = { 19, 21, 21, 19, 21, 21, 18, 25, 20, 19, 16 }; // páratlan elemszámú Lista

        int[] szamLista = { 19, 21, 21, 19, 21, 21, 18, 25, 20, 19 }; // páros elemszámú Lista


        int szamListaHossz = szamLista.Length;


        int[] szamListaRendezett = szamLista;

        Array.Sort(szamListaRendezett);


        foreach (int i in szamListaRendezett)
        {
            Console.WriteLine(i);
        }


        Console.WriteLine();

        double median = -1;


        if (szamListaHossz % 2 == 0) // páros eset
        {

            int kozepsoElsoSzam = Convert.ToInt32(Math.Floor(Convert.ToDouble(szamListaHossz / 2.0)));

            int kozepsoMasodikSzam = Convert.ToInt32(Math.Ceiling(Convert.ToDouble((szamListaHossz / 2.0) + 0.51)));

            median = (szamListaRendezett[kozepsoElsoSzam - 1] + szamListaRendezett[kozepsoMasodikSzam - 1]) / 2.0;

        }
        else // páratlan eset
        {

            median = szamListaRendezett[(szamListaHossz / 2)];

        }

        Console.WriteLine(median);


    }


}

