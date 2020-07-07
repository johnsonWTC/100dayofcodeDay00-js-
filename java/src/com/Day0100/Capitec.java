package com.Day0100;

public class Capitec extends BankBluePrint {
    boolean mobileBank;

    public Capitec(String name, int age, boolean mobileBank) {
        super(name, age);
        this.mobileBank = mobileBank;
    }

    @Override
    public void createAccount() {
        super.createAccount();
    }

    @Override
    public void depositFunds(int funds) {
        super.depositFunds(funds);
    }

    @Override
    public void withdrawFunds(int funds) {
        super.withdrawFunds(funds);
    }
}
