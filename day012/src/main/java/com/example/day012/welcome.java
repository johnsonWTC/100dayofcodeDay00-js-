package com.example.day012;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class welcome {
    @GetMapping("welcome")
    public String welcome(){
        return "wel";
    }
}
