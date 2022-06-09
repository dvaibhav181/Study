class Calci
{
    Calci()
    {
        System.out.println("In Calci");
    }

    Calci(int i)
    {
        System.out.println("In Calci int");
    }
    public int add(int i, int j)
    {
        return i + j;
    }
}

class AdvCalci extends Calci //Multilevel Inheritance, no multiple inheritance
{
    AdvCalci()
    {
        //super(); // calls the default constructor of super class
        super(5); // calls the parameterized constructor of super class
        System.out.println("In AdvCalci");
    }
    public int sub(int i, int j)
    {
        return i - j;
    }
}

class VeryAdvCalci extends AdvCalci
{
    public int mult(int i, int j)
    {
        return i * j;
    }
}

public class InheritanceDemo {
    public static void main(String args[])
    {
//        Calci c = new Calci();
//        System.out.println(c.add(5,4));
//
        AdvCalci ac = new AdvCalci();
        System.out.println(ac.add(9,3));
        System.out.println(ac.sub(9,3));

//        VeryAdvCalci vac = new VeryAdvCalci();
//        System.out.println(vac.mult(6,4));
//        System.out.println(vac.sub(6,4));
//        System.out.println(vac.add(6,4));
    }
}
