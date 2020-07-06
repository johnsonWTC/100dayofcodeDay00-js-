package com.Day0001;

public class Hero {
    int random;

    public Hero(int random) {
        this.random = random;
    }

 public  String heroMaker(){
        Integer randomtwo = new Integer(random);
         if(randomtwo.equals(1)){
             return "Johnson";
         } else if (randomtwo.equals(2)) {
             return "Jam";
         }else {
             return "asikwazi";
         }
 }
}