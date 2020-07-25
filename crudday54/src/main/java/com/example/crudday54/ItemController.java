package com.example.crudday54;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class ItemController {
    @Autowired
    ItemService itemService;

    @PostMapping ("create")
    public Item createItem(Item item){
        return  itemService.createItem(item);
    }

    @GetMapping("{itemID}")
    public Item getItemByID(@PathVariable("itemID") Integer itemID){
        return itemService.findItemBy(itemID);
    }
}
