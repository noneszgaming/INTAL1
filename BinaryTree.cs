public class TreeNode
{
    public string Value { get; set; }
    public TreeNode? Left { get; set; }
    public TreeNode? Right { get; set; }

    public TreeNode(string value)
    {
        Value = value;
    }
}

public class BinaryTree
{
    private TreeNode? root;
    private int index = 0;

    public void CreateTree(string input)
    {
        root = BuildTree(input);
    }

    private TreeNode? BuildTree(string input)
    {
        if (index >= input.Length) return null;

        // Skip parentheses
        while (index < input.Length && (input[index] == '(' || input[index] == ')'))
            index++;

        if (index >= input.Length) return null;

        // Read number
        if (!char.IsDigit(input[index])) return null;

        string number = "";
        while (index < input.Length && char.IsDigit(input[index]))
        {
            number += input[index];
            index++;
        }

        TreeNode node = new TreeNode(number);

        // Left subtree
        if (index < input.Length && input[index] == '(')
        {
            index++; // Skip '('
            node.Left = BuildTree(input);
        }

        // Right subtree
        if (index < input.Length && input[index] == '(')
        {
            index++; // Skip '('
            node.Right = BuildTree(input);
        }

        // Skip closing parenthesis
        if (index < input.Length && input[index] == ')')
            index++;

        return node;
    }

    public void PreOrder()
    {
        Console.WriteLine("\nPre-order bejárás:");
        PreOrderTraversal(root);
    }

    private void PreOrderTraversal(TreeNode? node)
    {
        if (node == null) return;
        Console.Write(node.Value + " ");
        PreOrderTraversal(node.Left);
        PreOrderTraversal(node.Right);
    }

    public void InOrder()
    {
        Console.WriteLine("\nIn-order bejárás:");
        InOrderTraversal(root);
    }

    private void InOrderTraversal(TreeNode? node)
    {
        if (node == null) return;
        InOrderTraversal(node.Left);
        Console.Write(node.Value + " ");
        InOrderTraversal(node.Right);
    }

    public void PostOrder()
    {
        Console.WriteLine("\nPost-order bejárás:");
        PostOrderTraversal(root);
    }

    private void PostOrderTraversal(TreeNode? node)
    {
        if (node == null) return;
        PostOrderTraversal(node.Left);
        PostOrderTraversal(node.Right);
        Console.Write(node.Value + " ");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Adja meg a fa szerkezetét (pl: (1(8(4(13))(7))(11(6(2)(10))(3(9)))) ):");
        string input = Console.ReadLine() ?? string.Empty;

        BinaryTree tree = new BinaryTree();
        tree.CreateTree(input);

        tree.PreOrder();
        tree.InOrder();
        tree.PostOrder();

        Console.ReadKey();
    }
}