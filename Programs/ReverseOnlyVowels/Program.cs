using System;

namespace ReverseOnlyVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = "rohit";

            if(String.IsNullOrEmpty(inputString))
            {
                System.Console.WriteLine(inputString);
                return;
            }

            int startindex = 0;
            int endindex = inputString.Length - 1;
            var vowelArray = inputString.ToCharArray();
            //looping till indexes overlap
            while(startindex < endindex)
            {
                if(!isVowel(inputString[startindex]))
                {
                    startindex++;
                    continue;
                }
                if(!isVowel(inputString[endindex]))
                {
                    endindex--;
                    continue;
                }
                char temp = vowelArray[startindex];
                vowelArray[startindex] = vowelArray[endindex];
                vowelArray[endindex] = temp;
                startindex++;
                endindex--;
            }
        }

        static bool isVowel(char input)
            {
                if(input == 'a' || input == 'A' || input == 'e' || input == 'E' ||
            input == 'i' || input == 'I' || input == 'o' || input == 'O' || input == 'u' || input == 'U' ||)
                {
                    return 1;
                }
                else{return 0;}
            }
    }
}
