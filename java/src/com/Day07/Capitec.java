package com.Day07;

import java.util.ArrayList;

public class Capitec implements ReserveBank {
    String name;
    int age;
    int balance = 0;

    public Capitec(String name, int age) {
        this.name = name;
        this.age = age;
    }

    ArrayList<String> names = new ArrayList<>();
    @Override
    public void createAccount(String Name, int age) {
        if(names.contains(this.name)){
            System.out.println(this.name + " Already has an account");
        }else{
            System.out.println("An account has been created for "+ this.name);
            names.add(this.name);
        }
    }

    @Override
    public void checkBalance() {
        if(!names.contains(this.name)){
            System.out.println(this.name +" does not have an account with us");
        }else if(age > 30){
            System.out.println("You are too old for a student account");
        }
        else{
            System.out.println("Hello " +this.name + " your new balance is "+ this.balance);
        }
    }

    @Override
    public void depositFunds(int funds) {
        if(!names.contains(this.name)){
            System.out.println(this.name +" does not have an account with us");
        }else if(funds > 10000){
            System.out.println("The maximum deposit limit 10000 for a student account");
        }
        else{
            System.out.println(funds + " was deposited into your account, your new balance is " +this.balance);
        }
    }

    @Override
    public void withDrawFunds(int funds) {
        if(!names.contains(this.name)){
            System.out.println(this.name +" does not have an account with us");
        }else if(funds > 10000){
            System.out.println("The maximum deposit limit 10000 for a student account");
        }
        else{
            System.out.println(funds + " was deposited into your account, your new balance is " +this.balance);
        }

    }
}
