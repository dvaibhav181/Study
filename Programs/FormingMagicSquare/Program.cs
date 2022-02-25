using System;
using System.Collections;

namespace FormingMagicSquare
{
    class Program
    {
        public static int formingMagicSquare(int[][] s) 
        {
            int cost = int.MaxValue;
        int[][] t = new int[][]
                    {
                        new int[] {4,9,2,3,5,7,8,1,6},
                        new int[] {4,3,8,9,5,1,2,7,6},
                        new int[] {2,9,4,7,5,3,6,1,8},
                        new int[] {2,7,6,9,5,1,4,3,8},
                        new int[] {8,1,6,3,5,7,4,9,2},
                        new int[] {8,3,4,1,5,9,6,7,2},
                        new int[] {6,7,2,1,5,9,8,3,4},
                        new int[] {6,1,8,7,5,3,2,9,4},
                    };
        int temp = 0;
        for(int i=0;i<8;i++){
            temp = Math.Abs(s[0][0]-t[i][0]) + Math.Abs(s[0][1]-t[i][1]) +Math.Abs(s[0][2]-t[i][2]) +Math.Abs(s[1][0]-t[i][3]) + Math.Abs(s[1][1]-t[i][4]) + Math.Abs(s[1][2]-t[i][5])+ Math.Abs(s[2][0]-t[i][6]) + Math.Abs(s[2][1]-t[i][7]) + Math.Abs(s[2][2]-t[i][8]);
            cost = temp<cost?temp:cost;
        }
        return cost;

        }
        static void Main(string[] args)
        {
            int[][] s = new int[3][]
            {
                new int[] {2,9,8},
                new int[] {4,2,7},
                new int[] {5,6,7}
            };

            string word1 = "apple";
            string word2 = "apply";

            word1.CompareTo(word2);
            int mincost = formingMagicSquare(s);
            Console.WriteLine(mincost);
        }

        
    }
}
