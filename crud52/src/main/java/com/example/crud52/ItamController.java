package com.example.crud52;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class ItamController {

    @Autowired
    ItemService itemService;

    @PostMapping("create")
    public Item createItem (Item item){
        return itemService.saveItem(item);
    }

    @GetMapping("{itemId}")
    public Item getItem(@PathVariable("itemId")  Integer itemId){
        return itemService.geItemByID(itemId);
    }

}
