package com.Day05;

import java.util.ArrayList;

public class BankSetter {
    String name;
    int age;
    int bankBalance = 0;
    ArrayList<String> bankAccounts = new ArrayList<>();

    public void createdAccount() {
        if (bankAccounts.contains(this.name)) {
            System.out.println(this.name + " already has an account with us");
        } else if (this.age > 40) {
            System.out.println("dude you are too old for this");
        } else {
            bankAccounts.add(this.name);
            System.out.println("Account created for " + this.name);
        }

    }

    void depositFunds(int funds) {
        if (!bankAccounts.contains(this.name)) {
            System.out.println(this.name + " doesnt have an account with us");
        } else if (funds > 10000) {
            System.out.println("Your account cannot hold this much money");
        } else {
            bankBalance = bankBalance + funds;
            System.out.println(this.bankBalance + " was deposited, your new balance is " + this.bankBalance);
        }
    }

    void withDrawFunds(int funds) {
        if (!bankAccounts.contains(this.name)) {
            System.out.println(this.name + " doesnt have an account with us");
        } else if (funds > bankBalance) {
            System.out.println("Insufficient funds");
        } else {
            bankBalance = bankBalance - funds;
            System.out.println(this.bankBalance + " was withdrawn, your new balance is " + this.bankBalance);
        }
    }
       void checkBalances(){
            if (!bankAccounts.contains(this.name)) {
                System.out.println(this.name + " doesnt have an account with us");
            }
        }
    }
