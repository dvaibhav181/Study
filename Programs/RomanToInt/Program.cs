using System;

namespace RomanToInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "MCMXCIV";
            int output = RomanToInt(s);
            System.Console.WriteLine(output);
        }

        private static int RomanToInt(string s)
        {   
            int at = 0;
            char next = ' ';
            int start = 0;
            int output = 0;
            foreach(char c in s)
            {
                switch(c)
                {
                    case 'I':
                        at = s.IndexOf(c,start);
                        if(at != -1 && (at + 1) != s.Length)
                        {
                            next = s[at + 1];
                            if(next == 'V' || next == 'X')
                            {
                                output--;
                            }
                            else
                            {
                                output++;
                            }
                        }
                        else
                        {
                            output++;
                        }
                        
                        break;
                        
                    case 'V':
                        output = output + 5;
                        break;
                        
                    case 'X':
                        at = s.IndexOf(c,start);
                        if(at != -1 && (at + 1) != s.Length)
                        {
                            next = s[at + 1];
                            if(next == 'L' || next == 'C')
                            {
                                output = output - 10;
                            }
                            else
                            {
                                output = output + 10;
                            }
                        }
                        else
                        {
                        output = output + 10; 
                        }
                        
                        break;
                        
                    case 'L':
                        output = output + 50;
                        break;
                        
                    case 'C':
                        at = s.IndexOf(c,start);
                        if(at != -1 && (at + 1) != s.Length)
                        {
                            next = s[at + 1];
                            if(next == 'D' || next == 'M')
                            {
                                output = output - 100;
                            }
                            else
                            {
                                output = output + 100;
                            }
                        }
                        else
                        {
                            output = output + 100;
                        }
                        
                        break;
                        
                    case 'D':
                        output = output + 500;
                        break;
                        
                    case 'M':
                        output = output + 1000;
                        break;
                }
                start++;
            }
            return output;
        }
    }
}