using System;
using System.Text;

namespace ReverseOnlyLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            /*
            "ab-cd"
            "a-bC-dEf-ghIj"
            "Test1ng-Leet=code-Q!"
            */
            string S = "a-bC-dEf-ghIj";
        int j = S.Length - 1;
        char temp = ' ';
        char[] chararray = new char[S.Length];
        StringBuilder sb = new StringBuilder();
        foreach(char c in S)
        {
            chararray[i] = c;
            i++;
        }
        i = 0;
        while (i < j)
        {
            if(((int)chararray[i] < 65 || (int)chararray[i] > 122) ||
                ((int)chararray[i] > 90 || (int)chararray[i] < 97))
            {
                i++;
                continue;
            }
            else if(((int)chararray[j] < 65 && (int)chararray[j] > 90) ||
                ((int)chararray[j] < 97 && (int)chararray[j] > 122))
            {
                j--;
                continue;
            }
            else
            {
                temp = chararray[i];
                chararray[i] = chararray[j];
                chararray[j] = temp;
                i++;
                j--;
            }
        }
        sb.Append(chararray);
        Console.WriteLine(sb.ToString());
        }
    }
}
