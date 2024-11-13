class Node
{
    public int Data { get; set; }
    public Node Next { get; set; }

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class LinkedList
{
    private Node head;

    //Beszúrás a lista végére
    public void Add(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            return;
        }

        Node current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    //Lista kiírása
    public void Display()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    //Elem módosítása
    public void Update(int oldValue, int newValue)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data == oldValue)
            {
                current.Data = newValue;
                return;
            }
            current = current.Next;
        }
    }

    //Elem törlése
    public void Delete(int data)
    {
        if (head == null) return;

        if (head.Data == data)
        {
            head = head.Next;
            return;
        }

        Node current = head;
        while (current.Next != null)
        {
            if (current.Next.Data == data)
            {
                current.Next = current.Next.Next;
                return;
            }
            current = current.Next;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        LinkedList list = new LinkedList();

        // Elemek hozzáadása
        list.Add(10);
        list.Add(20);
        list.Add(30);
        list.Add(40);

        Console.WriteLine("Eredeti lista:");
        list.Display();

        // Elem módosítása
        list.Update(20, 25);
        Console.WriteLine("\nLista módosítás után (20 -> 25):");
        list.Display();

        // Elem törlése
        list.Delete(30);
        Console.WriteLine("\nLista törlés után (30 törölve):");
        list.Display();

        Console.ReadKey();
    }
}
