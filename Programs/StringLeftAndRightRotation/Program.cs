using System;

namespace StringLeftAndRightRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Vaibhav";
            int rotateby = 2;
            string leftrotate = s1.Substring(rotateby,s1.Length - rotateby) + s1.Substring(0,rotateby);
            string rightrotate = s1.Substring(s1.Length - rotateby, rotateby) + s1.Substring(0, s1.Length - rotateby);
            Console.WriteLine(leftrotate);
            Console.WriteLine(rightrotate);
        }
    }
}
