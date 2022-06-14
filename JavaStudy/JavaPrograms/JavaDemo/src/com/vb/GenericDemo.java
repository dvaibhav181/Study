package com.vb;

//Collection,List,ArrayList,Set,HashSet,TreeSet,Map

import java.util.*;

class Stud implements Comparable<Stud>
{
    int rollno,marks;
    String name;

    public Stud(int rno, String name, int mks)
    {
        this.rollno = rno;
        this.name = name;
        this.marks = mks;
    }

    @Override
    public String toString() {
        return "Stud{" +
                "rollno=" + rollno +
                ", marks=" + marks +
                ", name='" + name + '\'' +
                '}';
    }

    @Override
    public int compareTo(Stud o) {
        return name.length() > o.name.length() ? 1 : -1;
    }
}

public class GenericDemo {
    public static void main(String[] args)
    {
        List<Stud> studs = new ArrayList<>();
        studs.add(new Stud(1,"Vaibhav",67));
        studs.add(new Stud(2,"Ashwini",76));
        studs.add(new Stud(3,"Maya",75));
        studs.add(new Stud(4,"Rohit",68));

        Collections.sort(studs);

        for(Stud s : studs)
        {
            System.out.println(s);
        }

        /*-------------------------------------------------
        List<Integer> c = new ArrayList<>();
        c.add(44);
        c.add(52);
        c.add(93);
        //c.add("s");

//        Comparator<Integer> comparator = (o1, o2) -> {
////                if(o1%10 > o2%10)
////                    return 1;
////                else
////                    return -1;
//                return o1%10 > o2%10 ? 1 : -1;
//        };
        //since comparator is functional interface, can convert it
        //into lambda expression
        Collections.sort(c, (o1, o2) ->  o1%10 > o2%10 ? 1 : -1 );

        System.out.println(c);*/
    }
}
