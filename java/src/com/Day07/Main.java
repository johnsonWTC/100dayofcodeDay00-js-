package com.Day07;

public class Main {
    public static void main(String[] args) {
        ReserveBank johnson = new Capitec("johnson", 30);
        johnson.checkBalance();
        johnson.createAccount();
        johnson.depositFunds(6000);
        johnson.checkBalance();
        johnson.withDrawFunds(5000);
    }
}
