using System;

namespace RumbleInTokyo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMinimumBlows(new int[] {1,2,3,4,3,2,3,2,1}));
        }

        private static int GetMinimumBlows(int[] vs)
        {
            int finalMinBlows = 0;

            //traverse left creature with 2 pointers
            int lp = 0;

            for(int rp = 1; rp < vs.Length; rp++)
            {
                if(vs[rp] < vs[rp-1])
                {
                    while(lp != rp - 1)
                    {
                        vs[lp] = 0;
                        lp++;
                    }
                    finalMinBlows++;
                    lp = rp + 1;
                    if(rp + 1 < vs.Length - 1)
                    {
                        rp = lp + 1;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            foreach(var item in vs)
            {
                Console.WriteLine(item);
            }

            return finalMinBlows;
        }
    }
}