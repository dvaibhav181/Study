using System;

namespace FlippingAnImage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[][] s = new int[3][]
            {
                new int[] {1,1,0},
                new int[] {1,0,1},
                new int[] {0,0,0}
            };

            int[][] n = FlipAndInvertImage(s);
            for(int i = 0; i < n.Length; i++)
            {
                for(int j = 0; j < n[i].Length; j++)
                {
                    System.Console.Write(n[i][j]);
                }
                System.Console.WriteLine();
            }
        }

        private static int[][] FlipAndInvertImage(int[][] s)
        {
            for(int i = 0; i < s.Length; i++)
            {
                Array.Reverse(s[i]);

                for(int j = 0; j < s[i].Length; j++)
                {
                    s[i][j] ^= 1;
                }
            }
            return s;
        }
    }
}
