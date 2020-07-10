package com.Day04;

public class Main {

    public static void main(String[] args) {
        IBank fnb = new FNB("johnson", 30);
        fnb.createAccount();
        fnb.depositFunds(3000);
        fnb.withDrawFunds(400);
        fnb.createAccount();
    }
}
