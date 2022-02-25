using System;

class SetOfStacks<T>
{
     public int length = 0;
        public Node<T> bottom {get; set; }
        public Node<T> top {get; set; }
        public int capacity = 5;
        public SetOfStacks()
        {
            this.bottom = null;
            this.top = null;
            this.length = 0;
        }

        public void push(int value)
        {
            if(length > capacity)
            {
                new SetOfStacks<T>();
            }
            Node<T> newNode = new Node<T>(value);            
                if (this.length == 0)
                {
                    this.bottom = newNode;
                    this.top = newNode;
                }
                else{
                    this.top.next = newNode;
                    this.top = newNode;
                }
                this.length++;
        }

        public void peek()
        {
            // Node newTop = this.bottom;
            // while (newTop.next != this.top)
            // {
            //     newTop = newTop.next;
            // }
            // Node peek = newTop.next;
            Console.WriteLine("Peeked value: " + this.top.value);
        }
        public int pop()
        {
            //T? t = default;
            Node<T> newTop = this.bottom;
            if(this.top == null)
            {
                return default;
            }

            if(this.bottom == this.top)
            {
                this.bottom = null;
                printStack();
                return default;
            }

            while (newTop.next != this.top)
            {
                newTop = newTop.next;
            }
            Node<T> pop = newTop.next;
            Console.WriteLine("Popped value: " + pop.value);
            this.top = newTop;
            this.top.next = null;
            printStack();
            this.length-- ;
            return pop.value;
        }

        public void printStack()
        {
            if (this.bottom == null)
            {
                Console.WriteLine("Stack Empty");
                return;
            }
            Node<T> newTop = this.bottom;
            while (newTop != null)
            {
                Console.Write(newTop.value + "-->");
                newTop = newTop.next;
            }
            Console.WriteLine();
        }
}