package com.Day04;

import java.util.ArrayList;

public class FNB implements IBank {
    String name;
    int age;
    ArrayList<String> names = new ArrayList<>();
    int bankBalance = 0;

    public FNB(String name, int age) {
        this.name = name;
        this.age = age;
    }

    @Override
    public void createAccount(String name, int age) {
        if(names.contains(this.name)){
            System.out.println(this.name + " already on the list");
        }else if(this.age > 40){
            System.out.println(this.name+ " you are too old for this");
        }
        else{
            names.add((this.name));
            System.out.println("account created for"+ this.name);
        }
    }

    @Override
    public void depositFunds(int funds) {
        if(!names.contains(this.name)){
            System.out.println(this.name + " does not have an account with us");
        }
    }

    @Override
    public void withDrawFunds(int funds) {
        if(!names.contains(this.name)){
            System.out.println(this.name + " does not have an account with us");
        }else if()
    }
}
