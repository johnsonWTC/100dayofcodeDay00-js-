package com.Day05;

public class Main {

    public static void main(String[] args) {
        NedBank johnson = new NedBank("johnson", 30, true);
        johnson.checkBalances();
        johnson.createdAccount();
        johnson.depositFunds(1500);
        johnson.checkBalances();
        johnson.withDrawFunds(1000);
    }
}
