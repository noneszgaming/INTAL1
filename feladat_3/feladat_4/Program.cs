using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int hashTableSize = 8;
        int[] values = [2, 8, 6, 4, 8, 9, 2, 1, 5, 6, 2, 8];

        Dictionary<int, int> hashTable = CreateHashTable(hashTableSize, values);

        foreach (var item in hashTable)
        {
            Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
        }
    }

    static Dictionary<int, int> CreateHashTable(int size, int[] values)
    {
        Dictionary<int, int> hashTable = new Dictionary<int, int>();

        for (int i = 0; i < values.Length; i++)
        {
            int hash = GetHash(values[i], size);
            hashTable[hash] = values[i] ;
        }

        return hashTable;
    }

    static int GetHash(int key, int size)
    {
        return key % size;
    }
}
