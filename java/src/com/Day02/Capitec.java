package com.Day02;

import java.util.ArrayList;

public class Capitec implements IBank {

    int age;
    String name;
    ArrayList<String> accounts = new ArrayList<>();
    int bankBalance = 0;

    public Capitec(int age, String name) {
        this.age = age;
        this.name = name;
    }

    @Override
    public void createAccount() {
        if(accounts.contains(this.name)){
            System.out.println(this.name + " already has an account with us");
        }else if (age > 40){
            System.out.println(" please try Nedbank");
        }
        else{
            accounts.add(this.name);
            System.out.println("Account for "+ this.name + " has been created" );
        }
    }

    @Override
    public void depositFunds(int fund) {
        if(!accounts.contains(this.name)){
            System.out.println(this.name + " Does not have an account with us");
        }
        else if(fund > 10000){
            System.out.println("that's to much for a saving account");
        }
        else{
            bankBalance = bankBalance + fund;
            System.out.println(bankBalance + " was deposited, your new balance is " + bankBalance);
        }

    }

    @Override
    public void withdrawFund(int fund) {
        if(!accounts.contains(this.name)){
            System.out.println(this.name + " Does not have an account with us");
        }
        else if(fund > bankBalance){
            System.out.println("insufficient funds");
        }else{
            bankBalance = bankBalance - fund;
            System.out.println(bankBalance + " was withdrawn, your balance is now " + bankBalance);
        }

    }
}
