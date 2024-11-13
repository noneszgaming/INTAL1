using System;

class Program
{
    static void Main()
    {
        int[] array = { 5, 3, 8, 4, 2 };
        int target = 4;
        int index = LinearSearch(array, target);

        if (index != -1)
        {
            Console.WriteLine($"Az elem megtalálható a(z) {index} indexen.");
        }
        else
        {
            Console.WriteLine("Az elem nem található a tömbben.");
        }
    }

static int LinearSearch(int[] array, int target)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == target)
            {
                return i;
            }
        }
        return -1;
    }
}
