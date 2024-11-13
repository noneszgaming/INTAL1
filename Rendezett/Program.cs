using System;

namespace Rendezetlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = { 1, 3, 5, 7 };
            int szam = 5;

            Console.WriteLine(Rendezett(tomb, szam));
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
    }
}
