package com.Day03;

public interface IBank {
    void createAccount(String name, int age);

    void checkBalance();

    void depositFunds(int funds);

    void withDrawFunds(int funds);
}

//class Solution {
//    public int findMaxConsecutiveOnes(int[] nums) {
//        int sum = 0;
//        int count = 0;
//        int i = 0;
//        while(nums.length > i){
//            if(nums[i] == 0){
//                if(count > sum){
//                    sum = count;
//                }
//                count  = 0;
//                i++;
//            }else{
//
//                count++;
//                if(count > sum){
//                    sum = count;
//                }
//                i++;
//            }
//        }
//        if(nums[0] == 1 && nums.length == 1 ){
//            sum = 1;
//        }
//        return sum;
//    }
//}
