package com.Day02;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        boolean game = true;
        while (game) {
            Scanner scanner = new Scanner(System.in);
            System.out.println("Hello, welcome to our ATM");
            System.out.println("*************************");
            System.out.println("Do you have an account with us?\n"
                    + "1.Yes\n"
                    + "2.No\n");
            Integer i = scanner.nextInt();
            if (i.equals(2)) {
                System.out.println("******create account******");
                System.out.println("what is you name");
                String name = scanner.next();
                System.out.println("Hello "name +" what is your age");
                Integer age = scanner.nextInt();
                IBank client = new Capitec(age, name);
                client.createAccount();
                System.out.println("What would you like to do?\n" +
                        "1.Deposit Money\n"
                        + "2.withdraw funds\n");
                    i = scanner.nextInt();
                    if(i.equals(1)){
                        System.out.println("How much would you like to deposit");
                        int funds = scanner.nextInt();
                        client.depositFunds(funds);
                    }
                break;
            }
        }
    }
}
