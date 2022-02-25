using System;
class Stack<T>
    {
        public T[] sArray {get; set;}
        public int length = 0;
        public int _capacity {get; set;}
        public Node<T> bottom {get; set; }
        public Node<T> top {get; set; }
        public Stack(int capacity)
        {
            this.bottom = null;
            this.top = null;
            this.length = 0;
            this._capacity = capacity;
            sArray = new T[capacity];
        }

        public void push(int value)
        {
            Node<T> newNode = new Node<T>(value);            
            if (this.length == 0)
            {
                this.bottom = newNode;
                this.top = newNode;
            }
            else if(this._capacity == 0 || this.length < this._capacity){
                this.top.next = newNode;
                this.top = newNode;
            }
            else
            {
                Console.WriteLine("Stack Overflow Error");
                //throw new StackOverflowException();
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
            Node<T> newTop = this.bottom;
            if(this.top == null)
            {
                return -1;
            }

            // if(this.bottom == this.top)
            // {
            //     printStack();
            //     return t;
            // }

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

        public void SortStack()
        {
            if(this.top == null)
                return;
            
            int temp = this.top.value;
            this.pop();
            this.SortStack();
            Insert(this, temp);
            
            return;
        }

        public void Insert(Stack<T> stack, int temp)
        {
            if(stack.top == null || stack.top.value <= temp)
            {
                stack.push(temp);
                return;
            }
            int val = stack.top.value;
            stack.pop();
            Insert(stack, temp);
            return;
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