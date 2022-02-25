using System;
using System.Collections;

namespace MyStack
{   
    
    class Program
    {
        static int add(int x, int y)
        {
            // x^y + x&y << 1 while carryover is 0
            while (y != 0)
            {
                int carry = x & y;
                x = x^y;
                y = carry << 1;
            }
            return x;
        }

        static int substract(int x, int y)
        {
            // x^y - ~x&y << 1 while borrow is 0
            while (y != 0)
            {
                int borrow = ~x & y;
                x = x^y;
                y = borrow << 1;

            }
            return x;
        }

        static void Main(string[] args)
        {
            // int sum = substract(110,50);
            // System.Console.WriteLine(sum);
            Hashtable hashtable = new Hashtable();
            hashtable.Add("1","Vaibhav");
            hashtable.Add("2","Rohit");
            //var key = Console.ReadLine().Split(",")[0];
            //var value = Console.ReadLine().Split(",")[1];
            // if(!string.IsNullOrEmpty(key) && !string.IsNullOrEmpty(value))
            // {
            //     // if(hashtable.ContainsKey((val)))
            //     // {
            //     //     hashtable[args[0]] = "Maya"; 
            //     // }

            //     hashtable[key] = hashtable.ContainsKey(key) ? hashtable[key] : string.IsNullOrEmpty(value) ? "No Input" : value;
            // }
            
            // System.Console.WriteLine(hashtable[key]);
            // string[] arr = {"a","c","b","d"};
            // Array.Sort(arr);
            // Console.WriteLine(arr);
            // Queue myQueue = new Queue();
            // myQueue.Enqueue(1);
            // myQueue.Enqueue(2);
            // myQueue.Enqueue(3);
            // myQueue.printQueue();
            // Console.WriteLine(myQueue.first.value);
            // Console.WriteLine(myQueue.last.value);
             Stack<int> myStack = new Stack<int>(5);
              myStack.push(1);
              myStack.push(3);
              myStack.push(2);
              myStack.push(4);
              myStack.push(6);
              myStack.push(5);
              myStack.SortStack();
             myStack.printStack();
            // myStack.pop();
            // myStack.pop();
            // myStack.push(2);
            // myStack.push(3);
            // myStack.push(4);
            // myStack.push(5);
            // myStack.printStack();
            // myStack.peek();
            // myStack.pop();
            // myStack.pop();
            // myStack.pop();
            // myStack.pop();
            // myStack.pop();
        }
    }
}
