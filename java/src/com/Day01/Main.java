package com.Day01;

public class Main {
    public static void main(String[] args) {
        MyBank johnson = new MyBank("johnson",65);
        johnson.checkBalance();
//        johnson.depositFunds(400);
//        johnson.withDrawFunds(400);
       johnson.createAccount();
//        johnson.withDrawFunds(700);
//        johnson.depositFunds(1000);
//        johnson.withDrawFunds(300);
        johnson.checkBalance();
        johnson.depositFunds(300);
        johnson.checkBalance();
        johnson.withDrawFunds(100);
        MyBank malebo = new MyBank("malebo",27);
        malebo.depositFunds(4000);
        malebo.createAccount();

    }
}
