using System;
using System.Collections;

namespace MaximumContSubArrK
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10]{8, 5, 10, 7, 9, 4, 15, 12, 90, 13};
            int k = 3;
            maxnumber(a,k);
            // foreach(var item in result)
            // {
            //     System.Console.WriteLine(item);
            // }
        }

        public static void maxnumber(int[] a, int k)
        {
            int max =0;
            int[] ret = new int[a.Length - k + 1];
            // while(i <= a.Length - k)
            // {
            //     j = i + k - 1;
            //     int m = i, max = 0;
            //     Stack s = new Stack();
            //     while(m <= j)
            //     {
            //         if(s.Count == 0)
            //         {
            //             s.Push(a[m]);
            //         }
            //         else if(a[m] > (int)s.Peek())
            //         {
            //             s.Pop();
            //             s.Push(a[m]);
            //         }
            //         m++;
            //     }
            //     ret[i] = (int)s.Pop();
            //     s.Clear();
            //     i++;
            // }
            for(int i = 0; i < a.Length - k; i++)
            {
                max = a[i];
                for(int j = 1; j < k; j++)
                {
                    if(a[i+j] > max)
                    {
                        max = a[i+j];
                    }
                }
                System.Console.WriteLine(max + " ");
            }
            
            
        }
    }
}
