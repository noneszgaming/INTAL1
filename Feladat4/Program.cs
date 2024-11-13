using System;
using System.Security.Policy;

namespace Intal2
{
    internal class Program
    {
        //1. Konzolról bekért karakter és string esetén a karakter sztringbeli megkeresése.Output: a karakter pozíciója, ha taláható.

        //2. Konzolról bekért string rendezése char szerint.

        //3. Lineáris keresés (rendezetlen és rendezett esetben)

        //4. Hash tábla kezelése.Input: hash méret, értékek. Output: hash tábla

        //5. Láncolt lista. 'CRUD'

        //6. Fa postorder bejárása

        static void Main(string[] args)
        {
            int[] tomb = { 1, 4, 3, 10 };
            int[] tomb2 = { 1, 3, 5, 7 };
            int szam = 5;

            tomb = Add(tomb, szam);

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.WriteLine(i + ": " + tomb[i]);
            }

            Console.ReadLine();
        }

        static int Rendezetlen(int[] tomb, int szam)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == szam)
                {
                    return i;
                }
            }

            return -1;
        }

        static bool Rendezett(int[] tomb, int szam)
        {
            bool megvan = false;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == szam)
                {
                    megvan = true;
                    break;
                }
                else if (tomb[i] > szam)
                {
                    break;
                }
            }

            return megvan;
        }

        static int[] Hasheles(int[] tomb, int meret)
        {
            int[] hash = new int[meret];

            for (int i = 0; i < tomb.Length; i++)
            {
                hash[tomb[i] % meret] = tomb[i];
            }

            return hash;
        }

        static int[] Add(int[] lista, int ujSzam)
        {
            int[] ujLista = new int[lista.Length + 1];

            for (int i = 0; i < lista.Length; i++)
            {
                ujLista[i] = lista[i];
            }

            ujLista[ujLista.Length - 1] = ujSzam;

            return ujLista;
        }
    }
}
