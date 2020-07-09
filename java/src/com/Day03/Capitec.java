package com.Day03;

import java.util.ArrayList;

public class Capitec implements IBank {

    int age;
    String name;
    int accountBalance;
    ArrayList<String> Accounts = new ArrayList();

    @Override
    public void createAccount(String name, int age) {
        if(Accounts.contains(this.name)){
            System.out.println(this.name+ " Already has an account");
        }else if(this.age > 45){
            System.out.println("You are too old this");
        }else{
            Accounts.add(this.name);
            System.out.println("Account has been created for "+ this.name);
        }
    }

    @Override
    public void checkBalance() {
        if(!Accounts.contains(this.name)){
            System.out.println(this.name+ " doesnt have an account with us");
        }else{
            System.out.println("Hello "+this.name+" your balance is "+ accountBalance);
        }
    }

    @Override
    public void depositFunds(int funds) {
        if(!Accounts.contains(this.name)){
            System.out.println(this.name+ "you do not  have an account with us");
        }else if(funds > 50000){
            System.out.println("Please open an investment account");
        }else{
            accountBalance = accountBalance + funds;
            System.out.println("Hello "+this.name + ", "+ funds + " where deposited into your account, your new balance is "+ this.accountBalance);
        }
    }

    @Override
    public void withDrawFunds(int funds) {
        if(!Accounts.contains(this.name)){
            System.out.println(this.name+ " doesnt have an account with us");
        }else if(funds > accountBalance){
            System.out.println("insufficient funds");
        }else{
            accountBalance = accountBalance - funds;
            System.out.println("Hello "+this.name + ", "+ funds + " where withdrawn from your account, your new balance is "+ this.accountBalance);
        }
    }

    class Solution {
        public int findMaxConsecutiveOnes(int[] nums) {
            int sum = 0;
            int count =0;
            int i = 0;
            while(nums.length > i){
                if(nums[i] == 0){
                    if(count > sum){
                        sum = count;
                    }
                    count  = 0;
                    i++;
                }else{
                    count++;
                    i++;
                }
            }
            return  sum;
        }
    }
}
