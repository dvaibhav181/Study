import java.awt.desktop.ScreenSleepEvent;

public class ArrayDemo {
    public static void main(String args[])
    {
        int[] a = {1,2,3,4};
        int[] b = {3,4,5,6};
        int[] c = {5,3,6,8};

        //int[][] d = {a,b,c}; 2D array
        int[][] d = {
                {1,2,3,4,7,5},
                {3,4,5,6,9},
                {5,3,6,6}
        }; // Jagged array

//        for(int i = 0; i < d.length; i++)
//        {
//            for(int j = 0; j < d[i].length; j++)
//            {
//                System.out.print(d[i][j]);
//            }
//            System.out.println();
//        }

        //Enhanced For Loop
        for(int[] k : d)
        {
            for(int l : k)
            {
                System.out.print(l);
            }
            System.out.println();
        }
    }
}
