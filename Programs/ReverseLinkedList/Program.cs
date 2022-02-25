using System;
using System.Collections.Generic;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            // MyLinkedList myLinkedList = new MyLinkedList(2);
            // myLinkedList.append(3);
            // myLinkedList.printLL();
            // myLinkedList.prepend(1);
            // myLinkedList.printLL();
            // myLinkedList.ReverseLL();
            //Console.WriteLine("Hello World!");

            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);

            //LinkedListNode<int> prevNode = null;
            LinkedListNode<int> currNode = null;
            LinkedListNode<int> nextNode = null;

            LinkedListNode<int> head = linkedList.First;
            currNode = head;

            while(currNode != null)
            {
                nextNode = currNode.Next;
                linkedList.Remove(nextNode);
                linkedList.AddFirst(nextNode.Value);
            }

            foreach(var item in linkedList)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
