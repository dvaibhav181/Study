using System;
using System.Text;

namespace MaxScoreSplitString
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] chars = new int[26];
            char[] ch = new char[2];
            ch[0] = 'v';
            ch[1] = 'a';
            ch.ToString();
            StringBuilder sb = new StringBuilder();
            sb.Append(ch);
            Console.WriteLine(ch.ToString());
        foreach(char c in "ab-yz-AB-YZ")
        {
            /*if(ht.ContainsKey(c))
            {
                ht[c]++;
            }
            else
            {
                ht[c] = 1;
            }*/
            Console.WriteLine((int)c);
            //chars[c - 'a']++;
        }
        
        int min = chars[1];//for b
        min = Math.Min(min, chars[0]);//for a
        min = Math.Min(min, chars[11] / 2);// for l /2 
        min = Math.Min(min, chars[14] / 2);//similarly for o/2
        min = Math.Min(min, chars[13]);


            string s = "011101";
            int[] zeroes = new int[s.Length + 1];
            int[] ones = new int[s.Length + 1];
            for (int i = 0; i < s.Length; i++)
            {
                zeroes[i + 1] += zeroes[i];
                ones[i + 1] += ones[i];

                if (s[i] == '0')
                {
                    zeroes[i + 1]++;
                }
                else
                {
                    ones[i + 1]++;
                }
            }

            int maxScore = 0;
            for (int i = 0; i < s.Length - 1; i++)
            {
                int score = zeroes[i + 1] + ones[s.Length] - ones[i + 1];            
                maxScore = Math.Max(maxScore, score);
            }

	  System.Console.WriteLine(value: maxScore);
    }
    }
}
