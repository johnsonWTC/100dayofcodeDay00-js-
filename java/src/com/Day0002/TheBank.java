package com.Day0002;

public class TheBank {
    public static void main(String[] args) {
        STDBank johnson = new STDBank("johnson", 30);
        johnson.checkBalance();
        johnson.depositMoney(40000000);
        johnson.openAccount();
        johnson.depositMoney(40000000);

    }
}
