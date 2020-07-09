package com.Day03;

public interface IBank {
    void createAccount(String name, int age);
    void checkBalance();
    void depositFunds(int funds);
    void withDrawFunds(int funds);
}
