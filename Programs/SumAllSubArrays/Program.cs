using System;

namespace SumAllSubArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] {1,2};
            //identify all the subarrays
            // for(int i =0;i < a.Length; i++)
            // {
            //     for(int j=i; j < a.Length;j++)
            //     {
            //         for (int k = i; k <= j; k++)
            //         {
            //             Console.Write(a[k] + " ");
            //         }
            //         Console.WriteLine();
            //     }
            // }
            //int sum = subarray(a,0,0,0);
            int result = sumSubArray(a);
            System.Console.WriteLine(result);;
        }

        public static int sumSubArray(int[] a)
        {
            int result = 0;
            for (int i = 0; i < a.Length; i++)
            {
                int temp = 0;
                for(int j = i; j < a.Length; j++)
                {
                    temp += a[j];
                    result += temp;
                }
            }
            return result;
        }
        public static int subarray(int[] arr, int start, int end, int sum)
        {
            if(end == arr.Length)
            {
                return sum;
            }

            else if(start > end)
            {
                subarray(arr,0,end+1,sum);
            }
            else
            {
                for(int i = start ; i < end; i++)
                {
                    Console.Write(arr[i] + " ");
                    sum += arr[i];
                }
                Console.WriteLine(arr[end] + " ");
                sum+=arr[end];
                subarray(arr,start+1,end,sum);
                
            }
            return sum;
        }
    }
}

/*
1 -> 1
2 -> 3
3 -> 6
4 -> {1,2,3,4} -> 10
1,
2,
3,
4,
[1,2],
[2,3],
[3,4],
[1,2,3],
[2,3,4],
[1,2,3,4]
*/
