package com.example.day14;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class welcome {
    @RequestMapping("welcome")
    public ModelAndView welcome(@RequestParam(value = "item", defaultValue = "Please insert name") String item){

        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject("name", item);
        modelAndView.setViewName("wel.jsp");
        return modelAndView;
    }
}
