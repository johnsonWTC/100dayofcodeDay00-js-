package com.javaday00.Day0002;

import java.util.ArrayList;

public class STDBank {
    String name;
    private int age;
    private int bankBalance = 0;
    private ArrayList bankAccounts = new ArrayList();

    public STDBank(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public void openAccount() {
        if (age > 70) {
            System.out.println("you are too old to open a bank account");
        } else if (age < 18) {
            System.out.println(" you are too young to open a bank account");
        } else {
            if (bankAccounts.contains(name)) {
                System.out.println(" already has an account");
            } else {
                bankAccounts.add(name);
                System.out.println(name + " now has an account");
            }

        }
    }

    public void checkBalance() {
        System.out.println("your current balance is " + this.bankBalance);
    }

    public void depositMoney(int funds) {
        if (bankAccounts.contains(this.name)) {
            if (funds > 50000) {
                System.out.println("this amount is too much for this account, please open an investment account");
                return;
            } else {
                this.bankBalance = funds + this.bankBalance;
                System.out.println(funds + " was deposited, your new balance is " + this.bankBalance);
            }
        } else {
            System.out.println(this.name + " does not have an acount with us");
        }
    }

    public void withDrawMoney(int funds) {
        if (this.bankBalance < funds) {
            System.out.println("insufficient funds on the account");
        } else {
            this.bankBalance = this.bankBalance - funds;
            System.out.println(funds + " was withdrawn, your new balance is " + bankBalance);
        }
    }
}
