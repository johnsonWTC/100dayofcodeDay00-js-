package com.javaday00.Day0001;

public class Main {

    public static void main(String[] args) {
        Hero hero = new Hero(3);
        String name = hero.heroMaker();
        System.out.println(name);
    }
}
