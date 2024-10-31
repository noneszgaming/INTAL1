namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
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
    }
}
