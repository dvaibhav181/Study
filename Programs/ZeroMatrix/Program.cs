using System;
using System.Collections.Generic;

namespace ZeroMatrix
{
    class Program
    {
         public void SetZeroes(int[][] matrix) {
        
        int ROWS = matrix.Length;
        int COLUMNS = matrix[0].Length;
        
        bool rowZero = false;
        
        //determine which rows and columns needs to be zero
        for(int r = 0; r < matrix.Length;r++)
        {
            for(int c = 0; c < matrix[0].Length; c++)
            {
                if(matrix[r][c] == 0)
                {
                    matrix[0][c]=0;
                    if(r > 0)
                    {
                        matrix[r][0] = 0;
                    }
                    else
                    {
                        rowZero = true;
                    }
                }
            }
        }
        
        //Except first row and column mark other rows and column to 0 if found 0
        for(int r = 1; r < matrix.Length;r++)
        {
            for(int c = 1; c < matrix[0].Length; c++)
            {
                if(matrix[r][0] == 0 || matrix[0][c] == 0)
                {
                    matrix[r][c] = 0;
                }
            }
        }
        
        //Set first row to 0 if the first cell is 0
        if(matrix[0][0] == 0)
        {
            for(int r = 1; r < matrix.Length;r++)
            {
                matrix[r][0] = 0;
            }
        }
        
        //Set first column to zero if first cell is 0
        if(rowZero)
        {
            for(int c = 0; c < matrix[0].Length; c++)
            {
                matrix[0][c] = 0;
            }
        }
        
        /*for(int row = 0; row < matrix.Length;row++)
        {
            for(int column = 0; column < matrix[0].Length; column++)
            {
                if(matrix[row][column] == 0)
                {
                    matrix[row][0] = -1;
                }
            }
        }
        
        for(int column = 0; column < matrix[0].Length;column++)
        {
            for(int row = 0; row < matrix.Length; row++)
            {
                if(matrix[column][row] == 0)
                {
                    matrix[0][column] = -2;
                }
            }
        }
        
        for(int row = 0; row < matrix.Length;row++)
        {
            if(matrix[row][0] == -1)
            {
                for(int column = 0; column < matrix[0].Length; column++)
                {
                    matrix[row][column] = 0;
                }
            }
            else
            {
                 continue;
            }
            
        }
        
        for(int column = 0; column < matrix[0].Length;column++)
        {
            if(matrix[0][column] == -2)
            {
                for(int row = 0; row < matrix.Length; row++)
                {
                   matrix[row][column] = 0;
                }
            }
            else
            {
                continue;
            }
        }*/
    }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int t = rnd.Next(3);
            char D = 'C';
            D.ToString();
            var dict = new Dictionary<char,int>();
            System.Console.WriteLine($"The key is { dict.Keys.Count }");
            int a = 3;
            int b = 4;
            string[] str = new string[a + b];
            foreach (var item in dict)
            {
                
            }
            System.Console.WriteLine(base62_encode(99999999999));
            int[][] s = new int[3][]
            {
                new int[] {0,2,3},
                new int[] {4,0,6},
                new int[] {7,8,9}
            };

            var interval = new int[][]
            {
                new int[] {1,2},
                new int[] {2,3},
                new int[] {3,4},
                new int[] {1,3}
            };
            Array.Sort(interval);

            for(int r = 0; r < s.Length;r++)
            {
                for(int c = 0; c < s[0].Length; c++)
                {
                    Console.Write(s[r][c] + " ");
                }
            Console.WriteLine();
            }
            //SetZeroes(s);
        }

        private static string base62_encode(Int64 deci)
        {
            var s = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var hash_str = "";
            Random rnd = new Random(1);
            rnd.Next();
            while(deci > 0)
            {
                int index = Convert.ToInt32(deci)%62;
                hash_str = s[index] + hash_str;
                deci /= 62;
            }

            return hash_str;
        }
    }
}
