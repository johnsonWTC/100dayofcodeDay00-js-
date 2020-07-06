package com.Day0002;

public class TheBank {
    public static void main(String[] args) {
        STDBank johnson = new STDBank("johnson", 30);
        johnson.checkBalance();
        johnson.depositMoney(4000);
        johnson.openAccount();
        johnson.depositMoney(4000000);
        johnson.checkBalance();
        johnson.withDrawMoney(5000);
        johnson.depositMoney(5000);
        johnson.withDrawMoney(4000);

    }
}
