package com.example.restful;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.servlet.ModelAndView;

@RestController
@RequestMapping("items")
public class TickingBookingController {

    @Autowired
    private ticketBookingService ticketBookingService;

    @PostMapping("/create")
    public Item createItem(Item item){

        return ticketBookingService.createItem(item);
    }

    @GetMapping("/{itemId}")
    public ModelAndView getItemById(@PathVariable("itemId") Integer itemId){
        ModelAndView modelAndView = new ModelAndView();
        Item item = new Item();
        item =  ticketBookingService.getItemById(itemId);
        modelAndView.addObject("itemId",item.getItemId());
        modelAndView.addObject("itemName",item.getItemName());
        return modelAndView;
    }
}
