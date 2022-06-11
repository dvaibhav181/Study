//Abstract class is used so that the class cannot be instantiated
//Abstract class can have abstract(no definition) as well as normal methods
/*abstract class Human
{
    public abstract void eat();
    public abstract void walk();
}
class Man extends Human
{
    @Override
    public void eat() {

    }

    @Override
    public void walk() {

    }
}
class Woman extends Human
{

    @Override
    public void eat() {

    }

    @Override
    public void walk() {

    }
}*/


class Printer
{
    public void show(Number i)
    {
        System.out.println(i);
    }
    // Both Integer and Double extend from Number, hence can create method accepting Number
    // Also Number is abstract class os can be instantiated

    /*public void show(Integer i)
    {
        System.out.println(i);
    }

    public void show(Double i)
    {
        System.out.println(i);
    }*/
}

public class AbstractDemo {
    public static void main(String args[])
    {
        //Human h = new Man();
        //h.eat();

        Printer p = new Printer();
        p.show(5.5f);
    }
}
