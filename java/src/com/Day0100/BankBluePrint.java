package com.Day0100;

import java.util.ArrayList;

public class BankBluePrint {
    String name;
    int age;
    int bankBalance = 0;
    ArrayList bankAccount = new ArrayList();

    public BankBluePrint(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public  void createAccount (){
        if(bankAccount.contains(this.name)){
            System.out.println(this.name + " already has an account with use");
        }else{
            bankAccount.add(this.name);
            System.out.println("Account created for " + this.name);
        }

    }

    public void depositFunds(int funds){
        if(!bankAccount.contains(this.name)){
            System.out.println(this.name + " does not have an account with us");
        }else if(funds > 10000){
            System.out.println("The maximum amount that can be deposited is 10000");
        }else{
            this.bankBalance = this.bankBalance + funds;
        }
    }
}
