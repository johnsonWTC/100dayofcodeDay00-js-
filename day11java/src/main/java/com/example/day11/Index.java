package com.example.day11;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class Index {

    public String welcome(){
        return "index.html";
    }
    @RequestMapping
    public ModelAndView welcome(@RequestParam(value = "name", defaultValue = "yourName") String name){
        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject(name,name);
        modelAndView.setViewName("welcome.html");
        return modelAndView;

    }

}
