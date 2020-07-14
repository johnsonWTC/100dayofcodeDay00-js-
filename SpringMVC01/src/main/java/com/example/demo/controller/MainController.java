package com.example.demo.controller;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ResponseBody;

@Controller

public class MainController {
    @ResponseBody
    @GetMapping("test")
    public String hello(){
        System.out.println("we testing");
        return "hello, we are testing";
    }

    @GetMapping("test")
    public  String wellcome(){
return  "welcome";
    }



}
