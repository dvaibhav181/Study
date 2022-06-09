class Outer
{
    public void display()
    {
        System.out.println("In Outer Class");
    }

    static class Inner
    {
        public void display()
        {
            System.out.println("In Inner Class");
        }
    }

}


public class InnerDemo {
    public static void main(String[] args) {
        Outer obj = new Outer();
        obj.display();

        Outer.Inner inner = new Outer.Inner();
        inner.display();
    }
}
