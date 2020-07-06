package com.company;

public class Main {

    public static void main(String[] args) {
        String name = "jam";
        int age = 210;

        MyClass test = new MyClass();
        AgeEvaluator ageEvaluator = new AgeEvaluator(27,"johnson");
        ageEvaluator.nameEvaluator();





    }

    public static  class MyClass {
        public void nameEvaluator(int personsAge) {

            if (personsAge > 21) {
                System.out.println("umdala");
            } else {
                System.out.println("no you are ok");
            }
        }
    }

}
