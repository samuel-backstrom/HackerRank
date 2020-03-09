using System.Collections.Generic;
using System;

namespace HackerRank
{
    public static class BinTreeHeight
    {
        public static int Compute(BinTree tree)
        {
            if (tree is null)
                throw new ArgumentNullException(nameof(tree));

            var current = new Stack<Node>();
            var next = new Stack<Node>();
            var depth = -1;

            current.Push(tree.Root);
            while (current.Count != 0)
            {
                var node = current.Pop();
                if (node.LeftChild != null)
                    next.Push(node.LeftChild);
                if (node.RightChild != null)
                    next.Push(node.RightChild);

                if (current.Count == 0)
                {
                    depth += 1;
                    current = next;
                    next = new Stack<Node>();
                }
            }

            return depth;
        }

        public static BinTree InitTree()
        {
            var tree = new BinTree();
            var values = new int[] { 3, 2, 6, 1, 5, 8, 4, 12, 9 };
            foreach (var n in values)
                tree.Insert(n);
            return tree;
        }

        public static void Run()
        {
            var tree = InitTree();
            Console.WriteLine(Compute(tree));
        }
    }


}