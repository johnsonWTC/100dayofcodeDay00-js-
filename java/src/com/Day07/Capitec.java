package com.Day07;

import java.util.ArrayList;

public class Capitec implements ReserveBank {
    String name;
    int age;
    ArrayList<String> names = new ArrayList<>();
    @Override
    public void createAccount(String Name, int age) {
        if(names.contains(this.name)){
            System.out.println(this.name + " Already has an account");
        }else{
            System.out.println("An account has been created for "+ this.name);
            names.add(this.name);
        }
    }

    @Override
    public void checkBalance() {

    }

    @Override
    public void depositFunds(int funds) {

    }

    @Override
    public void withDrawFunds() {

    }
}
