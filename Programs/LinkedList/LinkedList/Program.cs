using System;

namespace LinkedList
{
    public class Node
    {
        public int value { get; set; }
        public Node next { get; set; }

        public Node()
        {
            this.next = null;
        }
        public Node(int value)
        {
            this.value = value;
            this.next = null;
        }
    }

    public class LinkedList
    {
        private Node head;
        private Node tail;
        private int length;

        public LinkedList()
        {
            this.head = new Node();
            this.tail = this.head;
            this.length = 1;
        }

        public LinkedList(int value)
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

        public void insert(int index, int value)
        {
            index = wrapIndex(index);
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

        public void remove(int index)
        {
            index = wrapIndex(index);
            if (index == 0)
            {
                head = head.next;
                return;
            }

            Node leader = traverseToIndex(index - 1);
            Node nodeToRemove = leader.next;
            leader.next = nodeToRemove.next;
            this.length--;
        }

        public void reverse()
        {
            Node first = head;
            tail = head;
            Node second = first.next;
            for (int i = 0; i < length - 1; i++)
            {
                Node temp = second.next;
                second.next = first;
                first = second;
                second = temp;
            }
            head.next = null;
            head = first;
        }

        public void printList()
        {
            if (this.head == null)
            {
                return;
            }
            Node current = this.head;
            while (current != null)
            {
                Console.Write(current.value + "-->");
                current = current.next;
            }
            Console.Write("null");
            Console.WriteLine();
        }

        public int getLength()
        {
            return this.length;
        }

        public Node getHead()
        {
            return this.head;
        }

        public Node getTail()
        {
            return this.tail;
        }

        private int wrapIndex(int index)
        { 
            return Math.Max(Math.Min(index, this.length - 1), 0);
        }

        private Node traverseToIndex(int index)
        {
            int counter = 0;
            index = wrapIndex(index);
            Node currentNode = head;
            while (counter != index)
            {
                currentNode = currentNode.next;
                counter++;
            }
            return currentNode;
        }

        private void duplicate()
        {
            Node firstPointer = head;
            Node secondPointer = head.next;
            int firstIndex = 0;
            int secondIndex = 1;
            while(firstPointer != null)
            {
                while(secondPointer != null)
                {
                    if(firstPointer.value == secondPointer.value)
                    {
                        this.remove(firstIndex);
                        this.remove(secondIndex);
                    }
                    secondPointer = secondPointer.next;
                    secondIndex++;
                }
                firstPointer = firstPointer.next;
                secondPointer = (firstPointer == null || firstPointer.next == null) ? null : firstPointer.next;
                firstIndex++;
                secondIndex = firstIndex+1;
            }
        }

        private void kthToLast(int index)
        {
            if(this.length < index)
            {
                Console.WriteLine("Incorrect Index");
                return;
            }
            Node leader = traverseToIndex(index - 1);
            while(leader != null)
            {
                Console.Write("-->" + leader.value);
                leader = leader.next;
            }
            Console.WriteLine();            
        }

        static void Main(string[] args)
        {
            LinkedList l1 = new LinkedList(1);
            l1.append(2);
            l1.append(3);
            l1.append(4);
            l1.ReorderList();
            l1.printList();
            

            LinkedList l2 = new LinkedList(2);
            l2.append(9);
            l2.append(5);

            //l2.append(3);
            

            Add(l1,l2);
            AddForward(l1,l2);


            //l.append(5);
            //l.append(16);
            //l.prepend(1);
            //l.insert(2, 99);
            //l.insert(20, 19);
            //l.remove(2);
            //l.reverse();
            //l.printList();
            //l.duplicate();        
            //l.kthToLast(7);
            //l.printList();
        }

        private static void AddForward(LinkedList l1, LinkedList l2)
        {
            throw new NotImplementedException();
        }

        public void ReorderList() {
        Node dummy = head;
        Node tail = head;
        int countNodes = 1;
        int counter = 1;
        while(tail.next != null)
        {
            tail = tail.next;
            countNodes++;
        }
        
        int till = countNodes%2 == 0 ? (countNodes/2) - 1 : (countNodes/2);
        
        while(counter <= till)
        {
            tail.next = dummy.next;
            dummy = tail.next;
            //tail = dummy;
            while(tail.next != null)
            {
                tail = tail.next;
            }
            counter++;
        }
    }

        private static void Add(LinkedList l1, LinkedList l2)
        {
            var bigList = l1.length > l2.length ? l1 : l2;
            var smallList = l1.length < l2.length ? l1 : l2;

            if(l1.length == l2.length)
            {
                bigList = l1;
                smallList= l2;
            }
            var carryover = 0;  
            var sum = 0; 
            var count = 0;         
            LinkedList l3 = new LinkedList();
            Node curr = l3.head;
            while(bigList.head != null)
            {
                if(smallList.head != null)
                {
                    sum = bigList.head.value + smallList.head.value + carryover;
                    carryover = sum / 10;
                    if(count == 0)
                    {
                        l3.head.value = sum%10;
                        count++;
                        //l3.insert(2,0);
                        //l3.head = l3.head.next;
                    }
                    else
                    {
                        l3.append(sum%10);
                    }
                }
                else
                {
                    sum = bigList.head.value + carryover;
                    carryover = sum / 10;
                    l3.append(sum);
                }
                bigList.head = bigList.head.next;
                smallList.head = smallList.head == null ? null : smallList.head.next;
            }
            
            if(carryover > 0)
            {
                l3.append(carryover);
            }            
            l3.printList();
        }
    }
}