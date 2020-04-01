using System;
namespace HackerRank
{
    public static class DoublyLinkedListInsert
    {
        public static DoublyLinkedListNode Compute(DoublyLinkedListNode head, int data)
        {
            if (head is null)
                throw new ArgumentNullException(nameof(head));

            var current = head;
            while (current.data < data)
            {
                current = current.next;
                if (current.next == null)
                    break;
            }

            if (current.prev == null)
            {
                head.prev = new DoublyLinkedListNode(data)
                {
                    next = current,
                    prev = null
                };
                head = head.prev;
            }
            else if (current.next == null && data >= current.data)
            {
                var previous = current;
                previous.next = new DoublyLinkedListNode(data)
                {
                    prev = previous,
                    next = null
                };
            }
            else
            {
                var previous = current.prev;
                previous.next = new DoublyLinkedListNode(data)
                {
                    prev = previous,
                    next = current
                };
                current.prev = previous.next;
            }
            return head;
        }

        public static void Run()
        {
            var linkedList = new DoublyLinkedList();
            linkedList.InsertNode(1);
            linkedList.InsertNode(3);
            linkedList.InsertNode(4);
            linkedList.InsertNode(10);
            Compute(linkedList.head, 5);
        }
    }

    public class DoublyLinkedList
    {
        public DoublyLinkedListNode head;
        public DoublyLinkedListNode tail;

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void InsertNode(int nodeData)
        {
            DoublyLinkedListNode node = new DoublyLinkedListNode(nodeData);

            if (head == null)
            {
                head = node;
            }
            else
            {
                tail.next = node;
                node.prev = tail;
            }

            tail = node;
        }
    }

    public class DoublyLinkedListNode
    {
        public int data;
        public DoublyLinkedListNode next;
        public DoublyLinkedListNode prev;

        public DoublyLinkedListNode(int nodeData)
        {
            data = nodeData;
            next = null;
            prev = null;
        }
    }
}