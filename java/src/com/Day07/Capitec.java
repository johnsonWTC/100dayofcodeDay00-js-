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
