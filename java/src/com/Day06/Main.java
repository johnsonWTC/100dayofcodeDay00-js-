package com.Day06;

public class Main {

    public static void main(String[] args) {
        ReserveBank johnson = new ReserveBank("johnson", 29);
        johnson.depositFunds(70);
        johnson.createAccount();
        johnson.depositFunds(5000);
        johnson.withDrawFunds(600);
    }


}
