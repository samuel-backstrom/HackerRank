using System;
namespace HackerRank
{
    public static class LinkedListInsertAtSpecificPos
    {
        public static void Compute(SinglyLinkedListNode head, int pos, int data)
        {
            if (head is null)
                throw new ArgumentNullException(nameof(head));

            var current = head;
            var previous = head;
            for (int i = 0; i < pos; i++)
            {
                previous = current;
                current = current.Next;
            }

            previous.Next = new SinglyLinkedListNode(data)
            {
                Next = current
            };
        }

        public static void Run()
        {
            var head = new SinglyLinkedListNode(0);
            var current = head;
            for (int i = 1; i <= 5; i++)
            {
                current.Next = new SinglyLinkedListNode(i);
                current = current.Next;
            }
            Compute(head, 3, 10);
        }
    }

    public class SinglyLinkedListNode
    {
        public SinglyLinkedListNode Next { get; set; }
        public int Data { get; set; }
        public SinglyLinkedListNode(int data)
        {
            Data = data;
        }
    }
}