using System;

namespace PeldaHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Írj be egy számot: ");
            int bek = Convert.ToInt32(Console.ReadLine());
            int[] tomb = { 1, 2, 3, 4, 5, 6, 7};
            bool talalt = false;
            for(int i = 0; i < 5; i++)
            {
                if (tomb[i] == bek)
                {
                    bek = tomb[i];
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
    }
}
