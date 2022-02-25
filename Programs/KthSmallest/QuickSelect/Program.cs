using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace QuickSelect
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arr = {10,4,5,8,6,11,26};
            // int k = 3;//Convert.ToInt32(Console.ReadLine());
            // int arrLength = arr.Length;

            Heap h = new Heap();

            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(4);
            stack.Pop();
            stack.Push(3);
            stack.Push(2);
            System.Console.WriteLine(stack.Peek()); 
            stack.TryPop(out int stackResult);
            System.Console.WriteLine(stackResult); 
            foreach (var item in stack)
            {
                System.Console.WriteLine(item);
            }

             Queue<int> q = new Queue<int>();
            // q.Enqueue(5);
            // q.Enqueue(4);
            // q.Enqueue(6);
            // q.Count;
            // q.TryDequeue(out int qResult);
            // System.Console.WriteLine(qResult);
            // foreach (var item in q)
            // {
            //     System.Console.WriteLine(item);
            // }

            LinkedList<string> linkedList = new LinkedList<string>();
            LinkedListNode<string> node1 = linkedList.AddFirst("V"); // linkedList.AddLast("V");
            LinkedListNode<string> node2 = linkedList.AddAfter(node1,"A"); // linkedList.AddLast("A");
            LinkedListNode<string> node3 = linkedList.AddAfter(node2,"I"); // linkedList.AddLast("I");
            LinkedListNode<string> node4 = linkedList.AddAfter(node3,"B"); // linkedList.AddLast("B");
            LinkedListNode<string> node5 = linkedList.AddAfter(node4,"H"); // linkedList.AddLast("H");
            LinkedListNode<string> node6 = linkedList.AddAfter(node5,"A"); // linkedList.AddLast("A");
            LinkedListNode<string> node7 = linkedList.AddAfter(node6,"V"); // linkedList.AddLast("V");
            
            foreach (var item in linkedList)
            {
                System.Console.WriteLine(item);
            }

            // string str = "rohit";
            // str = "maya";
            // Console.WriteLine(str);
            // StringBuilder sb = new StringBuilder();
            // sb.Append('c' + 3);
            // LinkedList<int> adj = new LinkedList<int>[5];
            // while(adj.Count > 0)
            // {

            // }
            // if(k > arrLength)
            // {
            //     Console.WriteLine("Invalid Input");                
            // }
            // else
            // {
            //     Console.WriteLine("Kth smallest element in the array is: {0}", kthSmallest(arr,0,arrLength-1,k-1));
            // }
        }

        private static int kthSmallest(int[] arr, int low, int high, int k)
        {
            try{
                int partitionIndex = randomPartition(arr,low,high);

                if(partitionIndex == k)
                {
                    return arr[partitionIndex];
                }
                else if(partitionIndex < k)
                {
                    return kthSmallest(arr,partitionIndex + 1,high,k);
                }
                else
                {
                    return kthSmallest(arr,low,partitionIndex - 1,k);
                }
            }
            catch(ArgumentException ex)
            {
                throw new ArgumentException(ex.Message);
            }
            
        }

        private static int randomPartition(int[] arr, int low, int high)
        {
            int n = high - low - 1;
            Random rnd = new Random();
            int rand = rnd.Next(0,1);
            int piv = (int)(rand * (n-1));

            int temp = arr[low + piv];
            arr[low + piv] = arr[high];
            arr[high] = temp;

            return partition(arr,low,high);
        }

        private static int partition(int[] arr, int low, int high)
        {
            try{
                int pivot = arr[high];
                int temp, currentPivot = low;

                for(int i = low; i <= high; i++)
                {
                    if(arr[i] < pivot)
                    {
                        temp = arr[i];
                        arr[i] = arr[currentPivot];
                        arr[currentPivot] = temp;
                        currentPivot++;
                    }
                }

                temp = arr[high];
                arr[high] = arr[currentPivot];
                arr[currentPivot] = temp;
                return currentPivot;
            }
            catch(InvalidOperationException ex)
            {
                throw new InvalidOperationException(ex.Message);
            }
        }
    }
}
