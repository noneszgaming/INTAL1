class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }
}

class Program
{
    static void PreorderTraversal(Node root)
    {
        if (root == null)
            return;

        Console.Write(root.Data + " ");
        PreorderTraversal(root.Left);
        PreorderTraversal(root.Right);
    }

    static void InorderTraversal(Node root)
    {
        if (root == null)
            return;

        InorderTraversal(root.Left);
        Console.Write(root.Data + " ");
        InorderTraversal(root.Right);
    }

    static void PostorderTraversal(Node root)
    {
        if (root == null)
            return;

        PostorderTraversal(root.Left);
        PostorderTraversal(root.Right);
        Console.Write(root.Data + " ");
    }

    static void Main(string[] args)
    {
        // fa kreálás
        Node root = new Node(1);
        
        // 1 szint
        root.Left = new Node(8);
        root.Right = new Node(11);
        
        // 2 szint
        root.Left.Left = new Node(4);
        root.Left.Right = new Node(7);
        root.Right.Left = new Node(6);
        root.Right.Right = new Node(3);
        
        // 3 szint
        root.Left.Left.Left = new Node(13);
        root.Right.Left.Left = new Node(2);
        root.Right.Left.Right = new Node(10);
        root.Right.Right.Left = new Node(9);

        Console.WriteLine("Preorder bejárás");
        PreorderTraversal(root);
        Console.WriteLine("\n");

        Console.WriteLine("Inorder traversal of the binary tree:");
        InorderTraversal(root);
        Console.WriteLine("\n");

        Console.WriteLine("Postorder bejárás:");
        PostorderTraversal(root);
        Console.WriteLine();
    }
}
