using System;

namespace HourglassSum
{
    class Program
    {

        public void hourglassSum()
        {
                int[][] arr = new int[6][]{
                new int[] {1, 1, 1, 0, 0, 0},
                new int[] {0, 1, 0, 0, 0, 0},
                new int[] {1, 1, 1, 0, 0, 0},
                new int[] {0, 0, 2, 4, 4, 0},
                new int[] {0, 0, 0, 2, 0, 0},
                new int[] {0, 0, 1, 2, 4, 0}
                };            
                
                //var max = -63;
                for(int i = 0; i < 6; i++)
                {
                    for(int j = 0; j < 6; j++)
                    {
                        Console.Write($"{ arr[i][j] } ");
                    }
                    Console.WriteLine();
                }
            
                //int[] hourglass = new int[2];
                int max = -63;
                int sum = 0;
        
                for(int i = 0; i < 4; i++)
                {
                    for(int j = 0; j < 4; j++)
                    {
                        sum = arr[i][j] + arr[i][j+1] + arr[i][j+2] + arr[i+1][j+1] + arr[i+2][j] + arr[i+2][j+1] + arr[i+2][j+2];

                        if (max < sum )
                        {
                            max = sum;
                        }
                    }
                }

                System.Console.WriteLine(max);
        }

        public void LeftShift()
        {
            int[] a = new int[5] {1,2,3,4,5};
            int[] b = new int[5];
            int rot = 4;
            int len = a.Length;

            for(int i = 0; i < len; i++)
            {
                b[i] = a[(i+rot)%len];
            }     

            for(int i = 0; i <= len; i++)
            {
                System.Console.WriteLine(a[i]);
            }   
        }

        public void RightShift()
        {
            int[] a = new int[5] {1,2,3,4,5};
            int[] b = new int[5];
            int rot = 5;
            int len = a.Length;

            for(int i = 0; i < len; i++)
            {
                b[i] = a[(i+rot+1)%len];
            }     

            for(int i = 0; i < len; i++)
            {
                System.Console.WriteLine(b[i]);
            }   
        }
        
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
        }
    }
}
