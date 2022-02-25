using System;

namespace LIFO
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack(); 
            stack.Push(1); 
            stack.Push("Vaibhav"); 
            stack.Push(new int[3]{1,2,3}); 
            
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop()); 
        }
    }
}
