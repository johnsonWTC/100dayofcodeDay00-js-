package com.example.day49;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class profile {
    @RequestMapping("profile")
    public ModelAndView profile(@RequestParam(value = "userName",defaultValue = "what is your name") String userName){
        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject("name",userName);
        modelAndView.setViewName("profile.jsp");
        return modelAndView;
    }
}
