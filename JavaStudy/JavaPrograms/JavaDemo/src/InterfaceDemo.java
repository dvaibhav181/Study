/*abstract class Writer
{
    public abstract void write();
}*/

//Types of interface
//1. Normal Interface - Can have any number of methods
//2. Single Abstract Method - Has only one method, used in lambda expressions
//3. Marker interface - has no methods, e.g. Serializable

interface Writer
{
    void write(); //all methods are public abstract, hence no need to write it.
}
class Pen implements Writer
{
    public void write()
    {
        System.out.println("I m a pen");
    }
}

class Pencil implements Writer
{
    public void write()
    {
        System.out.println("I m a pencil");
    }
}

class Kit
{
    public void doSomething(Writer p)
    {
        p.write();
    }
}

public class InterfaceDemo {
    public static void main(String args[])
    {
        Kit k = new Kit();
        Pen p = new Pen();
        Pencil pc = new Pencil();
        //Writer w = new Pen();
        Writer w = new Pencil();
        k.doSomething(w);
    }
}
