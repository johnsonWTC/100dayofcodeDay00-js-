package com.example.day11;

import org.springframework.stereotype.Controller;

@Controller
public class Index {

    public String welcome(){
        return "index.html";
    }

}
