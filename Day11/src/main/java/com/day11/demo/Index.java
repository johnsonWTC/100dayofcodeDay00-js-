package com.day11.demo;


import org.springframework.stereotype.Controller;

@Controller
public class Index {
    public String index() {
        return "home.html";
    }
}
