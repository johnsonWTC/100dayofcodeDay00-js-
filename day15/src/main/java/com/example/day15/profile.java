package com.example.day15;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class profile {
    @RequestMapping("profile")
    public ModelAndView profile(@RequestParam(value = "item",defaultValue = "insert item name") String item){
        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject("name",item);
        modelAndView.setViewName("profile.jsp");
        return  modelAndView;
    }
}
