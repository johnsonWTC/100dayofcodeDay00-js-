package com.Day07;

public interface ReserveBank {

    void createAccount(String Name, int age);
    void checkBalance();
    void depositFunds(int funds);
    void withDrawFunds();
}
