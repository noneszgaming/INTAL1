using System;


class TreeNode
{
    public int Value;
    public TreeNode Left;
    public TreeNode Right;

    public TreeNode(int value)
    {
        Value = value;
        Left = null;
        Right = null;
    }
}

class BinaryTree
{
    public TreeNode Root;

    public BinaryTree(string structure)
    {
        int index = 0;
        Root = BuildTree(structure, ref index);
    }

    private TreeNode BuildTree(string structure, ref int index)
    {
        if (index >= structure.Length || structure[index] == ')')
        {
            return null;
        }

        int value = 0;
        while (index < structure.Length && char.IsDigit(structure[index]))
        {
            value = value * 10 + (structure[index] - '0');
            index++;
        }

        TreeNode node = new TreeNode(value);

        if (index < structure.Length && structure[index] == '(')
        {
            index++; // Skip '('
            node.Left = BuildTree(structure, ref index);
            index++; // Skip ')'
        }

        if (index < structure.Length && structure[index] == '(')
        {
            index++; // Skip '('
            node.Right = BuildTree(structure, ref index);
            index++; // Skip ')'
        }

        return node;
    }

    public void PreOrderTraversal(TreeNode node)
    {
        if (node == null)
        {
            return;
        }

        Console.Write(node.Value + " ");
        PreOrderTraversal(node.Left);
        PreOrderTraversal(node.Right);
    }

    public void DisplayTree(TreeNode node, string indent = "", bool last = true)
    {
        if (node != null)
        {
            Console.Write(indent);
            if (last)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "| ";
            }
            Console.WriteLine(node.Value);

            DisplayTree(node.Left, indent, false);
            DisplayTree(node.Right, indent, true);
        }
    }
}

class Program
{
    static void Main()
    {
        string structure = "(1(8(4(13))(7))(11(6(2)(10))(3(9)))";
        BinaryTree tree = new BinaryTree(structure);
        tree.PreOrderTraversal(tree.Root);
        Console.WriteLine();
        Console.WriteLine();
        tree.DisplayTree(tree.Root);
    }
}
