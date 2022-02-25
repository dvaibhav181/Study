using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'findSmallestDivisor' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. STRING t
     */

    public static int findSmallestDivisor(string s, string t)
    {
        if(string.IsNullOrEmpty(s) || string.IsNullOrEmpty(t))
        {
            return -1;
        }
        
        int slen = s.Length;
        int tlen = t.Length;
        int div = 0;
        StringBuilder sb = new StringBuilder();
        StringBuilder newsb = new StringBuilder();
        
        if(slen%tlen != 0)
        {
            return -1;
        }
        else
        {
            div = slen/tlen;
            for(int i = 0; i < div; i++)
            {
                sb.Append(t);
            }
            
            if(sb.Equals(s))
            {
                for(int j = 0; j < s.Length/2; j++)
                {
                    newsb.Append(s[j]);
                    string clearString = s.Replace(newsb.ToString(),"");
                
                    if(clearString.Length == 0)
                    {
                        var count = Regex.Matches(s,newsb.ToString()).Count; 
                        return s.Length/count;  
                    }

                }
                return -1;
            }
            else
            {
                return -1;
            }
        }
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = "lrbb";

        string t = "lrbb";

        int result = Result.findSmallestDivisor(s, t);
        System.Console.WriteLine(result);
        // textWriter.WriteLine(result);

        // textWriter.Flush();
        // textWriter.Close();
    }
}
