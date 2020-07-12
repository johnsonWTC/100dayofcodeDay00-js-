package com.Day06;

import java.util.ArrayList;

public class ReserveBank {
    String name;
    int age;
    ArrayList<String> names = new ArrayList<>();


    public ReserveBank(String name, int age) {
        this.name = name;
        this.age = age;
    }

    public void createAccount(){
        if(names.contains(this.name)){
            System.out.println(this.name + " Already has an account with us");
        }
    }
}
