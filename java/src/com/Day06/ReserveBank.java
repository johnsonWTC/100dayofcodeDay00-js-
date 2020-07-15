package com.Day06;

import java.util.ArrayList;

public class ReserveBank {
    String name;
    int age;
    ArrayList<String> names = new ArrayList<>();
    int bankBalance = 0;


    public ReserveBank(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public void createAccount() {
        if (names.contains(this.name)) {
            System.out.println(this.name + " Already has an account with us");
        } else if (age > 30) {
            System.out.println("You too old for this type of account " + this.name);
        } else {
            System.out.println("An account was created for " + this.name);
            names.add(this.name);
        }
    }

    public void depositFunds(int funds) {
        if (!names.contains(this.name)) {
            System.out.println(this.name + " Doesnt have  an account with us");
        } else if (funds > 10000) {
            System.out.println("This amount is too much for this account");
        } else {
            bankBalance = funds + bankBalance;
            System.out.println(funds + " where deposited on your account" + " your new balance is " + this.bankBalance);
        }
    }

    public void withDrawFunds(int funds) {
        if (!names.contains(this.name)) {
            System.out.println(this.name + " Doesnt have  an account with us");
        } else if (funds > bankBalance) {
            System.out.println("insufficient funds");
        } else {
            bankBalance = bankBalance - funds;
            System.out.println(funds + " where withdrawn on your account" + " your new balance is " + this.bankBalance);
        }
    }
}
