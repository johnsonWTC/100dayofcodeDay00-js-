package com.example.day12;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller

public class Welcome {
    @RequestMapping("welcome")
    public ModelAndView home(@RequestParam(value = "name", defaultValue = "User") String name){
        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject("name",name);
        modelAndView.setViewName("wel.jsp");
        return modelAndView;
    }
}
