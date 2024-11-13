using System;

public class pointer
{
    public int Data;
    public pointer Next;

    public pointer(int data)
    {
        Data = data;
        Next = null;
    }
}

public class lancolt_lista
{
    private pointer head;

    public lancolt_lista()
    {
        head = null;
    }

    // Create (Add) operation
    public void Add(int data)
    {
        pointer newNode = new pointer(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            pointer current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    // Read (Print) operation
    public void PrintList()
    {
        pointer current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }

    // Update operation
    public bool Update(int oldData, int newData)
    {
        pointer current = head;
        while (current != null)
        {
            if (current.Data == oldData)
            {
                current.Data = newData;
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    // Delete operation
    public bool Delete(int data)
    {
        if (head == null)
        {
            return false;
        }

        if (head.Data == data)
        {
            head = head.Next;
            return true;
        }

        pointer current = head;
        while (current.Next != null)
        {
            if (current.Next.Data == data)
            {
                current.Next = current.Next.Next;
                return true;
            }
            current = current.Next;
        }
        return false;
    }
}

class Program
{
    static void Main()
    {
        lancolt_lista list = new lancolt_lista();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.PrintList();

        list.Update(2, 4);
        list.PrintList();

        list.Delete(4);
        list.PrintList(); 
    }
}
