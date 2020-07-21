package com.example.day0500;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class Welcome {
    @RequestMapping("welcome")
    public ModelAndView welcome(@RequestParam(value = "userName", defaultValue = "username") String username){
        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject("name",username);
        modelAndView.setViewName("wel.jsp");
        return modelAndView;
    }
}
