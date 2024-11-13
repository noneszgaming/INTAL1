using System;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    // Create (Add) operation
    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
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
        Node current = head;
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
        Node current = head;
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

        Node current = head;
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
        LinkedList list = new LinkedList();
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
