package com.example.day012;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class welcome {
    @RequestMapping("welcome")
    public ModelAndView welcome(@RequestParam(value = "items",defaultValue = "item name") String name){
        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject("name", name);
        modelAndView.setViewName("wel.jsp");
        return modelAndView;
    }
}
