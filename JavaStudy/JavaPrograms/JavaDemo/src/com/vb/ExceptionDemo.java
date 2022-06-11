package com.vb;

public class ExceptionDemo {
    public static void main (String[] args)
    {
        int i = 8;
        int j = 19;
        int a[] = new int[3];
        try
        {
            //a[3] = 3;
            int k = i / j;
            if (k == 0)
                throw new VBException("something wrong");
        }
        catch(VBException e)
        {
            System.out.println(e.getMessage());
        }
        finally {
            System.out.println("Got exception");
        }

    }
}
