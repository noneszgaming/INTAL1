//Láncolt lista, CRUD műveletekkel. Objektumos megoldás és ...

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        LinkedList<int> LancoltLista = new LinkedList<int>();

        LancoltLista.AddFirst(5);
        LancoltLista.AddLast(10);
        LancoltLista.AddLast(15);
        LancoltLista.AddLast(20);

        Console.WriteLine("Lista elemei:");
        foreach (int elem in LancoltLista)
        {
            Console.Write(elem + " ");
        }
        Console.WriteLine();

        LinkedListNode<int> node = LancoltLista.Find(10);
        if (node != null)
        {
            LancoltLista.AddAfter(node, 12); 
            LancoltLista.Remove(10);
        }

        Console.WriteLine("\nLista elemei frissítés után:");
        foreach (int elem in LancoltLista)
        {
            Console.Write(elem + " ");
        }
        Console.WriteLine();

        LancoltLista.Remove(12);

        Console.WriteLine("\nLista elemei törlés után:");
        foreach (int elem in LancoltLista)
        {
            Console.Write(elem + " ");
        }
        Console.WriteLine();
    }
}