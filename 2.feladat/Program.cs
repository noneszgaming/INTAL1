using System;

namespace PeldaHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Írj be egy szöveget: ");
            String beker = Console.ReadLine();
            char[] arr = beker.ToCharArray();
            Array.Sort(arr);
            Console.WriteLine(arr);
            Console.ReadKey();
        }
    }
}