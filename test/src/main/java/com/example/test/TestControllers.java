package com.example.test;

import org.springframework.boot.autoconfigure.SpringBootApplication;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;


@Controller
public class TestControllers {

    @GetMapping("/test")
    public String testing(@RequestParam(value = "name", defaultValue = "World") String name){
        return ("hello.jsp");
    }
}
