using System;
using System.Linq;

namespace CountNegativeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // int[][] s = new int[4][]
            // {
            //     new int[] {4,3,2,-1},
            //     new int[] {3,2,1,-1},
            //     new int[] {1,1,-1,-2},
            //     new int[] {-1,-1,-2,-3}
            // };

            int[][] s = new int[2][]
            {
                new int[] {3,2},
                new int[] {1,0}
            };

            int n = CountNegatives(s);
            System.Console.WriteLine(n);
        }

        private static int CountNegatives(int[][] grid) {
        if(grid == null || grid.Length == 0)
        {
            return -1;
        }
        int result = 0;
        result += grid.Sum(r => r.Count(i => i < 0));
        // for(int i = 0; i < grid.Length; i++)
        // {
        //     if(grid[i][0] < 0)
        //     {
        //         result += grid[i].Length;
        //     }
        //     else
        //     {
        //         int start = 0;
        //         int end = grid[i].Length - 1;
        //         while (start < end)
        //         {
        //             int mid = start + (end - start) / 2;
        //             if(grid[i][mid] >= 0)
        //             {
        //                 start = mid + 1;
        //             }
        //             else
        //             {
        //               end = mid;
        //             }
                    
        //         }
        //         result += grid[i].Length - start;
        //     }
        // }
        
        return result;
    }
    }
}
