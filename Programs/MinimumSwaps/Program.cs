using System;

namespace MinimumSwaps
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {2,3,4,1,5};
            int minswaps = MinimumSwapsCounter(arr);
            Console.WriteLine(minswaps);
        }

        public static int MinimumSwapsCounter(int[] arr) 
        {
            int counter = 0, temp = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if((i+1) != arr[i])
                {
                    for(int j = i + 1; j < arr.Length; j++)
                    {
                        if(arr[j] == i+1)
                        {   
                            ++counter;
                            temp = arr[i];
                            arr[i] = arr[j];
                            arr[j] = temp;                        
                        }
                    }
                }
            }
            return counter;
        }
    }

}
