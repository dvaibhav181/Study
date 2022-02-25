using System;

class Queue<T>
{
    // public Stack S1 = new Stack();
    // public Stack S2 = new Stack();

    // void enqueue(int value)
    // {
    //     while(S1.length > 0)
    //     {
    //         S2.push(S1.pop());
    //         S1.length--;
    //     }

    //     S1.push(value);

    //     while(S2.length > 0)
    //     {
    //         S1.push(S2.pop());
    //         S2.length--;
    //     }

    // }
    
    public int capacity;
    public Node<T> first;
    public Node<T> last;
    public Queue()
    {
        this.capacity = 0;
        this.first = null;
        this.last = null;
    }

    public void Enqueue(int value)
    {
        Node<T> newNode = new Node<T>(value);
        if(last != null)
        {
            last.next = newNode;
            this.capacity++;
        }

        last = newNode;
        if(first == null)
        {
            first = last;
        }
        this.capacity++;
    }

    public int Dequeue()
    {
        if(first == null)
        {
            return default;
        }
        
        int data = first.value;
        first = first.next;
        return data;

    }

    public int peek()
    {
        if(first == null)
        {
            return default;
        }
        return first.value;
    }

    public void printQueue()
        {
            if (first == null)
            {
                Console.WriteLine("Queue Empty");
                return;
            }
            Node<T> newTop = first;
            while (newTop != null)
            {
                Console.Write(newTop.value + "-->");
                newTop = newTop.next;
            }
            Console.WriteLine();
        }

}