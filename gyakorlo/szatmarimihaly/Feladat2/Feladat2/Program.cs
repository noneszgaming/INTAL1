// Feladat Módusz kiszámítása


using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        int[] szamLista = { 19, 21, 21, 19, 21, 21, 18, 25, 20, 19, 16 };

        int szamListaHossz = szamLista.Length;


        Dictionary<int, int> frequencyMap = new Dictionary<int, int>();
        int legtobbDarabszamValaha = 0;
        int vegsoModuszErtek = -1;


        for (int k = 0; k < szamListaHossz; k++)
        {
            int jelenlegiSzam = szamLista[k];
            if (frequencyMap.ContainsKey(jelenlegiSzam))
            {

                frequencyMap[jelenlegiSzam]++;

            }
            else
            {
                frequencyMap[jelenlegiSzam] = 1;
            }


            if (frequencyMap[jelenlegiSzam] > legtobbDarabszamValaha)
            {
                legtobbDarabszamValaha = frequencyMap[jelenlegiSzam];
                vegsoModuszErtek = jelenlegiSzam;
            }
        }

        Console.WriteLine(vegsoModuszErtek + ", " + legtobbDarabszamValaha + " times");
    }
}

