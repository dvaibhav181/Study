using System;
using System.Collections;

namespace ArrayManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] m = new int[3][]{
                new int[3]{2,4,7},
                new int[3]{1,3,1},
                new int[3]{3,5,13}
                //  new int[3]{1,2,100},
                //  new int[3]{2,5,100},
                //  new int[3]{3,4,100}
            };

            long[] arr = new long[6]{0,0,0,0,0,0};
            //long[] arr = new long[5]{0,0,0,0,0};

            for(int i = 0; i < m.Length; i++)
            {
                arr[m[i][0]-1] += m[i][2]; 
                arr[m[i][1]] -= m[i][2];
            }

            for(int i = 0; i < arr.Length - 1; i++)
            {
                arr[i+1] += arr[i];
            }

            // for(int i = 0; i < m.Length; i++)
            // {
            //     //System.Console.Write($"Row{ i }:");
            //     for(int j = 0; j < m[i].Length - 1; j++)
            //     {
            //         //System.Console.Write($"{ m[i][j] } ");
            //         //if((j != (m[i].Length - 1)) && (m[i][j] != m[i][j-1]))
            //         if(j!=0)
            //         {
            //             if(m[i][j] != m[i][j-1])
            //             {
            //                 arr[m[i][j]-1] += m[i][m[i].Length - 1];
            //             }
            //         }
            //         else{
            //             arr[m[i][j]-1] += m[i][m[i].Length - 1];
            //         }
            //     }
            //     //Console.WriteLine("");
            // }

            Array.Sort(arr);
            Array.Reverse(arr);
            System.Console.WriteLine(arr[0]);
            
        }
    }
}
