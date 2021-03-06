package com.example.restful;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("items")
public class ItemAddingController {



    @Autowired
    private ticketBookingService ticketBookingService;

    @PostMapping("create")
    public Item createItem(Item item){

        return ticketBookingService.createItem(item);
    }

    @GetMapping("{itemId}")
    public Item getItemById(@PathVariable("itemId") Integer itemId){
        return ticketBookingService.getItemById(itemId);
    }

    @DeleteMapping("{itemId}")
        public void deleteItemById(@PathVariable("itemId") Integer itemId){
            ticketBookingService.deleteItemById(itemId);
        }

    @GetMapping("all")
    public Iterable  getAll() {
        return ticketBookingService.getAllItems();
    }

}
