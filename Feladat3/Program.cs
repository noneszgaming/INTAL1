namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tomb = [4, 3, 10, 1, 1];
            int szam = 1;

            Console.WriteLine(LinearisKereses(tomb, szam));
        }

        static bool LinearisKereses(int[] tomb, int szam)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] == szam)
                {
                    return true;
                }
            }

            return false;
        }
    }
}