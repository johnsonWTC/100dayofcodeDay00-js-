package com.example.day11;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;
@Controller
public class welcome {

    @RequestMapping("profile")
    public ModelAndView welcome(@RequestParam(value = "item", defaultValue = "yourName") String name){
        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject("name",name);
        modelAndView.setViewName("jam.jsp");
        return modelAndView;

    }
}
