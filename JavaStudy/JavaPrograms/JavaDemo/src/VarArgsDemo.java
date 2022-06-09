class Calc
{
    public int add(int ... i) // variable length arguments, arguments will be passed as an array
    {
        int sum = 0;
        for(int s : i)
        {
            sum += s;
        }
        return sum;
    }
}

public class VarArgsDemo {

    public static void main(String args[])
    {
        Calc obj1 = new Calc();
        System.out.println(obj1.add(1,2,2,3,4,5));
    }
}
