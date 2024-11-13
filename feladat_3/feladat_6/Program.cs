using System;


class Node
{
    public int Data;
    public Node Left, Right;

    public Node(int item)
    {
        Data = item;
        Left = Right = null;
    }
}

class BinaryTree
{
    Node root;

    public void BuildTreeFromList(List<int> dataList)
    {
        dataList.Sort();
        root = BuildTree(dataList, 0, dataList.Count - 1);
    }

    private Node BuildTree(List<int> dataList, int start, int end)
    {
        if (start > end)
            return null;

        int mid = (start + end) / 2;
        Node node = new Node(dataList[mid]);

        node.Left = BuildTree(dataList, start, mid - 1);
        node.Right = BuildTree(dataList, mid + 1, end);

        return node;
    }

    void PreOrder(Node node)
    {
        if (node == null)
            return;

        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    void InOrder(Node node)
    {
        if (node == null)
            return;

        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    void PostOrder(Node node)
    {
        if (node == null)
            return;

        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
    }

    void PrintTree(Node node, int space = 0, int height = 10)
    {
        if (node == null)
            return;

        space += height;

        PrintTree(node.Right, space);

        Console.WriteLine();
        for (int i = height; i < space; i++)
            Console.Write(" ");
        Console.WriteLine(node.Data);

        PrintTree(node.Left, space);
    }

    public static void Main(String[] args)
    {
        BinaryTree tree = new BinaryTree();
        List<int> dataList = new List<int> { 1, 2, 3, 4, 5, 9, 15, 18, 19, 25, 48 };
        tree.BuildTreeFromList(dataList);

        Console.WriteLine("Preorder traversal:");
        tree.PreOrder(tree.root);

        Console.WriteLine("\nInorder traversal:");
        tree.InOrder(tree.root);

        Console.WriteLine("\nPostorder traversal:");
        tree.PostOrder(tree.root);

        Console.WriteLine("\nTree structure:");
        tree.PrintTree(tree.root);
    }
}
