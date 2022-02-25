using System;

namespace SortSelect
{
    class Program
    {
        
        static void Main()
        {
            int[] arr = {3,5,7,13,2,8,5};
            int k = 3;
            if(k > arr.Length)
            {
                Console.WriteLine("Incorrect Input");
            }
            else
            {
                Console.WriteLine("k is: {0}", k);
                int kSmallest = kthSmallest(arr,k);
                Console.WriteLine("Kth Smallest Element is: {0}", kSmallest);
                int kLargest = kthLargest(arr,k);
                Console.WriteLine("Kth Largest Element is: {0}", kLargest);
            }
            
        }

        private static int kthSmallest(int[] arr, int k)
        {
            Array.Sort(arr); //2,3,5,7,13
            return arr[k-1];
        }

        private static int kthLargest(int[] arr, int k)
        {
            Array.Sort(arr); //2,3,5,7,13
            return arr[arr.Length - k];
        }
        
    }
}
