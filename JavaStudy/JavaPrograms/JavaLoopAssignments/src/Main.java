public class Main {
    public static void main(String[] args) {
        int num = 6;
//        for(int i = 1; i <= num; i++)
//        {
//            for(int j = 1; j <= i; j++)
//            {
//                System.out.print(j + " ");
//            }
//            System.out.println();
//        }

        char toChar = 'D';
//        for (int i = (int)'A'; i <= (int)toChar; i++)
//        {
//            for(int j = (int)'A'; j <= i; j++)
//            {
//                System.out.print((char)j);
//            }
//            System.out.println();
//        }
//        for (int i = (int)toChar; i >= (int)'A'; i--)
//        {
//            for(int j = (int)'A'; j < i ; j++)
//            {
//                System.out.print((char)j);
//            }
//            System.out.println();
//        }

//        * * * *   00 01 02 03
//        *     *   10 11 12 13
//        *     *   20 21 22 23
//        * * * *   30 31 32 33
        int numOfStars = 5;
        for(int i = 0; i < numOfStars; i++)
        {
            for(int j = 0; j < numOfStars; j++)
            {
                if(i == 0 || j == 0 || i == numOfStars - 1 || j == numOfStars - 1)
                {
                        System.out.print("* ");
                }
                else
                {
                    System.out.print("  ");
                }
            }
            System.out.println();
        }
    }
}