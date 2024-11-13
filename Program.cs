using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace hierlist
{
    public class HierarchicalNode
    {
        public int Value;
        public List<HierarchicalNode> Children;

        public HierarchicalNode(int value)
        {
            Value = value;
            Children = new List<HierarchicalNode>();
        }
    }

    public class BinaryTreeNode
    {
        public int Value;
        public BinaryTreeNode Left;
        public BinaryTreeNode Right;

        public BinaryTreeNode(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }

    public class BinaryTreeNodeConverter
    {
        public BinaryTreeNode Tree;

        public string FindNextItem(string s)
        {
            string next = "";

            if ((char)s[0] == '(')
            {
                next = "(";
            }
            else if ((char)s[0] == ')')
            {
                next = ")";
            }
            else 
            {
                foreach (char c in s)
                {
                    if (!Char.IsDigit(c))
                    {
                        break;
                    }
                    next += c;
                }
            }

            return next;
        }

        public string Converter(ref string s, BinaryTreeNode node)
        {
            string res = "";

            while (s.Length > 0)
            {
                res = FindNextItem(s);

                if (res == "(")
                {
                    s = s.Remove(0, res.Length);
                    BinaryTreeNode n = new BinaryTreeNode(0);
                    if (node.Left == null)
                        node.Left = n;
                    else
                        node.Right = n;
                    Converter(ref s, n);
                }
                else if (res == ")")
                {
                    s = s.Remove(0, res.Length);
                    return "";
                }
                else
                {
                    s = s.Remove(0, res.Length);
                    node.Value = Int32.Parse(res);
                }
            }

            return res;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            // 1.

            string s = Console.ReadLine();
            char c = Console.ReadLine()[0];

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            foreach (var item in s)
            {
                if (item == c)
                {
                    Console.WriteLine(item);
                }
            }
            */


            double doubleY = 8d;
            int intY = 8, intX = 3;

            double d = doubleY / intX;



            string HierList = "(1(8(4(13))(7))(11(6(2)(10))(3(9))))";

            BinaryTreeNodeConverter b = new BinaryTreeNodeConverter();
            b.Tree = new BinaryTreeNode(0);
            b.Converter(ref HierList, b.Tree);

            Console.ReadLine();
        }
    }
}
