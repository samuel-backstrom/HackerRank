namespace HackerRank
{
    public class BinTree
    {
        public Node Root { get; private set; }
        public void Insert(int data)
        {
            if (Root is null)
            {
                Root = new Node(data);
            }
            else
            {
                var current = Root;
                Node parent = null;
                while (current != null)
                {
                    if (data < current.Value)
                    {
                        parent = current;
                        current = current.LeftChild;
                    }
                    else if (data > current.Value)
                    {
                        parent = current;
                        current = current.RightChild;
                    }
                }

                if (data > parent.Value)
                    parent.RightChild = new Node(data);
                if (data < parent.Value)
                    parent.LeftChild = new Node(data);
            }
        }
    }

    public class Node
    {
        public Node(int data)
        {
            Value = data;
        }

        public int Value { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
    }
}