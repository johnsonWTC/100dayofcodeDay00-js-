package com.example.day16;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class profile {

    @RequestMapping("profile")
    public ModelAndView proflie(@RequestParam(value = "item", defaultValue = "what is your name vele") String item){
        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject("name",item);
        modelAndView.setViewName("profile.jsp");
        return modelAndView;
    }
}
