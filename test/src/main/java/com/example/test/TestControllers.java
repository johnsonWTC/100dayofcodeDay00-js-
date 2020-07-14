package com.example.test;

import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RestController;


@RestController
public class TestControllers {

    @GetMapping("/test")
    public String testing(){
        return  "Testing again";

    }
}
