package com.example.restfulday54;


import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class ItemController {

    @Autowired
    ItemService itemService;

    @GetMapping("{newItemId}")
    public Item findItemById(@PathVariable("newItemId") Integer newItemId){
        return itemService.findbyId(newItemId);
    }
}
