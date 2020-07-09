package com.Day03;

import java.util.ArrayList;

public class Capitec implements IBank {

    int age;
    String name;
    int accountBalance;
    ArrayList<String> Accounts = new ArrayList();

    @Override
    public void createAccount(String name, int age) {
        if(Accounts.contains(this.name)){
            System.out.println(this.name+ " Already has an account");
        }else if(this.age > 45){
            System.out.println("You are too old this");
        }else{
            Accounts.add(this.name);
            System.out.println("Account has been created for "+ this.name);
        }
    }

    @Override
    public void checkBalance() {
        if(!Accounts.contains(this.name)){
            System.out.println(this.name+ " doesnt have an account with us");
        }else{
            System.out.println("Hello "+this.name+" your balance is "+ accountBalance);
        }
    }

    @Override
    public void depositFunds(int funds) {
        if(!Accounts.contains(this.name)){
            System.out.println(this.name+ " doesnt have an account with us");
        }
    }

    @Override
    public void withDrawFunds(int funds) {

    }
}
