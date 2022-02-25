using System;
using System.Collections.Generic;
using System.Linq;

namespace SubsetSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[]{1,2,7};
            var dest = arr[0..1];
            var dict = new Dictionary<int,int>();
            HashSet<int> hS= new HashSet<int>();
            List<int> x = new List<int>();
            var s = Int32.MinValue;
            //int sum = 11;
            //bool result = RecursiveSubsetSum(arr,sum,arr.Length);
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            int answer = MinSubSetSumDiff(arr,sum);
            Console.WriteLine(answer);
            //bool result = DPSubsetSum(arr,sum);
            //Console.WriteLine(result.ToString());
        }

        private static int MinSubSetSumDiff(int[] arr, int sum)
        {
            bool[,] t = DPSubsetSum(arr,sum);
            t.GetLength(0);
            t.GetLength(1);
            t[0,0] = true;
            t[0, 0] = false;

            int[] v = new int[sum/2 + 1];
            for(int j = 0; j <= sum/2; j++)
            {
                if(t[arr.Length,j] == true)
                {
                    v[j] = j;
                }
            }

            int ans = Int32.MaxValue;
            for(int k = 0; k < v.Length; k++)
            {
                ans = Math.Min(ans, sum - 2*v[k]);
            }

            return ans;
        }

        private static bool[,] DPSubsetSum(int[] arr, int sum)
        {
            bool[,] t = new bool[arr.Length + 1,sum + 1];
            for(int i = 0 ; i <= arr.Length; i++)
            {
                for(int j = 0; j <= sum; j++)
                {
                    if(i == 0)
                    {
                        t[i,j] = false;
                    }
                    if(j == 0)
                    {
                        t[i,j] = true;
                    }
                }
            }

            for(int i = 1; i <= arr.Length; i++)
            {
                for(int j = 1; j <= sum; j++)
                {
                    if(arr[i-1] <= j)
                    {
                        t[i,j] = t[i-1,j-arr[i-1]] || t[i-1,j];
                    }
                    else
                    {
                        t[i,j] = t[i-1,j];
                    }
                }
            }
            
            return t;
            //return t[arr.Length,sum];
        }

        private static bool RecursiveSubsetSum(int[] arr, int sum, int n)
        {
            if(sum == 0)
            {
                return true;
            }
            if(n == 0)
            {
                return false;
            }

            // if((n == 0 && sum == 0) || (n > 0 && sum == 0))
            // {
            //     return true;
            // }

            /*if(arr[n-1] > sum)
            {
                return RecursiveSubsetSum(arr,sum,n-1);
            }
            return RecursiveSubsetSum(arr, sum ,n - 1) || RecursiveSubsetSum(arr, sum - arr[n-1], n-1) ;
            */

            if(arr[n-1] <= sum)
            {
                return RecursiveSubsetSum(arr, sum - arr[n-1], n-1) || RecursiveSubsetSum(arr, sum ,n - 1);
            }
            else
            {
                return RecursiveSubsetSum(arr,sum,n-1);
            }
        }
    }
}
