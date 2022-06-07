package org.example;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

@Component //default bean name will be class name which be decapitalized
public class Car implements Vehicle{
    @Autowired
    private Tyre tyre;

    public Tyre getTyre() {
        return tyre;
    }

    public void setTyre(Tyre tyre) {
        this.tyre = tyre;
    }

    public void drive()
    {
        System.out.println("Car is running " + tyre);
    }
}
