using System;
using System.Collections.Generic;

namespace SpiralMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] inputMatrix = new int[4][]{
                new int[4]{1,2,3,4},
                new int[4]{5,6,7,8},
                new int[4]{9,10,11,12},
                new int[4]{13,14,15,16},
            };

            PrintSpiral(inputMatrix);
        }

        private static void PrintSpiral(int[][] matrix)
        {
            // int rowLength = inputMatrix.Length;
            // int colLength = inputMatrix[0].Length;

            // int[] output = new int[rowLength*colLength];
            // int left = 0;
            // int right = colLength;
            // int top = 0;
            // int bottom = rowLength;
            // int index = 0;

            // while(left < right && top < bottom)
            // {
            //     //get every i from top row
            //     for(int i = left; i < right;i++)
            //     {
            //         output[++index] = inputMatrix[top][i];
            //     }
            //     top++;

            //     //get every i from last column
            //     for(int i = top; i < bottom;i++)
            //     {
            //         output[++index] = inputMatrix[i][right - 1];
            //     }
            //     right--;

            //     //get every i from last row
            //     for(int i = right - 1; i >= left;i--)
            //     {
            //         output[++index] = inputMatrix[bottom - 1][i];
            //     }
            //     bottom--;

            //     //get every i from first column
            //     for(int i = bottom - 1; i >= top;i--)
            //     {
            //         output[++index] = inputMatrix[i][left];
            //     }
            //     left++;

            // }

            var result = new List<int>();
        
        int l = 0; //left pointer
        int r = matrix[0].Length; // right pointer
        
        int t = 0; // top pointer
        int b = matrix.Length; // bottom pointer
        
        while(l < r && t < b)
        {   
            //go right
            for(int i = l; i < r; i++)
            {
                result.Add(matrix[t][i]);                
            }
            t++;
            
            //go down
            for(int i = t; i < b; i++)
            {
                result.Add(matrix[i][r-1]);
            }
            r--;
            
            if(l == r-1 && t == b)
            {
                break;
            }
            
            //go left
            for(int i = r-1; i >= l; i--)
            {
                result.Add(matrix[b-1][i]);
            }
            b--;
            
            //go up
            for(int i = b-1; i >= t; i--)
            {
                result.Add(matrix[i][l]);
            }
            l++;
            
        }

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

        }
    }
}
