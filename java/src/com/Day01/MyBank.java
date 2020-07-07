package com.Day01;

public class MyBank {

    String name;
    int age;
    int bankBalance = 0;
    String accountType;


    public MyBank(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public void checkBalance(){
        System.out.println(bankBalance + " Your current balance");
    }

    public void depositFunds(int funds){
        if(funds > 10000){
            System.out.println("This amount is too large to deposit");
        }
    }
}
