
class AnonyA
{
    public void show()
    {
        System.out.println("in AnonyA");
    }
}

interface AnonyB
{
    void show();
}
//class AnonyB extends AnonyA
//{
//    public void show() {
//        System.out.println("in AnonyB");
//    }
//}
public class AnonymousDemo {
    public static void main(String args[])
    {
        AnonyA a = new AnonyA()
                    {
                        //Anonymous class, when there is no reuse of the class
                        //can make it anonymous
                        public void show()
                        {
                            System.out.println("in AnonyB");
                        }
                    };
        a.show();

        /*AnonyB anonyB = new AnonyB() {
            @Override
            public void show() {
               System.out.println("in Interface object");
            }
        };
        anonyB.show();*/

        //Lambda expression, works only with functional interface having one method
        // () is the anonymous method name
        // -> points to the statement that needs to be executed by the method
        AnonyB anonyB = () -> System.out.println("in Interface object");
    }
}
