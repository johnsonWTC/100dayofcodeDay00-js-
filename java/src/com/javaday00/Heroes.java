package com.javaday00;

public class Heroes {
    int random;

    public Heroes(int i) {
        this.random = i;
    }


    public String herroType() {
        Integer value = random;
        if (value.equals(1)) {
            return "Hulk";
        } else if (value.equals(2)) {
            return "Captain America";
        } else if (value.equals(3)) {
            return "winter soldier";
        } else return "Jam";
    }
}
