package com.example.day502;


import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.servlet.ModelAndView;

@Controller
public class Shop {
@RequestMapping("shop")
    public ModelAndView shop(@RequestParam(value = "itemName", defaultValue = "the item name goes here") String item){
        ModelAndView modelAndView = new ModelAndView();
        modelAndView.addObject("shopItem",item);
        modelAndView.setViewName("shop.jsp");
        return  modelAndView;
    }
}
