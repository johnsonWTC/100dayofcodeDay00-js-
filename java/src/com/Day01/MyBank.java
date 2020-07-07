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
        }else {
            bankBalance = bankBalance + funds;
            System.out.println(funds + " was deposited into your bank account");
        }
    }

    public  void withDrawFunds(int funds){
        if (funds > bankBalance){
            System.out.println("inefficient funds");
        }else{
            bankBalance = bankBalance - funds;
            System.out.println(bankBalance + " was withdrawn, your new balance is " + bankBalance);
        }
    }

    public void createAccount{
        if(this.age > 65){
            System.out.println(this.name + " Sorry we can not open an account for you");
        }
    }
}
