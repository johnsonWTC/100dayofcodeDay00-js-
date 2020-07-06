package com.Day0002;

public class STDBank {
    String name;
    private int age;
    private int bankBalance;

    public STDBank(String name) {
        this.name = name;
    }

    public void setAge(int age) {
        this.age = age;
    }

    public int getAge() {
        return age;
    }

    public int getBankBalance() {
        return bankBalance;
    }

    public void depositMoney(int funds) {
        if(bankBalance > 5000){
            System.out.println("You have too much money in your account, please open an investment account");
        }else {
            this.bankBalance = funds + this.bankBalance;
            System.out.println("your new balance is "+ this.bankBalance);
        }
    }
}
