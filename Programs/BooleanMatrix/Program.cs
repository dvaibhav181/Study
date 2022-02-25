using System;

namespace BooleanMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] m = new int[4][]{
                new int[3]{1,0,0},
                new int[3]{1,0,0},
                new int[3]{1,0,0},
                new int[3]{0,0,0},
                //  new int[3]{1,2,100},
                //  new int[3]{2,5,100},
                //  new int[3]{3,4,100}
            };

            int[] row = new int[m.Length];
            int[] column = new int[m[0].Length];

            for(int i = 0;i < m.Length; i++)
            {
                row[i] = 0;
            }

            for(int i = 0;i < m[0].Length; i++)
            {
                column[i] = 0;
            }

            for(int i = 0; i < m.Length; i++)
            {
                for(int j = 0; j < m[i].Length; j++)
                {
                    if(m[i][j] == 1)
                    {
                        row[i] = 1;
                        column[j] = 1;
                    }
                }
            }

            for(int i = 0; i < m.Length; i++)
            {
                for(int j = 0; j < m[i].Length; j++)
                {
                    if(row[i] == 1 || column[j] == 1)
                    {
                        m[i][j] = 1;
                    }
                }
            }

            for(int i = 0; i < m.Length; i++)
            {
                for(int j = 0; j < m[i].Length; j++)
                {
                    System.Console.WriteLine($"{m[i][j]}");
                }
                System.Console.WriteLine();
            }

        }
    }
}
