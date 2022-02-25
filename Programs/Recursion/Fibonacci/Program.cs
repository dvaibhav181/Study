using System;
using System.Collections.Generic;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            //var result1 = fibonacciIterative(5);
            //var result2 = fibonacciRecursive(5);
            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            //Print1toN(5);
            //PrintNto1(5);
            var ar = new int[26];
            List<int> arr = new List<int> {0,1,8,2,5};
            SortRecursive(ref arr);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(FactorialRecursive(5));
        }

        public static void SortRecursive(ref List<int> arr)
        {
            if(arr.Count == 0)
            {
                return;
            }
            
            int temp = arr[arr.Count - 1];
            arr.RemoveAt(arr.Count - 1);
            SortRecursive(ref arr);
            RecursiveInsert(ref arr, temp);
            
        }

        public static void RecursiveInsert(ref List<int> arr, int temp)
        {
            if(arr.Count == 0 || (arr[arr.Count - 1] <= temp))
            {
                arr.Add(temp);
                return;
            }
            
            int val = arr[arr.Count - 1];
            arr.RemoveAt(arr.Count - 1);
            RecursiveInsert(ref arr, temp);
            arr.Add(val);
            return;
        }
        public static int FactorialRecursive(int n)
        {
            //base condition
            if(n <= 1)
            {
                return 1;
            }

            //Hypothesis
            int result = n * FactorialRecursive(n - 1);

            //Induction
            return result;
        }

        public static void PrintNto1(int n)
        {
            //base condition
            if(n == 1)
            {
                Console.WriteLine(1);
                return;
            }

            //Induction - placement is changed as opposed to printing 1 to N
            Console.WriteLine(n);

            //Hypothesis
            PrintNto1(n - 1);
        }
        public static void Print1toN(int n)
        {
            //Base condition
            if(n == 1)
            {
                Console.WriteLine(1);
                return;
            }

            //Hypothesis
            Print1toN(n-1);

            //Induction
            Console.WriteLine(n);
        }
        public static int fibonacciIterative(int number)
        {
            var result = 0;
                for (int i = 0; i < number; i++)
                {
                    result = result + i;
                }
            return result;
        }

        public static int fibonacciRecursive(int number)
        {
            if(number <= 2)
            {
                return 1;
            }
            int result = fibonacciRecursive(number - 1) + fibonacciRecursive(number - 2);
            
            return result;
        }
    }

    
}
