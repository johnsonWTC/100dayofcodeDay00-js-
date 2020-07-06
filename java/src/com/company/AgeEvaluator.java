package com.company;

public class AgeEvaluator {

    int age;
    String name;

    public AgeEvaluator(int age, String name) {
        this.age = age;
        this.name = name;
    }

    public void nameEvaluator() {
        if (age > 21) {
            System.out.println("umdala " + name);
        } else {
            System.out.println("no you are ok " + name);
        }
    }
}
