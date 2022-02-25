using System;

class Node{
        public int data;
        public Node next;
        public Node(int value)
        {
            data = value;
            next = null;
        }
    }
public class MyLinkedList{
    private Node head;
    private Node tail;
    private int length;
    public MyLinkedList(int value)
    {
        this.head = new Node(value);
        this.tail = this.head;
        this.length = 1;        
    }

    public void append(int value)
    {
        Node newNode = new Node(value);
        this.tail.next = newNode;
        this.tail = newNode;
        this.length++;
    }

    public void prepend(int value)
    {
        Node newNode = new Node(value);
        newNode.next = this.head;
        this.head = newNode;
        this.length++;
    }

    public void insert(int submittedIndex, int value)
    {
        int index = WrapIndex(submittedIndex);
        if (index == 0)
            {
                prepend(value);
                return;
            }

            if (index == length - 1)
            {
                append(value);
                return;
            }

            Node newNode = new Node(value);

            Node leader = traverseToIndex(index - 1);
            Node holdingPointer = leader.next;

            leader.next = newNode;
            newNode.next = holdingPointer;
            this.length++;
    }

    private Node traverseToIndex(int v)
    {
        int counter = 0;
        int index = WrapIndex(v);
        Node currNode = this.head;
        while(counter != index)
        {
            currNode = currNode.next;
            counter++;
        }
        return currNode;
    }

    public int WrapIndex(int index)
    {
        return Math.Max(Math.Min(index, this.length - 1),0);
    }
    public void printLL()
    {
        Node currNode = this.head;
        while(currNode != null)
        {
            Console.Write(currNode.data);
            Console.Write(" -> ");
            currNode = currNode.next;
        }
        Console.Write("NULL");
        Console.WriteLine("");
    }

    public void ReverseLL()
    {
        Node prevPointer = null,nextPointer = null,currPointer;
        currPointer = this.head;
        while(currPointer != null)
        {
            nextPointer = currPointer.next;
            currPointer.next = prevPointer;
            prevPointer = currPointer;
            currPointer = nextPointer;
        }
        this.head = prevPointer;
        this.printLL();
    }
}