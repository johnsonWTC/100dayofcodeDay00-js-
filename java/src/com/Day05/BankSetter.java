package com.Day05;

import java.util.ArrayList;

public class BankSetter {
    String name;
    int age;
    ArrayList<String> bankAccounts = new ArrayList<>();

    public void createdAccount(){
        if(bankAccounts.contains(this.name)){
            System.out.println(this.name + " already has an account with us");
        }
        else if(this.age > 40){
            System.out.println("dude you are too old for this");
        }else{
            bankAccounts.add(this.name);
            System.out.println("Account created for "+ this.name);
        }

    }
    void depositFunds(int funds){

    }
    void withDrawFunds(int funds){

    }
    void checkBalance(){

    }
}
