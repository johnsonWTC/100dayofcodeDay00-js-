package com.Day01;

import java.util.ArrayList;

public class MyBank {

    String name;
    int age;
    int bankBalance = 0;
    String accountType;
    ArrayList names = new ArrayList();


    public MyBank(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public void checkBalance() {
        if (!names.contains(this.name)) {
            System.out.println(this.name + " does not have an account with us");
            return;
        }
        System.out.println(bankBalance + " Your current balance");
    }

    public void depositFunds(int funds) {
        if (!names.contains(this.name)) {
            System.out.println(this.name + " does not have an account with us");
            return;
        }
        if (funds > 10000) {
            System.out.println("This amount is too large to deposit");
        } else {
            bankBalance = bankBalance + funds;
            System.out.println(funds + " was deposited into your bank account");
        }
    }

    public void withDrawFunds(int funds) {
        if (!names.contains(this.name)) {
            System.out.println(this.name + " does not have an account with us");
            return;
        }
        if (funds > bankBalance) {
            System.out.println("inefficient funds");
        } else {
            bankBalance = bankBalance - funds;
            System.out.println(funds + " was withdrawn, your new balance is " + bankBalance);
        }
    }

    public void createAccount() {
        if (this.age > 65) {
            System.out.println(this.name + " Sorry we can not open an account for you");
        } else if (names.contains(this.name)) {
            System.out.println(this.name + " Is already has an account");
        } else {
            names.add(this.name);
            System.out.println("Account was created for " + this.name);
        }
    }

}
