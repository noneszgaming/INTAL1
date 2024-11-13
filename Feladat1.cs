class Feladat1
{
    public static void Main(String[] args)
    {
        Console.Write("Adj meg egy karaktert:");
        char keresettKarakter = Console.ReadKey().KeyChar;
        Console.WriteLine();


        Console.Write("Adj meg egy szöveget:");
        string bekertSzoveg = Console.ReadLine();

        int pozicio = bekertSzoveg.IndexOf(keresettKarakter);

        if (bekertSzoveg.Length > 0)
        {
            Console.WriteLine($"A '{keresettKarakter}' a karakter pozíciója a szövegben {pozicio + 1}.");
        }
        else
        {
            Console.WriteLine($"A '{keresettKarakter}' a karakter pozíciója a szövegben nem található.");
        }
    }
}
