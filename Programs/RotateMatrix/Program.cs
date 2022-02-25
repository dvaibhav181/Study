using System;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //rows can have different columns, jagged array
            int[][] s = new int[3][]
            {
                new int[] {1,2,3,4},
                new int[] {4,5,6,7},
                new int[] {8,9,10,11}
            };

            //all rows should have same columns
            int[,] twoD = {
                            {1,2,3,5},
                            {5,6,9,4},
                            {3,5,7,0}
                         };

            twoD.GetLength(0);
            twoD.GetLength(1);

            /*
            int 
            */
            Console.WriteLine(rotate(s));
        }

        public static bool rotate(int[][] matrix) 
        { 
            // if (matrix.Length== 0 || matrix.Length != matrix[0].Length) return false; 
            // int n = matrix.Length; 
            // for (int layer = 0; layer < n / 2; layer++) 
            // { 
            //     int first = layer; 
            //     int last = n - 1 - layer; 
            //     for(int i = first; i < last; i++) 
            //     { 
            //         int offset = i - first;
            //         int top= matrix[first][i]; // save top 
            //         //left -> top 
            //         matrix[first][i] = matrix[last-offset][first]; 
            //         // bottom -> left 
            //         matrix[last-offset][first] = matrix[last][last - offset];
            //         // right -> bottom 
            //         matrix[last][last - offset] = matrix[i][last]; ;
            //         // top -> right 
            //         matrix[i][last] = top; // right<- saved top 
                    
            //     }
            // }

        if (matrix.Length != 0 && matrix.Length == matrix[0].Length)
       {
            int left = 0;
            int right = matrix.Length - 1;
               
            while (left < right)
            {
                for(int index = 0; index < matrix.Length - 1; index++)
                {
                    int top = left;
                    int bottom = right;
                    //Save top
                    int topLeft = matrix[top][left + index];
                
                    //swap bottom-left -> top-left
                    matrix[top][left + index] = matrix[bottom - index][left];
                
                
                    //swap bottom-right -> bottom-left
                    matrix[bottom - index][left] = matrix[bottom][right - index];
                
                
                    //swap bottom-right -> top-right
                    matrix[bottom][right - index] = matrix[top + index][right];
                    
                    //swap top-left -> top->right
                    matrix[top + index][right] = topLeft;
                }
                right--;
                left++;
            }
       }
            return true;
        }
    }
}
