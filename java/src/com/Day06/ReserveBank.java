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
        }else if(age > 30){
            System.out.println("You too old for this type of account "+ this.name);
        }else{
            System.out.println("An account was created for "+ this.name);
            names.add(this.name);
        }
    }
}
