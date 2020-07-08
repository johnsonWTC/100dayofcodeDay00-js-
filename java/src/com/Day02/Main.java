package com.Day02;

import java.util.Scanner;

public class Main {

    public static void main(String[] args) {
        boolean game = true;
        while(game){
            Scanner scanner = new Scanner(System.in);
            System.out.println("Hello, welcome to our ATM");
            System.out.println("*************************");
            System.out.println("Do you have an account with us?\n"
                    +"1.Yes\n"
                            +"2.No\n");
            int i  = scanner.nextInt();
            System.out.println("What would you like to do?\n"+
            "1.Withdraw Money\n"
            +"2.Deposit funds\n"
            +"3.Create account");
            String name = scanner.nextLine();
            System.out.println("your name is " + name);
            break;
        }
    }
}
