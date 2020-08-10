package com.example.day70crud;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("items")
public class ItemController {

    @Autowired
    ItemService itemService;

    @PutMapping("{itemID}/{itemName}")
    public Item updateItem(@PathVariable("itemID") Integer itemID, @PathVariable("itemName") String itemName){
        return itemService.updateItem(itemID,itemName);
    }
}
