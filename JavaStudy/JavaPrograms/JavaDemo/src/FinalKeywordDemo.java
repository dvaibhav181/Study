//variable can be final
//method can be final
//class can be final

class FinalA
{
    final int DAY; // constant, once assigned cannot be changed
    public FinalA()
    {
        DAY = 50;
        //i = 60;
    }

    public void show()
    {
        System.out.println("in Final A");
    }
}

class FinalB extends FinalA
{
    public void show()
    {
        System.out.println("in Final B");
    }
}


public class FinalKeywordDemo {
    public static void main(String args[])
    {
        FinalB finalB = new FinalB();
        finalB.show();
        //System.out.println(finalA.DAY);
    }
}
