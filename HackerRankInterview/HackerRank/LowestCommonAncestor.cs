using System.Linq;
using System.Collections;
using System;
using System.Collections.Generic;

namespace HackerRank
{
    public static class LowestCommonAncestor
    {
        public static int Compute(int v1, int v2, BinTree tree)
        {
            var v1List = Search(v1, tree);
            var v2List = Search(v2, tree);

            var shortestLength = v1List.Count < v2List.Count ? v1List.Count : v2List.Count;
            var i = 0;
            while (i < shortestLength && v1List[i] == v2List[i])
                i++;

            return v1List[i - 1];
        }

        public static IList<int> Search(int v, BinTree tree)
        {
            if (tree is null)
                throw new ArgumentNullException(nameof(tree));

            var list = new List<int>();
            var current = tree.Root;
            list.Add(current.Value);
            while (current.Value != v)
            {
                if (v > current.Value)
                    current = current.RightChild;
                else if (v < current.Value)
                    current = current.LeftChild;
                list.Add(current.Value);
            }
            return list;
        }

        public static void Run()
        {
            var tree = new BinTree();
            tree.Insert(8);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(3);
            tree.Insert(6);
            tree.Insert(5);
            tree.Insert(7);
            tree.Insert(10);
            tree.Insert(14);
            tree.Insert(15);
            tree.Insert(9);
            tree.Insert(12);
            tree.Insert(11);
            tree.Insert(13);
            var result = Compute(15, 11, tree);
            System.Console.WriteLine(result);
        }
    }
}