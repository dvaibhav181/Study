class A
{
    public void show()
    {
        System.out.println("in A");
    }
}

class B extends A
{
    public void show() //Method Overriding
    {
        //super.show();
        System.out.println("in B");
    }
}

class C extends A
{
    public void show() //Method Overriding
    {
        //super.show();
        System.out.println("in C");
    }
}

public class MethodOverrideDemo
{
    public static void main(String args[])
    {
        A b = new B(); //Runtime Polymorphism, reference of super class, object of subclass
        b.show(); // calling method of base class, overriding the method of base class.

        b = new C(); //Dynamic Method Dispatch,
        b.show(); // changing the object changes the calling
    }
}
