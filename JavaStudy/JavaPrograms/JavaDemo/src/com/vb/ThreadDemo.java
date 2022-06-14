package com.vb;

public class ThreadDemo {
    public static void main(String[] args) throws InterruptedException {
        Thread t1 = new Thread(() -> {
                for(int i = 1;i <= 5;i++) {
                    System.out.println("Hi");
                    try {
                        Thread.sleep(500);
                    } catch (InterruptedException e) {
                        throw new RuntimeException(e);
                    }
                }
        });
        Thread t2 = //Since Runnable is a functional interface
                    // lambda expression can be used
                      // new Runnable() { public void run
            new Thread(() ->
            {
                for(int i = 1;i <= 5;i++) {
                    System.out.println("Hello");
                    try {
                        Thread.sleep(500);
                    } catch (InterruptedException e) {
                        throw new RuntimeException(e);
                    }
                }
        });

        t1.start();
        Thread.sleep(10);
        t2.start();

        t1.join();

        System.out.println("Bye");
        //obj1.show();
        //obj2.show();
    }
}
